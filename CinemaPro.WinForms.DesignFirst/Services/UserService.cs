namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class UserService
{
    private const string DefaultPassword = "123456";
    private readonly EfUserRepository _userRepository = new();

    public IReadOnlyList<EmployeeRow> GetEmployees()
    {
        return _userRepository
            .GetAll()
            .Select(user => new EmployeeRow
            {
                UserId = user.UserCode,
                FullName = user.FullName,
                Username = user.Username,
                Role = user.Role,
                Status = user.UserStatus
            })
            .ToList();
    }

    public bool AddUser(string fullName, string username, string role, string status, out string message)
    {
        fullName = fullName.Trim();
        username = username.Trim();

        if (!ValidateInput(fullName, username, role, status, null, out message))
        {
            return false;
        }

        var user = new User
        {
            UserCode = _userRepository.GetNextUserCode(),
            FullName = fullName,
            Username = username,
            PasswordHash = DefaultPassword,
            Role = role,
            UserStatus = status
        };

        _userRepository.Insert(user);
        message = $"Đã thêm nhân viên {fullName}. Mật khẩu mặc định: {DefaultPassword}.";
        return true;
    }

    public bool UpdateUser(string userCode, string fullName, string username, string role, string status, out string message)
    {
        fullName = fullName.Trim();
        username = username.Trim();

        if (string.IsNullOrWhiteSpace(userCode))
        {
            message = "Vui lòng chọn nhân viên cần sửa.";
            return false;
        }

        if (!ValidateInput(fullName, username, role, status, userCode, out message))
        {
            return false;
        }

        var currentUser = _userRepository.FindByCode(userCode);
        if (currentUser is null)
        {
            message = "Không tìm thấy nhân viên cần sửa.";
            return false;
        }

        currentUser.FullName = fullName;
        currentUser.Username = username;
        currentUser.Role = role;
        currentUser.UserStatus = status;

        _userRepository.Update(currentUser);
        message = "Đã cập nhật thông tin nhân viên.";
        return true;
    }

    public bool ToggleLock(string userCode, out string message)
    {
        if (string.IsNullOrWhiteSpace(userCode))
        {
            message = "Vui lòng chọn nhân viên cần khóa hoặc mở khóa.";
            return false;
        }

        var user = _userRepository.FindByCode(userCode);
        if (user is null)
        {
            message = "Không tìm thấy nhân viên.";
            return false;
        }

        var nextStatus = string.Equals(user.UserStatus, "Locked", StringComparison.OrdinalIgnoreCase)
            ? "Active"
            : "Locked";

        _userRepository.UpdateStatus(userCode, nextStatus);
        message = nextStatus == "Locked" ? "Đã khóa tài khoản." : "Đã mở khóa tài khoản.";
        return true;
    }

    private bool ValidateInput(string fullName, string username, string role, string status, string? currentUserCode, out string message)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            message = "Vui lòng nhập họ tên.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(username))
        {
            message = "Vui lòng nhập username.";
            return false;
        }

        if (role is not ("Admin" or "Staff"))
        {
            message = "Role chỉ được là Admin hoặc Staff.";
            return false;
        }

        if (status is not ("Active" or "Locked"))
        {
            message = "Trạng thái chỉ được là Active hoặc Locked.";
            return false;
        }

        if (_userRepository.UsernameExists(username, currentUserCode))
        {
            message = "Username đã tồn tại.";
            return false;
        }

        message = "";
        return true;
    }
}
