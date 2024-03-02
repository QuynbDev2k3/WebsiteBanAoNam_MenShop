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
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly MyDbContext _context;

        public KhachHangRepository(MyDbContext context)
        {
            _context = context;
        }

        public KhachHang GetKhachHangById(Guid id)
        {
            return _context.KhachHangs.FirstOrDefault(k => k.Id == id);
        }

        public IEnumerable<KhachHang> GetAllKhachHangs()
        {
            return _context.KhachHangs.ToList();
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            _context.KhachHangs.Update(khachHang);
            _context.SaveChanges();
        }

        public void DeleteKhachHang(Guid id)
        {
            var khachHang = _context.KhachHangs.FirstOrDefault(k => k.Id == id);
            if (khachHang != null)
            {
                _context.KhachHangs.Remove(khachHang);
                _context.SaveChanges();
            }
        }
    }
}
