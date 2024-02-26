using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangController : Controller
    {
        private readonly IGioHangService _gioHangService;

        public GioHangController(IGioHangService gioHangService)
        {
            _gioHangService = gioHangService;
        }

        [HttpGet]
        public IEnumerable<GioHang> GetAllGioHangs()
        {
            return _gioHangService.GetAllGioHangs();
        }

        [HttpGet("{id}")]
        public GioHang GetGioHangById(Guid id)
        {
            return _gioHangService.GetGioHangById(id);
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
