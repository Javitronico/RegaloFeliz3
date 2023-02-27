using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegaloFeliz.Application.Migrations
{
    /// <inheritdoc />
    public partial class _2023022601 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ProductSales",
                columns: new[] { "Id", "Price", "ProductId", "SaleId" },
                values: new object[,]
                {
                    { new Guid("e2d7c24a-73ca-4957-b4f9-345f635b03d3"), 100f, new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), new Guid("98474b8e-d713-401e-8aee-acb7353f97bb") },
                    { new Guid("f01ed6d5-bba7-44f7-b28f-594aaf56b869"), 100f, new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), new Guid("98474b8e-d713-401e-8aee-acb7353f97bb") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), "FIFA 2023" },
                    { new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), "God Of War" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "ProductId", "SaleDate", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("150c81c6-2458-466e-907a-2df11325e2b8"), new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), new DateTime(2023, 1, 27, 21, 50, 28, 841, DateTimeKind.Local).AddTicks(4466), 300f },
                    { new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"), new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), new DateTime(2023, 2, 16, 21, 50, 28, 841, DateTimeKind.Local).AddTicks(4346), 100f },
                    { new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"), new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), new DateTime(2023, 2, 6, 21, 50, 28, 841, DateTimeKind.Local).AddTicks(4403), 200f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSales");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
