using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IKhachHangService
    {
        KhachHang GetKhachHangById(Guid id);
        IEnumerable<KhachHang> GetAllKhachHangs();
        void AddKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(Guid id);
    }
}
