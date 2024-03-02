using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IChatLieuRepository
    {
        ChatLieu GetById(Guid id);
        List<ChatLieu> GetAll();
        bool Add(ChatLieu chatlieu);
        bool Update(ChatLieu chatlieu);
        bool Delete(ChatLieu chatlieu);
    }
}
