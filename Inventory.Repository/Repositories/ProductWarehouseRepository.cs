using Inventory.Domain;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class ProductWarehouseRepository : BaseRepository<ProductWarehouse>, IProductWarehouseRepository
    {
        public ProductWarehouseRepository(InventoryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductWarehouse>> GetByProductIdAsync(int productId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(pw => pw.Warehouse)
                .Where(pw => pw.Id == productId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductWarehouse>> GetByWarehouseIdAsync(int warehouseId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(pw => pw.Product)
                .Where(pw => pw.WarehouseId == warehouseId)
                .ToListAsync();
        }

        public async Task<ProductWarehouse> GetByProductAndWarehouseIdAsync(int productId, int warehouseId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(pw => pw.Product)
                .Include(pw => pw.Warehouse)
                .FirstOrDefaultAsync(pw => pw.Id == productId && pw.WarehouseId == warehouseId);
        }
    }
}
