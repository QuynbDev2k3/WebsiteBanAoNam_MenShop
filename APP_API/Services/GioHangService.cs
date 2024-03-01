//using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class GioHangService
    {
        private MyDbContext _db;
        private DbSet<GioHang> _dbset;

        public GioHangService()
        {
            _db = new MyDbContext();
            _dbset = _db.Set<GioHang>();


        }

        public void AddGioHang(GioHang item)
        {

            try
            {

                _dbset.Add(item);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {


            }
        }

        public IEnumerable<GioHang> GetAllGioHangs()

        {
            return _dbset.ToList();
        }


        public void UpdateGioHang(GioHang item)
        {
            var x = GetAllGioHangs().FirstOrDefault(x => x.Id == item.Id);

            try
            {
                x.NgayTao = item.NgayTao;
                x.KhachHang = item.KhachHang;
                x.KhachHangID = item.KhachHangID;
                _dbset.Update(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void DeleteGioHang(Guid id)
        {
            var x = GetAllGioHangs().FirstOrDefault(x => x.Id == id);
            try
            {
                _dbset.Remove(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }
    }
}
