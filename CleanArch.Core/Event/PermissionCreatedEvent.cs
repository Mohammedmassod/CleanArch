using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class PermissionCreatedEvent : DomainEvent
    {
        public int PermissionId { get; private set; }
        public string PermissionName { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public PermissionCreatedEvent(int permissionId, string permissionName)
        {
            PermissionId = permissionId;
            PermissionName = permissionName;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
