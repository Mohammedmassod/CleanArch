using System;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs.User
{
    public class UserRequestDTO
    {
        [Required(ErrorMessage = "Please provide a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide an email.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        // Add other necessary fields for creating or updating a user
    }
}
