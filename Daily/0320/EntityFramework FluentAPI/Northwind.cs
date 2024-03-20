using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class Northwind : DbContext
{   
    /**
        TABLES FROM THE DB WHICH YOU WANT TO CRUD
    */
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }


    
    /**
        CALLING THE DB FILE
    */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=Northwind.db");
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=postgres;Password=postgres");
    }



    /**
        SETTING UP THE TABLE USING FLUENT API
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(c =>
		{
			c.HasKey(c => c.CategoryId);
			c.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(40);
			c.Property(c => c.Description).IsRequired(false);
			c.HasMany(c => c.Products);
		});

		modelBuilder.Entity<Product>(p =>
		{
			p.HasKey(p => p.Id);
			p.Property(p => p.ProductName)
			.IsRequired(true)
			.HasMaxLength(40);
			p.Property(p => p.Stock)
			.HasColumnType("smallint")
			.HasColumnName("UnitsInStock");
			p.HasOne(p => p.Category);
		});



		//Data Seeding
		modelBuilder.Entity<Category>().HasData(
			new Category() 
			{
				CategoryId = 1,
				CategoryName = "Beverages",
				Description = "Soft drinks, coffees, teas, beers, and ales"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "Yanto",
				Description = "Yanto is human being"
			}
		);

		modelBuilder.Entity<Product>().HasData(
			new Product() 
			{
				Id = 1,
				ProductName = "Chai",
				CategoryId = 1,
				Stock = 39
			},
			new Product() 
			{
				Id = 2,
				ProductName = "Chang",
				CategoryId = 1,
				Stock = 17
			},
			new Product() 
			{
				Id = 3,
				ProductName = "Aniseed Syrup",
				CategoryId = 2,
				Stock = 13
			}
		);
    }
}
