using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        TicketsService ticketsService = new TicketsService();

        // GET: api/<TicketController>
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return ticketsService.Get();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            Ticket t = ticketsService.GetById(id);
            if (t == null)
                return NotFound();
            return t;
        }
        // POST api/<TicketController>
        [HttpPost]
        public ActionResult<bool> Post(Ticket t)
        {
            return ticketsService.Add(t);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,Ticket t)
        {
            return ticketsService.Update(id,t);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return ticketsService.Remove(id);
        }
    }
}
