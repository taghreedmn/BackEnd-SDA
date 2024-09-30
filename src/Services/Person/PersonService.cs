using AutoMapper;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.Service.Person
{
    public class PersonService : IPersonService
    {
        private readonly PersonRepository _personRepository;
        protected readonly IMapper _mapper;

        public PersonService(PersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<PersonReadDto> GetByIdAsync(int id)
        {
            var foundPerson = await _personRepository.GetByIdAsync(id);
            // Naming it only Person makes the compiler get confused between the namespace and the Person class
            return _mapper.Map<src.Entity.Person, PersonReadDto>(foundPerson);
        }

        public Task<bool> EditPassword(int personId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditPhone(int personId, string newPhone)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProfilePicture(int personId, string picturePath)
        {
            throw new NotImplementedException();
        }

        public Task<PersonReadDto> SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
