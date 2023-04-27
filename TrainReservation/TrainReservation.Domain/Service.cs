using TrainReservation.Domain.Requests;
using TrainReservation.Domain.Responses;

namespace TrainReservation.Domain
{
    public interface IService
    {
        BookTrainSeatsResponse Book(BookTrainSeatsRequest request);
    }

    public class Service : IService
    {
        // TODO Repo
        public BookTrainSeatsResponse Book(BookTrainSeatsRequest request)
        {
            var response = new BookTrainSeatsResponse();
            return response;
        }
    }
}