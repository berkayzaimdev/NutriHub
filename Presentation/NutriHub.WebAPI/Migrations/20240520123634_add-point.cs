using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addpoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "LargeImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "CardImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Point_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CardImageUrl",
                value: "...");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CardImageUrl",
                value: "...");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardImageUrl",
                value: "...");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Point");

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

            migrationBuilder.DropColumn(
                name: "CardImageUrl",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "LargeImageUrl",
                table: "Products",
                newName: "ImageUrl");

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
    }
}
