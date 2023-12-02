using UserService.Dto;

namespace UserService.Service.Interface
{
    public interface IUserService
    {
        string Test();

        List<UserDTO> GetUsers();
    }
}
