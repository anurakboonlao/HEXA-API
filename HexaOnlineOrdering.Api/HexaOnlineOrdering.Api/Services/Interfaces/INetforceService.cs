using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.ERP.Models;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.ERP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface INetforceService
    {
        Task<List<ProductModel>> GetProductsAsync(List<QueryConditional> conditions);

        Task<ProductModel> GetProductByIdAsync(int id);

        Task<List<DentalTypeModel>> GetDentalTypesAsync(List<QueryConditional> conditions);

        Task<DentalTypeModel> GetDentalTypeByIdAsync(int id);

        Task<List<ShopModel>> GetShopsAsync(List<QueryConditional> conditions);

        Task<ShopModel> GetShopByIdAsync(int id);

        Task<List<ContactModel>> GetContactsAsync(List<QueryConditional> conditions);

        Task<ContactModel> GetContactByIdAsync(int id);

        Task<List<ContactModel>> GetContactByIdsAsync(List<int> ids);

        Task<List<ERP.Models.DoctorModel>> GetDoctorsAsync(List<QueryConditional> conditions);

        Task<ERP.Models.DoctorModel> GetDoctorByIdAsync(int id);

        Task<List<ERP.Models.DoctorModel>> GetDoctorByIdsAsync(List<int> ids);

        Task<List<AddressModel>> GetAddressesAsync(List<QueryConditional> conditions);

        Task<AddressModel> GetAddressByIdAsync(string id);

        Task CreateSaleOrdersAsync(List<SaleOrderModel> saleOrders);

        Task<List<SaleOrderStatusModel>> GetSaleOrderStatusByReferencesAsync(List<string> refs);

        Task CancelOrder(string referenceCode);
    }
}
