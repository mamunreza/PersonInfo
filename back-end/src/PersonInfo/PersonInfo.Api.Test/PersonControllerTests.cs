using Microsoft.Extensions.Logging;
using Moq;
using PersonInfo.Api.Controllers;
using PersonInfo.Service;
using PersonInfo.Contract.Commands;
using PersonInfo.Contract.Views;
using PersonInfo.Data.Model;

namespace PersonInfo.Api.Test
{
    public class PersonControllerTests
    {
        private Mock<ILogger<PersonController>> _loggerMock;
        private Mock<IPersonService> _personServiceMock;
        private PersonController _sut;

        [SetUp]
        public void Setup()
        {
            _loggerMock = new Mock<ILogger<PersonController>>();
            _personServiceMock = new Mock<IPersonService>();

            _sut = new PersonController(
                _loggerMock.Object,
                _personServiceMock.Object);
        }

        [Test]
        public async Task CreatePersonInfo()
        {
            //arrange
            _personServiceMock.Setup(x => x.CreateAsync(It.IsAny<Person>())).ReturnsAsync(
                new PersonView
                {
                    AgreeToTerms = true,
                    Id = 101,
                    SectorId = 7,
                    Name = "Person One",
                    Success = true
                });
            var newPersonCommand = new CreatePersonCommand
            {
                AgreeToTerms = true,
                Name = "Person One",
                SectorId = 7
            };

            //act
            var result = await _sut.CreateAsync(newPersonCommand);

            Assert.IsNotNull(result);
            Assert.True(result.Success);
        }

        [Test]
        public async Task CreatePersonInfoShouldReturnDefaultViewWhenUnSuccessful()
        {
            //arrange
            var newPersonCommand = new CreatePersonCommand
            {
                AgreeToTerms = true,
                Name = "Person One",
                SectorId = 7
            };

            //act
            var result = await _sut.CreateAsync(newPersonCommand);

            Assert.IsNotNull(result);
            Assert.False(result.Success);
        }
    }
}
