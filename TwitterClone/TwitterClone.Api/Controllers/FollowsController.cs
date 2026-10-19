using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetFollowById([FromRoute] Guid id)
        {
            return Ok(new
            {
                FollowId = id,
                FollowerId = Guid.NewGuid(),
                FollowingId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        [HttpGet("followers/{userId}")]
        public IActionResult GetFollowers([FromRoute] Guid userId)
        {
            return Ok(new List<object>
            {
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "follower1",
                },
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "follower2",
                },
            });
        }

        [HttpGet("following/{userId}")]
        public IActionResult GetFollowing([FromRoute] Guid userId)
        {
            return Ok(new List<object>
            {
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "following1",
                },
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "following2",
                },
            });
        }

        [HttpPost]
        public IActionResult CreateFollow()
        {
            return Ok(new
            {
                FollowId = Guid.NewGuid(),
                FollowerId = Guid.NewGuid(),
                FollowingId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFollow([FromRoute] Guid id)
        {
            return Ok(new
            {
                FollowId = id,
                Message = "Follow deleted successfully",
            });
        }
    }
}