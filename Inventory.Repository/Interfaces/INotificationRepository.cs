using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface INotificationRepository : IBaseRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetByUserIdAsync(string userId);
        Task<IEnumerable<Notification>> GetUnreadByUserIdAsync(string userId);
        Task<IEnumerable<Notification>> GetByTypeAsync(NotificationType type);
        Task<IEnumerable<Notification>> GetByProductIdAsync(int? productId);
        Task MarkAsReadAsync(int notificationId);
        Task MarkAllAsReadForUserAsync(string userId);
    }
}
