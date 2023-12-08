using User_API.Models;

namespace User_API.Interfaces
{
    public interface IFakeDb
    {
        static List<User> Users { get; set; }
    }
}
