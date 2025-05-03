using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class inittt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "69582def-2da5-4884-8311-1e7867ffd5a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8744bec9-3fd9-4294-9976-9a8c2b4e6290");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a0ea3e9-3bad-4cca-8902-8d6a0ba2b665", "AQAAAAIAAYagAAAAEM+x1CCqSZ7gtQxQyj6xzjiokFMkdmR1e7YyEQd91minM/bBbxoUulSjp4RvBj0SGA==", "56d3dab4-6c92-4489-8894-d234f547166e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b52ed148-606e-4c58-86d2-37e5f1d04eb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "86232894-335b-47f0-a12d-c9487bab7576");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8a5587-1cbb-4100-97b0-29de7deb9efc", "AQAAAAIAAYagAAAAEARdpNdzP67de7rpDDmydL0SiRbaXceQhfQnxejjsuxducb5GecdMiI5usrOBs4jqw==", "7e4fe79f-3fc9-4ddc-bd93-043438c65ba6" });
        }
    }
}
