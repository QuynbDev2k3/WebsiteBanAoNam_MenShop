using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class CTHoaDonService
    {
        private MyDbContext _dbcontext;
        private readonly DbSet<CTHoaDon> _dbset;
        public CTHoaDonService()
        {
            _dbcontext = new MyDbContext();
            _dbset = _dbcontext.Set<CTHoaDon>();


        }

        public void Add(CTHoaDon p)
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

        public IEnumerable<CTHoaDon> GetAll()

        {
            return _dbset.ToList();
        }


        public void Update(CTHoaDon item)
        {
            var p = GetAll().FirstOrDefault(p => p.Id == item.Id);

            try
            {
                p.dongia = item.dongia;
                p.soluong = item.soluong;
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
