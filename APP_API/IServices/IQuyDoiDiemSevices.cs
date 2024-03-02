using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IQuyDoiDiemSevices
    {
        public List<QuyDoiDiem> GetAll();
        public bool AddItem(QuyDoiDiem item);
        public bool RemoveItem(Guid Id);
        public bool EditItem(QuyDoiDiem item);
    }
}
