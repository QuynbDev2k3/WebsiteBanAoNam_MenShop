using APP_DATA.Context;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AppView.Controllers
{
    public class LichSuMuaHangController : Controller
    {
        // GET: ComBoController
        
        private readonly MyDbContext _context;
        
        

        public LichSuMuaHangController()
        {
            _context = new MyDbContext();
        }

        // GET: api/LichSuMuaHang
        public IQueryable<LichSuMuaHang> GetGioHangs()
        {
            return _context.lichSuMuaHangs;
        }
        // GET: api/LSMuaHang
        //[ResponseType(typeof(LichSuMuaHang))]
        public IActionResult GetlistLichSuMuaHang(Guid id)
        {
            LichSuMuaHang lsmuahang = _context.lichSuMuaHangs.Find(id);
            if (lsmuahang == null)
            {
                return NotFound();
            }
            return Ok(lsmuahang);
        }

        // PUT: api/GioHang/5
        // [ResponseType(typeof(void))]
        public ActionResult PutLS(Guid id, LichSuMuaHang lsMuaHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lsMuaHang.Id)
            {
                return BadRequest();
            }

            _context.Entry(lsMuaHang).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LsMuaHangExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        private ActionResult StatusCode(HttpStatusCode noContent)
        {
            throw new NotImplementedException();
        }
        private bool LsMuaHangExists(Guid id)
        {
            return _context.lichSuMuaHangs.Count(e => e.Id == id) > 0;
        }


        // POST: api/LSMuaHang
        //[ResponseType(typeof(LSMuaHang))]
        public ActionResult PostLS(LichSuMuaHang LsMuaHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.lichSuMuaHangs.Add(LsMuaHang);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = LsMuaHang.Id }, LsMuaHang);
        }

        // DELETE: api/LichSuMuaHang
        // [ResponseType(typeof(LSMuaHang))]
        public ActionResult DeleteLSMuaHang(Guid id)
        {
            LichSuMuaHang lsmuahang = _context.lichSuMuaHangs.Find(id);
            if (lsmuahang == null)
            {
                return NotFound();
            }

            _context.lichSuMuaHangs.Remove(lsmuahang);
            _context.SaveChanges();

            return Ok(lsmuahang);
        }







    }

    
}
