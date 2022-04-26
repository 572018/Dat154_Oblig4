namespace BookingSystem.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }     
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }

        public int RoomNumber { get; set; }

        public string EmailAdress { get; set; } 


    }
}
