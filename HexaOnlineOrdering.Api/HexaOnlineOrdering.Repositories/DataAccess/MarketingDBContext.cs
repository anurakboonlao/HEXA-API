using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HexaOnlineOrdering.Repositories.MarketingDataModels;

#nullable disable

namespace HexaOnlineOrdering.Repositories.DataAccess
{
    public partial class MarketingDBContext : DbContext
    {
        public MarketingDBContext()
        {
        }

        public MarketingDBContext(DbContextOptions<MarketingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<ZoneMember> ZoneMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=hexaceram.com;port=3306;database=admin_hexa2;uid=apollo;password=#Hexaapollo2021", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.11-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("members");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(191)
                    .HasColumnName("address");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(191)
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerVerifyKey)
                    .HasMaxLength(191)
                    .HasColumnName("customer_verify_key");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EoCusId)
                    .HasMaxLength(191)
                    .HasColumnName("eo_cus_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(191)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasColumnName("notification")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(191)
                    .HasColumnName("phone");

                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");

                entity.Property(e => e.PointExpire)
                    .HasColumnType("date")
                    .HasColumnName("point_expire");

                entity.Property(e => e.Province)
                    .HasMaxLength(191)
                    .HasColumnName("province");

                entity.Property(e => e.ProvinceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("province_id");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("role");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .HasMaxLength(191)
                    .HasColumnName("username");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("zone_id");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("zone_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(45)
                    .HasColumnName("line_id");

                entity.Property(e => e.LineUserId)
                    .HasMaxLength(45)
                    .HasColumnName("line_user_id");

                entity.Property(e => e.LineSecretCode)
                    .HasMaxLength(45)
                    .HasColumnName("line_secret_code");
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("zones");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

            });

            modelBuilder.Entity<ZoneMember>(entity =>
            {
                entity.ToTable("zone_members");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("int(11)")
                    .HasColumnName("zone_id");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
