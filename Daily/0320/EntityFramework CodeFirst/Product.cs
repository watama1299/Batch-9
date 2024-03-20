using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework;

public class Product
{
    /**
        COLUMN LABELS IN THE DB TABLE
    */
    [Key]
    public int Id { get; set; }

    // Required => NOT NULL
    [Required, MaxLength(40)]
    public string ProductName { get; set; }
    public int CategoryId { get; set; }

    // DB COLUMN NAME => UnitInStock
    [Column("UnitInStock", TypeName = "smallint")]
    public short Stock { get; set; }
    

    /**
        CATEGORY TO PRODUCT RELATIONSHIP
        MANY PRODUCTS -> 1 CATEGORY
    */
    public Category Category { get; set; }
}
