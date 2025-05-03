using Inventory.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IProductWarehouseRepository : IBaseRepository<ProductWarehouse>
    {
        Task<IEnumerable<ProductWarehouse>> GetByProductIdAsync(int productId);
        Task<IEnumerable<ProductWarehouse>> GetByWarehouseIdAsync(int warehouseId);
        Task<ProductWarehouse> GetByProductAndWarehouseIdAsync(int productId, int warehouseId);
    }
}
