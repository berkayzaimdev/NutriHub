using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatepointscol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a0dcda4-17bf-4a34-853f-08f9bf34ea3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b2a761-0934-4782-9486-bbff6fe94d4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5582d20a-2c69-4292-a234-869db6cd7f65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a0763aa-24ae-412b-867a-c2988bd82d8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b49b152-bc43-466b-a3b2-d94b4d7e7fd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c356b0-e99d-4cbc-93fd-df35205be331");

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "Point",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13e2a137-104b-413d-ae69-9172615a9be2", null, "Silver Üye", "SILVER" },
                    { "32309305-d24c-4650-b146-3d6c5a5e01cc", null, "Gold Üye", "GOLD" },
                    { "6d44ef31-d99f-40e3-bd29-57c095237af0", null, "Admin", "ADMIN" },
                    { "b1df481d-3481-4a3f-b954-60b398490951", null, "Yıldız Üye", "STAR" },
                    { "b6e4c3a2-ef5c-439f-a428-2b157a7ce1c4", null, "Platin Üye", "PLATIN" },
                    { "d1282ecc-6cec-498e-bd31-0a8415517c97", null, "Bronze Üye", "BRONZE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e2a137-104b-413d-ae69-9172615a9be2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32309305-d24c-4650-b146-3d6c5a5e01cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d44ef31-d99f-40e3-bd29-57c095237af0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1df481d-3481-4a3f-b954-60b398490951");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6e4c3a2-ef5c-439f-a428-2b157a7ce1c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1282ecc-6cec-498e-bd31-0a8415517c97");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Point",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a0dcda4-17bf-4a34-853f-08f9bf34ea3c", null, "Admin", "ADMIN" },
                    { "45b2a761-0934-4782-9486-bbff6fe94d4f", null, "Yıldız Üye", "STAR" },
                    { "5582d20a-2c69-4292-a234-869db6cd7f65", null, "Platin Üye", "PLATIN" },
                    { "8a0763aa-24ae-412b-867a-c2988bd82d8b", null, "Gold Üye", "GOLD" },
                    { "9b49b152-bc43-466b-a3b2-d94b4d7e7fd9", null, "Bronze Üye", "BRONZE" },
                    { "f6c356b0-e99d-4cbc-93fd-df35205be331", null, "Silver Üye", "SILVER" }
                });
        }
    }
}
