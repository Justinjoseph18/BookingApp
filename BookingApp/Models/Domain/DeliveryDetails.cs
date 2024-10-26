namespace BookingApp.Models.Domain
{
    public class DeliveryDetails
    {
        public Guid Id { get; set; }
        public string AgentName { get; set; }
        public int AgentNumber { get; set; }

        public OrderDetails OrderDetails { get; set; }
    }
}
