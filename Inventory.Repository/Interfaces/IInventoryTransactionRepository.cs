using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IInventoryTransactionRepository : IBaseRepository<InventoryTransaction>
    {
        Task<InventoryTransaction> CreateTransactionAsync(InventoryTransaction transaction);
        Task<IEnumerable<InventoryTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<InventoryTransaction>> GetTransactionsByProductIdAsync(int productId);
    }
}
