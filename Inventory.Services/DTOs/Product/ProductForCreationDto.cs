using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.Product
{
    public class ProductForCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int LowStockThreshold { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
