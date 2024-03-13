using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class NhanVienService : INhanVienService
{
    private readonly IRepository<NhanVien> repository;
    private readonly MyDbContext _context;

    public NhanVienService(IRepository<NhanVien> repository, MyDbContext context)
    {
        this.repository = repository;
        this._context = context;
    }

    public async Task<IEnumerable<NhanVien>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<NhanVien> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(Guid idrole, string ma, string ten, string sdt, string email, string diachi,
        string matkhau, bool trangthai)
    {
        NhanVien nhanVien = new NhanVien()
        {
            ID = Guid.NewGuid(),
            IDRole = idrole,
            Ma = ma,
            Ten = ten,
            SDT = sdt,
            Email = email,
            DiaChi = diachi,
            MatKhau = matkhau,
            TrangThai = trangthai,
        };
        await repository.Create(nhanVien);
    }

    public async Task Update(Guid id, Guid idrole, string ma, string ten, string sdt, string email, string diachi, string matkhau, bool trangthai)
    {
        var nhanVien = await _context.NhanViens.SingleOrDefaultAsync(p => p.ID == id);
        if (nhanVien != null)
        {
            nhanVien.IDRole = idrole;
            nhanVien.Ma = ma;
            nhanVien.Ten = ten;
            nhanVien.SDT = sdt;
            nhanVien.Email = email;
            nhanVien.DiaChi = diachi;
            nhanVien.MatKhau = matkhau;
            nhanVien.TrangThai = trangthai;
        }
        await repository.Update(nhanVien);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }
}