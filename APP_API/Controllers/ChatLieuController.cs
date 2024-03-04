using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatLieuController : ControllerBase
    {
        private readonly ChatLieuService _chatlieuServices;

        public ChatLieuController()
        {
            _chatlieuServices = new ChatLieuService();
        }

        [HttpGet("Get")]
        public IEnumerable<ChatLieu> GetAll()
        {
            return _chatlieuServices.GetAll();
        }



        [HttpPost("Add")]
        public IActionResult Add([FromQuery] ChatLieu ChatLieu)
        {
            _chatlieuServices.Add(ChatLieu);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromQuery] ChatLieu ChatLieu)
        {
            _chatlieuServices.Update(ChatLieu);
            return Ok();
        }

        [HttpDelete("Delete{id}")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            _chatlieuServices.Delete(id);
            return Ok();
        }
    }
}
