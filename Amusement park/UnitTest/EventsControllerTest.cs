using Amusement_park;
using Amusement_park.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class EventsControllerTest
    {
        [Fact]
        public void GetAll_ReturnListOfUsers()
        {
            var controller = new CustomerController();
            var result = controller.Get();
            Assert.IsType<ActionResult<IEnumerable<Customer>>>(result);
           
        }

        [Fact]
        public void Get_ReturnUsers()
        {
            var id = 1;
            var controller = new CustomerController();
            var result = controller.Get(id);
            Assert.IsType<ActionResult<Customer>>(result);
            //Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Post_ReturnUsers()
        {

            Customer obj = new Customer("329145916","eli","eli@gmail.com","033213232","123pw",new DateTime(),10,"old");
            var controller = new CustomerController();
            bool result = controller.Post(obj).Value;
            Assert.True(result);
        }
        [Fact]
        public void Put_ReturnUsers()
        {
            var id = 5;
            Customer obj = new Customer("329145916", "eli", "eli@gmail.com", "033213232", "123pw", new DateTime(), 10, "new");
            var controller = new CustomerController();
            bool result = controller.Put(id, obj).Value;
            Assert.False(result);
        }
    }
}
