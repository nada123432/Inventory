using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.Warehouse;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly IMapper _mapper;

        public WarehouseService(IWarehouseRepository warehouseRepository, IMapper mapper)
        {
            _warehouseRepository = warehouseRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WarehouseDto>> GetAllWarehousesAsync()
        {
            try
            {
                var warehouses = await _warehouseRepository.GetAllAsync();
                return _mapper.Map<IEnumerable<WarehouseDto>>(warehouses);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving warehouses: {ex.Message}");
                throw;
            }
        }

        public async Task<WarehouseDto> GetWarehouseByIdAsync(int id)
        {
            try
            {
                var warehouse = await _warehouseRepository.GetByIdAsync(id);
                if (warehouse == null)
                    return null;

                return _mapper.Map<WarehouseDto>(warehouse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving warehouse: {ex.Message}");
                throw;
            }
        }

        public async Task<WarehouseDto> GetWarehouseWithProductsAsync(int id)
        {
            try
            {
                var warehouse = await _warehouseRepository.GetWarehouseWithProductsAsync(id);
                if (warehouse == null)
                    return null;

                return _mapper.Map<WarehouseDto>(warehouse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving warehouse with products: {ex.Message}");
                throw;
            }
        }

        public async Task<WarehouseDto> CreateWarehouseAsync(WarehouseForCreationDto warehouseDto)
        {
            try
            {
                var warehouse = _mapper.Map<Warehouse>(warehouseDto);
                var result = await _warehouseRepository.AddAsync(warehouse);
                return _mapper.Map<WarehouseDto>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating warehouse: {ex.Message}");
                throw;
            }
        }

        public async Task<WarehouseDto> UpdateWarehouseAsync(int id, WarehouseForUpdateDto warehouseDto)
        {
            try
            {
                var existingWarehouse = await _warehouseRepository.GetByIdAsync(id);
                if (existingWarehouse == null)
                    return null;

                _mapper.Map(warehouseDto, existingWarehouse);
                await _warehouseRepository.UpdateAsync(existingWarehouse);
                return _mapper.Map<WarehouseDto>(existingWarehouse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating warehouse: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> DeleteWarehouseAsync(int id)
        {
            try
            {
                var warehouse = await _warehouseRepository.GetByIdAsync(id);
                if (warehouse == null)
                    return false;

                // Check if the warehouse has products
                var warehouseWithProducts = await _warehouseRepository.GetWarehouseWithProductsAsync(id);
                if (warehouseWithProducts.ProductWarehouses != null && warehouseWithProducts.ProductWarehouses.Count > 0)
                    throw new InvalidOperationException("Cannot delete warehouse with  products");

                await _warehouseRepository.DeleteAsync(warehouse);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting warehouse: {ex.Message}");
                throw;
            }
        }
    }
}
