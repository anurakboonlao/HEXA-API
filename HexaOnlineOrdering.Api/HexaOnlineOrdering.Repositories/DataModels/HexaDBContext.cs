using System;
using HexaOnlineOrdering.Repositories.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace HexaOnlineOrdering.Repositories.DataModels
{
    public partial class HexaDBContext : DbContext
    {
        public HexaDBContext()
        {
        }

        public HexaDBContext(DbContextOptions<HexaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblUser> Users { get; set; }
        public virtual DbSet<TblAds> Ads { get; set; }
        public virtual DbSet<TblCase> Cases { get; set; }
        public virtual DbSet<TblCaseAttachedFile> CaseAttachedFiles { get; set; }
        public virtual DbSet<TblCaseProduct> CaseProducts { get; set; }
        public virtual DbSet<TblCaseStatus> CaseStatus { get; set; }
        public virtual DbSet<TblCaseType> CaseTypes { get; set; }
        public virtual DbSet<TblFavorite> Favorites { get; set; }
        public virtual DbSet<TblMethod> Methods { get; set; }
        public virtual DbSet<TblNotification> Notifications { get; set; }
        public virtual DbSet<TblOrder> Orders { get; set; }
        public virtual DbSet<TblOrderHistory> OrderHistorys { get; set; }
        public virtual DbSet<TblOrderStatus> OrderStatus { get; set; }
        public virtual DbSet<TblProduct> Products { get; set; }
        public virtual DbSet<TblProductCategory> ProductCategorys { get; set; }
        public virtual DbSet<TblProductGroupItem> ProductGroupItems { get; set; }
        public virtual DbSet<TblProductType> ProductTypes { get; set; }
        public virtual DbSet<TblProductTypeGroup> ProductTypeGroups { get; set; }
        public virtual DbSet<TblUnit> Uints { get; set; }
        public virtual DbSet<TblUserRole> UserRoles { get; set; }
        public virtual DbSet<TblFavoriteMaterial> FavoriteMaterials { get; set; }
        public virtual DbSet<TblFavoriteDesign> FavoriteDesigns { get; set; }
        public virtual DbSet<TblFavoriteAddOn> FavoriteAddOns { get; set; }
        public virtual DbSet<TblCatalog> Catalogs { get; set; }
        public virtual DbSet<TblCatalogGroup> CatalogGroup { get; set; }
        public virtual DbSet<TblCaseAttachedFileType> CaseAttachedFileTypes { get; set; }
        public virtual DbSet<TblRejectNote> RejectNote { get; set; }
        public virtual DbSet<TblCasePresentationHistory> CasePresentationHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3310;database=hexa_online_dev;uid=root;password=root"
                     , ServerVersion.AutoDetect("server=localhost;port=3310;database=hexa_online_dev;uid=root;password=root")); ;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<TblNotification>(entity =>
            {
                entity.ToTable("TblNotification");
                entity.Property(e => e.Read)
                    .HasColumnName("Read")
                    .HasDefaultValueSql("'0'");
            });

            //modelBuilder.Entity<TblUser>().ToTable("TblUser");         
            modelBuilder.Entity<TblCase>(entity =>
            {
                entity.ToTable("TblCase");
                entity.Property(e => e.Disabled)
                    .HasColumnName("Disabled")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("TblOrder");
                entity.Property(e => e.Disabled)
                    .HasColumnName("Disabled")
                    .HasDefaultValueSql("'0'");
                entity.Property(e => e.IsNotification)
                    .HasColumnName("IsNotification")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TblCaseAttachedFile>(entity =>
            {
                entity.ToTable("TblCaseAttachedFile");
                entity.Property(e => e.UploadedDate).HasColumnName("UploadedDate").HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<TblCatalog>(entity =>
            {
                entity.ToTable("TblCatalog");
                entity.Property(e => e.Disabled)
                    .HasColumnName("Disabled")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TblCaseAttachedFile>(entity =>
            {
                entity.ToTable("TblCaseAttachedFile");
                entity.Property(e => e.FileTypeId)
                    .HasColumnName("FileTypeId")
                    .HasDefaultValueSql("'1'");
            });



            // Seed data.
            modelBuilder.SeedData();
            modelBuilder.SeedDataCrownAndBridge();
            modelBuilder.SeedDataOrthopedic();
            modelBuilder.SeedDataOrthodontic();
            modelBuilder.SeedStatusAndUserContact();
            modelBuilder.SeedDataCatalog();
            modelBuilder.SeedShadeSystemData();
            modelBuilder.SeedShadeData();
            modelBuilder.SeedDataICHARM();
            modelBuilder.SeedDataCatalog2022();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
