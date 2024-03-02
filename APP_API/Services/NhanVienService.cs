using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services;

public class NhanVienService : INhanVienService
{
    private readonly IRepository<NhanVien> repository;

    public NhanVienService(IRepository<NhanVien> repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<NhanVien>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<NhanVien> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(NhanVien nhanVien)
    {
        await repository.Create(nhanVien);
    }

    public async Task Update(NhanVien nhanVien)
    {
        await repository.Update(nhanVien);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}