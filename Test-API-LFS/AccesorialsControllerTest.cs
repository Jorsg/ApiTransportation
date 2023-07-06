using apilfs.Controllers;
using apilfs.Repository.Accessorial;
using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace TestAPI_LFS
{
    public class AccesorialsControllerTest
    {

        private readonly Mock<IAccesorials> repo = new Mock<IAccesorials>();

        [Fact]
        public void Get_WhenCalled_ReturnAllAccesorials()
        {
            //Arrange
            repo.Setup(r => r.GetAccessorials());

            var item = new AccesorialsController(repo.Object);

            //Act
            var result = item.GetAccesorials();

            //Assert            
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_WhenCalledExistAccesorils_ReturnOneAccesorials()
        {
            //Arrange
            repo.Setup(r => r.GetAccessorials(It.IsAny<string>()));

            var item = new AccesorialsController(repo.Object);

            //Act
            var result = item.GetAccesorials();

            //Assert            
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
