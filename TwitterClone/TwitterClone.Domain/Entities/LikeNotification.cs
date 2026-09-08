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


        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";
        }

        public override string GetMessage()
        {
            return $"UserId {LikeByUserId} liked your post";
        }
    }
}
