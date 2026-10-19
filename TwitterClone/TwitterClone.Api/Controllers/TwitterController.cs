using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {

        private IConfiguration _configuration;

        public TwitterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet("My first tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "Hello World"
                },
                new Tweet("My second tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "22222222"
                }
            };

            return Ok(tweets);
        }
    }
}
