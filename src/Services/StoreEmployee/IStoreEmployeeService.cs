
namespace FusionTech.src.Services.StoreEmployee
{
    public interface IStoreEmployeeService
    {
        Task<StoreEmployeeSignUpDTO> CreateOneAsync(StoreEmployeeSignUpDTO createDto, string email);
        Task<float> ViewSalary(string email);
        Task<int> CountStoreEmployeesAsync();
        Task<List<StoreEmployeeReadDto>> GetAllAsync(PaginationOptions paginationOptions);
    }
}
