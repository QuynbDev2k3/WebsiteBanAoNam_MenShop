using APP_API.IServices;
using APP_DATA.IRepositories;
using APP_DATA.Models;

namespace APP_API.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Role GetRoleById(Guid id)
        {
            return _roleRepository.GetRoleById(id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _roleRepository.GetAllRoles();
        }

        public void AddRole(Role role)
        {
            _roleRepository.AddRole(role);
        }

        public void UpdateRole(Role role)
        {
            _roleRepository.UpdateRole(role);
        }

        public void DeleteRole(Guid id)
        {
            _roleRepository.DeleteRole(id);
        }
    }
}
