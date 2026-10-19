using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetNotificationById([FromRoute] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                UserId = Guid.NewGuid(),
                Type = "Like",
                Message = "Notification message " + id.ToString(),
                IsRead = false,
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpPost]
        public IActionResult CreateNotification()
        {
            return Ok(new
            {
                NotificationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Type = "System",
                TriggeredByUserId = Guid.NewGuid(),
                Message = "System Notification: Unknown Error",
                IsRead = false,
                CreatedAt = DateTime.UtcNow,
            });
        }


        [HttpPatch("{id}/read")]
        public IActionResult MarkNotificationAsRead([FromRoute] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                IsRead = true,
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification([FromRoute] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                Message = "Notification deleted.",
            });
        }

    }
}
