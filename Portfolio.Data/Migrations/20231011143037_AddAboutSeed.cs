using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAboutSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Age", "Birthday", "City", "Degree", "Description", "Email", "ImageUrl", "Phone", "Title" },
                values: new object[] { 1, 29, new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Area", "Degree Area", "Description area", "Email Area", "", "Phone Number", "Title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
