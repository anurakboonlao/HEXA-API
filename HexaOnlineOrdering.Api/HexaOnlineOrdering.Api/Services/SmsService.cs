using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class SmsService : ISmsService
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly SmsSetting _smsOption;
        private string url;
        private string username;
        private string password;
        private string sender;
        private string force;
        private bool shorten_url;
        private string linkPath;

        public SmsService(IOptions<SmsSetting> smsOption)
        {
            _smsOption = smsOption != null ? smsOption.Value : throw new ArgumentNullException(nameof(smsOption));
            username = _smsOption.Username;
            password = _smsOption.Password;
            sender = _smsOption.Sender;
            force = _smsOption.Force;
            shorten_url = _smsOption.Shorten_url;
            url = _smsOption.Url;
            linkPath = _smsOption.LinkPath;
        }

        public async Task<bool> SendSMS(string phoneNo, int caseId)
        {
            string message = "แจ้งเลื่อนงาน" + Environment.NewLine + "รายละเอียด Click " + linkPath + caseId;

            var data = new { msisdn = phoneNo, message = message, sender = sender, force = force, shorten_url = shorten_url };
            string jsonData = JsonConvert.SerializeObject(data);

            byte[] byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
            requestMessage.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.SendAsync(requestMessage);
            return response.IsSuccessStatusCode;
        }
    }
}
