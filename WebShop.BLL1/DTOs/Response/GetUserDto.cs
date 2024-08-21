
using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Response;

public class GetUserDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public List<Orders>? Orders { get; set; }

}
