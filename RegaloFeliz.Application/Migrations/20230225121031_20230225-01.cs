using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegaloFeliz.Application.Migrations
{
    /// <inheritdoc />
    public partial class _2023022501 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSales_Products_ProductId",
                table: "ProductSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSales_Sales_SaleId",
                table: "ProductSales");

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "ProductSales",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductSales",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSales_Products_ProductId",
                table: "ProductSales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSales_Sales_SaleId",
                table: "ProductSales",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSales_Products_ProductId",
                table: "ProductSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSales_Sales_SaleId",
                table: "ProductSales");

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "ProductSales",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductSales",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSales_Products_ProductId",
                table: "ProductSales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSales_Sales_SaleId",
                table: "ProductSales",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }
    }
}
