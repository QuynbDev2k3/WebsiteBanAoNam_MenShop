using APP_DATA.Models;

namespace APP_API.IServices;

public interface IHangService
{
    Task<IEnumerable<Hang>> GetAll();
    Task<Hang> GetById(Guid id);
    Task Create(string ten, bool trangthai);
    Task Update(Guid id, string ten, bool trangthai);
    Task Delete(Guid id);
}