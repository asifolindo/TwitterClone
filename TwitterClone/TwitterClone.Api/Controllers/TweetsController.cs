using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly ITweetService _tweetService;

        public TweetsController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            var tweet = _tweetService.GetTweets();

            return Ok(tweet);
        }

        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetService.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }
            return Ok(tweet);
        }



        [HttpPost]
        public IActionResult CreateTweet([FromBody]CreateTweetDto createTweetDto)
        {
            var createdTweet = _tweetService.CreateTweet(createTweetDto);

            if (createdTweet == null)
            {
                return BadRequest("Invalid tweet data or user does not exist.");
            }

            return Ok(createdTweet);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute]Guid id, [FromBody]CreateTweetDto createTweetDto)
        {
            var tweet = _tweetService.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }

            tweet.Content = createTweetDto.Content;

            return Ok(tweet);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute]Guid id)
        {
            var tweet = _tweetService.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }

             var isDeleted = _tweetService.DeleteTweet(id);

            return Ok(isDeleted);
        }
        

        
    }
}
