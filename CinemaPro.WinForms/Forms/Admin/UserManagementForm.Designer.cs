using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class UserManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Panel totalAccountsPanel;
    private Panel adminPanel;
    private Panel staffPanel;
    private Panel lockedPanel;
    private Label totalAccountsTitleLabel;
    private Label totalAccountsValueLabel;
    private Label totalAccountsNoteLabel;
    private Label adminTitleLabel;
    private Label adminValueLabel;
    private Label adminNoteLabel;
    private Label staffTitleLabel;
    private Label staffValueLabel;
    private Label staffNoteLabel;
    private Label lockedTitleLabel;
    private Label lockedValueLabel;
    private Label lockedNoteLabel;
    private FlowLayoutPanel filterPanel;
    private Label searchFilterLabel;
    private TextBox searchTextBox;
    private Label roleFilterLabel;
    private ComboBox roleFilterCombo;
    private Button addButton;
    private Button updateButton;
    private Button lockUserButton;
    private Button refreshButton;
    private TableLayoutPanel contentLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private Label gridTitleLabel;
    private DataGridView userGrid;
    private Panel detailPanel;
    private TableLayoutPanel detailLayout;
    private Label detailTitleLabel;
    private Label fullNameInputLabel;
    private TextBox fullNameTextBox;
    private Label usernameInputLabel;
    private TextBox usernameTextBox;
    private Label roleInputLabel;
    private ComboBox roleCombo;
    private Label accountStatusInputLabel;
    private ComboBox statusCombo;
    private Label detailLabel;
    private Button saveButton;
    private Button resetPasswordButton;

    private DataGridViewTextBoxColumn userGridUserIdColumn;
    private DataGridViewTextBoxColumn userGridFullNameColumn;
    private DataGridViewTextBoxColumn userGridUsernameColumn;
    private DataGridViewTextBoxColumn userGridRoleColumn;
    private DataGridViewTextBoxColumn userGridStatusColumn;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        userGridUserIdColumn = new DataGridViewTextBoxColumn();
        userGridFullNameColumn = new DataGridViewTextBoxColumn();
        userGridUsernameColumn = new DataGridViewTextBoxColumn();
        userGridRoleColumn = new DataGridViewTextBoxColumn();
        userGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        statLayout = new TableLayoutPanel();
        totalAccountsPanel = new Panel();
        adminPanel = new Panel();
        staffPanel = new Panel();
        lockedPanel = new Panel();
        totalAccountsTitleLabel = new Label();
        totalAccountsValueLabel = new Label();
        totalAccountsNoteLabel = new Label();
        adminTitleLabel = new Label();
        adminValueLabel = new Label();
        adminNoteLabel = new Label();
        staffTitleLabel = new Label();
        staffValueLabel = new Label();
        staffNoteLabel = new Label();
        lockedTitleLabel = new Label();
        lockedValueLabel = new Label();
        lockedNoteLabel = new Label();
        filterPanel = new FlowLayoutPanel();
        searchFilterLabel = new Label();
        searchTextBox = new TextBox();
        roleFilterLabel = new Label();
        roleFilterCombo = new ComboBox();
        addButton = new Button();
        updateButton = new Button();
        lockUserButton = new Button();
        refreshButton = new Button();
        contentLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        gridTitleLabel = new Label();
        userGrid = new DataGridView();
        detailPanel = new Panel();
        detailLayout = new TableLayoutPanel();
        detailTitleLabel = new Label();
        fullNameInputLabel = new Label();
        fullNameTextBox = new TextBox();
        usernameInputLabel = new Label();
        usernameTextBox = new TextBox();
        roleInputLabel = new Label();
        roleCombo = new ComboBox();
        accountStatusInputLabel = new Label();
        statusCombo = new ComboBox();
        detailLabel = new Label();
        saveButton = new Button();
        resetPasswordButton = new Button();
        totalAccountsValueLabel.Text = "5";
        adminValueLabel.Text = "1";
        staffValueLabel.Text = "4";
        lockedValueLabel.Text = "1";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        totalAccountsPanel.SuspendLayout();
        adminPanel.SuspendLayout();
        staffPanel.SuspendLayout();
        lockedPanel.SuspendLayout();
        filterPanel.SuspendLayout();
        contentLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
        detailPanel.SuspendLayout();
        detailLayout.SuspendLayout();
        SuspendLayout();
        //
        // UserManagementForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "UserManagementForm";
        Text = "Quản lý nhân viên";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(filterPanel, 0, 1);
        rootLayout.Controls.Add(contentLayout, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(totalAccountsPanel, 0, 0);
        statLayout.Controls.Add(adminPanel, 1, 0);
        statLayout.Controls.Add(staffPanel, 2, 0);
        statLayout.Controls.Add(lockedPanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // stat cards
        //
        totalAccountsPanel.BackColor = Color.White;
        totalAccountsPanel.BorderStyle = BorderStyle.FixedSingle;
        totalAccountsPanel.Controls.Add(totalAccountsNoteLabel);
        totalAccountsPanel.Controls.Add(totalAccountsValueLabel);
        totalAccountsPanel.Controls.Add(totalAccountsTitleLabel);
        totalAccountsPanel.Dock = DockStyle.Fill;
        totalAccountsPanel.Margin = new Padding(0, 0, 12, 0);
        totalAccountsPanel.Padding = new Padding(18, 12, 18, 12);
        totalAccountsTitleLabel.Dock = DockStyle.Top;
        totalAccountsTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        totalAccountsTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        totalAccountsTitleLabel.Height = 24;
        totalAccountsTitleLabel.Text = "Tổng tài khoản";
        totalAccountsValueLabel.Dock = DockStyle.Top;
        totalAccountsValueLabel.Font = UiStyleHelper.TitleFont(17F);
        totalAccountsValueLabel.ForeColor = UiStyleHelper.Primary;
        totalAccountsValueLabel.Height = 34;
        totalAccountsNoteLabel.Dock = DockStyle.Top;
        totalAccountsNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        totalAccountsNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        totalAccountsNoteLabel.Height = 24;
        totalAccountsNoteLabel.Text = "Đang quản lý";
        adminPanel.BackColor = Color.White;
        adminPanel.BorderStyle = BorderStyle.FixedSingle;
        adminPanel.Controls.Add(adminNoteLabel);
        adminPanel.Controls.Add(adminValueLabel);
        adminPanel.Controls.Add(adminTitleLabel);
        adminPanel.Dock = DockStyle.Fill;
        adminPanel.Margin = new Padding(0, 0, 12, 0);
        adminPanel.Padding = new Padding(18, 12, 18, 12);
        adminTitleLabel.Dock = DockStyle.Top;
        adminTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        adminTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        adminTitleLabel.Height = 24;
        adminTitleLabel.Text = "Admin";
        adminValueLabel.Dock = DockStyle.Top;
        adminValueLabel.Font = UiStyleHelper.TitleFont(17F);
        adminValueLabel.ForeColor = UiStyleHelper.Accent;
        adminValueLabel.Height = 34;
        adminNoteLabel.Dock = DockStyle.Top;
        adminNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        adminNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        adminNoteLabel.Height = 24;
        adminNoteLabel.Text = "Quyền quản trị";
        staffPanel.BackColor = Color.White;
        staffPanel.BorderStyle = BorderStyle.FixedSingle;
        staffPanel.Controls.Add(staffNoteLabel);
        staffPanel.Controls.Add(staffValueLabel);
        staffPanel.Controls.Add(staffTitleLabel);
        staffPanel.Dock = DockStyle.Fill;
        staffPanel.Margin = new Padding(0, 0, 12, 0);
        staffPanel.Padding = new Padding(18, 12, 18, 12);
        staffTitleLabel.Dock = DockStyle.Top;
        staffTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        staffTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        staffTitleLabel.Height = 24;
        staffTitleLabel.Text = "Nhân viên";
        staffValueLabel.Dock = DockStyle.Top;
        staffValueLabel.Font = UiStyleHelper.TitleFont(17F);
        staffValueLabel.ForeColor = UiStyleHelper.Success;
        staffValueLabel.Height = 34;
        staffNoteLabel.Dock = DockStyle.Top;
        staffNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        staffNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        staffNoteLabel.Height = 24;
        staffNoteLabel.Text = "Quầy vé và kiểm vé";
        lockedPanel.BackColor = Color.White;
        lockedPanel.BorderStyle = BorderStyle.FixedSingle;
        lockedPanel.Controls.Add(lockedNoteLabel);
        lockedPanel.Controls.Add(lockedValueLabel);
        lockedPanel.Controls.Add(lockedTitleLabel);
        lockedPanel.Dock = DockStyle.Fill;
        lockedPanel.Margin = new Padding(0, 0, 0, 0);
        lockedPanel.Padding = new Padding(18, 12, 18, 12);
        lockedTitleLabel.Dock = DockStyle.Top;
        lockedTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        lockedTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        lockedTitleLabel.Height = 24;
        lockedTitleLabel.Text = "Tài khoản khóa";
        lockedValueLabel.Dock = DockStyle.Top;
        lockedValueLabel.Font = UiStyleHelper.TitleFont(17F);
        lockedValueLabel.ForeColor = UiStyleHelper.Danger;
        lockedValueLabel.Height = 34;
        lockedNoteLabel.Dock = DockStyle.Top;
        lockedNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        lockedNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        lockedNoteLabel.Height = 24;
        lockedNoteLabel.Text = "Cần rà soát";
        //
        // filterPanel
        //
        filterPanel.BackColor = UiStyleHelper.ContentBackground;
        filterPanel.Controls.Add(searchFilterLabel);
        filterPanel.Controls.Add(searchTextBox);
        filterPanel.Controls.Add(roleFilterLabel);
        filterPanel.Controls.Add(roleFilterCombo);
        filterPanel.Controls.Add(addButton);
        filterPanel.Controls.Add(updateButton);
        filterPanel.Controls.Add(lockUserButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        searchFilterLabel.Font = UiStyleHelper.SmallFont(9.25F);
        searchFilterLabel.ForeColor = UiStyleHelper.TextMuted;
        searchFilterLabel.Margin = new Padding(0, 21, 8, 0);
        searchFilterLabel.Size = new Size(70, 28);
        searchFilterLabel.Text = "Tìm kiếm";
        searchFilterLabel.TextAlign = ContentAlignment.MiddleLeft;
        ConfigureTextBox(searchTextBox, "Tìm theo họ tên hoặc username...");
        searchTextBox.Margin = new Padding(0, 18, 16, 0);
        searchTextBox.Size = new Size(270, 32);
        roleFilterLabel.Font = UiStyleHelper.SmallFont(9.25F);
        roleFilterLabel.ForeColor = UiStyleHelper.TextMuted;
        roleFilterLabel.Margin = new Padding(0, 21, 8, 0);
        roleFilterLabel.Size = new Size(52, 28);
        roleFilterLabel.Text = "Vai trò";
        roleFilterLabel.TextAlign = ContentAlignment.MiddleLeft;
        ConfigureCombo(roleFilterCombo);
        roleFilterCombo.Margin = new Padding(0, 18, 16, 0);
        roleFilterCombo.Size = new Size(150, 32);
        StylePrimaryButton(addButton, "Thêm", 92);
        StyleSecondaryButton(updateButton, "Sửa", 92);
        StyleDangerButton(lockUserButton, "Khóa tài khoản", 132);
        StyleSecondaryButton(refreshButton, "Làm mới", 104);
        //
        // contentLayout
        //
        contentLayout.BackColor = UiStyleHelper.ContentBackground;
        contentLayout.ColumnCount = 2;
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        contentLayout.Controls.Add(gridPanel, 0, 0);
        contentLayout.Controls.Add(detailPanel, 1, 0);
        contentLayout.Dock = DockStyle.Fill;
        contentLayout.RowCount = 1;
        contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // gridPanel
        //
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(gridLayout);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Margin = new Padding(0, 0, 12, 0);
        gridPanel.Padding = new Padding(10);
        gridLayout.BackColor = Color.White;
        gridLayout.ColumnCount = 1;
        gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        gridLayout.Controls.Add(gridTitleLabel, 0, 0);
        gridLayout.Controls.Add(userGrid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        gridTitleLabel.Dock = DockStyle.Fill;
        gridTitleLabel.Font = UiStyleHelper.SectionFont(10F);
        gridTitleLabel.ForeColor = UiStyleHelper.Primary;
        gridTitleLabel.Text = "DANH SÁCH NHÂN VIÊN";
        gridTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        ConfigureGrid(userGrid);
        userGrid.Dock = DockStyle.Fill;
        userGrid.AutoGenerateColumns = false;
        userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        userGrid.ColumnHeadersHeight = 40;
        userGrid.RowHeadersVisible = false;
        userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        userGridUserIdColumn.Name = "UserId";
        userGridUserIdColumn.DataPropertyName = "UserId";
        userGridUserIdColumn.HeaderText = "UserId";
        userGridUserIdColumn.FillWeight = 80F;
        userGrid.Columns.Add(userGridUserIdColumn);
        userGridFullNameColumn.Name = "FullName";
        userGridFullNameColumn.DataPropertyName = "FullName";
        userGridFullNameColumn.HeaderText = "Họ tên";
        userGridFullNameColumn.FillWeight = 190F;
        userGrid.Columns.Add(userGridFullNameColumn);
        userGridUsernameColumn.Name = "Username";
        userGridUsernameColumn.DataPropertyName = "Username";
        userGridUsernameColumn.HeaderText = "Username";
        userGridUsernameColumn.FillWeight = 120F;
        userGrid.Columns.Add(userGridUsernameColumn);
        userGridRoleColumn.Name = "Role";
        userGridRoleColumn.DataPropertyName = "Role";
        userGridRoleColumn.HeaderText = "Role";
        userGridRoleColumn.FillWeight = 90F;
        userGrid.Columns.Add(userGridRoleColumn);
        userGridStatusColumn.Name = "Status";
        userGridStatusColumn.DataPropertyName = "Status";
        userGridStatusColumn.HeaderText = "Trạng thái";
        userGridStatusColumn.FillWeight = 120F;
        userGrid.Columns.Add(userGridStatusColumn);
        //
        // detailPanel
        //
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailLayout);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Padding = new Padding(14);
        detailLayout.BackColor = Color.White;
        detailLayout.ColumnCount = 2;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(detailTitleLabel, 0, 0);
        detailLayout.Controls.Add(fullNameInputLabel, 0, 1);
        detailLayout.Controls.Add(fullNameTextBox, 1, 1);
        detailLayout.Controls.Add(usernameInputLabel, 0, 2);
        detailLayout.Controls.Add(usernameTextBox, 1, 2);
        detailLayout.Controls.Add(roleInputLabel, 0, 3);
        detailLayout.Controls.Add(roleCombo, 1, 3);
        detailLayout.Controls.Add(accountStatusInputLabel, 0, 4);
        detailLayout.Controls.Add(statusCombo, 1, 4);
        detailLayout.Controls.Add(detailLabel, 0, 5);
        detailLayout.Controls.Add(saveButton, 0, 6);
        detailLayout.Controls.Add(resetPasswordButton, 0, 7);
        detailLayout.Dock = DockStyle.Fill;
        detailLayout.RowCount = 8;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        detailLayout.SetColumnSpan(detailTitleLabel, 2);
        detailLayout.SetColumnSpan(detailLabel, 2);
        detailLayout.SetColumnSpan(saveButton, 2);
        detailLayout.SetColumnSpan(resetPasswordButton, 2);
        detailTitleLabel.Dock = DockStyle.Fill;
        detailTitleLabel.Font = UiStyleHelper.SectionFont(10F);
        detailTitleLabel.ForeColor = UiStyleHelper.Primary;
        detailTitleLabel.Text = "HỒ SƠ NHÂN VIÊN";
        detailTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        StyleFieldLabel(fullNameInputLabel, "Họ tên");
        StyleFieldLabel(usernameInputLabel, "Username");
        StyleFieldLabel(roleInputLabel, "Vai trò");
        StyleFieldLabel(accountStatusInputLabel, "Trạng thái");
        ConfigureTextBox(fullNameTextBox);
        ConfigureTextBox(usernameTextBox);
        ConfigureCombo(roleCombo);
        ConfigureCombo(statusCombo);
        DockFieldControl(fullNameTextBox);
        DockFieldControl(usernameTextBox);
        DockFieldControl(roleCombo);
        DockFieldControl(statusCombo);
        fullNameTextBox.Text = "Nguyễn Văn Quản";
        usernameTextBox.Text = "admin";
        roleCombo.Items.AddRange(new object[] { "Admin", "Staff" });
        roleCombo.SelectedIndex = 0;
        statusCombo.Items.AddRange(new object[] { "Hoạt động", "Khóa" });
        statusCombo.SelectedIndex = 0;
        detailLabel.Dock = DockStyle.Fill;
        detailLabel.Font = UiStyleHelper.BodyFont(9.75F);
        detailLabel.ForeColor = UiStyleHelper.TextDark;
        detailLabel.Text = "Nguyễn Văn Quản\r\n\r\nUserId: U001\r\nUsername: admin\r\nVai trò: Admin\r\nTrạng thái: Hoạt động";
        detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        StylePrimaryButton(saveButton, "Lưu", 0);
        saveButton.Dock = DockStyle.Fill;
        saveButton.Margin = new Padding(0, 0, 0, 8);
        StyleSecondaryButton(resetPasswordButton, "Đặt lại mật khẩu", 0);
        resetPasswordButton.Dock = DockStyle.Fill;
        resetPasswordButton.Margin = Padding.Empty;
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        totalAccountsPanel.ResumeLayout(false);
        adminPanel.ResumeLayout(false);
        staffPanel.ResumeLayout(false);
        lockedPanel.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        contentLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
        detailPanel.ResumeLayout(false);
        detailLayout.ResumeLayout(false);
        UiStyleHelper.CompleteDesignerGrid(userGrid);
        ResumeLayout(false);
    }

    private static void ConfigureTextBox(TextBox textBox, string placeholder = "")
    {
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Font = UiStyleHelper.BodyFont(10F);
        textBox.Height = 32;
        textBox.PlaceholderText = placeholder;
    }

    private static void ConfigureCombo(ComboBox combo)
    {
        combo.DropDownStyle = ComboBoxStyle.DropDownList;
        combo.FlatStyle = FlatStyle.Flat;
        combo.Font = UiStyleHelper.BodyFont(10F);
        combo.Height = 34;
    }

    private static void StyleFieldLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 0, 8, 0);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void DockFieldControl(Control control)
    {
        control.Dock = DockStyle.Fill;
        control.Margin = new Padding(0, 12, 0, 12);
    }

    private static void ConfigureGrid(DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoGenerateColumns = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersHeight = 40;
        grid.Dock = DockStyle.Fill;
        grid.EnableHeadersVisualStyles = false;
        grid.MultiSelect = false;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 34;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    private static void StylePrimaryButton(Button button, string text, int width)
    {
        button.BackColor = UiStyleHelper.Primary;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = Color.White;
        button.Margin = new Padding(0, 18, 8, 0);
        button.Size = new Size(width > 0 ? width : 110, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleSecondaryButton(Button button, string text, int width)
    {
        button.BackColor = Color.White;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = UiStyleHelper.Primary;
        button.Margin = new Padding(0, 18, 8, 0);
        button.Size = new Size(width > 0 ? width : 110, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleDangerButton(Button button, string text, int width)
    {
        StyleSecondaryButton(button, text, width);
        button.ForeColor = UiStyleHelper.Danger;
    }
}
