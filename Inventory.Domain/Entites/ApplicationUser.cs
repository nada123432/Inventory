using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory.Domain.Entites
{
    public class ApplicationUser: IdentityUser
    {

        [InverseProperty("User")]
        public ICollection<Notification> Notifications { get; set; }


        [InverseProperty("GeneratedByUser")]
        public ICollection<Report> Reports { get; set; }
        public virtual ICollection<ProductWarehouse> ProductWarehouse { get; set; }

    }
}
