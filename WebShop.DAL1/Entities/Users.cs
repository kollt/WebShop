using System;
using System.Collections.Generic;

namespace WebShop.DAL.Entities
{
    public class Users
    {
        public long Id { get; set; }    
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Orders>? Orders { get; set; }
    }
}
