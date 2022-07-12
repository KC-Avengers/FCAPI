using fcapi.DTO;
using fcapi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fcapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly FcMRPComp01Context _fcMRPComp01Context;
        public EventController(FcMRPComp01Context fcMRPComp01Context)
        {
            _fcMRPComp01Context = fcMRPComp01Context;
        }
        [HttpGet("GetAllEvent")]
        public IActionResult GetAllEvent()
        {
            var result = new Result();
            try
            {
                
            }
            catch (Exception ex)
            {
            }
            return Ok(result);
        }

        
    }
}
