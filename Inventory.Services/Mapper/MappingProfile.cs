using AutoMapper;
using Inventory.Domain.Entites;
using Inventory.Services.DTOs.Category;
using Inventory.Services.DTOs.InventoryTransaction;
using Inventory.Services.DTOs.Notification;
using Inventory.Services.DTOs.Product;
using Inventory.Services.DTOs.ProductWarehouse;
using Inventory.Services.DTOs.Report;
using Inventory.Services.DTOs.User;
using Inventory.Services.DTOs.Warehouse;

namespace Inventory.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Category mappings
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryForCreationDto, Category>();
            CreateMap<CategoryForUpdateDto, Category>();

            // Product mappings
            CreateMap<Product, ProductDto>()
                 .ForMember(dest => dest.CategoryName, opt =>
                     opt.MapFrom(src => src.Category != null ? src.Category.Name : null));
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForUpdateDto, Product>();

            // Warehouse mappings
            CreateMap<Warehouse, WarehouseDto>().ReverseMap();
            CreateMap<WarehouseForCreationDto, Warehouse>();
            CreateMap<WarehouseForUpdateDto, Warehouse>();

            // ProductWarehouse mappings
            CreateMap<ProductWarehouse, ProductWarehouseDto>().ReverseMap();
            CreateMap<ProductWarehouseForCreationDto, ProductWarehouse>();
            CreateMap<ProductWarehouseForUpdateDto, ProductWarehouse>();

            // InventoryTransaction mappings
            CreateMap<InventoryTransaction, InventoryTransactionDto>().ReverseMap();
            CreateMap<InventoryTransactionForCreationDto, InventoryTransaction>();

            // Notification mappings
            CreateMap<Notification, NotificationDto>().ReverseMap();

            // Report mappings
            CreateMap<Report, ReportDto>().ReverseMap();
            CreateMap<ReportForCreationDto, Report>();

            // User mappings
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}
