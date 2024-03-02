//using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class KichCoService 
    {
        private MyDbContext _db;
        private DbSet<KichCo> _dbset;

        public KichCoService()
        {
            _db = new MyDbContext();
            _dbset = _db.Set<KichCo>();


        }

        public void AddKichCo(KichCo item)
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

        public IEnumerable<KichCo> GetAllKichCos()

        {
            return _dbset.ToList();
        }


        public void UpdateKichCo(KichCo item)
        {
            var x = GetAllKichCos().FirstOrDefault(x => x.Id == item.Id);

            try
            {
                x.Name = item.Name;
                x.TrangThai = item.TrangThai;
                x.Ma = item.Ma;
                _dbset.Update(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void DeleteKichCo(Guid id)
        {
            var x = GetAllKichCos().FirstOrDefault(x => x.Id == id);
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
