using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.Eshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mysql_101_productInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageSource", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "/img/produkty-02.jpg", "Chleba", 20.0 },
                    { 2, "", "/img/produkty-01.jpg", "Rohlík", 5.0 },
                    { 3, "", "/img/produkty-08.jpg", "Věneček", 40.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
