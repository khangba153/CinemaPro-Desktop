using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Session;

public static class UserSession
{
    public static string UserId { get; private set; } = "";
    public static string FullName { get; private set; } = "";
    public static string Username { get; private set; } = "";
    public static string Role { get; private set; } = "";

    public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserId);
    public static bool IsAdmin => string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);
    public static bool IsStaff => string.Equals(Role, "Staff", StringComparison.OrdinalIgnoreCase);

    public static void Set(AppUser user)
    {
        UserId = user.UserId;
        FullName = user.FullName;
        Username = user.Username;
        Role = user.Role;
    }

    public static void Clear()
    {
        UserId = "";
        FullName = "";
        Username = "";
        Role = "";
    }
}
