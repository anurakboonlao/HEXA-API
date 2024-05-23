using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Models.ERP;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Models.Case;

namespace HexaOnlineOrdering.Api.Controllers
{

    [Authorize(Roles = "Dentist,Clinic")]
    [Route("api/[controller]")]
    public class CaseController : BaseController
    {
        private readonly Mode _mode;
        private readonly IProductService _productService;
        private readonly INetforceService _netforceService;
        private readonly ICaseService _caseService;
        private readonly IOrdersService _orderService;
        private readonly IAWS3service _aws3service;
        private readonly ILineService _lineService;

        public CaseController(IHttpContextAccessor httpContextAccessor, ICaseService caseService, IProductService productService, INetforceService netforceService, IOrdersService orderService , IAWS3service aws3Service, IOptions<Mode> mode, ILineService lineService) : base(httpContextAccessor)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
            _caseService = caseService ?? throw new ArgumentNullException(nameof(caseService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _aws3service = aws3Service ?? throw new ArgumentNullException(nameof(aws3Service));
            _lineService = lineService ?? throw new ArgumentNullException(nameof(lineService));
            _mode = mode.Value;
        }

        [HttpPost("AddNewCase")]
        public async Task<IActionResult> AddNewCase([FromBody] DisplayCaseModel caseData)
        {
            if(caseData == null)
            {
                throw new HexaDomainException("Model is null");
            }
            else if (caseData.CaseOrderLists == null || (caseData.CaseOrderLists != null && caseData.CaseOrderLists.Count == 0))
            {
                throw new HexaDomainException("No product in request");
            }
            else
            {
                CaseModel result = await _caseService.SaveCase(caseData);
                if (result != null)
                {
                    return Ok(result);
                }  
                else
                {
                    throw new HexaDomainException("Save failed");
                }    
            }
            
        }

        [HttpPost("AddDraftCase")]
        public async Task<int> AddDraftCase([FromBody] DraftCaseModel caseData)
        {
            if (caseData == null)
            {
                throw new HexaDomainException("Model is null");
            }
            else
            {
                int result = await _caseService.SaveCase(caseData);
                if (result > 0)
                    return result;
                else
                    throw new HexaDomainException("Save Draft failed");
            }
        }

        [HttpPut("UpdateCase")]
        public async Task<IActionResult> UpdateCase([FromBody] DisplayCaseModel caseData)
        {
            if (caseData == null)
            {

                throw new HexaDomainException("Model is null");
            }
            else if (caseData.CaseOrderLists == null || (caseData.CaseOrderLists != null && caseData.CaseOrderLists.Count == 0))
            {
                throw new HexaDomainException("No product in request");
            }
            else
            {
                CaseModel result = await _caseService.UpdateCase(caseData);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    throw new HexaDomainException("Save failed");
                }
                    
            }

        }

        [HttpDelete("Delete/{caseId}")]
        public async Task<IActionResult> DeleteCase([FromRoute] int caseId)
        {
            // Check case has ordered
            var ordered = await _caseService.FindCaseHasOrderByCaseId(caseId);
            if (ordered != null)
                throw new HexaDomainException("Cannot delete an ordered case");

            await _caseService.DeleteCaseById(caseId);
            return Ok(caseId);
        }
       
        [HttpGet("GetCaseListByClinicId/{clinicId}")]
        public async Task<CaseManageModel> GetCaseListByClinicId([FromRoute] int clinicId, DateTime startDate, DateTime endDate, int dentistId,int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField,string filterText, int caseTypeId, int productTypeId)
        {
            return await _caseService.GetCaseListByClinicId(clinicId, startDate, endDate, dentistId, statusId, page, pageSize, sortField, sortOrder, filterField, filterText, caseTypeId, productTypeId);
        }

        [HttpGet("GetCaseListByDentistId/{dentistId}")]
        public async Task<CaseManageModel> GetCaseListByDentistId([FromRoute] int dentistId, DateTime startDate, DateTime endDate, int clinicId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId)
        {
            return await _caseService.GetCaseListByDentistId(dentistId, startDate, endDate, clinicId, statusId, page, pageSize, sortField, sortOrder, filterField, filterText, caseTypeId, productTypeId);
        }

        [HttpGet("GetCaseByCaseId/{caseId}")]
        public async Task<DisplayCaseModel> GetCaseByCaseId([FromRoute] int caseId)
        {
            return await _caseService.GetCaseByCaseId(caseId);
        }

