using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetweetsController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetRetweetById([FromRoute] Guid id)
        {
            return Ok(new
            {
                RetweetId = id,
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                Comment = "Retweet comment " + id.ToString(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        [HttpPost]
        public IActionResult CreateRetweet()
        {
            return Ok(new
            {
                RetweetId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                Comment = "New Retweet",
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRetweet([FromRoute] Guid id)
        {
            return Ok(new
            {
                RetweetId = id,
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                Comment = "Updated Retweet comment " + id.ToString(),
                ModifiedAt = DateTime.UtcNow,
            });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteRetweet([FromRoute] Guid id)
        {
            return Ok(new
            {
                RetweetId = id,
                Message = "Retweet deleted successfully",
            });
        }
    }
}
