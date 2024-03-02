using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class RoleService 
    {
        private MyDbContext _db;
        private DbSet<Role> _dbset;

        public RoleService()
        {
            _db = new MyDbContext();
            _dbset = _db.Set<Role>();


        }

        public void AddRole(Role item)
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

        public IEnumerable<Role> GetAllRoles()

        {
            return _dbset.ToList();
        }


        public void UpdateRole(Role item)
        {
            var x = GetAllRoles().FirstOrDefault(x => x.Id == item.Id);

            try
            {
                x.Ten = item.Ten;
                x.TrangThai = item.TrangThai;
               
                _dbset.Update(x);
                _db.SaveChanges();
                return;
            }
            catch (Exception)
            {



            }
        }

        public void DeleteRole(Guid id)
        {
            var x = GetAllRoles().FirstOrDefault(x => x.Id == id);
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
