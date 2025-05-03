using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entites
{
    public class Report : baseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Required]
        public ReportType Type { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        [Required]
        public DateTime GeneratedAt { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string DataJson { get; set; }

        [ForeignKey("GeneratedByUser")]
        public string GeneratedByUserId { get; set; }
        public ApplicationUser GeneratedByUser { get; set; }
    }
}