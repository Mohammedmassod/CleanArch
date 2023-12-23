using CleanArch.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionDeletedEvent : DomainEvent
    {
        public int PermissionId { get; private set; }
        public string DeletedPermissionName { get; private set; }
        public DateTime DeletedAt { get; private set; }

        public PermissionDeletedEvent(int permissionId, string deletedPermissionName)
        {
            PermissionId = permissionId;
            DeletedPermissionName = deletedPermissionName;
            DeletedAt = DateTime.UtcNow;
        }
    }
}
