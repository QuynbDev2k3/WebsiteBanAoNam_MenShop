using System.Data;
using System;
using System.Collections.Generic;
using APP_DATA.Models;
namespace APP_API.IServices
{
    public interface IRoleService
    {
        Role GetRoleById(Guid id);
        IEnumerable<Role> GetAllRoles();
       void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Guid id);
    }
}
