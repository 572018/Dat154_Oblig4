using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;


namespace BookingSystem.Repositories
{

    public interface ICustomerRepository
    {
       public DbSet<Booking> GetAllBookingsForCustomer(string email);
       public DbSet<Customer> GetAllCustomers();

       public Customer GetCustomer(string email);
       public void AddCustomer(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        private dat154_2022_6Context dx = new();

        public void AddCustomer(Customer customer)
        {
            dx.Customers.Add(customer);
            dx.SaveChanges();
        }

        public DbSet<Booking> GetAllBookingsForCustomer(string email)
        {
            throw new NotImplementedException();
        }

        public DbSet<Customer> GetAllCustomers()
        {
            return dx.Customers;
        }

        public Customer GetCustomer(string email)
        {
            return dx.Customers.Find(email);
        }
    }
}
