using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IGiamGiaSevices
    {
        public List<GiamGia> GetAll();
        public bool AddItem(GiamGia item);
        public bool RemoveItem(Guid Id);
        public bool EditItem(GiamGia item);
    }
}
