using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionUpdatedEvent : DomainEvent
    {
        public int PermissionId { get; private set; }
        public string UpdatedPermissionName { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public PermissionUpdatedEvent(int permissionId, string updatedPermissionName)
        {
            PermissionId = permissionId;
            UpdatedPermissionName = updatedPermissionName;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
