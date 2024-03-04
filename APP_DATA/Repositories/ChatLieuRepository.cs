using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Repositories
{
    public class ChatLieuRepository : IChatLieuRepository
    {
        private readonly MyDbContext _context;
        public ChatLieuRepository(MyDbContext context)
        {
            _context = context;
        }
        public bool Add(ChatLieu chatlieu)
        {
            if (chatlieu == null) return false;
            _context.Add(chatlieu);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(ChatLieu chatlieu)
        {
            if (chatlieu == null) return false;
            _context.Remove(chatlieu);
            _context.SaveChanges();
            return true;
        }

        public List<ChatLieu> GetAll()
        {
            return _context.chatlieus.ToList();
        }

        public ChatLieu GetById(Guid id)
        {
            return _context.chatlieus.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(ChatLieu chatlieu)
        {
            if (chatlieu == null) return false;
            _context.Update(chatlieu);
            _context.SaveChanges();
            return true;
        }

        
    }
}
