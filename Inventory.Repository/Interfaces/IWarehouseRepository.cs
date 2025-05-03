using Inventory.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IWarehouseRepository : IBaseRepository<Warehouse>
    {
        Task<IEnumerable<Warehouse>> GetWarehousesWithProductsAsync();
        Task<Warehouse> GetWarehouseWithProductsAsync(int id);
    }
}
