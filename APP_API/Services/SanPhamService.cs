using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class SanPhamService : ISanPhamService
{
    private readonly IRepository<SanPham> repository;
    private readonly MyDbContext _context;

    public SanPhamService(IRepository<SanPham> repository, MyDbContext context)
    {
        this.repository = repository;
        this._context = context;
    }

    public async Task<IEnumerable<SanPham>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<SanPham> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(Guid iddanhmucsanpham, string ma, string ten, float gia, bool trangthai)
    {
        SanPham sanPham = new SanPham()
        {
            ID = Guid.NewGuid(),
            IDDanhMucSanPham = iddanhmucsanpham,
            Ma = ma,
            Ten = ten,
            Gia = gia,
            TrangThai = trangthai,
        };
        await repository.Create(sanPham);
    }

    public async Task Update(Guid id, Guid iddanhmucsanpham, string ma, string ten, float gia, bool trangthai)
    {
        var sanPham = await _context.SanPhams.SingleOrDefaultAsync(p => p.ID == id);
        if (sanPham != null)
        {
            sanPham.IDDanhMucSanPham = id;
            sanPham.Ma = ma;
            sanPham.Ten = ten;
            sanPham.Gia = gia;
            sanPham.TrangThai = trangthai;
        }
        await repository.Update(sanPham);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}