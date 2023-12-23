using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    using System;

    namespace CleanArch.Domain.Events
    {
        public class UserGroupCreatedEvent : DomainEvent
        {
            public int GroupId { get; private set; }
            public string GroupName { get; private set; }
            public DateTime CreatedAt { get; private set; }

            public UserGroupCreatedEvent(int groupId, string groupName)
            {
                GroupId = groupId;
                GroupName = groupName;
                CreatedAt = DateTime.UtcNow;
            }
        }
    }

}
