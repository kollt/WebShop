using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Request;

public class UpdateProductRequestDto
{
	public long Id { get; set; }
	public string? Name { get; set; }
	public Categories? Category { get; set; }
	public double Price { get; set; }
	public string? Description { get; set; }
}