using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralCounterController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRequestsCount()
        {
            var count = GeneralCounter.RequestCounter;
             return Ok(count) ;
        }
    }
}
