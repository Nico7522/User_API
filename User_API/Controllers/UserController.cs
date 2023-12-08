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
    }
   
}
