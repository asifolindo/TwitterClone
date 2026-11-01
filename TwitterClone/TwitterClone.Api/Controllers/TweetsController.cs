using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;

        public TweetsController(TweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }

        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            var tweet = _tweetRepository.GetTweets();

            return Ok(tweet);
        }

        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }
            return Ok(tweet);
        }       

                
        


        [HttpPost]
        public IActionResult CreateTweet([FromBody]CreateTweetDto createTweetDto)
        {
            if(string.IsNullOrWhiteSpace(createTweetDto.Content))
            {
                return BadRequest("Content is required.");
            }

            var tweet = new Tweet(createTweetDto.UserId, createTweetDto.Content);

            var createdTweet = _tweetRepository.AddTweet(tweet);

            return Ok(createdTweet);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute]Guid id, [FromBody]CreateTweetDto createTweetDto)
        {
            var tweet = _tweetRepository.GetTweetById(id);
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
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }

             var isDeleted = _tweetRepository.DeleteTweet(tweet);

            return Ok(isDeleted);
        }
        

        
    }
}
