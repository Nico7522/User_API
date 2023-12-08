using User_API.Models;

namespace User_API.Utils
{
    public static class Method
    {

        private static int _id = 0;

        public static int IncrementId()
        {
            return ++_id;
        }

        public static User FindUser(int id)
        {
            User user = FakeDb.Users.SingleOrDefault(u => u.Id == id);
            return user;

        }
    }
}
