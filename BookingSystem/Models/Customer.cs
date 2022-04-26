using System;
using System.Collections.Generic;

namespace BookingSystem
{
    public partial class Customer
    {
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;

        public Customer(string emailAddress, string name, string password)
        {
            Email = emailAddress;
            Name = name;
            Password = password;
        }
    }
}
