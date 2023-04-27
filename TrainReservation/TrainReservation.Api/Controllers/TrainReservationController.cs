using Microsoft.AspNetCore.Mvc;
using TrainReservation.Domain;
using TrainReservation.Domain.Requests;

namespace TrainReservation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainReservationController : ControllerBase
    {
        private readonly IService _service;
        private readonly ILogger<TrainReservationController> _logger;

        public TrainReservationController(ILogger<TrainReservationController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("book")]
        public IActionResult BookSeats(BookTrainSeatsRequest request)
        {
            var response = _service.Book(request);

            return Ok(response);
        }
    }


}