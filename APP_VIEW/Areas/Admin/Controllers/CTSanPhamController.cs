using APP_DATA.Context;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace APP_VIEW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CTSanPhamController : Controller
    {
        private readonly MyDbContext _dbcontext;
        private readonly ILogger<ProductController> _logger;
        private readonly HttpClient _httpClient;
        public CTSanPhamController(ILogger<ProductController> logger)
        {
            _logger = logger;
            _dbcontext = new MyDbContext();
        }
        [HttpGet]
        [Route("Listsanpham")]

        public IActionResult Index()
        {
            var lstSanPham = _dbcontext.CtSanPhams.ToList();
            return View(lstSanPham);
           
        }
        [HttpGet]
        public async Task<IActionResult> ThemSanPhamMoi()
        {
            
            return View();
        }
        [HttpPost]
        [Route("Themspmoi")]
        public async Task<IActionResult> ThemSanPhamMoi(CTSanPham SanPham)
        {
            var asult = await _httpClient.PostAsJsonAsync<CTSanPham>($"https://localhost:7164/api/ctsanpham/add",SanPham);
            return View("Index");
        }
        [Route("[action]/masp")]
        [HttpDelete]
        public async Task<IActionResult> Delete(string masp)
        {
            var asult = await _httpClient.DeleteAsync($"https://localhost:7164/api/ctsanpham/delete/{masp}");
            return View("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            string apiUrl = $"";
            var response = await _httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var CTSanPham = JsonConvert.DeserializeObject<CTSanPham>(apiData);
            return this.View(CTSanPham);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Guid id, CTSanPham ctSP)
        {
            string apiUrl = $"";
            var content = new StringContent(JsonConvert.SerializeObject(ctSP),Encoding.UTF8,"application/json");
            var response = await _httpClient.PutAsync(apiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                return this.RedirectToAction("Index");
            }
            return this.View(ctSP);
        }
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            string apiUrl = $"";
            var response = await _httpClient.GetAsync(apiUrl) ;
            string apiData = await response.Content.ReadAsStringAsync() ;
            var CTSP = JsonConvert.DeserializeObject<CTSanPham> (apiData);
            return this.View(CTSP);
        }
    }
}
