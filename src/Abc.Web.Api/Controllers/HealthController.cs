﻿using Microsoft.AspNetCore.Mvc;

namespace Abc.Web.Api.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet("health")]
        public IActionResult IsHealthy()
        {
            return Ok();
        }
    }
}
