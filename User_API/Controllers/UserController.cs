using Microsoft.AspNetCore.Mvc;
using User_API.Mappers;
using User_API.Models;
using User_API.Models.DTO;
using User_API.Utils;

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
            if (users is null)
                return NotFound();

            return Ok(users);

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
        public ActionResult CreateUser(UserCreateDTO newUser) {
            User u = new(Method.IncrementId() ,newUser.FirstName, newUser.LastName, newUser.Email, newUser.Password, newUser.Pseudo);
           
            int userCountBeforeAdd = _fakeDbTableUser.Count;
            _fakeDbTableUser.Add(u);

            if (userCountBeforeAdd == _fakeDbTableUser.Count)
                return BadRequest();

            return Ok();
        
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDTO userToUpdate)
        {
            int userPosition = _fakeDbTableUser.FindIndex(u => u.Id == id);
            if (userPosition == -1)
                return NotFound();

            _fakeDbTableUser[userPosition] = userToUpdate.ToUser(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            User? userToDelete = _fakeDbTableUser.SingleOrDefault(u => u.Id == id);
            bool isDeleted = _fakeDbTableUser.Remove(userToDelete);
            return isDeleted ? Ok() : BadRequest();

        }

        [HttpPatch("update/firstname/{id}")]
        public ActionResult UpdateFirstName(int id, string newFirsName)
        {

            User? user = Method.FindUser(id);
            if (user == null)
                return BadRequest();


            if (!user.Patch(newFirsName, user, "FirstName"))
                return BadRequest();

            return Ok();

        }

        [HttpPatch("update/lastname/{id}")]
        public ActionResult UpdtaeLastName(int id, string newLastName)
        {

            User? user = Method.FindUser(id);
            if (user == null)
                return BadRequest();


            if (!user.Patch(newLastName, user, "LastName"))
                return BadRequest();

            return Ok();

        }

        [HttpPatch("update/password/{id}")]
        public ActionResult UpdatePassword(int id, string newPassword)
        {

            User? user = Method.FindUser(id);
            if (user == null)
                return BadRequest();


          if(!user.Patch(newPassword, user, "Password"))
                return BadRequest();

          return Ok();

        }

        [HttpPatch("update/email/{id}")]
        public ActionResult UpdateEmail(int id, string newEmail)
        {

            User? user = Method.FindUser(id);
            if (user == null)
                return BadRequest();


            if (!user.Patch(newEmail, user, "Email"))
                return BadRequest();

            return Ok();

        }
    }
   
}
