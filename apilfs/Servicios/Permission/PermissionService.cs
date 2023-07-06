using apilfs.Repository.Interfaces;
using apilfs.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Services.Permission
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermission _permission;

        public PermissionService(IPermission permission)
        {
            _permission = permission;
        }
    }
}
