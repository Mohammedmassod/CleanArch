using CleanArch.Application.Interfaces;
using CleanArch.Application.IServices;
using CleanArch.Application.Services;
using CleanArch.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Test.Services
{
    public class PermissionGroupServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly IGroupService _groupService;

        public PermissionGroupServiceTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _groupService = new GroupService(_mockUnitOfWork.Object);
        }

        // Test for Add method
        [Theory]
        [InlineData("Group Name")]
        public async Task AddGroup_ValidGroup_ReturnsSuccessResponse(string groupName)
        {
            // Arrange
            var group = new Group { Name = groupName };
            _mockUnitOfWork.Setup(uow => uow.Groups.AddAsync(group)).ReturnsAsync("1"); // Simulating successful addition

            // Act
            var response = await _groupService.Add(group);

            // Assert
            Assert.True(response.Success);
            Assert.Equal("Group added successfully.", response.Result);
        }

        // Similarly, write tests for other methods like Update, Delete, GetById, and GetAll using similar arrangements and assertions
    }
}
