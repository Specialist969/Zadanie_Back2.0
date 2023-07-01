using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zadanie_back.Migrations
{
    /// <inheritdoc />
    public partial class Product_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "Product_name");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movie",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "Product_department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_name",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Product_department",
                table: "Movie",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Movie",
                newName: "Rating");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
