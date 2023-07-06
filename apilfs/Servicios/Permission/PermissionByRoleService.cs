using apilfs.Repository.Interfaces;
using apilfs.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Services.Permission
{
    public class PermissionByRoleService : IPermissionByRoleService
    {
        private readonly IPermissionByRole _permissionByRole;

        public PermissionByRoleService(IPermissionByRole permissionByRole)
        {
            _permissionByRole = permissionByRole;
        }
    }
}
