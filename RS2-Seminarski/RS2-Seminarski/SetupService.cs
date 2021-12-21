using Data.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Seminarski
{
    public class SetupService
    {
        public void Init(AppDbContext context)
        {
            context.Database.Migrate();

            //add new new data or update data
            
        }
    }
}

