using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Repositories.DataAccess;
using HexaOnlineOrdering.Repositories.Interfaces;
using HexaOnlineOrdering.Repositories.MarketingDataModels;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories
{
    public class MarketingMemberRepository : EntityBaseRepository<Member, MarketingDBContext>, IMarketingMemberRepository
    {
        private readonly MarketingDBContext _dbContext;
        private readonly IMapper _mapper;

        public MarketingMemberRepository(MarketingDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<MarketingMemberModel> GetMemberByCustomerIdAndType(int customerId, string type)
        {
            var members = await _dbContext.Members.Where(c => c.CustomerId == customerId.ToString() && c.Type == type && c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToListAsync();
            if (members.Count >= 1)
            {
                return _mapper.Map<Member, MarketingMemberModel>(members[0]);
            }

            return null;
        }

        public async Task<MarketingMemberModel> GetMemberByCustomerId(int customerId)
        {
           Member member = await _dbContext.Members
                .Where(c => c.CustomerId == customerId.ToString() && c.DeletedAt == null).FirstOrDefaultAsync();
            if (member != null)
            {
                return _mapper.Map<Member, MarketingMemberModel>(member);
            }

            return null;
        }

        public async Task<List<MarketingZoneMemberModel>> GetZoneOfMemberId(int memberId)
        {

            List<ZoneMember> zoneMembers = await _dbContext.ZoneMembers
                .Include(zm => zm.Zone)
                .Include(zm => zm.Member)
                .Where(zm => zm.MemberId == memberId && zm.DeletedAt == null).ToListAsync();

            List<MarketingZoneMemberModel> result = new List<MarketingZoneMemberModel>();
            if (zoneMembers?.Count > 0)
            {
                foreach (ZoneMember zoneMember in zoneMembers)
                { 
                    MarketingZoneMemberModel resultItem = _mapper.Map<ZoneMember, MarketingZoneMemberModel>(zoneMember);
                    result.Add(resultItem);
                }
            }

            return result;

        }

        public async Task<List<MarketingMemberModel>> GetMembersInZone(int zoneId)
        {

            List<ZoneMember> zoneMembers = await _dbContext.ZoneMembers
                .Include(zm => zm.Member)
                .Where(zm => zm.ZoneId == zoneId && zm.DeletedAt == null).ToListAsync();

            List<MarketingMemberModel> members = new List<MarketingMemberModel>();
            if (zoneMembers?.Count > 0)
            {
                foreach (ZoneMember zoneMember in zoneMembers)
                {
                    if(zoneMember.Member != null)
                    {
                        MarketingMemberModel member = _mapper.Map<Member, MarketingMemberModel>(zoneMember.Member);
                        members.Add(member);
                    }
                }
                 
            }
            return members;
        }
    }
}
