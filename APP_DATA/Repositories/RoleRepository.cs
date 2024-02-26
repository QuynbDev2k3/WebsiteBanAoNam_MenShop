using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MyDbContext _context;

        public RoleRepository(MyDbContext context)
        {
            _context = context;
        }

        public Role GetRoleById(Guid id)
        {
            return _context.Roles.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }

        public void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Guid id)
        {
            var role = _context.Roles.FirstOrDefault(r => r.Id == id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }
    }
}
