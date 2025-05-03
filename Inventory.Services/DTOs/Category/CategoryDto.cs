using Inventory.Services.DTOs.Base;
using Inventory.Services.DTOs.Product;
using System.Collections.Generic;

namespace Inventory.Services.DTOs.Category
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}
