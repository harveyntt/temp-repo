using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FabricShop.Migrations
{
    public partial class modelsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    DeliveryDistance = table.Column<int>(nullable: false),
                    DeliveryTime = table.Column<int>(nullable: false),
                    OrderType = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    Cate1 = table.Column<string>(nullable: true),
                    Cate2 = table.Column<string>(nullable: true),
                    Cate3 = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Composition = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    Weave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
