using Data.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
        public void InsertData(AppDbContext context)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Script", "radvolontera.sql");
            var query = File.ReadAllText(path);
            context.Database.ExecuteSqlRaw(query);
        }
    }
}

