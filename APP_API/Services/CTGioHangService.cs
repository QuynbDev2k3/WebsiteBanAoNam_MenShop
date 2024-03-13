//using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class CTGioHangService 
    {
        private MyDbContext _db;
        private DbSet<CTGioHang> _dbset;

        public CTGioHangService()
        {
            _db = new MyDbContext();
            _dbset = _db.Set<CTGioHang>();


        }

        public void AddCTGioHang(CTGioHang item)
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

        public IEnumerable<CTGioHang> GetAllCTGioHangs()

        {
            return _dbset.ToList();
        }


        public void UpdateCTGioHang(CTGioHang item)
        {
            var x = GetAllCTGioHangs().FirstOrDefault(x => x.Id == item.Id);

            try
            {
                x.TongTien = item.TongTien;
                x.SoLuong = item.SoLuong;
                x.GioHang = item.GioHang;
                //x.ChiTietSP = item.ChiTietSP;
                x.GioHangID = item.GioHangID;
                //x.ChiTetSP = item.ChiTietSP;
                
                _dbset.Update(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void DeleteCTGioHang(Guid id)
        {
            var x = GetAllCTGioHangs().FirstOrDefault(x => x.Id == id);
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
