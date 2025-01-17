﻿// <auto-generated />
using System;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    [DbContext(typeof(HexaDBContext))]
    [Migration("20210510052229_CreateDatabaseSchema")]
    partial class CreateDatabaseSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblAds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Disabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("TblAds");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CaseName")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<int>("CaseStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CaseTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Disabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Disabled")
                        .HasDefaultValueSql("'0'");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Memo")
                        .HasColumnType("longtext");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<int?>("ReferenceCaseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaseStatusId");

                    b.HasIndex("CaseTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("TblCase");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseAttachedFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("TblCaseAttachedFile");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<int>("MethodId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Section")
                        .HasColumnType("int");

                    b.Property<int?>("TeethNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("MethodId");

                    b.HasIndex("ProductTypeGroupId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("TblCaseProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblCaseStatus");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseSubProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaseProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaseProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("TblCaseSubProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblCaseType");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblFavorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("TblFavorite");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblFavoriteSubProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FavoriteId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteId");

                    b.HasIndex("ProductId");

                    b.ToTable("TblFavoriteSubProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("TblMethod");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<bool>("Read")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Read")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Title")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TblNotification");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<bool>("Disabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Disabled")
                        .HasDefaultValueSql("'0'");

                    b.Property<DateTime?>("EstimatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNumber")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CaseId")
                        .IsUnique();

                    b.HasIndex("OrderStatusId");

                    b.ToTable("TblOrder");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrderHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("TblOrderHistory");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblOrderStatus");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ColorCode")
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("EOrderProductId")
                        .HasColumnType("int");

                    b.Property<string>("LogoPath")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("TblProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblProductCategory");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductGroupItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeGroupId");

                    b.ToTable("TblProductGroupItem");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblProductType");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductTypeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("DisplayAsGroup")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("TblProductTypeGroup");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblSubProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SubProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SubProductId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SubProductId");

                    b.HasIndex("SubProductId1");

                    b.ToTable("TblSubProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TblUnit");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("UserId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("TblUser");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TblUserRole");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCase", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCaseStatus", "CaseStatus")
                        .WithMany("Cases")
                        .HasForeignKey("CaseStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCaseType", "CaseType")
                        .WithMany("Cases")
                        .HasForeignKey("CaseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaseStatus");

                    b.Navigation("CaseType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseAttachedFile", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCase", "Case")
                        .WithMany("CaseAttachedFiles")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseProduct", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCase", "Case")
                        .WithMany("CaseProducts")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblMethod", "Method")
                        .WithMany()
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductTypeGroup", "ProductTypeGroup")
                        .WithMany()
                        .HasForeignKey("ProductTypeGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Method");

                    b.Navigation("ProductType");

                    b.Navigation("ProductTypeGroup");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseSubProduct", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCaseProduct", "CaseProduct")
                        .WithMany("CaseSubProducts")
                        .HasForeignKey("CaseProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaseProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblFavorite", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductType", "ProductType")
                        .WithMany("Favorites")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUser", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblFavoriteSubProduct", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblFavorite", "Favorite")
                        .WithMany("FavoriteProducts")
                        .HasForeignKey("FavoriteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Favorite");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblMethod", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductType", "ProductType")
                        .WithMany("Methods")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblNotification", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrder", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblCase", "Case")
                        .WithOne("OrderData")
                        .HasForeignKey("HexaOnlineOrdering.Repositories.DataModels.TblOrder", "CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblOrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrderHistory", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblOrder", "Order")
                        .WithMany("OrderHistorys")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblOrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProduct", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUnit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductGroupItem", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProduct", "Product")
                        .WithMany("ProductGroupItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductTypeGroup", "ProductTypeGroup")
                        .WithMany("ProductGroupItems")
                        .HasForeignKey("ProductTypeGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductTypeGroup");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductTypeGroup", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductType", "ProductType")
                        .WithMany("ProductTypeGroups")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblSubProduct", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProductType", "ProductType")
                        .WithMany("SubProducts")
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProduct", "Product")
                        .WithMany("SubProducts")
                        .HasForeignKey("SubProductId")
                        .HasConstraintName("fk_tbl_subproduct_tbl_product_creator_subproduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblProduct", "SubProduct")
                        .WithMany()
                        .HasForeignKey("SubProductId1");

                    b.Navigation("Product");

                    b.Navigation("ProductType");

                    b.Navigation("SubProduct");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUser", b =>
                {
                    b.HasOne("HexaOnlineOrdering.Repositories.DataModels.TblUserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCase", b =>
                {
                    b.Navigation("CaseAttachedFiles");

                    b.Navigation("CaseProducts");

                    b.Navigation("OrderData");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseProduct", b =>
                {
                    b.Navigation("CaseSubProducts");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseStatus", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblCaseType", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblFavorite", b =>
                {
                    b.Navigation("FavoriteProducts");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrder", b =>
                {
                    b.Navigation("OrderHistorys");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblOrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProduct", b =>
                {
                    b.Navigation("ProductGroupItems");

                    b.Navigation("SubProducts");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductType", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Methods");

                    b.Navigation("ProductTypeGroups");

                    b.Navigation("SubProducts");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblProductTypeGroup", b =>
                {
                    b.Navigation("ProductGroupItems");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUnit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUser", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("HexaOnlineOrdering.Repositories.DataModels.TblUserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
