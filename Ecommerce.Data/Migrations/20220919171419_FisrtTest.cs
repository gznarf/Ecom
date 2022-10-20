using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    public partial class FisrtTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    ID_BillDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Bill = table.Column<int>(type: "int", nullable: false),
                    ID_Client = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantity = table.Column<string>(type: "varchar(100)", nullable: false),
                    price = table.Column<decimal>(type: "Decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.ID_BillDetail);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID_Client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(20)", nullable: false),
                    phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", nullable: false),
                    City = table.Column<string>(type: "varchar(30)", nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(8)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID_Client);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Product = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: false),
                    Mark = table.Column<string>(type: "varchar(20)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    BillDetailID_BillDetail = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID_Product);
                    table.ForeignKey(
                        name: "FK_Products_BillDetails_BillDetailID_BillDetail",
                        column: x => x.BillDetailID_BillDetail,
                        principalTable: "BillDetails",
                        principalColumn: "ID_BillDetail");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    ID_Bill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_BillDetail = table.Column<int>(type: "int", nullable: false),
                    ID_Client = table.Column<int>(type: "int", nullable: false),
                    BillID_Bill = table.Column<int>(type: "int", nullable: true),
                    ClientID_Client = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.ID_Bill);
                    table.ForeignKey(
                        name: "FK_Bills_Bills_BillID_Bill",
                        column: x => x.BillID_Bill,
                        principalTable: "Bills",
                        principalColumn: "ID_Bill");
                    table.ForeignKey(
                        name: "FK_Bills_Clients_ClientID_Client",
                        column: x => x.ClientID_Client,
                        principalTable: "Clients",
                        principalColumn: "ID_Client");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID_Categorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(60)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    ProductID_Product = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID_Categorie);
                    table.ForeignKey(
                        name: "FK_Categories_Products_ProductID_Product",
                        column: x => x.ProductID_Product,
                        principalTable: "Products",
                        principalColumn: "ID_Product");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillID_Bill",
                table: "Bills",
                column: "BillID_Bill");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ClientID_Client",
                table: "Bills",
                column: "ClientID_Client");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductID_Product",
                table: "Categories",
                column: "ProductID_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BillDetailID_BillDetail",
                table: "Products",
                column: "BillDetailID_BillDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "BillDetails");
        }
    }
}
