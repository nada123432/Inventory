using Inventory.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.InventoryTransaction
{
    public class InventoryTransactionForCreationDto
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public string UserId { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        
        [Required]
        public TransactionType TransactionType { get; set; }
        
        public int? SourceWarehouseId { get; set; }
        
        public int? DestinationWarehouseId { get; set; }
        
        public string Notes { get; set; }
    }
}
