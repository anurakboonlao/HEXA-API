using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Orders;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IOrderOverviewRepository : IEntityBaseRepository< TblOrder, HexaDBContext>
    {
        Task<int> DeleteOrderById(int orderId);
        Task<List<DisplayOrder>> GetClinicOrders(int clinicId
            , DateTime from
            , DateTime to
            , int status
            , int searchType
            , string searchStr
            , int page
            , int dentistId);
        Task<List<DisplayOrder>> GetDentistOrders(int dentistId
            , DateTime from
            , DateTime to
            , int status
            , int searchType
            , string searchStr
            , int page
            , int clinicId);

        Task<List<DisplayOrder>> GetDentistOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, List<int> status, int dentistId, int clinicId);
        Task<List<DisplayOrder>> GetClinicOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, List<int> status, int clinicId, int dentistId);

        Task<List<CaseItemModel>> GetOrderSmallDetailList(int orderId);

        Task<OrderDetailModel> GetOrderDetail(int orderId);
        Task<OrderDetailModel> GetOrderDetail(string referenceNumber);
        Task<OrderDetailModel> GetOrderDetailByCasedId(int caseId);
        Task<OrderDetailModel> ShowNotificationByCasedId(int caseId);

        Task<int> CancelOrder(int orderId);

        Task<int> GetCurrentReferenceNumber(DateTime currentDate);

        Task<List<TblOrder>> GetClinicOrderForDashboard(int clinicId, DateTime startDate, DateTime endDate, int dentistId);
        Task<List<TblOrder>> GetDentistOrderForDashboard(int dentistId, DateTime startDate, DateTime endDate, int clinicId);

        Task<List<TblOrder>> GetOrderForAdminDashboard( DateTime startDate, DateTime endDate);

        Task<int> GetCaseIdByOrderId(int orderId);

        Task<List<DisplayOrder>> GetOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, int[] status);

        Task<List<AdminReportModel>> GetOrdersReportFilterByDate(DateTime fromDate, DateTime toDate, int[] status, List<int> adminPermission);
        Task<DateTime?> CalculateEstimatedDate(int orderId);

        Task<TblOrder> UpdateEstimatedDate(int orderId,DateTime estimatedDate);

        Task<List<DisplayOrder>> GetOrderDisplayByIds(List<int> orderIds);
    }

    public enum OrderStatusEnum
    {
        // NOTE: we use same number with status id of ERP
        all = 0,
        draft = 1,
        waitingOrder = 2,
        ordered = 3,
        delivery = 5,
        completed = 6,
        reject = 7,

        // NOTE: we group waitingOrder and draft 
        waitingOrDraft = 8,
        canceled = 4,
    }

    public enum IcharmOrderStatusEnum
    {
        Draft = 1,
        WaitingOrder = 2,
        Ordered = 3,
        Delivery = 5,
        Completed = 6,
        Reject = 7,

        Canceled = 4,
        Step1 = 8,
        CustomerConfirmStep2 = 10,
        Step2 = 9,
    }

    public enum SearchRoleEnum
    {
        all = 0,
        doctor = 1,
        clinic = 2,
        patientName = 3,
        orderRef = 4
    }
}
