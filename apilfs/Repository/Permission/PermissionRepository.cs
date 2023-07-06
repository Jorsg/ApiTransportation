using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Permission
{
    public class PermissionRepository : IPermission
    {
        private readonly BD_LFSContext _context;

        public PermissionRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public Models.Permission GetPermissionById(int id)
        {
            return _context.Permissions.Where(elm => elm.Id == id).FirstOrDefault();
        }
    }
}
