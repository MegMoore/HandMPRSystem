using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandMPRSystem.Migrations
{
    /// <inheritdoc />
    public partial class orderlines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Pantographs_PantographId",
                table: "Orderlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Products_ProductId",
                table: "Orderlines");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Orderlines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PantographId",
                table: "Orderlines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Pantographs_PantographId",
                table: "Orderlines",
                column: "PantographId",
                principalTable: "Pantographs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Products_ProductId",
                table: "Orderlines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Pantographs_PantographId",
                table: "Orderlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Products_ProductId",
                table: "Orderlines");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Orderlines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PantographId",
                table: "Orderlines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Pantographs_PantographId",
                table: "Orderlines",
                column: "PantographId",
                principalTable: "Pantographs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Products_ProductId",
                table: "Orderlines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
