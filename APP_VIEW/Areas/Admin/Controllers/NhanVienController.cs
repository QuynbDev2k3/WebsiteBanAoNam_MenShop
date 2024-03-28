using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using APP_DATA.Repositories;
using APP_VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
using System.Text;

namespace APP_VIEW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NhanVienController : Controller
    {
        private readonly HttpClient _httpClient;

        public NhanVienController()
        {
                _httpClient = new HttpClient();
        }
        [HttpGet]
        [Route("List_nhanvien")]
        public async Task<IActionResult> Show()
        {
            string apiUrl = "https://localhost:7164/api/nhanvien/Getall";
            var response = await _httpClient.GetAsync(apiUrl);
            string apidata = await response.Content.ReadAsStringAsync();
            var nhanvien = JsonConvert.DeserializeObject<List<NhanVien>>(apidata);
            return View(nhanvien);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NhanVien model)
        {
            string apiUrl = $"https://localhost:7164/api/nhanvien/add?idrole={model.IDRole}&ma={model.Ma}&ten={model.Ten}&sdt={model.SDT}&email={model.Email}&diachi={model.DiaChi}&matkhau={model.MatKhau}&trangthai={model.TrangThai}";
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiUrl,content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Show");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            string apiURL = $"https://localhost:7164/api/nhanvien/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            var apiData = await response.Content.ReadAsStringAsync();
            var nhanviens = JsonConvert.DeserializeObject<NhanVien>(apiData);
            return View(nhanviens);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            string apiURL = $"https://localhost:7164/api/nhanvien/getbyid/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var nhanvien = JsonConvert.DeserializeObject<NhanVien>(apiData);
            return this.View(nhanvien);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, NhanVien nhanvien)
        {
            string apiURL = $"https://localhost:7164/api/nhanvien/update/{id}?idrole={nhanvien.IDRole}&ma={nhanvien.Ma}&ten={nhanvien.Ten}&sdt={nhanvien.SDT}&email={nhanvien.Email}&diachi={nhanvien.DiaChi}&matkhau={nhanvien.MatKhau}&trangthai={nhanvien.TrangThai}";
            var content = new StringContent(JsonConvert.SerializeObject(nhanvien), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(apiURL, content);
            if (response.IsSuccessStatusCode)
            {
                return this.RedirectToAction("Show");
            }
            return this.View(nhanvien);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            string apiURL = $"https://localhost:7164/api/nhanvien/delete/{id}";
            var response = await _httpClient.DeleteAsync(apiURL);
            if (response.IsSuccessStatusCode)
            {
                return this.RedirectToAction("Show");
            }
            return this.RedirectToAction("Show");
        }
    }
}
