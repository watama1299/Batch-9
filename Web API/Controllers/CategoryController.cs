using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Tutorial.Models;

namespace Web_API;

/**
    USE A PARENT CLASS TO ROUTE ALL CHILD CLASS TO A CERTAIN ROUTING
    INSTEAD OF CHANGING THE ROUTING ONE BY ONE IN EACH CLASS
*/
public class CategoryController : APIBaseController
{
    // private readonly DataContext _db;
    private readonly ICategoryRepository _repo;



    private readonly IMapper _map;
    // public CategoryController(DataContext dataContext, IMapper mapper)
    // {
    //     _db = dataContext;
    //     _map = mapper;
    // }
    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _repo = categoryRepository;
        _map = mapper;
    }

    [HttpGet]
    public IActionResult GetAllCategories()
    {
        // Mapping Category to CategoryDTO
        // var categories = _db.Categories.Include(c => c.Products).ToList();
        var categories = _repo.GetAll().Include(c => c.Products);
        var categoriesDTO = new List<CategoryDTO>();
        foreach (var c in categories)
        {
            categoriesDTO.Add(new CategoryDTO
            {
                // CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Description = c.Description
            });
        }
        // return Ok(categoriesDTO);
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneCategory(int id)
    {
        // var category = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
        var category = _repo.Get(c => c.CategoryId == id).FirstOrDefault();
        if (category is null)
        {
            return NotFound($"Category with id {id} not found!");
        }

        // Mapping using AutoMapper
        var catDTO = _map.Map<CategoryDTO>(category);
        return Ok(catDTO);
    }

    [HttpPost]
    public IActionResult AddCategory([FromBody]CategoryDTO? categoryDTO)
    {
        if (categoryDTO is null)
        {
            return NotFound("Category is null!");
        }

        var category = _map.Map<Category>(categoryDTO);
        // _db.Categories.Add(category);
        // _db.SaveChanges();
        _repo.Add(category);
        _repo.Save();
        return Ok(category);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory([FromRoute]int id, [FromBody]CategoryDTO? categoryDTO)
    {
        if (categoryDTO is null)
        {
            return NotFound("Category is null!");
        }

        // var existingCategory = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
        var existingCategory = _repo.Get(c => c.CategoryId == id).FirstOrDefault();
        if (existingCategory is null)
        {
            return NotFound($"Category with id {id} not found!");
        }

        if(categoryDTO.CategoryName != null)
		{
			existingCategory.CategoryName = categoryDTO.CategoryName;
		}

		if(categoryDTO.Description != null)
		{
			existingCategory.Description = categoryDTO.Description;
		}

		// _db.SaveChanges();
        _repo.Save();
		return Ok(existingCategory);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        // var category = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
        var category = _repo.Get(c => c.CategoryId == id).FirstOrDefault();
        if (category is null)
        {
            return NotFound($"Category with id {id} not found!");
        }
        // _db.Categories.Remove(category);
		// _db.SaveChanges();
        _repo.Remove(category);
        _repo.Save();
		return Ok();
    }
}
