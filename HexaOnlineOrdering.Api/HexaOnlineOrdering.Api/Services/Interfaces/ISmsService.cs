using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface ISmsService
    {
        public Task<bool> SendSMS(string phoneNo, int caseId);
    }
}
