using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10385543_CLDV6211_Part1.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderDetailProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Orders_OrdersId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrdersDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrdersDetail",
                newName: "IX_OrdersDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrdersId",
                table: "OrdersDetail",
                newName: "IX_OrdersDetail_OrdersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersDetail",
                table: "OrdersDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetail_Orders_OrdersId",
                table: "OrdersDetail",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetail_Product_ProductId",
                table: "OrdersDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetail_Orders_OrdersId",
                table: "OrdersDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetail_Product_ProductId",
                table: "OrdersDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersDetail",
                table: "OrdersDetail");

            migrationBuilder.RenameTable(
                name: "OrdersDetail",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetail_ProductId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetail_OrdersId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrdersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Orders_OrdersId",
                table: "OrderDetail",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
