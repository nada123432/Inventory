using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.ProductWarehouse;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class ProductWarehouseService : IProductWarehouseService
    {
        private readonly IProductWarehouseRepository _repository;
        private readonly IMapper _mapper;

        public ProductWarehouseService(
            IProductWarehouseRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductWarehouseDto>> GetByProductIdAsync(int productId)
        {
            var items = await _repository.GetByProductIdAsync(productId);
            return _mapper.Map<IEnumerable<ProductWarehouseDto>>(items);
        }

        public async Task<IEnumerable<ProductWarehouseDto>> GetByWarehouseIdAsync(int warehouseId)
        {
            var items = await _repository.GetByWarehouseIdAsync(warehouseId);
            return _mapper.Map<IEnumerable<ProductWarehouseDto>>(items);
        }

        public async Task<ProductWarehouseDto> GetByProductAndWarehouseIdAsync(int productId, int warehouseId)
        {
            var item = await _repository.GetByProductAndWarehouseIdAsync(productId, warehouseId);
            return _mapper.Map<ProductWarehouseDto>(item);
        }

        public async Task<ProductWarehouseDto> AssignProductToWarehouseAsync(ProductWarehouseForCreationDto dto)
        {
            var item = _mapper.Map<ProductWarehouse>(dto);
            var result = await _repository.AddAsync(item);
            return _mapper.Map<ProductWarehouseDto>(result);
        }

        public async Task<ProductWarehouseDto> UpdateProductWarehouseQuantityAsync(int productId, int warehouseId, ProductWarehouseForUpdateDto dto)
        {
            var item = await _repository.GetByProductAndWarehouseIdAsync(productId, warehouseId);
            if (item == null)
                return null;

            _mapper.Map(dto, item);
            await _repository.UpdateAsync(item);
            return _mapper.Map<ProductWarehouseDto>(item);
        }

        public async Task<bool> RemoveProductFromWarehouseAsync(int productId, int warehouseId)
        {
            var item = await _repository.GetByProductAndWarehouseIdAsync(productId, warehouseId);
            if (item == null)
                return false;
                
            await _repository.DeleteAsync(item);
            return true;
        }
    }
}
