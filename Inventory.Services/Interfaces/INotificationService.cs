using Inventory.Services.DTOs.Notification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface INotificationService
    {
        Task<IEnumerable<NotificationDto>> GetNotificationsByUserIdAsync(string userId);
        
        Task CheckLowStockProductsAsync(string adminUserId);
        
        Task<IEnumerable<NotificationDto>> GetUnreadNotificationsByUserIdAsync(string userId);


    }
}
