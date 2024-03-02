using APP_API.IServices;
using APP_API.Services;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using APP_DATA.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangController : Controller
    {
        private readonly GioHangService _gioHangService;
        public GioHangController()
        {
            _gioHangService = new GioHangService();
        }

        [HttpGet]
        public IEnumerable<GioHang> GetAllGioHangs()
        {
            return _gioHangService.GetAllGioHangs();
        }

        

        [HttpPost]
        public IActionResult AddGioHang(GioHang gioHang)
        {
            _gioHangService.AddGioHang(gioHang);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGioHang(GioHang gioHang)
        {
            _gioHangService.UpdateGioHang(gioHang);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGioHang(Guid id)
        {
            _gioHangService.DeleteGioHang(id);
            return Ok();
        }
    }
}
