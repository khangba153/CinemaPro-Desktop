namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class RoomManagementForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel actionPanel = null!;
    private Button addRoomButton = null!;
    private Button editRoomButton = null!;
    private Button createSeatButton = null!;
    private Button maintenanceButton = null!;
    private Panel gridPanel = null!;
    private DataGridView roomGrid = null!;
    private Panel detailPanel = null!;
    private TextBox roomNameTextBox = null!;
    private ComboBox roomTypeComboBox = null!;
    private NumericUpDown rowCountInput = null!;
    private NumericUpDown seatPerRowInput = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        actionPanel = new Panel();
        maintenanceButton = new Button();
        createSeatButton = new Button();
        editRoomButton = new Button();
        addRoomButton = new Button();
        gridPanel = new Panel();
        roomGrid = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        title = new Label();
        detailPanel = new Panel();
        seatLabel = new Label();
        seatPerRowInput = new NumericUpDown();
        rowLabel = new Label();
        rowCountInput = new NumericUpDown();
        typeLabel = new Label();
        roomTypeComboBox = new ComboBox();
        nameLabel = new Label();
        roomNameTextBox = new TextBox();
        detailTitle = new Label();
        actionPanel.SuspendLayout();
        gridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)roomGrid).BeginInit();
        detailPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)seatPerRowInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)rowCountInput).BeginInit();
        SuspendLayout();
        // 
        // actionPanel
        // 
        actionPanel.BackColor = Color.White;
        actionPanel.BorderStyle = BorderStyle.FixedSingle;
        actionPanel.Controls.Add(maintenanceButton);
        actionPanel.Controls.Add(createSeatButton);
        actionPanel.Controls.Add(editRoomButton);
        actionPanel.Controls.Add(addRoomButton);
        actionPanel.Location = new Point(21, 19);
        actionPanel.Margin = new Padding(3, 4, 3, 4);
        actionPanel.Name = "actionPanel";
        actionPanel.Size = new Size(1197, 82);
        actionPanel.TabIndex = 2;
        // 
        // maintenanceButton
        // 
        maintenanceButton.BackColor = Color.White;
        maintenanceButton.FlatStyle = FlatStyle.Flat;
        maintenanceButton.ForeColor = Color.FromArgb(220, 38, 38);
        maintenanceButton.Location = new Point(480, 21);
        maintenanceButton.Margin = new Padding(3, 4, 3, 4);
        maintenanceButton.Name = "maintenanceButton";
        maintenanceButton.Size = new Size(160, 43);
        maintenanceButton.TabIndex = 0;
        maintenanceButton.Text = "Bảo trì phòng";
        maintenanceButton.UseVisualStyleBackColor = false;
        // 
        // createSeatButton
        // 
        createSeatButton.BackColor = Color.White;
        createSeatButton.FlatStyle = FlatStyle.Flat;
        createSeatButton.Location = new Point(327, 21);
        createSeatButton.Margin = new Padding(3, 4, 3, 4);
        createSeatButton.Name = "createSeatButton";
        createSeatButton.Size = new Size(137, 43);
        createSeatButton.TabIndex = 1;
        createSeatButton.Text = "Tạo ghế";
        createSeatButton.UseVisualStyleBackColor = false;
        // 
        // editRoomButton
        // 
        editRoomButton.BackColor = Color.White;
        editRoomButton.FlatStyle = FlatStyle.Flat;
        editRoomButton.Location = new Point(174, 21);
        editRoomButton.Margin = new Padding(3, 4, 3, 4);
        editRoomButton.Name = "editRoomButton";
        editRoomButton.Size = new Size(137, 43);
        editRoomButton.TabIndex = 2;
        editRoomButton.Text = "Sửa phòng";
        editRoomButton.UseVisualStyleBackColor = false;
        // 
        // addRoomButton
        // 
        addRoomButton.BackColor = Color.FromArgb(37, 99, 235);
        addRoomButton.FlatAppearance.BorderSize = 0;
        addRoomButton.FlatStyle = FlatStyle.Flat;
        addRoomButton.ForeColor = Color.White;
        addRoomButton.Location = new Point(21, 21);
        addRoomButton.Margin = new Padding(3, 4, 3, 4);
        addRoomButton.Name = "addRoomButton";
        addRoomButton.Size = new Size(137, 43);
        addRoomButton.TabIndex = 3;
        addRoomButton.Text = "Thêm phòng";
        addRoomButton.UseVisualStyleBackColor = false;
        addRoomButton.Click += AddRoomButton_Click;
        // 
        // gridPanel
        // 
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(roomGrid);
        gridPanel.Controls.Add(title);
        gridPanel.Location = new Point(21, 125);
        gridPanel.Margin = new Padding(3, 4, 3, 4);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(788, 661);
        gridPanel.TabIndex = 1;
        // 
        // roomGrid
        // 
        roomGrid.AllowUserToAddRows = false;
        roomGrid.AllowUserToDeleteRows = false;
        roomGrid.BackgroundColor = Color.White;
        roomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        roomGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
        roomGrid.Location = new Point(21, 75);
        roomGrid.Margin = new Padding(3, 4, 3, 4);
        roomGrid.Name = "roomGrid";
        roomGrid.ReadOnly = true;
        roomGrid.RowHeadersVisible = false;
        roomGrid.RowHeadersWidth = 51;
        roomGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        roomGrid.Size = new Size(745, 560);
        roomGrid.TabIndex = 0;
        roomGrid.SelectionChanged += RoomGrid_SelectionChanged;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Mã phòng";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 125;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Tên phòng";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 125;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Loại phòng";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 125;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Số hàng";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 125;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "Ghế/hàng";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 125;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.HeaderText = "Trạng thái";
        dataGridViewTextBoxColumn6.MinimumWidth = 6;
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        dataGridViewTextBoxColumn6.Width = 125;
        // 
        // title
        // 
        title.AutoSize = true;
        title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        title.Location = new Point(21, 24);
        title.Name = "title";
        title.Size = new Size(233, 28);
        title.TabIndex = 1;
        title.Text = "Danh sách phòng chiếu";
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(seatLabel);
        detailPanel.Controls.Add(seatPerRowInput);
        detailPanel.Controls.Add(rowLabel);
        detailPanel.Controls.Add(rowCountInput);
        detailPanel.Controls.Add(typeLabel);
        detailPanel.Controls.Add(roomTypeComboBox);
        detailPanel.Controls.Add(nameLabel);
        detailPanel.Controls.Add(roomNameTextBox);
        detailPanel.Controls.Add(detailTitle);
        detailPanel.Location = new Point(827, 125);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(391, 661);
        detailPanel.TabIndex = 0;
        // 
        // seatLabel
        // 
        seatLabel.Location = new Point(199, 261);
        seatLabel.Name = "seatLabel";
        seatLabel.Size = new Size(114, 31);
        seatLabel.TabIndex = 0;
        seatLabel.Text = "Ghế mỗi hàng";
        // 
        // seatPerRowInput
        // 
        seatPerRowInput.Location = new Point(199, 293);
        seatPerRowInput.Margin = new Padding(3, 4, 3, 4);
        seatPerRowInput.Name = "seatPerRowInput";
        seatPerRowInput.Size = new Size(137, 27);
        seatPerRowInput.TabIndex = 1;
        seatPerRowInput.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // rowLabel
        // 
        rowLabel.Location = new Point(25, 261);
        rowLabel.Name = "rowLabel";
        rowLabel.Size = new Size(114, 31);
        rowLabel.TabIndex = 2;
        rowLabel.Text = "Số hàng ghế";
        // 
        // rowCountInput
        // 
        rowCountInput.Location = new Point(25, 293);
        rowCountInput.Margin = new Padding(3, 4, 3, 4);
        rowCountInput.Name = "rowCountInput";
        rowCountInput.Size = new Size(137, 27);
        rowCountInput.TabIndex = 3;
        rowCountInput.Value = new decimal(new int[] { 6, 0, 0, 0 });
        // 
        // typeLabel
        // 
        typeLabel.Location = new Point(25, 173);
        typeLabel.Name = "typeLabel";
        typeLabel.Size = new Size(114, 31);
        typeLabel.TabIndex = 4;
        typeLabel.Text = "Loại phòng";
        // 
        // roomTypeComboBox
        // 
        roomTypeComboBox.Items.AddRange(new object[] { "2D", "3D", "IMAX", "VIP" });
        roomTypeComboBox.Location = new Point(25, 205);
        roomTypeComboBox.Margin = new Padding(3, 4, 3, 4);
        roomTypeComboBox.Name = "roomTypeComboBox";
        roomTypeComboBox.Size = new Size(331, 28);
        roomTypeComboBox.TabIndex = 5;
        // 
        // nameLabel
        // 
        nameLabel.Location = new Point(25, 85);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(114, 31);
        nameLabel.TabIndex = 6;
        nameLabel.Text = "Tên phòng";
        // 
        // roomNameTextBox
        // 
        roomNameTextBox.Location = new Point(25, 117);
        roomNameTextBox.Margin = new Padding(3, 4, 3, 4);
        roomNameTextBox.Name = "roomNameTextBox";
        roomNameTextBox.Size = new Size(331, 27);
        roomNameTextBox.TabIndex = 7;
        roomNameTextBox.Text = "Phòng 1";
        // 
        // detailTitle
        // 
        detailTitle.AutoSize = true;
        detailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        detailTitle.Location = new Point(21, 24);
        detailTitle.Name = "detailTitle";
        detailTitle.Size = new Size(170, 28);
        detailTitle.TabIndex = 8;
        detailTitle.Text = "Thông tin phòng";
        // 
        // RoomManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1239, 808);
        Controls.Add(detailPanel);
        Controls.Add(gridPanel);
        Controls.Add(actionPanel);
        Margin = new Padding(3, 4, 3, 4);
        Name = "RoomManagementForm";
        Text = "Quản lý phòng chiếu";
        Load += RoomManagementForm_Load;
        actionPanel.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)roomGrid).EndInit();
        detailPanel.ResumeLayout(false);
        detailPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)seatPerRowInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)rowCountInput).EndInit();
        ResumeLayout(false);
    }
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private Label title;
    private Label seatLabel;
    private Label rowLabel;
    private Label typeLabel;
    private Label nameLabel;
    private Label detailTitle;
}
