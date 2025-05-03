using Inventory.Domain.Configuration;
using Inventory.Domain.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Inventory.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace Inventory.Domain
{
    public class InventoryDbContext : IdentityDbContext<ApplicationUser>
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductWarehouse> ProductWarehouses { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductWarehouse>()
                .HasKey(pw => pw.Id);  

           
            modelBuilder.Entity<ProductWarehouse>()
                .HasOne(pw => pw.Product)
                .WithMany(p => p.ProductWarehouses)
                .HasForeignKey(pw => pw.ProductId);

            modelBuilder.Entity<ProductWarehouse>()
                .HasOne(pw => pw.Warehouse)
                .WithMany(w => w.ProductWarehouses)
                .HasForeignKey(pw => pw.WarehouseId);

            modelBuilder.Entity<InventoryTransaction>()
                .HasOne(it => it.Report)
                .WithMany()
                .HasForeignKey(it => it.ReportId)
                .IsRequired(false); 

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", CreatedAt = DateTime.UtcNow.AddDays(-30) },
                new Category { Id = 2, Name = "Home Appliances", CreatedAt = DateTime.UtcNow.AddDays(-29) },
                new Category { Id = 3, Name = "Clothing", CreatedAt = DateTime.UtcNow.AddDays(-28) },
                new Category { Id = 4, Name = "Food & Beverages", CreatedAt = DateTime.UtcNow.AddDays(-27) },
                new Category { Id = 5, Name = "Office Supplies", CreatedAt = DateTime.UtcNow.AddDays(-26) }
            );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { Id = 1, Name = "Main Warehouse", Location = "New York", CreatedAt = DateTime.UtcNow.AddDays(-60) },
                new Warehouse { Id = 2, Name = "West Coast Hub", Location = "Los Angeles", CreatedAt = DateTime.UtcNow.AddDays(-50) },
                new Warehouse { Id = 3, Name = "Midwest Center", Location = "Chicago", CreatedAt = DateTime.UtcNow.AddDays(-40) }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High-performance laptop with 16GB RAM",
                    Price = 1200,
                    Quantity = 15,
                    LowStockThreshold = 5,
                    CategoryId = 1, // Electronics
                    CreatedAt = DateTime.UtcNow.AddDays(-15)
                },
                new Product
                {
                    Id = 2,
                    Name = "Vacuum Cleaner",
                    Description = "2000W powerful vacuum cleaner",
                    Price = 180,
                    Quantity = 3, // Low stock
                    LowStockThreshold = 5,
                    CategoryId = 2, 
                    CreatedAt = DateTime.UtcNow.AddDays(-10)
                },
                new Product
                {
                    Id = 3,
                    Name = "Smartphone",
                    Description = "Latest model with 5G capability",
                    Price = 899,
                    Quantity = 25,
                    LowStockThreshold = 8,
                    CategoryId = 1,
                    CreatedAt = DateTime.UtcNow.AddDays(-20)
                },
                new Product
                {
                    Id = 4,
                    Name = "Office Chair",
                    Description = "Ergonomic design for comfort",
                    Price = 250,
                    Quantity = 12,
                    LowStockThreshold = 4,
                    CategoryId = 5, // Office Supplies
                    CreatedAt = DateTime.UtcNow.AddDays(-25)
                },
                new Product
                {
                    Id = 5,
                    Name = "Cooking Oil",
                    Description = "1 liter vegetable cooking oil",
                    Price = 7.99M,
                    Quantity = 7, // Low stock
                    LowStockThreshold = 10,
                    CategoryId = 4, // Food & Beverages
                    CreatedAt = DateTime.UtcNow.AddDays(-5)
                },
                new Product
                {
                    Id = 6,
                    Name = "Dress Shirt",
                    Description = "Men's formal shirt, 100% cotton",
                    Price = 45.50M,
                    Quantity = 30,
                    LowStockThreshold = 10,
                    CategoryId = 3, // Clothing
                    CreatedAt = DateTime.UtcNow.AddDays(-18)
                },
                new Product
                {
                    Id = 7,
                    Name = "Headphones",
                    Description = "Noise-cancelling wireless headphones",
                    Price = 199.99M,
                    Quantity = 18,
                    LowStockThreshold = 5,
                    CategoryId = 1, // Electronics
                    CreatedAt = DateTime.UtcNow.AddDays(-22)
                },
                new Product
                {
                    Id = 8,
                    Name = "Coffee Maker",
                    Description = "Automatic drip coffee maker with timer",
                    Price = 89.95M,
                    Quantity = 9,
                    LowStockThreshold = 4,
                    CategoryId = 2, // Home Appliances
                    CreatedAt = DateTime.UtcNow.AddDays(-12)
                }
            );

            // Product Warehouses
            modelBuilder.Entity<ProductWarehouse>().HasData(
                // Main Warehouse products
                new ProductWarehouse { Id = 1, ProductId = 1, WarehouseId = 1, Quantity = 10, CreatedAt = DateTime.UtcNow.AddDays(-14) },
                new ProductWarehouse { Id = 2, ProductId = 2, WarehouseId = 1, Quantity = 2, CreatedAt = DateTime.UtcNow.AddDays(-9) },
                new ProductWarehouse { Id = 3, ProductId = 3, WarehouseId = 1, Quantity = 15, CreatedAt = DateTime.UtcNow.AddDays(-19) },
                new ProductWarehouse { Id = 4, ProductId = 4, WarehouseId = 1, Quantity = 8, CreatedAt = DateTime.UtcNow.AddDays(-24) },
                new ProductWarehouse { Id = 5, ProductId = 5, WarehouseId = 1, Quantity = 5, CreatedAt = DateTime.UtcNow.AddDays(-4) },
                new ProductWarehouse { Id = 6, ProductId = 6, WarehouseId = 1, Quantity = 20, CreatedAt = DateTime.UtcNow.AddDays(-17) },
                new ProductWarehouse { Id = 7, ProductId = 7, WarehouseId = 1, Quantity = 12, CreatedAt = DateTime.UtcNow.AddDays(-21) },
                new ProductWarehouse { Id = 8, ProductId = 8, WarehouseId = 1, Quantity = 6, CreatedAt = DateTime.UtcNow.AddDays(-11) },
                
                // West Coast Hub products
                new ProductWarehouse { Id = 9, ProductId = 1, WarehouseId = 2, Quantity = 5, CreatedAt = DateTime.UtcNow.AddDays(-14) },
                new ProductWarehouse { Id = 10, ProductId = 3, WarehouseId = 2, Quantity = 10, CreatedAt = DateTime.UtcNow.AddDays(-19) },
                new ProductWarehouse { Id = 11, ProductId = 6, WarehouseId = 2, Quantity = 10, CreatedAt = DateTime.UtcNow.AddDays(-17) },
                new ProductWarehouse { Id = 12, ProductId = 7, WarehouseId = 2, Quantity = 6, CreatedAt = DateTime.UtcNow.AddDays(-21) },
                
                // Midwest Center products
                new ProductWarehouse { Id = 13, ProductId = 2, WarehouseId = 3, Quantity = 1, CreatedAt = DateTime.UtcNow.AddDays(-9) },
                new ProductWarehouse { Id = 14, ProductId = 4, WarehouseId = 3, Quantity = 4, CreatedAt = DateTime.UtcNow.AddDays(-24) },
                new ProductWarehouse { Id = 15, ProductId = 5, WarehouseId = 3, Quantity = 2, CreatedAt = DateTime.UtcNow.AddDays(-4) },
                new ProductWarehouse { Id = 16, ProductId = 8, WarehouseId = 3, Quantity = 3, CreatedAt = DateTime.UtcNow.AddDays(-11) }
            );

            // Create roles - only Admin and User as requested
            var adminRoleId = "1";
            var userRoleId = "2";
            
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                { 
                    Id = adminRoleId, 
                    Name = "Admin", 
                    NormalizedName = "ADMIN", 
                    ConcurrencyStamp = Guid.NewGuid().ToString() 
                },
                new IdentityRole 
                { 
                    Id = userRoleId, 
                    Name = "User", 
                    NormalizedName = "USER", 
                    ConcurrencyStamp = Guid.NewGuid().ToString() 
                }
            );

            var adminUserId = "1";
            var secondAdminUserId = "2"; // Changed from manager to second admin
            var userId = "3";

            // Create admin user
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@inventory.com",
                NormalizedEmail = "ADMIN@INVENTORY.COM",
                EmailConfirmed = true,
                PhoneNumber = "+1-555-123-4567",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var secondAdminUser = new ApplicationUser
            {
                Id = secondAdminUserId,
                UserName = "admin2",
                NormalizedUserName = "ADMIN2",
                Email = "admin2@inventory.com",
                NormalizedEmail = "ADMIN2@INVENTORY.COM",
                EmailConfirmed = true,
                PhoneNumber = "+1-555-234-5678",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var normalUser = new ApplicationUser
            {
                Id = userId,
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@inventory.com",
                NormalizedEmail = "USER@INVENTORY.COM",
                EmailConfirmed = true,
                PhoneNumber = "+1-555-345-6789",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin@123");
            secondAdminUser.PasswordHash = passwordHasher.HashPassword(secondAdminUser, "Admin@123");
            normalUser.PasswordHash = passwordHasher.HashPassword(normalUser, "User@123");

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser, secondAdminUser, normalUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = adminRoleId },
                new IdentityUserRole<string> { UserId = secondAdminUserId, RoleId = adminRoleId }, 
                new IdentityUserRole<string> { UserId = userId, RoleId = userRoleId }
            );

            // Add some notifications
            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    Id = 1,
                    Title = "Low Stock Alert",
                    Message = "Product Vacuum Cleaner has reached a low stock level (3 remaining). Minimum threshold is 5.",
                    IsRead = false,
                    Type = NotificationType.LowStock,
                    UserId = adminUserId,
                    ProductId = 2,
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new Notification
                {
                    Id = 2,
                    Title = "Low Stock Alert",
                    Message = "Product Vacuum Cleaner has reached a low stock level (3 remaining). Minimum threshold is 5.",
                    IsRead = false,
                    Type = NotificationType.LowStock,
                    UserId = secondAdminUserId, 
                    ProductId = 2,
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new Notification
                {
                    Id = 3,
                    Title = "Low Stock Alert",
                    Message = "Product Cooking Oil has reached a low stock level (7 remaining). Minimum threshold is 10.",
                    IsRead = false,
                    Type = NotificationType.LowStock,
                    UserId = adminUserId,
                    ProductId = 5,
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new Notification
                {
                    Id = 4,
                    Title = "Low Stock Alert",
                    Message = "Product Cooking Oil has reached a low stock level (7 remaining). Minimum threshold is 10.",
                    IsRead = true,
                    Type = NotificationType.LowStock,
                    UserId = secondAdminUserId, 
                    ProductId = 5,
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new Notification
                {
                    Id = 5,
                    Title = "Product Information",
                    Message = "Price of product Laptop has changed to $1200.",
                    IsRead = false,
                    Type = NotificationType.Info,
                    UserId = userId,
                    ProductId = 1,
                    CreatedAt = DateTime.UtcNow.AddDays(-5)
                }
            );

            modelBuilder.Entity<InventoryTransaction>().HasData(
                new InventoryTransaction
                {
                    Id = 1,
                    ProductId = 1,
                    UserId = adminUserId,
                    TransactionType = TransactionType.AddStock,
                    Quantity = 10,
                    SourceWarehouseId = 1,
                    ReportId = null, // تحديد أن ReportId هو null
                    CreatedAt = DateTime.UtcNow.AddDays(-30)
                },
                new InventoryTransaction
                {
                    Id = 2,
                    ProductId = 2,
                    UserId = secondAdminUserId, // Updated from managerUserId to secondAdminUserId
                    TransactionType = TransactionType.AddStock,
                    Quantity = 5,
                    SourceWarehouseId = 1,
                    ReportId = null, // تحديد أن ReportId هو null
                    CreatedAt = DateTime.UtcNow.AddDays(-25)
                },
                new InventoryTransaction
                {
                    Id = 3,
                    ProductId = 2,
                    UserId = userId,
                    TransactionType = TransactionType.RemoveStock,
                    Quantity = 2,
                    SourceWarehouseId = 1,
                    ReportId = null, // تحديد أن ReportId هو null
                    CreatedAt = DateTime.UtcNow.AddDays(-15)
                },
                new InventoryTransaction
                {
                    Id = 4,
                    ProductId = 1,
                    UserId = adminUserId,
                    TransactionType = TransactionType.TransferStock,
                    Quantity = 5,
                    SourceWarehouseId = 1,
                    DestinationWarehouseId = 2,
                    ReportId = null, // تحديد أن ReportId هو null
                    CreatedAt = DateTime.UtcNow.AddDays(-14)
                },
                new InventoryTransaction
                {
                    Id = 5,
                    ProductId = 3,
                    UserId = secondAdminUserId, // Updated from managerUserId to secondAdminUserId
                    TransactionType = TransactionType.AddStock,
                    Quantity = 25,
                    SourceWarehouseId = 1,
                    ReportId = null, // تحديد أن ReportId هو null
                    CreatedAt = DateTime.UtcNow.AddDays(-20)
                }
            );

            // Add some reports
            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    Id = 1,
                    Title = "Low Stock Products Report",
                    Description = "Report showing products that have reached low stock levels",
                    Type = ReportType.LowStock,
                    GeneratedAt = DateTime.UtcNow.AddDays(-5),
                    GeneratedByUserId = adminUserId,
                    DataJson = "[]",
                    CreatedAt = DateTime.UtcNow.AddDays(-5)
                },
                new Report
                {
                    Id = 2,
                    Title = $"Transaction History ({DateTime.UtcNow.AddDays(-30):yyyy-MM-dd} - {DateTime.UtcNow:yyyy-MM-dd})",
                    Description = $"Report showing inventory transactions from the past 30 days",
                    Type = ReportType.TransactionHistory,
                    StartDate = DateTime.UtcNow.AddDays(-30),
                    EndDate = DateTime.UtcNow,
                    GeneratedAt = DateTime.UtcNow.AddDays(-1),
                    GeneratedByUserId = adminUserId,
                    DataJson = "[]",
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new Report
                {
                    Id = 3,
                    Title = $"Inventory Summary {DateTime.UtcNow:yyyy-MM-dd}",
                    Description = "Report showing current inventory status",
                    Type = ReportType.InventorySummary,
                    GeneratedAt = DateTime.UtcNow,
                    GeneratedByUserId = secondAdminUserId, // Updated from managerUserId to secondAdminUserId
                    DataJson = "[]",
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}