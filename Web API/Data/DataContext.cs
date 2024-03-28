using Microsoft.EntityFrameworkCore;
using MVC_Tutorial.Models;

namespace Web_API;

public class DataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Building tables
        modelBuilder.Entity<Category>(c => {
            c.HasKey(c => c.CategoryId);
            c.Property(c => c.CategoryName).IsRequired().HasMaxLength(40);
            c.Property(c => c.Description).IsRequired(false);
            c.HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
        });

        modelBuilder.Entity<Product>(p => {
            p.HasKey(p => p.ProductId);
            p.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
            p.Property(p => p.Description).IsRequired(false);
            p.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        });


        // Seeding data
        modelBuilder.Entity<Category>().HasData(
			new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Electronic Items" },
			new Category { CategoryId = 2, CategoryName = "Clothes", Description = "Dress Items" },
			new Category { CategoryId = 3, CategoryName = "Groceries", Description = "Grocery Items" }
		);
		modelBuilder.Entity<Product>().HasData(
			new Product { ProductId = 1, ProductName = "Laptop", Description = "Laptop", CategoryId = 1 },
			new Product { ProductId = 2, ProductName = "Mobile", Description = "Mobile", CategoryId = 1 },
			new Product { ProductId = 3, ProductName = "Shirt", Description = "Shirt", CategoryId = 2 },
			new Product { ProductId = 4, ProductName = "Jeans", Description = "Jeans", CategoryId = 2 },
			new Product { ProductId = 5, ProductName = "Rice", Description = "Rice", CategoryId = 3 },
			new Product { ProductId = 6, ProductName = "Wheat", Description = "Wheat", CategoryId = 3 }
		);
    }



}
