using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnhController : ControllerBase
    {
        private readonly AnhServiece _AnhServices;

        public AnhController()
        {
            _AnhServices = new AnhServiece();
        }

        [HttpGet("Get")]
        public IEnumerable<Anh> GetAll()
        {
            return _AnhServices.GetAll();
        }



        [HttpPost("Add")]
        public IActionResult Add([FromQuery] Anh anh)
        {
            _AnhServices.Add(anh);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromQuery] Anh anh)
        {
            _AnhServices.Update(anh);
            return Ok();
        }

        [HttpDelete("Delete{id}")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            _AnhServices.Delete(id);
            return Ok();
        }
    }
}

//using APP_DATA.Models;
//using Bill.Serviece.Implements;
//using Bill.Serviece.Interfaces;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace APP_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AnhController : ControllerBase
//    {
//        private readonly IAnhServiece _anhsv;

//        public AnhController()
//        {
//            _anhsv = new AnhServiece();
//        }
//        // GET: api/<AnhController>
//        [HttpGet("GetAll")]
//        public IEnumerable<Anh> Get()
//        {
//            return _anhsv.GetAll();
//        }

//        // POST api/<AnhController>
//        [HttpPost("Create")]
//        public bool CreateAnh( string name)
//        {
//            Anh anh = new Anh()
//            {
//                Id = Guid.NewGuid(),
//                LinkAnh = name,
//                TrangThai = true,
//            };
//            return _anhsv.Add(anh);
//        }

//        // DELETE api/<MauSacController>/5
//        [HttpDelete("{Deleteid}")]
//        public bool DeleteAnh(Guid id)
//        {
//            return _anhsv.Del(id);
//        }
//    }
//}
