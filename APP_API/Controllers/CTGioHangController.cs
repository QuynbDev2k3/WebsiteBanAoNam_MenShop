//using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CTGioHangController : Controller
    {
        private readonly CTGioHangService _ctGioHangService;

        public CTGioHangController()
        {
            _ctGioHangService = new CTGioHangService();
        }

        [HttpGet]
        public IEnumerable<CTGioHang> GetAllCTGioHangs()
        {
            return _ctGioHangService.GetAllCTGioHangs();
        }

        

        [HttpPost]
        public IActionResult AddCTGioHang(CTGioHang ctGioHang)
        {
            _ctGioHangService.AddCTGioHang(ctGioHang);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCTGioHang(CTGioHang ctGioHang)
        {
            _ctGioHangService.UpdateCTGioHang(ctGioHang);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCTGioHang(Guid id)
        {
            _ctGioHangService.DeleteCTGioHang(id);
            return Ok();
        }
    }
}
