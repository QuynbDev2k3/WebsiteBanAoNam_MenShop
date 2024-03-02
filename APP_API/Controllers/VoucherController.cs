using APP_API.Services;
using APP_DATA.Models;
using APP_DATA.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APP_DATA.Context;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : Controller
    {
        private readonly VoucherService _voucherServices;

        public VoucherController()
        {
            _voucherServices = new VoucherService();
        }

        [HttpGet("Get")]
        public IEnumerable<Voucher> GetAll()
        {
            return _voucherServices.GetAll();
        }

        

        [HttpPost("Add")]
        public IActionResult Add([FromQuery] Voucher Voucher)
        {
            _voucherServices.Add(Voucher);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromQuery] Voucher Voucher)
        {
            _voucherServices.Update(Voucher);
            return Ok();
        }

        [HttpDelete("Delete{id}")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            _voucherServices.Delete(id);
            return Ok();
        }

    }
}
