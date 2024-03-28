using APP_DATA.Models;

namespace APP_VIEW.Models
{
    public class CTSanPhamViewModel
    {
        public SanPham objSanPham { get; set; }
        public List<SanPham> Listsanpham { get; set; }
        public List<DanhMucSanPham> listDanhmuc { get; set; }
     
    }
}
