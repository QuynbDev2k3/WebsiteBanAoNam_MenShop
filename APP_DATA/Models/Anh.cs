using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Anh
    {
        public Guid Id { get; set; }
        public string LinkAnh { get; set; }
        public bool TrangThai { get; set; }
        public virtual CTSanPham? CTSanPhams { get; set; }
    }
}
