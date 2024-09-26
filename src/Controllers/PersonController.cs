// This file will be replaced later with a sign in and sign up apis.

using FusionTech.src.Entity;
using FusionTech.src.utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        public static List<Person> people = new List<Person>
        {
            new Customer("cus", "Ran@mail.com", "pass1", "+966561111111", "Path", 25),
            new StoreEmployee(
                "emp",
                "emp@mail.com",
                "pass2",
                "+966561111112",
                "Path",
                "role",
                15000,
                3
            ),
            new SystemAdmin(
                "adm",
                "adm@mail.com",
                "pass3",
                "+966561111113",
                "Path",
                true,
                true,
                true,
                true
            ),
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
            return Ok(people.FirstOrDefault(p => p.PersonId.Equals(id)));
            // 200
        }

        [HttpPost]
        public ActionResult RegisterCustomer(
            string name,
            string email,
            string password,
            string number,
            string _,
            int age
        )
        {
            var newCustomer = new Customer(name, email, password, number, string.Empty, age);
            people.Add(newCustomer);
            return CreatedAtAction(
                nameof(GetPerson),
                new { id = newCustomer.PersonId },
                newCustomer
            );
        }

        [HttpPost("login")]
        public ActionResult SignInCustomer(string email, string password)
        {
            var newCustomer = people.Find(p => p.PersonEmail.Equals(email));
            if (newCustomer == null)
            {
                return NotFound("User doesn't exists");
            }
            if (!newCustomer.trySignIn(password))
            {
                return NotFound("Wrong Password");
            }
            return CreatedAtAction(
                nameof(GetPerson),
                new { id = newCustomer.PersonId },
                newCustomer
            );
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            Customer? customer = people.FirstOrDefault(p => p.PersonId == id) as Customer;
            if (customer == null)
            {
                return NotFound();
            }

            people.Remove(customer);
            return NoContent();
        }

        [HttpPut("{id}/birthday")]
        public ActionResult IncrementAge(int id)
        {
            Customer? customer = people.FirstOrDefault(p => p.PersonId == id) as Customer;
            if (customer == null)
            {
                return NotFound();
            }

            customer.Age += 1;
            return Ok(customer);
        }
    }
}
