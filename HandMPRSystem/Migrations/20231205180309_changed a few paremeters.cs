using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandMPRSystem.Migrations
{
    /// <inheritdoc />
    public partial class changedafewparemeters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quilt",
                table: "Quilt");

            migrationBuilder.RenameTable(
                name: "Quilt",
                newName: "Quilts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quilts",
                table: "Quilts",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quilts",
                table: "Quilts");

            migrationBuilder.RenameTable(
                name: "Quilts",
                newName: "Quilt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quilt",
                table: "Quilt",
                column: "Id");
        }
    }
}
