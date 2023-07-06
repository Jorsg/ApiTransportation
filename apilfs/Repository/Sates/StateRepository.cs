using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.States
{
    public class StateRepository : IStates
    {
        private readonly BD_LFSContext _context;
        public StateRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public State GetStateById(int id)
        {
            return _context.States.Where(elm => elm.Id == id).FirstOrDefault();
        }
    }
}
