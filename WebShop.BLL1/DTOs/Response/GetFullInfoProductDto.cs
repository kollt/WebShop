using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Response;

public class GetFullInfoProductDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public Categories? Categories { get; set; }
    public string? Description { get; set; }
    public double? Price { get; set; }
}
