using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class qqk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_userId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_userId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CategoryFilter",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Reports");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Reports",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GeneratedByUserId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DataJson",
                table: "Reports",
                type: "nvarchar(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "GeneratedAt",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ReportId",
                table: "InventoryTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "74e7a19d-fc43-4010-b346-637490001867", "admin@inventory.com", "ADMIN@INVENTORY.COM", "AQAAAAIAAYagAAAAEMiZmNAI2ln7b8SJvJDbze1J/6XmW+UtcolWxjlshQt4IPtuPhnMyPAKzLjWcqIQOg==", "+1-555-123-4567", "4746add6-5251-4011-8dbe-d4ddb47cce54" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2", 0, "bbb439e7-2592-4cd9-b78c-9d5b86e5fcaa", "manager@inventory.com", true, false, null, "MANAGER@INVENTORY.COM", "MANAGER", "AQAAAAIAAYagAAAAECzZIgrKY3FEMIp/pYUIWd+1yt5kUJ7PAzP8mI2DiUHAk25chOhFwYJcrtC9jnXxSg==", "+1-555-234-5678", false, "72dec0c7-6c9c-4bc4-805c-35cbdfbbea37", false, "manager" },
                    { "3", 0, "b8a235d7-51e4-43b8-8da7-66f8d853f6c1", "user@inventory.com", true, false, null, "USER@INVENTORY.COM", "USER", "AQAAAAIAAYagAAAAEL/YOZz2bw+wnZCXDuZxQx50ZRbgNBnh/AFNilrBE1UvZJCc1flOOefgDh9hfSVmMw==", "+1-555-345-6789", false, "dc3f8f5c-d1d9-4987-9c27-fc7ad0ce7058", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 3, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9169), "Electronics", null },
                    { 2, new DateTime(2025, 4, 4, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9176), "Home Appliances", null },
                    { 3, new DateTime(2025, 4, 5, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9178), "Clothing", null },
                    { 4, new DateTime(2025, 4, 6, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9179), "Food & Beverages", null },
                    { 5, new DateTime(2025, 4, 7, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9180), "Office Supplies", null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CreatedAt", "DataJson", "Description", "EndDate", "GeneratedAt", "GeneratedByUserId", "StartDate", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(924), "[]", "Report showing products that have reached low stock levels", null, new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(921), "1", null, "Low Stock Products Report", 0, null },
                    { 2, new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1180), "[]", "Report showing inventory transactions from the past 30 days", new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1172), "1", new DateTime(2025, 4, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1168), "Transaction History (2025-04-03 - 2025-05-03)", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "CreatedAt", "Location", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 4, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9283), "New York", "Main Warehouse", null },
                    { 2, new DateTime(2025, 3, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9285), "Los Angeles", "West Coast Hub", null },
                    { 3, new DateTime(2025, 3, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9286), "Chicago", "Midwest Center", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "2" },
                    { "2", "3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "LowStockThreshold", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 18, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9308), "High-performance laptop with 16GB RAM", 5, "Laptop", 1200m, 15, null },
                    { 2, 2, new DateTime(2025, 4, 23, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9310), "2000W powerful vacuum cleaner", 5, "Vacuum Cleaner", 180m, 3, null },
                    { 3, 1, new DateTime(2025, 4, 13, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9312), "Latest model with 5G capability", 8, "Smartphone", 899m, 25, null },
                    { 4, 5, new DateTime(2025, 4, 8, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9313), "Ergonomic design for comfort", 4, "Office Chair", 250m, 12, null },
                    { 5, 4, new DateTime(2025, 4, 28, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9317), "1 liter vegetable cooking oil", 10, "Cooking Oil", 7.99m, 7, null },
                    { 6, 3, new DateTime(2025, 4, 15, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9319), "Men's formal shirt, 100% cotton", 10, "Dress Shirt", 45.50m, 30, null },
                    { 7, 1, new DateTime(2025, 4, 11, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9320), "Noise-cancelling wireless headphones", 5, "Headphones", 199.99m, 18, null },
                    { 8, 2, new DateTime(2025, 4, 21, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9322), "Automatic drip coffee maker with timer", 4, "Coffee Maker", 89.95m, 9, null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CreatedAt", "DataJson", "Description", "EndDate", "GeneratedAt", "GeneratedByUserId", "StartDate", "Title", "Type", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1187), "[]", "Report showing current inventory status", null, new DateTime(2025, 5, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(1186), "2", null, "Inventory Summary 2025-05-03", 2, null });

            migrationBuilder.InsertData(
                table: "InventoryTransactions",
                columns: new[] { "Id", "CreatedAt", "DestinationWarehouseId", "ProductId", "Quantity", "ReportId", "SourceWarehouseId", "TransactionType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 3, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(848), null, 1, 10, null, 1, 0, null, "1" },
                    { 2, new DateTime(2025, 4, 8, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(851), null, 2, 5, null, 1, 0, null, "2" },
                    { 3, new DateTime(2025, 4, 18, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(858), null, 2, 2, null, 1, 1, null, "3" },
                    { 4, new DateTime(2025, 4, 19, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(860), 2, 1, 5, null, 1, 2, null, "1" },
                    { 5, new DateTime(2025, 4, 13, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(862), null, 3, 25, null, 1, 0, null, "2" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsRead", "Message", "ProductId", "Title", "Type", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(751), false, "Product Vacuum Cleaner has reached a low stock level (3 remaining). Minimum threshold is 5.", 2, "Low Stock Alert", 0, null, "1" },
                    { 2, new DateTime(2025, 5, 1, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(764), false, "Product Vacuum Cleaner has reached a low stock level (3 remaining). Minimum threshold is 5.", 2, "Low Stock Alert", 0, null, "2" },
                    { 3, new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(765), false, "Product Cooking Oil has reached a low stock level (7 remaining). Minimum threshold is 10.", 5, "Low Stock Alert", 0, null, "1" },
                    { 4, new DateTime(2025, 5, 2, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(767), true, "Product Cooking Oil has reached a low stock level (7 remaining). Minimum threshold is 10.", 5, "Low Stock Alert", 0, null, "2" },
                    { 5, new DateTime(2025, 4, 28, 10, 12, 51, 107, DateTimeKind.Utc).AddTicks(768), false, "Price of product Laptop has changed to $1200.", 1, "Product Information", 2, null, "3" }
                });

            migrationBuilder.InsertData(
                table: "ProductWarehouses",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "ProductId", "Quantity", "UpdatedAt", "WarehouseId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 19, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9347), 1, 10, null, 1 },
                    { 2, null, new DateTime(2025, 4, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9348), 2, 2, null, 1 },
                    { 3, null, new DateTime(2025, 4, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9350), 3, 15, null, 1 },
                    { 4, null, new DateTime(2025, 4, 9, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9351), 4, 8, null, 1 },
                    { 5, null, new DateTime(2025, 4, 29, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9352), 5, 5, null, 1 },
                    { 6, null, new DateTime(2025, 4, 16, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9353), 6, 20, null, 1 },
                    { 7, null, new DateTime(2025, 4, 12, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9354), 7, 12, null, 1 },
                    { 8, null, new DateTime(2025, 4, 22, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9355), 8, 6, null, 1 },
                    { 9, null, new DateTime(2025, 4, 19, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9356), 1, 5, null, 2 },
                    { 10, null, new DateTime(2025, 4, 14, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9357), 3, 10, null, 2 },
                    { 11, null, new DateTime(2025, 4, 16, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9358), 6, 10, null, 2 },
                    { 12, null, new DateTime(2025, 4, 12, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9359), 7, 6, null, 2 },
                    { 13, null, new DateTime(2025, 4, 24, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9361), 2, 1, null, 3 },
                    { 14, null, new DateTime(2025, 4, 9, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9362), 4, 4, null, 3 },
                    { 15, null, new DateTime(2025, 4, 29, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9363), 5, 2, null, 3 },
                    { 16, null, new DateTime(2025, 4, 22, 10, 12, 50, 931, DateTimeKind.Utc).AddTicks(9364), 8, 3, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GeneratedByUserId",
                table: "Reports",
                column: "GeneratedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_GeneratedByUserId",
                table: "Reports",
                column: "GeneratedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_GeneratedByUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_GeneratedByUserId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductWarehouses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "GeneratedAt",
                table: "Reports");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "GeneratedByUserId",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DataJson",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)");

            migrationBuilder.AddColumn<string>(
                name: "CategoryFilter",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ReportId",
                table: "InventoryTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "a97c3372-bd45-462d-96d4-02dbcc28a2d2", "admin@manager.com", "ADMIN@MANAGER.COM", "AQAAAAIAAYagAAAAEASgIzswfTUTfOJVlNjLPX67SFu+4OLrBS36IKAnGP5tzwmCzHiFQp8fYrdDrJxPxw==", null, "1a029bcc-8072-4ee0-a599-ed296fb960a9" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_userId",
                table: "Reports",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_userId",
                table: "Reports",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
