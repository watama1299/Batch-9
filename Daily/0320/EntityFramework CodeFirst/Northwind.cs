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
        optionsBuilder.UseSqlite("Data Source=Northwind.db");
    }
}
