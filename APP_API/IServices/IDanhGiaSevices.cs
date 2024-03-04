using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IDanhGiaSevices
    {
        public List<DanhGia> GetAll();
        public bool AddItem(DanhGia item);
        public bool RemoveItem(Guid Id);
        public bool EditItem(DanhGia item);
    }
}
