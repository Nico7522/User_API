using User_API.Interfaces;
using User_API.Utils;

namespace User_API.Models
{
    public static class FakeDb 
    {
        public static List<User> Users = new List<User>()
        {
            new User(Method.IncrementId(),"Nicolas", "D'Addabbo", "nico.d@gmail.com", "Test123123=", ""),
            new User(Method.IncrementId(),"Jean", "Dupont", "jean.dupont@gmail.com", "MotDePasse123=", ""),
            new User(Method.IncrementId(), "Marie", "Martin", "marie.martin@gmail.com", "Password456=", ""),
            new User(Method.IncrementId(), "Pierre", "Durand", "pierre.durand@gmail.com", "SecurePass789=", ""),
            new User(Method.IncrementId(), "Emma", "Johnson", "emma.j@gmail.com", "UserPass321=", ""),
            new User(Method.IncrementId(), "Alex", "Smith", "alex.smith@gmail.com", "12345678Ab=", ""),
            new User(Method.IncrementId(), "Sophie", "Taylor", "sophie.t@gmail.com", "PassSophie987=", ""),
            new User(Method.IncrementId(), "Thomas", "Anderson", "thomas.a@gmail.com", "MatrixPass123=", ""),
            new User(Method.IncrementId(), "Laura", "Williams", "laura.w@gmail.com", "Secure123Pass=", ""),
            new User(Method.IncrementId(), "Samuel", "Jones", "sam.j@gmail.com", "JonesPass789=", ""),
            new User(Method.IncrementId(), "Eva", "Brown", "eva.b@gmail.com", "BrownEva456=", ""),
        };

    

    }
}
