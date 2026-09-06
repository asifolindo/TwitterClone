using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class ShareNotification : Notification
    {
        public ShareNotification(Guid shareByUserId) : base("Share")
        {
            ShareByUserId = shareByUserId;
        }
        public Guid ShareByUserId { get; set; }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, ShareByUserId: {ShareByUserId}";
        }
        public override string GetMessage()
        {
            return $"UserId {ShareByUserId} shared your post";
        }
    }
}
