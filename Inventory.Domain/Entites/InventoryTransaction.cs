using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    public class InventoryTransaction : baseEntity
    {
        public TransactionType TransactionType { get; set; }
        public int Quantity { get; set; }
        
        public int? ReportId { get; set; }
        public Report Report { get; set; }
        
        [ForeignKey("SourceWarehouse")]
        public int? SourceWarehouseId { get; set; }
        public Warehouse SourceWarehouse { get; set; }

        [ForeignKey("DestinationWarehouse")]
        public int? DestinationWarehouseId { get; set; }
        public Warehouse DestinationWarehouse { get; set; }
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
