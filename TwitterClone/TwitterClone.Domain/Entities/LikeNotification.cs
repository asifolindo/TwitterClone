using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }
        public Guid LikeByUserId { get; set; }
    }
}
