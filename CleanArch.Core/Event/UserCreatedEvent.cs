using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Event
{
    public class UserCreatedEvent : DomainEvent
    {
        public int UserId { get; private set; }
        public string Username { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public UserCreatedEvent(int userId, string username)
        {
            UserId = userId;
            Username = username;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
