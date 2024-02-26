using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface ICTGioHangService
    {
        CTGioHang GetCTGioHangById(Guid id);
        IEnumerable<CTGioHang> GetAllCTGioHangs();
        void AddCTGioHang(CTGioHang ctGioHang);
        void UpdateCTGioHang(CTGioHang ctGioHang);
        void DeleteCTGioHang(Guid id);
    }
}
