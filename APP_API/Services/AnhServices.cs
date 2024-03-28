using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class AnhServices : IAnhServices
{
    private readonly IRepository<Anh> repository;
    private readonly MyDbContext _context;

    public AnhServices(IRepository<Anh> repository, MyDbContext context)
    {
        this.repository = repository;
        this._context = context;
    }

    public async Task<IEnumerable<Anh>> GetAll()
    {
        return await repository.GetAll();
    }

    public async Task<Anh> GetById(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task Create(string linkanh, bool trangthai)
    {
        Anh anh = new Anh()
        {
            Id = Guid.NewGuid(),
            LinkAnh = linkanh,
            TrangThai = trangthai,
        };
        await repository.Create(anh);
    }

    public async Task Update(Guid id, string linkanh, bool trangthai)
    {
        var anh = await _context.anhs.SingleOrDefaultAsync(p => p.Id == id);
        if (anh != null)
        {

            anh.LinkAnh = linkanh;
            anh.TrangThai = trangthai;
        }
        await repository.Update(anh);
    }

    public async Task Delete(Guid id)
    {
        await repository.Delete(id);
    }

 
}