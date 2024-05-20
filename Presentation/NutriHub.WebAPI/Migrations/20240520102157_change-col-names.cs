using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class changecolnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a2c02b8-6573-47b2-a4e9-2f624b2be8ba", null, "Silver Üye", "SILVER" },
                    { "1d575311-a046-47fd-9c9a-754ce6563ec2", null, "Platin Üye", "PLATIN" },
                    { "389db0d8-b51d-43fa-a200-cd8f64ca6a53", null, "Admin", "ADMIN" },
                    { "7d7e33ac-3933-439e-a6d6-a031c17a335f", null, "Yıldız Üye", "STAR" },
                    { "875210a5-489b-4752-bd1a-7c18bbdcbd49", null, "Gold Üye", "GOLD" },
                    { "f81231da-33d3-4832-83c7-0f13c79a95b1", null, "Bronze Üye", "BRONZE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a2c02b8-6573-47b2-a4e9-2f624b2be8ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d575311-a046-47fd-9c9a-754ce6563ec2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "389db0d8-b51d-43fa-a200-cd8f64ca6a53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7e33ac-3933-439e-a6d6-a031c17a335f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "875210a5-489b-4752-bd1a-7c18bbdcbd49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81231da-33d3-4832-83c7-0f13c79a95b1");

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
        }
    }
}
