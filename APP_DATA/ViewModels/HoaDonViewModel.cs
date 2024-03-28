using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.ViewModels
{
    public class HoaDonViewModel
    {
        public List<CTHoaDonViewModel> cTHoaDonViewModels { get; set; }
        public int TongTien { get; set; }
        public int TienShip { get; set; }
        public string TenNgNhan { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
