using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiamGiaController : ControllerBase
    {
        private readonly GiamGiaSevices _GiamGiaSevices;
        public GiamGiaController()
        {
            _GiamGiaSevices = new GiamGiaSevices();
        }
        // GET: api/<GiamGiaController>
        [HttpGet]
        public IEnumerable<GiamGia> GetAllGiamGia()
        {
            return _GiamGiaSevices.GetAll();
        }

        // GET api/<GiamGiaController>/5

        // POST api/<GiamGiaController>
        [HttpPost]
        public IActionResult AddGiamGia([FromQuery] GiamGia giamGia )
        {
            _GiamGiaSevices.AddItem( giamGia );
            return Ok();
        }

        // PUT api/<GiamGiaController>/5
        [HttpPut]
        public IActionResult UpdateGiamGia(GiamGia giamGia)
        {
            _GiamGiaSevices.EditItem( giamGia );
            return Ok();
        }

        // DELETE api/<GiamGiaController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCTGioHang(Guid Id)
        {
            _GiamGiaSevices.RemoveItem(Id);
            return Ok();
        }
    }
}
