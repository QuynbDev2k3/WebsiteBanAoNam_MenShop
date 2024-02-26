using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository _khachHangRepository;

        public KhachHangService(IKhachHangRepository khachHangRepository)
        {
            _khachHangRepository = khachHangRepository;
        }

        public KhachHang GetKhachHangById(Guid id)
        {
            return _khachHangRepository.GetKhachHangById(id);
        }

        public IEnumerable<KhachHang> GetAllKhachHangs()
        {
            return _khachHangRepository.GetAllKhachHangs();
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            _khachHangRepository.AddKhachHang(khachHang);
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            _khachHangRepository.UpdateKhachHang(khachHang);
        }

        public void DeleteKhachHang(Guid id)
        {
            _khachHangRepository.DeleteKhachHang(id);
        }
    }
}
