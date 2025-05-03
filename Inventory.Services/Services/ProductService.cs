using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.Product;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        // طرق أساسية
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        // تنفيذ طريقة GetProductsByCategoryAsync المطلوبة في الواجهة
        // ملاحظة: تستخدم GetProductsByCategoryIdAsync من الريبوزيتوري
        public async Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId);
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        // طرق إضافية
        public async Task<IEnumerable<ProductDto>> GetLowStockProductsAsync()
        {
            var products = await _productRepository.GetLowStockProductsAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto productDto)
        {
            try
            {
                var product = _mapper.Map<Product>(productDto);
                var createdProduct = await _productRepository.AddAsync(product);
                return _mapper.Map<ProductDto>(createdProduct);
            }
            catch (Exception ex)
            {
                throw new Exception($"حدث خطأ أثناء إنشاء المنتج: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            try
            {
                var product = await _productRepository.GetByIdAsync(id);
                if (product == null)
                    return false;

                return await _productRepository.DeleteAsync(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"حدث خطأ أثناء حذف المنتج: {ex.Message}", ex);
            }
        }

        public async Task<ProductDto> UpdateProductAsync(int id, ProductForUpdateDto productDto)
        {
            try
            {
                var existingProduct = await _productRepository.GetByIdAsync(id);
                if (existingProduct == null)
                    return null;

                _mapper.Map(productDto, existingProduct);
                existingProduct.UpdatedAt = DateTime.UtcNow;

                await _productRepository.UpdateAsync(existingProduct);
                return _mapper.Map<ProductDto>(existingProduct);
            }
            catch (Exception ex)
            {
                throw new Exception($"حدث خطأ أثناء تحديث المنتج: {ex.Message}", ex);
            }
        }
    }
}
