using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetroPrime.DAL.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_customer_CustomerId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_courrier_order_OrdersOrderId",
                table: "courrier");

            migrationBuilder.DropForeignKey(
                name: "FK_order_payment_PaymentId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_product_carts_CartId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_supplier_product_ProductId",
                table: "supplier");

            migrationBuilder.DropIndex(
                name: "IX_supplier_ProductId",
                table: "supplier");

            migrationBuilder.DropIndex(
                name: "IX_product_CartId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_CategoryId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_payment_CartId",
                table: "payment");

            migrationBuilder.DropIndex(
                name: "IX_order_PaymentId",
                table: "order");

            migrationBuilder.DropIndex(
                name: "IX_courrier_OrdersOrderId",
                table: "courrier");

            migrationBuilder.DropIndex(
                name: "IX_carts_CustomerId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "supplier");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "payment");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "order");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "courrier");

            migrationBuilder.DropColumn(
                name: "OrdersOrderId",
                table: "courrier");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "carts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "supplier",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "payment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "courrier",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderId",
                table: "courrier",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "carts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_supplier_ProductId",
                table: "supplier",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CartId",
                table: "product",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_CartId",
                table: "payment",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_order_PaymentId",
                table: "order",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_courrier_OrdersOrderId",
                table: "courrier",
                column: "OrdersOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_CustomerId",
                table: "carts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_customer_CustomerId",
                table: "carts",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courrier_order_OrdersOrderId",
                table: "courrier",
                column: "OrdersOrderId",
                principalTable: "order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_payment_PaymentId",
                table: "order",
                column: "PaymentId",
                principalTable: "payment",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_carts_CartId",
                table: "product",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_supplier_product_ProductId",
                table: "supplier",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
