using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Permission
{
    public class PermissionByRoleRepository : IPermissionByRole
    {
        private readonly BD_LFSContext _context;

        public PermissionByRoleRepository(BD_LFSContext context)
        {
            _context = context;
        }

        IQueryable<Models.PermissionsByRole> IPermissionByRole.GetPermissionsByRole(int idRole)
        {
            return _context.PermissionsByRoles.Where(elm => elm.IdRole == idRole);
        }
    }
}
