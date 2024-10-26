namespace BookingApp.Models.Domain
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
    }
}
