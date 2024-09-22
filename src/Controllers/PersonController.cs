// This file will be replaced later with a sign in and sign up apis.

using backend.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace backend.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        public static List<Person> people = new List<Person>
        {
            new Customer("cus", "Ran@mail.com", "+966561111111", 25),
            new StoreEmployee("emp", "emp@mail.com", "+966561111112", 8),
            new SystemAdmin("adm", "adm@mail.com", "+966561111113", true, true, true, true),
        };

        [HttpGet]
        public ActionResult GetAllPeople()
        {
            return Ok(people);
            // 200
        }

        [HttpGet("{id}")]
        public ActionResult GetPerson(int id)
        {
            return Ok(people.FirstOrDefault(p => p.Person_Id.Equals(id)));
            // 200
        }

        [HttpPost]
        public ActionResult RegisterCustomer(string name, string email, string number, int age)
        {
            var newCustomer = new Customer(name, email, number, age);
            people.Add(newCustomer);
            return CreatedAtAction(
                nameof(GetPerson),
                new { id = newCustomer.Person_Id },
                newCustomer
            );
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            Customer? customer = people.FirstOrDefault(p => p.Person_Id == id) as Customer;
            if (customer == null)
            {
                return NotFound();
            }

            people.Remove(customer);
            return NoContent();
        }

        [HttpPut("{id}/birthday")]
        public ActionResult incrementAge(int id)
        {
            Customer? customer = people.FirstOrDefault(p => p.Person_Id == id) as Customer;
            if (customer == null)
            {
                return NotFound();
            }

            customer.Age += 1;
            return Ok(customer);
        }
    }
}