using Microsoft.AspNetCore.Mvc;
using MVC_Tutorial.Data;
using MVC_Tutorial.Models;

namespace MVC_Tutorial;

public class CategoryController : Controller
{
    private readonly DataContext _dataContext;
    public CategoryController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    // Will look for the Index.cshtml in Views/Category
    public IActionResult Index()
    {
        var categories = _dataContext.Categories;
        return View(categories);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        _dataContext.Categories.Add(category);
        _dataContext.SaveChanges();
        TempData["success"] = "Category has been added successfully";
        return RedirectToAction("Index");
    }

    public IActionResult Update(int? id)
    {
        if (id is null || id <= 0 ) {
            TempData["error"] = "CategoryId not found!";
            return RedirectToAction("Index");
        }

        var category = _dataContext.Categories.Find(id);
        if (category is null) {
            TempData["error"] = "Category not found!";
            return RedirectToAction("Index");
        }

        return View(category);
    }

    [HttpPost]
    public IActionResult Update(Category category)
    {
        _dataContext.Categories.Update(category);
        _dataContext.SaveChanges();
        TempData["success"] = "Category has been updated successfully";
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
    {
        if (id is null || id <= 0 ) {
            TempData["error"] = "CategoryId not found!";
            return RedirectToAction("Index");
        }

        var category = _dataContext.Categories.Find(id);
        if (category is null) {
            TempData["error"] = "Category not found!";
            return RedirectToAction("Index");
        }

        _dataContext.Categories.Remove(category);
        _dataContext.SaveChanges();
        TempData["success"] = "Category has been deleted successfully";
        return RedirectToAction("Index");
    }
}
