using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegaloFeliz.Application.Migrations
{
    /// <inheritdoc />
    public partial class _2023022302 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Sales",
                newName: "SaleDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SaleDate",
                table: "Sales",
                newName: "Date");
        }
    }
}
