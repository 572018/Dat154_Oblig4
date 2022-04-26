using BookingSystem.Models;
using BookingSystem.Repositories;

namespace BookingSystem.Services
{
    public  class CustomerService
    {
        public bool ValidatePassword(string password, Customer customer)
        {
            return password!= null && customer != null && password == customer.Password;
        }

        public  Customer getConsumerByEmail(string email)
        {
            return null;
        }

    }
}
