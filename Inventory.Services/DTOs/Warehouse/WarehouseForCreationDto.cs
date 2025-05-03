using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.Warehouse
{
    public class WarehouseForCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Location { get; set; }
    }
}
