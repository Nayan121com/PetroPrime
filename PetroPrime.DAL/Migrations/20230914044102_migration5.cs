using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetroPrime.DAL.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartItem_carts_CartId",
                table: "cartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_cartItem_product_ProductId",
                table: "cartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_customer_CustomerId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_productSupplier_product_ProductId",
                table: "productSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_productSupplier_supplier_SupplierId",
                table: "productSupplier");

            migrationBuilder.DropIndex(
                name: "IX_productSupplier_ProductId",
                table: "productSupplier");

            migrationBuilder.DropIndex(
                name: "IX_productSupplier_SupplierId",
                table: "productSupplier");

            migrationBuilder.DropIndex(
                name: "IX_payment_CartId",
                table: "payment");

            migrationBuilder.DropIndex(
                name: "IX_carts_CustomerId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_cartItem_CartId",
                table: "cartItem");

            migrationBuilder.DropIndex(
                name: "IX_cartItem_ProductId",
                table: "cartItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_productSupplier_ProductId",
                table: "productSupplier",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productSupplier_SupplierId",
                table: "productSupplier",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_CartId",
                table: "payment",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_CustomerId",
                table: "carts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItem_CartId",
                table: "cartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItem_ProductId",
                table: "cartItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_cartItem_carts_CartId",
                table: "cartItem",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cartItem_product_ProductId",
                table: "cartItem",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_customer_CustomerId",
                table: "carts",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSupplier_product_ProductId",
                table: "productSupplier",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSupplier_supplier_SupplierId",
                table: "productSupplier",
                column: "SupplierId",
                principalTable: "supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
