using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.src.Services.StoreEmployee
{
    public interface IStoreEmployeeService
    {
        Task<StoreEmployeeSignInDto> CreateOneAsync(StoreEmployeeSignUpDTO createDto, string email);
        Task<float> ViewSalary(string email);
    }
}
