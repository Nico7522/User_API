using System.Text.Json.Serialization;
using User_API.Utils;

namespace User_API.Models
{
    public class User
    {
#nullable disable

        #region Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _pseudo;

        #endregion

        #region Properties
        public int Id { get => _id; }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string Email { get => _email; }
        public string Password { get => _password; }
        public string Pseudo { get => _pseudo; }

        #endregion

        #region Ctor

        [JsonConstructor]
        public User(int id, string firstName, string lastName, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _pseudo = firstName.Substring(0, 2) + lastName.Substring(0, 2);
            _id = id;
         
        }

        public User(int id, string firstName, string lastName, string email, string password, string pseudo) : this(id, firstName, lastName, email, password)
        {
            _pseudo = pseudo;
        }

        #endregion



    }

}
