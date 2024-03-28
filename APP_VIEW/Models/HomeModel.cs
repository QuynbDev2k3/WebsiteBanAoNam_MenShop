using APP_DATA.Models;

namespace APP_VIEW.Models
{
    public class HomeModel
    {
        public List<SanPham> bestSellers { get; set; }
        public List<SanPham> newArrivals { get; set; }
        public List<SanPham> hotsale { get; set; }
    }
}
