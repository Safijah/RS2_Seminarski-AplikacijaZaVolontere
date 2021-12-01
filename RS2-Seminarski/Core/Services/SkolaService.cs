using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class SkolaService :ISkolaService
    {
        private AppDbContext _appDbContext;
        public SkolaService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Skola> Get()
        {
            return _appDbContext.Skola.Where(a=>a.TipSkoleID==3).ToList();
        }

    }
}
