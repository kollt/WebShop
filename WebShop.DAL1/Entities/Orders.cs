using System;
using System.Collections.Generic;

namespace WebShop.DAL.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public Users? User { get; set; }
        public List<OrderItems>? OrderItems { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
