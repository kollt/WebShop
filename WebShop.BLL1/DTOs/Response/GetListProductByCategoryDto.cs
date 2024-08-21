

using WebShop.DAL.Entities;

namespace WebShop.BLL.DTOs.Response;

public class GetListProductByCategoryDto
{
   public List<Products>? ListProduct {  get; set; }
}
