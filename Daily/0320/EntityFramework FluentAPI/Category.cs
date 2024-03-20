using EntityFramework;

public class Category
{   
    /**
        COLUMN LABELS IN THE DB TABLE
    */
    public int CategoryId {get; set;} // Default Primary Key => ClassNameId
    public string CategoryName {get; set;}
    public string Description { get; set; }


    /**
        CATEGORY TO PRODUCT RELATIONSHIP
        1 CATEGORY -> MANY PRODUCTS
    */
    public ICollection<Product> Products { get; set; }

    public Category() {
        Products = new HashSet<Product>();
    }
}