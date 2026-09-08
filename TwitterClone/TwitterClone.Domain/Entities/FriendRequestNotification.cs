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

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestByUserId: {RequestByUserId}";
        }

        public override string GetMessage()
        {
            return $"UserId {RequestByUserId} sent you a friend request";
        }
    }
}
