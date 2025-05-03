using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.ProductWarehouse
{
    public class ProductWarehouseForUpdateDto
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
