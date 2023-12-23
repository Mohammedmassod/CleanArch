using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class UserDeletedEvent : DomainEvent
    {
        public int UserId { get; private set; }
        public string DeletedUsername { get; private set; }
        public DateTime DeletedAt { get; private set; }

        public UserDeletedEvent(int userId, string deletedUsername)
        {
            UserId = userId;
            DeletedUsername = deletedUsername;
            DeletedAt = DateTime.UtcNow;
        }
    }

}
