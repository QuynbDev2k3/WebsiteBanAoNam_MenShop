using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace APP_VIEW.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly HttpClient _httpClient;
        public RoleController()
        {
            _httpClient = new HttpClient();
        }
        [HttpGet]
        [Route("Show_chuc_vu")]
       public async Task<IActionResult> Show()
        {
            string apiURL = $"https://localhost:7164/api/Role";
            var response = await _httpClient.GetAsync(apiURL);
            var apiData = await response.Content.ReadAsStringAsync();
            var Role = JsonConvert.DeserializeObject<List<Role>>(apiData);
            return View(Role);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid Id)
        {
            string apiURL = $"https://localhost:7164/api/Role/GetById/{Id}";
            var response = await _httpClient.GetAsync(apiURL);
            var apiData = await response.Content.ReadAsStringAsync();
            var Role = JsonConvert.DeserializeObject<Role>(apiData);
            return View(Role);
        }

        // GET: RoleController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Role Role)
        {
            string apiURL = $"https://localhost:7164/api/Role?Id={Role.Id}&Ten={Role.Ten}&TrangThai={Role.TrangThai}";
            var content = new StringContent(JsonConvert.SerializeObject(Role), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiURL, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Show");
            }
            return View();
        }
        // GET: RoleController/Edit/5
        public async Task<IActionResult> Edit(Guid Id)
        {
            string apiURL = $"https://localhost:7164/api/Role/GetById/{Id}";
            var response = await _httpClient.GetAsync(apiURL);
            var apiData = await response.Content.ReadAsStringAsync();
            var Role = JsonConvert.DeserializeObject<Role>(apiData);
            return View(Role);
        }

        // POST: RoleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid Id, Role Role)
        {
            string apiURL = $"https://localhost:7164/api/Role?Id={Id
                }&Ten={Role.Ten}&TrangThai={Role.TrangThai}";
            var content = new StringContent(JsonConvert.SerializeObject(Role), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(apiURL, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Show");
            }
            return View();
        }


        // POST: RoleController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(Guid Id)
        {
            string apiURL = $"https://localhost:7164/api/Role/{Id}";
            var response = await _httpClient.DeleteAsync(apiURL);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Show");
            }
            return RedirectToAction("Show");
        }
    }
}
