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
    public class VoucherRepository : IVoucherRepository
    {
        private readonly MyDbContext _context;
        public VoucherRepository(MyDbContext context)
        {
            _context = context;
        }
        public bool Add(Voucher voucher)
        {
            if (voucher == null) return false;
            _context.Add(voucher);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Voucher voucher)
        {
            if (voucher == null) return false;
            _context.Remove(voucher);
            _context.SaveChanges();
            return true;
        }

        public List<Voucher> GetAll()
        {
            return _context.vouchers.ToList();
        }

        public Voucher GetById(Guid id)
        {
            return _context.vouchers.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Voucher voucher)
        {
            if (voucher == null) return false;
            _context.Update(voucher);
            _context.SaveChanges();
            return true;
        }
    }
}
