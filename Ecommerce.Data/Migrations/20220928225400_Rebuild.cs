using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    public partial class Rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stock",
                table: "Products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");
        }
    }
}
