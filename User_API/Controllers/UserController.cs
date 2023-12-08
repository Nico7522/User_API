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
    }
   
}
