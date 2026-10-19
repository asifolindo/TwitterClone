using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<object>
            {
                new { Id = Guid.NewGuid(), Username = "muhin", Email = "muhin@example.com", CreatedAt = DateTime.UtcNow},
                new { Id = Guid.NewGuid(), Username = "User2", Email = "user2@example.com", CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), Username = "User3", Email = "user3@example.com", CreatedAt = DateTime.UtcNow }  
            };
            return Ok(users);
        }


        [HttpPost]
        [AllowAnonymous]

        public IActionResult CreateUser()
        {
            return Ok(new
            {
                UserId = Guid.NewGuid(),
                Username = "NewUser"
            });
        }



        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute]Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "User" + id.ToString()
            });
        }


        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute]Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "UpdatedUser" + id.ToString()
            });
        }

        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok("hello");
        }


        [HttpDelete("{id}")]
                public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "User deleted successfully"
            });
        }

    }
}
