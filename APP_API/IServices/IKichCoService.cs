using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IKichCoService
    {
        KichCo GetKichCoById(Guid id);
        IEnumerable<KichCo> GetAllKichCos();
        void AddKichCo(KichCo kichCo);
        void UpdateKichCo(KichCo kichCo);
        void DeleteKichCo(Guid id);
    }
}
