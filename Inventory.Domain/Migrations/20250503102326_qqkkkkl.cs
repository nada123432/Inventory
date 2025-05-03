using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class qqkkkkl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9d1d240e-8dbc-4604-b9a1-0cc4fca51b27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e868c570-ad7b-4f2c-8435-474e76d1319e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc023c50-3375-44dd-afef-56150fdde384", "AQAAAAIAAYagAAAAEHI6y9G8FKUo+P8LA9hNdl80sjQLSsmwKNeW9ZyBghUelNrTbGEzvr7X+pfU8NHLww==", "370068d6-6dd6-4cac-91de-a04ce78759e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b6128e4-5169-45ba-b4a9-de0a0d2f64cd", "AQAAAAIAAYagAAAAEJyesF9oy+9YC7E7EeLGwlDTqUBB7yubwbPUa5tJyv8tHKoFq39FNl1FTcU1yEw8AQ==", "cdf96d51-df7f-4a2f-af68-93a9b0075461" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b8516fa-4c3e-4c6b-b392-85dad10c3b4f", "AQAAAAIAAYagAAAAEPlHfG8oxSauOtZavoxlsjL4obCjjYNlHHYCQeINcZ7q7ng19zRxYYVfLQvAtVHULQ==", "3256eca9-3789-41b0-ae47-4c1114ca66b4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 4, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 15, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 11, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8861), new DateTime(2025, 4, 28, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "GeneratedAt", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 2, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8998), new DateTime(2025, 5, 3, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8997), new DateTime(2025, 5, 2, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8998), new DateTime(2025, 4, 3, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 5, 3, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(9004), new DateTime(2025, 5, 3, 10, 23, 25, 939, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 24, 10, 23, 25, 752, DateTimeKind.Utc).AddTicks(570));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e7c5ddc0-1cbb-44af-9a99-fae15fe72b5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "93d6ec69-8d3a-4a47-962e-8a5930c66829");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac2f30f-a7e2-4175-a2e0-abcf633d7926", "AQAAAAIAAYagAAAAEDEONdmJhZDRNQB06rB0GShrDj6l2oHiIb/0cv9s5lBdl/u8xFBzMwiVc/RJW37LUw==", "e7a4a71e-d53c-4b40-b40c-d75c33fd1bd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f3da2e7-c161-4209-9388-e0abd798746c", "AQAAAAIAAYagAAAAEFsGvZF7aYQJR2fk94HTKNLZ3Ha50Wai/LSK3qErWqjMtQd/gi3tunadrwF4mIEIrw==", "ced88622-129d-4079-8278-474b82ce0db3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1b806e-c6f0-4055-9a98-34cda69a4d4b", "AQAAAAIAAYagAAAAEPwqsGhMS9d/ksJCYtNgNFXrBks5rFl8gOtJHPDBmxTLNBONtuw1RCJ7VPllG4CeuQ==", "2457ecc1-565b-4d17-8816-5f249e14c70a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 4, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 15, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 11, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 4, 28, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "GeneratedAt", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 2, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1498), new DateTime(2025, 5, 3, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1484), new DateTime(2025, 5, 2, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1490), new DateTime(2025, 4, 3, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 5, 3, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1508), new DateTime(2025, 5, 3, 10, 20, 1, 474, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 24, 10, 20, 1, 182, DateTimeKind.Utc).AddTicks(3173));
        }
    }
}
