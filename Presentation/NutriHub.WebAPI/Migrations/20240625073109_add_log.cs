using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriHub.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class add_log : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "244cfd13-6d89-4332-814f-90c5edd9ce70", "AQAAAAIAAYagAAAAEOtrbllaHaYs9REnDiUVCBimGs+vQvlitTzhhQTTLhc16LL0MA75ZbWnKbBVV1hOBA==", "c2971754-03ed-45b2-8199-77b4e8748e79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1a57240-01bf-4624-9e3b-92b545bd824b", "AQAAAAIAAYagAAAAEFRKm4s5juhYN0OcrL/x7qQBFKvXqq2RVkpoHfa6XCUTuX2iuOL3yAT2mLTNky8rCA==", "f83ce657-cf29-4829-a541-26df0be3c916" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogEntries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dd2044e-1469-445a-a9dd-5e5af0a64c34", "AQAAAAIAAYagAAAAELLi0JNgvEmz8PEZzISm4rMQJsElL7/tqcnB4j1PYr6R5f5ETog5tDGpcwdxUky65Q==", "7954267e-fe55-440b-8de3-2cb211cb72a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "044de10b-dcc8-4e34-ace9-0091e28582b1", "AQAAAAIAAYagAAAAEPyRl9f6g+Uwn3BydZfrwmb7zyhclzMrPCnZbdoZtyMGoeSKI03gX38kGak4Du2ppg==", "9bc143d3-b9fb-4444-9ace-3d5834339227" });
        }
    }
}
