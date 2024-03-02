using APP_DATA.Models;

namespace APP_API.IServices;

public interface ICTSanPhamService
{
    Task<IEnumerable<CTSanPham>> GetAll();
    Task<CTSanPham> GetById(Guid id);
    Task Create(CTSanPham ctSanPham);
    Task Update(CTSanPham ctSanPham);
    Task Delete(Guid id);
}