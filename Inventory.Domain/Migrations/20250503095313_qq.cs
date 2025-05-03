using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class qq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ebac64e7-9733-4613-b754-4c0243c1cb4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d6089f1d-ec85-44da-acbc-bce43d2f4f59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a97c3372-bd45-462d-96d4-02dbcc28a2d2", "AQAAAAIAAYagAAAAEASgIzswfTUTfOJVlNjLPX67SFu+4OLrBS36IKAnGP5tzwmCzHiFQp8fYrdDrJxPxw==", "1a029bcc-8072-4ee0-a599-ed296fb960a9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "49051662-2b0c-4f25-af1a-bfdf83f87690");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1aca0f21-efa8-44bb-9237-9d60dc684502");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a15e6f-c2e2-4ba4-a4a2-3f03455484ce", "AQAAAAIAAYagAAAAED5X3u0CTWDKif08HCtOmPTsGFRVyPOwQHD4nBUa5epI/SChLsmqGKABczsHfimVWQ==", "7ab3c15a-566b-4401-ba37-96727e483a34" });
        }
    }
}
