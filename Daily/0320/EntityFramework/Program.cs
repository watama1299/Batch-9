using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class Program
{
    static void Main(string[] args)
    {
        using (Northwind db = new Northwind()) {
            bool status = db.Database.CanConnect();
            Console.WriteLine($"Can connect: {status}");
            Console.ReadLine();

            // RETRIVE
            var categories = db.Categories.ToList();
            Console.WriteLine("Categories table");
            foreach (var category in categories) {
                Console.WriteLine($"{category.CategoryId} {category.CategoryName} {category.Description}");
            }
            Console.ReadLine();

            var category1 = db.Categories.Find(3);
            var category2 = db.Categories.Where(c => c.CategoryId == 5).FirstOrDefault();
            var category3 = db.Categories.Where(c => c.CategoryName.Contains("Beverages")).FirstOrDefault();



            // Retrieving data from Products table thru Categories table
            string search = "Produce";
            var categoryProduce = db.Categories.Where(c => c.CategoryName == search)
                                               .Include(c => c.Products)
                                               .ToList();
            foreach(var category in categoryProduce) 
			{
				Console.WriteLine($"{category.CategoryId} {category.CategoryName} {category.Description}");
				Console.WriteLine(category.Products.Count());
				foreach(var product in category.Products) 
				{
					Console.WriteLine($"\t{product.ProductName}");
				}
			}
            Console.ReadLine();



            /**
                FOR CREATE, UPDATE AND DELETE
                
                REMEMBER TO ALWAYS SAVE AFTER THE CHANGES

                SaveChanges()
            */
            // CREATE
            var javaCoffee = new Product() {
                // ProductId will be auto generated
                ProductName = "Java coffee",
                CategoryId = 1
            };
            db.Products.Add(javaCoffee);
            db.SaveChanges();
            Console.ReadLine();



            // UPDATE
            var dairy = db.Categories.Where(c => c.CategoryName == "Dairy Products").FirstOrDefault();
            var desc = dairy?.Description;
            desc += ", milk and butter";
            dairy.Description = desc;
            db.SaveChanges();
            Console.ReadLine();



            // DELETE
            if (javaCoffee is not null) {
                db.Products.Remove(javaCoffee);
                db.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
