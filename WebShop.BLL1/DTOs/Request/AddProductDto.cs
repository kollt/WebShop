using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Request
{
    public class AddProductDto
    {
        public string? Name { get; set; }
        public Categories? Categories { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
    }
}
