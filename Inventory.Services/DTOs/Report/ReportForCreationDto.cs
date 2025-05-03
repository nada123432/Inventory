using Inventory.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Services.DTOs.Report
{
    public class ReportForCreationDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
        
        [Required]
        public ReportType Type { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public DateTime GeneratedDate { get; set; } = DateTime.UtcNow;
        
        [Required]
        public string GeneratedByUserId { get; set; }
    }
}
