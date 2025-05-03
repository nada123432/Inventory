using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    public class Notification : baseEntity
    {
     
            [Required]
            [MaxLength(200)]
            public string Title { get; set; }

            [Required]
            [MaxLength(1000)]
            public string Message { get; set; }

            [Required]
            public bool IsRead { get; set; } = false;

            [Required]
            public NotificationType Type { get; set; }

            [Required]
            [ForeignKey("User")]
            public string UserId { get; set; }

            [InverseProperty("Notifications")]
            public ApplicationUser User { get; set; }

            [ForeignKey("Product")]
            public int? ProductId { get; set; }

            [InverseProperty("Notifications")]
            public Product Product { get; set; }
        }
    }

