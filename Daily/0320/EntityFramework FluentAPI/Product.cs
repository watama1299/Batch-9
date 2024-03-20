using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public short Stock { get; set; }
    

    /**
        CATEGORY TO PRODUCT RELATIONSHIP
        MANY PRODUCTS -> 1 CATEGORY
    */
    public Category Category { get; set; }
}
