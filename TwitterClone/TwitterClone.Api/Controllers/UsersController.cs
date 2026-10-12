using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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


    }
}
