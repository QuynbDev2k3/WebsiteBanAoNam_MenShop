using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public IEnumerable<Role> GetAllRoles()
        {
            return _roleService.GetAllRoles();
        }

        [HttpGet("{id}")]
        public Role GetRoleById(Guid id)
        {
            return _roleService.GetRoleById(id);
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
