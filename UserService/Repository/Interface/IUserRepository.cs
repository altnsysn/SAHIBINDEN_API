using UserService.Dto;
using UserService.Entity;

namespace UserService.Repository.Interface
{
    public interface IUserRepository
    {
        List<UserDTO> GetAllUser();

        User AddNewUser(UserSingUpDTO singUpDTO);

    }
}
