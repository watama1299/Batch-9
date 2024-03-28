using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Tutorial.Models;

namespace Web_API;

/**
    USE A PARENT CLASS TO ROUTE ALL CHILD CLASS TO A CERTAIN ROUTING
    INSTEAD OF CHANGING THE ROUTING ONE BY ONE IN EACH CLASS
*/
public class ProductController : APIBaseController
{
    private readonly DataContext _db;
    public ProductController(DataContext dataContext)
    {
        _db = dataContext;
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var products = _db.Products.ToList();
        return Ok(products);
    }
}
