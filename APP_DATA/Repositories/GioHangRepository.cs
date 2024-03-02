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
    public class GioHangRepository : IGioHangRepository
    {
        private readonly MyDbContext _context;

        public GioHangRepository(MyDbContext context)
        {
            _context = context;
        }

        public GioHang GetGioHangById(Guid id)
        {
            return _context.GioHangs.FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<GioHang> GetAllGioHangs()
        {
            return _context.GioHangs.ToList();
        }

        public void AddGioHang(GioHang gioHang)
        {
            _context.GioHangs.Add(gioHang);
            _context.SaveChanges();
        }

        public void UpdateGioHang(GioHang gioHang)
        {
            _context.GioHangs.Update(gioHang);
            _context.SaveChanges();
        }

        public void DeleteGioHang(Guid id)
        {
            var gioHang = _context.GioHangs.FirstOrDefault(g => g.Id == id);
            if (gioHang != null)
            {
                _context.GioHangs.Remove(gioHang);
                _context.SaveChanges();
            }
        }
    }
}
