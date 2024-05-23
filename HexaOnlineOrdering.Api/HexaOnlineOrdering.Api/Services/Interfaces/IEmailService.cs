using HexaOnlineOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(EmailModel emailModel);
    }
}
