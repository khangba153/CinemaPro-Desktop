namespace CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;

public sealed class UserEntity
{
    public int UserId { get; set; }
    public string UserCode { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Role { get; set; } = "";
    public string UserStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
