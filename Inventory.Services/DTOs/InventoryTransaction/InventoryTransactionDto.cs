using Inventory.Domain.Enums;
using Inventory.Services.DTOs.Base;
using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.User;
using Inventory.Services.DTOs.Warehouse;
using System;

namespace Inventory.Services.DTOs.InventoryTransaction
{
    public class InventoryTransactionDto : BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        
        public string UserId { get; set; }
        public UserDto User { get; set; }
        
        public int Quantity { get; set; }
        public TransactionType TransactionType { get; set; }
        
        public int? SourceWarehouseId { get; set; }
        public WarehouseDto SourceWarehouse { get; set; }
        
        public int? DestinationWarehouseId { get; set; }
        public WarehouseDto DestinationWarehouse { get; set; }
        
        public int? ReportId { get; set; }
        
        public string Notes { get; set; }
    }
}
