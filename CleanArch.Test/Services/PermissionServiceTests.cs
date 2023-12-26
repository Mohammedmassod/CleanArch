using CleanArch.Application.Helpers;
using CleanArch.Application.IServices;
using CleanArch.Application.Services;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Enums;
using CleanArch.Application.IRepositores;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CleanArch.Tests.Services
{
    public class PermissionServiceTests
    {
        private Mock<IPermissionRepository> _mockPermissionRepository;

        private PermissionService _permissionService;

        public PermissionServiceTests()
        {
            _mockPermissionRepository = new Mock<IPermissionRepository>();
            _permissionService = new PermissionService(_mockPermissionRepository.Object);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1000)]
        public async Task GetById_Should_Return_Correct_Permission(int permissionId)
        {
            // Arrange
            var expectedPermission = GetExpectedPermission(permissionId);
            _mockPermissionRepository.Setup(repo => repo.GetByIdAsync(permissionId)).ReturnsAsync(expectedPermission);

            // Act
            var result = await _permissionService.GetById(permissionId);

            // Assert
            if (permissionId == 999) // Non-existent permission
            {
                Assert.False(result.Success);
                Assert.Null(result.Result);
            }
            else
            {
                Assert.True(result.Success);
                Assert.Equal(expectedPermission, result.Result);
            }
        }

        // Helper function to create expected permission based on ID
        private Permission GetExpectedPermission(int permissionId)
        {
            // Return the expected permission based on the given ID
            // return new Permission { Id = permissionId, Name = "Test Permission " + permissionId };
            return new Permission("NameValue", "DescriptionValue", PermissionLevel.Admin);

        }

        // Add similar tests for Add, Update, Delete, and GetAll methods, following the same structure
    }
}