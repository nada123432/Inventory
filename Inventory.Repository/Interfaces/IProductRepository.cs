using Inventory.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Product>> GetLowStockProductsAsync();
        
    }
}
