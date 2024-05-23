using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Repositories.DataAccess;
using HexaOnlineOrdering.Repositories.MarketingDataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IMarketingMemberRepository : IEntityBaseRepository<Member, MarketingDBContext>
    {
        Task<MarketingMemberModel> GetMemberByCustomerIdAndType(int customerId, string type);
        Task<MarketingMemberModel> GetMemberByCustomerId(int customerId);
        Task<List<MarketingZoneMemberModel>> GetZoneOfMemberId(int memberId);
        Task<List<MarketingMemberModel>> GetMembersInZone(int zoneId);
    }
}
