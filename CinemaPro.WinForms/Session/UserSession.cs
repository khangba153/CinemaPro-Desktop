using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Session;

public static class UserSession
{
    public static string UserId { get; private set; } = string.Empty;

    public static string FullName { get; private set; } = string.Empty;

    public static string Username { get; private set; } = string.Empty;

    public static string Role { get; private set; } = string.Empty;

    public static bool IsAuthenticated => !string.IsNullOrWhiteSpace(UserId);

    public static void SetCurrentUser(AppUser user)
    {
        UserId = user.UserId;
        FullName = user.FullName;
        Username = user.Username;
        Role = user.Role;
    }

    public static void Clear()
    {
        UserId = string.Empty;
        FullName = string.Empty;
        Username = string.Empty;
        Role = string.Empty;
    }
}
