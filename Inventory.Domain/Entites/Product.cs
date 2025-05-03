using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    public class Product:baseEntity
    {
     

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int LowStockThreshold { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        
        [InverseProperty("Product")]
        public ICollection<Notification> Notifications { get; set; }
       
        [InverseProperty("Product")]
        public ICollection<ProductWarehouse> ProductWarehouses { get; set; }

        [InverseProperty("Product")]
        public ICollection<InventoryTransaction> Transactions { get; set; }
    }
}
