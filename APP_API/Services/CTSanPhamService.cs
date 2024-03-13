using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class CTSanPhamService : ICTSanPhamService
{
    private readonly IRepository<CTSanPham> repository;
    private readonly MyDbContext _context;

    public CTSanPhamService(IRepository<CTSanPham> repository, MyDbContext context)
    {
        this.repository = repository;
        this._context = context;
    }

    public async Task<IEnumerable<CTSanPham>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<CTSanPham> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idanh, Guid idgiamgia, Guid idhang, Guid iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai)
    {
        ngaytao = DateTime.Now;
        CTSanPham ctSanPham = new CTSanPham()
        {
            ID = Guid.NewGuid(),
            IDSanPham = idsanpham,
            IDVoucher = idvoucher,
            IDMauSac = idmausac,
            IDKichCo = idkichco,
            IDChatLieu = idchatlieu,
            IDAnh = idanh,
            IDGiamGia = idgiamgia,
            IDHang = idhang,
            IDDanhGia = iddanhgia,
            Ma = ma,
            GiaBan = giaban,
            SoLuong = soluong,
            Age = age,
            NgayTao = ngaytao,
            MoTa = mota,
            TrangThai = trangthai,
        };
        await repository.Create(ctSanPham);
    }

    public async Task Update(Guid id,Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idanh, Guid idgiamgia, Guid idhang, Guid iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai)
    {
        var ctSanPham = await _context.CtSanPhams.SingleOrDefaultAsync(p => p.ID == id);
        if (ctSanPham != null)
        {
            ctSanPham.IDSanPham = idsanpham;
            ctSanPham.IDVoucher = idvoucher;
            ctSanPham.IDMauSac = idmausac;
            ctSanPham.IDKichCo = idkichco;
            ctSanPham.IDChatLieu = idchatlieu;
            ctSanPham.IDAnh = idanh;
            ctSanPham.IDGiamGia = idgiamgia;
            ctSanPham.IDHang = idhang;
            ctSanPham.IDDanhGia = iddanhgia;
            ctSanPham.Ma = ma;
            ctSanPham.GiaBan = giaban;
            ctSanPham.SoLuong = soluong;
            ctSanPham.Age = age;
            ctSanPham.NgayTao = DateTime.Now;
            ctSanPham.MoTa = mota;
            ctSanPham.TrangThai = trangthai;
        }
        await repository.Update(ctSanPham);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}