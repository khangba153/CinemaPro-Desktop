using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class UserManagementForm : Form
{
    public UserManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(userGrid);
    }

    private void UserManagementForm_Load(object? sender, EventArgs e)
    {
        roleComboBox.SelectedIndex = 0;
        statusComboBox.SelectedIndex = 0;
        userGrid.Rows.Clear();
        foreach (var employee in AppServices.CinemaStore.GetEmployees())
        {
            userGrid.Rows.Add(employee.UserId, employee.FullName, employee.Username, employee.Role, employee.Status);
        }
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Quản lý nhân viên đang dùng dữ liệu demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
