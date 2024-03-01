using APP_DATA.Models;

namespace APP_API.IServices;

public interface IHangService
{
    Task<IEnumerable<Hang>> GetAll();
    Task<Hang> GetById(Guid id);
    Task Create(Hang hang);
    Task Update(Hang hang);
    Task Delete(Guid id);
}