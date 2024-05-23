using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Models.Message;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class LineService : ILineService
    {
        private readonly IOptions<LineConfiguration> _lineConfiguration;
        private readonly ILogger<OrdersService> _logger;
        private readonly Line.LineBot _line;
        private readonly IMarketingMemberRepository _marketingMemberRepository;

        public LineService(ILogger<OrdersService> logger, IOptions<LineConfiguration> lineConfiguration, IMarketingMemberRepository marketingMemberRepository)
        {
            _logger = logger;
            _lineConfiguration = lineConfiguration;
            _line = InitLineBot();
            _marketingMemberRepository = marketingMemberRepository;
        }

        public async Task<bool> SendLineNotification(string message, string lineUserId)
        {
            try
            {
                _logger.LogInformation($"Send Line notification to lineUserId");
                Line.ISendMessage textMessage = new Line.TextMessage(message);
                await _line.Push(lineUserId, textMessage);

                return true;
            }
            catch(Exception ex)
            {
                _logger.LogError("Send Line notification error " + ex.Message);
                return false;
            }
        }

        public async Task SendNotificationToSale(DisplayCaseModel caseData)
        {
            //get member id
            MarketingMemberModel clinicData = await _marketingMemberRepository.GetMemberByCustomerId(caseData.ClinicId);
            //clinic no data
            if (clinicData == null)
                return;

            List<MarketingZoneMemberModel> zoneMember = await _marketingMemberRepository.GetZoneOfMemberId((int)clinicData.Id);
            //clinic no zone
            if (zoneMember == null || zoneMember.Count == 0)
                return;


            List<MarketingZoneModel> zones = zoneMember.Select(zm => zm.Zone).ToList();
            if (zones == null || zones.Count == 0)
                return;

            Dictionary<string, List<MarketingMemberModel>> saleInZone = new Dictionary<string, List<MarketingMemberModel>>();

            //get sale in zone
            foreach (MarketingZoneModel zone in zones)
            {
                List<MarketingMemberModel> zMembers = await _marketingMemberRepository.GetMembersInZone((int)zone.Id);
                if(zMembers != null)
                {
                    List<MarketingMemberModel> staffList = zMembers.Where(zm => zm.Type == "staff" && !string.IsNullOrEmpty(zm.LineUserId)).ToList();
                    if (staffList?.Count > 0)
                    {
                        if (!saleInZone.ContainsKey(zone.Name))
                        {
                            saleInZone.Add(zone.Name, staffList);
                        }
                        else
                        {
                            List<MarketingMemberModel> temp = saleInZone[zone.Name];
                            temp.AddRange(staffList);
                            saleInZone[zone.Name] = temp;
                        }
                    }
                }
            }

            if (saleInZone.Count == 0)
                return;

            MessageUtil messageUtil = new MessageUtil();

            LineSaleMessageModel messageModel = new LineSaleMessageModel();
            messageModel.PatientName = caseData.PatientName;
            messageModel.ClinicName = caseData.ClinicName;
            messageModel.DoctorName = caseData.DentistName;
            messageModel.PickUpDate = caseData.PickupDate;

            if (caseData.CaseOrderLists != null)
            {
                Dictionary<string, int> productTypeDic = caseData.CaseOrderLists.GroupBy(item => item.ProductType)
                .Select(group => new { type = group.Key, count = group.Count() })
                .ToDictionary(t => t.type, t => t.count);
                messageModel.ProductTypeCount = productTypeDic;
            }

            foreach (KeyValuePair<string, List<MarketingMemberModel>> zone in saleInZone)
            {
                messageModel.ZoneName = zone.Key;
                string message = messageUtil.GenerateSaleLineMessage(messageModel);
                await SendLineZoneStaff(message, zone.Value);
            }
                    
        }

        private async Task SendLineZoneStaff(string message, List<MarketingMemberModel> members)
        {
            if(members?.Count() > 0)
            {
                foreach (MarketingMemberModel member in members)
                {
                    await SendLineNotification(message, member.LineUserId);
                } 
            }
        }

        private Line.LineBot InitLineBot()
        {
            Line.LineConfiguration cl = new Line.LineConfiguration();
            cl.ChannelAccessToken = _lineConfiguration.Value.ChannelAccessToken;
            cl.ChannelSecret = _lineConfiguration.Value.ChannelSecret;
            Line.LineBot line = new Line.LineBot(cl);
            return line;
        }
    }
}
