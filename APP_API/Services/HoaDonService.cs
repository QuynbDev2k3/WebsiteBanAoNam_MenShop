using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class HoaDonService
    {
        private MyDbContext _dbcontext;
        private readonly DbSet<HoaDon> _dbset;
        public HoaDonService()
        {
            _dbcontext = new MyDbContext();
            _dbset = _dbcontext.Set<HoaDon>();


        }

        public void Add(HoaDon p)
        {

            try
            {

                _dbset.Add(p);
                _dbcontext.SaveChanges();
                return;
            }
            catch (Exception)
            {


            }
        }

        public IEnumerable<HoaDon> GetAll()

        {
            return _dbset.ToList();
        }


        public void Update(HoaDon item)
        {
            var p = GetAll().FirstOrDefault(p => p.Id == item.Id);

            try
            {
                p.MaHD = item.MaHD;
                p.TienShip = item.TienShip;
                p.NgayTao = item.NgayTao;
                p.TenNgNhan = item.TenNgNhan;
                p.SDT = item.SDT;
                p.Email = item.Email;
                p.PTThanhToan = item.PTThanhToan;
                p.TongTien = item.TongTien;
                p.DiaChi = item.DiaChi;
                p.GhiChu = item.GhiChu;
                p.NgayNhanHang = item.NgayNhanHang;
                p.NgayThanhToan = item.NgayThanhToan;
                p.TrangThai = item.TrangThai;


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
