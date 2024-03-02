using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IChatLieuService
    {
        public List<ChatLieu> GetAll();
        public bool Add(ChatLieu p);
        public bool Edit(Guid id, ChatLieu p);
        public bool Delete(Guid id);
    }
}
