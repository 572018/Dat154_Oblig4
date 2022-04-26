
namespace BookingSystem.Models
{
    public static class Extensions
    {
        public static int CalculateRoomPrize(this RoomModel room)
        {
            return room.RoomSize switch
            {
                RoomSize.small => 300 + Math.Min(0, (room.NumberOfBeds - 1)) * 200,
                RoomSize.medium => 600 + Math.Min(0, (room.NumberOfBeds - 2)) * 200,
                RoomSize.large => 1200 + Math.Min(0, (room.NumberOfBeds - 2)) * 200,
                _ => 0,
            };
        }

    }
}
