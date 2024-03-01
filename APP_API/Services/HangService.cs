using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using APP_DATA.Repositories;

namespace APP_API.Services;

public class HangService : IHangService
{
    private readonly IRepository<Hang> repository;

    public HangService(IRepository<Hang> repository)
    {
        this.repository = repository;
    }
    
    public async Task<IEnumerable<Hang>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<Hang> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(Hang hang)
    {
        await repository.Create(hang);
    }

    public async Task Update(Hang hang)
    {
        await repository.Update(hang);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}