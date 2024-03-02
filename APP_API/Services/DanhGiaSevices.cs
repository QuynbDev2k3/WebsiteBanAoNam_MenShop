using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class DanhGiaSevices : IDanhGiaSevices
    {
        private MyDbContext myDbContext;
        public DanhGiaSevices()
        {
            myDbContext = new MyDbContext();
        }
        public bool AddItem(DanhGia item)
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

        public bool EditItem(DanhGia item)
        {
            try
            {
                var gg = myDbContext.DanhGias.FirstOrDefault(c => c.Id == item.Id);
               gg.BinhLuan=item.BinhLuan;
                gg.Sao=item.Sao;
                gg.NgayDanhGia=item.NgayDanhGia;
                gg.TrangThai=item.TrangThai;
                myDbContext.Update(gg);
                myDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<DanhGia> GetAll()
        {
            return myDbContext.DanhGias.ToList();
        }

        public bool RemoveItem(Guid Id)
        {
            try
            {
                var gg = myDbContext.DanhGias.FirstOrDefault(c => c.Id == Id);
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
