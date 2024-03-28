<<<<<<< HEAD
﻿using APP_API.Services;
using APP_DATA.Models;
using Bill.Serviece.Interfaces;
using Microsoft.AspNetCore.Mvc;
=======
﻿//using APP_API.IServices;
//using APP_DATA.Models;
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd

//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace APP_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MauSacController : ControllerBase
//    {
//        private readonly IMauSacServiece _mausacsv;

//        public MauSacController()
//        {
//            _mausacsv = new IMauSacServiece();
//        }
//        // GET: api/<MauSacController>
//        [HttpGet("GetAll")]
//        public IEnumerable<MauSac> GetAllMauSac()
//        {
//            return _mausacsv.GetAll();
//        }

<<<<<<< HEAD

        // POST api/<MauSacController>
        [HttpPost("create")]
        public bool CreateMauSac(string name, string ma)
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
=======
        
//        // POST api/<MauSacController>
//        [HttpPost("create")]
//        public bool CreateMauSac( string name, string ma)
//        {
//            MauSac mau = new MauSac()
//            {
//                Id = Guid.NewGuid(),
//                TenMauSac = name,
//                TrangThai = true,
//                Ma = ma,
//            };
//            if (_mausacsv.GetAll().Any(c => c.TenMauSac == name))
//            {
//                return false;
//            }
//            else
//            {
//                return _mausacsv.Add(mau);
//            }
//        }
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd



<<<<<<< HEAD
        // DELETE api/<MauSacController>/5
        [HttpDelete("{id}")]
        public bool DeleteMau(Guid id)
        {
            return _mausacsv.Delete(id);
        }
    }
}
=======
//        // DELETE api/<MauSacController>/5
//        [HttpDelete("{id}")]
//        public bool DeleteMau(Guid id)
//        {
//            return _mausacsv.Del(id);
//        }
//    }
//}
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
