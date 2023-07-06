using apilfs.Repository.Interfaces;
using apilfs.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Services.Role
{
    public class RoleService : IRoleService
    {
        private readonly IRole _role;

        public RoleService(IRole role)
        {
            _role = role;
        }
    }
}
