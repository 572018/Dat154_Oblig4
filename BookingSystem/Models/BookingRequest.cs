namespace BookingSystem.Models
{
    public class BookingRequest
    {

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int NumberOfBeds { get; set; }

    }
}
