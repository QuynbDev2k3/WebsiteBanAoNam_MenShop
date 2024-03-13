using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class GioHang
    {
        public Guid Id { get; set; }
        public Guid IdGioHang { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public Guid? KhachHangID { get;  set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTGioHang>? cTGioHangs { get; set; }
    }
}
