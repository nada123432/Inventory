using Inventory.Domain;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class WarehouseRepository : BaseRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(InventoryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Warehouse>> GetWarehousesWithProductsAsync()
        {
            return await _dbSet
                .AsNoTracking()
                .Include(w => w.ProductWarehouses)
                    .ThenInclude(pw => pw.Product)
                .ToListAsync();
        }

        public async Task<Warehouse> GetWarehouseWithProductsAsync(int id)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(w => w.ProductWarehouses)
                    .ThenInclude(pw => pw.Product)
                .FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}
