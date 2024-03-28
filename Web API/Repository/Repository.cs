using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Web_API;

public class Repository<T> : IRepository<T> where T : class
{
    private DataContext _db;
    private DbSet<T> _dbSet;

    public Repository(DataContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
    }

    public bool Add(T entity)
    {
        _dbSet.Add(entity);
        return true;
    }

    public bool AddRange(IEnumerable<T> entities)
    {
        _dbSet.AddRange(entities);
        return true;
    }

    public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression);
    }

    public IQueryable<T> GetAll()
    {
        return _dbSet;
    }

    public bool Remove(T entity)
    {
        _dbSet.Remove(entity);
        return true;
    }

    public bool RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
        return true;
    }

    public int Save()
    {
        return _db.SaveChanges();
    }

}
