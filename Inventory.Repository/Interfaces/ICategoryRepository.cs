using Inventory.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
        Task<Category> GetCategoryWithProductsAsync(int id);
    }
}
