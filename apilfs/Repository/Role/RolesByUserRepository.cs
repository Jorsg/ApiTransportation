using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Role
{
    public class RolesByUserRepository : IRolesByUser
    {
        private readonly BD_LFSContext _context;

        public RolesByUserRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.RolesByUser> GetRolesByUser(int idUser)
        {
            return _context.RolesByUsers.Where(elm => elm.IdUser == idUser);
        }

        public void CreateRolesByUser(Models.RolesByUser rolesByUser)
        {
            _context.RolesByUsers.Add(rolesByUser);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
