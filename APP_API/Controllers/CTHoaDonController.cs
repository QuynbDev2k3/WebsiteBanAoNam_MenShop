using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CTHoaDonController : Controller
    {
        private readonly CTHoaDonService _CtHoadonServices;

        public CTHoaDonController()
        {
            _CtHoadonServices = new CTHoaDonService();
        }

        [HttpGet("Get")]
        public IEnumerable<CTHoaDon> GetAll()
        {
            return _CtHoadonServices.GetAll();
        }



        [HttpPost("Add")]
        public IActionResult Add([FromQuery] CTHoaDon CTHoaDon)
        {
            _CtHoadonServices.Add(CTHoaDon);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromQuery] CTHoaDon CTHoaDon)
        {
            _CtHoadonServices.Update(CTHoaDon);
            return Ok();
        }

        [HttpDelete("Delete{id}")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            _CtHoadonServices.Delete(id);
            return Ok();
        }
    }
}
