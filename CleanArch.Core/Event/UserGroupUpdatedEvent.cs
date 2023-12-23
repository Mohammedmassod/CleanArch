using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class UserGroupUpdatedEvent : DomainEvent
    {
        public int GroupId { get; private set; }
        public string UpdatedGroupName { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public UserGroupUpdatedEvent(int groupId, string updatedGroupName)
        {
            GroupId = groupId;
            UpdatedGroupName = updatedGroupName;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
