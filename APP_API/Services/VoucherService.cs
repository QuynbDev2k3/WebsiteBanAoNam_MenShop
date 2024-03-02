using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class VoucherService
    {
        private MyDbContext _dbcontext;
        private readonly DbSet<Voucher> _dbset;
        public VoucherService()
        {
            _dbcontext = new MyDbContext();
            _dbset = _dbcontext.Set<Voucher>();


        }

        public void Add(Voucher item)
        {

            try
            {

                _dbset.Add(item);
                _dbcontext.SaveChanges();
                return;
            }
            catch (Exception)
            {
                
               
            }
        }

        public IEnumerable<Voucher> GetAll()

        {
            return _dbset.ToList();
        }


        public void Update(Voucher item)
        {
            var p = GetAll().FirstOrDefault(p => p.Id == item.Id);

            try
            {
                p.Ten = item.Ten;
                p.DieuKien = item.DieuKien;
                p.GiaTri = item.GiaTri;
                p.NgayApDung = item.NgayApDung;
                p.NgayHetHan = item.NgayHetHan;
                p.SoLuong = item.SoLuong;
                p.MoTa = item.MoTa;
                p.trangthai = item.trangthai;

                _dbset.Update(p);
                _dbcontext.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void Delete(Guid id)
        {
            var p = GetAll().FirstOrDefault(p => p.Id == id);
            try
            {
                _dbset.Remove(p);
                _dbcontext.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }
    }
}
