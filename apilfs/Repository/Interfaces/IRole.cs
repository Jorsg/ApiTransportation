using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IRole
    {
        Models.Role GetRoleById(int id);
        Models.Role GetRoleByName(string name);
    }
}
