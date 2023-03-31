using Day2.BL.Dtos.Tickets;
using Day2.BL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day2.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsManager _tickesManager;

        public TicketsController(ITicketsManager tickesManager)
        {
            _tickesManager = tickesManager;
        }

        [HttpGet]
        public ActionResult<List<TicketReadDto>> GetAll()
        {
            return _tickesManager.GetAll();
        }

        [HttpPost]
        public ActionResult Add(TicketAddDto doctorDto)
        {
            _tickesManager.Add(doctorDto);
            return NoContent();
        }
    }
}
