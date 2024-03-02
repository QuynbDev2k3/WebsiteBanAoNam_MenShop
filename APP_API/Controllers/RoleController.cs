using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        [HttpGet]
        public IEnumerable<Role> GetAllRoles()
        {
            return _roleService.GetAllRoles();
        }

        

        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            _roleService.AddRole(role);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            _roleService.UpdateRole(role);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(Guid id)
        {
            _roleService.DeleteRole(id);
            return Ok();
        }
    }
}
