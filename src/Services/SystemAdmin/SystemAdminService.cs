using AutoMapper;
using FusionTech.src.Config;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Services.SystemAdmin
{
    public class SystemAdminService : ISystemAdminService
    {
        protected readonly PersonRepository _personRepo;
        protected readonly CustomerRepository _customerRepo;

        // protected readonly StoreEmployeeRepository _storeEmployeeRepo;
        protected readonly SystemAdminRepository _systemAdminRepository;
        protected readonly IMapper _mapper;

        public SystemAdminService(
            PersonRepository personRepo,
            CustomerRepository customerRepo,
            // StoreEmployeeRepository storeEmployeeRepo,
            SystemAdminRepository systemAdminRepository,
            IMapper mapper
        )
        {
            _customerRepo = customerRepo;
            _personRepo = personRepo;
            // _storeEmployeeRepo = storeEmployeeRepo;
            _systemAdminRepository = systemAdminRepository;
            _mapper = mapper;
        }

        public Task<bool> AddGame()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGame()
        {
            throw new NotImplementedException();
        }

        public async Task<SystemAdminReadDto> CreateOneAsync(
            SystemAdminSignUpDTO createDto,
            string email
        )
        {
            var originalPerson = await _personRepo.FindPersonByEmail(email);
            var originalSystemAdmin = await _systemAdminRepository.GetByIdAsync(
                originalPerson!.PersonId
            );

            if (!originalSystemAdmin!.ManageSystemAdmins)
            {
                throw CustomException.Forbidden("Admin not authorized");
            }

            Entity.SystemAdmin systemAdmin = _mapper.Map<SystemAdminSignUpDTO, Entity.SystemAdmin>(
                createDto
            );
            PasswordUtils.HashPassword(
                createDto.PersonPassword!,
                out string hashedPassword,
                out byte[] salt
            );
            var idCounter = await _personRepo.GetIdCounterAsync(Entity.SystemAdmin.PersonType);
            systemAdmin.PersonId = PersonIdConfig.SystemAdminStartIndex + idCounter.CurrentId + 1;
            systemAdmin.PersonPassword = hashedPassword;
            systemAdmin.salt = salt;
            Entity.SystemAdmin createdSystemAdmin = await _systemAdminRepository.CreateOneAsync(
                systemAdmin
            );
            await _personRepo.UpdatePersonIdCounter(idCounter);
            return _mapper.Map<Entity.SystemAdmin, SystemAdminReadDto>(createdSystemAdmin);
        }

        public async Task<bool> DeletePersonAsync(int id, string adminEmail)
        {
            var toBeDeletedPerson = await _personRepo.GetByIdAsync(id);
            if (toBeDeletedPerson == null)
            {
                throw CustomException.NotFound("Person not found");
            }
            var adminPerson = await _personRepo.FindPersonByEmail(adminEmail);
            var admin = await _systemAdminRepository.GetByIdAsync(adminPerson!.PersonId);
            switch (PersonTypeUtils.GetPersonType(toBeDeletedPerson))
            {
                case Entity.PersonType.SystemAdmin:
                    if (admin!.ManageSystemAdmins)
                        return await _personRepo.DeletePerson(toBeDeletedPerson);
                    throw CustomException.Forbidden("Admin not authorized");
                case Entity.PersonType.StoreEmployee:
                    if (admin!.ManageEmployees)
                        return await _personRepo.DeletePerson(toBeDeletedPerson);
                    throw CustomException.Forbidden("Admin not authorized");
                case Entity.PersonType.Customer:
                    if (admin!.ManageCustomers)
                        return await _personRepo.DeletePerson(toBeDeletedPerson);
                    throw CustomException.Forbidden("Admin not authorized");
                default:
                    throw new ArgumentNullException(
                        "Something is wrong, the type of the person is undefined"
                    );
            }
        }
    }
}
