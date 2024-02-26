using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : Controller
    {
        private readonly IKhachHangService _khachHangService;

        public KhachHangController(IKhachHangService khachHangService)
        {
            _khachHangService = khachHangService;
        }

        [HttpGet]
        public IEnumerable<KhachHang> GetAllKhachHangs()
        {
            return _khachHangService.GetAllKhachHangs();
        }

        [HttpGet("{id}")]
        public KhachHang GetKhachHangById(Guid id)
        {
            return _khachHangService.GetKhachHangById(id);
        }

        [HttpPost]
        public IActionResult AddKhachHang(KhachHang khachHang)
        {
            _khachHangService.AddKhachHang(khachHang);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateKhachHang(KhachHang khachHang)
        {
            _khachHangService.UpdateKhachHang(khachHang);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKhachHang(Guid id)
        {
            _khachHangService.DeleteKhachHang(id);
            return Ok();
        }
    }
}
