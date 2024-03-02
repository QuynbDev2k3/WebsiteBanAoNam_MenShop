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
    public class CTHoaDonRepository : ICTHoaDonRepository
    {
        private readonly MyDbContext _context;
        public CTHoaDonRepository(MyDbContext context)
        {
            _context = context;
        }

        
        public bool Add(CTHoaDon CtHoaDon)
        {
            if (CtHoaDon == null) return false;
            _context.Add(CtHoaDon);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(CTHoaDon CtHoaDon)
        {
            if (CtHoaDon == null) return false;
            _context.Remove(CtHoaDon);
            _context.SaveChanges();
            return true;
        }

        public List<CTHoaDon> GetAll()
        {
            return _context.CtHoadons.ToList();
        }

        public CTHoaDon GetById(Guid id)
        {
            return _context.CtHoadons.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(CTHoaDon CtHoaDon)
        {
            if (CtHoaDon == null) return false;
            _context.Update(CtHoaDon);
            _context.SaveChanges();
            return true;
        }
    }
}
