using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.Category;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            try
            {
                var categories = await _categoryRepository.GetAllAsync();
                return _mapper.Map<IEnumerable<CategoryDto>>(categories);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving categories: {ex.Message}");
                throw;
            }
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            try
            {
                var category = await _categoryRepository.GetByIdAsync(id);
                if (category == null)
                    return null;

                return _mapper.Map<CategoryDto>(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving category: {ex.Message}");
                throw;
            }
        }

        public async Task<CategoryDto> GetCategoryWithProductsAsync(int id)
        {
            try
            {
                var category = await _categoryRepository.GetCategoryWithProductsAsync(id);
                if (category == null)
                    return null;

                return _mapper.Map<CategoryDto>(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving category with products: {ex.Message}");
                throw;
            }
        }

      
      
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            try
            {
                var category = await _categoryRepository.GetByIdAsync(id);
                if (category == null)
                    return false;

                // Check if the category has products
                var categoryWithProducts = await _categoryRepository.GetCategoryWithProductsAsync(id);
                if (categoryWithProducts.Products != null && categoryWithProducts.Products.Count > 0)
                    throw new InvalidOperationException("Cannot delete category has  products");

                await _categoryRepository.DeleteAsync(category);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting category: {ex.Message}");
                throw;
            }
        }
    }
}
