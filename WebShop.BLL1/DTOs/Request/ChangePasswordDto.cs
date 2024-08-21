namespace WebShop.BLL.DTOs.Request;

public class ChangePasswordDto
{
    public long Id { get; set; }
    public string? OldPassword { get; set; }
    public string? NewPassword { get; set; }
    public string? Email { get; set; }

}
