using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PersonInfo.Api.Controllers;
using PersonInfo.Contract.Views;
using PersonInfo.Service;

namespace PersonInfo.Api.Test
{
    public class SectorControllerTests
    {
        private Mock<ILogger<SectorController>> _loggerMock;
        private Mock<ISectorService> _sectorServiceMock;
        private SectorController _sut;

        [SetUp]
        public void Setup()
        {
            _loggerMock = new Mock<ILogger<SectorController>>();
            _sectorServiceMock = new Mock<ISectorService>();

            _sut = new SectorController(
                _loggerMock.Object, 
                _sectorServiceMock.Object);
        }

        [Test]
        public async Task GetAllSectors()
        {
            // arrange
            _sectorServiceMock.Setup(x => x.GetAllInstancesAsync()).ReturnsAsync(
                new List<SectorView>
                {
                    new()
                    {
                        Id = -1,
                        ParentId = -1,
                        IsParent = true,
                        Level = 1,
                        Name = "Select Sector"
                    },
                    new()
                    {
                        Id = 1,
                        ParentId = -1,
                        IsParent = false,
                        Level = 2,
                        Name = "Sector 1"
                    },
                    new()
                    {
                        Id = 2,
                        ParentId = -1,
                        IsParent = false,
                        Level = 2,
                        Name = "Sector 2"
                    }
                });

            //act
            var actionResult = await _sut.AllAsync();

            Assert.IsInstanceOf<OkObjectResult>(actionResult);
        }

        [Test]
        public async Task GetAllSectorsShouldReturnNoContentForEmptyResult()
        {

            //act
            var actionResult = await _sut.AllAsync();

            Assert.IsInstanceOf<NoContentResult>(actionResult);
        }
    }
}