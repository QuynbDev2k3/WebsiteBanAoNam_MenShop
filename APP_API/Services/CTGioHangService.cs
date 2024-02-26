using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class CTGioHangService : ICTGioHangService
    {
        private readonly ICTGioHangRepository _ctGioHangRepository;

        public CTGioHangService(ICTGioHangRepository ctGioHangRepository)
        {
            _ctGioHangRepository = ctGioHangRepository;
        }

        public CTGioHang GetCTGioHangById(Guid id)
        {
            return _ctGioHangRepository.GetCTGioHangById(id);
        }

        public IEnumerable<CTGioHang> GetAllCTGioHangs()
        {
            return _ctGioHangRepository.GetAllCTGioHangs();
        }

        public void AddCTGioHang(CTGioHang ctGioHang)
        {
            _ctGioHangRepository.AddCTGioHang(ctGioHang);
        }

        public void UpdateCTGioHang(CTGioHang ctGioHang)
        {
            _ctGioHangRepository.UpdateCTGioHang(ctGioHang);
        }

        public void DeleteCTGioHang(Guid id)
        {
            _ctGioHangRepository.DeleteCTGioHang(id);
        }
    }
}
