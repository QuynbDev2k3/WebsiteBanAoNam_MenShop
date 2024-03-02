using APP_API.IServices;
using APP_DATA.Context;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class DanhMucSanPhamSevices : IDanhMusSanPhamSevices
    {
        private MyDbContext myDbContext;
        public DanhMucSanPhamSevices()
        {
            myDbContext = new MyDbContext();
        }
        public bool AddItem(DanhMucSanPham item)
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

        public bool EditItem(DanhMucSanPham item)
        {
            try
            {
                var gg = myDbContext.DanhMucSanPhams.FirstOrDefault(c => c.Id == item.Id);
                gg.Ten=item.Ten;
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

        public List<DanhMucSanPham> GetAll()
        {
            return myDbContext.DanhMucSanPhams.ToList();
        }

        public bool RemoveItem(Guid Id)
        {
            try
            {
                var gg = myDbContext.DanhMucSanPhams.FirstOrDefault(c => c.Id == Id);
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
