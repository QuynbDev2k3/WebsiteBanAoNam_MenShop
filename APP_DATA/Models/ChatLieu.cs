using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class ChatLieu
    {       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
    }
}
    