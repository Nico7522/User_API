namespace User_API.Models.DTO
{
    public class UserUpdateDTO
    {
        public UserUpdateDTO(string firstName, string lastName, string email, string password, string? pseudo)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Pseudo = pseudo;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string? Pseudo { get; set; }
    }
}
