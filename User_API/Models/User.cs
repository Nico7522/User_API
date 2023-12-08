using System.Reflection;
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
        public int Id { get => _id;  }
        public string FirstName { get => _firstName; private set => _firstName = value; }
        public string LastName { get => _lastName; private set => _lastName = value; }
        public string Email { get => _email; private set => _email = value; }
        public string Password { get => _password; private set => _password = value; }
        public string Pseudo { get => _pseudo; private set => _pseudo = value; }

        #endregion

        #region Ctor

        [JsonConstructor]
        public User(int id, string firstName, string lastName, string email, string password, string pseudo) 
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            Email = email;
            _password = password;
            _pseudo = string.IsNullOrEmpty(pseudo) ? firstName.Substring(0, 2) + lastName.Substring(0, 2) : pseudo  ;
         
        }


        #endregion

        #region Method
        public bool Patch<T>(T value, User user, string fieldType)
        {
            Type type = user.GetType();
            PropertyInfo property = type.GetProperty(fieldType);
            if (property is not null)
            {
                property.SetValue(user, value);
                return true;
            }
            return false;

        }

        #endregion



    }

}
