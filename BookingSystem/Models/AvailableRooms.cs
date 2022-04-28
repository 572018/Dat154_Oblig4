namespace BookingSystem.Models
{
    public class AvailableRooms
    {
        public IEnumerable<Room> rooms { get; set; }
        public Booking ? booking { get; set; }    
    }
}
