using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IUser
    {
        Models.User GetUserByEmail(string email);
        Models.User CreateUser(Models.User user);
    }
}
