using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid systemId) : base("System Notification")
        {
            SystemId = systemId;
        }
        public Guid SystemId { get; set; }
    }
}
