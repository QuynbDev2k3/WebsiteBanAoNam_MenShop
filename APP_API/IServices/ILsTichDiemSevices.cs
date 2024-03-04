using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface ILsTichDiemSevices
    {
        public List<LichSuTichDiem> GetAll();
        public bool AddItem(LichSuTichDiem item);
        public bool RemoveItem(Guid Id);
        public bool EditItem(LichSuTichDiem item);
    }
}
