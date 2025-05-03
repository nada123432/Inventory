using Inventory.Services.DTOs.Warehouse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IWarehouseService
    {
        Task<IEnumerable<WarehouseDto>> GetAllWarehousesAsync();
        Task<WarehouseDto> GetWarehouseByIdAsync(int id);
        Task<WarehouseDto> CreateWarehouseAsync(WarehouseForCreationDto warehouseDto);
        Task<WarehouseDto> UpdateWarehouseAsync(int id, WarehouseForUpdateDto warehouseDto);
        Task<bool> DeleteWarehouseAsync(int id);
    }
}
