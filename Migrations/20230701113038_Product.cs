using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zadanie_back.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Movie",
                newName: "Shop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Shop",
                table: "Movie",
                newName: "Comment");
        }
    }
}
