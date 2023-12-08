namespace User_API.Models
{
    public class User
    {
        #nullable disable
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _pseudo;
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = (value != null) ? value : _firstName+_lastName; }

        public User(string firstName, string lastName, string email, string password)
        {
            _id = _id + 1;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
         
        }

        public User(string firstName, string lastName, string email, string password, string pseudo) : this(firstName, lastName, email, password)
        {
            _pseudo = pseudo;
        }

    }
}
