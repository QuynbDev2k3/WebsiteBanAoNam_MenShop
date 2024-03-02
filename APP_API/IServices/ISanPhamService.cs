using APP_DATA.Models;

namespace APP_API.IServices;

public interface ISanPhamService
{
    Task<IEnumerable<SanPham>> GetAll();
    Task<SanPham> GetById(Guid id);
    Task Create(SanPham sanPham);
    Task Update(SanPham sanPham);
    Task Delete(Guid id);
}