using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;
//using APP_API.IServices;
//using APP_DATA.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MauSacController : ControllerBase
    {
        private readonly IMauSacServiece _mausacsv;

        public MauSacController(IMauSacServiece mausacsv)
        {
            _mausacsv = mausacsv;
        }
        // GET: api/<MauSacController>
        [HttpGet("GetAll")]
        public IEnumerable<MauSac> GetAllMauSac()
        {
            return _mausacsv.GetAll();
        }

        // POST api/<MauSacController>
        //[HttpPost("create")]
        //public bool CreateMauSac(string name, string ma)
        //{
        //    MauSac mau = new MauSac()
        //    {
        //        Id = Guid.NewGuid(),
        //        TenMauSac = name,
        //        TrangThai = true,
        //        Ma = ma,
        //    };
        //    if (_mausacsv.GetAll().Any(c => c.TenMauSac == name))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return _mausacsv.Add(mau);
        //    }
        //}

        ////        // POST api/<MauSacController>
        //[HttpPost("create")]
        //public bool CreateMauSac(string name, string ma)
        //{
        //    MauSac mau = new MauSac()
        //    {
        //        Id = Guid.NewGuid(),
        //        TenMauSac = name,
        //        TrangThai = true,
        //        Ma = ma,
        //    };
        //    if (_mausacsv.GetAll().Any(c => c.TenMauSac == name))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return _mausacsv.Add(mau);
        //    }
        //}
        //// DELETE api/<MauSacController>/5
        //[HttpDelete("{id}")]
        //public bool DeleteMau(Guid id)
        //{
        //    return _mausacsv.Delete(id);
        //}
    }
}
//        // DELETE api/<MauSacController>/5
//        [HttpDelete("{id}")]
//        public bool DeleteMau(Guid id)
//        {
//            return _mausacsv.Del(id);
//        }
//    }
//}
