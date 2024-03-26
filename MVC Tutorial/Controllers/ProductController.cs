using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Tutorial.Data;

namespace MVC_Tutorial;

public class ProductController : Controller
{
    private readonly DataContext _dataContext;
    public ProductController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    // Will look for the Index.cshtml in Views/Product
    public IActionResult Index()
    {
        var products = _dataContext.Products.Include(p => p.Category);
        return View(products);
    }
}
