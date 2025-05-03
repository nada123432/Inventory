using Inventory.Services.DTOs.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId); // مهم: هذا هو الاسم الصحيح

        Task<IEnumerable<ProductDto>> GetLowStockProductsAsync();
        Task<ProductDto> CreateProductAsync(ProductForCreationDto productDto);
        Task<ProductDto> UpdateProductAsync(int id, ProductForUpdateDto productDto);
        Task<bool> DeleteProductAsync(int id);
    }
}
