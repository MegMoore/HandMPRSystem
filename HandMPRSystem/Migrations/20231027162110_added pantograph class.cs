using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandMPRSystem.Migrations
{
    /// <inheritdoc />
    public partial class addedpantographclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pantographs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    PartNbr = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantographs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pantographs_PartNbr",
                table: "Pantographs",
                column: "PartNbr",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pantographs");
        }
    }
}
