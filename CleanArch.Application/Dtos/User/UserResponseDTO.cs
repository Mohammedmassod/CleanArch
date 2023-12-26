using CleanArch.Domain.Enums;
using System;

namespace CleanArch.Application.DTOs.User
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }

        // Add other necessary fields for responding with user information
    }
}
