using System;
using System.Collections.Generic;

namespace WebShop.DAL.Entities
{
    internal class Orders
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
