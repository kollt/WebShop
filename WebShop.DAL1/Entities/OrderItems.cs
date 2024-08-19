
namespace WebShop.DAL.Entities
{
    public class OrderItems
    {
        public int? Id { get; set; }
        public Orders? Order { get; set; }

        public Products? Product { get; set; }

        public int? ProductCount { get; set; }
    }
}
