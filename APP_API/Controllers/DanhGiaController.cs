using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhGiaController : ControllerBase
    {
        private readonly DanhGiaSevices _danhGiasevices;
        public DanhGiaController()
        {
            _danhGiasevices = new DanhGiaSevices();
        }
        // GET: api/<DanhGiaController>
        [HttpGet]
        public IEnumerable<DanhGia> GetDanhGia()
        {
            return _danhGiasevices.GetAll();
        }

        // GET api/<DanhGiaController>/5
     

        // POST api/<DanhGiaController>
        [HttpPost]
        public IActionResult AddDanhGia([FromQuery] DanhGia dg)
        {
            _danhGiasevices.AddItem(dg);
            return Ok();
        }

        // PUT api/<DanhGiaController>/5
        [HttpPut]
        public IActionResult UpdateDanhGia(DanhGia dg)
        {
            _danhGiasevices.EditItem(dg);
            return Ok();
        }

        // DELETE api/<DanhGiaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid Id)
        {
            _danhGiasevices.RemoveItem(Id);
            return Ok();
        }
    }
}
