using BookingSystem.ExtensionMethods;

namespace BookingSystem.Models
{
    public class RoomModel
    {
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public RoomSize RoomSize { get; set; }

        public bool NiceView { get; set; }

        public int RoomPrice { get; set; }

        public RoomModel(int numberOfBeds, RoomSize roomSize, bool niceView)
        {
            NumberOfBeds = numberOfBeds;
            RoomSize = roomSize;
            NiceView = niceView;

            RoomPrice = Extensions.CalculateRoomPrize(this);
           }
    }
    public enum RoomSize
    {
        small,
        medium,
        large
    }
}
