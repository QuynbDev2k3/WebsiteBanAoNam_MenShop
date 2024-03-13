using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.IServices;

public interface INhanVienService
{
    Task<IEnumerable<NhanVien>> GetAll();
    Task<NhanVien> GetById(Guid id);
    Task Create(Guid idrole, string ma, string ten, string sdt, string email, string diachi, string matkhau, bool trangthai);
    Task Update(Guid id, Guid idrole, string ma, string ten, string sdt, string email, string diachi, string matkhau, bool trangthai);
    Task Delete(Guid id);
}