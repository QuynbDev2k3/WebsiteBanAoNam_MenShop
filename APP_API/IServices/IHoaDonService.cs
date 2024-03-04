using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IHoaDonService
    {
        public List<HoaDon> GetAll();
        public bool Add(HoaDon p);
        public bool Edit(Guid id, HoaDon p);
        public bool Delete(Guid id);
    }
}
