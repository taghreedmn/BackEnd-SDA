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
            if (foundPerson == null)
            {
                throw new KeyNotFoundException("Person not found.");
            }
            return _mapper.Map<Entity.Person, PersonSignInDTO>(foundPerson);
        }

        public async Task<int> GetIdByEmailAsync(string email)
        {
            var person = await _personRepository.FindPersonByEmail(email);

            return person!.PersonId;
        }

        public async Task<bool> UpdateNameAsync(string email, string name)
        {
            var person = await _personRepository.FindPersonByEmail(email);
            person!.PersonName = name;
            var result = await _personRepository.UpdateAsync(person);
            return result;
        }

        public async Task<bool> EditPassword(string email, string oldPassword, string newPassword)
        {
            var person = await _personRepository.FindPersonByEmail(email);
            if (!PasswordUtils.isPasswordEqual(oldPassword, person!.PersonPassword, person.salt))
            {
                throw new UnauthorizedAccessException("Old password does not match.");
            }
            PasswordUtils.HashPassword(newPassword, out string hashedPassword, out byte[] salt);
            person.PersonPassword = hashedPassword;
            person.salt = salt;
            var result = await _personRepository.UpdateAsync(person);

            return result;
        }

        public async Task<bool> EditPhone(string email, string newPhone)
        {
            var person = await _personRepository.FindPersonByEmail(email);
            person!.PersonPhoneNumber = newPhone;
            var result = await _personRepository.UpdateAsync(person);
            return result;
        }

        public async Task<bool> EditProfilePicture(string email, string picturePath)
        {
            var person = await _personRepository.FindPersonByEmail(email);
            person!.ProfilePicturePath = picturePath;
            var result = await _personRepository.UpdateAsync(person);
            return result;
        }

        public async Task<string> SignInAsync(PersonSignInDTO personSignInDTO)
        {
            var foundPerson = await _personRepository.FindPersonByEmail(
                personSignInDTO.PersonEmail
            );

            if (foundPerson == null)
            {
                throw new UnauthorizedAccessException("Wrong Email or Password"); // Yes, I'm lying here
            }
            bool isMatched = PasswordUtils.isPasswordEqual(
                personSignInDTO.PersonPassword,
                foundPerson.PersonPassword,
                foundPerson.salt
            );
            if (!isMatched)
            {
                throw new UnauthorizedAccessException("Invalid credentials.");
            }
            var tokenUtils = new TokenUtils(_config);
            return tokenUtils.generateToken(foundPerson);
        }
    }
}
