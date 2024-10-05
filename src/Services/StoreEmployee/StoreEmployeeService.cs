using AutoMapper;
using FusionTech.src.Config;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.src.Services.StoreEmployee
{
    public class StoreEmployeeService : IStoreEmployeeService
    {
        protected readonly PersonRepository _personRepo;

        protected readonly StoreEmployeeRepository _storeEmployeeRepo;
        protected readonly SystemAdminRepository _systemAdminRepository;
        protected readonly IMapper _mapper;

        public StoreEmployeeService(
            PersonRepository personRepo,
            StoreEmployeeRepository storeEmployeeRepo,
            SystemAdminRepository systemAdminRepository,
            IMapper mapper
        )
        {
            _personRepo = personRepo;
            _storeEmployeeRepo = storeEmployeeRepo;
            _systemAdminRepository = systemAdminRepository;
            _mapper = mapper;
        }

        public async Task<StoreEmployeeSignInDto> CreateOneAsync(
            StoreEmployeeSignUpDTO createDto,
            string adminEmail
        )
        {
            var originalPerson = await _personRepo.FindPersonByEmail(adminEmail);
            var originalSystemAdmin = await _systemAdminRepository.GetByIdAsync(
                originalPerson!.PersonId
            );

            if (!originalSystemAdmin!.ManageSystemAdmins)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            Entity.StoreEmployee storeEmployee = _mapper.Map<
                StoreEmployeeSignUpDTO,
                Entity.StoreEmployee
            >(createDto);
            PasswordUtils.HashPassword(
                createDto.PersonPassword!,
                out string hashedPassword,
                out byte[] salt
            );
            var idCounter = await _personRepo.GetIdCounterAsync(Entity.StoreEmployee.PersonType);
            storeEmployee.PersonId = PersonIdConfig.StoreEmployeeStartIndex + idCounter.CurrentId + 1;
            storeEmployee.PersonPassword = hashedPassword;
            storeEmployee.salt = salt;
            Entity.StoreEmployee createdStoreEmployee = await _storeEmployeeRepo.CreateOneAsync(
                storeEmployee
            );
            await _personRepo.UpdatePersonIdCounter(idCounter);
            return _mapper.Map<Entity.StoreEmployee, StoreEmployeeSignInDto>(createdStoreEmployee);
        }

        public async Task<float> ViewSalary(string email)
        {
            var originalPerson = await _personRepo.FindPersonByEmail(email);
            var employee = await _storeEmployeeRepo.GetByIdAsync(originalPerson!.PersonId);
            return employee!.Salary;
        }
    }
}
