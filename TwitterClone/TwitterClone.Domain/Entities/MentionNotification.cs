using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionByUserId) : base("Mention")
        {
              MentionedByUserId = mentionByUserId;
        }

        public Guid MentionedByUserId { get; set; }
        public override string GetMessage()
        {
            return $"You were mentioned in a tweet by UserId{MentionedByUserId}.";
        }
    }
}
