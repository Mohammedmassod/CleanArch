using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionGroupUpdatedEvent : DomainEvent
    {
        public int PermissionGroupId { get; private set; }
        public string UpdatedPermissionGroupName { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public PermissionGroupUpdatedEvent(int permissionGroupId, string updatedPermissionGroupName)
        {
            PermissionGroupId = permissionGroupId;
            UpdatedPermissionGroupName = updatedPermissionGroupName;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
