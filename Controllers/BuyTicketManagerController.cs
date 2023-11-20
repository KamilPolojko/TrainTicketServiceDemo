
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketServices.Controllers
{
    [ApiController]
    [Route("api/1/manager-tickets")]
    public class BuyTicketManagerController : ControllerBase
    {

        private readonly ILogger<BuyTicketManagerController> _logger;

        public BuyTicketManagerController(ILogger<BuyTicketManagerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTrainRouteManager")]
        public IEnumerable<BuyTicketManager> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new BuyTicketManager
                {
                    Name = "Bilet 1",
                    Price = 15,
                    BaseStation = "Krakow",
                    Destination = "Warszawa",
                    TravelStartTime = new DateTime(2023, 12, 2, 6, 26, 32),
                    TravelFinishTime = new DateTime(2023, 12, 2, 9, 56, 45),
                    TotalTravelTime = new TimeOnly(3, 30),
                    TrainSerialNumber = new List<int>(){51189},
                    ChangeoversCount = 0,
                    PurchaseDate = new DateTime(2023, 12, 2, 4, 13, 16),
                    PurchaseMetod = "blik",
                    NumberOfPassengers = 3
            })
                .ToArray();
        }
    }
}