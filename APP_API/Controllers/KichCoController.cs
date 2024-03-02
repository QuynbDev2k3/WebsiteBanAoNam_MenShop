//using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KichCoController : Controller
    {
        private readonly KichCoService _kichCoService;

        public KichCoController()
        {
            _kichCoService = new KichCoService();
        }

        [HttpGet]
        public IEnumerable<KichCo> GetAllKichCos()
        {
            return _kichCoService.GetAllKichCos();
        }

        //[HttpGet("{id}")]
        //public KichCo GetKichCoById(Guid id)
        //{
            //return _kichCoService.GetKichCoById(id);
        //}

        [HttpPost]
        public IActionResult AddKichCo(KichCo kichCo)
        {
            _kichCoService.AddKichCo(kichCo);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateKichCo(KichCo kichCo)
        {
            _kichCoService.UpdateKichCo(kichCo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKichCo(Guid id)
        {
            _kichCoService.DeleteKichCo(id);
            return Ok();
        }
    }
}
