namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class AppUser
{
    public string UserId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Role { get; set; } = "";
    public string Status { get; set; } = "";
}

public sealed class EmployeeRow
{
    public string UserId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";
    public string Role { get; set; } = "";
    public string Status { get; set; } = "";
}
