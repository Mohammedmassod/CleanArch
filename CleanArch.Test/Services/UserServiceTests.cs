using CleanArch.Application.Helpers;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CleanArch.Application.Tests.Services
{
    public class UserServiceTests
    {
        // إستخدام [Theory] بدلاً من [Fact]
        [Theory]
        [InlineData(1)] // بيانات الإدخال للاختبار
        [InlineData(2)]
        [InlineData(1000)]
        public async Task GetUserById_Should_Return_Correct_User(int userId)
        {
            // Arrange
            var expectedUser = GetExpectedUser(userId); // احضار المستخدم المتوقع بناءً على الهوية

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var userService = new UserService(mockUnitOfWork.Object);

            mockUnitOfWork.Setup(uow => uow.Users.GetByIdAsync(userId)).ReturnsAsync(expectedUser);

            // Act
            var result = await userService.GetById(userId);

            // Assert
            if (userId == 999) // في حالة المستخدم الغير موجود
            {
                Assert.False(result.Success);
                Assert.Null(result.Result);
            }
            else // في حالة المستخدم الموجود
            {
                Assert.True(result.Success);
                Assert.Equal(expectedUser, result.Result);
            }
        }

        // دالة تعيد المستخدم المتوقع بناءً على الهوية
        private User GetExpectedUser(int userId)
        {
            // قم بإعادة المستخدم المتوقع بناءً على الهوية المحددة
            // يمكنك استخدام بيانات مختلفة هنا للمستخدمين المتوقعين لكل اختبار
            return new User { Id = userId, Name = "Test User " + userId };
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1000)]
        public async Task UpdateUser_Should_Update_User(int userId)
        {
            // Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var userService = new UserService(mockUnitOfWork.Object);

            var updatedUser = GetUpdatedUser(userId); // احضار المستخدم المحدث بناءً على الهوية

            //mockUnitOfWork.Setup(uow => uow.Users.UpdateAsync(updatedUser)).ReturnsAsync(true);
            mockUnitOfWork.Setup(uow => uow.Users.UpdateAsync(It.IsAny<User>())).ReturnsAsync("Updated successfully");

            // Act
            var result = await userService.Update(updatedUser);

            // Assert
            Assert.True(result.Success);
            Assert.Equal("User updated successfully.", result.Result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1000)]
        public async Task DeleteUser_Should_Delete_User(int userId)
        {
            // Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var userService = new UserService(mockUnitOfWork.Object);

            // mockUnitOfWork.Setup(uow => uow.Users.DeleteAsync(userId)).ReturnsAsync(true);
            //mockUnitOfWork.Setup(uow => uow.Users.DeleteAsync(It.IsAny<User>())).ReturnsAsync("Updated successfully"); // Act
            mockUnitOfWork.Setup(uow => uow.Users.DeleteAsync(It.IsAny<int>())).ReturnsAsync("Updated successfully");

            var result = await userService.Delete(userId);

            // Assert
            Assert.True(result.Success);
            Assert.Equal("User deleted successfully.", result.Result);
        }

        [Fact]
        public async Task GetAllUsers_Should_Return_All_Users()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Id = 1, Name = "User 1" },
                new User { Id = 2, Name = "User 2" },
                // Add more users for testing different scenarios
            };

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var userService = new UserService(mockUnitOfWork.Object);

            mockUnitOfWork.Setup(uow => uow.Users.GetAllAsync()).ReturnsAsync(users);

            // Act
            var result = await userService.GetAll();

            // Assert
            Assert.True(result.Success);
            Assert.Equal(users, result.Result);
        }

        // دالة تعيد المستخدم المحدث بناءً على الهوية
        private User GetUpdatedUser(int userId)
        {
            // قم بإعادة المستخدم المحدث بناءً على الهوية المحددة
            // يمكنك استخدام بيانات مختلفة هنا للمستخدمين المحدثين لكل اختبار
            return new User { Id = userId, Name = "Updated User " + userId };
        }
    }
}
