using Inventory.Services.DTOs.ProductWarehouse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IProductWarehouseService
    {
        Task<IEnumerable<ProductWarehouseDto>> GetByProductIdAsync(int productId);
        Task<IEnumerable<ProductWarehouseDto>> GetByWarehouseIdAsync(int warehouseId);
        Task<ProductWarehouseDto> GetByProductAndWarehouseIdAsync(int productId, int warehouseId);
        Task<ProductWarehouseDto> AssignProductToWarehouseAsync(ProductWarehouseForCreationDto dto);
        Task<ProductWarehouseDto> UpdateProductWarehouseQuantityAsync(int productId, int warehouseId, ProductWarehouseForUpdateDto dto);
        Task<bool> RemoveProductFromWarehouseAsync(int productId, int warehouseId);
    }
}
