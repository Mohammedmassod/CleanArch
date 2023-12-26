using System;
using CleanArch.Domain.Enums;

namespace CleanArch.Application.DTOs.User
{
    public class UserResponseDTO
    {
        public int Id { get; set; } // Assuming Id is the primary key for the User entity

        public string Name { get; set; }

        public string Email { get; set; }

        public Status Status { get; set; }

        public DateTime BirthDate { get; set; }

        // Other properties...
        // (Address, Phone, Gender, Username, Enabled, IsActive, UserGroupId)
    }
}
