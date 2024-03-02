using APP_DATA.Models;

namespace APP_API.IServices;

public interface INhanVienService
{
    Task<IEnumerable<NhanVien>> GetAll();
    Task<NhanVien> GetById(Guid id);
    Task Create(NhanVien nhanVien);
    Task Update(NhanVien nhanVien);
    Task Delete(Guid id);
}