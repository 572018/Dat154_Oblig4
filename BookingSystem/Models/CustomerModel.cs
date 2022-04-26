using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Models
{
    public class CustomerModel
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }   
        public string Password { get; set; }

        public CustomerModel(string emailAddress, string name, string password)
        {
            EmailAddress = emailAddress;   
            Name = name;
            Password = password;
        }

    }

}
