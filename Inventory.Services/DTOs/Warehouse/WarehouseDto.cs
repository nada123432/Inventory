using Inventory.Services.DTOs.Base;
using Inventory.Services.DTOs.ProductWarehouse;
using System.Collections.Generic;

namespace Inventory.Services.DTOs.Warehouse
{
    public class WarehouseDto : BaseDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<ProductWarehouseDto> ProductWarehouses { get; set; }
    }
}
