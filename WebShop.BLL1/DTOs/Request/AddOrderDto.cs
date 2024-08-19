using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Request
{
    public class AddOrderDto
    {
        public Users? User { get; set; }
        public List<OrderItems>? OrderItems { get; set; }
    }
}
