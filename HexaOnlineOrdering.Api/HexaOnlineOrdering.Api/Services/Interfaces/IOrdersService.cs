using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IOrdersService
    {
        OrderModel GetOrder(int orderId);
        Task<int> DeleteOrder(int orderId );
        Task<OrderWithLengthModel> GetOrderListByClinictId(int clinicId
            , DateTime from
            , DateTime to
            , int[] status
            , int searchType
            , string searchStr
            , int page
            , int pageSize
            , int dentistId
            , int productTypeId
            , string sortOrder);

        Task<OrderWithLengthModel> GetOrderListByDentistId(int dentistId
            , DateTime from
            , DateTime to
            , List<int> status
            , int searchType
            , string searchStr
            , int page
            , int pageSize
            , int clinicId
            , int productTypeId
            , string sortOrder);

        Task<DisplayOrderDetail> GetOrderDetailById(int orderId);

        Task<int> CancelOrder(int orderId);



        Task<OrderModel> CreateOrder(int caseId, string referenceNumber, DateTime? EstimatedDate, bool isNotification = false);

        Task<string> GetNewOrderReferenceNumber(bool isSitMode);

        Task<DashboardModel> GetClinicDashboard(int clinicId, DateTime startDate, DateTime endDate, int dentistId);
        Task<DashboardModel> GetDentistDashboard(int dentistId, DateTime startDate, DateTime endDate, int clinicId);

        Task<OrderDetailModel> GetOrderByReference(string reference);

        Task<OrderDetailModel> GetOrderByCaseId(int caseId);

        Task UpdateOrderStatus(int orderId, int statusId);

        Task<OrderModel> UpdateOrderStatusIcharm(int caseId, int statusId, bool isNotification);

        Task<OrderModel> UpdateOrderIsNotification(int orderId, bool isNotification);

        Task<OrderWithLengthModel> GetAllOrders(OrderFilterModel orderFilter,List<int> adminPermission);

        Task<List<AdminReportModel>> GetOrdersReport(OrderFilterModel orderFilter, List<int> adminPermission);

        Task<DashboardModel> GetAdminDashboard(DateTime startDate, DateTime endDate);

        Task<string> UpdateEstimatedDate(UpdateEstimatedDateRequest model);

        Task<List<DisplayOrder>> GetPrintingOrderList(List<int> orderIds);
        byte[] GetOrderPDFBuffer(List<DisplayOrder> orderData);

    }
}
