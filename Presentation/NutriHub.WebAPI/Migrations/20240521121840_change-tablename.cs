using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class changetablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Point_AspNetUsers_UserId",
                table: "Point");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Point",
                table: "Point");

            migrationBuilder.RenameTable(
                name: "Point",
                newName: "Points");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Points",
                table: "Points",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "908ee206-ed9c-44e9-8849-47f3cbaccf41", "AQAAAAIAAYagAAAAEL+/lP3IUbvYUs3fCVHBZpIHqhO147lQOq5WC6KppGcwVSeG1NuyMYil31GZVy6dKw==", "bfac2a6d-8cc4-41aa-b37a-8ef0c68d486d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adb3d3bd-69f4-493e-883a-e99daafe7955", "AQAAAAIAAYagAAAAEJxy1vqxEccUI9PrSEG07LDD+mm0jW3bbHvgLjnCsmn/ZCLMXbHJEeK3ufnLSIKs3Q==", "b3b88a20-11c6-4252-b311-caad9947833e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Points_AspNetUsers_UserId",
                table: "Points",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_AspNetUsers_UserId",
                table: "Points");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Points",
                table: "Points");

            migrationBuilder.RenameTable(
                name: "Points",
                newName: "Point");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Point",
                table: "Point",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3590443b-a81a-422d-bfbf-119f744fc294", "AQAAAAIAAYagAAAAECh+HiWSgxrclkuoFuN+cm7sJMF0GskNEfBhg9Da50ZegRYhFj72EiiGbstyOQZGcQ==", "6871b837-987b-4fc5-85dd-cec92dc6fec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "017a649a-47e8-481f-9c33-58b4ceadeacd", "AQAAAAIAAYagAAAAEHqxWFTnHzv9qEdVQzZ1u5MCGNBBKBIiu0wpcvtxg4RRHCcbD+/vEaKzTcl37OUt8g==", "1073ffce-9a99-4aab-837a-6d3900d30921" });

            migrationBuilder.AddForeignKey(
                name: "FK_Point_AspNetUsers_UserId",
                table: "Point",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
