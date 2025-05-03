using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Domain.Enums;
using Inventory.Repository.Interfaces;
using Inventory.Services.DTOs.Notification;
using Inventory.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public NotificationService(
            INotificationRepository notificationRepository,
            IProductRepository productRepository,
            IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NotificationDto>> GetNotificationsByUserIdAsync(string userId)
        {
            try
            {
                var notifications = await _notificationRepository.GetByUserIdAsync(userId);
                return _mapper.Map<IEnumerable<NotificationDto>>(notifications);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving notifications for user {userId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<NotificationDto>> GetUnreadNotificationsByUserIdAsync(string userId)
        {
            try
            {
                var notifications = await _notificationRepository.GetUnreadByUserIdAsync(userId);
                return _mapper.Map<IEnumerable<NotificationDto>>(notifications);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving unread notifications for user {userId}: {ex.Message}");
                throw;
            }
        }

        public async Task<NotificationDto> CreateLowStockNotificationAsync(int productId, string userId)
        {
            try
            {
                var product = await _productRepository.GetByIdAsync(productId);
                if (product == null)
                    throw new ArgumentException($"Product with ID {productId} not found");
                
                var notification = new Notification
                {
                    Title = "تنبيه المخزون المنخفض",
                    Message = $"المنتج {product.Name} وصل إلى مستوى منخفض من المخزون ({product.Quantity} متبقية). الحد الأدنى هو {product.LowStockThreshold}.",
                    IsRead = false,
                    Type = NotificationType.LowStock,
                    UserId = userId,
                    ProductId = productId
                };

                var createdNotification = await _notificationRepository.AddAsync(notification);
                return _mapper.Map<NotificationDto>(createdNotification);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating low stock notification: {ex.Message}");
                throw;
            }
        }

        public async Task CheckLowStockProductsAsync(string adminUserId)
        {
            try
            {
                var lowStockProducts = await _productRepository.GetLowStockProductsAsync();
                
                foreach (var product in lowStockProducts)
                {
                    await CreateLowStockNotificationAsync(product.Id, adminUserId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking low stock products: {ex.Message}");
                throw;
            }
        }

    }
}
