using UserService.Dto;
using UserService.Entity;

namespace UserService.Service.Interface
{
    public interface IUserService
    {
        string Test();

        List<UserDTO> GetUsers();

        User SingUp(UserSingUpDTO singUpDTO);
    }
}
