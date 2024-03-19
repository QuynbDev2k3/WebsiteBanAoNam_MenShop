using Microsoft.AspNetCore.Mvc;
using APP_DATA.Models;
using APP_DATA.Context;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace APP_VIEW.Controllers
{
    public class GioHangController : Controller
    {
        private readonly MyDbContext _context;

        public GioHangController()
        {
            _context = new MyDbContext();
        }

        // GET: api/GioHang
        public IQueryable<CTGioHang> GetGioHangs()
        {
            return _context.CTGioHangs;
        }

        // GET: api/GioHang/5
        //[ResponseType(typeof(CTGioHang))]
        public ActionResult GetCTGioHang(Guid id)
        {
            CTGioHang ctgiohang = _context.CTGioHangs.Find(id);
            if (ctgiohang == null)
            {
                return NotFound();
            }
            return Ok(ctgiohang);
        }

        // PUT: api/GioHang/5
       // [ResponseType(typeof(void))]
        public ActionResult PutCTGioHang(Guid id, CTGioHang ctgiohang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ctgiohang.Id)
            {
                return BadRequest();
            }

            _context.Entry(ctgiohang).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CTGioHangExists(id))
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

        // POST: api/GioHang
        //[ResponseType(typeof(CTGioHang))]
        public ActionResult PostCTGioHang(CTGioHang ctgiohang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CTGioHangs.Add(ctgiohang);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ctgiohang.Id }, ctgiohang);
        }

        // DELETE: api/GioHang/5
       // [ResponseType(typeof(CTGioHang))]
        public ActionResult DeleteCTGioHang(Guid id)
        {
            CTGioHang ctgiohang = _context.CTGioHangs.Find(id);
            if (ctgiohang == null)
            {
                return NotFound();
            }

            _context.CTGioHangs.Remove(ctgiohang);
            _context.SaveChanges();

            return Ok(ctgiohang);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CTGioHangExists(Guid id)
        {
            return _context.CTGioHangs.Count(e => e.Id == id) > 0;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> CapNhatSoLuong(Guid id, [FromBody] CapNhatSoLuongRequest request)
        {
            if (ModelState.IsValid)
            {
                var ctGioHang = await _context.CTGioHangs.FindAsync(id);

                if (ctGioHang == null)
                {
                    return NotFound();
                }

                ctGioHang.SoLuong = request.SoLuong;
                ctGioHang.TongTien = (int)(ctGioHang.SoLuong * ctGioHang.CTSanPhams.GiaBan);

                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }

        public class CapNhatSoLuongRequest
        {
            public int SoLuong { get; set; }
        }

        public decimal TinhTongTienGioHang(List<CTGioHang> gioHangItems)
        {
            decimal tongTien = 0;

            for (int i = 0; i < gioHangItems.Count; i++)
            {
                CTGioHang item = gioHangItems[i];
                decimal thanhTien = (decimal)(item.SoLuong * (item.CTSanPhams?.GiaBan ?? 0));
                tongTien += thanhTien;
            }

            return tongTien;
        }


    }
}
