using System;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface ILineService
    {
        Task<bool> SendLineNotification(string message, string lineUserId);
        Task SendNotificationToSale(DisplayCaseModel caseData);
    }
}
