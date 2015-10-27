﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Security.DataContext;
using HCMIS.Security.Models;

namespace HCMIS.Security.Repository
{
    public class JobTitleRepository : GenericRepository<SecurityContext, JobTitle>
    {
        public JobTitleRepository(SecurityContext context)
        {
            this.Context = context;
        }
    }
}
