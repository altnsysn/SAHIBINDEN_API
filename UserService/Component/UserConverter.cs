using UserService.Dto;
using UserService.Entity;

namespace UserService.Component
{
    public class UserConverter
    {
        public List<UserDTO> UserToUserDTO(List<User> users)
        {
            List<UserDTO> ret = new List<UserDTO>();
            foreach (var user in users) 
            {
                ret.Add(new UserDTO() { Name = user.Name, Email = user.Email });
            }
            return ret;
        }
    }
}
