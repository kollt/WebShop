
namespace WebShop.DAL.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Categories? Categories { get; set; } 

        public string? Description { get; set; }

        public double? Price { get; set; }
    }
}
