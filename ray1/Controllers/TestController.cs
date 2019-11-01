using System;
using Microsoft.AspNetCore.Mvc;

namespace ray1.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new { name = "Raybest AND AYORINDE and tosin" });
        }
    }
}
