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
    public class KichCoRepository : IKichCoRepository
    {
        private readonly MyDbContext _context;

        public KichCoRepository(MyDbContext context)
        {
            _context = context;
        }

        public KichCo GetKichCoById(Guid id)
        {
            return _context.KichCos.FirstOrDefault(k => k.Id == id);
        }

        public IEnumerable<KichCo> GetAllKichCos()
        {
            return _context.KichCos.ToList();
        }

        public void AddKichCo(KichCo kichCo)
        {
            _context.KichCos.Add(kichCo);
            _context.SaveChanges();
        }

        public void UpdateKichCo(KichCo kichCo)
        {
            _context.KichCos.Update(kichCo);
            _context.SaveChanges();
        }

        public void DeleteKichCo(Guid id)
        {
            var kichCo = _context.KichCos.FirstOrDefault(k => k.Id == id);
            if (kichCo != null)
            {
                _context.KichCos.Remove(kichCo);
                _context.SaveChanges();
            }
        }
    }
}
