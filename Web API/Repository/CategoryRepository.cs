using MVC_Tutorial.Models;

namespace Web_API;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly DataContext _db;
    public CategoryRepository(DataContext db) : base(db)
    {
        _db = db;
    }


    public void Update(Category category)
    {
        _db.Categories.Update(category);
    }

}
