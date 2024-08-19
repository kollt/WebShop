using System;
using System.Collections.Generic;


namespace WebShop.DAL.Entities
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Products>? Products { get; set; }
    }
}
