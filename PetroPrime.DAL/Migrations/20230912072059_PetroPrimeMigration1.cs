using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetroPrime.DAL.Migrations
{
    public partial class PetroPrimeMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_product_ProductId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_product_supplier_SupplierId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_carts_ProductId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "product",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_product_SupplierId",
                table: "product",
                newName: "IX_product_CartId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "supplier",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_supplier_ProductId",
                table: "supplier",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_carts_CartId",
                table: "product",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_supplier_product_ProductId",
                table: "supplier",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_carts_CartId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_supplier_product_ProductId",
                table: "supplier");

            migrationBuilder.DropIndex(
                name: "IX_supplier_ProductId",
                table: "supplier");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "supplier");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "product",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_product_CartId",
                table: "product",
                newName: "IX_product_SupplierId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_carts_ProductId",
                table: "carts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_product_ProductId",
                table: "carts",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_supplier_SupplierId",
                table: "product",
                column: "SupplierId",
                principalTable: "supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
