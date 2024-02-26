using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IRoleRepository
    {
        Role GetRoleById(Guid id);
        IEnumerable<Role> GetAllRoles();
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Guid id);
    }
}
