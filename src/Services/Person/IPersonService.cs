using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.src.Services.Person
{
    public interface IPersonService
    {
        Task<PersonSignInDTO> GetByIdAsync(int id);
        Task<string> SignInAsync(PersonSignInDTO personSignInDTO);
        Task<bool> EditProfilePicture(int personId, string picturePath);
        Task<bool> EditPassword(int personId, string oldPassword, string newPassword);
        Task<bool> EditPhone(int personId, string newPhone);
    }
}
