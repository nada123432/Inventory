using Inventory.API.Controllers;
using Inventory.Domain.Enums;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.DTOs.Product;
using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Inventory.Test.Controllers
{
    public class ReportsControllerTests
    {
        [Fact]
        public async Task GetTransactionHistory_WithLargePageSize_ShouldLimitToMaximum()
        {
            var reportServiceMock = new Mock<IReportService>();
            var transactions = new List<InventoryTransactionDto>();
            
            for (int i = 1; i <= 150; i++)
            {
                transactions.Add(new InventoryTransactionDto { Id = i, Quantity = i });
            }

            reportServiceMock.Setup(service => service.GetTransactionHistoryReportAsync(
                It.IsAny<DateTime?>(), 
                It.IsAny<DateTime?>(), 
                It.IsAny<int?>(), 
                It.IsAny<int?>(), 
                It.IsAny<TransactionType?>()))
                .ReturnsAsync(transactions);

            var controller = new ReportsController(reportServiceMock.Object);

            var result = await controller.GetTransactionHistory(
                productId: null,
                startDate: null,
                endDate: null,
                categoryId: null,
                pageNumber: 1,
                pageSize: 200);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedItems = Assert.IsType<List<InventoryTransactionDto>>(okResult.Value);
            
            Assert.Equal(100, returnedItems.Count);
        }

        [Fact]
        public async Task GetLowStockReport_ShouldReturnOkResult()
        {
            var reportServiceMock = new Mock<IReportService>();
            
            var products = new List<ProductDto>
            {
                new ProductDto { Id = 1, Name = "Low Stock Product", Quantity = 3 }
            };

            reportServiceMock.Setup(service => service.GetLowStockReportAsync())
                .ReturnsAsync(products);

            var controller = new ReportsController(reportServiceMock.Object);

            var result = await controller.GetLowStockReport();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            
            var returnedProducts = Assert.IsAssignableFrom<IEnumerable<ProductDto>>(okResult.Value);
            
            Assert.Single(returnedProducts);
        }
    }
}
