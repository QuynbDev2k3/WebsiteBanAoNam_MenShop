using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_API.Services
{
    public class ChatLieuService
    {
        private MyDbContext _dbcontext;
        private DbSet<ChatLieu> _dbset;
        public ChatLieuService()
        {
            _dbcontext = new MyDbContext();
            _dbset = _dbcontext.Set<ChatLieu>();


        }

        public void Add(ChatLieu p)
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

        public IEnumerable<ChatLieu> GetAll()

        {
            return _dbset.ToList();
        }


        public void Update(ChatLieu item)
        {
            var p = GetAll().FirstOrDefault(p => p.Id == item.Id);

            try
            {
                p.Name = item.Name;
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
