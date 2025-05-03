using Inventory.API.Controllers;
using Inventory.Services.DTOs.Product;
using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Inventory.Test.Controllers
{
    public class ProductsControllerTests
    {
        private readonly Mock<IProductService> _productServiceMock;
        private readonly ProductsController _controller;

        public ProductsControllerTests()
        {
            _productServiceMock = new Mock<IProductService>();
            _controller = new ProductsController(_productServiceMock.Object);
        }

        [Fact]
        public async Task GetProducts_ShouldReturnAllProducts()
        {
            var productsList = new List<ProductDto>
            {
                new ProductDto { Id = 1, Name = "Product 1", Price = 100, Quantity = 10 },
                new ProductDto { Id = 2, Name = "Product 2", Price = 200, Quantity = 20 }
            };

            _productServiceMock.Setup(service => service.GetAllProductsAsync())
                .ReturnsAsync(productsList);

            var result = await _controller.GetAllProducts();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedProducts = Assert.IsAssignableFrom<IEnumerable<ProductDto>>(okResult.Value);
            
            Assert.Equal(2, returnedProducts.Count());
        }

        [Fact]
        public async Task GetProduct_WithValidId_ShouldReturnProduct()
        {
            var productId = 1;
            var product = new ProductDto { Id = productId, Name = "Product 1", Price = 100, Quantity = 10 };

            _productServiceMock.Setup(service => service.GetProductByIdAsync(productId))
                .ReturnsAsync(product);

            var result = await _controller.GetProduct(productId);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedProduct = Assert.IsType<ProductDto>(okResult.Value);
            
            Assert.Equal(productId, returnedProduct.Id);
            Assert.Equal("Product 1", returnedProduct.Name);
        }

        [Fact]
        public async Task GetProduct_WithInvalidId_ShouldReturnNotFound()
        {
            var invalidProductId = 324;
            ProductDto nullProduct = null;

            _productServiceMock.Setup(service => service.GetProductByIdAsync(invalidProductId))
                .ReturnsAsync(nullProduct);

            var result = await _controller.GetProduct(invalidProductId);

            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
