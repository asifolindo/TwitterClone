using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestByUserId) : base("Friend Request")
        {
            RequestByUserId = requestByUserId;
        }

        public Guid RequestByUserId { get; set; }
    }
}
