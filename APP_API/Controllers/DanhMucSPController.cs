using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucSPController : ControllerBase
    {
        private readonly DanhMucSanPhamSevices _danhmucSPSevices;
        public DanhMucSPController()
        {
            _danhmucSPSevices = new DanhMucSanPhamSevices();
        }
        // GET: api/<DanhMucSPController>
        [HttpGet]
        public IEnumerable<DanhMucSanPham> GetALlDanhMucSP()
        {
            return _danhmucSPSevices.GetAll();
        }

        // GET api/<DanhMucSPController>/5
        [HttpGet("{id}")]


        // POST api/<DanhMucSPController>
        [HttpPost]
        public IActionResult AddDanhMucSP(DanhMucSanPham Danhmuc)
        {
            _danhmucSPSevices.AddItem(Danhmuc);
            return Ok();
        }

        // PUT api/<DanhMucSPController>/5
        [HttpPut]
        public IActionResult UpdateDanhMucSP(DanhMucSanPham Danhmuc)
        {
            _danhmucSPSevices.EditItem(Danhmuc);
            return Ok();
        }

        // DELETE api/<DanhMucSPController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDanhMucSP(Guid Id)
        {
            _danhmucSPSevices.RemoveItem(Id);
            return Ok();    
        }
    }
}
