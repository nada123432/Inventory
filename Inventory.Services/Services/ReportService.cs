using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.Report;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IProductRepository _productRepository;
        private readonly IInventoryTransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public ReportService(
            IReportRepository reportRepository,
            IProductRepository productRepository,
            IInventoryTransactionRepository transactionRepository,
            IMapper mapper)
        {
            _reportRepository = reportRepository;
            _productRepository = productRepository;
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetLowStockReportAsync()
        {
            try
            {
                var lowStockProducts = await _productRepository.GetLowStockProductsAsync();
                return _mapper.Map<IEnumerable<ProductDto>>(lowStockProducts);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetLowStockReportAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<InventoryTransactionDto>> GetTransactionHistoryReportAsync(
            DateTime? startDate = null,
            DateTime? endDate = null,
            int? productId = null,
            int? categoryId = null,
            TransactionType? transactionType = null)
        {
            try
            {
                IEnumerable<InventoryTransaction> transactions;

                if (startDate.HasValue && endDate.HasValue)
                {
                    transactions = await _transactionRepository.GetTransactionsByDateRangeAsync(
                        startDate.Value, endDate.Value);
                }
                else
                {
                    transactions = await _transactionRepository.GetAllAsync();
                }

                if (productId.HasValue)
                {
                    transactions = transactions.Where(t => t.ProductId == productId.Value);
                }

                if (categoryId.HasValue)
                {
                    var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId.Value);
                    var productIds = products.Select(p => p.Id).ToList();
                    transactions = transactions.Where(t => productIds.Contains(t.ProductId));
                }

                if (transactionType.HasValue)
                {
                    transactions = transactions.Where(t => t.TransactionType == transactionType.Value);
                }

                return _mapper.Map<IEnumerable<InventoryTransactionDto>>(transactions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTransactionHistoryReportAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<ReportDto> GenerateReportAsync(ReportForCreationDto reportDto)
        {
            try
            {
                var report = _mapper.Map<Report>(reportDto);

                switch (reportDto.Type)
                {
                    case ReportType.LowStock:
                        var lowStockProducts = await _productRepository.GetLowStockProductsAsync();
                        report.DataJson = JsonSerializer.Serialize(lowStockProducts);
                        break;

                    case ReportType.TransactionHistory:
                        var transactions = await _transactionRepository.GetTransactionsByDateRangeAsync(
                            reportDto.StartDate ?? DateTime.UtcNow.AddMonths(-1),
                            reportDto.EndDate ?? DateTime.UtcNow);
                        report.DataJson = JsonSerializer.Serialize(transactions);
                        break;

                    case ReportType.InventorySummary:
                        var allProducts = await _productRepository.GetAllAsync();
                        report.DataJson = JsonSerializer.Serialize(allProducts);
                        break;
                }

                var createdReport = await _reportRepository.AddAsync(report);
                return _mapper.Map<ReportDto>(createdReport);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GenerateReportAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<ReportDto> SaveReportAsync(string title, string description, ReportType type, IDictionary<string, object> parameters)
        {
            try
            {
                var reportDto = new ReportForCreationDto
                {
                    Title = title,
                    Description = description,
                    Type = type,
                    GeneratedDate = DateTime.UtcNow
                };

                if (parameters.ContainsKey("startDate") && parameters["startDate"] is DateTime startDate)
                {
                    reportDto.StartDate = startDate;
                }
                
                if (parameters.ContainsKey("endDate") && parameters["endDate"] is DateTime endDate)
                {
                    reportDto.EndDate = endDate;
                }

                return await GenerateReportAsync(reportDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveReportAsync: {ex.Message}");
                throw;
            }
        }
    }
}