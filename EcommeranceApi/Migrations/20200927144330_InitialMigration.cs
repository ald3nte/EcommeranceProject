using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommeranceApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HexCode = table.Column<string>(nullable: true),
                    ImageColorUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDefinition",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Mark = table.Column<string>(nullable: true),
                    Collection = table.Column<string>(nullable: true),
                    IsAvaible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDefinition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    IsAvaible = table.Column<int>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    ColorValue = table.Column<string>(nullable: true),
                    SizeValue = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ProductDefinitionId = table.Column<Guid>(nullable: false),
                    SizeId = table.Column<Guid>(nullable: false),
                    ColorId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductDefinition_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalTable: "ProductDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAvailability",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAvailability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAvailability_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductFoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EditedAt = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductDefinitionId = table.Column<Guid>(nullable: false),
                    FotoUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Index = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFoto_ProductDefinition_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalTable: "ProductDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductFoto_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "EditedAt", "Name", "ParentId" },
                values: new object[] { new Guid("a18fd658-344b-435c-ab09-fe744303f38e"), new DateTime(2020, 9, 27, 14, 43, 29, 926, DateTimeKind.Utc).AddTicks(2164), new DateTime(2020, 9, 27, 14, 43, 29, 926, DateTimeKind.Utc).AddTicks(2171), "Koszulki", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedAt", "Description", "EditedAt", "HexCode", "ImageColorUrl", "Name" },
                values: new object[] { new Guid("e38d0ddc-8c81-451a-8180-5e9d34804ee4"), new DateTime(2020, 9, 27, 14, 43, 29, 925, DateTimeKind.Utc).AddTicks(3583), "jasno żółty", new DateTime(2020, 9, 27, 14, 43, 29, 925, DateTimeKind.Utc).AddTicks(3591), "#2423", "/color.jpg", "Żółty" });

            migrationBuilder.InsertData(
                table: "ProductDefinition",
                columns: new[] { "Id", "Collection", "CreatedAt", "Description", "EditedAt", "IsAvaible", "Mark", "Name" },
                values: new object[] { new Guid("e561c011-79b4-4c97-ae1e-b961de87ad3f"), "2020 summer", new DateTime(2020, 9, 27, 14, 43, 29, 925, DateTimeKind.Utc).AddTicks(9178), "Bawełniana koszulka z nadrukiem", new DateTime(2020, 9, 27, 14, 43, 29, 925, DateTimeKind.Utc).AddTicks(9185), 1, "Stussy", "Koszulka Stussy" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "Description", "Details", "EditedAt", "Name" },
                values: new object[] { new Guid("0641b61a-839a-4061-9152-ae40a3613697"), new DateTime(2020, 9, 27, 14, 43, 29, 924, DateTimeKind.Utc).AddTicks(8656), "rozmiar S", "", new DateTime(2020, 9, 27, 14, 43, 29, 924, DateTimeKind.Utc).AddTicks(8675), "S" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EditedAt", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[] { new Guid("60e67526-1865-466c-85d2-54ac144437c4"), new DateTime(2020, 9, 27, 14, 43, 29, 922, DateTimeKind.Utc).AddTicks(7409), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@wp.pl", "admin", "admin", "t@blet2009", "admin" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "ColorId", "ColorValue", "CreatedAt", "Discount", "EditedAt", "IsAvaible", "Price", "ProductDefinitionId", "SizeId", "SizeValue" },
                values: new object[] { new Guid("33820b19-3c18-4769-b518-4ffaa341af32"), new Guid("a18fd658-344b-435c-ab09-fe744303f38e"), new Guid("e38d0ddc-8c81-451a-8180-5e9d34804ee4"), "żółty", new DateTime(2020, 9, 27, 14, 43, 29, 926, DateTimeKind.Utc).AddTicks(8960), 0.0, new DateTime(2020, 9, 27, 14, 43, 29, 926, DateTimeKind.Utc).AddTicks(8967), 1, 109.0, new Guid("e561c011-79b4-4c97-ae1e-b961de87ad3f"), new Guid("0641b61a-839a-4061-9152-ae40a3613697"), "S" });

            migrationBuilder.InsertData(
                table: "ProductAvailability",
                columns: new[] { "Id", "CreatedAt", "EditedAt", "ProductId", "Quantity" },
                values: new object[] { new Guid("a139ceb8-01ef-44d5-a95c-241ae2eb9875"), new DateTime(2020, 9, 27, 14, 43, 29, 927, DateTimeKind.Utc).AddTicks(3402), new DateTime(2020, 9, 27, 14, 43, 29, 927, DateTimeKind.Utc).AddTicks(3410), new Guid("33820b19-3c18-4769-b518-4ffaa341af32"), 10 });

            migrationBuilder.InsertData(
                table: "ProductFoto",
                columns: new[] { "Id", "CreatedAt", "Description", "EditedAt", "FotoUrl", "Index", "ProductDefinitionId", "ProductId" },
                values: new object[] { new Guid("956c1204-68e6-45b1-b5a7-d38a5bc52ba9"), new DateTime(2020, 9, 27, 14, 43, 29, 927, DateTimeKind.Utc).AddTicks(8328), "Koszulka nike", new DateTime(2020, 9, 27, 14, 43, 29, 927, DateTimeKind.Utc).AddTicks(8335), "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/syjv2pftag56ak1oy7mx/meska-domowa-koszulka-pilkarska-fc-Q8x1XQ.jpg", 1, new Guid("e561c011-79b4-4c97-ae1e-b961de87ad3f"), new Guid("33820b19-3c18-4769-b518-4ffaa341af32") });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorId",
                table: "Product",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductDefinitionId",
                table: "Product",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SizeId",
                table: "Product",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAvailability_ProductId",
                table: "ProductAvailability",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFoto_ProductDefinitionId",
                table: "ProductFoto",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFoto_ProductId",
                table: "ProductFoto",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAvailability");

            migrationBuilder.DropTable(
                name: "ProductFoto");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "ProductDefinition");

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
