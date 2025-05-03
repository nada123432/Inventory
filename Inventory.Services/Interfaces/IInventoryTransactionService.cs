using Inventory.Domain.Enums;
using Inventory.Services.DTOs.InventoryTransaction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IInventoryTransactionService
    {
        Task<IEnumerable<InventoryTransactionDto>> GetAllTransactionsAsync();
        Task<IEnumerable<InventoryTransactionDto>> GetTransactionsByProductIdAsync(int productId);
        Task<IEnumerable<InventoryTransactionDto>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<InventoryTransactionDto> AddStockAsync(InventoryTransactionForCreationDto transactionDto);
        Task<InventoryTransactionDto> RemoveStockAsync(InventoryTransactionForCreationDto transactionDto);
        Task<bool> TransferStockAsync(int productId, int fromWarehouseId, int toWarehouseId, int quantity, string userId);
        Task<InventoryTransactionDto> CreateTransactionAsync(InventoryTransactionForCreationDto transaction);
    }
}
