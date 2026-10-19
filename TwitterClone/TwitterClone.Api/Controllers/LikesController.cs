using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetLikeById([FromRoute] Guid id)
        {
            return Ok(new
            {
                LikeId = id,
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public IActionResult CreateLike()
        {
            return Ok(new
            {
                LikeId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLike([FromRoute] Guid id)
        {
            return Ok(new
            {
                LikeId = id,
                Message = "Like deleted successfully",
            });
        }
    }
}
