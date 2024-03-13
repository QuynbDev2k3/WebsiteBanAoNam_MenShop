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
        public bool TrsngThai {  get; set; }
        public virtual KhachHang? KhachHang { get; set;}
    }
}
