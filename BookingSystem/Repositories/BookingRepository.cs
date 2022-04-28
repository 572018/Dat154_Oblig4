using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;
namespace BookingSystem.Repositories
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
    }
    public class BookingRepository : IBookingRepository

    {
        private dat154_2022_6Context dx = new();


        public void AddBooking(Booking booking)
        {
            dx.Bookings.Add(booking);
            dx.SaveChanges();
        }
    }
}

