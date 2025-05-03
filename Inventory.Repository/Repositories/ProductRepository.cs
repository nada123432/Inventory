using Inventory.Domain;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(InventoryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(p => p.Category)
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetLowStockProductsAsync()
        {
            return await _dbSet
                .AsNoTracking()
                .Include(p => p.Category)
                .Where(p => p.Quantity <= p.LowStockThreshold)
                .OrderBy(p => p.Quantity)
                .ToListAsync();
        }

    }
}
