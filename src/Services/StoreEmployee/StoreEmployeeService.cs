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

        public async Task<StoreEmployeeSignUpDTO> CreateOneAsync(
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
            storeEmployee.PersonId =
                PersonIdConfig.StoreEmployeeStartIndex + idCounter.CurrentId + 1;
            storeEmployee.PersonPassword = hashedPassword;
            storeEmployee.salt = salt;
            Entity.StoreEmployee createdStoreEmployee = await _storeEmployeeRepo.CreateOneAsync(
                storeEmployee
            );
            await _personRepo.UpdatePersonIdCounter(idCounter);
            return _mapper.Map<Entity.StoreEmployee, StoreEmployeeSignUpDTO>(createdStoreEmployee);
        }

        public async Task<float> ViewSalary(string email)
        {
            var originalPerson = await _personRepo.FindPersonByEmail(email);
            var employee = await _storeEmployeeRepo.GetByIdAsync(originalPerson!.PersonId);
            return employee!.Salary;
        }

        public async Task<List<StoreEmployeeReadDto>> GetAllAsync(
            PaginationOptions paginationOptions
        )
        {
            var storeEmployees = await _storeEmployeeRepo.GetAllAsync();
            var filteredStoreEmployees = storeEmployees
                .Where(c =>
                    c.PersonName.Contains(
                        paginationOptions.Search,
                        StringComparison.OrdinalIgnoreCase
                    )
                    || c.PersonEmail.Contains(
                        paginationOptions.Search,
                        StringComparison.OrdinalIgnoreCase
                    )
                    || (
                        c.PersonPhoneNumber != null
                        && c.PersonPhoneNumber.Contains(
                            paginationOptions.Search,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                )
                .ToList();

            var paginatedStoreEmployees = filteredStoreEmployees
                .Skip(paginationOptions.Offset)
                .Take(paginationOptions.Limit)
                .ToList();
            return _mapper.Map<List<Entity.StoreEmployee>, List<StoreEmployeeReadDto>>(
                paginatedStoreEmployees
            );
        }

        public async Task<int> CountStoreEmployeesAsync()
        {
            return await _storeEmployeeRepo.CountAsync();
        }
    }
}
