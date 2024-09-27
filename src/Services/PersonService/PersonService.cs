using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.Service.PersonService
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
            return _mapper.Map<Person, PersonReadDto>(foundPerson);
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
