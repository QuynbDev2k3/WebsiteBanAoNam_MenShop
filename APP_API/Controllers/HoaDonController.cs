using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : Controller
    {
        private readonly HoaDonService _hoadonServices;

        public HoaDonController()
        {
            _hoadonServices = new HoaDonService();
        }

        [HttpGet("Get")]
        public IEnumerable<HoaDon> GetAll()
        {
            return _hoadonServices.GetAll();
        }



        [HttpPost("Add")]
        public IActionResult Add([FromQuery] HoaDon HoaDon)
        {
            _hoadonServices.Add(HoaDon);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromQuery] HoaDon HoaDon)
        {
            _hoadonServices.Update(HoaDon);
            return Ok();
        }

        [HttpDelete("Delete{id}")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            _hoadonServices.Delete(id);
            return Ok();
        }
    }
}
