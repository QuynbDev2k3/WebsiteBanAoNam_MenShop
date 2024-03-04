using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IVoucherService
    {
        public List<Voucher> GetAll();
        public bool Add(Voucher p);
        public bool Edit(Guid id, Voucher p);
        public bool Delete(Guid id);
    }
}
