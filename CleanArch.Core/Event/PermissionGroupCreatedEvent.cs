using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionGroupCreatedEvent : DomainEvent
    {
        public int PermissionGroupId { get; private set; }
        public string PermissionGroupName { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public PermissionGroupCreatedEvent(int permissionGroupId, string permissionGroupName)
        {
            PermissionGroupId = permissionGroupId;
            PermissionGroupName = permissionGroupName;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
