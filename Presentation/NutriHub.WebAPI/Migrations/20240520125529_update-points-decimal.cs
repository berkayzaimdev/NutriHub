using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatepointsdecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EarnedPoints",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c7baf0b-2062-44e6-8863-011365a800c1", null, "Yıldız Üye", "STAR" },
                    { "3448b22b-7d9a-4569-8b99-facbc4f626e3", null, "Gold Üye", "GOLD" },
                    { "872059c5-7aa6-4a32-a968-9f2f95c0f8cc", null, "Platin Üye", "PLATIN" },
                    { "a28a1384-3444-46cd-8733-e6b4962ec3d4", null, "Silver Üye", "SILVER" },
                    { "d39800f3-d3d6-4466-8aec-747b792f31db", null, "Admin", "ADMIN" },
                    { "f28fd720-a066-47a9-8296-b0e3e77135e8", null, "Bronze Üye", "BRONZE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c7baf0b-2062-44e6-8863-011365a800c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3448b22b-7d9a-4569-8b99-facbc4f626e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "872059c5-7aa6-4a32-a968-9f2f95c0f8cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a28a1384-3444-46cd-8733-e6b4962ec3d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d39800f3-d3d6-4466-8aec-747b792f31db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f28fd720-a066-47a9-8296-b0e3e77135e8");

            migrationBuilder.DropColumn(
                name: "EarnedPoints",
                table: "Orders");

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
    }
}
