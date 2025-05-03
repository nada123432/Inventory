using Microsoft.Extensions.DependencyInjection;
using Inventory.Repository.Interfaces;
using Inventory.Repository.Repositories;
using Inventory.Services.Interfaces;
using Inventory.Services.Services;
using Inventory.Services.Mapper;
using System.Reflection;

namespace Inventory.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection  addAllServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IProductWarehouseRepository, ProductWarehouseRepository>();
            services.AddScoped<IInventoryTransactionRepository, InventoryTransactionRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();

            // Register Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IWarehouseService, WarehouseService>();
            services.AddScoped<IProductWarehouseService, ProductWarehouseService>();
            services.AddScoped<IInventoryTransactionService, InventoryTransactionService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
