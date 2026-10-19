using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetBookmarkById([FromRoute] Guid id)
        {
            return Ok(new
            {
                BookmarkId = id,
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        [HttpPost]
        public IActionResult CreateBookmark()
        {
            return Ok(new
            {
                BookmarkId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBookmark([FromRoute] Guid id)
        {
            return Ok(new
            {
                BookmarkId = id,
                Message = "Bookmark removed successfully.",
            });
        }
    }
}
