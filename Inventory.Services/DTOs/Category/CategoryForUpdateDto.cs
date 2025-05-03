using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.Category
{
    public class CategoryForUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
