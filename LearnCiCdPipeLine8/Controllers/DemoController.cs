using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnCiCdPipeLine8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase

    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("CI/CD Demo Working 🚀");
        }

        [HttpGet("time")]
        public IActionResult GetTime()
        {
            return Ok(DateTime.Now);
        }
    }
}
