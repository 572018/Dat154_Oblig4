using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;

namespace BookingSystem.Repositories
{

    public interface IRoomRepository
    {
        public IEnumerable<Room> GetAllRooms();
        public Room getRoomByRoomNumber(int number);
    }


    public class RoomRepository : IRoomRepository
    {
        private dat154_2022_6Context dx = new();
        public IEnumerable<Room> GetAllRooms()
        {
            return dx.Rooms.AsNoTracking().AsEnumerable();
        }

        public Room getRoomByRoomNumber(int number)
        {
            return dx.Rooms.Find(number);
        }
    }
}
