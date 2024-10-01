using AutoMapper;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.CustomerDTO;

namespace FusionTech.src.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        protected readonly CustomerRepository _CustomerRepo;

        protected readonly IMapper _mapper;

        public CustomerService(CustomerRepository CustomerRepo, IMapper mapper)
        {
            _CustomerRepo = CustomerRepo;
            _mapper = mapper;
        }

        public async Task<CustomerReadDto> CreateOneAsync(CustomerSignUpDTO createDto)
        {
            // TODO: Check if password and other information are valid
            Entity.Customer customer = _mapper.Map<CustomerSignUpDTO, Entity.Customer>(createDto);
            PasswordUtils.HashPassword(
                createDto.PersonPassword!,
                out string hashedPassword,
                out byte[] salt
            );
            customer.PersonId = await _CustomerRepo.GetNextIdCustomerAsync();
            customer.PersonPassword = hashedPassword;
            customer.salt = salt;
            Entity.Customer categoryCreated = await _CustomerRepo.CreateOneAsync(customer);
            return _mapper.Map<Entity.Customer, CustomerReadDto>(categoryCreated);
        }

        public Task<bool> UpdateAgeAsync(int customerId, int age)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNameAsync(int customerId, string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> OrderGameAsync(int customerId, int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
