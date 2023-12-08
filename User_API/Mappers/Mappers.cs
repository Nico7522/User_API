using User_API.Models;
using User_API.Models.DTO;
using User_API.Utils;

namespace User_API.Mappers
{
    internal static class Mappers
    {
        internal static User ToUser(this UserUpdateDTO user, int id)
        {
            return new User(id, user.FirstName, user.LastName, user.Email, user.Password, user.Pseudo);
        }

        internal static User ToUser(this UserCreateDTO user)
        {
            return new User(Method.IncrementId(),user.FirstName, user.LastName, user.Email, user.Password, user.Pseudo);
        }

    }
}
