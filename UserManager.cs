namespace TrainTicketServices
{
    public class UserManager
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<string>? Roles { get; set; }


        public bool EmailConfirmed { get; set; }


        public string PhoneNumber { get; set; }
        public string DiscountCategory { get; set; }
    }
}
