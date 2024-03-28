using MVC_Tutorial.Models;

namespace Web_API;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category category);
}
