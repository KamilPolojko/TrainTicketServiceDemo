
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketServices.Controllers
{
    [ApiController]
    [Route("api/1/train-routes")]
    public class TrainRoutesManagerController : ControllerBase
    {

        private readonly ILogger<TrainRoutesManagerController> _logger;

        public TrainRoutesManagerController(ILogger<TrainRoutesManagerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTicketManager")]
        public IEnumerable<TrainRoutesManager> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new TrainRoutesManager
            {
                    Name = "Bilet 1",
                    BaseStation = "Krakow",
                    Destination = "Warszawa",
                    TravelStartTime = new DateTime(2023, 12, 2, 6, 26, 32),
                    TravelFinishTime = new DateTime(2023, 12, 2, 9, 56, 45),
                    TotalTravelTime = new TimeOnly(3, 30),
                    TrainSerialNumber = new List<int>() { 51189 },
                    ChangeoversCount = 0
            })
                .ToArray();
        }
    }
}