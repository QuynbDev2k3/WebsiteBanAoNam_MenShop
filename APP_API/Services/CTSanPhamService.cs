using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services;

public class CTSanPhamService : ICTSanPhamService
{
    private readonly IRepository<CTSanPham> repository;

    public CTSanPhamService(IRepository<CTSanPham> repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<CTSanPham>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<CTSanPham> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(CTSanPham ctSanPham)
    {
        await repository.Create(ctSanPham);
    }

    public async Task Update(CTSanPham ctSanPham)
    {
        await repository.Update(ctSanPham);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}