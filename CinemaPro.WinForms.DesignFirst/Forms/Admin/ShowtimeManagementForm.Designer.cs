namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class ShowtimeManagementForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel inputPanel = null!;
    private ComboBox movieComboBox = null!;
    private ComboBox roomComboBox = null!;
    private DateTimePicker showDatePicker = null!;
    private DateTimePicker startTimePicker = null!;
    private DateTimePicker endTimePicker = null!;
    private TextBox priceTextBox = null!;
    private ComboBox formatComboBox = null!;
    private ComboBox statusComboBox = null!;
    private Button checkConflictButton = null!;
    private Button createButton = null!;
    private Button editButton = null!;
    private Button cancelButton = null!;
    private Panel gridPanel = null!;
    private DataGridView showtimeGrid = null!;
    private Panel detailPanel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        inputPanel = new Panel();
        cancelButton = new Button();
        editButton = new Button();
        createButton = new Button();
        checkConflictButton = new Button();
        statusComboBox = new ComboBox();
        formatComboBox = new ComboBox();
        priceTextBox = new TextBox();
        endTimePicker = new DateTimePicker();
        startTimePicker = new DateTimePicker();
        showDatePicker = new DateTimePicker();
        roomComboBox = new ComboBox();
        movieComboBox = new ComboBox();
        formTitle = new Label();
        gridPanel = new Panel();
        showtimeGrid = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        gridTitle = new Label();
        detailPanel = new Panel();
        detailText = new Label();
        detailTitle = new Label();
        inputPanel.SuspendLayout();
        gridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        detailPanel.SuspendLayout();
        SuspendLayout();
        // 
        // inputPanel
        // 
        inputPanel.BackColor = Color.White;
        inputPanel.BorderStyle = BorderStyle.FixedSingle;
        inputPanel.Controls.Add(cancelButton);
        inputPanel.Controls.Add(editButton);
        inputPanel.Controls.Add(createButton);
        inputPanel.Controls.Add(checkConflictButton);
        inputPanel.Controls.Add(statusComboBox);
        inputPanel.Controls.Add(formatComboBox);
        inputPanel.Controls.Add(priceTextBox);
        inputPanel.Controls.Add(endTimePicker);
        inputPanel.Controls.Add(startTimePicker);
        inputPanel.Controls.Add(showDatePicker);
        inputPanel.Controls.Add(roomComboBox);
        inputPanel.Controls.Add(movieComboBox);
        inputPanel.Controls.Add(formTitle);
        inputPanel.Location = new Point(21, 19);
        inputPanel.Margin = new Padding(3, 4, 3, 4);
        inputPanel.Name = "inputPanel";
        inputPanel.Size = new Size(1197, 146);
        inputPanel.TabIndex = 2;
        // 
        // cancelButton
        // 
        cancelButton.BackColor = Color.White;
        cancelButton.FlatStyle = FlatStyle.Flat;
        cancelButton.ForeColor = Color.FromArgb(220, 38, 38);
        cancelButton.Location = new Point(501, 104);
        cancelButton.Margin = new Padding(3, 4, 3, 4);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(137, 37);
        cancelButton.TabIndex = 0;
        cancelButton.Text = "Hủy suất chiếu";
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Click += cancelButton_Click;
        // 
        // editButton
        // 
        editButton.BackColor = Color.White;
        editButton.FlatStyle = FlatStyle.Flat;
        editButton.Location = new Point(347, 104);
        editButton.Margin = new Padding(3, 4, 3, 4);
        editButton.Name = "editButton";
        editButton.Size = new Size(137, 37);
        editButton.TabIndex = 1;
        editButton.Text = "Sửa suất chiếu";
        editButton.UseVisualStyleBackColor = false;
        editButton.Click += ActionButton_Click;
        // 
        // createButton
        // 
        createButton.BackColor = Color.FromArgb(37, 99, 235);
        createButton.FlatAppearance.BorderSize = 0;
        createButton.FlatStyle = FlatStyle.Flat;
        createButton.ForeColor = Color.White;
        createButton.Location = new Point(194, 104);
        createButton.Margin = new Padding(3, 4, 3, 4);
        createButton.Name = "createButton";
        createButton.Size = new Size(137, 37);
        createButton.TabIndex = 2;
        createButton.Text = "Tạo suất chiếu";
        createButton.UseVisualStyleBackColor = false;
        createButton.Click += ActionButton_Click;
        // 
        // checkConflictButton
        // 
        checkConflictButton.BackColor = Color.White;
        checkConflictButton.FlatStyle = FlatStyle.Flat;
        checkConflictButton.Location = new Point(21, 104);
        checkConflictButton.Margin = new Padding(3, 4, 3, 4);
        checkConflictButton.Name = "checkConflictButton";
        checkConflictButton.Size = new Size(158, 37);
        checkConflictButton.TabIndex = 3;
        checkConflictButton.Text = "Kiểm tra trùng lịch";
        checkConflictButton.UseVisualStyleBackColor = false;
        checkConflictButton.Click += CheckConflictButton_Click;
        // 
        // statusComboBox
        // 
        statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        statusComboBox.Items.AddRange(new object[] { "Đang bán", "Sắp chiếu", "Đã hủy" });
        statusComboBox.Location = new Point(1015, 67);
        statusComboBox.Margin = new Padding(3, 4, 3, 4);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(137, 28);
        statusComboBox.TabIndex = 4;
        // 
        // formatComboBox
        // 
        formatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        formatComboBox.Items.AddRange(new object[] { "2D", "3D", "IMAX" });
        formatComboBox.Location = new Point(912, 67);
        formatComboBox.Margin = new Padding(3, 4, 3, 4);
        formatComboBox.Name = "formatComboBox";
        formatComboBox.Size = new Size(86, 28);
        formatComboBox.TabIndex = 5;
        // 
        // priceTextBox
        // 
        priceTextBox.Location = new Point(798, 67);
        priceTextBox.Margin = new Padding(3, 4, 3, 4);
        priceTextBox.Name = "priceTextBox";
        priceTextBox.Size = new Size(98, 27);
        priceTextBox.TabIndex = 6;
        priceTextBox.Text = "90000";
        // 
        // endTimePicker
        // 
        endTimePicker.CustomFormat = "HH:mm";
        endTimePicker.Format = DateTimePickerFormat.Custom;
        endTimePicker.Location = new Point(679, 67);
        endTimePicker.Margin = new Padding(3, 4, 3, 4);
        endTimePicker.Name = "endTimePicker";
        endTimePicker.ShowUpDown = true;
        endTimePicker.Size = new Size(102, 27);
        endTimePicker.TabIndex = 7;
        endTimePicker.Value = new DateTime(2026, 6, 4, 21, 0, 0, 0);
        // 
        // startTimePicker
        // 
        startTimePicker.CustomFormat = "HH:mm";
        startTimePicker.Format = DateTimePickerFormat.Custom;
        startTimePicker.Location = new Point(560, 67);
        startTimePicker.Margin = new Padding(3, 4, 3, 4);
        startTimePicker.Name = "startTimePicker";
        startTimePicker.ShowUpDown = true;
        startTimePicker.Size = new Size(102, 27);
        startTimePicker.TabIndex = 8;
        startTimePicker.Value = new DateTime(2026, 6, 4, 19, 0, 0, 0);
        // 
        // showDatePicker
        // 
        showDatePicker.Format = DateTimePickerFormat.Short;
        showDatePicker.Location = new Point(418, 67);
        showDatePicker.Margin = new Padding(3, 4, 3, 4);
        showDatePicker.Name = "showDatePicker";
        showDatePicker.Size = new Size(125, 27);
        showDatePicker.TabIndex = 9;
        // 
        // roomComboBox
        // 
        roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        roomComboBox.Location = new Point(254, 67);
        roomComboBox.Margin = new Padding(3, 4, 3, 4);
        roomComboBox.Name = "roomComboBox";
        roomComboBox.Size = new Size(148, 28);
        roomComboBox.TabIndex = 10;
        // 
        // movieComboBox
        // 
        movieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        movieComboBox.Location = new Point(21, 67);
        movieComboBox.Margin = new Padding(3, 4, 3, 4);
        movieComboBox.Name = "movieComboBox";
        movieComboBox.Size = new Size(217, 28);
        movieComboBox.TabIndex = 11;
        // 
        // formTitle
        // 
        formTitle.AutoSize = true;
        formTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        formTitle.Location = new Point(21, 19);
        formTitle.Name = "formTitle";
        formTitle.Size = new Size(207, 28);
        formTitle.TabIndex = 12;
        formTitle.Text = "Thông tin suất chiếu";
        // 
        // gridPanel
        // 
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(showtimeGrid);
        gridPanel.Controls.Add(gridTitle);
        gridPanel.Location = new Point(21, 187);
        gridPanel.Margin = new Padding(3, 4, 3, 4);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(834, 599);
        gridPanel.TabIndex = 1;
        // 
        // showtimeGrid
        // 
        showtimeGrid.AllowUserToAddRows = false;
        showtimeGrid.AllowUserToDeleteRows = false;
        showtimeGrid.BackgroundColor = Color.White;
        showtimeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        showtimeGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
        showtimeGrid.Location = new Point(21, 75);
        showtimeGrid.Margin = new Padding(3, 4, 3, 4);
        showtimeGrid.Name = "showtimeGrid";
        showtimeGrid.ReadOnly = true;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.RowHeadersWidth = 51;
        showtimeGrid.Size = new Size(791, 496);
        showtimeGrid.TabIndex = 0;
        showtimeGrid.CellClick += showtimeGrid_CellClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Mã";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 125;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Phim";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 125;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Phòng";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 125;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Ngày";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 125;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "Giờ";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 125;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.HeaderText = "Giá vé";
        dataGridViewTextBoxColumn6.MinimumWidth = 6;
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        dataGridViewTextBoxColumn6.Width = 125;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.HeaderText = "Trạng thái";
        dataGridViewTextBoxColumn7.MinimumWidth = 6;
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        dataGridViewTextBoxColumn7.Width = 125;
        // 
        // gridTitle
        // 
        gridTitle.AutoSize = true;
        gridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        gridTitle.Location = new Point(21, 24);
        gridTitle.Name = "gridTitle";
        gridTitle.Size = new Size(207, 28);
        gridTitle.TabIndex = 1;
        gridTitle.Text = "Danh sách lịch chiếu";
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailText);
        detailPanel.Controls.Add(detailTitle);
        detailPanel.Location = new Point(873, 187);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(345, 599);
        detailPanel.TabIndex = 0;
        // 
        // detailText
        // 
        detailText.Font = new Font("Segoe UI", 10F);
        detailText.Location = new Point(23, 80);
        detailText.Name = "detailText";
        detailText.Size = new Size(297, 213);
        detailText.TabIndex = 0;
        detailText.Text = "Fake rule:\r\nPhòng 1 + giờ bắt đầu 19:00 sẽ báo trùng lịch.\r\n\r\nKhông ghi database, không gọi API thật.";
        // 
        // detailTitle
        // 
        detailTitle.AutoSize = true;
        detailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        detailTitle.Location = new Point(21, 24);
        detailTitle.Name = "detailTitle";
        detailTitle.Size = new Size(177, 28);
        detailTitle.TabIndex = 1;
        detailTitle.Text = "Ghi chú vận hành";
        // 
        // ShowtimeManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1239, 808);
        Controls.Add(detailPanel);
        Controls.Add(gridPanel);
        Controls.Add(inputPanel);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ShowtimeManagementForm";
        Text = "Quản lý lịch chiếu";
        Load += ShowtimeManagementForm_Load;
        inputPanel.ResumeLayout(false);
        inputPanel.PerformLayout();
        gridPanel.ResumeLayout(false);
        gridPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        detailPanel.ResumeLayout(false);
        detailPanel.PerformLayout();
        ResumeLayout(false);
    }

    private Label formTitle;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private Label gridTitle;
    private Label detailText;
    private Label detailTitle;
}
