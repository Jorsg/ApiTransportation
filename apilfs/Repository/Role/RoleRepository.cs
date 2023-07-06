using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Role
{
    public class RoleRepository : IRole
    {
        private readonly BD_LFSContext _context;

        public RoleRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public Models.Role GetRoleById(int id)
        {
            return _context.Roles.Where(elm => elm.Id == id).FirstOrDefault();
        }

        public Models.Role GetRoleByName(string name)
        {
            return _context.Roles.Where(elm => elm.Name == name).FirstOrDefault();
        }
    }
}
