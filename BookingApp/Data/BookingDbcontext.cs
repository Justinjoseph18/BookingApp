using BookingApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Data
{
    public class BookingDbcontext:DbContext
    {
        public BookingDbcontext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            {
            }

        }
        public DbSet<DeliveryDetails> Delivery_Detils { get; set; }
        public DbSet<OrderDetails>Order_Details { get; set; }
        public DbSet<PersonalDetails> Personal_Details { get; set; }


    }
}
