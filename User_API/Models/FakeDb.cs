using User_API.Interfaces;

namespace User_API.Models
{
    public static class FakeDb 
    {
        private static int id = 1;
        public static List<User> Users = new List<User>()
        {
            new User(IncrementId(), "Nicolas", "D'Addabbo", "nico.d@gmail.com", "Test123123="),
            new User(IncrementId(),"Jean", "Dupont", "jean.dupont@gmail.com", "MotDePasse123="),
            new User(IncrementId(),"Marie", "Martin", "marie.martin@gmail.com", "Password456="),
            new User(IncrementId(),"Pierre", "Durand", "pierre.durand@gmail.com", "SecurePass789="),
            new User(IncrementId(),"Emma", "Johnson", "emma.j@gmail.com", "UserPass321="),
            new User(IncrementId(),"Alex", "Smith", "alex.smith@gmail.com", "12345678Ab="),
            new User(IncrementId(),"Sophie", "Taylor", "sophie.t@gmail.com", "PassSophie987="),
            new User(IncrementId(),"Thomas", "Anderson", "thomas.a@gmail.com", "MatrixPass123="),
            new User(IncrementId(), "Laura", "Williams", "laura.w@gmail.com", "Secure123Pass="),
            new User(IncrementId(), "Samuel", "Jones", "sam.j@gmail.com", "JonesPass789="),
            new User(IncrementId(), "Eva", "Brown", "eva.b@gmail.com", "BrownEva456="),
        };

        private static int IncrementId()
        {
            return id++;
        }

    }
}
