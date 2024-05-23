using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.CustomMapping
{
    public static class CustomMapTblToModel
    {
        public static string _MAXILLA = "Maxilla";
        public static string _MANDIBLE = "Mandible";
        public static MasterProductModel MapMasterProduct(TblMasterProduct masterProduct)
        {
            if (masterProduct != null)
            {
                MasterProductModel product = new MasterProductModel();
                product.Id = masterProduct.Id;
                product.Name = masterProduct.Name;
                product.ColorCode = masterProduct.ColorCode;
                product.LogoPath = masterProduct.LogoPath;
                product.ExpectedProductDay = masterProduct.ExpectedProductDay;
                product.ProductTypeId = masterProduct.ProductTypeId;
                product.Code = masterProduct.Code;

                if (masterProduct.Materials != null)
                {
                    List<MaterialModel> materials = new List<MaterialModel>();
                    foreach (TblProductMaterial item in masterProduct.Materials)
                    {
                        if (item.Material != null)
                        {
                            MaterialModel material = MapMaterialModel(item.Material);
                            if (material != null)
                                materials.Add(material);
                        }
                    }
                    product.Materials = materials;
                }

                if (masterProduct.Designs != null)
                {
                    List<DesignModel> designs = new List<DesignModel>();
                    foreach (TblProductDesign item in masterProduct.Designs)
                    {
                        if (item.Design != null)
                        {
                            DesignModel design = MapDesignModel(item.Design);
                            if (design != null)
                                designs.Add(design);
                        }
                    }
                    product.Designs = designs;
                }

                if (masterProduct.AddOns != null)
                {
                    List<GroupAddOnModel> addOnGroups = new List<GroupAddOnModel>();
                
                    foreach (TblProductAddOn item in masterProduct.AddOns)
                    {
                        if(item.GroupAddOn != null)
                        {
                            GroupAddOnModel group = addOnGroups.Find(f => f.Id == item.GroupAddOn.Id);
                            if(group == null)
                            {
                                addOnGroups.Add(MapGroupAddOnModel(item.GroupAddOn));
                            }
                        }

                        if (item.AddOn != null)
                        {
                            AddOnModel addOn = MapAddOnModel(item);
                            if (addOn != null)
                            {
                                GroupAddOnModel group = addOnGroups.Find(f => f.Id == addOn.GroupAddOnId);
                                if(group != null)
                                {
                                    group.AddOns.Add(addOn);
                                }
                                else
                                {
                                    GroupAddOnModel groupCaseNotInclude = addOnGroups.Find(f => f.Id == 0);
                                    if(groupCaseNotInclude != null)
                                    {
                                        groupCaseNotInclude.AddOns.Add(addOn);
                                    }
                                    else
                                    {
                                        GroupAddOnModel noneGroup = CreatNoGroupAddOnModel();
                                        noneGroup.AddOns.Add(addOn);
                                        addOnGroups.Add(noneGroup);
                                    }
                                }
                            }
                        }
                    }
                    product.AddOnGroups = addOnGroups.OrderBy(o => o.OrderNumber).ToList();
                }

                return product;
            }
            return null;
        }

        public static GroupAddOnModel MapGroupAddOnModel(TblGroupAddOn tblGroupAddOn)
        {
            GroupAddOnModel group = null;
            if(tblGroupAddOn != null)
            {
                group = new GroupAddOnModel();
                group.Id = tblGroupAddOn.Id;
                group.Name = tblGroupAddOn.Name;
                group.OrderNumber = tblGroupAddOn.OrderNumber;
                group.DisplayAsGroup = true;
                group.AddOns = new List<AddOnModel>();
            }
            return group;
        }

        public static GroupAddOnModel CreatNoGroupAddOnModel()
        {
            GroupAddOnModel group = new GroupAddOnModel();
            group.Id = 0;
            group.Name = string.Empty;
            group.OrderNumber = 0;
            group.DisplayAsGroup = false;
            group.AddOns = new List<AddOnModel>();
            return group;
        }

        public static MaterialModel MapMaterialModel(TblMaterial tblMaterial)
        {
            MaterialModel material = null;
            if (tblMaterial != null)
            {
                material = new MaterialModel();
                material.Id = tblMaterial.Id;
                material.Name = tblMaterial.Name;
                material.LogoPath = tblMaterial.LogoPath;
            }
            return material;
        }

        public static DesignModel MapDesignModel(TblDesign tblDesign)
        {
            DesignModel design = null;
            if (tblDesign != null)
            {
                design = new DesignModel();
                design.Id = tblDesign.Id;
                design.Name = tblDesign.Name;
                design.LogoPath = tblDesign.LogoPath;

            }
            return design;
        }

        public static AddOnModel MapAddOnModel(TblProductAddOn productAddOn)
        {
            AddOnModel addOn = null;
            if (productAddOn != null && productAddOn.AddOn != null)
            {
                addOn = new AddOnModel();
                addOn.Id = productAddOn.AddOn.Id;
                addOn.Name = productAddOn.AddOn.Name;
                addOn.DisplayName = productAddOn.AddOn.DisplayName;
                addOn.Code = productAddOn.AddOn.Code;
                addOn.ColorCode = productAddOn.AddOn.ColorCode;
                addOn.LogoPath = productAddOn.AddOn.LogoPath;
                addOn.RequiredInput = productAddOn.RequiredInput;
                addOn.GroupAddOnId = productAddOn.GroupAddOnId.HasValue ? productAddOn.GroupAddOnId.Value : 0;

                if (productAddOn.InputType != null)
                    addOn.InputType = (Models.AddOnInputTypeEnum)((int)productAddOn.InputType);
            }
            return addOn;
        }

        public static SelectedAddOnModel MapSelectedAddOnModel(TblCaseProductAddOn productAddOn, TblProductAddOn masterProductAddOn)
        {
            SelectedAddOnModel addOn = null;
            if (productAddOn != null && productAddOn.AddOn != null)
            {
                addOn = new SelectedAddOnModel();
                addOn.Id = productAddOn.AddOn.Id;
                addOn.Name = productAddOn.AddOn.Name;
                addOn.DisplayName = productAddOn.AddOn.DisplayName;
                addOn.Code = productAddOn.AddOn.Code;
                addOn.ColorCode = productAddOn.AddOn.ColorCode;
                addOn.LogoPath = productAddOn.AddOn.LogoPath;
                addOn.Input = productAddOn.InputAddOn;

                if(masterProductAddOn != null)
                {
                    addOn.RequiredInput = masterProductAddOn.RequiredInput;
                    if (masterProductAddOn.InputType != null)
                        addOn.InputType = (Models.AddOnInputTypeEnum)((int)masterProductAddOn.InputType);
                }
                    
            }
            return addOn;
        }

        public static ProductGroupModel MapProductGroupModel(TblProductTypeGroup productTypeGroup)
        {
            ProductGroupModel productGroupModel = null;
            if (productTypeGroup != null)
            {
                productGroupModel = new ProductGroupModel();
                productGroupModel.Id = productTypeGroup.Id;
                productGroupModel.Name = productTypeGroup.Name;
                productGroupModel.DisplayAsGroup = productTypeGroup.DisplayAsGroup;
                productGroupModel.ProductTypeId = productTypeGroup.ProductTypeId;
                if (productTypeGroup.ProductGroupItems != null)
                {
                    List<MasterProductModel> products = new List<MasterProductModel>();
                    foreach (TblProductGroupItem groupItem in productTypeGroup.ProductGroupItems)
                    {
                        if (groupItem.Product != null)
                        {
                            MasterProductModel product = MapMasterProduct(groupItem.Product);
                            if (product != null)
                                products.Add(product);
                        }
                    }
                    productGroupModel.ProductItems = products;
                }
            }
            return productGroupModel;
        }

        public static MethodModel MapMethodModel(TblMethod tblMethod)
        {
            MethodModel method = null;
            if (tblMethod != null)
            {
                method = new MethodModel();
                method.Id = tblMethod.Id;
                method.Name = tblMethod.Name;
                method.ProductTypeId = tblMethod.ProductTypeId;
            }
            return method;
        }

        public static CaseAttachedFileModel MapCaseAttachedFileModel(TblCaseAttachedFile caseAttachedFile)
        {
            CaseAttachedFileModel model = null;
            if (caseAttachedFile != null)
            {
                model = new CaseAttachedFileModel();
                model.Id = caseAttachedFile.Id;
                model.CaseId = caseAttachedFile.CaseId;
                model.FilePath = caseAttachedFile.FilePath;
                model.FileTypeId = caseAttachedFile.FileTypeId;
            }
            return model;
        }

        public static ProductTypeModel MapProductTypeModel(TblProductType productType)
        {
            ProductTypeModel model = null;
            if (productType != null)
            {
                model = new ProductTypeModel();
                model.Id = productType.Id;
                model.Name = productType.Name;

                if (productType.Methods != null)
                {
                    List<MethodModel> methods = new List<MethodModel>();
                    foreach (TblMethod method in productType.Methods)
                    {
                        MethodModel methodModel = MapMethodModel(method);
                        if (methodModel != null)
                            methods.Add(methodModel);
                    }
                    model.Methods = methods;
                }

                if (productType.ProductTypeGroups != null)
                {
                    List<ProductGroupModel> productGroupModels = new List<ProductGroupModel>();
                    foreach (TblProductTypeGroup productTypeGroup in productType.ProductTypeGroups.OrderBy(o => o.OrderNumber))
                    {
                        ProductGroupModel productGroup = MapProductGroupModel(productTypeGroup);
                        if (productGroup != null && productGroup.ProductItems != null && productGroup.ProductItems.Count > 0)
                            productGroupModels.Add(productGroup);
                    }
                    model.ProductGroupModels = productGroupModels;
                }

                if (productType.ShadeSystems != null)
                {
                    List<ShadeSystemModel> shadeSystemModels = new List<ShadeSystemModel>();
                    foreach (TblShadeSystem shade in productType.ShadeSystems)
                    {
                        ShadeSystemModel shadeSystem = MapShadeSystemModel(shade);
                        if (shadeSystem != null)
                            shadeSystemModels.Add(shadeSystem);
                    }
                    model.ShadeSystemsModels = shadeSystemModels;
                }

            }
            return model;
        }

        public static ShadeSystemModel MapShadeSystemModel(TblShadeSystem shadeSystem)
        {
            ShadeSystemModel shadeSystemModel = null;
            if (shadeSystem != null)
            {
                shadeSystemModel = new ShadeSystemModel();
                shadeSystemModel.Id = shadeSystem.Id;
                shadeSystemModel.Name = shadeSystem.Name;
                shadeSystemModel.Order = shadeSystem.Order;
                if (shadeSystem.Shades != null)
                {
                    List<ShadeModel> shades = new List<ShadeModel>();
                    foreach (TblShade shade in shadeSystem.Shades)
                    {
                        ShadeModel shadeModel = MapShadesModel(shade);
                        if (shadeModel != null)
                            shades.Add(shadeModel);
                    }
                    shadeSystemModel.Shades = shades;
                }
            }
            return shadeSystemModel;
        }

        public static ShadeModel MapShadesModel(TblShade item)
        {
            ShadeModel shade = null;
            if (item != null)
            {
                shade = new ShadeModel(); 
                shade.Id = item.Id;
                shade.Name = item.Name;
                shade.ShadeSystemId = item.ShadeSystemId;
            }
            return shade;
        }

        public static CaseItemModel MapCaseItemModel(TblCaseProduct item)
        {
            CaseItemModel itemModel = null;
            if(item != null)
            {
                itemModel = new CaseItemModel();
                itemModel.CaseId = item.CaseId;             
                itemModel.Method = MapMethodModel(item.Method);
                itemModel.Option = item.Option;
                itemModel.ProductTypeId = item.ProductTypeId;
                itemModel.SelectShade = item.Shade;
                itemModel.SelectShadeSystem = item.ShadeSystem;
                itemModel.SelectedShadeSystem = MapShadeSystemModel(item.ShadeSystemObject);
                itemModel.SelectedShade = MapShadesModel(item.ShadeObject);

                if (item.SubstitutionTooth != null)
                    itemModel.SubstitutionTooth = item.SubstitutionTooth;

                if (item.ProductType != null)
                    itemModel.ProductType = item.ProductType.Name;

                if (item.TeethNumber.HasValue)
                    itemModel.No = item.TeethNumber.Value.ToString();
                else if (item.Section.HasValue)
                {
                    if (item.Section.Value == DataModels.CaseSectionEnum.Upper)
                        itemModel.No = _MAXILLA;
                    else if (item.Section.Value == DataModels.CaseSectionEnum.Lower)
                        itemModel.No = _MANDIBLE;
                }
                
                if (item.Product != null )
                    itemModel.SelectProduct = MapMasterProduct(item.Product);
                if (item.Materials?.Count > 0)
                    itemModel.SelectMaterial = MapMaterialModel(item.Materials.FirstOrDefault().Material);
                if (item.Designs?.Count > 0)
                    itemModel.SelectDesign = MapDesignModel(item.Designs.FirstOrDefault().Design);

                if (item.AddOns?.Count > 0)
                {
                    List<SelectedAddOnModel> selectAddOns = new List<SelectedAddOnModel>();
                    foreach (TblCaseProductAddOn addOnItem in item.AddOns)
                    {
                        TblProductAddOn masterProductAddOn = null;
                        masterProductAddOn = item.Product?.AddOns.Where(pa => pa.AddOnId == addOnItem.AddOnId && pa.MasterProductId == item.Product.Id).FirstOrDefault();
                        
                        SelectedAddOnModel selectedAddOnModel = MapSelectedAddOnModel(addOnItem, masterProductAddOn);
                        if (selectedAddOnModel != null)
                            selectAddOns.Add(selectedAddOnModel);
                    }

                    itemModel.SelectAddOn = selectAddOns;
                }
            }

            return itemModel;
        }

        public static TblCaseProduct MapTblCaseProduct(CaseItemModel productItem)
        {
            if (productItem != null && productItem.SelectProduct != null)
            {
                TblCaseProduct caseProduct = new TblCaseProduct();
                caseProduct.ProductId = productItem.SelectProduct.Id;
                caseProduct.ProductTypeId = productItem.ProductTypeId;
                caseProduct.MethodId = productItem.Method != null ? productItem.Method.Id : 0;
                caseProduct.Option = productItem.Option;
                caseProduct.Qty = 1;
                caseProduct.Shade = productItem.SelectShade;
                caseProduct.ShadeSystem = productItem.SelectShadeSystem;
                caseProduct.ShadeSystemId = productItem.SelectedShadeSystem != null ? productItem.SelectedShadeSystem.Id : null;
                caseProduct.ShadeId = productItem.SelectedShade != null ? productItem.SelectedShade.Id : null;
                caseProduct.SubstitutionTooth = productItem != null ? productItem.SubstitutionTooth : null;

                int teethNumber = 0;
                if (int.TryParse(productItem.No, out teethNumber))
                    caseProduct.TeethNumber = teethNumber;
                else if (productItem.No != null && productItem.No.ToLower() == "maxilla")
                    caseProduct.Section = DataModels.CaseSectionEnum.Upper;
                else if (productItem.No != null && productItem.No.ToLower() == "mandible")
                    caseProduct.Section = DataModels.CaseSectionEnum.Lower;
                if (productItem.SelectMaterial != null)
                {
                    TblCaseProductMaterial cpMaterial = new TblCaseProductMaterial();
                    cpMaterial.MaterialId = productItem.SelectMaterial.Id;
                    caseProduct.Materials = new List<TblCaseProductMaterial>() { cpMaterial };
                }

                if (productItem.SelectDesign != null)
                {
                    TblCaseProductDesign cpDesign = new TblCaseProductDesign();
                    cpDesign.DesignId = productItem.SelectDesign.Id;
                    caseProduct.Designs = new List<TblCaseProductDesign>() { cpDesign };
                }

                if (productItem.SelectAddOn?.Count > 0)
                {
                    List<TblCaseProductAddOn> addOns = new List<TblCaseProductAddOn>();
                    foreach (SelectedAddOnModel addOn in productItem.SelectAddOn)
                    {
                        TblCaseProductAddOn cpAddOn = new TblCaseProductAddOn();
                        cpAddOn.AddOnId = addOn.Id;
                        cpAddOn.InputAddOn = addOn.Input;
                        addOns.Add(cpAddOn);
                    }
                    caseProduct.AddOns = addOns;
                }

                caseProduct.Shade = productItem.SelectShade;
                caseProduct.ShadeSystem = productItem.SelectShadeSystem;

                return caseProduct;
            }
            return null;
        }

        public static DisplayCaseModel MapDisplayCaseModel(TblCase item)
        {
            DisplayCaseModel displayCase = null;
            if (item != null)
            {
                displayCase = new DisplayCaseModel();
                displayCase.CaseId = item.Id;
                displayCase.CaseName = item.CaseName;
                displayCase.PatientName = item.PatientName;
                displayCase.ClinicId = item.OrganizationId.HasValue ? item.OrganizationId.Value : 0;
                displayCase.DentistId = item.DoctorId.HasValue ? item.DoctorId.Value : 0;
                displayCase.Memo = item.Memo;
                displayCase.CaseTypeId = item.CaseTypeId;
                displayCase.RequestDate = item.RequestDate;
                displayCase.PickupDate = item.PickupDate;
                displayCase.ReferenceOrderId = item.ReferenceOrderId;
                displayCase.ReferenceOrderNumber = item.ReferenceOrderNumber;
                displayCase.Age = item.Age;
                displayCase.Gender = item.Gender;
                displayCase.Aligners = item.Aligners;

                List<string> productTypes = new List<string>();
                if (item != null && item.CaseProducts?.Count > 0)
                {
                    foreach (TblCaseProduct caseProduct in item.CaseProducts)
                    {
                        if (caseProduct.ProductType != null && !productTypes.Contains(caseProduct.ProductType.Name))
                            productTypes.Add(caseProduct.ProductType.Name);
                    }
                }

                displayCase.ProductType = productTypes != null ? string.Join(',', productTypes) : string.Empty;

                if (item.CaseStatus != null)
                    displayCase.Status = item.CaseStatus.Name;
                if (item.CaseType != null)
                    displayCase.CaseType = item.CaseType.Name;
                displayCase.UserId = item.UserId;
                displayCase.LastUpdate = item.LastUpdate;
                //TODO: Get ClinicName and DentistName by API
                displayCase.ClinicName = "Ohmkoi Hospital";
                displayCase.DentistName = "Chin Asuka";
                

                if (item.CaseAttachedFiles?.Count > 0)
                {
                    List<CaseAttachedFileModel> files = new List<CaseAttachedFileModel>();
                    foreach (TblCaseAttachedFile file in item.CaseAttachedFiles)
                    {
                        CaseAttachedFileModel fileModel = MapCaseAttachedFileModel(file);
                        if (fileModel != null)
                            files.Add(fileModel);
                    }
                    displayCase.AttachedFileList = files;
                }
                if (item.CaseProducts?.Count > 0)
                {
                    List<CaseItemModel> caseItems = new List<CaseItemModel>();
                    foreach (TblCaseProduct caseProduct in item.CaseProducts)
                    {
                        CaseItemModel caseProductItem = MapCaseItemModel(caseProduct);
                        if (caseProductItem != null)
                        {
                            caseItems.Add(caseProductItem);
                        }
                    }
                    displayCase.CaseOrderLists = caseItems;
                }
                if (item.OrderData != null)
                {
                    displayCase.OrderId = item.OrderData.Id;
                    displayCase.OrderRefNumber = item.OrderData.ReferenceNumber;                   
                }
                if (item.OrderData != null && item.OrderData.EstimatedDate.HasValue)
                {
                    displayCase.EstimatedDate = item.OrderData.EstimatedDate.Value;
                }
            }
            return displayCase;
        }   
        
        public static DisplayOrder MapDisplayOrders(TblOrder item)
        {
            DisplayOrder displayOrder = new DisplayOrder();
            displayOrder.OrderId = item.Id;
            displayOrder.OrderRef = item.ReferenceNumber;
            displayOrder.ClinicName = ""; 
            displayOrder.DentistName = "";
            if(item.Case != null)
            {
                displayOrder.ClinicId = item.Case.OrganizationId ?? 0;
                displayOrder.DentistId = item.Case.DoctorId ?? 0;
                displayOrder.PatientName = item.Case.PatientName;
                displayOrder.RequestDeliveryDate = item.Case.RequestDate;
                displayOrder.CaseType = item.Case.CaseType?.Name;
                displayOrder.PickupDate = item.Case.PickupDate;
                displayOrder.CaseId = item.CaseId;
                displayOrder.DisplayCase = CustomMapping.CustomMapTblToModel.MapDisplayCaseModel(item.Case);
            }

            displayOrder.Disabled = item.Disabled;
            displayOrder.Status = item.OrderStatus?.Id ?? 1; // default status to draft
            displayOrder.OrderDate = item.OrderDate;
            displayOrder.EstimatetionDate = item.EstimatedDate;
            displayOrder.IsNotification = item.IsNotification;
            
            return displayOrder;
        }

        public static DisplayRolePermissionModel MapDisplayRoles(TblUserRole userrole)
        {
            DisplayRolePermissionModel displayRole = new DisplayRolePermissionModel();
            List<PermissiveProductType> permissiveProductTypeList = new List<PermissiveProductType>();
            foreach (TblProductType productType in userrole.ProductType)
            {
                PermissiveProductType permissiveProductType = new PermissiveProductType();
                permissiveProductType.Id = productType.Id;
                permissiveProductType.Name = productType.Name;
                permissiveProductTypeList.Add(permissiveProductType);
            }
            displayRole.ProductTypeList = permissiveProductTypeList;
            displayRole.Id = userrole.Id;
            displayRole.Name = userrole.Name;
            if(userrole.Users != null)
            displayRole.UserCount = userrole.Users.Count;

            return displayRole;
        }
    }
}
