using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addorderordercode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Bronze Üye", "BRONZE" },
                    { "3", null, "Silver Üye", "SILVER" },
                    { "4", null, "Gold Üye", "GOLD" },
                    { "5", null, "Platin Üye", "PLATIN" },
                    { "6", null, "Yıldız Üye", "STAR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "3590443b-a81a-422d-bfbf-119f744fc294", "admin@nutrihub.com", true, "Admin", "Male", "Admin", false, null, "ADMIN@NUTRIHUB.COM", "ADMIN", "AQAAAAIAAYagAAAAECh+HiWSgxrclkuoFuN+cm7sJMF0GskNEfBhg9Da50ZegRYhFj72EiiGbstyOQZGcQ==", null, false, "6871b837-987b-4fc5-85dd-cec92dc6fec8", false, "admin" },
                    { "2", 0, "017a649a-47e8-481f-9c33-58b4ceadeacd", "user@nutrihub.com", true, "Regular", "Male", "User", false, null, "REGULARUSER@NUTRIHUB.COM", "REGULARUSER", "AQAAAAIAAYagAAAAEHqxWFTnHzv9qEdVQzZ1u5MCGNBBKBIiu0wpcvtxg4RRHCcbD+/vEaKzTcl37OUt8g==", null, false, "1073ffce-9a99-4aab-837a-6d3900d30921", false, "regularuser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Orders");

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
    }
}