        [HttpPost("CreateSaleOrders")]
        public async Task<IActionResult> CreateSaleOrders([FromBody] OpenOrderRequest saleOrderRequest)
        {
            if (saleOrderRequest == null || saleOrderRequest?.CaseId < 1)
                throw new HexaDomainException("Bad request no case");

            //save request date
            DateTime? request = saleOrderRequest.RequestDate.HasValue ? saleOrderRequest.RequestDate.Value.Date : null;
            bool updateRequestDatePass = await _caseService.SaveRequestDate(saleOrderRequest.CaseId, request);
            if (!updateRequestDatePass)
                throw new HexaDomainException("Update Request Date before create order failed");
            else
            {
                SaleOrderModel saleOrder = await GenerateSaleOrderModel(saleOrderRequest.CaseId);
                if (saleOrder != null)
                {
                    await _netforceService.CreateSaleOrdersAsync(new List<SaleOrderModel>() { saleOrder });
                    await _orderService.CreateOrder(saleOrderRequest.CaseId, saleOrder.Reference, saleOrder.DueDate);
                    await _caseService.UpdateCaseStatusToOrder(saleOrderRequest.CaseId);
                    await _lineService.SendNotificationToSale(await _caseService.GetCaseByCaseId(saleOrderRequest.CaseId));
                }
            }
            return Ok(true);
        }

        [HttpPost("AddNewCaseAndOrder")]
        public async Task<IActionResult> AddNewCaseAndOrder([FromBody] DisplayCaseModel caseData)
        {
            if (caseData == null)
            {
                throw new HexaDomainException("Model is null");
            }
            else if (caseData.CaseOrderLists == null || (caseData.CaseOrderLists != null && caseData.CaseOrderLists.Count == 0))
            {
                throw new HexaDomainException("No product in request");
            }
            else
            {
                CaseModel result = await _caseService.SaveCase(caseData);
                if (result != null)
                {
                    SaleOrderModel saleOrder = await GenerateSaleOrderModel(result.Id);
                    if (saleOrder != null)
                    {
                        await _netforceService.CreateSaleOrdersAsync(new List<SaleOrderModel>() { saleOrder });
                        await _orderService.CreateOrder(result.Id, saleOrder.Reference, saleOrder.DueDate);
                        await _caseService.UpdateCaseStatusToOrder(result.Id);
                        await _lineService.SendNotificationToSale(await _caseService.GetCaseByCaseId(result.Id));

                        return Ok(true);
                    }
                    else
                        throw new HexaDomainException("Save case completed, but create save order failed");
                }
                else
                    throw new HexaDomainException("Save failed");
            }

        }

        [HttpPut("UpdateCaseAndOrder")]
        public async Task<IActionResult> UpdateCaseAndOrder([FromBody] DisplayCaseModel caseData)
        {
            if (caseData == null)
            {
                throw new HexaDomainException("Model is null");
            }
            else if (caseData.CaseOrderLists == null || (caseData.CaseOrderLists != null && caseData.CaseOrderLists.Count == 0))
            {
                throw new HexaDomainException("No product in request");
            }
            else
            {
                CaseModel result = await _caseService.UpdateCase(caseData);
                Boolean isNotification = caseData.CaseOrderLists.First().ProductType.ToLower() == ProductType.ICHARM.ToString().ToLower();

                if (result != null)
                {
                    SaleOrderModel saleOrder = await GenerateSaleOrderModel(result.Id);
                    if (saleOrder != null)
                    {                
                        await _netforceService.CreateSaleOrdersAsync(new List<SaleOrderModel>() { saleOrder });
                        await _orderService.CreateOrder(result.Id, saleOrder.Reference, saleOrder.DueDate, isNotification);
                        await _caseService.UpdateCaseStatusToOrder(result.Id);
                        await _lineService.SendNotificationToSale(await _caseService.GetCaseByCaseId(result.Id));
                        return Ok(true);
                    }
                    else
                        throw new HexaDomainException("Save case completed, but create save order failed");
                }
                else
                    throw new HexaDomainException("Save failed");
            }

        }

        [HttpGet("GetSaleOrderStatus")]
        public async Task<List<SaleOrderStatusModel>> CreateSaleOrders(string refCode)
        {
            var result = await _netforceService.GetSaleOrderStatusByReferencesAsync(new List<string>() { refCode });
            return result;
        }

