using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class relationorderproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_OrderId",
                table: "User",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Order_OrderId",
                table: "User",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Order_OrderId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_OrderId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "User");
        }
    }
}
