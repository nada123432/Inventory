using Inventory.Domain.Enums;
using Inventory.Services.DTOs;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.Report;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<ProductDto>> GetLowStockReportAsync();
        Task<IEnumerable<InventoryTransactionDto>> GetTransactionHistoryReportAsync(
            DateTime? startDate = null,
            DateTime? endDate = null,
            int? productId = null,
            int? categoryId = null,
            TransactionType? transactionType = null);
        Task<ReportDto> GenerateReportAsync(ReportForCreationDto reportDto);
        Task<ReportDto> SaveReportAsync(string title, string description, ReportType type, IDictionary<string, object> parameters);
    }
}
