using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace APP_VIEW.Controllers
{
    public class AdminController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AdminController(HttpClient httpClient, IWebHostEnvironment hostEnvironment)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7164/api/");
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> GetAllSanPham(int? page)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + "sanpham/getall");
            var sp = JsonConvert.DeserializeObject<List<SanPham>>(response.Content.ReadAsStringAsync().Result);
            var pageNumber = page ?? 1; // page là tham số trang, hoặc mặc định là trang 1 nếu không có
            var pageSize = 5; // Số lượng mục trên mỗi trang
            var spPagedList = sp.ToPagedList(pageNumber, pageSize);
            return View(spPagedList);
        }
        public async Task<IActionResult> GetAllCTSanPham(int? page)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + "ctsanpham/getall");
            var ctsp = JsonConvert.DeserializeObject<List<CTSanPham>>(response.Content.ReadAsStringAsync().Result);
            var pageNumber = page ?? 1; // page là tham số trang, hoặc mặc định là trang 1 nếu không có
            var pageSize = 5; // Số lượng mục trên mỗi trang
            var ctspPagedList = ctsp.ToPagedList(pageNumber, pageSize);
            return View(ctspPagedList);
        }
        public async Task<IActionResult> GetAllHang(int? page)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + "hang/getall");
            var hang = JsonConvert.DeserializeObject<List<Hang>>(response.Content.ReadAsStringAsync().Result);
            var pageNumber = page ?? 1; // page là tham số trang, hoặc mặc định là trang 1 nếu không có
            var pageSize = 5; // Số lượng mục trên mỗi trang
            var hangPagedList = hang.ToPagedList(pageNumber, pageSize);
            return View(hangPagedList);
        }
        public async Task<IActionResult> GetAllNhanVien(int? page)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress + "nhanvien/getall");
            var nv = JsonConvert.DeserializeObject<List<NhanVien>>(response.Content.ReadAsStringAsync().Result);
            var pageNumber = page ?? 1; // page là tham số trang, hoặc mặc định là trang 1 nếu không có
            var pageSize = 5; // Số lượng mục trên mỗi trang
            var nvPagedList = nv.ToPagedList(pageNumber, pageSize);
            return View(nvPagedList);
        }

        public IActionResult AddSanPham()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSanPham(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                string apiUri = $"https://localhost:7164/api/sanpham/add?iddanhmucsanpham={sanPham.IDDanhMucSanPham}&ma={sanPham.Ma}&ten={sanPham.Ten}&gia={sanPham.Gia}&trangthai={sanPham.TrangThai}";
                var response = await _httpClient.PostAsync(apiUri, null);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllSanPham");
                }
                else
                {
                    TempData["ErrorMessage"] = "Thêm sản phẩm không thành công!";
                    return View(sanPham);
                }
            }
            return View(sanPham);
        }
        public IActionResult AddCTSanPham()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCTSanPham(CTSanPham cTSanPham)
        {
            if (ModelState.IsValid)
            {
                string apiUri = $"https://localhost:7164/api/ctsanpham/add?idsanpham={cTSanPham.IDSanPham}&idvoucher={cTSanPham.IDVoucher}&idmausauc={cTSanPham.IDMauSac}&idkichco={cTSanPham.IDKichCo}&idchatlieu={cTSanPham.IDChatLieu}&idanh={cTSanPham.IDAnh}&idhang={cTSanPham.IDHang}&idgiamgia={cTSanPham.IDGiamGia}&ma={cTSanPham.Ma}&giaban={cTSanPham.GiaBan}&soluong={cTSanPham.SoLuong}&age={cTSanPham.Age}&ngaytao={cTSanPham.NgayTao}&mota={cTSanPham.MoTa}&trangthai={cTSanPham.TrangThai}";
                var response = await _httpClient.PostAsync(apiUri, null);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllCTSanPham");
                }
                else
                {
                    TempData["ErrorMessage"] = "Thêm chitiết sản phẩm không thành công!";
                    return View(cTSanPham);
                }
            }
            return View(cTSanPham);
        }
        public IActionResult AddHang()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHang(Hang hang)
        {
            if (ModelState.IsValid)
            {
                string apiUri = $"https://localhost:7164/api/hang/add?ten={hang.Ten}&trangthai={hang.TrangThai}";
                var response = await _httpClient.PostAsync(apiUri, null);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllHang");
                }
                else
                {
                    TempData["ErrorMessage"] = "Thêm hãng không thành công!";
                    return View(hang);
                }
            }
            return View(hang);
        }
        public IActionResult AddNhanVien()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNhanVien(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                string apiUri = $"https://localhost:7164/api/nhanvien/add?idrole={nhanVien.IDRole}&ma={nhanVien.Ma}&ten={nhanVien.Ten}&sdt={nhanVien.SDT}&email={nhanVien.Email}&diachi={nhanVien.DiaChi}&matkhau={nhanVien.MatKhau}&trangthai={nhanVien.TrangThai}";
                var response = await _httpClient.PostAsync(apiUri, null);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllNhanVien");
                }
                else {
                    TempData["ErrorMessage"] = "Thêm nhân viên không thành công!";
                    return View(nhanVien);
                }
            }
            return View(nhanVien);
        }

        public async Task<IActionResult> UpdateSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/sanpham/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var sanpham = JsonConvert.DeserializeObject<SanPham>(apiData);
            return View(sanpham);
        }
        public async Task<IActionResult> UpdateSanPham(Guid id, SanPham sanPham)
        {
            string apiUri = $"https://localhost:7164/api/sanpham/update/{id}?{sanPham.IDDanhMucSanPham}&ma={sanPham.Ma}&ten={sanPham.Ten}&gia={sanPham.Gia}&trangthai={sanPham.TrangThai}";
            var response = await _httpClient.PutAsync(apiUri, null);
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllSanPham");
            }
            TempData["ErrorMessage"] = "Sửa sản phẩm không thành công!";
            return View(sanPham);
        }
        public async Task<IActionResult> UpdateCTSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/ctsanpham/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var ctsanpham = JsonConvert.DeserializeObject<CTSanPham>(apiData);
            return View(ctsanpham);
        }
        public async Task<IActionResult> UpdateCTSanPham(Guid id, CTSanPham cTSanPham)
        {
            string apiUri = $"https://localhost:7164/api/ctsanpham/update/{id}?idsanpham={cTSanPham.IDSanPham}&idvoucher={cTSanPham.IDVoucher}&idmausauc={cTSanPham.IDMauSac}&idkichco={cTSanPham.IDKichCo}&idchatlieu={cTSanPham.IDChatLieu}&idanh={cTSanPham.IDAnh}&idhang={cTSanPham.IDHang}&idgiamgia={cTSanPham.IDGiamGia}&ma={cTSanPham.Ma}&giaban={cTSanPham.GiaBan}&soluong={cTSanPham.SoLuong}&age={cTSanPham.Age}&ngaytao={cTSanPham.NgayTao}&mota={cTSanPham.MoTa}&trangthai={cTSanPham.TrangThai}";
            var response = await _httpClient.PutAsync(apiUri, null);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllCTSanPham");
            }
            TempData["ErrorMessage"] = "Sửa chi tiết sản phẩm không thành công!";
            return View(cTSanPham);
        }
        public async Task<IActionResult> UpdateHang(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/hang/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var hang = JsonConvert.DeserializeObject<Hang>(apiData);
            return View(hang);
        }
        public async Task<IActionResult> UpdateHang(Guid id, Hang hang)
        {
            string apiUri = $"https://localhost:7164/api/hang/update/{id}?ten={hang.Ten}&trangthai={hang.TrangThai}";
            var response = await _httpClient.PutAsync(apiUri, null);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllHang");
            }
            TempData["ErrorMessage"] = "Sửa hãng không thành công!";
            return View(hang);
        }
        public async Task<IActionResult> UpdateNhanVien(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/nhanvien/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var nhanvien = JsonConvert.DeserializeObject<NhanVien>(apiData);
            return View(nhanvien);
        }
        public async Task<IActionResult> UpdateNhanVien(Guid id, NhanVien nhanVien)
        {
            string apiUri = $"https://localhost:7164/api/nhanvien/update/{id}?idrole={nhanVien.IDRole}&ma={nhanVien.Ma}&ten={nhanVien.Ten}&sdt={nhanVien.SDT}&email={nhanVien.Email}&diachi={nhanVien.DiaChi}&matkhau={nhanVien.MatKhau}&trangthai={nhanVien.TrangThai}";
            var response = await _httpClient.PutAsync(apiUri, null);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllNhanVien");
            }
            TempData["ErrorMessage"] = "Sửa nhân viên không thành công!";
            return View(nhanVien);
        }

        public async Task<IActionResult> DetailsSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/sanpham/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var sanpham = JsonConvert.DeserializeObject<SanPham>(apiData);
            return View(sanpham);
        }
        public async Task<IActionResult> DetailsCTSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/ctsanpham/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var ctsanpham = JsonConvert.DeserializeObject<CTSanPham>(apiData);
            return View(ctsanpham);
        }
        public async Task<IActionResult> DetailsHang(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/hang/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var hang = JsonConvert.DeserializeObject<Hang>(apiData);
            return View(hang);
        }
        public async Task<IActionResult> DetailsNhanVien(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/nhanvien/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiUri);
            var apiData = await response.Content.ReadAsStringAsync();
            var nhanvien = JsonConvert.DeserializeObject<NhanVien>(apiData);
            return View(nhanvien);
        }

        public async Task<IActionResult> DeleteSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/sanpham/delete/{id}";
            var response = await _httpClient.DeleteAsync(apiUri);
            return RedirectToAction("GetAllSanPham");
        }
        public async Task<IActionResult> DeleteCTSanPham(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/ctsanpham/delete/{id}";
            var response = await _httpClient.DeleteAsync(apiUri);
            return RedirectToAction("GetAllCTSanPham");
        }
        public async Task<IActionResult> DeleteHang(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/hang/delete/{id}";
            var response = await _httpClient.DeleteAsync(apiUri);
            return RedirectToAction("GetAllHang");
        }
        public async Task<IActionResult> DeleteNhanVien(Guid id)
        {
            string apiUri = $"https://localhost:7164/api/nhanvien/delete/{id}";
            var response = await _httpClient.DeleteAsync(apiUri);
            return RedirectToAction("GetAllNhanVien");
        }
    }
}
