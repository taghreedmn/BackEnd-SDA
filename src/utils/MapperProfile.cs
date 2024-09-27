using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.PersonDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Utils
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Person mappings
            CreateMap<PersonCreateDto, Person>();
            CreateMap<Person, PersonReadDto>();
            // CreateMap<PersonUpdateDto, Person>();

            // Customer mappings
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<Customer, CustomerReadDto>();
            // CreateMap<CustomerUpdateDto, Customer>();

            // StoreEmployee mappings
            CreateMap<StoreEmployeeCreateDto, StoreEmployee>();
            CreateMap<StoreEmployee, StoreEmployeeReadDto>();
            // CreateMap<StoreEmployeeUpdateDto, StoreEmployee>();

            // SystemAdmin mappings
            CreateMap<SystemAdminCreateDto, SystemAdmin>();
            CreateMap<SystemAdmin, SystemAdminReadDto>();
            // CreateMap<SystemAdminUpdateDto, SystemAdmin>();
        }
    }
}
