namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class AuthService
{
    private readonly EfUserRepository _userRepository = new();

    public AppUser? Login(string username, string password, out string message)
    {
        username = username.Trim();

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            message = "Vui lòng nhập username và password.";
            return null;
        }

        var user = _userRepository.FindByUsername(username);
        if (user is null || user.PasswordHash != password)
        {
            message = "Tài khoản hoặc mật khẩu không đúng.";
            return null;
        }

        if (string.Equals(user.UserStatus, "Locked", StringComparison.OrdinalIgnoreCase))
        {
            message = "Tài khoản đang bị khóa. Vui lòng liên hệ quản trị viên.";
            return null;
        }

        message = "Đăng nhập thành công.";
        return new AppUser
        {
            UserId = user.UserCode,
            FullName = user.FullName,
            Username = user.Username,
            Password = "",
            Role = user.Role,
            Status = user.UserStatus
        };
    }
}
