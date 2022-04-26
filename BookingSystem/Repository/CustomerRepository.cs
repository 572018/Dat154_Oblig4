using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;

namespace BookingSystem.Repository
{

    public interface ICustomerRepository
    {
        DbSet<Booking> GetAllBookingsForCustomer(string email);
        DbSet<Customer> GetAllCustomers();

        Customer GetCustomer(string email);
        void AddCustomer(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        private dat154_2022_6Context dx = new();

        public void AddCustomer(Customer customer)
        {
            dx.Customers.Add(customer);
            dx.SaveChanges();
        }

        DbSet<Booking> ICustomerRepository.GetAllBookingsForCustomer(string email)
        {
            throw new NotImplementedException();
        }

        DbSet<Customer> ICustomerRepository.GetAllCustomers()
        {
            return dx.Customers;
        }

        Customer ICustomerRepository.GetCustomer(string email)
        {

            return dx.Customers.Find(email);




        }
    }
}
