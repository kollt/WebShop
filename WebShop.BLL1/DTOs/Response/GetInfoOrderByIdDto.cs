using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Response;

public class GetInfoOrderByIdDto
{
    public long Id { get; set; }
    public Users? User { get; set; }
    public List<OrderItems>? OrderItems { get; set; }
    public DateTime? OrderDate { get; set; }
}
