using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class GradService: IGradService 
    {
        private AppDbContext _appDbContext;
        public GradService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       public List<Grad> Get()
        {
            return _appDbContext.Grad.ToList();
        }

    }
}
