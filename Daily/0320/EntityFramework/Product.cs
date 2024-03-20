namespace EntityFramework;

public class Product
{
    /**
        COLUMN LABELS IN THE DB TABLE
    */
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; } 
    

    /**
        CATEGORY TO PRODUCT RELATIONSHIP
        MANY PRODUCTS -> 1 CATEGORY
    */
    public Category Category { get; set; }
}
