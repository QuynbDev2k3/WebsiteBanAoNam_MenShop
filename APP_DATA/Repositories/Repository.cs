using APP_DATA.Context;
using APP_DATA.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace APP_DATA.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly MyDbContext context;
    private DbSet<T> dbSet;
    
    public Repository(MyDbContext context)
    {
        this.context = context;
        this.dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public async Task Create(T entity)
    {
        await dbSet.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        dbSet.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var entity = await dbSet.FindAsync(id);
        dbSet.Remove(entity);
        await context.SaveChangesAsync();
    }
}