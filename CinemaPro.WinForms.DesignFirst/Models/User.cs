namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class User
{
    public int UserId { get; set; }
    public string UserCode { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";

    // Demo only: database script currently stores plain text password in PasswordHash.
    public string PasswordHash { get; set; } = "";

    public string Role { get; set; } = "";
    public string UserStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
