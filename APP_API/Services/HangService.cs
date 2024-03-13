using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using APP_DATA.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class HangService : IHangService
{
    private readonly IRepository<Hang> repository;
    private readonly MyDbContext _context;

    public HangService(IRepository<Hang> repository, MyDbContext _context)
    {
        this.repository = repository;
        this._context = _context;
    }
    
    public async Task<IEnumerable<Hang>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<Hang> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(string ten, bool trangthai)
    {
        Hang hang = new Hang()
        {
            ID = Guid.NewGuid(),
            Ten = ten,
            TrangThai = trangthai,
        };
        await repository.Create(hang);
    }

    public async Task Update(Guid id, string ten, bool trangthai)
    {
        var hang = await _context.Hangs.SingleOrDefaultAsync(p => p.ID == id);
        if (hang !=null)
        {
            hang.Ten = ten;
            hang.TrangThai = trangthai;
        }
        await repository.Update(hang);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}