using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addappliedcoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "143b4941-eca9-471b-8e00-67fdff6d1be3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a76c01-0417-4418-a763-245693e00efa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52d0d615-deaf-4c29-9218-fa8ce6d29093");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fb8deeb-8d76-4ad9-81c3-cdc640175d85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b977e2e-9bd2-4ec3-8361-ca5ed476c844");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da6771ef-9d11-43ef-8506-74c2355bffaa");

            migrationBuilder.CreateTable(
                name: "AppliedCoupons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedCoupons", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AppliedCoupons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppliedCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7089812c-1ac8-475d-8b0c-6d761595240f", null, "Bronze Üye", "BRONZE" },
                    { "83c26ceb-be46-4178-8dbd-b22721a86601", null, "Gold Üye", "GOLD" },
                    { "9bb659aa-c81e-46ce-9844-c452b95b99e4", null, "Silver Üye", "SILVER" },
                    { "a03bd675-a6a1-4a72-a914-eef8b82a2911", null, "Platin Üye", "PLATIN" },
                    { "a05f6b5e-ce65-41bb-95f8-31809341361c", null, "Yıldız Üye", "STAR" },
                    { "a2f48acc-8b3e-48fa-9405-bbcf1252de48", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppliedCoupons_CouponId",
                table: "AppliedCoupons",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "AppliedCoupons");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7089812c-1ac8-475d-8b0c-6d761595240f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83c26ceb-be46-4178-8dbd-b22721a86601");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bb659aa-c81e-46ce-9844-c452b95b99e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a03bd675-a6a1-4a72-a914-eef8b82a2911");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a05f6b5e-ce65-41bb-95f8-31809341361c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2f48acc-8b3e-48fa-9405-bbcf1252de48");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "143b4941-eca9-471b-8e00-67fdff6d1be3", null, "Platin Üye", "PLATIN" },
                    { "14a76c01-0417-4418-a763-245693e00efa", null, "Admin", "ADMIN" },
                    { "52d0d615-deaf-4c29-9218-fa8ce6d29093", null, "Yıldız Üye", "STAR" },
                    { "7fb8deeb-8d76-4ad9-81c3-cdc640175d85", null, "Silver Üye", "SILVER" },
                    { "8b977e2e-9bd2-4ec3-8361-ca5ed476c844", null, "Gold Üye", "GOLD" },
                    { "da6771ef-9d11-43ef-8506-74c2355bffaa", null, "Bronze Üye", "BRONZE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
