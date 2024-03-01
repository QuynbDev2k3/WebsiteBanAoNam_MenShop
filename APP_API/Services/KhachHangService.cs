using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class KhachHangService 
    {
      
        private MyDbContext _db;
        private DbSet<KhachHang> _dbset;

        public KhachHangService()
        {
          _db = new MyDbContext();
          _dbset = _db.Set<KhachHang>();


        }

        public void AddKhachHang(KhachHang item)
        {

            try
            {
      
                _dbset.Add(item);
                _db.SaveChanges();
                return ;
            }
            catch (Exception)
            {

                
            }
        }

        public IEnumerable<KhachHang> GetAllKhachHangs()

        {
            return _dbset.ToList();
        }


        public void UpdateKhachHang(KhachHang item)
        {
            var x = GetAllKhachHangs().FirstOrDefault(x => x.Id == item.Id);

            try
            {
                x.SDT = item.SDT;
                x.GioiTinh = item.GioiTinh;
                x.Ten = item.Ten;
                x.MatKhau = item.MatKhau;
                x.NgaySinh = item.NgaySinh;
                x.DiaChi = item.DiaChi;
                x.Diem=item.Diem;
                x.Email = item.Email;
                x.TrangThai = item.TrangThai;
                _dbset.Update(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void DeleteKhachHang(Guid id)
        {
           var x = GetAllKhachHangs().FirstOrDefault(x => x.Id == id);
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
