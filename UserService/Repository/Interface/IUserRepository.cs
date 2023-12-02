using UserService.Dto;

namespace UserService.Repository.Interface
{
    public interface IUserRepository
    {
        List<UserDTO> GetAllUser();

    }
}
