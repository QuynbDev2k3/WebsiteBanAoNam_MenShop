using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IDanhMusSanPhamSevices
    {
        public List<DanhMucSanPham> GetAll();
        public bool AddItem(DanhMucSanPham item);
        public bool RemoveItem(Guid Id);
        public bool EditItem(DanhMucSanPham item);
    }
}
