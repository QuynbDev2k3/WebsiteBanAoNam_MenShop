
using APP_DATA.Context;
using APP_DATA.Models;
using AppData.Serviece.Implements;
using AppData.Serviece.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LichSuMuaHangController : ControllerBase
    {
        private readonly ILichSuMuaHangService<LichSuMuaHang> _lssv;
        private MyDbContext _db = new MyDbContext();
        private DbSet<LichSuMuaHang> _lsmh;

        public LichSuMuaHangController()
        {
            _lsmh = _db.lichSuMuaHangs;
            LichSuMuaHangService<LichSuMuaHang> all = new LichSuMuaHangService<LichSuMuaHang>(_db, _lsmh);
            _lssv = all;
        }

        // GET: api/<LichSuMuaHangController>
        [HttpGet("GetLSMH")]
        public IEnumerable<LichSuMuaHang> GetLichSuMuaHang()
        {
            return _lssv.GetAll();
        }

        // GET api/<LichSuMuaHangController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LichSuMuaHangController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LichSuMuaHangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LichSuMuaHangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
