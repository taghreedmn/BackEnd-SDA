using AutoMapper;
using FusionTech.src.Config;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.CustomerDTO;

namespace FusionTech.Service.CustomerService
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

        public async Task<CustomerReadDto> CreateOneAsync(CustomerCreateDto createDto)
        {
            // TODO: Check if password and other information are valid
            Customer customer = _mapper.Map<CustomerCreateDto, Customer>(createDto);
            customer.PersonId = await _CustomerRepo.GetNextIdCustomerAsync();
            Customer categoryCreated = await _CustomerRepo.CreateOneAsync(customer);
            return _mapper.Map<Customer, CustomerReadDto>(categoryCreated);
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
