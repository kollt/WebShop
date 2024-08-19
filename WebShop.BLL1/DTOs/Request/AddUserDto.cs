using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Request
{
    public class AddUserDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Orders>? Orders { get; set; }
    }
}
