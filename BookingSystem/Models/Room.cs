using System;
using System.Collections.Generic;
using BookingSystem.ExtensionMethods;

namespace BookingSystem
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public Room (int numberOfBeds, RoomSize roomSize)
        {
            Beds = numberOfBeds;
            Size = roomSize;
            Price = Extensions.CalculateRoomPrize(this);
        }

        public int Roomnr { get; set; }
        public int Beds { get; set; }
        public RoomSize Size { get; set; }
        public int? Price { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }

       
    }
    public enum RoomSize
    {
        small,
        medium,
        large
    }
}
