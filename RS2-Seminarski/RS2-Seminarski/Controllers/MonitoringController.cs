using Core.Interfaces;
using Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Seminarski.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MonitoringController : ControllerBase
    {
        private IMonitoringService _monitoringService;
        public MonitoringController(IMonitoringService monitoringService)
        {
            _monitoringService = monitoringService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(MonitoringVM vm)
        {
           var result= await _monitoringService.InsertAsync(vm);
            return Ok(result);
        }
    }
}
