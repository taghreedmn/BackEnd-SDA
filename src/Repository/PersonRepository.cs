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
            _Person = _databaseContext.Set<Person>();
        }

        public async Task<Person> FindPersonById(int id)
        {
            return await _Person.FindAsync(id);
        }

        public async Task<Person> FindPersonByEmail(string email)
        {
            return await _Person.FirstOrDefaultAsync(e => e.PersonEmail == email);
        }

        public async Task<bool> DeletePersonById(int id)
        {
            var result = await DeletePerson(GetByIdAsync(id).Result);
            return result;
        }

        public async Task<bool> DeletePerson(Person person)
        {
            _Person.Remove(person);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<Person?> GetByIdAsync(int id)
        {
            return await _Person.FindAsync(id);
        }
    }
}
