namespace MVC_Tutorial.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<Product> Products { get; set; } = null!;

    public Category()
    {
        Products = new List<Product>();
    }
}
