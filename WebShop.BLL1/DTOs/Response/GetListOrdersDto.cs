
using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Response;

public class GetListOrdersDto
{
    public List<Orders>? ListOrders { get; set; }
}
