using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly MyDbContext _context;
        public HoaDonRepository(MyDbContext context)
        {
            _context = context;
        }
        public bool Add(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            _context.Add(hoadon);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            _context.Remove(hoadon);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _context.hoadons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            return _context.hoadons.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            _context.Update(hoadon);
            _context.SaveChanges();
            return true;
        }
    }
}
