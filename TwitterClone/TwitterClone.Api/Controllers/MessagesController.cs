using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetMessageById([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "Message content " + id.ToString(),
                SentAt = DateTime.UtcNow,
                IsRead = false
            });
        }

        [HttpPost]
        public IActionResult SendMessage()
        {
            return Ok(new
            {
                MessageId = Guid.NewGuid(),
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "New message content",
                SentAt = DateTime.UtcNow,
                IsRead = false
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMessage([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "Updated message content " + id.ToString(),
                ModifiedAt = DateTime.UtcNow,
            });
        }

        [HttpPatch("{id}/read")]
        public IActionResult MarkMessageAsRead([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                IsRead = true,
            });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMessage([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                Message = "Message Deleted Successfully."
            });
        }
    }
}
