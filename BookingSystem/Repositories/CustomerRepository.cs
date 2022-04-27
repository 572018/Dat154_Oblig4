using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;


namespace BookingSystem.Repositories
{

    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        IEnumerable<Booking> GetAllBookingsForCustomer(string email);
        Customer GetCustomer(string email);
    }
    public class CustomerRepository : ICustomerRepository
    {

        private dat154_2022_6Context dx = new();

        public void AddCustomer(Customer customer)
        {
            dx.Customers.Add(customer);
            dx.SaveChanges();
        }

        public IEnumerable<Booking> GetAllBookingsForCustomer(string email)
        {
            throw new NotImplementedException();
        }


        public Customer GetCustomer(string email)
        {
            return dx.Customers.Find(email);
        }
    }
}