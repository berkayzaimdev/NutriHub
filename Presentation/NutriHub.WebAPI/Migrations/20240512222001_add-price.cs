using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c5a1da3-73f7-491a-807b-1f0d7cdee37e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75679413-3260-4f06-9bfd-483f8d81b8be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89f4d488-4e25-45c4-95bd-997b1ed6286f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "908db12a-fda3-469a-8819-9acc01f49910");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2877ce0-460b-499e-86aa-cebf6717ece8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd0f6dbd-c13d-42e6-a4ea-431916c6af57");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08878856-65f0-471a-847d-24dd713d795c", null, "Gold Üye", "GOLD" },
                    { "0b46c6f9-4a9d-45ca-82e7-5a12137317f4", null, "Admin", "ADMIN" },
                    { "2bf57d1a-f643-4dae-abfd-11b31da8480b", null, "Silver Üye", "SILVER" },
                    { "50ddc9cc-0358-463e-8995-392561357315", null, "Bronze Üye", "BRONZE" },
                    { "af1f43e4-9547-4830-942d-6a481301e4a4", null, "Yıldız Üye", "STAR" },
                    { "af7a593a-62f7-4e00-8b71-e928f87302e7", null, "Platin Üye", "PLATIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 178m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 300m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 55m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08878856-65f0-471a-847d-24dd713d795c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b46c6f9-4a9d-45ca-82e7-5a12137317f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bf57d1a-f643-4dae-abfd-11b31da8480b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ddc9cc-0358-463e-8995-392561357315");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af1f43e4-9547-4830-942d-6a481301e4a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af7a593a-62f7-4e00-8b71-e928f87302e7");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c5a1da3-73f7-491a-807b-1f0d7cdee37e", null, "Admin", "ADMIN" },
                    { "75679413-3260-4f06-9bfd-483f8d81b8be", null, "Gold Üye", "GOLD" },
                    { "89f4d488-4e25-45c4-95bd-997b1ed6286f", null, "Bronze Üye", "BRONZE" },
                    { "908db12a-fda3-469a-8819-9acc01f49910", null, "Yıldız Üye", "STAR" },
                    { "b2877ce0-460b-499e-86aa-cebf6717ece8", null, "Silver Üye", "SILVER" },
                    { "dd0f6dbd-c13d-42e6-a4ea-431916c6af57", null, "Platin Üye", "PLATIN" }
                });
        }
    }
}
