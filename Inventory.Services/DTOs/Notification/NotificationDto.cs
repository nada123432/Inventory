using Inventory.Domain.Enums;
using Inventory.Services.DTOs.Base;
using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.User;
using System;

namespace Inventory.Services.DTOs.Notification
{
    public class NotificationDto : BaseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public NotificationType Type { get; set; }
        public string UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
