using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class LichSuMuaHang
    {
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid IdKhachHang { get; set; }
        public bool TrangThai {  get; set; }
        public virtual KhachHang? KhachHang { get; set;}
        public virtual HoaDon? HoaDon { get; set;}
    }
}
