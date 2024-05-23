using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;


namespace HexaOnlineOrdering.Repositories.Extensions
{
    public static class ModelICHARMMasterExtensions
    {
        public static void SeedDataICHARM(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblProductType>(entity => 
            {
                entity.HasData(
                    new TblProductType()
                    {
                        Id = 5,
                        Name = "ICHARM"
                    }
                    );          
            });

            modelBuilder.Entity<TblMethod>(entity =>
            {
                entity.HasData(
                    new TblMethod()
                    {
                        Id = 15,
                        Name = "Finish",
                        ProductTypeId = 5
                    },
                    new TblMethod()
                    {
                        Id = 16,
                        Name = "Refinement",
                        ProductTypeId = 5
                    }
                    );
            });

            modelBuilder.Entity<TblMasterProduct>(entity =>
            {
                entity.HasData(
                    new TblMasterProduct()
                    {
                        Id = 144,
                        Name = "Canine to Canine",
                        ExpectedProductDay = 3,
                        ProductTypeId = 5
                    },
                    new TblMasterProduct()
                    {
                        Id = 145,
                        Name = "Premolar to Premolar",
                        ExpectedProductDay = 3,
                        ProductTypeId = 5
                    });
            });

            modelBuilder.Entity<TblCaseAttachedFileType>(entity =>
            {
                entity.HasData(
                    new TblCaseAttachedFileType()
                    {
                        Id = 1,
                        Name = "normal"
                    },
                    new TblCaseAttachedFileType()
                    {
                        Id = 2,
                        Name = "ICHARM patient image"
                    }, 
                    new TblCaseAttachedFileType()
                    {
                        Id = 3,
                        Name = "ICHARM x-ray"
                    },
                    new TblCaseAttachedFileType()
                    {
                        Id = 4,
                        Name = "ICHARM case presentation"
                    });
            });

            modelBuilder.Entity<TblOrderStatus>(entity => 
            {
                entity.HasData(
                    new TblOrderStatus() 
                    {
                        Id = 8,
                        Name = "Step1"
                    },
                    new TblOrderStatus()
                    {
                        Id = 9,
                        Name = "Step2"
                    },
                    new TblOrderStatus()
                    {
                        Id = 10,
                        Name = "Step1-delivery"
                    },
                    new TblOrderStatus()
                    {
                        Id = 11,
                        Name = "Step2-delivery"
                    }
                    );
            });

            modelBuilder.Entity<TblProductTypeGroup>(entity =>
            {
                entity.HasData(
                    new TblProductTypeGroup()
                    {
                        Id = 16,
                        Name = "ICHARM",
                        DisplayAsGroup = false,
                        ProductTypeId = 5,
                        OrderNumber = 0
                    });
            });

            modelBuilder.Entity<TblProductGroupItem>(entity =>
            {
                entity.HasData(
                    new TblProductGroupItem()
                    {
                        Id = 144,
                        ProductTypeGroupId = 16,
                        ProductId = 144
                    },
                    new TblProductGroupItem()
                    {
                        Id = 145,
                        ProductTypeGroupId = 16,
                        ProductId = 145
                    });
            });
        }
    }
}
