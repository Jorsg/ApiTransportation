using apilfs.Repository.Interfaces;
using apilfs.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Services.Role
{
    public class RolesByUserService : IRolesByUserService
    {
        private readonly IRolesByUser _roleByUser;

        public RolesByUserService(IRolesByUser roleByUser)
        {
            _roleByUser = roleByUser;
        }
    }
}
