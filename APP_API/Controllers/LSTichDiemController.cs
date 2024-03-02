using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LSTichDiemController : ControllerBase
    {
        public readonly LsTichDiemSevices _lstichdiem;
        public LSTichDiemController()
        {
            _lstichdiem = new LsTichDiemSevices();
        }
        // GET: api/<LSTichDiemController>
        [HttpGet]
        public IEnumerable<LichSuTichDiem> GetALlLsTichDiem()
        {
            return _lstichdiem.GetAll();
        }

        // GET api/<LSTichDiemController>/5
       

        // POST api/<LSTichDiemController>
        [HttpPost]
        public IActionResult AddLsTichDiem(LichSuTichDiem LsDiem)
        {
            _lstichdiem.AddItem(LsDiem);
            return Ok();
        }

        // PUT api/<LSTichDiemController>/5
        [HttpPut]
        public IActionResult UpdateLsTichDiem(LichSuTichDiem LsDiem)
        {
            _lstichdiem.EditItem(LsDiem);
            return Ok();
        }

        // DELETE api/<LSTichDiemController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid Id)
        {
            _lstichdiem.RemoveItem(Id);
            return Ok();
        }
    }
}
