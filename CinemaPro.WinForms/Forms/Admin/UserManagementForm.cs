using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class UserManagementForm : Form
{
    private readonly List<EmployeeRow> _employees;

    public UserManagementForm()
    {
        _employees = AppServices.CinemaStore.GetEmployees().ToList();
        InitializeComponent();
        BindLookupData();
        WireEvents();
        LoadData();
    }

    private void BindLookupData()
    {
        roleFilterCombo.Items.Clear();
        roleCombo.Items.Clear();
        statusCombo.Items.Clear();
        roleFilterCombo.Items.AddRange(["Tất cả vai trò", "Admin", "Staff"]);
        roleFilterCombo.SelectedIndex = 0;
        roleCombo.Items.AddRange(["Admin", "Staff"]);
        statusCombo.Items.AddRange(["Hoạt động", "Khóa"]);
    }

    private void WireEvents()
    {
        searchTextBox.TextChanged += (_, _) => LoadData();
        roleFilterCombo.SelectedIndexChanged += (_, _) => LoadData();
        refreshButton.Click += (_, _) => LoadData();
        addButton.Click += (_, _) => MessageBox.Show("Đã thêm nhân viên demo.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        updateButton.Click += (_, _) => MessageBox.Show("Đã cập nhật nhân viên demo.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        lockUserButton.Click += (_, _) => MessageBox.Show("Đã khóa tài khoản demo.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        saveButton.Click += (_, _) => MessageBox.Show("Đã lưu hồ sơ nhân viên demo.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        resetPasswordButton.Click += (_, _) => MessageBox.Show("Mật khẩu demo đã được đặt lại về 123456.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        userGrid.SelectionChanged += (_, _) => UpdateDetailFromGrid();
        UiStyleHelper.ApplyStatusCellFormatting(userGrid, "Status");
    }

    private void LoadData()
    {
        totalAccountsValueLabel.Text = _employees.Count.ToString();
        adminValueLabel.Text = _employees.Count(employee => employee.Role == "Admin").ToString();
        staffValueLabel.Text = _employees.Count(employee => employee.Role == "Staff").ToString();
        lockedValueLabel.Text = _employees.Count(employee => employee.Status == "Khóa").ToString();

        var rows = FilterEmployees().ToList();
        userGrid.DataSource = rows.Select(employee => new
        {
            employee.UserId,
            employee.FullName,
            employee.Username,
            employee.Role,
            employee.Status
        }).ToList();

        userGrid.ClearSelection();
        userGrid.CurrentCell = null;

        if (rows.Count > 0)
        {
            UpdateDetail(rows[0]);
        }
        else
        {
            ClearDetail();
        }
    }

    private IEnumerable<EmployeeRow> FilterEmployees()
    {
        var query = _employees.AsEnumerable();
        var keyword = searchTextBox.Text.Trim();
        var role = roleFilterCombo.SelectedItem?.ToString();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(employee =>
                employee.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                employee.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(role) && role != "Tất cả vai trò")
        {
            query = query.Where(employee => employee.Role == role);
        }

        return query.OrderBy(employee => employee.Role).ThenBy(employee => employee.FullName);
    }

    private void UpdateDetailFromGrid()
    {
        if (userGrid.SelectedRows.Count == 0)
        {
            return;
        }

        var userId = userGrid.SelectedRows[0].Cells["UserId"].Value?.ToString();
        var employee = _employees.FirstOrDefault(item => item.UserId == userId);
        if (employee is not null)
        {
            UpdateDetail(employee);
        }
    }

    private void UpdateDetail(EmployeeRow employee)
    {
        fullNameTextBox.Text = employee.FullName;
        usernameTextBox.Text = employee.Username;
        roleCombo.SelectedItem = employee.Role;
        statusCombo.SelectedItem = employee.Status;
        detailLabel.Text =
            $"{employee.FullName}\n\n" +
            $"UserId: {employee.UserId}\n" +
            $"Username: {employee.Username}\n" +
            $"Vai trò: {employee.Role}\n" +
            $"Trạng thái: {employee.Status}\n\n" +
            "Thông tin này chỉ phục vụ demo giao diện.";
    }

    private void ClearDetail()
    {
        fullNameTextBox.Clear();
        usernameTextBox.Clear();
        roleCombo.SelectedIndex = -1;
        statusCombo.SelectedIndex = -1;
        detailLabel.Text = "Không có nhân viên phù hợp bộ lọc hiện tại.";
    }
}
