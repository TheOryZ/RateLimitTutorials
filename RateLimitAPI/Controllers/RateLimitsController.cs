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
    public class RateLimitsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            //We sent a product info back for testing.
            return Ok(new { Id = 1, Name = "Pencil", Price = 20 });
        }
    }
}
