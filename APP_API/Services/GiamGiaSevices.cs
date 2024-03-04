using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class GiamGiaSevices : IGiamGiaSevices
    {
        private MyDbContext myDbContext;
        public GiamGiaSevices()
        {
            myDbContext = new MyDbContext();
        }
        public bool AddItem(GiamGia item)
        {
            try
            {
                myDbContext.Add(item);
                myDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EditItem(GiamGia item)
        {
            try
            {
                var gg = myDbContext.GiamGias.FirstOrDefault(c => c.Id == item.Id);
                gg.BinhLuan=item.BinhLuan;
                gg.Sao=item.Sao;
                gg.NgayDanhGia=item.NgayDanhGia;
                gg.trangThai=item.trangThai;
                myDbContext.Update(gg);
                myDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false; 
            }
        }

        public List<GiamGia> GetAll()
        {
            return myDbContext.GiamGias.ToList();
        }

        public bool RemoveItem(Guid Id)
        {
            try
            {
                var gg = myDbContext.GiamGias.FirstOrDefault(c => c.Id == Id);
                myDbContext.Remove(gg);
                myDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
