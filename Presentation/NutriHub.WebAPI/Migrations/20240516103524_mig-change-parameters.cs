using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class migchangeparameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "ShippingAmount",
                table: "Orders",
                newName: "ProductDiscount");

            migrationBuilder.RenameColumn(
                name: "ProductDiscounts",
                table: "Orders",
                newName: "PaymentMethodDiscount");

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13691335-0dc0-4e57-9d66-e1f43ab50580", null, "Bronze Üye", "BRONZE" },
                    { "37e427c5-723f-41e8-a241-2d831ebf93b7", null, "Gold Üye", "GOLD" },
                    { "7e4d7496-4f70-471a-93af-bef1d0c75008", null, "Platin Üye", "PLATIN" },
                    { "84c2efd3-b2dd-4865-9a17-617bf55c70e6", null, "Admin", "ADMIN" },
                    { "96b3c806-38a3-4936-98f2-513a3fbcbaa2", null, "Silver Üye", "SILVER" },
                    { "e106509d-c5db-4a77-948b-b17b7cd207f4", null, "Yıldız Üye", "STAR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CouponId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13691335-0dc0-4e57-9d66-e1f43ab50580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e427c5-723f-41e8-a241-2d831ebf93b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e4d7496-4f70-471a-93af-bef1d0c75008");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84c2efd3-b2dd-4865-9a17-617bf55c70e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b3c806-38a3-4936-98f2-513a3fbcbaa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e106509d-c5db-4a77-948b-b17b7cd207f4");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ProductDiscount",
                table: "Orders",
                newName: "ShippingAmount");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodDiscount",
                table: "Orders",
                newName: "ProductDiscounts");

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
        }
    }
}
