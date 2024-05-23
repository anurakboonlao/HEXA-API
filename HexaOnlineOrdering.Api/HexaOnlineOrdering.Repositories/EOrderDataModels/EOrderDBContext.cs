using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class EOrderDBContext : DbContext
    {
        public EOrderDBContext()
        {
        }

        public EOrderDBContext(DbContextOptions<EOrderDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Logbook> Logbooks { get; set; }
        public virtual DbSet<PerformanceNf> PerformanceNfs { get; set; }
        public virtual DbSet<PerformanceProduct> PerformanceProducts { get; set; }
        public virtual DbSet<Section> Sections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=e-order.netforce.co.th;port=3306;database=dental;uid=api_order;password=hexaapiorder123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.5.58-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.ToTable("clinic");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ClinicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("clinicId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.ClinicCusId)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("clinic_cus_id");

                entity.Property(e => e.ClinicGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("clinicGroupId");

                entity.Property(e => e.ClinicName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("clinicName")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ClnActive)
                    .HasColumnName("cln_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("code")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("'2016-07-26 13:00:00'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctor");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DocCusId, "doc_cus_id");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("doctorId");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ClinicCode)
                    .HasMaxLength(8)
                    .HasColumnName("clinicCode")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.DocActive)
                    .HasColumnName("doc_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DocCusId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("doc_cus_id");

                entity.Property(e => e.DocLastupdate).HasColumnName("doc_lastupdate");

                entity.Property(e => e.DocName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("doc_name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Logbook>(entity =>
            {
                entity.ToTable("logbook");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.LogDate, "log_date");

                entity.HasIndex(e => e.LogOrdId, "log_ord_id");

                entity.HasIndex(e => e.LogStfId, "log_stf_id");

                entity.Property(e => e.Logbookid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("logbookid");

                entity.Property(e => e.LogDate)
                    .HasColumnName("log_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LogOrdId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("log_ord_id");

                entity.Property(e => e.LogSecId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("log_sec_id");

                entity.Property(e => e.LogStatus)
                    .HasColumnType("int(2)")
                    .HasColumnName("log_status");

                entity.Property(e => e.LogStfId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("log_stf_id");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnType("enum('KN','IN','OUT')")
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'KN'")
                    .UseCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<PerformanceNf>(entity =>
            {
                entity.HasKey(e => e.PdId)
                    .HasName("PRIMARY");

                entity.ToTable("performance_nf");

                entity.Property(e => e.PdId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pd_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CategId)
                    .HasColumnType("int(11)")
                    .HasColumnName("categ_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .HasColumnName("code")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.LastUpdate).HasColumnName("last_update");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PerStatus)
                    .HasColumnType("int(1)")
                    .HasColumnName("per_status");

                entity.Property(e => e.UomId)
                    .HasColumnType("int(11)")
                    .HasColumnName("uom_id");
            });

            modelBuilder.Entity<PerformanceProduct>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PRIMARY");

                entity.ToTable("performance_product");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ProId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pro_id");

                entity.Property(e => e.ProCatalog)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("pro_catalog");

                entity.Property(e => e.ProCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pro_code");

                entity.Property(e => e.ProDepart)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("pro_depart");

                entity.Property(e => e.ProIdOld)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("pro_id_old");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("pro_name");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.SectionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sectionID");

                entity.Property(e => e.ApiStat)
                    .HasColumnName("api_stat")
                    .HasComment("Use display section in API");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .HasColumnName("department")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Process)
                    .HasColumnType("int(11)")
                    .HasColumnName("process");

                entity.Property(e => e.Room)
                    .HasMaxLength(50)
                    .HasColumnName("room")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.SecActive).HasColumnName("sec_active");

                entity.Property(e => e.SecLastUpdate).HasColumnName("sec_last_update");

                entity.Property(e => e.SecProcess)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sec_process");

                entity.Property(e => e.SecRoom)
                    .HasMaxLength(50)
                    .HasColumnName("sec_room");

                entity.Property(e => e.SecType)
                    .HasColumnType("enum('F','R','O','M')")
                    .HasColumnName("sec_type");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true)
                    .UseCollation("utf8_unicode_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
