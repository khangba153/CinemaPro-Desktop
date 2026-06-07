namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class UserManagementForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel actionPanel = null!;
    private Button addButton = null!;
    private Button editButton = null!;
    private Button lockButton = null!;
    private Button refreshButton = null!;
    private Panel gridPanel = null!;
    private DataGridView userGrid = null!;
    private Panel detailPanel = null!;
    private TextBox fullNameTextBox = null!;
    private TextBox usernameTextBox = null!;
    private ComboBox roleComboBox = null!;
    private ComboBox statusComboBox = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        actionPanel = new Panel();
        refreshButton = new Button();
        lockButton = new Button();
        editButton = new Button();
        addButton = new Button();
        gridPanel = new Panel();
        userGrid = new DataGridView();
        title = new Label();
        detailPanel = new Panel();
        statusLabel = new Label();
        statusComboBox = new ComboBox();
        roleLabel = new Label();
        roleComboBox = new ComboBox();
        userLabel = new Label();
        usernameTextBox = new TextBox();
        nameLabel = new Label();
        fullNameTextBox = new TextBox();
        detailTitle = new Label();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        actionPanel.SuspendLayout();
        gridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
        detailPanel.SuspendLayout();
        SuspendLayout();
        // 
        // actionPanel
        // 
        actionPanel.BackColor = Color.White;
        actionPanel.BorderStyle = BorderStyle.FixedSingle;
        actionPanel.Controls.Add(refreshButton);
        actionPanel.Controls.Add(lockButton);
        actionPanel.Controls.Add(editButton);
        actionPanel.Controls.Add(addButton);
        actionPanel.Location = new Point(21, 19);
        actionPanel.Margin = new Padding(3, 4, 3, 4);
        actionPanel.Name = "actionPanel";
        actionPanel.Size = new Size(1197, 82);
        actionPanel.TabIndex = 2;
        // 
        // refreshButton
        // 
        refreshButton.BackColor = Color.White;
        refreshButton.FlatStyle = FlatStyle.Flat;
        refreshButton.Location = new Point(475, 21);
        refreshButton.Margin = new Padding(3, 4, 3, 4);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(126, 43);
        refreshButton.TabIndex = 0;
        refreshButton.Text = "Làm mới";
        refreshButton.UseVisualStyleBackColor = false;
        refreshButton.Click += ActionButton_Click;
        // 
        // lockButton
        // 
        lockButton.BackColor = Color.White;
        lockButton.FlatStyle = FlatStyle.Flat;
        lockButton.ForeColor = Color.FromArgb(220, 38, 38);
        lockButton.Location = new Point(309, 21);
        lockButton.Margin = new Padding(3, 4, 3, 4);
        lockButton.Name = "lockButton";
        lockButton.Size = new Size(149, 43);
        lockButton.TabIndex = 1;
        lockButton.Text = "Khóa tài khoản";
        lockButton.UseVisualStyleBackColor = false;
        lockButton.Click += ActionButton_Click;
        // 
        // editButton
        // 
        editButton.BackColor = Color.White;
        editButton.FlatStyle = FlatStyle.Flat;
        editButton.Location = new Point(165, 21);
        editButton.Margin = new Padding(3, 4, 3, 4);
        editButton.Name = "editButton";
        editButton.Size = new Size(126, 43);
        editButton.TabIndex = 2;
        editButton.Text = "Sửa";
        editButton.UseVisualStyleBackColor = false;
        editButton.Click += ActionButton_Click;
        // 
        // addButton
        // 
        addButton.BackColor = Color.FromArgb(37, 99, 235);
        addButton.FlatAppearance.BorderSize = 0;
        addButton.FlatStyle = FlatStyle.Flat;
        addButton.ForeColor = Color.White;
        addButton.Location = new Point(21, 21);
        addButton.Margin = new Padding(3, 4, 3, 4);
        addButton.Name = "addButton";
        addButton.Size = new Size(126, 43);
        addButton.TabIndex = 3;
        addButton.Text = "Thêm";
        addButton.UseVisualStyleBackColor = false;
        addButton.Click += ActionButton_Click;
        // 
        // gridPanel
        // 
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(userGrid);
        gridPanel.Controls.Add(title);
        gridPanel.Location = new Point(21, 125);
        gridPanel.Margin = new Padding(3, 4, 3, 4);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(788, 661);
        gridPanel.TabIndex = 1;
        // 
        // userGrid
        // 
        userGrid.AllowUserToAddRows = false;
        userGrid.AllowUserToDeleteRows = false;
        userGrid.BackgroundColor = Color.White;
        userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        userGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
        userGrid.Location = new Point(21, 75);
        userGrid.Margin = new Padding(3, 4, 3, 4);
        userGrid.Name = "userGrid";
        userGrid.ReadOnly = true;
        userGrid.RowHeadersVisible = false;
        userGrid.RowHeadersWidth = 51;
        userGrid.Size = new Size(745, 560);
        userGrid.TabIndex = 0;
        userGrid.CellContentClick += userGrid_CellContentClick;
        // 
        // title
        // 
        title.AutoSize = true;
        title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        title.Location = new Point(21, 24);
        title.Name = "title";
        title.Size = new Size(209, 28);
        title.TabIndex = 1;
        title.Text = "Danh sách nhân viên";
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(statusLabel);
        detailPanel.Controls.Add(statusComboBox);
        detailPanel.Controls.Add(roleLabel);
        detailPanel.Controls.Add(roleComboBox);
        detailPanel.Controls.Add(userLabel);
        detailPanel.Controls.Add(usernameTextBox);
        detailPanel.Controls.Add(nameLabel);
        detailPanel.Controls.Add(fullNameTextBox);
        detailPanel.Controls.Add(detailTitle);
        detailPanel.Location = new Point(827, 125);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(391, 661);
        detailPanel.TabIndex = 0;
        // 
        // statusLabel
        // 
        statusLabel.Location = new Point(25, 341);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(114, 31);
        statusLabel.TabIndex = 0;
        statusLabel.Text = "Trạng thái";
        // 
        // statusComboBox
        // 
        statusComboBox.Items.AddRange(new object[] { "Hoạt động", "Tạm khóa" });
        statusComboBox.Location = new Point(25, 373);
        statusComboBox.Margin = new Padding(3, 4, 3, 4);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(331, 28);
        statusComboBox.TabIndex = 1;
        // 
        // roleLabel
        // 
        roleLabel.Location = new Point(25, 256);
        roleLabel.Name = "roleLabel";
        roleLabel.Size = new Size(114, 31);
        roleLabel.TabIndex = 2;
        roleLabel.Text = "Role";
        // 
        // roleComboBox
        // 
        roleComboBox.Items.AddRange(new object[] { "Admin", "Staff" });
        roleComboBox.Location = new Point(25, 288);
        roleComboBox.Margin = new Padding(3, 4, 3, 4);
        roleComboBox.Name = "roleComboBox";
        roleComboBox.Size = new Size(331, 28);
        roleComboBox.TabIndex = 3;
        // 
        // userLabel
        // 
        userLabel.Location = new Point(25, 171);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(114, 31);
        userLabel.TabIndex = 4;
        userLabel.Text = "Username";
        // 
        // usernameTextBox
        // 
        usernameTextBox.Location = new Point(25, 203);
        usernameTextBox.Margin = new Padding(3, 4, 3, 4);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(331, 27);
        usernameTextBox.TabIndex = 5;
        usernameTextBox.Text = "admin";
        // 
        // nameLabel
        // 
        nameLabel.Location = new Point(25, 85);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(114, 31);
        nameLabel.TabIndex = 6;
        nameLabel.Text = "Họ tên";
        // 
        // fullNameTextBox
        // 
        fullNameTextBox.Location = new Point(25, 117);
        fullNameTextBox.Margin = new Padding(3, 4, 3, 4);
        fullNameTextBox.Name = "fullNameTextBox";
        fullNameTextBox.Size = new Size(331, 27);
        fullNameTextBox.TabIndex = 7;
        fullNameTextBox.Text = "Nguyễn Văn Quản";
        // 
        // detailTitle
        // 
        detailTitle.AutoSize = true;
        detailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        detailTitle.Location = new Point(21, 24);
        detailTitle.Name = "detailTitle";
        detailTitle.Size = new Size(203, 28);
        detailTitle.TabIndex = 8;
        detailTitle.Text = "Thông tin nhân viên";
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "UserId";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 125;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 125;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Username";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 125;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Role";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 125;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "Trạng thái";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 125;
        // 
        // UserManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1239, 808);
        Controls.Add(detailPanel);
        Controls.Add(gridPanel);
        Controls.Add(actionPanel);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UserManagementForm";
        Text = "Quản lý nhân viên";
        Load += UserManagementForm_Load;
        actionPanel.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
        detailPanel.ResumeLayout(false);
        detailPanel.PerformLayout();
        ResumeLayout(false);
    }

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private Label title;
    private Label statusLabel;
    private Label roleLabel;
    private Label userLabel;
    private Label nameLabel;
    private Label detailTitle;
}
