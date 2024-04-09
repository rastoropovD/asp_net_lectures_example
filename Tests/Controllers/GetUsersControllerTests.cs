using System;
using System.Collections.Generic;
using System.Linq;
using asp_net_lectures_example.Controllers.Users;
using asp_net_lectures_example.Models;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Tests.Controllers;

public sealed class GetUsersControllerTests
{
    [Fact]
    public void UsersController_NoError()
    {
        // Arrange
        Mock<IUsersRepository> userRepositoryMock = new Mock<IUsersRepository>();
        userRepositoryMock
            .Setup(r => r.GetUsers())
            .Returns(new List<UserEntity>()
            {
                new UserEntity(0, "", "", "")
            });
        GetUsersController controller = new GetUsersController(userRepositoryMock.Object);

        // Act
        ViewResult result = controller.UsersList();

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty((IEnumerable<UserViewModel>)result.Model);
    }
    
    [Theory]
    [InlineData(0)]
    public void UsersController_NoError_Cases(int dataCount)
    {
        // Arrange
        List<UserEntity> data = new List<UserEntity>(dataCount);

        for (int i = 0; i < dataCount; i++)
        {
            data.Add(new UserEntity(i, "", "", ""));
        }
        Mock<IUsersRepository> userRepositoryMock = new Mock<IUsersRepository>();
        userRepositoryMock
            .Setup(r => r.GetUsers())
            .Returns(data);
        GetUsersController controller = new GetUsersController(userRepositoryMock.Object);

        // Act
        ViewResult result = controller.UsersList();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(dataCount, ((IEnumerable<UserViewModel>)result.Model).Count());
        // Assert.NotEmpty((IEnumerable<UserViewModel>)result.Model);
    }
}