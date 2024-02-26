using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class GioHangService : IGioHangService
    {
        private readonly IGioHangRepository _gioHangRepository;

        public GioHangService(IGioHangRepository gioHangRepository)
        {
            _gioHangRepository = gioHangRepository;
        }

        public GioHang GetGioHangById(Guid id)
        {
            return _gioHangRepository.GetGioHangById(id);
        }

        public IEnumerable<GioHang> GetAllGioHangs()
        {
            return _gioHangRepository.GetAllGioHangs();
        }

        public void AddGioHang(GioHang gioHang)
        {
            _gioHangRepository.AddGioHang(gioHang);
        }

        public void UpdateGioHang(GioHang gioHang)
        {
            _gioHangRepository.UpdateGioHang(gioHang);
        }

        public void DeleteGioHang(Guid id)
        {
            _gioHangRepository.DeleteGioHang(id);
        }
    }
}
