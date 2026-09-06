using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification : Notification
    {
        public SystemNotification(Guid systemId) : base("System Notification")
        {
            SystemId = systemId;
        }
        public Guid SystemId { get; set; }


        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }

        public override string GetMessage()
        {
            return $"System notification : unknown error.";
        }
    }
}
