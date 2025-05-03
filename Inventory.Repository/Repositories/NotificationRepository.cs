using Inventory.Domain;
using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(InventoryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Notification>> GetByUserIdAsync(string userId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(n => n.Product)
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetUnreadByUserIdAsync(string userId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(n => n.Product)
                .Where(n => n.UserId == userId && !n.IsRead)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetByTypeAsync(NotificationType type)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(n => n.Product)
                .Include(n => n.User)
                .Where(n => n.Type == type)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetByProductIdAsync(int? productId)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(n => n.User)
                .Where(n => n.ProductId == productId)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        public async Task MarkAsReadAsync(int notificationId)
        {
            var notification = await _dbSet.FindAsync(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                notification.UpdatedAt = System.DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task MarkAllAsReadForUserAsync(string userId)
        {
            var notifications = await _dbSet
                .Where(n => n.UserId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
                notification.UpdatedAt = System.DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();
        }
    }
}
