﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public  interface IVDraftsAll
    {
       IQueryable<Models.VDraftsAll> GetDraftsAll(int idDraft);
    }
}
