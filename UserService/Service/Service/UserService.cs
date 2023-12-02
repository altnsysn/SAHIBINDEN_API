using UserService.Dto;
using UserService.Entity;
using UserService.Repository.Interface;
using UserService.Service.Interface;

namespace UserService.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public List<UserDTO> GetUsers()
        {
            return userRepository.GetAllUser();
        }

        public User SingUp(UserSingUpDTO singUpDTO)
        {
            return userRepository.AddNewUser(singUpDTO);
        }

        public string Test()
        {
            return "ServieTEST";
        }
    }
}
