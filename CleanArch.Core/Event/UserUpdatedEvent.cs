using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class UserUpdatedEvent : DomainEvent
    {
        public int UserId { get; private set; }
        public string UpdatedUsername { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public UserUpdatedEvent(int userId, string updatedUsername)
        {
            UserId = userId;
            UpdatedUsername = updatedUsername;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
