using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.Interfaces
{
    public interface IPort
    {
        IQueryable<Models.PortsRamp> GetPort();

        IQueryable<Models.PortsRamp> GetPort(string codePort);

        void InsertPort(Models.PortsRamp port);

        void Save();
    }
}
