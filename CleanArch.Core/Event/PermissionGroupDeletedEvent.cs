using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionGroupDeletedEvent : DomainEvent
    {
        public int PermissionGroupId { get; private set; }
        public string DeletedPermissionGroupName { get; private set; }
        public DateTime DeletedAt { get; private set; }

        public PermissionGroupDeletedEvent(int permissionGroupId, string deletedPermissionGroupName)
        {
            PermissionGroupId = permissionGroupId;
            DeletedPermissionGroupName = deletedPermissionGroupName;
            DeletedAt = DateTime.UtcNow;
        }
    }
}
