using System;
using System.Threading.Tasks;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Repositories.Interfaces;

namespace HexaOnlineOrdering.Api.Services
{
    public class MarketingService : IMarketingService
    {
        private readonly IMarketingMemberRepository _marketingMemberRepo;


        public MarketingService(IMarketingMemberRepository marketingMemberRepo)
        {
            _marketingMemberRepo = marketingMemberRepo ?? throw new ArgumentNullException(nameof(marketingMemberRepo));
        }

        public async Task<MarketingMemberModel> GetMemberByCustomerIdAndType(int customerId, string type)
        {
            return await _marketingMemberRepo.GetMemberByCustomerIdAndType(customerId, type);
        }

        public async Task<MarketingMemberModel> GetMemberByCustomerId(int customerId)
        {
            return await _marketingMemberRepo.GetMemberByCustomerId(customerId);
        }
    }
}
