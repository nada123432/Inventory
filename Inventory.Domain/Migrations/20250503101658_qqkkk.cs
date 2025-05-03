using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class qqkkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "807fa91c-fab8-4203-8798-4a85934041f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8f28c4f8-1ff5-490c-9a9d-98d29e962013");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9e0d37f-c635-4532-ac01-764b4f485520", "AQAAAAIAAYagAAAAEEcNUf3yUS2IOC6L04AsbMDaBVd2ypV8aC+NQRiDjoAd81cd26HB0DC8BbIVw0K+Eg==", "dee967b9-7943-456e-9f75-46a7e65f5554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a8b087a-fff6-4122-8047-5f26394e405f", "AQAAAAIAAYagAAAAEB8hIp4cPgkJ1Ooti3EhGjHXjMANix7CliPmTQjhGEm//W+z7QtC5DO4if14/eY7Ig==", "99d656b3-e4c2-4edc-99e1-ccc6f434ec3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2244ef8-160b-4916-b346-a6f707b9ba4d", "AQAAAAIAAYagAAAAEFVg8r2FSHmq0fDQkDVnq5b+kkvAUESQV6+oSjJwyHalJibRw+XzG0IV4G3X/StJ6w==", "c143c6bc-18cf-410c-a77f-84c32a53bdc3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 4, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 15, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 11, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 4, 28, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "GeneratedAt", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 2, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 5, 3, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 5, 2, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 4, 3, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 5, 3, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6179), new DateTime(2025, 5, 3, 10, 16, 58, 551, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 24, 10, 16, 58, 384, DateTimeKind.Utc).AddTicks(5493));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a5c6625d-ac32-4739-b922-659d74ffcf5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "db4b01f2-e61d-43de-9119-cb32a400cbb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", "7a6bb340-a3ff-45c9-838c-492dd83e20cb", "Manager", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74e7a19d-fc43-4010-b346-637490001867", "AQAAAAIAAYagAAAAEMiZmNAI2ln7b8SJvJDbze1J/6XmW+UtcolWxjlshQt4IPtuPhnMyPAKzLjWcqIQOg==", "4746add6-5251-4011-8dbe-d4ddb47cce54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbb439e7-2592-4cd9-b78c-9d5b86e5fcaa", "AQAAAAIAAYagAAAAECzZIgrKY3FEMIp/pYUIWd+1yt5kUJ7PAzP8mI2DiUHAk25chOhFwYJcrtC9jnXxSg==", "72dec0c7-6c9c-4bc4-805c-35cbdfbbea37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8a235d7-51e4-43b8-8da7-66f8d853f6c1", "AQAAAAIAAYagAAAAEL/YOZz2bw+wnZCXDuZxQx50ZRbgNBnh/AFNilrBE1UvZJCc1flOOefgDh9hfSVmMw==", "dc3f8f5c-d1d9-4987-9c27-fc7ad0ce7058" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 4, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 1, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 16, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 12, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 29, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 13, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 15, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 11, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(924), new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "GeneratedAt", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1180), new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 4, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GeneratedAt" },
                values: new object[] { new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 4, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9286));
        }
    }
}
