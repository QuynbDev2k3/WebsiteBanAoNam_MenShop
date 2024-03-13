using APP_DATA.Models;

namespace APP_API.IServices;

public interface ISanPhamService
{
    Task<IEnumerable<SanPham>> GetAll();
    Task<SanPham> GetById(Guid id);
    Task Create(Guid iddanhmucsanpham, string ma, string ten, float gia, bool trangthai);
    Task Update(Guid id, Guid iddanhmucsanpham, string ma, string ten, float gia, bool trangthai);
    Task Delete(Guid id);
}