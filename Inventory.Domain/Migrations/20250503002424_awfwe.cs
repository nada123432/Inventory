using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    /// <inheritdoc />
    public partial class awfwe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_GeneratedByUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_GeneratedByUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "GeneratedAt",
                table: "Reports");

            migrationBuilder.AlterColumn<string>(
                name: "GeneratedByUserId",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ProductWarehouses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestinationWarehouseId",
                table: "InventoryTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "InventoryTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceWarehouseId",
                table: "InventoryTransactions",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Reports_userId",
                table: "Reports",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductWarehouses_ApplicationUserId",
                table: "ProductWarehouses",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_DestinationWarehouseId",
                table: "InventoryTransactions",
                column: "DestinationWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_ReportId",
                table: "InventoryTransactions",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_SourceWarehouseId",
                table: "InventoryTransactions",
                column: "SourceWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Warehouses_DestinationWarehouseId",
                table: "InventoryTransactions",
                column: "DestinationWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Warehouses_SourceWarehouseId",
                table: "InventoryTransactions",
                column: "SourceWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductWarehouses_AspNetUsers_ApplicationUserId",
                table: "ProductWarehouses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_userId",
                table: "Reports",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Reports_ReportId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Warehouses_DestinationWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Warehouses_SourceWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductWarehouses_AspNetUsers_ApplicationUserId",
                table: "ProductWarehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_userId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_userId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_ProductWarehouses_ApplicationUserId",
                table: "ProductWarehouses");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTransactions_DestinationWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTransactions_ReportId",
                table: "InventoryTransactions");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTransactions_SourceWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ProductWarehouses");

            migrationBuilder.DropColumn(
                name: "DestinationWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "InventoryTransactions");

            migrationBuilder.DropColumn(
                name: "SourceWarehouseId",
                table: "InventoryTransactions");

            migrationBuilder.AlterColumn<string>(
                name: "GeneratedByUserId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "GeneratedAt",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GeneratedByUserId",
                table: "Reports",
                column: "GeneratedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_GeneratedByUserId",
                table: "Reports",
                column: "GeneratedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
