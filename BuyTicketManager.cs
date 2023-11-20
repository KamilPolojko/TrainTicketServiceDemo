namespace TrainTicketServices
{
    public class BuyTicketManager:RoutesDataManager
    {

        public int Price { get; set; }

        public DateTime PurchaseDate { get;set; }

        public string PurchaseMetod { get; set;}
        public int NumberOfPassengers { get; set; }

    }
}
