using System;
using CleanArch.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs.User
{
    public class UserRequestDTO
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "يرجى إدخال عنوان بريد إلكتروني.")]
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح.")]
        public string Email { get; set; }

        public Status Status { get; set; }
        public DateTime BirthDate { get; set; }

        // Other properties...
        // (Address, Phone, Gender, Username, Password, ConfirmPassword, Enabled, IsActive, UserGroup)
    }
}
