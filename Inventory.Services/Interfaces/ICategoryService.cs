using Inventory.Services.Common;
using Inventory.Services.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
