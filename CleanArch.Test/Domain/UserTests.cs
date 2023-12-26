using CleanArch.Domain.Entities;
using CleanArch.Domain.Enums;
using Moq;
using System;
using Xunit;

namespace CleanArch.Tests.Entities
{
    public class UserTests
    {
        [Theory]
        [InlineData("John", "john@example.com", true, "123 Street, City", "1234567890", "Male", "john_doe", "password", "password", true, true)]
        [InlineData("Sarah", "sarah@example.com", false, "456 Avenue, Town", "9876543210", "Female", "sarah_smith", "pass1234", "pass1234", false, true)]
        public void User_ConstructsCorrectly(
            string name, string email, bool status, string address, string phone,
            string gender, string username, string password, string confirmPassword,
            bool enabled, bool isActive)
        {
            // Arrange
            var userGroup = new Group(); // Replace Group() with your actual Group instance or mock

            // Act
            var user = new User
            {
                Name = name,
                Email = email,
                Status = status ? Status.Active : Status.Inactive,
                Address = address,
                Phone = phone,
                Gender = gender,
                Username = username,
                Password = password,
                ConfirmPassword = confirmPassword,
                Enabled = enabled,
                IsActive = isActive,
                UserGroup = userGroup
            };

            // Assert
            Assert.Equal(name, user.Name);
            Assert.Equal(email, user.Email);
            Assert.Equal(status ? Status.Active : Status.Inactive, user.Status);
            Assert.Equal(address, user.Address);
            Assert.Equal(phone, user.Phone);
            Assert.Equal(gender, user.Gender);
            Assert.Equal(username, user.Username);
            Assert.Equal(password, user.Password);
            Assert.Equal(confirmPassword, user.ConfirmPassword);
            Assert.Equal(enabled, user.Enabled);
            Assert.Equal(isActive, user.IsActive);
            Assert.Equal(userGroup, user.UserGroup);
        }
    }
}
