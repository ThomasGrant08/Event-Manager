namespace PlanAhead.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public DateTime eventTime { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Postcode { get; set; }

        public Event()
        {

        }
    }
}
