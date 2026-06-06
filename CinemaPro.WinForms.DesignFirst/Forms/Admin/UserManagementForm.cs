namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class UserManagementForm : Form
{
    private readonly UserService _userService = new();
    private string _selectedUserCode = "";

    public UserManagementForm()
    {
        InitializeComponent();
        ConfigureRuntimeText();
        ConfigureGrid();
    }

    private void UserManagementForm_Load(object? sender, EventArgs e)
    {
        LoadUsers();
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        try
        {
            if (sender == addButton)
            {
                AddUser();
                return;
            }

            if (sender == editButton)
            {
                UpdateUser();
                return;
            }

            if (sender == lockButton)
            {
                ToggleLock();
                return;
            }

            if (sender == refreshButton)
            {
                LoadUsers();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Không thể xử lý dữ liệu nhân viên.\n\n" + ex.Message,
                "Lỗi database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void AddUser()
    {
        if (_userService.AddUser(
            fullNameTextBox.Text,
            usernameTextBox.Text,
            roleComboBox.Text,
            statusComboBox.Text,
            out var message))
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
            ClearDetail();
            return;
        }

        MessageBox.Show(message, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void UpdateUser()
    {
        if (_userService.UpdateUser(
            _selectedUserCode,
            fullNameTextBox.Text,
            usernameTextBox.Text,
            roleComboBox.Text,
            statusComboBox.Text,
            out var message))
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
            return;
        }

        MessageBox.Show(message, "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void ToggleLock()
    {
        if (_userService.ToggleLock(_selectedUserCode, out var message))
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
            return;
        }

        MessageBox.Show(message, "Không thể đổi trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void LoadUsers()
    {
        userGrid.Rows.Clear();

        foreach (var user in _userService.GetEmployees())
        {
            var rowIndex = userGrid.Rows.Add(
                user.UserId,
                user.FullName,
                user.Username,
                user.Role,
                user.Status);

            userGrid.Rows[rowIndex].Tag = user;
        }

        if (userGrid.Rows.Count > 0)
        {
            userGrid.ClearSelection();
            userGrid.Rows[0].Selected = true;
            FillDetailFromRow(userGrid.Rows[0]);
        }
        else
        {
            ClearDetail();
        }
    }

    private void ConfigureGrid()
    {
        userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        userGrid.MultiSelect = false;
        userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        SetColumnHeader("colUserId", "Mã NV");
        SetColumnHeader("colFullName", "Họ tên");
        SetColumnHeader("colUsername", "Username");
        SetColumnHeader("colRole", "Role");
        SetColumnHeader("colStatus", "Trạng thái");
        userGrid.SelectionChanged += (_, _) =>
        {
            if (userGrid.SelectedRows.Count > 0)
            {
                FillDetailFromRow(userGrid.SelectedRows[0]);
            }
        };
    }

    private void SetColumnHeader(string columnName, string headerText)
    {
        if (userGrid.Columns[columnName] is DataGridViewColumn column)
        {
            column.HeaderText = headerText;
        }
    }

    private void FillDetailFromRow(DataGridViewRow row)
    {
        if (row.Tag is not EmployeeRow user)
        {
            return;
        }

        _selectedUserCode = user.UserId;
        fullNameTextBox.Text = user.FullName;
        usernameTextBox.Text = user.Username;
        roleComboBox.Text = user.Role;
        statusComboBox.Text = user.Status;
        lockButton.Text = user.Status == "Locked" ? "Mở khóa" : "Khóa tài khoản";
    }

    private void ClearDetail()
    {
        _selectedUserCode = "";
        fullNameTextBox.Clear();
        usernameTextBox.Clear();
        roleComboBox.SelectedIndex = 1;
        statusComboBox.SelectedIndex = 0;
        lockButton.Text = "Khóa tài khoản";
    }

    private void ConfigureRuntimeText()
    {
        Text = "Quản lý nhân viên";
        addButton.Text = "Thêm";
        editButton.Text = "Sửa";
        lockButton.Text = "Khóa tài khoản";
        refreshButton.Text = "Làm mới";

        roleComboBox.Items.Clear();
        roleComboBox.Items.AddRange(new object[] { "Admin", "Staff" });
        roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        statusComboBox.Items.Clear();
        statusComboBox.Items.AddRange(new object[] { "Active", "Locked" });
        statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        roleComboBox.SelectedIndex = 1;
        statusComboBox.SelectedIndex = 0;
    }

    private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
