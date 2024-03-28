using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services;

public class AnhServiece : IAnhServiece
{
    private readonly IRepository<Anh> repository;
    private readonly MyDbContext _context;

    public AnhServiece(IRepository<Anh> repository, MyDbContext context)
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

    public async Task Create(Guid id, string linkanh, bool trangthai)
    {
        Anh anh = new Anh   ()
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

    

    public bool Add(Anh p)
    {
        throw new NotImplementedException();
    }

    public bool Edit(Guid id, Anh p)
    {
        throw new NotImplementedException();
    }

    List<Anh> IAnhServiece.GetAll()
    {
        throw new NotImplementedException();
    }

    bool IAnhServiece.Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
//using APP_API.IServices;
//using APP_DATA.Context;
//using APP_DATA.Models;
//using Microsoft.EntityFrameworkCore;

//namespace APP_API.Services
//{
//    public class AnhServiece
//    {
//        private MyDbContext _dbcontext;
//        private DbSet<Anh> _dbset;
//        public AnhServiece()
//        {
//            _dbcontext = new MyDbContext();
//            _dbset = _dbcontext.Set<Anh>();


//        }

//        public void Add(Guid id, Anh p)
//        {

//            try
//            {

//                _dbset.Add(p);
//                _dbcontext.SaveChanges();
//                return;
//            }
//            catch (Exception)
//            {


//            }
//        }

//        public IEnumerable<Anh> GetAll()

//        {
//            return _dbset.ToList();
//        }


//        public void Update(Anh item)
//        {
//            var p = GetAll().FirstOrDefault(p => p.Id == item.Id);

//            try
//            {
//                p.LinkAnh = item.LinkAnh;
//                p.TrangThai = item.TrangThai;


//                _dbset.Update(p);
//                _dbcontext.SaveChanges();
//                return;
//            }
//            catch (Exception)
//            {



//            }
//        }

//        public void Delete(Guid id)
//        {
//            var p = GetAll().FirstOrDefault(p => p.Id == id);
//            try
//            {
//                _dbset.Remove(p);
//                _dbcontext.SaveChanges();
//                return;
//            }
//            catch (Exception)
//            {



//            }
//        }
//    }
//}

////using APP_DATA.Context;
////using APP_DATA.Models;

////using Bill.Serviece.Interfaces;
////using Microsoft.EntityFrameworkCore;
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Bill.Serviece.Implements
////{
////    public class AnhServiece : IAnhServiece
////    {
////        private readonly MyDbContext _context;
////        public AnhServiece()
////        {
////            _context = new MyDbContext();
////        }
////        public bool Add(Anh p)
////        {
////            try
////            {
////                Anh anh = new Anh()
////                {
////                    Id = Guid.NewGuid(),
////                    LinkAnh = p.LinkAnh,
////                    TrangThai = p.TrangThai
////                };
////                _context.anhs.Add(anh);
////                _context.SaveChanges(); 
////                return true;

////            }catch (Exception ex) 
////            {
////                return false;
////            }
////        }

////        public bool Del(Guid id)
////        {
////            try
////            {
////                Anh anh = _context.anhs.FirstOrDefault(c => c.Id == id);
////                if (anh != null)
////                {
////                    anh.TrangThai = true;
////                }
////                _context.anhs.Update(anh);
////                _context.SaveChanges();
////                return true;

////            }
////            catch (Exception ex)
////            {
////                return false;
////            }
////        }

////        public bool Edit(Guid id, Anh p)
////        {
////            try
////            {
////                Anh anh = _context.anhs.FirstOrDefault(c => c.Id == id);
////                if (anh != null)
////                {
////                    anh.TrangThai = p.TrangThai;
////                    anh.LinkAnh = p.LinkAnh;
////                }
////                _context.anhs.Update(anh);
////                _context.SaveChanges();
////                return true;
////            } catch (Exception ex)
////            {
////                return false;
////            }
////        }

////        public List<Anh> GetAll()
////        {
////            return _context.anhs.ToList();
////        }
////    }
////}
