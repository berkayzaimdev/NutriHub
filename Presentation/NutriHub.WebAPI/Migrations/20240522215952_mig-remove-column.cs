using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class migremovecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png", "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png", "Çilekli Protein Tozu", 1m, 999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png", "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png", "Kazein Protein", 9999m, 999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Stock" },
                values: new object[] { "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png", "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png", "Kreatin", 999 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Gender", "PasswordHash", "SecurityStamp" },
                values: new object[] { "908ee206-ed9c-44e9-8849-47f3cbaccf41", "Male", "AQAAAAIAAYagAAAAEL+/lP3IUbvYUs3fCVHBZpIHqhO147lQOq5WC6KppGcwVSeG1NuyMYil31GZVy6dKw==", "bfac2a6d-8cc4-41aa-b37a-8ef0c68d486d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Gender", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adb3d3bd-69f4-493e-883a-e99daafe7955", "Male", "AQAAAAIAAYagAAAAEJxy1vqxEccUI9PrSEG07LDD+mm0jW3bbHvgLjnCsmn/ZCLMXbHJEeK3ufnLSIKs3Q==", "b3b88a20-11c6-4252-b311-caad9947833e" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "...", "...", "1000 gr", 178m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "...", "...", "3000 gr", 300m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardImageUrl", "LargeImageUrl", "Name", "Stock" },
                values: new object[] { "...", "...", "500 gr", 0 });
        }
    }
}
