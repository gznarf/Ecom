using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    public partial class ChangePpriceDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "BillDetails",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "BillDetails",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");
        }
    }
}
