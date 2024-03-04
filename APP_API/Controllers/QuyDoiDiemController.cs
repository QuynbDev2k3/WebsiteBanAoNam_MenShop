using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuyDoiDiemController : ControllerBase
    {
        private readonly QuyDoiDiemSevices quyDoiDiemSevices;
        public QuyDoiDiemController()
        {
            quyDoiDiemSevices = new QuyDoiDiemSevices();
        }
        // GET: api/<QuyDoiDiemController>
        [HttpGet]
        public IEnumerable<QuyDoiDiem> GetAllQuyDoi()
        {
            return quyDoiDiemSevices.GetAll();
        }

        // GET api/<QuyDoiDiemController>/5
       

        // POST api/<QuyDoiDiemController>
        [HttpPost]
        public IActionResult Post(QuyDoiDiem quyDoi)
        {
            quyDoiDiemSevices.AddItem(quyDoi);
            return Ok();
        }

        // PUT api/<QuyDoiDiemController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateQUyDoi(QuyDoiDiem quyDoi)
        {
            quyDoiDiemSevices.EditItem(quyDoi);
            return Ok();
        }

        // DELETE api/<QuyDoiDiemController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteQuyDoi(Guid id)
        {
            quyDoiDiemSevices.RemoveItem(id);
            return Ok();
        }
    }
}
