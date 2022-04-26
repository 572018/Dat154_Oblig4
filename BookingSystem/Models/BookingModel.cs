using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }     
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }

        public int RoomNumber { get; set; }

        public string EmailAdress { get; set; } 

        public BookingModel(DateOnly checkInDate, DateOnly checkOutDate, int roomNumber, string emailAddress)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomNumber = roomNumber;
            EmailAdress = emailAddress;
        }
    }

}
