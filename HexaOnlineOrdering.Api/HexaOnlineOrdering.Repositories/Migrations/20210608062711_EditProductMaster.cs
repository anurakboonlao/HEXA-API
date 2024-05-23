using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class EditProductMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblMethod_MethodId",
                table: "TblCaseProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblProductTypeGroup_ProductTypeGroupId",
                table: "TblCaseProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProductGroupItem_TblProduct_ProductId",
                table: "TblProductGroupItem");

            migrationBuilder.DropTable(
                name: "TblCaseSubProduct");

            migrationBuilder.DropTable(
                name: "TblFavoriteSubProduct");

            migrationBuilder.DropTable(
                name: "TblSubProduct");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseProduct_MethodId",
                table: "TblCaseProduct");

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "MethodId",
                table: "TblCaseProduct");

            migrationBuilder.RenameColumn(
                name: "ProductTypeGroupId",
                table: "TblCaseProduct",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TblCaseProduct_ProductTypeGroupId",
                table: "TblCaseProduct",
                newName: "IX_TblCaseProduct_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "TblFavorite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MethodId",
                table: "TblCase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "TblCase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TblAddOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorCode = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoPath = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RequiredInput = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InputType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAddOn", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesign", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblMasterProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorCode = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoPath = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExpectedProductDay = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMasterProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMasterProduct_TblProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "TblProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMaterial", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblCaseProductAddOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddOnId = table.Column<int>(type: "int", nullable: false),
                    CaseProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCaseProductAddOn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCaseProductAddOn_TblAddOn_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "TblAddOn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCaseProductAddOn_TblCaseProduct_CaseProductId",
                        column: x => x.CaseProductId,
                        principalTable: "TblCaseProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblFavoriteAddOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddOnId = table.Column<int>(type: "int", nullable: false),
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavoriteAddOn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavoriteAddOn_TblAddOn_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "TblAddOn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavoriteAddOn_TblFavorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "TblFavorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblCaseProductDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    CaseProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCaseProductDesign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCaseProductDesign_TblCaseProduct_CaseProductId",
                        column: x => x.CaseProductId,
                        principalTable: "TblCaseProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCaseProductDesign_TblDesign_DesignId",
                        column: x => x.DesignId,
                        principalTable: "TblDesign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblFavoriteDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavoriteDesign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavoriteDesign_TblDesign_DesignId",
                        column: x => x.DesignId,
                        principalTable: "TblDesign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavoriteDesign_TblFavorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "TblFavorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblProductAddOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddOnId = table.Column<int>(type: "int", nullable: false),
                    MasterProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProductAddOn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblProductAddOn_TblAddOn_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "TblAddOn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblProductAddOn_TblMasterProduct_MasterProductId",
                        column: x => x.MasterProductId,
                        principalTable: "TblMasterProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblProductDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    MasterProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProductDesign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblProductDesign_TblDesign_DesignId",
                        column: x => x.DesignId,
                        principalTable: "TblDesign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblProductDesign_TblMasterProduct_MasterProductId",
                        column: x => x.MasterProductId,
                        principalTable: "TblMasterProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblCaseProductMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    CaseProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCaseProductMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCaseProductMaterial_TblCaseProduct_CaseProductId",
                        column: x => x.CaseProductId,
                        principalTable: "TblCaseProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCaseProductMaterial_TblMaterial_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "TblMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblFavoriteMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavoriteMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavoriteMaterial_TblFavorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "TblFavorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavoriteMaterial_TblMaterial_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "TblMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblProductMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    MasterProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProductMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblProductMaterial_TblMasterProduct_MasterProductId",
                        column: x => x.MasterProductId,
                        principalTable: "TblMasterProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblProductMaterial_TblMaterial_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "TblMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_ProductId",
                table: "TblFavorite",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCase_MethodId",
                table: "TblCase",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCase_ProductTypeId",
                table: "TblCase",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductAddOn_AddOnId",
                table: "TblCaseProductAddOn",
                column: "AddOnId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductAddOn_CaseProductId",
                table: "TblCaseProductAddOn",
                column: "CaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductDesign_CaseProductId",
                table: "TblCaseProductDesign",
                column: "CaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductDesign_DesignId",
                table: "TblCaseProductDesign",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductMaterial_CaseProductId",
                table: "TblCaseProductMaterial",
                column: "CaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProductMaterial_MaterialId",
                table: "TblCaseProductMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteAddOn_AddOnId",
                table: "TblFavoriteAddOn",
                column: "AddOnId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteAddOn_FavoriteId",
                table: "TblFavoriteAddOn",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteDesign_DesignId",
                table: "TblFavoriteDesign",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteDesign_FavoriteId",
                table: "TblFavoriteDesign",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteMaterial_FavoriteId",
                table: "TblFavoriteMaterial",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteMaterial_MaterialId",
                table: "TblFavoriteMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMasterProduct_ProductTypeId",
                table: "TblMasterProduct",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductAddOn_AddOnId",
                table: "TblProductAddOn",
                column: "AddOnId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductAddOn_MasterProductId",
                table: "TblProductAddOn",
                column: "MasterProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductDesign_DesignId",
                table: "TblProductDesign",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductDesign_MasterProductId",
                table: "TblProductDesign",
                column: "MasterProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductMaterial_MasterProductId",
                table: "TblProductMaterial",
                column: "MasterProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductMaterial_MaterialId",
                table: "TblProductMaterial",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCase_TblMethod_MethodId",
                table: "TblCase",
                column: "MethodId",
                principalTable: "TblMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCase_TblProductType_ProductTypeId",
                table: "TblCase",
                column: "ProductTypeId",
                principalTable: "TblProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblMasterProduct_ProductId",
                table: "TblCaseProduct",
                column: "ProductId",
                principalTable: "TblMasterProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFavorite_TblMasterProduct_ProductId",
                table: "TblFavorite",
                column: "ProductId",
                principalTable: "TblMasterProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductGroupItem_TblMasterProduct_ProductId",
                table: "TblProductGroupItem",
                column: "ProductId",
                principalTable: "TblMasterProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCase_TblMethod_MethodId",
                table: "TblCase");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCase_TblProductType_ProductTypeId",
                table: "TblCase");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblMasterProduct_ProductId",
                table: "TblCaseProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFavorite_TblMasterProduct_ProductId",
                table: "TblFavorite");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProductGroupItem_TblMasterProduct_ProductId",
                table: "TblProductGroupItem");

            migrationBuilder.DropTable(
                name: "TblCaseProductAddOn");

            migrationBuilder.DropTable(
                name: "TblCaseProductDesign");

            migrationBuilder.DropTable(
                name: "TblCaseProductMaterial");

            migrationBuilder.DropTable(
                name: "TblFavoriteAddOn");

            migrationBuilder.DropTable(
                name: "TblFavoriteDesign");

            migrationBuilder.DropTable(
                name: "TblFavoriteMaterial");

            migrationBuilder.DropTable(
                name: "TblProductAddOn");

            migrationBuilder.DropTable(
                name: "TblProductDesign");

            migrationBuilder.DropTable(
                name: "TblProductMaterial");

            migrationBuilder.DropTable(
                name: "TblAddOn");

            migrationBuilder.DropTable(
                name: "TblDesign");

            migrationBuilder.DropTable(
                name: "TblMasterProduct");

            migrationBuilder.DropTable(
                name: "TblMaterial");

            migrationBuilder.DropIndex(
                name: "IX_TblFavorite_ProductId",
                table: "TblFavorite");

            migrationBuilder.DropIndex(
                name: "IX_TblCase_MethodId",
                table: "TblCase");

            migrationBuilder.DropIndex(
                name: "IX_TblCase_ProductTypeId",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "TblFavorite");

            migrationBuilder.DropColumn(
                name: "MethodId",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "TblCase");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "TblCaseProduct",
                newName: "ProductTypeGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_TblCaseProduct_ProductId",
                table: "TblCaseProduct",
                newName: "IX_TblCaseProduct_ProductTypeGroupId");

            migrationBuilder.AddColumn<int>(
                name: "MethodId",
                table: "TblCaseProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TblCaseSubProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CaseProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCaseSubProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCaseSubProduct_TblCaseProduct_CaseProductId",
                        column: x => x.CaseProductId,
                        principalTable: "TblCaseProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCaseSubProduct_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblFavoriteSubProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FavoriteId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavoriteSubProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavoriteSubProduct_TblFavorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "TblFavorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavoriteSubProduct_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblSubProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
                    SubProductId = table.Column<int>(type: "int", nullable: false),
                    SubProductId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSubProduct", x => x.Id);
                    table.ForeignKey(
                        name: "fk_tbl_subproduct_tbl_product_creator_subproduct",
                        column: x => x.SubProductId,
                        principalTable: "TblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblSubProduct_TblProduct_SubProductId1",
                        column: x => x.SubProductId1,
                        principalTable: "TblProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSubProduct_TblProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "TblProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, true, "Crown & Bridge 1", 1 },
                    { 2, true, "Crown & Bridge 2", 1 },
                    { 3, true, "Removable 1", 2 },
                    { 4, true, "Removable 2", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProduct_MethodId",
                table: "TblCaseProduct",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseSubProduct_CaseProductId",
                table: "TblCaseSubProduct",
                column: "CaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseSubProduct_ProductId",
                table: "TblCaseSubProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteSubProduct_FavoriteId",
                table: "TblFavoriteSubProduct",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavoriteSubProduct_ProductId",
                table: "TblFavoriteSubProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubProduct_ProductTypeId",
                table: "TblSubProduct",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubProduct_SubProductId",
                table: "TblSubProduct",
                column: "SubProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubProduct_SubProductId1",
                table: "TblSubProduct",
                column: "SubProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblMethod_MethodId",
                table: "TblCaseProduct",
                column: "MethodId",
                principalTable: "TblMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblProductTypeGroup_ProductTypeGroupId",
                table: "TblCaseProduct",
                column: "ProductTypeGroupId",
                principalTable: "TblProductTypeGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductGroupItem_TblProduct_ProductId",
                table: "TblProductGroupItem",
                column: "ProductId",
                principalTable: "TblProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
