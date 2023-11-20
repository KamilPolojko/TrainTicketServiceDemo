namespace TrainTicketServices
{
    public class RoutesDataManager
    {
        public string Name { get; set; }
        public string BaseStation { get; set; }
        public string Destination { get; set;}
        public DateTime TravelStartTime { get; set;}
        public DateTime TravelFinishTime { get; set;}
        public TimeOnly TotalTravelTime { get; set;}

        public List<int> TrainSerialNumber { get; set;}

        public int ChangeoversCount { get; set; }

    }
}
