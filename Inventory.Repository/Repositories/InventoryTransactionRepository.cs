using Inventory.Domain;
using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class InventoryTransactionRepository : BaseRepository<InventoryTransaction>, IInventoryTransactionRepository
    {
        public InventoryTransactionRepository(InventoryDbContext context) : base(context)
        {
        }

        public async Task<InventoryTransaction> CreateTransactionAsync(InventoryTransaction transaction)
        {
            await _dbSet.AddAsync(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<IEnumerable<InventoryTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _dbSet
                .AsNoTracking()
                .Where(t => t.CreatedAt >= startDate && t.CreatedAt <= endDate)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<InventoryTransaction>> GetTransactionsByProductIdAsync(int productId)
        {
            return await _dbSet
                .AsNoTracking()
                .Where(t => t.ProductId == productId) 
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();
        }
    }
}
