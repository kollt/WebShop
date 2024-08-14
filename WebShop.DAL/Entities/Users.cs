using System;
using System.Collections.Generic;

namespace WebShop.DAL.Entities
{
    internal class Users
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime RegistrationTime { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
