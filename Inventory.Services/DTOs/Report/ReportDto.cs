using Inventory.Domain.Enums;
using Inventory.Services.DTOs.Base;
using Inventory.Services.DTOs.User;
using System;

namespace Inventory.Services.DTOs.Report
{
    public class ReportDto : BaseDto
    {
        public string Title { get; set; }
        public ReportType Type { get; set; }
        public string GeneratedByUserId { get; set; }
        public UserDto GeneratedByUser { get; set; }
        
        public string FilePath { get; set; }
        public string DataJson { get; set; }
        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CategoryFilter { get; set; }
    }
}
