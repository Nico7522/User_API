using Microsoft.AspNetCore.Mvc;
using User_API.Models;

namespace User_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly List<User> _fakeDbTableUser = FakeDb.Users;

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUser()
        {
            IEnumerable<User> users = _fakeDbTableUser;
            if (users != null)
                return Ok(users);

            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            User? user = _fakeDbTableUser.SingleOrDefault(u => u.Id == id);

            if (user is null)
                return NotFound("User not found");

            return Ok(user);
        }

        [HttpPost]
        public ActionResult<bool> CreateUser(User newUser) {
            Console.WriteLine(newUser.LastName);
            User u = new User(newUser.Id, newUser.FirstName, newUser.LastName, newUser.Email, newUser.Password);
           
            int userCountBeforeAdd = _fakeDbTableUser.Count();
            _fakeDbTableUser.Add(u);

            if (userCountBeforeAdd < _fakeDbTableUser.Count()) 
                return Ok(true);

            return BadRequest(false);
        
        }

        [HttpPut("{id}")]
        public ActionResult<bool> UpdateUser(int id, User userToUpdate)
        {
            int userPosition = _fakeDbTableUser.FindIndex(u => u.Id == id);
            if (userPosition != -1)
            {
                _fakeDbTableUser[userPosition] = userToUpdate;
                return Ok(true);
            }

            return BadRequest(false);
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteUser(int id)
        {
            bool isDeleted = false;
            int userCountBeforeDelete = _fakeDbTableUser.Count();
            User? userToDelete = _fakeDbTableUser.SingleOrDefault(u => u.Id == id);

            if (userToDelete is not null)
            {
                isDeleted = _fakeDbTableUser.Remove(userToDelete);

            } else
            {
                return NotFound(false);
            }

            return isDeleted ? Ok(true) : BadRequest(false);

        }
    }
   
}
