using Microsoft.EntityFrameworkCore;
using Dat154_Oblig4_Library;

namespace BookingSystem.Repository
{
    public class BookingsRepository
    {

        public interface IBookingsRepository
        {
            DbSet<Booking> GetAll();
            Booking Get(int id);
             
            List<Booking> GetByRoomnumber(int nr);
        }

        public class BookingRepository : IBookingsRepository
        {
            private dat154_2022_6Context dx = new();

            public Booking Get(int id)
            {
                return dx.Bookings.Find(id);
            }

            public DbSet<Booking> GetAll()
            {
                return dx.Bookings;
            }

            public List<Booking> GetByRoomnumber(int nr)
            {
                return dx.Bookings.Where(x => x.Roomnr == nr).ToList(); 
            }
        }
    }
}
