using APP_DATA.Models;
using APP_DATA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace APP_VIEW.Controllers
{
    public class BanHangController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ILogger<BanHangController> _logger;

        public BanHangController(HttpClient httpClient, IWebHostEnvironment hostEnvironment, ILogger<BanHangController> logger)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7164/api/");
            _hostEnvironment = hostEnvironment;
            _logger = logger;
        }
        public async Task<IActionResult> TaiQuay()
        {
            // Gọi API để lấy danh sách sản phẩm
            var sanPhamResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "sanpham/getall");
                var sanPhamJsonString = await sanPhamResponse.Content.ReadAsStringAsync();
                var sanpham = JsonConvert.DeserializeObject<List<SanPham>>(sanPhamJsonString);
                // Tiếp tục xử lý dữ liệu sản phẩm tại đây

            // Gọi API để lấy thông tin hóa đơn
            var hoaDonResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "hoadon/getall");
                var hoaDonJsonString = await hoaDonResponse.Content.ReadAsStringAsync();
                var hoaDon = JsonConvert.DeserializeObject<HoaDon>(hoaDonJsonString);
                // Tiếp tục xử lý dữ liệu hóa đơn tại đây

            // Gọi API để lấy thông tin chi tiết hóa đơn
            var ctHoaDonResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "cthoadon/getall");
                var ctHoaDonJsonString = await ctHoaDonResponse.Content.ReadAsStringAsync();
                var ctHoaDon = JsonConvert.DeserializeObject<CTHoaDon>(ctHoaDonJsonString);
                // Tiếp tục xử lý dữ liệu chi tiết hóa đơn tại đây

            // Convert danh sách sản phẩm từ kiểu SanPham sang kiểu SanPhamViewModel
            var sanPhamViewModels = sanpham.Select(p => new SanPhamViewModel
            {
                ID = p.ID,
                Ten = p.Ten,
                Gia = p.Gia,
                // Gán các thuộc tính khác cần thiết từ model SanPham vào SanPhamViewModel
            }).ToList();
            var hoaDonViewModel = new HoaDonViewModel
            {
                // Gán các thuộc tính từ model HoaDon vào InvoiceViewModel
                TongTien = hoaDon.TongTien,
                TienShip = hoaDon.TienShip,
                TenNgNhan = hoaDon.TenNgNhan,
                DiaChi = hoaDon.DiaChi,
                SDT = hoaDon.SDT,
                Email = hoaDon.Email,
                // Gán các thuộc tính khác cần thiết từ model HoaDon vào InvoiceViewModel
            };

            var ctHoaDonViewModel = new CTHoaDonViewModel
            {
                // Gán các thuộc tính từ model CTHoaDon vào ProductInvoiceViewModel
                Ten = ctHoaDon.IdCTSP.ToString(),
                Gia = ctHoaDon.dongia,
                SoLuong = ctHoaDon.soluong,
                // Gán các thuộc tính khác cần thiết từ model CTHoaDon vào ProductInvoiceViewModel
            };
            // Tạo và truyền dữ liệu qua ViewModel
            var viewModel = new BanHangViewModel
            {
                // Gán dữ liệu từ các API đã gọi
                sanPhamViewModels = sanPhamViewModels,
                hoaDonViewModel = hoaDonViewModel,
            };

            // Trả về View và truyền ViewModel
            return View(viewModel);
            //return View();
        }
    }
}
