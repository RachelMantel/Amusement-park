using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomersService customerService=new CustomersService();

        // GET: api/<Customer>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return customerService.Get();
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            Customer c = customerService.GetById(id);
            if (c == null)
                return NotFound();
            return c;
        }
        // POST api/<Customer>
        [HttpPost]
        public ActionResult<bool> Post(Customer c)
        {
           return customerService.Add(c);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,Customer c)
        {
           return customerService.Update(id,c);
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
           return customerService.Remove(id);
        }
    }
}
