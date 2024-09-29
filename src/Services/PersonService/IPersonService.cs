using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.Service.PersonService
{
    public interface IPersonService
    {
        Task<PersonReadDto> GetByIdAsync(int id);
        Task<PersonReadDto> SignIn(string email, string password);
        Task<bool> EditProfilePicture(int personId, string picturePath);
        Task<bool> EditPassword(int personId, string oldPassword, string newPassword);
        Task<bool> EditPhone(int personId, string newPhone);
    }
}
