using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "Bronze");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "Name",
                value: "Silver");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "Name",
                value: "Gold");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Star", "STAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dd2044e-1469-445a-a9dd-5e5af0a64c34", "AQAAAAIAAYagAAAAELLi0JNgvEmz8PEZzISm4rMQJsElL7/tqcnB4j1PYr6R5f5ETog5tDGpcwdxUky65Q==", "7954267e-fe55-440b-8de3-2cb211cb72a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "044de10b-dcc8-4e34-ace9-0091e28582b1", "AQAAAAIAAYagAAAAEPyRl9f6g+Uwn3BydZfrwmb7zyhclzMrPCnZbdoZtyMGoeSKI03gX38kGak4Du2ppg==", "9bc143d3-b9fb-4444-9ace-3d5834339227" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "Bronze Üye");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "Name",
                value: "Silver Üye");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "Name",
                value: "Gold Üye");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Platin Üye", "PLATIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6", null, "Yıldız Üye", "STAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6426989a-9b56-42e5-923c-f63de3af192b", "AQAAAAIAAYagAAAAEKudUJSj1xoxMX/3/M0nhjkzRxkbvgrBh4nyw7B4CNJW2b/ZTkVGbv6Vz+dIWNZeHw==", "41184a5c-113a-45c5-9785-e3c7a9ead59c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a91673-d3c6-4550-8512-5a179c965e0e", "AQAAAAIAAYagAAAAEAWcOeAIcKfMIdeCKGBXlYOv/0FdM25TUbB1N1VlfQAAyL2FAMSP/yOn0cuR+xwGDA==", "8b9b0521-b8ec-4ee1-b0b8-d26a946299e9" });
        }
    }
}
