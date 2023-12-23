using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    using global::CleanArch.Domain.Common;
    using System;

    namespace CleanArch.Domain.Events
    {
        public class UserGroupDeletedEvent : DomainEvent
        {
            public int GroupId { get; private set; }
            public string GroupName { get; private set; }
            public DateTime DeletedAt { get; private set; }

            public UserGroupDeletedEvent(int groupId, string groupName)
            {
                GroupId = groupId;
                GroupName = groupName;
                DeletedAt = DateTime.UtcNow;
            }
        }
    }

}
