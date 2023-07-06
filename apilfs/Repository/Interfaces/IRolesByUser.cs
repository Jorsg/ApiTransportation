using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IRolesByUser
    {
        IQueryable<Models.RolesByUser> GetRolesByUser(int idUser);
        void CreateRolesByUser(Models.RolesByUser rolesByUser);
    }
}
