using User_API.Interfaces;

namespace User_API.Models
{
    public static class FakeDb 
    {

        public static List<User> Users = new List<User>()
        {
            new User("Nicolas", "D'Addabbo", "nico.d@gmail.com", "Test123123="),
            new User("Jean", "Dupont", "jean.dupont@gmail.com", "MotDePasse123="),
            new User("Marie", "Martin", "marie.martin@gmail.com", "Password456="),
            new User("Pierre", "Durand", "pierre.durand@gmail.com", "SecurePass789="),
            new User("Emma", "Johnson", "emma.j@gmail.com", "UserPass321="),
            new User("Alex", "Smith", "alex.smith@gmail.com", "12345678Ab="),
            new User("Sophie", "Taylor", "sophie.t@gmail.com", "PassSophie987="),
            new User("Thomas", "Anderson", "thomas.a@gmail.com", "MatrixPass123="),
            new User("Laura", "Williams", "laura.w@gmail.com", "Secure123Pass="),
            new User("Samuel", "Jones", "sam.j@gmail.com", "JonesPass789="),
            new User("Eva", "Brown", "eva.b@gmail.com", "BrownEva456="),
        };

    }
}
