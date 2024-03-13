using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class DoiTra
    {
        public Guid Id { get; set; }
        public DateTime NgayDoiTra { get; set; }
        public string Lydo {  get; set; }
        public DateTime HanDoi { get; set; }
        public bool TrangThai { get; set; } 
        public Guid IdHoaDon { get; set; }
        public Guid IdSanPham { get; set; }
        public virtual SanPham? SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }

    }
}
