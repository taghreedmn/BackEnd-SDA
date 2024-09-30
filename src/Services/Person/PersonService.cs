using AutoMapper;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.src.Services.Person
{
    public class PersonService : IPersonService
    {
        private readonly PersonRepository _personRepository;
        protected readonly IMapper _mapper;
        private readonly IConfiguration _config;

        public PersonService(
            PersonRepository personRepository,
            IMapper mapper,
            IConfiguration config
        )
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _config = config;
        }

        public async Task<PersonSignInDTO> GetByIdAsync(int id)
        {
            var foundPerson = await _personRepository.GetByIdAsync(id);
            // Naming it only Person makes the compiler get confused between the namespace and the Person class
            return _mapper.Map<Entity.Person, PersonSignInDTO>(foundPerson);
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

        public async Task<string> SignInAsync(PersonSignInDTO personSignInDTO)
        {
            var foundPerson = await _personRepository.FindPersonByEmail(
                personSignInDTO.PersonEmail
            );
            bool isMatched = PasswordUtils.isPasswordEqual(
                personSignInDTO.PersonPassword,
                foundPerson.PersonPassword,
                foundPerson.salt
            );
            if (!isMatched)
            {
                return "Unauthorized";
            }
            var tokenUtils = new TokenUtils(_config);
            return tokenUtils.generateToken(foundPerson);
        }
    }
}
