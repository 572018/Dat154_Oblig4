using BookingSystem.Models;
using BookingSystem.Repositories;
namespace BookingSystem.Services
{
    public interface IBookingService
    {
        public void AddBooking(Booking booking);
    }

    public class BookingService : IBookingService

    {
         private readonly IBookingRepository _bookingRepository;

    

     public void AddBooking(Booking booking)
     {
        _bookingRepository.AddBooking(booking);

    }
}
}
