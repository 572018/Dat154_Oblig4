
using BookingSystem.Models;

namespace BookingSystem.ExtensionMethods
{
    public static class Extensions
    {
        public static int CalculateRoomPrize(this Room room)
        {
            return room.Size switch
            {
                RoomSize.small => 300 + Math.Min(0, (room.Beds - 1)) * 200,
                RoomSize.medium => 600 + Math.Min(0, (room.Beds - 2)) * 200,
                RoomSize.large => 1200 + Math.Min(0, (room.Beds - 2)) * 200,
                _ => 0,
            };
        }

    }
}
