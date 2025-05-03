using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.Warehouse;

namespace Inventory.Services.DTOs.ProductWarehouse
{
    public class ProductWarehouseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }

        public int WarehouseId { get; set; }
        public WarehouseDto Warehouse { get; set; }

        public int Quantity { get; set; }
    }
}
