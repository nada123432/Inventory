using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    [Table("ProductWarehouses")]
    public class ProductWarehouse:baseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "quantity must be >0")]
        public int Quantity { get; set; }
    }
}
