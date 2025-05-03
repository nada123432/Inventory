using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    public class Warehouse : baseEntity
    {
        public string Name { get; set; } 
        public string Location { get; set; } 

        public ICollection<ProductWarehouse> ProductWarehouses { get; set; }

    }
}
