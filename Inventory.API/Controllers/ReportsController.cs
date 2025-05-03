using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Inventory.Domain.Enums;
using Inventory.Services.Services;
using Inventory.Services.DTOs.Report;

namespace Inventory.API.Controllers
{
    [Route("api/report")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }
       
        [Authorize(Roles ="Admin")]
        [HttpGet("low-stock")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetLowStockReport()
        {
            var lowStockProducts = await _reportService.GetLowStockReportAsync();
            return Ok(lowStockProducts);
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<ActionResult<ReportDto>> GenerateReport(ReportForCreationDto reportDto)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "startDate", reportDto.StartDate },
                    { "endDate", reportDto.EndDate }
                };

                var report = await _reportService.SaveReportAsync(
                    reportDto.Title,
                    reportDto.Description,
                    reportDto.Type,
                    parameters);

                return Ok(report);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("transaction-history")]
        public async Task<ActionResult<IEnumerable<InventoryTransactionDto>>> GetTransactionHistory(
            [FromQuery] int? productId,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate,
            [FromQuery] int? categoryId = null,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 50)
        {
            if (pageSize > 100)
                pageSize = 100;

            if (!startDate.HasValue)
                startDate = DateTime.UtcNow.AddMonths(-1);
            if (!endDate.HasValue)
                endDate = DateTime.UtcNow;

            var transactions = await _reportService.GetTransactionHistoryReportAsync(
                startDate,  
                endDate,  
                productId,  
                categoryId
            );

            var pagedItems = transactions
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(pagedItems);
        }
    }
}