        private async Task<SaleOrderModel> GenerateSaleOrderModel(int caseId)
        {
            string _MAXILLA = "Maxilla";
            string _MANDIBLE = "Mandible";
            SaleOrderModel saleOrder = new SaleOrderModel();
            DisplayCaseModel caseModel = await _caseService.GetCaseByCaseId(caseId);

            if (caseModel != null)
            {
                if(caseModel.OrderId > 0 || !string.IsNullOrEmpty(caseModel.OrderRefNumber))
                    throw new HexaDomainException(string.Format("This case has been ordered with order number ({0})", caseModel.OrderRefNumber));

                saleOrder.DoctorId = caseModel.DentistId;
                saleOrder.ClinicId = caseModel.ClinicId;
                saleOrder.Patient = caseModel.PatientName;

                bool isSitMode = false;
                if (!string.IsNullOrEmpty(_mode.IsSitMode) && _mode.IsSitMode.ToLower() == "true")
                    isSitMode = true;
                saleOrder.Reference = await _orderService.GetNewOrderReferenceNumber(isSitMode);
                saleOrder.Comments = caseModel.Memo;
                saleOrder.CaseType = GetCaseTypeEnumById(caseModel.CaseTypeId);
                saleOrder.OrderDate = DateTime.Now;
                saleOrder.FromOrderReference = caseModel.ReferenceOrderNumber;

                if (caseModel.AttachedFileList?.Count > 0)
                    saleOrder.Files = caseModel.AttachedFileList.Select(f => _aws3service.GenerateAwsFileUrl(f.FilePath)).ToList();
                if (caseModel.RequestDate.HasValue)
                    saleOrder.DateRequired = caseModel.RequestDate.Value;
                saleOrder.DueDate = caseModel.EstimatedDate;

                List<string> lableAddon = new List<string>();
                if (caseModel.CaseOrderLists?.Count > 0)
                {
                    Dictionary<ProductType, SaleOrderMainProduct> mainProductDic = new Dictionary<ProductType, SaleOrderMainProduct>();
                    Dictionary<string, List<string>> bridgeDic = new Dictionary<string, List<string>>();
                    foreach (CaseItemModel orderItem in caseModel.CaseOrderLists)
                    {
                        if (orderItem.ProductTypeId > 0 && orderItem.SelectProduct != null)
                        {
                            //get product
                            SaleOrderClassProduct mainProduct = new SaleOrderClassProduct();
                            mainProduct.Name = orderItem.SelectProduct.Name;
                            mainProduct.Code = orderItem.SelectProduct.Code;
                            mainProduct.Class = orderItem.No == _MAXILLA ? "upper" : orderItem.No == _MANDIBLE ? "lower" : "teeth";
                            int teethNumber = 0;
                            if (orderItem.No != _MAXILLA && orderItem.No != _MANDIBLE && int.TryParse(orderItem.No, out teethNumber))
                            {
                                mainProduct.Position = teethNumber.ToString();
                            }
                            List<SaleOrderSubProduct> subProducts = new List<SaleOrderSubProduct>();

                            if (orderItem.SelectMaterial != null)
                            {
                                SaleOrderSubProduct material = new SaleOrderSubProduct();
                                material.Name = orderItem.SelectMaterial.Name + " (" + mainProduct.Class + (!string.IsNullOrEmpty(mainProduct.Position)? ' ' + mainProduct.Position + ')' :')');
                                material.Code = string.Empty;
                                material.Qty = 1;
                                subProducts.Add(material);
                            }

                            if (orderItem.SelectDesign != null)
                            {
                                SaleOrderSubProduct design = new SaleOrderSubProduct();
                                design.Name = orderItem.SelectDesign.Name + " (" + mainProduct.Class + (!string.IsNullOrEmpty(mainProduct.Position)? ' ' + mainProduct.Position + ')' :')');
                                design.Code = string.Empty;
                                design.Qty = 1;
                                subProducts.Add(design);
                            }

                            if (orderItem.SelectAddOn?.Count > 0)
                            {
                                foreach (SelectedAddOnModel addonItem in orderItem.SelectAddOn)
                                {
                                    SaleOrderSubProduct addon = new SaleOrderSubProduct();
                                    addon.Name = addonItem.Name;
                                    addon.Code = addonItem.Code;
                                    addon.Qty = 1;
                                    addon.Position = addonItem.Input + " (" + mainProduct.Class + (!string.IsNullOrEmpty(mainProduct.Position)? ' ' + mainProduct.Position + ')' :')');
                                    subProducts.Add(addon);

                                    if (IsLabelInAddOn(addonItem.Input))
                                        lableAddon.Add(string.Format("{0} {1}, {2}", addon.Name,addon.Code,addon.Position));                                    
                                }
                            }

                            ProductType caseProductType = GetProductTypeEnumById(orderItem.ProductTypeId);

                            // Case Crown and Bridge or removable might have 
                            if (caseProductType == ProductType.CROWNANDBRIDGES || caseProductType == ProductType.REMOVEABLE)
                            {
                                ShadesOfProduct shades = new ShadesOfProduct();

                                if (orderItem.SelectShade?.Length > 0)
                                {
                                    shades.Shade = orderItem.SelectShade;
                                }


                                if (orderItem.SelectShadeSystem?.Length > 0)
                                    shades.ShadeSystem = orderItem.SelectShadeSystem;

                                if (!string.IsNullOrEmpty(orderItem.SubstitutionTooth) && caseProductType == ProductType.REMOVEABLE)
                                {
                                    shades.SubsituteTooth = orderItem.SubstitutionTooth;
                                    mainProduct.Position = orderItem.SubstitutionTooth;
                                }

                                mainProduct.Shades = shades;
                            }

                            if (subProducts.Count > 0)
                                mainProduct.SubProducts = subProducts;

                            // feature bridge

                            if (caseProductType == ProductType.CROWNANDBRIDGES && !string.IsNullOrEmpty(orderItem.Option))
                            {
                                if (bridgeDic.ContainsKey(orderItem.Option))
                                {
                                    if (bridgeDic[orderItem.Option] == null)
                                        bridgeDic[orderItem.Option] = new List<string>();
                                    bridgeDic[orderItem.Option].Add(orderItem.No);
                                }
                                else
                                {
                                    bridgeDic.Add(orderItem.Option, new List<string>() { orderItem.No });
                                }
                            }

                            if (mainProductDic.ContainsKey(caseProductType))
                            {
                                // found in memory
                                if (mainProductDic[caseProductType].Products == null)
                                    mainProductDic[caseProductType].Products = new List<SaleOrderClassProduct>();
                                mainProductDic[caseProductType].Products.Add(mainProduct);
                            }
                            else
                            {
                                SaleOrderMainProduct typeProduct = new SaleOrderMainProduct();
                                typeProduct.Products = new List<SaleOrderClassProduct>() { mainProduct };
                                typeProduct.Type = caseProductType;
                                //typeProduct.Options = orderItem.Option;
                                typeProduct.Method = orderItem.Method?.Name;
                                mainProductDic.Add(caseProductType, typeProduct);
                            }
                        }
                    }

                    //Open sale Order
                    saleOrder.Products = new List<SaleOrderMainProduct>();
                    foreach (KeyValuePair<ProductType, SaleOrderMainProduct> product in mainProductDic)
                    {
                        if(product.Key == ProductType.CROWNANDBRIDGES && bridgeDic?.Count > 0)
                        {
                            List<string> optionValue = new List<string>();
                            // feature bridge for update option
                            foreach (KeyValuePair<string, List<string>> bridge in bridgeDic)
                            {
                                if(bridge.Value?.Count > 0)
                                {
                                    List<string> sortBridge = bridge.Value;
                                    sortBridge.Sort();
                                    optionValue.Add(string.Format("{0}-{1}", sortBridge.First(), sortBridge.Last()));
                                }
                            }

                            SaleOrderMainProduct temp = product.Value;
                            temp.Options = string.Join(",", optionValue);
                            saleOrder.Products.Add(temp);
                        }
                        else
                            saleOrder.Products.Add(product.Value);
                    }
                }

                // Display Label to comment
                if(lableAddon.Count > 0)
                {
                    string memoLabel = string.Join(" , ", lableAddon);
                    saleOrder.Comments = string.Format("{0}\n{1}", saleOrder.Comments, memoLabel);
                }
            }
            return saleOrder;
        }

