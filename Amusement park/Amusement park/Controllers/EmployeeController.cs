using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService employeeService =new EmployeeService();

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return employeeService.Get();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee e = employeeService.GetById(id);
            if (e == null)
                return NotFound();
            return e;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post(Employee e)
        {
            return employeeService.Add(e);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,Employee e)
        {
            return employeeService.Update(id,e);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return employeeService.Remove(id);
        }
    }
}
