using apilfs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Services.Interfaces
{
    public interface IUserService
    {
        UserRolesPermissions GetUserWithRoles(string email);
        Models.User CreateUserWithRolesAndCustomerAndAgent(UserRolesCustomerAgentDto userRolesCustomerAgent);
    }
}
