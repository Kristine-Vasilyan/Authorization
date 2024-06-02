using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authorization.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "177b74c6-4f44-4c4b-84c8-66ec56544880", null, "seller", "seller" },
                    { "c64c0340-db1c-46fa-8de5-75ab16228cba", null, "admin", "admin" },
                    { "defa3b98-3008-4d96-986e-ab1a8086e596", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "177b74c6-4f44-4c4b-84c8-66ec56544880");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c64c0340-db1c-46fa-8de5-75ab16228cba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "defa3b98-3008-4d96-986e-ab1a8086e596");
        }
    }
}
