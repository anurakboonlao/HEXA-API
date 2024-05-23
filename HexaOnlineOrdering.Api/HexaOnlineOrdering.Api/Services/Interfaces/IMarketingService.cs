using System;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models.Marketing;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IMarketingService
    {
        Task<MarketingMemberModel> GetMemberByCustomerIdAndType(int customerId, string type);
        Task<MarketingMemberModel> GetMemberByCustomerId(int customerId);
    }
}
