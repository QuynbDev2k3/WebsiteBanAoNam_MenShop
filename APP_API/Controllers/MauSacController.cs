using APP_DATA.Models;
using Bill.Serviece.Implements;
using Bill.Serviece.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MauSacController : ControllerBase
    {
        private readonly IMauSacServiece _mausacsv;

        public MauSacController()
        {
            _mausacsv = new MauSacServiece();
        }
        // GET: api/<MauSacController>
        [HttpGet("GetAll")]
        public IEnumerable<MauSac> GetAllMauSac()
        {
            return _mausacsv.GetAll();
        }

        
        // POST api/<MauSacController>
        [HttpPost("create")]
        public bool CreateMauSac( string name, string ma)
        {
            MauSac mau = new MauSac()
            {
                Id = Guid.NewGuid(),
                TenMauSac = name,
                TrangThai = true,
                Ma = ma,
            };
            if (_mausacsv.GetAll().Any(c => c.TenMauSac == name))
            {
                return false;
            }
            else
            {
                return _mausacsv.Add(mau);
            }
        }

        

        // DELETE api/<MauSacController>/5
        [HttpDelete("{id}")]
        public bool DeleteMau(Guid id)
        {
            return _mausacsv.Del(id);
        }
    }
}
