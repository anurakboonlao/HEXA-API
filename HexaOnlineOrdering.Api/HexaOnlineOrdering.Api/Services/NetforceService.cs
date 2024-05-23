using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.ERP.Models;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.ERP;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class NetforceService : INetforceService
    {
        #region Fields
        private readonly IHttpClientService _httpClientService;
        private readonly NetforceSetting _netforceOption;
        private const string _productTable = "product";
        private const string _shopTable = "pos.shop";
        private const string _dentalTypeTable = "dental.type";
        private const string _conactTable = "contact";
        private const string _doctorTable = "doctor";
        private const string _addressTable = "address";
        private const string _saleOrderTable = "sale.order";
        private const string _queryMethod = "search_read";
        #endregion

        public NetforceService(IHttpClientService httpClientService, IOptions<NetforceSetting> netforceOption)
        {
            _httpClientService = httpClientService ?? throw new ArgumentNullException(nameof(httpClientService));
            _netforceOption = netforceOption != null ? netforceOption.Value : throw new ArgumentNullException(nameof(netforceOption));
        }

        public async Task<ProductModel> GetProductByIdAsync(int id)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "name", "code" };

            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.EQUAL], id });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _productTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ProductModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result.Count > 0 ? response.Result[0] : null;
        }

        public async Task<List<ProductModel>> GetProductsAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "name", "code" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _productTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ProductModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task<List<DentalTypeModel>> GetDentalTypesAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "sequence", "name", "type", "code", "notes" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _productTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<DentalTypeModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public Task<DentalTypeModel> GetDentalTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShopModel>> GetShopsAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "name", "address_text", "disc_account_id", "shop_no" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _shopTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ShopModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task<ShopModel> GetShopByIdAsync(int id)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "name", "address_text", "disc_account_id", "shop_no" };

            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.EQUAL], id });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _shopTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ShopModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result.Count > 0 ? response.Result[0] : null;
        }

        public async Task<List<ContactModel>> GetContactsAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "active", "name", "type" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _conactTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ContactModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task<ContactModel> GetContactByIdAsync(int id)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "active", "name", "type", "doctor_ids" };


            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.EQUAL], id });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _conactTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ContactModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result.Count > 0 ? response.Result[0] : null;
        }

        public async Task<List<ERP.Models.DoctorModel>> GetDoctorsAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "active", "name", "code" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _doctorTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ERP.Models.DoctorModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task<ERP.Models.DoctorModel> GetDoctorByIdAsync(int id)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "active", "name", "code", "contact_ids" };

            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.EQUAL], id });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _doctorTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ERP.Models.DoctorModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result.Count > 0 ? response.Result[0] : null;
        }

        public async Task<List<AddressModel>> GetAddressesAsync(List<QueryConditional> conditions)
        {
            List<object> args = new List<object>();
            List<object[]> predicates = new List<object[]>();
            string[] columns = new string[] { "address", "city", "phone", "fax", "email" };

            foreach (var condition in conditions)
            {
                predicates.Add(new object[] { condition.FieldName, NetforceQueryOperator.Operators[condition.Operator], condition.Value });
            }

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _addressTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<AddressModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);
            return response.Result;
        }

        public async Task<AddressModel> GetAddressByIdAsync(string id)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "address", "city", "phone", "fax", "email" };


            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.EQUAL], id });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _addressTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<AddressModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result.Count > 0 ? response.Result[0] : null;
        }

        public async Task CreateSaleOrdersAsync(List<SaleOrderModel> saleOrders)
        {
            List<object> args = new List<object>();
            foreach (var saleOrder in saleOrders)
            {
                args.Add(saleOrder);
            }

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _saleOrderTable, "create_api_work_order", args };

            var response = await _httpClientService.PostAsync<NetforceResponseModel, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);
            else if (response.Result != "200")
            {
                if (response.Result == "417")
                    throw new HexaDomainException("Error on ERP api while create sale orders");

                else
                    throw new HexaDomainException($"Error on ERP api because {response.Result}");
            }
        }

        public async Task<List<SaleOrderStatusModel>> GetSaleOrderStatusByReferencesAsync(List<string> refs)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "ref", "store_work_state" };

            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "sale_type", NetforceQueryOperator.Operators[OperatorType.EQUAL], "work_order" });
            predicates.Add(new object[] { "ref", NetforceQueryOperator.Operators[OperatorType.IN], refs });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _saleOrderTable, _queryMethod, args };

            // response will return with only matched cases.
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<SaleOrderStatusModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            List<SaleOrderStatusModel> refStatuses = new List<SaleOrderStatusModel>();
            foreach (var refCode in refs)
            {
                SaleOrderStatusModel saleOrderStatus = response.Result.SingleOrDefault(c => c.Reference == refCode);
                if (saleOrderStatus == null)
                    refStatuses.Add(new SaleOrderStatusModel() { Reference = refCode });
                else
                    refStatuses.Add(saleOrderStatus);
            }

            return refStatuses;
        }

        public async Task<List<ContactModel>> GetContactByIdsAsync(List<int> ids)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "active", "name", "type" };


            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.IN], ids });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _conactTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ContactModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task<List<ERP.Models.DoctorModel>> GetDoctorByIdsAsync(List<int> ids)
        {
            List<object> args = new List<object>();
            string[] columns = new string[] { "active", "name", "code" };

            List<object[]> predicates = new List<object[]>();
            predicates.Add(new object[] { "id", NetforceQueryOperator.Operators[OperatorType.IN], ids });

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(predicates);
            args.Add(columns);

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _doctorTable, _queryMethod, args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel<List<ERP.Models.DoctorModel>>, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Error != null)
                throw new HexaDomainException(response.Error.Message);

            return response.Result;
        }

        public async Task CancelOrder(string referenceCode)
        {
            List<object> args = new List<object>();

            // Order must be,
            // [0] The conditions.
            // [1] The return fields.
            args.Add(new SaleOrderCancelModel() { Reference = referenceCode });

            NetforceRequestModel payload = new NetforceRequestModel();
            payload.Id = _netforceOption.Id;
            payload.Method = _netforceOption.Method;
            payload.DBName = _netforceOption.Database;
            payload.UserId = _netforceOption.UserId;
            payload.CompanyId = _netforceOption.CompanyId;
            payload.ParamList = new object[] { _saleOrderTable, "void_api_work_order", args };
            var response = await _httpClientService.PostAsync<NetforceResponseModel, NetforceRequestModel>(_netforceOption.ApiUrl, payload);
            if (response.Result != "successfully")
                throw new HexaDomainException(response.Result ?? $"Reference code {referenceCode} not found");

        }
    }
}
