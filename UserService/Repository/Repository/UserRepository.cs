using System.Security.AccessControl;
using UserService.Component;
using UserService.Dto;
using UserService.Entity;
using UserService.Repository.Interface;

namespace UserService.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>() { new User { Id = 1, Name = "Atacan", Email="atacanakats@outlook.com",Password="TESTPW" },
                                                      new User { Id = 2, Name = "Yasin", Email="yasin@outlook.com",Password="TESTPWYasin" }}; 

        private readonly UserConverter userConverter;

        public UserRepository()
        {
            this.userConverter = new UserConverter();
        }

        public List<UserDTO> GetAllUser()
        {
            return userConverter.UserToUserDTO(users);
        }

        public User AddNewUser(UserSingUpDTO singUpDTO)
        {
            var user = userConverter.SingUpDtoToUser(singUpDTO);
            users.Add(user);
            return user;
        }
    }
}
