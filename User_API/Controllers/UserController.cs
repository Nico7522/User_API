﻿using Microsoft.AspNetCore.Mvc;
using User_API.Models;
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
        public ActionResult CreateUser(User newUser) {
            User u = new(Method.IncrementId() ,newUser.FirstName, newUser.LastName, newUser.Email, newUser.Password);
           
            int userCountBeforeAdd = _fakeDbTableUser.Count;
            _fakeDbTableUser.Add(u);

            if (userCountBeforeAdd == _fakeDbTableUser.Count)
                return BadRequest(false);

            return Ok(true);
        
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, User userToUpdate)
        {
            int userPosition = _fakeDbTableUser.FindIndex(u => u.Id == id);
            if (userPosition != -1)
            {
                _fakeDbTableUser[userPosition] = userToUpdate;
                return BadRequest(false);
            }

            return Ok(true);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            bool isDeleted = false;
            int userCountBeforeDelete = _fakeDbTableUser.Count();
            User? userToDelete = _fakeDbTableUser.SingleOrDefault(u => u.Id == id);

            if (userToDelete is null)
            {
                return NotFound(false);

            } else
            {
                isDeleted = _fakeDbTableUser.Remove(userToDelete);
            }

            return isDeleted ? Ok(true) : BadRequest(false);

        }
    }
   
}
