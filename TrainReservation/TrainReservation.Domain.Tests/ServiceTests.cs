using TrainReservation.Domain.Requests;
using TrainReservation.Domain.Responses;

namespace TrainReservation.Domain.Tests
{
    public class ServiceTests
    {
        private readonly Service _service;

        public ServiceTests()
        {
            _service = new Service();
        }

        [Fact]
        public void Book()
        {
            var request = new BookTrainSeatsRequest();
            var expectedResponse = new BookTrainSeatsResponse();

            var response = _service.Book(request);

            response.Should().BeEquivalentTo(expectedResponse);
        }
    }
}