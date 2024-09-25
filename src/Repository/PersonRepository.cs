using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class PersonRepository
    {
        protected DbSet<Person> _Person;
        protected DatabaseContext _databaseContext;

        public PersonRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Person> LogIn(string email, string password)
        {
            Person? person = await _Person.FirstOrDefaultAsync(p => p.PersonEmail == email);
            if (person == null)
            {
                // return NotFound("User doesn't exists");
                throw new Exception();
            }
            if (!person.trySignIn(password))
            {
                // return NotFound("Wrong Password");
                throw new Exception();
            }
            return person;
        }

        public async Task<Person> FindPersonById(int id)
        {
            return await _Person.FindAsync(id);
        }

        public async Task<bool> DeletePersonById(int id)
        {
            return DeletePerson(FindPersonById(id).Result).Result;
        }

        public async Task<bool> DeletePerson(Person person)
        {
            _Person.Remove(person);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
