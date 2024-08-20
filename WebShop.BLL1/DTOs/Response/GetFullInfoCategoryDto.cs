using WebShop.DAL.Entities;
namespace WebShop.BLL.DTOs.Response;

public class GetFullInfoCategoryDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Products>? Products { get; set; }
}
