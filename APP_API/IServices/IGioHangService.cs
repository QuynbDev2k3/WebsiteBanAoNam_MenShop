using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IGioHangService
    {
        GioHang GetGioHangById(Guid id);
        IEnumerable<GioHang> GetAllGioHangs();
        void AddGioHang(GioHang gioHang);
        void UpdateGioHang(GioHang gioHang);
        void DeleteGioHang(Guid id);
    }
}
