using BlazorTickets.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BlazorTickets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketRepository _ticketrepo;

        public TicketsController(TicketRepository ticketrepository)
        {
            _ticketrepo = ticketrepository;

        }
        [HttpGet]
        public async Task<ActionResult>Get()
        {
            var tickets = await _ticketrepo.GetAllWithTagsAndResponses();
            return Ok(tickets);
        }
    }
}
