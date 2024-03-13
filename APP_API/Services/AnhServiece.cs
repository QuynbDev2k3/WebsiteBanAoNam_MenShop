using APP_DATA.Context;
using APP_DATA.Models;

using Bill.Serviece.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.Serviece.Implements
{
    public class AnhServiece : IAnhServiece
    {
        private readonly MyDbContext _context;
        public AnhServiece()
        {
            _context = new MyDbContext();
        }
        public bool Add(Anh p)
        {
            try
            {
                Anh anh = new Anh()
                {
                    Id = Guid.NewGuid(),
                    LinkAnh = p.LinkAnh,
                    TrangThai = p.TrangThai
                };
                _context.anhs.Add(anh);
                _context.SaveChanges(); 
                return true;

            }catch (Exception ex) 
            {
                return false;
            }
        }

        public bool Del(Guid id)
        {
            try
            {
                Anh anh = _context.anhs.FirstOrDefault(c => c.Id == id);
                if (anh != null)
                {
                    anh.TrangThai = true;
                }
                _context.anhs.Update(anh);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(Guid id, Anh p)
        {
            try
            {
                Anh anh = _context.anhs.FirstOrDefault(c => c.Id == id);
                if (anh != null)
                {
                    anh.TrangThai = p.TrangThai;
                    anh.LinkAnh = p.LinkAnh;
                }
                _context.anhs.Update(anh);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public List<Anh> GetAll()
        {
            return _context.anhs.ToList();
        }
    }
}
