
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketServices.Controllers
{
    [ApiController]
    [Route("api/1/manager-users")]
    public class UserManagerController : ControllerBase
    {

        private readonly ILogger<UserManagerController> _logger;

        public UserManagerController(ILogger<UserManagerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUserManager")]
        public IEnumerable<UserManager> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new UserManager
                {
                    UserName="jan12345",
                    Email="jan54321@gmail.com",
                    Password="123456789",
                    FirstName="Jan",
                    LastName = "Kowalski",
                    DateOfBirth= new DateTime(1997,2,28),
                    Roles = new List<string>(){ "zwyk³y klient"},
                    EmailConfirmed = true,
                    PhoneNumber = "607654387",
                    DiscountCategory = "g³uchoniemy"

            })
                .ToArray();
        }
    }
}