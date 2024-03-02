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
    public class CTGioHangRepository:ICTGioHangRepository
    {
        private readonly MyDbContext _context;

        public CTGioHangRepository(MyDbContext context)
        {
            _context = context;
        }

        public CTGioHang GetCTGioHangById(Guid id)
        {
            return _context.CTGioHangs.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<CTGioHang> GetAllCTGioHangs()
        {
            return _context.CTGioHangs.ToList();
        }

        public void AddCTGioHang(CTGioHang ctGioHang)
        {
            _context.CTGioHangs.Add(ctGioHang);
            _context.SaveChanges();
        }

        public void UpdateCTGioHang(CTGioHang ctGioHang)
        {
            _context.CTGioHangs.Update(ctGioHang);
            _context.SaveChanges();
        }

        public void DeleteCTGioHang(Guid id)
        {
            var ctGioHang = _context.CTGioHangs.FirstOrDefault(c => c.Id == id);
            if (ctGioHang != null)
            {
                _context.CTGioHangs.Remove(ctGioHang);
                _context.SaveChanges();
            }
        }
    }
}
