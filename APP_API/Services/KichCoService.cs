using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class KichCoService : IKichCoService
    {
        private readonly IKichCoRepository _kichCoRepository;

        public KichCoService(IKichCoRepository kichCoRepository)
        {
            _kichCoRepository = kichCoRepository;
        }

        public KichCo GetKichCoById(Guid id)
        {
            return _kichCoRepository.GetKichCoById(id);
        }

        public IEnumerable<KichCo> GetAllKichCos()
        {
            return _kichCoRepository.GetAllKichCos();
        }

        public void AddKichCo(KichCo kichCo)
        {
            _kichCoRepository.AddKichCo(kichCo);
        }

        public void UpdateKichCo(KichCo kichCo)
        {
            _kichCoRepository.UpdateKichCo(kichCo);
        }

        public void DeleteKichCo(Guid id)
        {
            _kichCoRepository.DeleteKichCo(id);
        }
    }
}
