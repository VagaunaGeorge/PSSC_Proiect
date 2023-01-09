using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderHeaderDboOrderId",
                table: "OrderLine",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDboProductId",
                table: "OrderLine",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderLine_OrderHeaderDboOrderId",
                table: "OrderLine",
                column: "OrderHeaderDboOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLine_ProductDboProductId",
                table: "OrderLine",
                column: "ProductDboProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_OrderHeader_OrderHeaderDboOrderId",
                table: "OrderLine",
                column: "OrderHeaderDboOrderId",
                principalTable: "OrderHeader",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Product_ProductDboProductId",
                table: "OrderLine",
                column: "ProductDboProductId",
                principalTable: "Product",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_OrderHeader_OrderHeaderDboOrderId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Product_ProductDboProductId",
                table: "OrderLine");

            migrationBuilder.DropIndex(
                name: "IX_OrderLine_OrderHeaderDboOrderId",
                table: "OrderLine");

            migrationBuilder.DropIndex(
                name: "IX_OrderLine_ProductDboProductId",
                table: "OrderLine");

            migrationBuilder.DropColumn(
                name: "OrderHeaderDboOrderId",
                table: "OrderLine");

            migrationBuilder.DropColumn(
                name: "ProductDboProductId",
                table: "OrderLine");
        }
    }
}
