using System;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUserRole>().HasData(
                new TblUserRole()
                {
                    Id = 1,
                    Name = "Dentist"
                },
                new TblUserRole()
                {
                    Id = 2,
                    Name = "Clinic"
                },
                new TblUserRole()
                {
                    Id = 3,
                    Name = "Admin"
                },
                new TblUserRole()
                {
                    Id = 4,
                    Name = "Staff"
                }
            );

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasData(
                    new TblUser()
                    {
                        UserId = 1,
                        UserRoleId = 1,
                        Username = "Dentist",
                        Password = "dentist",
                        Name = "ทพญ.ศลิษา สิริยศธำรง",
                        ContactId = 32503
                    },
                    new TblUser()
                    {
                        UserId = 2,
                        UserRoleId = 2,
                        Username = "Clinic",
                        Password = "clinic",
                        Name = "คลินิกบ้านหมอฟัน (พะเยา)",
                        ContactId = 21379
                    },
                    new TblUser()
                    {
                        UserId = 3,
                        UserRoleId = 3,
                        Username = "Admin",
                        Password = "admin",
                        Name = "System Admin"
                    },
                    new TblUser()
                    {
                        UserId = 4,
                        UserRoleId = 4,
                        Username = "Staff",
                        Password = "staff",
                        Name = "Leknoi"
                    });
            });

            modelBuilder.Entity<TblProductType>(entity =>
            {
                entity.HasData(
                    new TblProductType()
                    {
                        Id = 1,
                        Name = "Crown & Bridge"
                    },
                    new TblProductType()
                    {
                        Id = 2,
                        Name = "Removable"
                    },
                    new TblProductType()
                    {
                        Id = 3,
                        Name = "Orthodontic"
                    },
                    new TblProductType()
                    {
                        Id = 4,
                        Name = "Orthopedic"
                    });
            });

            modelBuilder.Entity<TblProductCategory>(entity =>
            {
                entity.HasData(
                    new TblProductCategory()
                    {
                        Id = 1,
                        Name = "Product"
                    },
                    new TblProductCategory()
                    {
                        Id = 2,
                        Name = "Material"
                    },
                    new TblProductCategory()
                    {
                        Id = 3,
                        Name = "Alloy"
                    },
                    new TblProductCategory()
                    {
                        Id = 4,
                        Name = "Design"
                    },
                    new TblProductCategory()
                    {
                        Id = 5,
                        Name = "Add-On"
                    });
            });

            modelBuilder.Entity<TblUnit>(entity =>
            {
                entity.HasData(
                    new TblUnit()
                    {
                        Id = 1,
                        Name = "Unit A"
                    },
                    new TblUnit()
                    {
                        Id = 2,
                        Name = "Unit B"
                    });
            });

            modelBuilder.Entity<TblMethod>(entity =>
            {
                entity.HasData(
                    //Method of Crown & Bridge Type
                    new TblMethod()
                    {
                        Id = 1,
                        Name = "Try in",
                        ProductTypeId = 1
                    },
                    new TblMethod()
                    {
                        Id = 2,
                        Name = "Contour",
                        ProductTypeId = 1
                    },
                    new TblMethod()
                    {
                        Id = 3,
                        Name = "Finish",
                        ProductTypeId = 1
                    },
                    new TblMethod()
                    {
                        Id = 4,
                        Name = "Remake",
                        ProductTypeId = 1
                    },

                    //Method of Removable Type
                    new TblMethod()
                    {
                        Id = 5,
                        Name = "Try in",
                        ProductTypeId = 2
                    },
                    new TblMethod()
                    {
                        Id = 6,
                        Name = "Set up teeth",
                        ProductTypeId = 2
                    },
                    new TblMethod()
                    {
                        Id = 7,
                        Name = "Finish",
                        ProductTypeId = 2
                    },
                    new TblMethod()
                    {
                        Id = 8,
                        Name = "Remake",
                        ProductTypeId = 2
                    },

                    //Method of Orthodontic Type
                    new TblMethod()
                    {
                        Id = 9,
                        Name = "Finish",
                        ProductTypeId = 3
                    },
                    new TblMethod()
                    {
                        Id = 10,
                        Name = "Try in",
                        ProductTypeId = 3
                    },
                    new TblMethod()
                    {
                        Id = 11,
                        Name = "Remake",
                        ProductTypeId = 3
                    },

                    //Method of Orthopedic Type
                    new TblMethod()
                    {
                        Id = 12,
                        Name = "Finish",
                        ProductTypeId = 4
                    },
                    new TblMethod()
                    {
                        Id = 13,
                        Name = "Try in",
                        ProductTypeId = 4
                    },
                    new TblMethod()
                    {
                        Id = 14,
                        Name = "Remake",
                        ProductTypeId = 4
                    });
            });

            modelBuilder.Entity<TblProductTypeGroup>(entity =>
            {
                entity.HasData(
                    new TblProductTypeGroup()
                    {
                        Id = 1,
                        Name = "General",
                        DisplayAsGroup = true,
                        ProductTypeId = 1
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 2,
                        Name = "Removable",
                        DisplayAsGroup = false,
                        ProductTypeId = 2
                    });
            });

            modelBuilder.Entity<TblCaseType>(entity =>
            {
                entity.HasData(
                    new TblCaseType()
                    {
                        Id = 1,
                        Name = "New Case"
                    },
                    new TblCaseType()
                    {
                        Id = 2,
                        Name = "Remake"
                    },
                    new TblCaseType()
                    {
                        Id = 3,
                        Name = "Warranty"
                    });
            });

            modelBuilder.Entity<TblCaseStatus>(entity =>
            {
                entity.HasData(
                    new TblCaseStatus()
                    {
                        Id = 1,
                        Name = "Draft"
                    },
                    new TblCaseStatus()
                    {
                        Id = 2,
                        Name = "Ordered"
                    });
            });

            #region Add seed removable product and Add-On 

            modelBuilder.Entity<TblMasterProduct>(entity =>
            {
                entity.HasData(
                    new TblMasterProduct()
                    {
                        Id = 1,
                        Name = "Full Denture",
                        ColorCode = "#3bb858",
                        LogoPath = "/ProductIcon/Removable/Products/full_denture.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 2,
                        Name = "Partial Denture Framework",
                        ColorCode = "#968226",
                        LogoPath = "/ProductIcon/Removable/Products/partial_denture_framework.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 3,
                        Name = "Temporary Partial Plate",
                        ColorCode = "#604bbf",
                        LogoPath = "/ProductIcon/Removable/Products/Temporary%20patial%20plate.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 4,
                        Name = "Bite Block",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/bite_block.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 5,
                        Name = "Chrome Cobalt Retaner",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/chrome_cobalt.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 6,
                        Name = "Flexible Denture",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/flexible_denture.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 7,
                        Name = "Special Tray",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/Special%20tray.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 8,
                        Name = "Peek (Polyetheretherketone)",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/peek.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 9,
                        Name = "Peek for RPD (เฉพาะโครง)",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/peek_for_rpd-aceltal_%20plate.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 10,
                        Name = "Peek for RB (เฉพาะโครง)",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/rb_all_acetal.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 11,
                        Name = "All Acetal Plate",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/peek_for_rpd-aceltal_%20plate.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 12,
                        Name = "RB All Acetal",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/rb_all_acetal.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    },
                    new TblMasterProduct()
                    {
                        Id = 143,
                        Name = "Removable Bridge",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 2
                    }
                    );
            });
            #region material
            modelBuilder.Entity<TblMaterial>(entity =>
            {
                entity.HasData(
                    new TblMaterial()
                    {
                        Id = 8,
                        Name = "Metal"
                    },
                    new TblMaterial()
                    {
                        Id = 9,
                        Name = "Acrylic"
                    },
                    new TblMaterial()
                    {
                        Id = 12,
                        Name = "Flexible"
                    }
                );
            });
            #endregion

            #region product ref material
            modelBuilder.Entity<TblProductMaterial>(entity =>
            {
                entity.HasData(
                    new TblProductMaterial()
                    {
                        Id = 15,
                        MasterProductId = 143,
                        MaterialId = 8
                    },
                    new TblProductMaterial()
                    {
                        Id = 16,
                        MasterProductId = 143,
                        MaterialId = 9
                    },
                    new TblProductMaterial()
                    {
                        Id = 21,
                        MasterProductId = 143,
                        MaterialId = 12
                    }
                );
            });
            #endregion

            modelBuilder.Entity<TblAddOn>(entity =>
            {
                entity.HasData(
                    new TblAddOn()
                    {
                        Id = 1,
                        Code = "REA0001",
                        Name = "TP ซี่ต่อไป (ซี่ละ)",
                        DisplayName = "TP ซี่ต่อไป (ซี่ละ)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 2,
                        Code = "REA0002",
                        Name = "ฐานนิ่ม (Soft base vertex)",
                        DisplayName = "ฐานนิ่ม (Soft base vertex)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 3,
                        Code = "REA0005",
                        Name = "Valplast Clasp",
                        DisplayName = "Valplast Clasp",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 4,
                        Code = "REA0006",
                        Name = "ตะขอลวดดัด",
                        DisplayName = "ตะขอลวดดัด",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 5,
                        Code = "REA0008",
                        Name = "ตะขอ Ball / Adam",
                        DisplayName = "ตะขอ Ball / Adam",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 6,
                        Code = "REA0009",
                        Name = "ตะขอ Y or T",
                        DisplayName = "ตะขอ Y or T",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 7,
                        Code = "REA0010",
                        Name = "Twinflex in TP",
                        DisplayName = "Twinflex in TP",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 8,
                        Code = "REA0011",
                        Name = "เสริมลวดงาน TP (ดามลวด)",
                        DisplayName = "เสริมลวดงาน TP (ดามลวด)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 9,
                        Code = "REA0013",
                        Name = "เสริมโลหะเหวี่ยงงาน TP ( Casting Lingual Bar)",
                        DisplayName = "เสริมโลหะเหวี่ยงงาน TP ( Casting Lingual Bar)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 10,
                        Code = "REA0018",
                        Name = "ฐานนิ่มบางตำแหน่ง (Soft base vertex)",
                        DisplayName = "ฐานนิ่มบางตำแหน่ง (Soft base vertex)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 11,
                        Code = "REA0020",
                        Name = "ตะแกรงทองเล็ก (สำเร็จ)",
                        DisplayName = "ตะแกรงทองเล็ก (สำเร็จ)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 12,
                        Code = "REA0021",
                        Name = "ตะแกรงทองใหญ่ (สำเร็จ)",
                        DisplayName = "ตะแกรงทองใหญ่ (สำเร็จ)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 13,
                        Code = "REA0022",
                        Name = "High Impact for Full Denture",
                        DisplayName = "High Impact for Full Denture",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 14,
                        Code = "REA0023",
                        Name = "High Impact for TP",
                        DisplayName = "High Impact for TP",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 15,
                        Code = "REA0027",
                        Name = "Acrylic Gum slip",
                        DisplayName = "Acrylic Gum slip",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 16,
                        Code = "REA0028",
                        Name = "Overlay Denture",
                        DisplayName = "Overlay Denture",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 17,
                        Code = "REA0029",
                        Name = "Clear Acrylic",
                        DisplayName = "Clear Acrylic",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 18,
                        Code = "REA0031",
                        Name = "ฟัน Acetal บนโครง RPD",
                        DisplayName = "ฟัน Acetal บนโครง RPD",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 19,
                        Code = "REA0032",
                        Name = "Full Metal Tooth",
                        DisplayName = "Full Metal Tooth",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 20,
                        Code = "REA0033",
                        Name = "Backing",
                        DisplayName = "Backing",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 21,
                        Code = "REA0035",
                        Name = "Rest (เหวี่ยงโลหะ)",
                        DisplayName = "Rest (เหวี่ยงโลหะ)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 22,
                        Code = "REA0037",
                        Name = "ตะขอเหวี่ยงโลหะ",
                        DisplayName = "ตะขอเหวี่ยงโลหะ",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 23,
                        Code = "REA0038",
                        Name = "ตะแกรง (เหวี่ยงโลหะ)",
                        DisplayName = "ตะแกรง (เหวี่ยงโลหะ)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 24,
                        Code = "REA0039",
                        Name = "Swing Lock in Acetal,Valplast,Metal",
                        DisplayName = "Swing Lock in Acetal,Valplast,Metal",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 25,
                        Code = "REA0041",
                        Name = "Acetal Clasp (ตะขอสีเหมือนฟัน)",
                        DisplayName = "Acetal Clasp (ตะขอสีเหมือนฟัน)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 26,
                        Code = "REA0045",
                        Name = "High Impact for RPD",
                        DisplayName = "High Impact for RPD",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 27,
                        Code = "REA0077",
                        Name = "Rest (ลวดดัด)",
                        DisplayName = "Rest (ลวดดัด)",
                        ColorCode = "",
                        LogoPath = ""
                    }
                    );
            });

            modelBuilder.Entity<TblGroupAddOn>(entity =>
            {
                #region Removable add on Group
                entity.HasData(

                #region Partial Denture Framework Group
                    new TblGroupAddOn()
                    {
                        Id = 1,
                        Name = "ตะขอ",
                        OrderNumber = 1
                    },
                    new TblGroupAddOn()
                    {
                        Id = 2,
                        Name = "อื่นๆ",
                        OrderNumber = 2
                    }
                    #endregion

                    #region Partial Denture Framework Group
                    ,new TblGroupAddOn()
                    {
                        Id = 3,
                        Name = "ตะขอ",
                        OrderNumber = 1
                    },
                    new TblGroupAddOn()
                    {
                        Id = 4,
                        Name = "ตะแกรง",
                        OrderNumber = 2
                    },
                    new TblGroupAddOn()
                    {
                        Id = 5,
                        Name = "อื่นๆ",
                        OrderNumber = 3
                    }

                    #endregion
                    #region  Full Denture
                    , new TblGroupAddOn()
                    {
                        Id = 6,
                        Name = "ตะแกรง",
                        OrderNumber = 1
                    },
                    new TblGroupAddOn()
                    {
                        Id = 7,
                        Name = "ตะขอ",
                        OrderNumber = 2
                    },
                    new TblGroupAddOn()
                    {
                        Id = 8,
                        Name = "อื่นๆ",
                        OrderNumber = 3
                    }

                    #endregion
                );

                #endregion
            });




            modelBuilder.Entity<TblProductAddOn>(entity =>
            {

                entity.HasData(
                #region Full Denture AddOn             
                    new TblProductAddOn()
                    {
                        Id = 1,
                        AddOnId = 2,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.QuadrantWithAll,
                        GroupAddOnId = 8

                    },
                    new TblProductAddOn()
                    {
                        Id = 2,
                        AddOnId = 3,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 7
                    },
                    new TblProductAddOn()
                    {
                        Id = 3,
                        AddOnId = 4,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 7

                    },
                    new TblProductAddOn()
                    {
                        Id = 4,
                        AddOnId = 6,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 7
                    },
                    new TblProductAddOn()
                    {
                        Id = 5,
                        AddOnId = 10,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.Quadrant,
                        GroupAddOnId = 8
                    },
                    new TblProductAddOn()
                    {
                        Id = 6,
                        AddOnId = 25,
                        MasterProductId = 1,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 7
                    },
                    new TblProductAddOn()
                    {
                        Id = 7,
                        AddOnId = 8,
                        MasterProductId = 1,
                        RequiredInput = false,
                        GroupAddOnId = 8
                    },
                    new TblProductAddOn()
                    {
                        Id = 8,
                        AddOnId = 11,
                        MasterProductId = 1,
                        RequiredInput = false,
                        GroupAddOnId = 6
                    },
                    new TblProductAddOn()
                    {
                        Id = 9,
                        AddOnId = 12,
                        MasterProductId = 1,
                        RequiredInput = false,
                        GroupAddOnId = 6
                    },
                    new TblProductAddOn()
                    {
                        Id = 10,
                        AddOnId = 13,
                        MasterProductId = 1,
                        RequiredInput = false,
                        GroupAddOnId = 8
                    },
                    new TblProductAddOn()
                    {
                        Id = 11,
                        AddOnId = 23,
                        MasterProductId = 1,
                        RequiredInput = false,
                        GroupAddOnId = 6
                    },
                #endregion

                #region Partial Denture Framework AddOn 
                    new TblProductAddOn()
                    {
                        Id = 12,
                        AddOnId = 2,
                        MasterProductId = 2,
                        RequiredInput = false,
                        GroupAddOnId = 2
                    },
                    new TblProductAddOn()
                    {
                        Id = 13,
                        AddOnId = 3,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 1
                    },
                    new TblProductAddOn()
                    {
                        Id = 14,
                        AddOnId = 4,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 1
                    },
                    new TblProductAddOn()
                    {
                        Id = 15,
                        AddOnId = 6,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 1
                    },
                    new TblProductAddOn()
                    {
                        Id = 16,
                        AddOnId = 10,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.Quadrant,
                        GroupAddOnId = 1
                    },
                    new TblProductAddOn()
                    {
                        Id = 17,
                        AddOnId = 18,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 2
                    },
                    new TblProductAddOn()
                    {
                        Id = 18,
                        AddOnId = 19,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 2
                    },
                    new TblProductAddOn()
                    {
                        Id = 19,
                        AddOnId = 20,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 2
                    },
                    new TblProductAddOn()
                    {
                        Id = 20,
                        AddOnId = 24,
                        MasterProductId = 2,
                        RequiredInput = false,
                        GroupAddOnId = 2
                    },
                    new TblProductAddOn()
                    {
                        Id = 21,
                        AddOnId = 25,
                        MasterProductId = 2,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 1
                    },
                    new TblProductAddOn()
                    {
                        Id = 22,
                        AddOnId = 26,
                        MasterProductId = 2,
                        RequiredInput = false,
                        GroupAddOnId = 2
                    },
                #endregion

                #region Temporary Partial Plate AddOn 
                    new TblProductAddOn()
                    {
                        Id = 23,
                        AddOnId = 4,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 3
                    },
                    new TblProductAddOn()
                    {
                        Id = 24,
                        AddOnId = 6,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 3
                    },
                    new TblProductAddOn()
                    {
                        Id = 25,
                        AddOnId = 25,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 3
                    },
                    new TblProductAddOn()
                    {
                        Id = 26,
                        AddOnId = 8,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 27,
                        AddOnId = 11,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 4
                    },
                    new TblProductAddOn()
                    {
                        Id = 28,
                        AddOnId = 12,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 4
                    },
                    new TblProductAddOn()
                    {
                        Id = 29,
                        AddOnId = 23,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 4
                    },
                    new TblProductAddOn()
                    {
                        Id = 30,
                        AddOnId = 20,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 31,
                        AddOnId = 5,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 3
                    },
                    new TblProductAddOn()
                    {
                        Id = 32,
                        AddOnId = 7,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 33,
                        AddOnId = 9,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 34,
                        AddOnId = 14,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 35,
                        AddOnId = 15,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 36,
                        AddOnId = 16,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 37,
                        AddOnId = 17,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 38,
                        AddOnId = 21,
                        MasterProductId = 3,
                        RequiredInput = false,
                        GroupAddOnId = 5
                    },
                    new TblProductAddOn()
                    {
                        Id = 39,
                        AddOnId = 22,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 3
                    },
                    new TblProductAddOn()
                    {
                        Id = 40,
                        AddOnId = 27,
                        MasterProductId = 3,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber,
                        GroupAddOnId = 5
                    },
                #endregion

                #region Bite Block AddOn 
                    new TblProductAddOn()
                    {
                        Id = 41,
                        AddOnId = 4,
                        MasterProductId = 4,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber
                    },
                    new TblProductAddOn()
                    {
                        Id = 42,
                        AddOnId = 6,
                        MasterProductId = 4,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber
                    },
                    new TblProductAddOn()
                    {
                        Id = 43,
                        AddOnId = 27,
                        MasterProductId = 4,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber
                    },
                #endregion

                #region Chrome Cobalt Retaner AddOn 
                    new TblProductAddOn()
                    {
                        Id = 44,
                        AddOnId = 1,
                        MasterProductId = 5,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber
                    },
                    new TblProductAddOn()
                    {
                        Id = 45,
                        AddOnId = 2,
                        MasterProductId = 5,
                        RequiredInput = true,
                        InputType = AddOnInputTypeEnum.TeethNumber
                    }
                    #endregion
                    );
            });

            modelBuilder.Entity<TblProductGroupItem>(entity =>
            {
                entity.HasData(
                    new TblProductGroupItem()
                    {
                        Id = 1,
                        ProductTypeGroupId = 2,
                        ProductId = 1
                    },
                    new TblProductGroupItem()
                    {
                        Id = 2,
                        ProductTypeGroupId = 2,
                        ProductId = 2
                    },
                    new TblProductGroupItem()
                    {
                        Id = 3,
                        ProductTypeGroupId = 2,
                        ProductId = 3
                    },
                    new TblProductGroupItem()
                    {
                        Id = 4,
                        ProductTypeGroupId = 2,
                        ProductId = 4
                    },
                    new TblProductGroupItem()
                    {
                        Id = 5,
                        ProductTypeGroupId = 2,
                        ProductId = 5
                    },
                    new TblProductGroupItem()
                    {
                        Id = 6,
                        ProductTypeGroupId = 2,
                        ProductId = 6
                    },
                    new TblProductGroupItem()
                    {
                        Id = 7,
                        ProductTypeGroupId = 2,
                        ProductId = 7
                    },
                    new TblProductGroupItem()
                    {
                        Id = 8,
                        ProductTypeGroupId = 2,
                        ProductId = 8
                    },
                    new TblProductGroupItem()
                    {
                        Id = 9,
                        ProductTypeGroupId = 2,
                        ProductId = 9
                    },
                    new TblProductGroupItem()
                    {
                        Id = 10,
                        ProductTypeGroupId = 2,
                        ProductId = 10
                    },
                    new TblProductGroupItem()
                    {
                        Id = 11,
                        ProductTypeGroupId = 2,
                        ProductId = 11
                    },
                    new TblProductGroupItem()
                    {
                        Id = 12,
                        ProductTypeGroupId = 2,
                        ProductId = 12
                    },
                    new TblProductGroupItem()
                    {
                        Id = 143,
                        ProductTypeGroupId = 2,
                        ProductId = 143
                    }
                    );
            });

            #endregion
        }

        public static void SeedDataCrownAndBridge(this ModelBuilder modelBuilder)
        {
            #region ProductGroup
            modelBuilder.Entity<TblProductTypeGroup>(entity =>
            {
                entity.HasData(
                    new TblProductTypeGroup()
                    {
                        Id = 12,
                        Name = "All Ceramics",
                        DisplayAsGroup = true,
                        ProductTypeId = 1
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 13,
                        Name = "Zircon Products",
                        DisplayAsGroup = true,
                        ProductTypeId = 1
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 14,
                        Name = "Implants",
                        DisplayAsGroup = true,
                        ProductTypeId = 1
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 15,
                        Name = "Individual Abutments",
                        DisplayAsGroup = true,
                        ProductTypeId = 1
                    });

            });
            #endregion

            #region master product
            modelBuilder.Entity<TblMasterProduct>(entity =>
            {
                entity.HasData(
                    new TblMasterProduct()
                    {
                        Id = 13,
                        Name = "PFM",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/01Tooth.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 14,
                        Name = "Full Metal Crown",
                        ColorCode = "#968226",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/06Extraction.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 15,
                        Name = "Pintooth",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/02Root.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 16,
                        Name = "Inlay Onlay",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/56FillingTop.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 17,
                        Name = "Veneer",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/27Veneer.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 18,
                        Name = "Marryland Bridge",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/29BridgeInstall.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 19,
                        Name = "Temporary",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/48EnamelDefence.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 20,
                        Name = "Acrylic Jacket",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/14CrownInstall.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 21,
                        Name = "Composite",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/CrownAndBridge/Products/16ExtractingTooth.svg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                    new TblMasterProduct()
                    {
                        Id = 126,
                        Name = "PMMA (CAD/CAM)",
                        ColorCode = "",
                        LogoPath = "/ProductIcon/Removable/Products/pmma.jpg",
                        ExpectedProductDay = 3,
                        ProductTypeId = 1
                    },
                     new TblMasterProduct()
                     {
                         Id = 127,
                         Name = "E max",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/eMax.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 128,
                         Name = "E max Cad",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/eMaxCad.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 129,
                         Name = "Empress Cad",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/EmpressCad.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 130,
                         Name = "Tetric Cad",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/TetricCad.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 131,
                         Name = "Lisi Press",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/LisiPress.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 132,
                         Name = "Zircon Crown (with Porcelain Layer)",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Zircon/zircon-crown.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 133,
                         Name = "Full Zircon Crown & Bridge",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Zircon/full-zircom.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 134,
                         Name = "Full Zircon Multilayer (High Strength)",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Zircon/full-zircom.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 135,
                         Name = "Full Zircon Multilayer (High translucent)",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Zircon/full-zircom.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 136,
                         Name = "Stent for Implant",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/stend-for-implant.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 137,
                         Name = "Pre-milled Titanium",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/Premilled-titanium.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 138,
                         Name = "Full-milled Titanium",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/ful-milled-titanium.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 139,
                         Name = "Milled Titanium Bar ( all on 4 )",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/milled-titanium-bar.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 140,
                         Name = "Milled CoCr Implant Bridge",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/milled-cocr-implant-bridge.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 141,
                         Name = "Peek for crown per unit",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/Implants/peek-for-crown-per-unit.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     },
                     new TblMasterProduct()
                     {
                         Id = 142,
                         Name = "Zircon Abutment",
                         ColorCode = "",
                         LogoPath = "/ProductIcon/IndividualAbutments/zircom-abument.jpg",
                         ExpectedProductDay = 3,
                         ProductTypeId = 1
                     }

                );
            });
            #endregion

            #region material
            modelBuilder.Entity<TblMaterial>(entity =>
            {
                entity.HasData(
                    new TblMaterial()
                    {
                        Id = 1,
                        Name = "Non Nickel",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Argen.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 2,
                        Name = "Palladium Silver for FMC",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Argen.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 3,
                        Name = "Palladium Yellow Color for FMC(Au 20%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 4,
                        Name = "Palladium Base for Ceramic (PD 53.80%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 5,
                        Name = "Semi Precious for Ceramic & FMC (Au 52.20%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 6,
                        Name = "High Gold for FMC (Au 68.60%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 7,
                        Name = "High White Gold for Ceramic & FMC (Au 76.80%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 10,
                        Name = "High White Gold for Ceramic (Au 86.70%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg"
                    },
                    new TblMaterial()
                    {
                        Id = 11,
                        Name = "High Gold for FMC (Au 96.30%)",
                        LogoPath = "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg"
                    },
                     new TblMaterial()
                     {
                         Id = 13,
                         Name = "E-Max",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/eMax.jpg"
                     },
                     new TblMaterial()
                     {
                         Id = 14,
                         Name = "Zircon",
                         LogoPath = "/ProductIcon/Zircon/zircon.jpeg"
                     },
                     new TblMaterial()
                     {
                         Id = 15,
                         Name = "E max Cad",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/eMaxCad.jpg"
                     }, new TblMaterial()
                     {
                         Id = 16,
                         Name = "Empress Cad",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/EmpressCad.jpg"
                     }, new TblMaterial()
                     {
                         Id = 17,
                         Name = "Tetric Cad",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/TetricCad.jpg"
                     }, new TblMaterial()
                     {
                         Id = 18,
                         Name = "Lisi Press",
                         LogoPath = "/ProductIcon/CrownAndBridge/InlayOnlay/LisiPress.jpg"
                     },
                     new TblMaterial()
                     {
                         Id = 19,
                         Name = "Zircon With Pocelainer Layer",
                         LogoPath = "/ProductIcon/Zircon/zircon.jpeg"
                     },
                     new TblMaterial()
                     {
                         Id = 20,
                         Name = "Full Zircon Multilayer ( High Translucent )",
                         LogoPath = "/ProductIcon/Zircon/zircon.jpeg"
                     },
                     new TblMaterial()
                     {
                         Id = 21,
                         Name = "Amber",
                         LogoPath = "/ProductIcon/Amber/amber.png"
                     }

                );
            });
            #endregion

            #region Design
            modelBuilder.Entity<TblDesign>(entity =>
            {
                entity.HasData(
                    new TblDesign()
                    {
                        Id = 1,
                        Name = "Occlusal Metal",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/OcclusalMetal.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 2,
                        Name = "3/4 Occlusal Metal",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/3p4OcclusalMetal.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 3,
                        Name = "Buccal Metal Margin",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/BuccalMetalMargin.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 4,
                        Name = "Lingual Metal Margin",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/LingualMetalMargin.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 5,
                        Name = "No Metal Margin",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/NoMetalMargin.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 6,
                        Name = "Porcelain Extended Margin",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/PorcelainExtendedMargin.jpg"
                    },
                    new TblDesign()
                    {
                        Id = 7,
                        Name = "Porcelain Margin",
                        LogoPath = "/ProductIcon/CrownAndBridge/Design/procelain-margin.jpg"
                    }
                );
            });
            #endregion

            #region product ref material
            modelBuilder.Entity<TblProductMaterial>(entity =>
            {
                entity.HasData(
                    new TblProductMaterial()
                    {
                        Id = 1,
                        MasterProductId = 13,
                        MaterialId = 1
                    },
                    new TblProductMaterial()
                    {
                        Id = 2,
                        MasterProductId = 13,
                        MaterialId = 2
                    },
                    new TblProductMaterial()
                    {
                        Id = 3,
                        MasterProductId = 13,
                        MaterialId = 3
                    },
                    new TblProductMaterial()
                    {
                        Id = 4,
                        MasterProductId = 13,
                        MaterialId = 4
                    },
                    new TblProductMaterial()
                    {
                        Id = 5,
                        MasterProductId = 13,
                        MaterialId = 5
                    },
                    new TblProductMaterial()
                    {
                        Id = 6,
                        MasterProductId = 13,
                        MaterialId = 6
                    },
                    new TblProductMaterial()
                    {
                        Id = 7,
                        MasterProductId = 13,
                        MaterialId = 7
                    },
                     new TblProductMaterial()
                     {
                         Id = 17,
                         MasterProductId = 13,
                         MaterialId = 10
                     },
                      new TblProductMaterial()
                      {
                          Id = 18,
                          MasterProductId = 13,
                          MaterialId = 11
                      },

                    new TblProductMaterial()
                    {
                        Id = 8,
                        MasterProductId = 14,
                        MaterialId = 1
                    },
                    new TblProductMaterial()
                    {
                        Id = 9,
                        MasterProductId = 14,
                        MaterialId = 2
                    },
                    new TblProductMaterial()
                    {
                        Id = 10,
                        MasterProductId = 14,
                        MaterialId = 3
                    },
                    new TblProductMaterial()
                    {
                        Id = 11,
                        MasterProductId = 14,
                        MaterialId = 4
                    },
                    new TblProductMaterial()
                    {
                        Id = 12,
                        MasterProductId = 14,
                        MaterialId = 5
                    },
                    new TblProductMaterial()
                    {
                        Id = 13,
                        MasterProductId = 14,
                        MaterialId = 6
                    },
                    new TblProductMaterial()
                    {
                        Id = 14,
                        MasterProductId = 14,
                        MaterialId = 7
                    },
                     new TblProductMaterial()
                     {
                         Id = 19,
                         MasterProductId = 14,
                         MaterialId = 10
                     },
                      new TblProductMaterial()
                      {
                          Id = 20,
                          MasterProductId = 14,
                          MaterialId = 11
                      },


                    new TblProductMaterial()
                    {
                        Id = 22,
                        MasterProductId = 16,
                        MaterialId = 1
                    },
                    new TblProductMaterial()
                    {
                        Id = 23,
                        MasterProductId = 16,
                        MaterialId = 2
                    },
                    new TblProductMaterial()
                    {
                        Id = 24,
                        MasterProductId = 16,
                        MaterialId = 3
                    },
                    new TblProductMaterial()
                    {
                        Id = 25,
                        MasterProductId = 16,
                        MaterialId = 4
                    },
                    new TblProductMaterial()
                    {
                        Id = 26,
                        MasterProductId = 16,
                        MaterialId = 5
                    },
                    new TblProductMaterial()
                    {
                        Id = 27,
                        MasterProductId = 16,
                        MaterialId = 6
                    },
                    new TblProductMaterial()
                    {
                        Id = 28,
                        MasterProductId = 16,
                        MaterialId = 7
                    },
                    new TblProductMaterial()
                    {
                        Id = 29,
                        MasterProductId = 16,
                        MaterialId = 10
                    },
                    new TblProductMaterial()
                    {
                        Id = 30,
                        MasterProductId = 16,
                        MaterialId = 11
                    },
                    new TblProductMaterial()
                    {
                        Id = 31,
                        MasterProductId = 16,
                        MaterialId = 13
                    },
                    new TblProductMaterial()
                    {
                        Id = 32,
                        MasterProductId = 16,
                        MaterialId = 14
                    },

                    new TblProductMaterial()
                    {
                        Id = 33,
                        MasterProductId = 17,
                        MaterialId = 13
                    },
                    new TblProductMaterial()
                    {
                        Id = 34,
                        MasterProductId = 17,
                        MaterialId = 15
                    },
                    new TblProductMaterial()
                    {
                        Id = 35,
                        MasterProductId = 17,
                        MaterialId = 16
                    }, 
                    new TblProductMaterial()
                    {
                        Id = 36,
                        MasterProductId = 17,
                        MaterialId = 17
                    }, 
                    new TblProductMaterial()
                    {
                        Id = 37,
                        MasterProductId = 17,
                        MaterialId = 18
                    }, 
                    new TblProductMaterial()
                    {
                        Id = 38,
                        MasterProductId = 17,
                        MaterialId = 19
                    }, 
                    new TblProductMaterial()
                    {
                        Id = 39,
                        MasterProductId = 17,
                        MaterialId = 20
                    }, 
                    new TblProductMaterial()
                    {
                        Id = 40,
                        MasterProductId = 17,
                        MaterialId = 21
                    }
                );
            });
            #endregion

            #region product ref design
            modelBuilder.Entity<TblProductDesign>(entity =>
            {
                entity.HasData(
                    new TblProductDesign()
                    {
                        Id = 1,
                        MasterProductId = 13,
                        DesignId = 1
                    },
                    new TblProductDesign()
                    {
                        Id = 2,
                        MasterProductId = 13,
                        DesignId = 2
                    },
                    new TblProductDesign()
                    {
                        Id = 3,
                        MasterProductId = 13,
                        DesignId = 3
                    },
                    new TblProductDesign()
                    {
                        Id = 4,
                        MasterProductId = 13,
                        DesignId = 4
                    },
                    new TblProductDesign()
                    {
                        Id = 5,
                        MasterProductId = 13,
                        DesignId = 5
                    },
                    new TblProductDesign()
                    {
                        Id = 6,
                        MasterProductId = 13,
                        DesignId = 6
                    },
                    new TblProductDesign()
                    {
                        Id = 7,
                        MasterProductId = 13,
                        DesignId = 7
                    }
                );
            });
            #endregion

            modelBuilder.Entity<TblProductGroupItem>(entity =>
            {
                entity.HasData(
                    new TblProductGroupItem()
                    {
                        Id = 13,
                        ProductTypeGroupId = 1,
                        ProductId = 13
                    },
                    new TblProductGroupItem()
                    {
                        Id = 14,
                        ProductTypeGroupId = 1,
                        ProductId = 14
                    },
                    new TblProductGroupItem()
                    {
                        Id = 15,
                        ProductTypeGroupId = 1,
                        ProductId = 15
                    },
                    new TblProductGroupItem()
                    {
                        Id = 16,
                        ProductTypeGroupId = 1,
                        ProductId = 16
                    },
                    new TblProductGroupItem()
                    {
                        Id = 17,
                        ProductTypeGroupId = 1,
                        ProductId = 17
                    },
                    new TblProductGroupItem()
                    {
                        Id = 18,
                        ProductTypeGroupId = 1,
                        ProductId = 18
                    },
                    new TblProductGroupItem()
                    {
                        Id = 19,
                        ProductTypeGroupId = 1,
                        ProductId = 19
                    },
                    new TblProductGroupItem()
                    {
                        Id = 20,
                        ProductTypeGroupId = 1,
                        ProductId = 20
                    },
                    new TblProductGroupItem()
                    {
                        Id = 21,
                        ProductTypeGroupId = 1,
                        ProductId = 21
                    },
                    new TblProductGroupItem()
                    {
                        Id = 126,
                        ProductTypeGroupId = 1,
                        ProductId = 126
                    },
                    // Group All Ceramics
                    new TblProductGroupItem()
                    {
                        Id = 127,
                        ProductTypeGroupId = 12,
                        ProductId = 127
                    },
                    new TblProductGroupItem()
                    {
                        Id = 128,
                        ProductTypeGroupId = 12,
                        ProductId = 128
                    },
                    new TblProductGroupItem()
                    {
                        Id = 129,
                        ProductTypeGroupId = 12,
                        ProductId = 129
                    },
                    new TblProductGroupItem()
                    {
                        Id = 130,
                        ProductTypeGroupId = 12,
                        ProductId = 130
                    },
                    new TblProductGroupItem()
                    {
                        Id = 131,
                        ProductTypeGroupId = 12,
                        ProductId = 131
                    }
                    // Zircon Products
                    ,
                    new TblProductGroupItem()
                    {
                        Id = 132,
                        ProductTypeGroupId = 13,
                        ProductId = 132
                    },
                    new TblProductGroupItem()
                    {
                        Id = 133,
                        ProductTypeGroupId = 13,
                        ProductId = 133
                    },
                    new TblProductGroupItem()
                    {
                        Id = 134,
                        ProductTypeGroupId = 13,
                        ProductId = 134
                    },
                    new TblProductGroupItem()
                    {
                        Id = 135,
                        ProductTypeGroupId = 13,
                        ProductId = 135
                    }
                    // Implants
                    ,
                    new TblProductGroupItem()
                    {
                        Id = 136,
                        ProductTypeGroupId = 14,
                        ProductId = 136
                    },
                    new TblProductGroupItem()
                    {
                        Id = 137,
                        ProductTypeGroupId = 14,
                        ProductId = 137
                    },
                    new TblProductGroupItem()
                    {
                        Id = 138,
                        ProductTypeGroupId = 14,
                        ProductId = 138
                    },
                    new TblProductGroupItem()
                    {
                        Id = 139,
                        ProductTypeGroupId = 14,
                        ProductId = 139
                    },
                    new TblProductGroupItem()
                    {
                        Id = 140,
                        ProductTypeGroupId = 14,
                        ProductId = 140
                    },
                    new TblProductGroupItem()
                    {
                        Id = 141,
                        ProductTypeGroupId = 14,
                        ProductId = 141
                    }
                    // Individual Abutments
                    ,
                    new TblProductGroupItem()
                    {
                        Id = 142,
                        ProductTypeGroupId = 15,
                        ProductId = 142
                    }

                );
            });
        }

        public static void SeedDataOrthopedic(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblProductTypeGroup>(entity =>
            {
                entity.HasData(
                    new TblProductTypeGroup()
                    {
                        Id = 3,
                        Name = "Orthopedic",
                        DisplayAsGroup = false,
                        ProductTypeId = 4
                    }
                );
            });

            #region AddOns
            modelBuilder.Entity<TblAddOn>(entity =>
            {
                entity.HasData(
                    new TblAddOn()
                    {
                        Id = 28,
                        Code = "OTA0001",
                        Name = "Solder/Welding ตำแหน่งละ",
                        DisplayName = "Solder/Welding ตำแหน่งละ",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 29,
                        Code = "OTA0018",
                        Name = "Soldering Hook (Hook Included)",
                        DisplayName = "Soldering Hook (Hook Included)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 30,
                        Code = "OTA0014",
                        Name = "Occlusal Coverage / Bite Plane (Mounting Included)",
                        DisplayName = "Occlusal Coverage / Bite Plane (Mounting Included)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 31,
                        Code = "OTA0002",
                        Name = "เติม Spring หรือตะขอ ตำแหน่งละ",
                        DisplayName = "เติม Spring หรือตะขอ ตำแหน่งละ",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 32,
                        Code = "OTA0004",
                        Name = "เติม Tongue Guard/Tongue Wire ตำแหน่งละ",
                        DisplayName = "เติม Tongue Guard/Tongue Wire ตำแหน่งละ",
                        ColorCode = "",
                        LogoPath = ""
                    }, new TblAddOn()
                    {
                        Id = 33,
                        Code = "OTA0017",
                        Name = "Spinner",
                        DisplayName = "Spinner",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 34,
                        Code = "OTA0007",
                        Name = "Sectional Screw, Stainless Steel:100/pcs No.600-500-60",
                        DisplayName = "Sectional Screw, Stainless Steel:100/pcs No.600-500-60",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 35,
                        Code = "OTA0009",
                        Name = "3D Screw - 2 Activation Points",
                        DisplayName = "3D Screw - 2 Activation Points",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 36,
                        Code = "OTA0010",
                        Name = "3D Screw-3 Activation Points",
                        DisplayName = "3D Screw-3 Activation Points",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 37,
                        Code = "OTA0008",
                        Name = "Fan-Type Screw 2 pieces : 9 mm : A0815-14",
                        DisplayName = "Fan-Type Screw 2 pieces : 9 mm : A0815-14",
                        ColorCode = "",
                        LogoPath = ""
                    }, new TblAddOn()
                    {
                        Id = 38,
                        Code = "OTA0012",
                        Name = "Band with Buccal Tube",
                        DisplayName = "Band with Buccal Tube",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 39,
                        Code = "OTA0003",
                        Name = "เติม Bite Plane ตำแหน่งละ",
                        DisplayName = "เติม Bite Plane ตำแหน่งละ",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 40,
                        Code = "OTA0015",
                        Name = "Tripod ( 3 Points, Mounting Included)",
                        DisplayName = "Tripod ( 3 Points, Mounting Included)",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 41,
                        Code = "OTA0011",
                        Name = "Band without Buccal Tube",
                        DisplayName = "Band without Buccal Tube",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 42,
                        Code = "OTA0018",
                        Name = "Soldering Hook (Hook Included)",
                        DisplayName = "Soldering Hook (Hook Included)",
                        ColorCode = "",
                        LogoPath = ""
                    }
                );
            });
            #endregion

            #region master product
            modelBuilder.Entity<TblMasterProduct>(entity =>
            {
                entity.HasData(
                    new TblMasterProduct()
                    {
                        Id = 22,
                        Name = "Schwarz Plate with 1 Screw",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0054"
                    },
                    new TblMasterProduct()
                    {
                        Id = 23,
                        Name = "Schwarz Plate with 2 Screws",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0055"
                    },
                    new TblMasterProduct()
                    {
                        Id = 24,
                        Name = "Schwarz Plate with 3 Screw",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0056"
                    },
                    new TblMasterProduct()
                    {
                        Id = 25,
                        Name = "Schwarz Plate with 3D Screws(2 Activation Points / 3 Activation Points)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0057"
                    },
                    new TblMasterProduct()
                    {
                        Id = 26,
                        Name = "Schwarz Plate with Fan Gear",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0058"
                    },
                    new TblMasterProduct()
                    {
                        Id = 27,
                        Name = "Williams : Lower (Bands & Buttons not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0059"
                    },
                    new TblMasterProduct()
                    {
                        Id = 28,
                        Name = "Garcia Night-Time Retainer : Upper & Lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0072"
                    },
                    new TblMasterProduct()
                    {
                        Id = 29,
                        Name = "Finishing Splint : Upper / Lower (Soldering Hook not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0078"
                    },
                    new TblMasterProduct()
                    {
                        Id = 30,
                        Name = "Maxillary Williams : Upper (Bands & Buttons not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0060"
                    },
                    new TblMasterProduct()
                    {
                        Id = 31,
                        Name = "Bio-Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0074"
                    },
                    new TblMasterProduct()
                    {
                        Id = 32,
                        Name = "Corrector to Open, Corrector to Close, Corrector to Hold",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0069"
                    },
                    new TblMasterProduct()
                    {
                        Id = 33,
                        Name = "Healing Splint : Upper / Lower (Soldering Hook not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0077"
                    },
                    new TblMasterProduct()
                    {
                        Id = 34,
                        Name = "Rick-A-Nator (Soldering Service Included, Bands & Lingual Sheath not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0071"
                    },
                    new TblMasterProduct()
                    {
                        Id = 35,
                        Name = "Truitt 3 (3D Screw , 4 Clasps, 1 Labial Bow, Occlusal Coverage Included, Soldering Service not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0076"
                    },
                    new TblMasterProduct()
                    {
                        Id = 36,
                        Name = "Frankel 3",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0075"
                    },
                    new TblMasterProduct()
                    {
                        Id = 37,
                        Name = "Tooth Setup with Spring Hawley Retainer ( Each Tooth)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0073"
                    },
                    new TblMasterProduct()
                    {
                        Id = 38,
                        Name = "Vinyl Splint : Upper / LowerOT0079 Pivotal Splint : Upper / Lower (Soldering Hook not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0080"
                    },
                    new TblMasterProduct()
                    {
                        Id = 39,
                        Name = "Anterior Deprogramming Appliance (ADA) : Upper / Lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0081"
                    },
                    new TblMasterProduct()
                    {
                        Id = 40,
                        Name = "Tongue Wire & Spinner (Bands not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0082"
                    },
                    new TblMasterProduct()
                    {
                        Id = 41,
                        Name = "Uprighting Spring (Soldering Service Included, Band not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0083"
                    },
                    new TblMasterProduct()
                    {
                        Id = 42,
                        Name = "Power Arm (Soldering Service Included, Band not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0084"
                    },
                    new TblMasterProduct()
                    {
                        Id = 43,
                        Name = "Unilateral C.D. Distalizer (Premolar Bands, 0.9 NiTi Spring, Body Wire, Buccal Tubes and Soldering Service Included, Molar Band not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0085"
                    },
                    new TblMasterProduct()
                    {
                        Id = 44,
                        Name = "Bilateral C.D. Distalizer (Premolar Bands, 0.9 NiTi Springs, Body Wire, Buccal Tubes and Soldering Service Included, Molar Bands not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0086"
                    },
                    new TblMasterProduct()
                    {
                        Id = 45,
                        Name = "Class III Labial Bow (ไม่รวม Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0088"
                    },
                    new TblMasterProduct()
                    {
                        Id = 46,
                        Name = "Pendulum (รวม Screw , ไม่รวม Band และ Lingual Sheath)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0089"
                    },
                    new TblMasterProduct()
                    {
                        Id = 47,
                        Name = "Crozat",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0220"
                    },
                    new TblMasterProduct()
                    {
                        Id = 48,
                        Name = "PMA appliance",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0263"
                    },
                    new TblMasterProduct()
                    {
                        Id = 49,
                        Name = "PMA appliance ไม่รวม Band",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0264"
                    },
                    new TblMasterProduct()
                    {
                        Id = 50,
                        Name = "Class III Williams : Lower (Bands & Buttons not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0061"
                    },
                    new TblMasterProduct()
                    {
                        Id = 51,
                        Name = "Semi-Fixed ALF with 3 Loops : Upper / Lower (Bands not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0062"
                    },
                    new TblMasterProduct()
                    {
                        Id = 52,
                        Name = "Semi-Fixed ALF with 5 Loops : Upper / Lower (Bands not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0063"
                    },
                    new TblMasterProduct()
                    {
                        Id = 53,
                        Name = "Removable ALF with 3 Loops : Upper / Lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0064"
                    },
                    new TblMasterProduct()
                    {
                        Id = 54,
                        Name = "Removable ALF with 5 Loops : Upper / Lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0065"
                    },
                    new TblMasterProduct()
                    {
                        Id = 55,
                        Name = "RN-Sagittal : Upper",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0066"
                    },
                    new TblMasterProduct()
                    {
                        Id = 56,
                        Name = "Trampoline 2 (2 Screws Included, Occlusal Coverage not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0067"
                    },
                    new TblMasterProduct()
                    {
                        Id = 57,
                        Name = "Semi-Fixed TPA Soldered with Gold (Spinner & Soldering Service Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0068"
                    },
                    new TblMasterProduct()
                    {
                        Id = 58,
                        Name = "Twin Block Stage II : Upper",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 4,
                        Code = "OT0070"
                    }
                );
            });
            #endregion

            #region produce group item Xref
            modelBuilder.Entity<TblProductGroupItem>(entity =>
            {
                entity.HasData(
                    new TblProductGroupItem() { Id = 22, ProductTypeGroupId = 3, ProductId = 22 },
                    new TblProductGroupItem() { Id = 23, ProductTypeGroupId = 3, ProductId = 23 },
                    new TblProductGroupItem() { Id = 24, ProductTypeGroupId = 3, ProductId = 24 },
                    new TblProductGroupItem() { Id = 25, ProductTypeGroupId = 3, ProductId = 25 },
                    new TblProductGroupItem() { Id = 26, ProductTypeGroupId = 3, ProductId = 26 },
                    new TblProductGroupItem() { Id = 27, ProductTypeGroupId = 3, ProductId = 27 },
                    new TblProductGroupItem() { Id = 28, ProductTypeGroupId = 3, ProductId = 28 },
                    new TblProductGroupItem() { Id = 29, ProductTypeGroupId = 3, ProductId = 29 },
                    new TblProductGroupItem() { Id = 30, ProductTypeGroupId = 3, ProductId = 30 },
                    new TblProductGroupItem() { Id = 31, ProductTypeGroupId = 3, ProductId = 31 },
                    new TblProductGroupItem() { Id = 32, ProductTypeGroupId = 3, ProductId = 32 },
                    new TblProductGroupItem() { Id = 33, ProductTypeGroupId = 3, ProductId = 33 },
                    new TblProductGroupItem() { Id = 34, ProductTypeGroupId = 3, ProductId = 34 },
                    new TblProductGroupItem() { Id = 35, ProductTypeGroupId = 3, ProductId = 35 },
                    new TblProductGroupItem() { Id = 36, ProductTypeGroupId = 3, ProductId = 36 },
                    new TblProductGroupItem() { Id = 37, ProductTypeGroupId = 3, ProductId = 37 },
                    new TblProductGroupItem() { Id = 38, ProductTypeGroupId = 3, ProductId = 38 },
                    new TblProductGroupItem() { Id = 39, ProductTypeGroupId = 3, ProductId = 39 },
                    new TblProductGroupItem() { Id = 40, ProductTypeGroupId = 3, ProductId = 40 },
                    new TblProductGroupItem() { Id = 41, ProductTypeGroupId = 3, ProductId = 41 },
                    new TblProductGroupItem() { Id = 42, ProductTypeGroupId = 3, ProductId = 42 },
                    new TblProductGroupItem() { Id = 43, ProductTypeGroupId = 3, ProductId = 43 },
                    new TblProductGroupItem() { Id = 44, ProductTypeGroupId = 3, ProductId = 44 },
                    new TblProductGroupItem() { Id = 45, ProductTypeGroupId = 3, ProductId = 45 },
                    new TblProductGroupItem() { Id = 46, ProductTypeGroupId = 3, ProductId = 46 },
                    new TblProductGroupItem() { Id = 47, ProductTypeGroupId = 3, ProductId = 47 },
                    new TblProductGroupItem() { Id = 48, ProductTypeGroupId = 3, ProductId = 48 },
                    new TblProductGroupItem() { Id = 49, ProductTypeGroupId = 3, ProductId = 49 },
                    new TblProductGroupItem() { Id = 50, ProductTypeGroupId = 3, ProductId = 50 },
                    new TblProductGroupItem() { Id = 51, ProductTypeGroupId = 3, ProductId = 51 },
                    new TblProductGroupItem() { Id = 52, ProductTypeGroupId = 3, ProductId = 52 },
                    new TblProductGroupItem() { Id = 53, ProductTypeGroupId = 3, ProductId = 53 },
                    new TblProductGroupItem() { Id = 54, ProductTypeGroupId = 3, ProductId = 54 },
                    new TblProductGroupItem() { Id = 55, ProductTypeGroupId = 3, ProductId = 55 },
                    new TblProductGroupItem() { Id = 56, ProductTypeGroupId = 3, ProductId = 56 },
                    new TblProductGroupItem() { Id = 57, ProductTypeGroupId = 3, ProductId = 57 },
                    new TblProductGroupItem() { Id = 58, ProductTypeGroupId = 3, ProductId = 58 }
                );
            });
            #endregion

            #region product addon Xref
            modelBuilder.Entity<TblProductAddOn>(entity =>
            {
                entity.HasData(
                    //OT0054 Schwarz Plate with 1 Screw
                    new TblProductAddOn() { Id = 46, AddOnId = 28, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 47, AddOnId = 29, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 48, AddOnId = 30, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 49, AddOnId = 31, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 50, AddOnId = 32, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 51, AddOnId = 33, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 52, AddOnId = 34, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 211, AddOnId = 39, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 226, AddOnId = 44, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 227, AddOnId = 45, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 228, AddOnId = 46, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 229, AddOnId = 47, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 230, AddOnId = 48, MasterProductId = 22, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0055 Schwarz Plate with 2 Screws
                    new TblProductAddOn() { Id = 53, AddOnId = 28, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 54, AddOnId = 29, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 55, AddOnId = 30, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 56, AddOnId = 31, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 57, AddOnId = 32, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 58, AddOnId = 33, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 59, AddOnId = 34, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 212, AddOnId = 39, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 231, AddOnId = 44, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 232, AddOnId = 45, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 233, AddOnId = 46, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 234, AddOnId = 47, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 235, AddOnId = 48, MasterProductId = 23, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0056 Schwarz Plate with 3 Screws
                    new TblProductAddOn() { Id = 60, AddOnId = 28, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 61, AddOnId = 29, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 62, AddOnId = 30, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 63, AddOnId = 31, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 64, AddOnId = 32, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 65, AddOnId = 33, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 66, AddOnId = 34, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 213, AddOnId = 39, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 236, AddOnId = 44, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 237, AddOnId = 45, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 238, AddOnId = 46, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 239, AddOnId = 47, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 240, AddOnId = 48, MasterProductId = 24, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0057 Schwarz Plate with 3D Screws(2 Activation Points / 3 Activation Points)
                    new TblProductAddOn() { Id = 67, AddOnId = 28, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 68, AddOnId = 29, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 69, AddOnId = 30, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 70, AddOnId = 31, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 71, AddOnId = 32, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 72, AddOnId = 33, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 214, AddOnId = 39, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 241, AddOnId = 44, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 242, AddOnId = 45, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 243, AddOnId = 46, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 244, AddOnId = 47, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 245, AddOnId = 48, MasterProductId = 25, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0058 Schwarz Plate with Fan Gear
                    new TblProductAddOn() { Id = 75, AddOnId = 28, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 76, AddOnId = 29, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 77, AddOnId = 30, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 78, AddOnId = 31, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 79, AddOnId = 32, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 80, AddOnId = 33, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 81, AddOnId = 37, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 215, AddOnId = 39, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 246, AddOnId = 44, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 247, AddOnId = 45, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 248, AddOnId = 46, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 249, AddOnId = 47, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 250, AddOnId = 48, MasterProductId = 26, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0061 Class III Williams : Lower (Bands & Buttons not Included)
                    new TblProductAddOn() { Id = 82, AddOnId = 42, MasterProductId = 50, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0062 Semi-Fixed ALF with 3 Loops : Upper / Lower (Bands not Included)
                    new TblProductAddOn() { Id = 83, AddOnId = 38, MasterProductId = 51, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 258, AddOnId = 39, MasterProductId = 51, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0063 Semi-Fixed ALF with 5 Loops : Upper / Lower (Bands not Included)
                    new TblProductAddOn() { Id = 84, AddOnId = 38, MasterProductId = 52, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 259, AddOnId = 39, MasterProductId = 52, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0064 Removable ALF with 3 Loops: Upper / Lower
                    new TblProductAddOn() { Id = 85, AddOnId = 38, MasterProductId = 53, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 260, AddOnId = 39, MasterProductId = 53, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0065 Removable ALF with 5 Loops : Upper / Lower
                    new TblProductAddOn() { Id = 86, AddOnId = 38, MasterProductId = 54, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 261, AddOnId = 39, MasterProductId = 54, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0066 RN-Sagittal : Upper
                    new TblProductAddOn() { Id = 87, AddOnId = 28, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 89, AddOnId = 30, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 90, AddOnId = 31, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 91, AddOnId = 32, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 92, AddOnId = 33, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 93, AddOnId = 39, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 94, AddOnId = 40, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 95, AddOnId = 42, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    new TblProductAddOn() { Id = 201, AddOnId = 44, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 202, AddOnId = 45, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 203, AddOnId = 46, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 204, AddOnId = 47, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 205, AddOnId = 48, MasterProductId = 55, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0067 Trampoline 2 (2 Screws Included, Occlusal Coverage not Included)
                    new TblProductAddOn() { Id = 96, AddOnId = 28, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 97, AddOnId = 30, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 98, AddOnId = 31, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 99, AddOnId = 32, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 100, AddOnId = 33, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 101, AddOnId = 39, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 102, AddOnId = 40, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 103, AddOnId = 42, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    new TblProductAddOn() { Id = 206, AddOnId = 44, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 207, AddOnId = 45, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 208, AddOnId = 46, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 209, AddOnId = 47, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 210, AddOnId = 48, MasterProductId = 56, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0068 Semi - Fixed TPA Soldered with Gold(Spinner & Soldering Service Included)
                    new TblProductAddOn() { Id = 104, AddOnId = 28, MasterProductId = 57, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 105, AddOnId = 33, MasterProductId = 57, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 106, AddOnId = 38, MasterProductId = 57, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 107, AddOnId = 41, MasterProductId = 57, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 108, AddOnId = 42, MasterProductId = 57, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0070 Twin Block Stage II : Upper
                    new TblProductAddOn() { Id = 109, AddOnId = 28, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 110, AddOnId = 42, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 221, AddOnId = 44, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 222, AddOnId = 45, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 223, AddOnId = 46, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 224, AddOnId = 47, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 225, AddOnId = 48, MasterProductId = 58, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0069 Corrector to Open, Corrector to Close, Corrector to Hold
                    new TblProductAddOn() { Id = 216, AddOnId = 44, MasterProductId = 32, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 217, AddOnId = 45, MasterProductId = 32, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 218, AddOnId = 46, MasterProductId = 32, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 219, AddOnId = 47, MasterProductId = 32, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 220, AddOnId = 48, MasterProductId = 32, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter }

                );
            });
            #endregion
        }

        public static void SeedDataOrthodontic(this ModelBuilder modelBuilder)
        {
            #region AddOns
            modelBuilder.Entity<TblAddOn>(entity =>
            {
                entity.HasData(
                    new TblAddOn()
                    {
                        Id = 43,
                        Code = "OTA0004 ",
                        Name = "เติม Tongue Guard/Tongue Wire ตำแหน่งละ",
                        DisplayName = "เติม Tongue Guard/Tongue Wire ตำแหน่งละ",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 44,
                        Code = "",
                        Name = "Acrylic Plate",
                        DisplayName = "Acrylic Plate",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 45,
                        Code = "",
                        Name = "Labial Acrylic",
                        DisplayName = "Labial Acrylic",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 46,
                        Code = "",
                        Name = "Buccal Acrylic",
                        DisplayName = "Buccal Acrylic",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 47,
                        Code = "",
                        Name = "Sticker",
                        DisplayName = "Sticker",
                        ColorCode = "",
                        LogoPath = ""
                    },
                    new TblAddOn()
                    {
                        Id = 48,
                        Code = "",
                        Name = "Glitter",
                        DisplayName = "Glitter",
                        ColorCode = "",
                        LogoPath = ""
                    }
                );
            });
            #endregion

            #region Group Item
            modelBuilder.Entity<TblProductTypeGroup>(entity =>
            {
                entity.HasData(
                    new TblProductTypeGroup()
                    {
                        Id = 4,
                        Name = "Anti Snoring",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 7
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 5,
                        Name = "Functional",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 3
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 6,
                        Name = "Model",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 6
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 7,
                        Name = "Retainer",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 1
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 8,
                        Name = "Passive / Active Plate",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 2
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 9,
                        Name = "Space Mantainer",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 4
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 10,
                        Name = "Splint / Stent",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 5
                    },
                    new TblProductTypeGroup()
                    {
                        Id = 11,
                        Name = "Other",
                        DisplayAsGroup = true,
                        ProductTypeId = 3,
                        OrderNumber = 8
                    }
                );
            });
            #endregion

            #region Master product
            modelBuilder.Entity<TblMasterProduct>(entity =>
            {
                entity.HasData(
                    new TblMasterProduct()
                    {
                        Id = 59,
                        Name = "M.D.S.A (Anti Snoring Appliance)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0031"
                    },
                    new TblMasterProduct()
                    {
                        Id = 60,
                        Name = "IST Appliance (Herbst)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0097"
                    },
                    new TblMasterProduct()
                    {
                        Id = 61,
                        Name = "TAP T (Anti-Snoring) Include screw",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0267"
                    },
                    new TblMasterProduct()
                    {
                        Id = 62,
                        Name = "Activator",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0028"
                    },
                    new TblMasterProduct()
                    {
                        Id = 63,
                        Name = "Bionator to Open,to Close,to Hold",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0029"
                    },
                    new TblMasterProduct()
                    {
                        Id = 64,
                        Name = "Twin Block Upper or Lower (ไม่รวม Screw)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0030"
                    },
                    new TblMasterProduct()
                    {
                        Id = 65,
                        Name = "Ortho model upper or lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0024"
                    },
                    new TblMasterProduct()
                    {
                        Id = 66,
                        Name = "Ortho model upper and lower",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0025"
                    },
                    new TblMasterProduct()
                    {
                        Id = 67,
                        Name = "Printed Resin 3D Study Model (per set)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0026"
                    },
                    new TblMasterProduct()
                    {
                        Id = 68,
                        Name = "Study Model (American Polished) per set",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0032"
                    },
                    new TblMasterProduct()
                    {
                        Id = 69,
                        Name = "Study Model not polished per set",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0033"
                    },
                    new TblMasterProduct()
                    {
                        Id = 70,
                        Name = "Working Model / Sending Impression (per set)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0034"
                    },
                    new TblMasterProduct()
                    {
                        Id = 71,
                        Name = "Study Model Scan 3D Digital File (ต่อคู่)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0035"
                    },
                    new TblMasterProduct()
                    {
                        Id = 72,
                        Name = "Printed Resin 3D Study Model (ต่อคู่)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0036"
                    },
                    new TblMasterProduct()
                    {
                        Id = 73,
                        Name = "ต่อฐำน แช่น้ำสบู่ (ต่อชิ้น)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0037"
                    },
                    new TblMasterProduct()
                    {
                        Id = 74,
                        Name = "ต่อฐำน ไม่แช่น้ำสบู่ (ต่อชิ้น)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0038"
                    },
                    new TblMasterProduct()
                    {
                        Id = 75,
                        Name = "Duplicate Model(ต่อคู่)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0041"
                    },
                    new TblMasterProduct()
                    {
                        Id = 76,
                        Name = "Duplicate Model (ชิ้น)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0240"
                    },
                    new TblMasterProduct()
                    {
                        Id = 77,
                        Name = "Model only (Ortho model upper or lower)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0300"
                    },
                    new TblMasterProduct()
                    {
                        Id = 78,
                        Name = "Model only (Ortho model upper + lower)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0301"
                    },
                    new TblMasterProduct()
                    {
                        Id = 79,
                        Name = "Hawley's Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0001"
                    },
                    new TblMasterProduct()
                    {
                        Id = 80,
                        Name = "Wrap Around Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0002"
                    },
                    new TblMasterProduct()
                    {
                        Id = 81,
                        Name = "Clear Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0003"
                    },
                    new TblMasterProduct()
                    {
                        Id = 82,
                        Name = "Celar Bow (Included Acrylic Plate)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0004"
                    },
                    new TblMasterProduct()
                    {
                        Id = 83,
                        Name = "Spring Hawley Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0005"
                    },
                    new TblMasterProduct()
                    {
                        Id = 84,
                        Name = "Advance Functional Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0006"
                    },
                    new TblMasterProduct()
                    {
                        Id = 85,
                        Name = "C-C Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0007"
                    },
                    new TblMasterProduct()
                    {
                        Id = 86,
                        Name = "Chrome Cobalt Retainer",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = ""
                    },
                    new TblMasterProduct()
                    {
                        Id = 87,
                        Name = "Removable with Any Springs",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0008"
                    },
                    new TblMasterProduct()
                    {
                        Id = 88,
                        Name = "Removable with Screw",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0009"
                    },
                    new TblMasterProduct()
                    {
                        Id = 89,
                        Name = "Removable with Screw (ไม่รวม Screw)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0010"
                    },
                    new TblMasterProduct()
                    {
                        Id = 90,
                        Name = "Quad Helix",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0011"
                    },
                    new TblMasterProduct()
                    {
                        Id = 91,
                        Name = "Hyrax Expansion Screw",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0012"
                    },
                    new TblMasterProduct()
                    {
                        Id = 92,
                        Name = "Lip Bumper Appliance",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0013"
                    },
                    new TblMasterProduct()
                    {
                        Id = 93,
                        Name = "Setup Tooth with Clear Aligner",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0027"
                    },
                    new TblMasterProduct()
                    {
                        Id = 94,
                        Name = "Set Up Tooth (per tooth)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0039"
                    },
                    new TblMasterProduct()
                    {
                        Id = 95,
                        Name = "Set Up Model (ต่อชิ้น)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0040"
                    },
                    new TblMasterProduct()
                    {
                        Id = 96,
                        Name = " Hexa Lingual Individual Bracket Placement (ต่อซี่น)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0042"
                    },
                    new TblMasterProduct()
                    {
                        Id = 97,
                        Name = "Labial Indirect Matrix Bonding (Upper or Lower)(ไม่รวม Bracket)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0043"
                    },
                    new TblMasterProduct()
                    {
                        Id = 98,
                        Name = "Anterior Bite Plane (รวมตะขอ) number of ball",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0052"
                    },
                    new TblMasterProduct()
                    {
                        Id = 99,
                        Name = "Posterior Bite Plane (รวมตะขอ)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0053"
                    },
                    new TblMasterProduct()
                    {
                        Id = 100,
                        Name = "Band and Loop (ไม่รวม Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0017"
                    },
                    new TblMasterProduct()
                    {
                        Id = 101,
                        Name = "Distal Shoe (ไม่รวม Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0018"
                    },
                    new TblMasterProduct()
                    {
                        Id = 102,
                        Name = "Trans Palatal Bar or TPA (Not included Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0019"
                    },
                    new TblMasterProduct()
                    {
                        Id = 103,
                        Name = "Mandibular Lingual Holding Arch (ไม่รวม Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0020"
                    },
                    new TblMasterProduct()
                    {
                        Id = 104,
                        Name = "Nance:Upper (Soldering Service Included,Not included Band)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0021"
                    },
                    new TblMasterProduct()
                    {
                        Id = 105,
                        Name = "Tongue Clip",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0022"
                    },
                    new TblMasterProduct()
                    {
                        Id = 106,
                        Name = "TPA and Nance (soldering Service Included, Band Not Included)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0232"
                    },
                    new TblMasterProduct()
                    {
                        Id = 107,
                        Name = "Occlusal Splint (Hard)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0014"
                    },
                    new TblMasterProduct()
                    {
                        Id = 108,
                        Name = "Stent for Implant (Self Cure)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0016"
                    },
                    new TblMasterProduct()
                    {
                        Id = 109,
                        Name = "Garger Splint (Inside soft/Outside hard)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0023"
                    },
                    new TblMasterProduct()
                    {
                        Id = 110,
                        Name = "Damon Splint ( 2 template 1mm )",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0178"
                    },
                    new TblMasterProduct()
                    {
                        Id = 111,
                        Name = "3D Printed Surgical Splint",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0305"
                    },
                    new TblMasterProduct()
                    {
                        Id = 112,
                        Name = "Milled Occlusal Splint",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0310"
                    },
                    new TblMasterProduct()
                    {
                        Id = 113,
                        Name = "Stent for Implant (Vacum Plate)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0321"
                    },
                    new TblMasterProduct()
                    {
                        Id = 114,
                        Name = "Clape Palate (Obtulator Palate)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0015"
                    },
                    new TblMasterProduct()
                    {
                        Id = 115,
                        Name = "Night Guard (Soft)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0044"
                    },
                    new TblMasterProduct()
                    {
                        Id = 116,
                        Name = "Night Guard (Hard)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0045"
                    },
                    new TblMasterProduct()
                    {
                        Id = 117,
                        Name = "Mouth Guard 3 MM ( Clear/Color)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0046"
                    },
                    new TblMasterProduct()
                    {
                        Id = 118,
                        Name = "Mouth Guard 4 MM ( Clear)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0047"
                    },
                    new TblMasterProduct()
                    {
                        Id = 119,
                        Name = "Mouth Guard 5 MM ( Clear/color)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0048"
                    },
                    new TblMasterProduct()
                    {
                        Id = 120,
                        Name = "Mouth Guard 6 MM ( Clear/color)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0049"
                    },
                    new TblMasterProduct()
                    {
                        Id = 121,
                        Name = "Bleaching Tray (รวม sheet)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0050"
                    },
                    new TblMasterProduct()
                    {
                        Id = 122,
                        Name = "Bleaching Tray (ไม่รวม sheet)",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0051"
                    },
                    new TblMasterProduct()
                    {
                        Id = 123,
                        Name = "Night Guard (soft) 4 mm.",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0183"
                    },
                    new TblMasterProduct()
                    {
                        Id = 124,
                        Name = "3D Printed Nasal Form",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0268"
                    },
                    new TblMasterProduct()
                    {
                        Id = 125,
                        Name = "Night Guard Hard/Soft",
                        ColorCode = "",
                        LogoPath = "",
                        ExpectedProductDay = 3,
                        ProductTypeId = 3,
                        Code = "OT0343"
                    }
                );
            });
            #endregion

            #region Product Group Xref
            modelBuilder.Entity<TblProductGroupItem>(entity =>
            {
                entity.HasData(
                    //Anti Snoring
                    new TblProductGroupItem() { Id = 59, ProductTypeGroupId = 4, ProductId = 59 },
                    new TblProductGroupItem() { Id = 60, ProductTypeGroupId = 4, ProductId = 60 },
                    new TblProductGroupItem() { Id = 61, ProductTypeGroupId = 4, ProductId = 61 },

                    //Functional
                    new TblProductGroupItem() { Id = 62, ProductTypeGroupId = 5, ProductId = 62 },
                    new TblProductGroupItem() { Id = 63, ProductTypeGroupId = 5, ProductId = 63 },
                    new TblProductGroupItem() { Id = 64, ProductTypeGroupId = 5, ProductId = 64 },

                    //Model
                    new TblProductGroupItem() { Id = 65, ProductTypeGroupId = 6, ProductId = 65 },
                    new TblProductGroupItem() { Id = 66, ProductTypeGroupId = 6, ProductId = 66 },
                    new TblProductGroupItem() { Id = 67, ProductTypeGroupId = 6, ProductId = 67 },
                    new TblProductGroupItem() { Id = 68, ProductTypeGroupId = 6, ProductId = 68 },
                    new TblProductGroupItem() { Id = 69, ProductTypeGroupId = 6, ProductId = 69 },
                    new TblProductGroupItem() { Id = 70, ProductTypeGroupId = 6, ProductId = 70 },
                    new TblProductGroupItem() { Id = 71, ProductTypeGroupId = 6, ProductId = 71 },
                    new TblProductGroupItem() { Id = 72, ProductTypeGroupId = 6, ProductId = 72 },
                    new TblProductGroupItem() { Id = 73, ProductTypeGroupId = 6, ProductId = 73 },
                    new TblProductGroupItem() { Id = 74, ProductTypeGroupId = 6, ProductId = 74 },
                    new TblProductGroupItem() { Id = 75, ProductTypeGroupId = 6, ProductId = 75 },
                    new TblProductGroupItem() { Id = 76, ProductTypeGroupId = 6, ProductId = 76 },
                    new TblProductGroupItem() { Id = 77, ProductTypeGroupId = 6, ProductId = 77 },
                    new TblProductGroupItem() { Id = 78, ProductTypeGroupId = 6, ProductId = 78 },

                    //Retainer
                    new TblProductGroupItem() { Id = 79, ProductTypeGroupId = 7, ProductId = 79 },
                    new TblProductGroupItem() { Id = 80, ProductTypeGroupId = 7, ProductId = 80 },
                    new TblProductGroupItem() { Id = 81, ProductTypeGroupId = 7, ProductId = 81 },
                    new TblProductGroupItem() { Id = 82, ProductTypeGroupId = 7, ProductId = 82 },
                    new TblProductGroupItem() { Id = 83, ProductTypeGroupId = 7, ProductId = 83 },
                    new TblProductGroupItem() { Id = 84, ProductTypeGroupId = 7, ProductId = 84 },
                    new TblProductGroupItem() { Id = 85, ProductTypeGroupId = 7, ProductId = 85 },
                    new TblProductGroupItem() { Id = 86, ProductTypeGroupId = 7, ProductId = 86 },

                    //Passive / Active Plate
                    new TblProductGroupItem() { Id = 87, ProductTypeGroupId = 8, ProductId = 87 },
                    new TblProductGroupItem() { Id = 88, ProductTypeGroupId = 8, ProductId = 88 },
                    new TblProductGroupItem() { Id = 89, ProductTypeGroupId = 8, ProductId = 89 },
                    new TblProductGroupItem() { Id = 90, ProductTypeGroupId = 8, ProductId = 90 },
                    new TblProductGroupItem() { Id = 91, ProductTypeGroupId = 8, ProductId = 91 },
                    new TblProductGroupItem() { Id = 92, ProductTypeGroupId = 8, ProductId = 92 },
                    new TblProductGroupItem() { Id = 93, ProductTypeGroupId = 8, ProductId = 93 },
                    new TblProductGroupItem() { Id = 95, ProductTypeGroupId = 8, ProductId = 95 },
                    new TblProductGroupItem() { Id = 96, ProductTypeGroupId = 8, ProductId = 96 },
                    new TblProductGroupItem() { Id = 97, ProductTypeGroupId = 8, ProductId = 97 },
                    new TblProductGroupItem() { Id = 98, ProductTypeGroupId = 8, ProductId = 98 },
                    new TblProductGroupItem() { Id = 99, ProductTypeGroupId = 8, ProductId = 99 },

                    //Space Mantainer
                    new TblProductGroupItem() { Id = 100, ProductTypeGroupId = 9, ProductId = 100 },
                    new TblProductGroupItem() { Id = 101, ProductTypeGroupId = 9, ProductId = 101 },
                    new TblProductGroupItem() { Id = 102, ProductTypeGroupId = 9, ProductId = 102 },
                    new TblProductGroupItem() { Id = 103, ProductTypeGroupId = 9, ProductId = 103 },
                    new TblProductGroupItem() { Id = 104, ProductTypeGroupId = 9, ProductId = 104 },
                    new TblProductGroupItem() { Id = 105, ProductTypeGroupId = 9, ProductId = 105 },
                    new TblProductGroupItem() { Id = 106, ProductTypeGroupId = 9, ProductId = 106 },

                    //Splint / Stent
                    new TblProductGroupItem() { Id = 107, ProductTypeGroupId = 10, ProductId = 107 },
                    new TblProductGroupItem() { Id = 108, ProductTypeGroupId = 10, ProductId = 108 },
                    new TblProductGroupItem() { Id = 109, ProductTypeGroupId = 10, ProductId = 109 },
                    new TblProductGroupItem() { Id = 110, ProductTypeGroupId = 10, ProductId = 110 },
                    new TblProductGroupItem() { Id = 111, ProductTypeGroupId = 10, ProductId = 111 },
                    new TblProductGroupItem() { Id = 112, ProductTypeGroupId = 10, ProductId = 112 },
                    new TblProductGroupItem() { Id = 113, ProductTypeGroupId = 10, ProductId = 113 },

                    //Orther
                    new TblProductGroupItem() { Id = 114, ProductTypeGroupId = 11, ProductId = 114 },
                    new TblProductGroupItem() { Id = 115, ProductTypeGroupId = 11, ProductId = 115 },
                    new TblProductGroupItem() { Id = 116, ProductTypeGroupId = 11, ProductId = 116 },
                    new TblProductGroupItem() { Id = 117, ProductTypeGroupId = 11, ProductId = 117 },
                    new TblProductGroupItem() { Id = 118, ProductTypeGroupId = 11, ProductId = 118 },
                    new TblProductGroupItem() { Id = 119, ProductTypeGroupId = 11, ProductId = 119 },
                    new TblProductGroupItem() { Id = 120, ProductTypeGroupId = 11, ProductId = 120 },
                    new TblProductGroupItem() { Id = 121, ProductTypeGroupId = 11, ProductId = 121 },
                    new TblProductGroupItem() { Id = 122, ProductTypeGroupId = 11, ProductId = 122 },
                    new TblProductGroupItem() { Id = 123, ProductTypeGroupId = 11, ProductId = 123 },
                    new TblProductGroupItem() { Id = 124, ProductTypeGroupId = 11, ProductId = 124 },
                    new TblProductGroupItem() { Id = 125, ProductTypeGroupId = 11, ProductId = 125 }
                );
            });
            #endregion

            #region Product Addon Xref
            modelBuilder.Entity<TblProductAddOn>(entity =>
            {
                entity.HasData(
                    //OT0028 Activator
                    new TblProductAddOn() { Id = 111, AddOnId = 34, MasterProductId = 62, RequiredInput = false},

                    new TblProductAddOn() { Id = 146, AddOnId = 44, MasterProductId = 62, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 147, AddOnId = 45, MasterProductId = 62, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 148, AddOnId = 46, MasterProductId = 62, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 149, AddOnId = 47, MasterProductId = 62, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 150, AddOnId = 48, MasterProductId = 62, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0029 Bionater to Open,to Close,to Hold
                    new TblProductAddOn() { Id = 112, AddOnId = 34, MasterProductId = 63, RequiredInput = false},

                    new TblProductAddOn() { Id = 151, AddOnId = 44, MasterProductId = 63, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 152, AddOnId = 45, MasterProductId = 63, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 153, AddOnId = 46, MasterProductId = 63, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 154, AddOnId = 47, MasterProductId = 63, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 155, AddOnId = 48, MasterProductId = 63, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0030 Twin Block Upper or Lower (ไม่รวม Screw)
                    new TblProductAddOn() { Id = 113, AddOnId = 34, MasterProductId = 64, RequiredInput = false},

                    new TblProductAddOn() { Id = 156, AddOnId = 44, MasterProductId = 64, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 157, AddOnId = 45, MasterProductId = 64, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 158, AddOnId = 46, MasterProductId = 64, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 159, AddOnId = 47, MasterProductId = 64, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 160, AddOnId = 48, MasterProductId = 64, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },


                    //OT0008 Removable with Any Springs
                    new TblProductAddOn() { Id = 114, AddOnId = 28, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 115, AddOnId = 31, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 116, AddOnId = 39, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 117, AddOnId = 32, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 118, AddOnId = 42, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 119, AddOnId = 30, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 120, AddOnId = 33, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },


                    new TblProductAddOn() { Id = 191, AddOnId = 44, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 192, AddOnId = 45, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 193, AddOnId = 46, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 194, AddOnId = 47, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 195, AddOnId = 48, MasterProductId = 87, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },
                    

                    //OT0009 Removable with Screw
                    new TblProductAddOn() { Id = 121, AddOnId = 28, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 122, AddOnId = 31, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 123, AddOnId = 39, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 124, AddOnId = 32, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 125, AddOnId = 42, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 126, AddOnId = 30, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 127, AddOnId = 33, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 128, AddOnId = 34, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 129, AddOnId = 37, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 130, AddOnId = 35, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 131, AddOnId = 36, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    new TblProductAddOn() { Id = 196, AddOnId = 44, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 197, AddOnId = 45, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 198, AddOnId = 46, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 199, AddOnId = 47, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 200, AddOnId = 48, MasterProductId = 88, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT00010 Removable with Screw (ไม่รวม Screw)
                    new TblProductAddOn() { Id = 251, AddOnId = 44, MasterProductId = 89, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 252, AddOnId = 45, MasterProductId = 89, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 253, AddOnId = 46, MasterProductId = 89, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 256, AddOnId = 47, MasterProductId = 89, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 257, AddOnId = 48, MasterProductId = 89, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    //OT0011 Quad Helix
                    new TblProductAddOn() { Id = 132, AddOnId = 28, MasterProductId = 90, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 133, AddOnId = 42, MasterProductId = 90, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 134, AddOnId = 41, MasterProductId = 90, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 135, AddOnId = 38, MasterProductId = 90, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },


                    //OT0012 Hyrax Expansion Screw
                    new TblProductAddOn() { Id = 136, AddOnId = 28, MasterProductId = 91, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 137, AddOnId = 42, MasterProductId = 91, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 138, AddOnId = 41, MasterProductId = 91, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 139, AddOnId = 38, MasterProductId = 91, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 140, AddOnId = 30, MasterProductId = 91, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //OT0013 Lip Bumper Appliance
                    new TblProductAddOn() { Id = 141, AddOnId = 28, MasterProductId = 92, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 142, AddOnId = 42, MasterProductId = 92, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 143, AddOnId = 41, MasterProductId = 92, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 144, AddOnId = 38, MasterProductId = 92, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },
                    new TblProductAddOn() { Id = 145, AddOnId = 30, MasterProductId = 92, RequiredInput = true, InputType = AddOnInputTypeEnum.Number },

                    //Group Retainer sticker (master product id 79-86)
                    new TblProductAddOn() { Id = 161, AddOnId = 44, MasterProductId = 79, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 162, AddOnId = 45, MasterProductId = 79, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 163, AddOnId = 46, MasterProductId = 79, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 164, AddOnId = 47, MasterProductId = 79, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 165, AddOnId = 48, MasterProductId = 79, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    new TblProductAddOn() { Id = 166, AddOnId = 44, MasterProductId = 80, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 167, AddOnId = 45, MasterProductId = 80, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 168, AddOnId = 46, MasterProductId = 80, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 169, AddOnId = 47, MasterProductId = 80, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 170, AddOnId = 48, MasterProductId = 80, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    new TblProductAddOn() { Id = 171, AddOnId = 44, MasterProductId = 82, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 174, AddOnId = 47, MasterProductId = 82, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 175, AddOnId = 48, MasterProductId = 82, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    new TblProductAddOn() { Id = 176, AddOnId = 44, MasterProductId = 83, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 177, AddOnId = 45, MasterProductId = 83, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 178, AddOnId = 46, MasterProductId = 83, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 179, AddOnId = 47, MasterProductId = 83, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 180, AddOnId = 48, MasterProductId = 83, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    new TblProductAddOn() { Id = 181, AddOnId = 44, MasterProductId = 84, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 182, AddOnId = 45, MasterProductId = 84, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 183, AddOnId = 46, MasterProductId = 84, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 184, AddOnId = 47, MasterProductId = 84, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 185, AddOnId = 48, MasterProductId = 84, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter },

                    new TblProductAddOn() { Id = 186, AddOnId = 44, MasterProductId = 86, RequiredInput = true, InputType = AddOnInputTypeEnum.Plate },
                    new TblProductAddOn() { Id = 187, AddOnId = 45, MasterProductId = 86, RequiredInput = true, InputType = AddOnInputTypeEnum.Labial },
                    new TblProductAddOn() { Id = 188, AddOnId = 46, MasterProductId = 86, RequiredInput = true, InputType = AddOnInputTypeEnum.Buccal },
                    new TblProductAddOn() { Id = 189, AddOnId = 47, MasterProductId = 86, RequiredInput = true, InputType = AddOnInputTypeEnum.Sticker },
                    new TblProductAddOn() { Id = 190, AddOnId = 48, MasterProductId = 86, RequiredInput = true, InputType = AddOnInputTypeEnum.Glitter }


                );
            });
            #endregion
        }

        public static void SeedStatusAndUserContact(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblOrderStatus>(entity =>
            {
                entity.HasData(
                    new TblOrderStatus()
                    {
                        Id = 1,
                        Name = "Draft"
                    },
                    new TblOrderStatus()
                    {
                        Id = 2,
                        Name = "Waiting Order"
                    },
                    new TblOrderStatus()
                    {
                        Id = 3,
                        Name = "Ordered"
                    },
                    new TblOrderStatus()
                    {
                        Id = 4,
                        Name = "Canceled"
                    },
                    new TblOrderStatus()
                    {
                        Id = 5,
                        Name = "Delivery"
                    },
                    new TblOrderStatus()
                    {
                        Id = 6,
                        Name = "Completed"
                    },
                    new TblOrderStatus()
                    {
                        Id = 7,
                        Name = "Reject"
                    });
            });
        }
        
        public static void SeedDataCatalog(this ModelBuilder modelBuilder)
        {
            #region catalog group
            modelBuilder.Entity<TblCatalogGroup>(entity =>
            {
                entity.HasData(
                    new TblCatalogGroup()
                    {
                        Id = 1,
                        Name = "Plate"
                    },
                    new TblCatalogGroup()
                    {
                        Id = 2,
                        Name = "Glitter"
                    });
            });
            #endregion

            #region catalog path
            modelBuilder.Entity<TblCatalog>(entity =>
            {
                entity.HasData(
                #region plate 
                    new TblCatalog()
                    {
                        Id = 1,
                        Name = "Red 901",
                        LogoPath = "/Catalog/901.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 1
                    },
                    new TblCatalog()
                    {
                        Id = 2,
                        Name = "Yellow 902",
                        LogoPath = "/Catalog/902.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 2
                    },
                    new TblCatalog()
                    {
                        Id = 3,
                        Name = "Blue 903",
                        LogoPath = "/Catalog/903.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 3
                    },
                    new TblCatalog()
                    {
                        Id = 4,
                        Name = "Green 904",
                        LogoPath = "/Catalog/904.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 4
                    },
                    new TblCatalog()
                    {
                        Id = 5,
                        Name = "Blue 905",
                        LogoPath = "/Catalog/905.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 5
                    },
                    new TblCatalog()
                    {
                        Id = 6,
                        Name = "Blue 906",
                        LogoPath = "/Catalog/906.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 6
                    },
                    new TblCatalog()
                    {
                        Id = 7,
                        Name = "Purple 907",
                        LogoPath = "/Catalog/907.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 7
                    },
                    new TblCatalog()
                    {
                        Id = 8,
                        Name = "Turquoise 908",
                        LogoPath = "/Catalog/908.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 8
                    },
                    new TblCatalog()
                    {
                        Id = 9,
                        Name = "White 909",
                        LogoPath = "/Catalog/909.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 9
                    },
                    new TblCatalog()
                    {
                        Id = 10,
                        Name = "Violet 910",
                        LogoPath = "/Catalog/910.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 10
                    },
                    new TblCatalog()
                    {
                        Id = 11,
                        Name = "Black 912",
                        LogoPath = "/Catalog/912.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 11
                    },
                    new TblCatalog()
                    {
                        Id = 12,
                        Name = "Magenta 913",
                        LogoPath = "/Catalog/913.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 12
                    },
                    new TblCatalog()
                    {
                        Id = 13,
                        Name = "Neon Yellow 914",
                        LogoPath = "/Catalog/914.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 13
                    },
                    new TblCatalog()
                    {
                        Id = 14,
                        Name = "Neon Green 915",
                        LogoPath = "/Catalog/915.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 14
                    },
                    new TblCatalog()
                    {
                        Id = 15,
                        Name = "Neon Orange 916",
                        LogoPath = "/Catalog/916.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 15
                    },
                    new TblCatalog()
                    {
                        Id = 16,
                        Name = "Neon Pink 917",
                        LogoPath = "/Catalog/917.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 16
                    },
                    new TblCatalog()
                    {
                        Id = 17,
                        Name = "Pink Opaque 921",
                        LogoPath = "/Catalog/921.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 17
                    },
                    new TblCatalog()
                    {
                        Id = 18,
                        Name = "Clear 922",
                        LogoPath = "/Catalog/922.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 18
                    },
                    new TblCatalog()
                    {
                        Id = 19,
                        Name = "Pink Tone 923",
                        LogoPath = "/Catalog/923.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 19
                    },
                    new TblCatalog()
                    {
                        Id = 20,
                        Name = "027",
                        LogoPath = "/Catalog/027.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 27
                    },
                    new TblCatalog()
                    {
                        Id = 21,
                        Name = "031",
                        LogoPath = "/Catalog/031.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 31
                    },
                    new TblCatalog()
                    {
                        Id = 22,
                        Name = "033",
                        LogoPath = "/Catalog/033.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 33
                    },
                    new TblCatalog()
                    {
                        Id = 23,
                        Name = "034",
                        LogoPath = "/Catalog/034.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 34
                    },
                    new TblCatalog()
                    {
                        Id = 24,
                        Name = "035",
                        LogoPath = "/Catalog/035.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 35
                    },
                    new TblCatalog()
                    {
                        Id = 25,
                        Name = "036",
                        LogoPath = "/Catalog/036.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 36
                    },
                    new TblCatalog()
                    {
                        Id = 26,
                        Name = "037",
                        LogoPath = "/Catalog/037.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 37
                    },
                    new TblCatalog()
                    {
                        Id = 27,
                        Name = "038",
                        LogoPath = "/Catalog/038.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 38
                    },
                    new TblCatalog()
                    {
                        Id = 28,
                        Name = "042",
                        LogoPath = "/Catalog/042.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 42
                    },
                    new TblCatalog()
                    {
                        Id = 29,
                        Name = "043",
                        LogoPath = "/Catalog/043.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 46
                    },
                    new TblCatalog()
                    {
                        Id = 30,
                        Name = "044",
                        LogoPath = "/Catalog/044.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 47
                    },
                    new TblCatalog()
                    {
                        Id = 31,
                        Name = "045",
                        LogoPath = "/Catalog/045.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 48
                    },
                    new TblCatalog()
                    {
                        Id = 32,
                        Name = "046",
                        LogoPath = "/Catalog/046.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 49
                    },
                    new TblCatalog()
                    {
                        Id = 33,
                        Name = "047",
                        LogoPath = "/Catalog/047.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 50
                    },
                    new TblCatalog()
                    {
                        Id = 34,
                        Name = "048",
                        LogoPath = "/Catalog/048.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 51
                    },
                    new TblCatalog()
                    {
                        Id = 35,
                        Name = "049",
                        LogoPath = "/Catalog/049.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 52
                    },
                    new TblCatalog()
                    {
                        Id = 36,
                        Name = "050",
                        LogoPath = "/Catalog/050.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 53
                    },
                    new TblCatalog()
                    {
                        Id = 37,
                        Name = "051",
                        LogoPath = "/Catalog/051.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 54
                    },
                    new TblCatalog()
                    {
                        Id = 38,
                        Name = "052",
                        LogoPath = "/Catalog/052.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 55
                    },
                    new TblCatalog()
                    {
                        Id = 39,
                        Name = "053",
                        LogoPath = "/Catalog/053.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 56
                    },
                    new TblCatalog()
                    {
                        Id = 40,
                        Name = "054",
                        LogoPath = "/Catalog/054.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 57
                    },
                    new TblCatalog()
                    {
                        Id = 41,
                        Name = "055",
                        LogoPath = "/Catalog/055.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 58
                    },
                    new TblCatalog()
                    {
                        Id = 42,
                        Name = "056",
                        LogoPath = "/Catalog/056.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 59
                    },
                    new TblCatalog()
                    {
                        Id = 43,
                        Name = "057",
                        LogoPath = "/Catalog/057.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 60
                    },
                    new TblCatalog()
                    {
                        Id = 44,
                        Name = "058",
                        LogoPath = "/Catalog/058.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 61
                    },
                    new TblCatalog()
                    {
                        Id = 45,
                        Name = "059",
                        LogoPath = "/Catalog/059.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 62
                    },
                    new TblCatalog()
                    {
                        Id = 46,
                        Name = "060",
                        LogoPath = "/Catalog/060.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 63
                    },
                    new TblCatalog()
                    {
                        Id = 47,
                        Name = "061",
                        LogoPath = "/Catalog/061.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 64
                    },
                    new TblCatalog()
                    {
                        Id = 48,
                        Name = "062",
                        LogoPath = "/Catalog/062.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 65
                    },
                    new TblCatalog()
                    {
                        Id = 49,
                        Name = "063",
                        LogoPath = "/Catalog/063.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 66
                    },
                    new TblCatalog()
                    {
                        Id = 50,
                        Name = "064",
                        LogoPath = "/Catalog/064.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 67
                    },
                    new TblCatalog()
                    {
                        Id = 51,
                        Name = "065",
                        LogoPath = "/Catalog/065.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 68
                    },
                    new TblCatalog()
                    {
                        Id = 52,
                        Name = "066",
                        LogoPath = "/Catalog/066.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 69
                    },
                    new TblCatalog()
                    {
                        Id = 53,
                        Name = "067",
                        LogoPath = "/Catalog/067.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 70
                    },
                    new TblCatalog()
                    {
                        Id = 54,
                        Name = "068",
                        LogoPath = "/Catalog/068.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 71
                    },
                    new TblCatalog()
                    {
                        Id = 55,
                        Name = "060",
                        LogoPath = "/Catalog/069.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 72
                    },
                    new TblCatalog()
                    {
                        Id = 56,
                        Name = "070",
                        LogoPath = "/Catalog/070.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 73
                    },
                    new TblCatalog()
                    {
                        Id = 57,
                        Name = "071",
                        LogoPath = "/Catalog/071.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 74
                    },
                    new TblCatalog()
                    {
                        Id = 58,
                        Name = "072",
                        LogoPath = "/Catalog/072.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 75
                    },
                    new TblCatalog()
                    {
                        Id = 59,
                        Name = "073",
                        LogoPath = "/Catalog/073.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 76
                    },
                    new TblCatalog()
                    {
                        Id = 60,
                        Name = "074",
                        LogoPath = "/Catalog/074.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 77
                    },
                    new TblCatalog()
                    {
                        Id = 61,
                        Name = "075",
                        LogoPath = "/Catalog/075.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 78
                    },
                    new TblCatalog()
                    {
                        Id = 62,
                        Name = "076",
                        LogoPath = "/Catalog/076.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 79
                    },
                    new TblCatalog()
                    {
                        Id = 63,
                        Name = "077",
                        LogoPath = "/Catalog/077.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 80
                    },
                    new TblCatalog()
                    {
                        Id = 64,
                        Name = "078",
                        LogoPath = "/Catalog/078.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 81
                    },
                    new TblCatalog()
                    {
                        Id = 65,
                        Name = "079",
                        LogoPath = "/Catalog/079.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 82
                    },
                    new TblCatalog()
                    {
                        Id = 66,
                        Name = "080",
                        LogoPath = "/Catalog/080.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 83
                    },
                    new TblCatalog()
                    {
                        Id = 67,
                        Name = "081",
                        LogoPath = "/Catalog/081.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 84
                    },
                    new TblCatalog()
                    {
                        Id = 68,
                        Name = "082",
                        LogoPath = "/Catalog/082.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 85
                    },
                    new TblCatalog()
                    {
                        Id = 69,
                        Name = "083",
                        LogoPath = "/Catalog/083.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 86
                    },
                    new TblCatalog()
                    {
                        Id = 70,
                        Name = "084",
                        LogoPath = "/Catalog/084.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 87
                    },
                    new TblCatalog()
                    {
                        Id = 71,
                        Name = "085",
                        LogoPath = "/Catalog/085.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 88
                    },
                    new TblCatalog()
                    {
                        Id = 72,
                        Name = "086",
                        LogoPath = "/Catalog/086.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 89
                    },
                    new TblCatalog()
                    {
                        Id = 73,
                        Name = "087",
                        LogoPath = "/Catalog/087.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 90
                    },
                    new TblCatalog()
                    {
                        Id = 74,
                        Name = "088",
                        LogoPath = "/Catalog/088.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 91
                    },
                    new TblCatalog()
                    {
                        Id = 75,
                        Name = "089",
                        LogoPath = "/Catalog/089.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 92
                    },
                    new TblCatalog()
                    {
                        Id = 76,
                        Name = "090",
                        LogoPath = "/Catalog/090.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 93
                    },
                    new TblCatalog()
                    {
                        Id = 77,
                        Name = "H01",
                        LogoPath = "/Catalog/H01.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 100
                    },
                    new TblCatalog()
                    {
                        Id = 78,
                        Name = "H05",
                        LogoPath = "/Catalog/H05.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 101
                    },
                    new TblCatalog()
                    {
                        Id = 79,
                        Name = "H07",
                        LogoPath = "/Catalog/H07.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 102
                    },
                    new TblCatalog()
                    {
                        Id = 80,
                        Name = "H09",
                        LogoPath = "/Catalog/H09.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 103
                    },
                    new TblCatalog()
                    {
                        Id = 81,
                        Name = "H19",
                        LogoPath = "/Catalog/H19.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 104
                    },
                    new TblCatalog()
                    {
                        Id = 82,
                        Name = "H21",
                        LogoPath = "/Catalog/H21.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 105
                    },
                    new TblCatalog()
                    {
                        Id = 83,
                        Name = "H29",
                        LogoPath = "/Catalog/H29.jpg",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 106
                    },

                    new TblCatalog()
                    {
                        Id = 84,
                        Name = "Red A901",
                        LogoPath = "/Catalog/A901.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 21
                    },
                    new TblCatalog()
                    {
                        Id = 85,
                        Name = "Yellow A902",
                        LogoPath = "/Catalog/A902.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 22
                    },
                    new TblCatalog()
                    {
                        Id = 86,
                        Name = "Blue A903",
                        LogoPath = "/Catalog/A903.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 23
                    },
                    new TblCatalog()
                    {
                        Id = 87,
                        Name = "Purple A907",
                        LogoPath = "/Catalog/A907.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 24
                    },
                    new TblCatalog()
                    {
                        Id = 88,
                        Name = "Magenta A913",
                        LogoPath = "/Catalog/A913.png",
                        CatalogGroupId = 1,
                        Disabled = true,
                        OrderNumber = 25
                    },
                    #endregion

                    // start at Id 89-98 orderNumber 26-35
                    #region Glitter 

                    new TblCatalog()
                    {
                        Id = 89,
                        Name = "Glitter Gold",
                        LogoPath = "/Catalog/Glitter-Gold.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 26
                    },
                    new TblCatalog()
                    {
                        Id = 90,
                        Name = "Glitter Green",
                        LogoPath = "/Catalog/Glitter-Green.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 27
                    },
                    new TblCatalog()
                    {
                        Id = 91,
                        Name = "Glitter Silver",
                        LogoPath = "/Catalog/Glitter-Silver.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 28
                    },
                    new TblCatalog()
                    {
                        Id = 92,
                        Name = "Glitter Red",
                        LogoPath = "/Catalog/Glitter-Red.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 29
                    },
                    new TblCatalog()
                    {
                        Id = 93,
                        Name = "Glitter Blue",
                        LogoPath = "/Catalog/Glitter-Blue.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 30
                    },
                    new TblCatalog()
                    {
                        Id = 94,
                        Name = "Glitter Colorful",
                        LogoPath = "/Catalog/Glitter-Colorful.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 31
                    },
                    new TblCatalog()
                    {
                        Id = 95,
                        Name = "Glitter Orange",
                        LogoPath = "/Catalog/Glitter-Orange.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 32
                    },
                    new TblCatalog()
                    {
                        Id = 96,
                        Name = "Glitter Purple",
                        LogoPath = "/Catalog/Glitter-Purple.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 33
                    },
                    new TblCatalog()
                    {
                        Id = 97,
                        Name = "Glitter Pink",
                        LogoPath = "/Catalog/Glitter-Pink.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 34
                    },
                    new TblCatalog()
                    {
                        Id = 98,
                        Name = "Glitter Yellow",
                        LogoPath = "/Catalog/Glitter-Yellow.png",
                        CatalogGroupId = 2,
                        Disabled = true,
                        OrderNumber = 35
                    }
                    #endregion

                    );


                    

            });
            #endregion
        }
    }
}
