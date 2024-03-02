using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services;

public class SanPhamService : ISanPhamService
{
    private readonly IRepository<SanPham> repository;

    public SanPhamService(IRepository<SanPham> repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<SanPham>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<SanPham> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(SanPham sanPham)
    {
        await repository.Create(sanPham);
    }

    public async Task Update(SanPham sanPham)
    {
        await repository.Update(sanPham);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}