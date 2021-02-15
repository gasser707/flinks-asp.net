using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace flinks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlinksController : ControllerBase
    {

        [HttpGet]
       public async Task<IActionResult> Get()
        {
            return Ok("Hello from Flinks server!");
        }

        [HttpPost]
        public async Task<IActionResult> post(String message)
        {
            return Ok("Flinks server heard: " +  message);
        }
        
        
    }
}