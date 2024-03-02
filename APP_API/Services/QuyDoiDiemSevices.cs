using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class QuyDoiDiemSevices : IQuyDoiDiemSevices
    {
        private MyDbContext myDbContext;
        public QuyDoiDiemSevices()
        {
            myDbContext = new MyDbContext();
        }
        public bool AddItem(QuyDoiDiem item)
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

        public bool EditItem(QuyDoiDiem item)
        {
            try
            {
                var gg = myDbContext.QuyDoiDiems.FirstOrDefault(c => c.Id == item.Id);
               gg.TiLeTichDiem=item.TiLeTichDiem;
                gg.TiLeTieuDiem=item.TiLeTieuDiem;
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

        public List<QuyDoiDiem> GetAll()
        {
            return myDbContext.QuyDoiDiems.ToList();
        }

        public bool RemoveItem(Guid Id)
        {
            try
            {
                var gg = myDbContext.QuyDoiDiems.FirstOrDefault(c => c.Id == Id);
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
