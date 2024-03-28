using APP_DATA.Models;

namespace APP_API.IServices;

public interface ICTSanPhamService
{
    Task<IEnumerable<CTSanPham>> GetAll();
    Task<CTSanPham> GetById(Guid id);
    Task Create(Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idgiamgia, Guid idhang, Guid? iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai);
    Task Update(Guid id, Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idgiamgia, Guid idhang, Guid iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai);
    Task Delete(Guid id);
}