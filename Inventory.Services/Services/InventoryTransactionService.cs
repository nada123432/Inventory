using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class InventoryTransactionService : IInventoryTransactionService
    {
        private readonly IInventoryTransactionRepository _transactionRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProductWarehouseRepository _productWarehouseRepository;
        private readonly IMapper _mapper;

        ILogger<InventoryTransactionService> logger;

        public InventoryTransactionService(
            IInventoryTransactionRepository transactionRepository,
            IProductRepository productRepository,
            IProductWarehouseRepository productWarehouseRepository,
            IMapper mapper, ILogger<InventoryTransactionService> logger)
        {
            _transactionRepository = transactionRepository;
            _productRepository = productRepository;
            _productWarehouseRepository = productWarehouseRepository;
            _mapper = mapper;
            logger = logger;

        }

        public async Task<IEnumerable<InventoryTransactionDto>> GetAllTransactionsAsync()
        {
            try
            {
                var transactions = await _transactionRepository.GetAllAsync();
                return _mapper.Map<IEnumerable<InventoryTransactionDto>>(transactions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllTransactionsAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<InventoryTransactionDto>> GetTransactionsByProductIdAsync(int productId)
        {
            try
            {
                var transactions = await _transactionRepository.GetTransactionsByProductIdAsync(productId);
                return _mapper.Map<IEnumerable<InventoryTransactionDto>>(transactions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTransactionsByProductIdAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<InventoryTransactionDto>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            try
            {
                var transactions = await _transactionRepository.GetTransactionsByDateRangeAsync(startDate, endDate);
                return _mapper.Map<IEnumerable<InventoryTransactionDto>>(transactions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTransactionsByDateRangeAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<InventoryTransactionDto> AddStockAsync(InventoryTransactionForCreationDto transactionDto)
        {
           
            try
            {
                // Check if product exists
                var product = await _productRepository.GetByIdAsync(transactionDto.ProductId);
                if (product == null)
                    throw new ArgumentException($"Product with ID {transactionDto.ProductId} not found");

                // Check if warehouse ID is provided
                if (!transactionDto.SourceWarehouseId.HasValue)
                    throw new ArgumentException("Source warehouse ID is required for adding stock");

                // Create transaction with AddStock type
                var transaction = _mapper.Map<InventoryTransaction>(transactionDto);
                transaction.TransactionType = TransactionType.AddStock;

                // Update product-warehouse quantity instead of just product quantity
                var productWarehouse = await _productWarehouseRepository.GetByProductAndWarehouseIdAsync( transactionDto.ProductId, transactionDto.SourceWarehouseId.Value);

                if (productWarehouse == null)
                {
                    // Create new relationship if it doesn't exist
                    productWarehouse = new ProductWarehouse
                    {
                        Id = transactionDto.ProductId,
                        WarehouseId = transactionDto.SourceWarehouseId.Value,
                        Quantity = 0
                    };
                    productWarehouse.Quantity += transactionDto.Quantity;
                    await _productWarehouseRepository.AddAsync(productWarehouse);
                }
                else
                {
                    // Update existing relationship
                    productWarehouse.Quantity += transactionDto.Quantity;
                    await _productWarehouseRepository.UpdateAsync(productWarehouse);
                }

                // Update total product quantity as well
                product.Quantity += transactionDto.Quantity;
                await _productRepository.UpdateAsync(product);

                // Save transaction
                var createdTransaction = await _transactionRepository.AddAsync(transaction);
                return _mapper.Map<InventoryTransactionDto>(createdTransaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddStockAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<InventoryTransactionDto> RemoveStockAsync(InventoryTransactionForCreationDto transactionDto)
        {
            try
            {
                // Check if product exists
                var product = await _productRepository.GetByIdAsync(transactionDto.ProductId);
                if (product == null)
                    throw new ArgumentException($"Product with ID {transactionDto.ProductId} not found");

                // Check if warehouse ID is provided
                if (!transactionDto.SourceWarehouseId.HasValue)
                    throw new ArgumentException("Source warehouse ID is required for removing stock");

                // Check if product exists in the specified warehouse with enough quantity
                var productWarehouse = await _productWarehouseRepository.GetByProductAndWarehouseIdAsync(
                    transactionDto.ProductId, transactionDto.SourceWarehouseId.Value);

                if (productWarehouse == null || productWarehouse.Quantity < transactionDto.Quantity)
                    throw new InvalidOperationException("Not enough stock available in the specified warehouse");

                // Create transaction with RemoveStock type
                var transaction = _mapper.Map<InventoryTransaction>(transactionDto);
                transaction.TransactionType = TransactionType.RemoveStock;

                // Update product-warehouse quantity
                productWarehouse.Quantity -= transactionDto.Quantity;
                await _productWarehouseRepository.UpdateAsync(productWarehouse);

                // Update total product quantity as well
                product.Quantity -= transactionDto.Quantity;
                await _productRepository.UpdateAsync(product);
                if (product.Quantity <= product.LowStockThreshold)
                {
                    logger.LogWarning(
                        "Low stock alert: Product {ProductName} (ID: {ProductId}) is  threshold. Current quantity: {CurrentQuantity}, Threshold: {Threshold}",
                        product.Name,
                        product.Id,
                        product.Quantity,
                        product.LowStockThreshold);
                }

                // Save transaction
                var createdTransaction = await _transactionRepository.AddAsync(transaction);
                return _mapper.Map<InventoryTransactionDto>(createdTransaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RemoveStockAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> TransferStockAsync(int productId, int fromWarehouseId, int toWarehouseId, int quantity, string userId)
        {
            try
            {
                // Check if product exists in source warehouse with enough quantity
                var sourceProductWarehouse = await _productWarehouseRepository.GetByProductAndWarehouseIdAsync(productId, fromWarehouseId);
        
                // Check if product exists in destination warehouse
                var destProductWarehouse = await _productWarehouseRepository.GetByProductAndWarehouseIdAsync(productId, toWarehouseId);
                if (destProductWarehouse == null)
                {
                    // Create new product-warehouse relationship
                    destProductWarehouse = new ProductWarehouse
                    {
                      Id = productId,
                        WarehouseId = toWarehouseId,
                        Quantity = 0
                    };
                    await _productWarehouseRepository.AddAsync(destProductWarehouse);
                }

                // Update quantities
                sourceProductWarehouse.Quantity -= quantity;
                destProductWarehouse.Quantity += quantity;

                // Save changes
                await _productWarehouseRepository.UpdateAsync(sourceProductWarehouse);
                await _productWarehouseRepository.UpdateAsync(destProductWarehouse);

                // Create transactions for both operations
                var removeTransaction = new InventoryTransaction
                {
                    ProductId = productId,
                    UserId = userId,
                    Quantity = quantity,
                    TransactionType = TransactionType.RemoveStock,
                };

                var addTransaction = new InventoryTransaction
                {
                    ProductId = productId,
                    UserId = userId,
                    Quantity = quantity,
                    TransactionType = TransactionType.AddStock,
                };

                await _transactionRepository.AddAsync(removeTransaction);
                await _transactionRepository.AddAsync(addTransaction);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<InventoryTransactionDto> CreateTransactionAsync(InventoryTransactionForCreationDto transactionDto)
        {
            var transaction = _mapper.Map<InventoryTransaction>(transactionDto);
            transaction.CreatedAt = DateTime.UtcNow;
            
            var createdTransaction = await _transactionRepository.CreateTransactionAsync(transaction);
            return _mapper.Map<InventoryTransactionDto>(createdTransaction);
        }

    }
}