        [HttpPost("DuplicateCase")]
        public async Task<int> DuplicateCase([FromBody] DuplicateCaseRequestModel requestModel)
        {
            if (requestModel == null)
            {
                throw new HexaDomainException("Duplicate Case bad request");
            }
            else if (requestModel.DentistId < 0)
            {
                throw new HexaDomainException("Please select Dentist");
            }
            else if (requestModel.ClinicId < 0)
            {
                throw new HexaDomainException("Please select Clinic");
            }
            else
            {
                DuplicateCaseResponseModel result = await _caseService.DuplicateCase(requestModel.CaseId, requestModel.UserId, requestModel.DentistId, requestModel.ClinicId);
                if (result != null)
                {
                    if (result.IsPass)
                    {
                        return result.ResultCaseId;
                    }
                    else
                    {
                        throw new HexaDomainException(result.ErrorMessage);
                    }
                }
                else
                    throw new HexaDomainException("Save Draft failed");
            }
        }

        private CaseType GetCaseTypeEnumById(int caseTypeId)
        {
            switch (caseTypeId)
            {
                case 1:
                    return CaseType.NEW;
                case 2:
                    return CaseType.RE_C;
                case 3:
                    return CaseType.RE_UM;
                default:
                    return CaseType.NEW;
            }
        }
        private ProductType GetProductTypeEnumById(int productTypeId)
        {
            switch (productTypeId)
            {
                case 1:
                    return ProductType.CROWNANDBRIDGES;
                case 2:
                    return ProductType.REMOVEABLE;
                case 3:
                    return ProductType.OTHODONTIC;
                case 4:
                    return ProductType.OTHOPEDIC;
                case 5:
                    return ProductType.ICHARM;
                default:
                    return ProductType.CROWNANDBRIDGES;
            }               
        }

        private bool IsLabelInAddOn(string input)
        {
            return input.Contains("name:");
        }


    }
}
