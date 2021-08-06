using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateLimitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateLimits2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(new { Id = 1, Category = "paper-work" });
        }
    }
}
