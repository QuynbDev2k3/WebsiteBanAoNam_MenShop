using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface ICTHoaDonService
    {
        public List<CTHoaDon> GetAll();
        public bool Add(CTHoaDon p);
        public bool Edit(Guid id, CTHoaDon p);
        public bool Delete(Guid id);
    }
}
