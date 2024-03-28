using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IAnhServices
    {
        Task<IEnumerable<Anh>> GetAll();
        Task<Anh> GetById(Guid id);


        Task Create(string linkanh, bool trangthai);
        Task Update(Guid id, string linkanh, bool trangthai);
        Task Delete(Guid id);
    }
}