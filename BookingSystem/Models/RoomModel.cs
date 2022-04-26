namespace BookingSystem.Models
{
    public class RoomModel
    {

        public int RoomNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public RoomSize RoomSize { get; set; }

        public Boolean NiceView { get; set; } // ?

        public int PricePerNight { get; set; } // ?

    }

    public enum RoomSize
    {

    }
}
