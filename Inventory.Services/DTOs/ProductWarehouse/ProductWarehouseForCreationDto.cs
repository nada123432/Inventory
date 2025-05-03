using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.ProductWarehouse
{
    public class ProductWarehouseForCreationDto
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int WarehouseId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
