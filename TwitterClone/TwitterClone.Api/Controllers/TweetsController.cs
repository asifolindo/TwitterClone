using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            return Ok(new List<object>
            {
                new
                {
                    TweetId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Content = "Hello, World!!",
                    CreatedAt = DateTime.UtcNow.AddHours(-2),
                },
                new
                {
                    TweetId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Content = "2nd tweet!",
                    CreatedAt = DateTime.UtcNow.AddHours(-1),
                }
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                UserId = Guid.NewGuid(),
                Content = "tweet" + id.ToString(),
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpPost]
        public IActionResult CreateTweet()
        {
            return Ok(new
            {
                TweetId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Content = "New Tweet",
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute]Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                UserId = Guid.NewGuid(),
                Content = "Updated Tweet" + id.ToString(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute]Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                Message = "Tweet deleted successfully",

            });
        }
        

        
    }
}
