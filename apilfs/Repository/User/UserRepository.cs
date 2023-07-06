using apilfs.Models;
using apilfs.Repository.Interfaces;
using System.Linq;

namespace apilfs.Repository.User
{
    public class UserRepository : IUser
    {
        private readonly BD_LFSContext _context;

        public UserRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public Models.User CreateUser(Models.User user)
        {
            _context.Users.Add(user);
            Save();
            return user;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Models.User GetUserByEmail(string email)
        {
            return _context.Users.Where(elm => elm.User1 == email).FirstOrDefault();
        }
    }
}
