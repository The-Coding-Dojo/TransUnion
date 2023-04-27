using Castle.Core.Logging;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using TrainReservation.Api.Controllers;
using TrainReservation.Domain;
using TrainReservation.Domain.Requests;
using TrainReservation.Domain.Responses;

namespace TrainReservation.Api.Tests.Controller
{
    public class TrainReservationControllerTests
    {
        private readonly TrainReservationController _controller;

        private readonly Mock<ILogger<TrainReservationController>> _logger;
        private readonly Mock<IService> _service;

        public TrainReservationControllerTests()
        {
            _service = new Mock<IService>();
            _logger = new Mock<ILogger<TrainReservationController>>();
            this._controller = new TrainReservationController(_logger.Object, _service.Object);
        }

        [Fact]
        public void Book_ReturnsResponseFromService()
        {
            var responseFromService = new BookTrainSeatsResponse();
            var request = new BookTrainSeatsRequest();
            _service
                .Setup(service => service.Book(It.IsAny<BookTrainSeatsRequest>()))
                .Returns(responseFromService);

            var response = _controller.BookSeats(request);

            response.Should().BeOfType<OkObjectResult>();
            var responseResult = response as OkObjectResult;
            responseResult.Value.Should().BeEquivalentTo(responseFromService);
        }
    }
}