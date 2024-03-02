using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class LsTichDiemSevices : ILsTichDiemSevices
    {
        private MyDbContext myDbContext;
        public LsTichDiemSevices()
        {
            myDbContext = new MyDbContext();
        }
        public bool AddItem(LichSuTichDiem item)
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

        public bool EditItem(LichSuTichDiem item)
        {
            try
            {
                var gg = myDbContext.LichSuTichDiems.FirstOrDefault(c => c.Id == item.Id);
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

        public List<LichSuTichDiem> GetAll()
        {
            return myDbContext.LichSuTichDiems.ToList();
        }

        public bool RemoveItem(Guid Id)
        {
            try
            {
                var gg = myDbContext.LichSuTichDiems.FirstOrDefault(c => c.Id == Id);
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
