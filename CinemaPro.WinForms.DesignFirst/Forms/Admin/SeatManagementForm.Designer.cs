namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class SeatManagementForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel filterPanel = null!;
    private ComboBox roomComboBox = null!;
    private TextBox rowCountTextBox = null!;
    private TextBox columnCountTextBox = null!;
    private Button createLayoutButton = null!;
    private Button changeStatusButton = null!;
    private Button maintenanceButton = null!;
    private Button refreshButton = null!;
    private Panel seatPanel = null!;
    private Panel detailPanel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        filterPanel = new Panel();
        roomComboBox = new ComboBox();
        rowCountTextBox = new TextBox();
        columnCountTextBox = new TextBox();
        createLayoutButton = new Button();
        changeStatusButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        seatPanel = new Panel();
        detailPanel = new Panel();
        var roomLabel = new Label();
        var rowCountLabel = new Label();
        var columnCountLabel = new Label();
        var screenLabel = new Label();
        var titleLabel = new Label();
        var detailTitleLabel = new Label();
        var legendAvailableLabel = new Label();
        var legendSelectedLabel = new Label();
        var legendSoldLabel = new Label();
        var legendMaintenanceLabel = new Label();
        filterPanel.SuspendLayout();
        seatPanel.SuspendLayout();
        detailPanel.SuspendLayout();
        SuspendLayout();
        // 
        // filterPanel
        // 
        filterPanel.BackColor = Color.White;
        filterPanel.BorderStyle = BorderStyle.FixedSingle;
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Controls.Add(maintenanceButton);
        filterPanel.Controls.Add(changeStatusButton);
        filterPanel.Controls.Add(createLayoutButton);
        filterPanel.Controls.Add(columnCountTextBox);
        filterPanel.Controls.Add(columnCountLabel);
        filterPanel.Controls.Add(rowCountTextBox);
        filterPanel.Controls.Add(rowCountLabel);
        filterPanel.Controls.Add(roomComboBox);
        filterPanel.Controls.Add(roomLabel);
        filterPanel.Location = new Point(18, 14);
        filterPanel.Name = "filterPanel";
        filterPanel.Size = new Size(1048, 62);
        filterPanel.TabIndex = 0;
        roomLabel.AutoSize = true;
        roomLabel.Location = new Point(18, 23);
        roomLabel.Name = "roomLabel";
        roomLabel.Size = new Size(68, 15);
        roomLabel.TabIndex = 0;
        roomLabel.Text = "Chọn phòng";
        roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        roomComboBox.Location = new Point(94, 19);
        roomComboBox.Name = "roomComboBox";
        roomComboBox.Size = new Size(154, 23);
        roomComboBox.TabIndex = 1;
        roomComboBox.SelectedIndexChanged += RoomComboBox_SelectedIndexChanged;
        rowCountLabel.AutoSize = true;
        rowCountLabel.Location = new Point(268, 23);
        rowCountLabel.Name = "rowCountLabel";
        rowCountLabel.Size = new Size(50, 15);
        rowCountLabel.TabIndex = 2;
        rowCountLabel.Text = "Số hàng";
        rowCountTextBox.Location = new Point(326, 19);
        rowCountTextBox.Name = "rowCountTextBox";
        rowCountTextBox.Size = new Size(44, 23);
        rowCountTextBox.TabIndex = 3;
        rowCountTextBox.Text = "6";
        columnCountLabel.AutoSize = true;
        columnCountLabel.Location = new Point(388, 23);
        columnCountLabel.Name = "columnCountLabel";
        columnCountLabel.Size = new Size(37, 15);
        columnCountLabel.TabIndex = 4;
        columnCountLabel.Text = "Số cột";
        columnCountTextBox.Location = new Point(438, 19);
        columnCountTextBox.Name = "columnCountTextBox";
        columnCountTextBox.Size = new Size(44, 23);
        columnCountTextBox.TabIndex = 5;
        columnCountTextBox.Text = "8";
        createLayoutButton.BackColor = Color.FromArgb(37, 99, 235);
        createLayoutButton.FlatAppearance.BorderSize = 0;
        createLayoutButton.FlatStyle = FlatStyle.Flat;
        createLayoutButton.ForeColor = Color.White;
        createLayoutButton.Location = new Point(504, 15);
        createLayoutButton.Name = "createLayoutButton";
        createLayoutButton.Size = new Size(120, 34);
        createLayoutButton.TabIndex = 6;
        createLayoutButton.Text = "Tạo sơ đồ";
        createLayoutButton.UseVisualStyleBackColor = false;
        createLayoutButton.Click += CreateLayoutButton_Click;
        changeStatusButton.BackColor = Color.FromArgb(37, 99, 235);
        changeStatusButton.FlatAppearance.BorderSize = 0;
        changeStatusButton.FlatStyle = FlatStyle.Flat;
        changeStatusButton.ForeColor = Color.White;
        changeStatusButton.Location = new Point(646, 15);
        changeStatusButton.Name = "changeStatusButton";
        changeStatusButton.Size = new Size(128, 34);
        changeStatusButton.TabIndex = 7;
        changeStatusButton.Text = "Đổi trạng thái ghế";
        changeStatusButton.UseVisualStyleBackColor = false;
        changeStatusButton.Click += ActionButton_Click;
        maintenanceButton.BackColor = Color.White;
        maintenanceButton.FlatStyle = FlatStyle.Flat;
        maintenanceButton.Location = new Point(792, 15);
        maintenanceButton.Name = "maintenanceButton";
        maintenanceButton.Size = new Size(104, 34);
        maintenanceButton.TabIndex = 8;
        maintenanceButton.Text = "Đặt bảo trì";
        maintenanceButton.UseVisualStyleBackColor = false;
        maintenanceButton.Click += ActionButton_Click;
        refreshButton.BackColor = Color.White;
        refreshButton.FlatStyle = FlatStyle.Flat;
        refreshButton.Location = new Point(914, 15);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(92, 34);
        refreshButton.TabIndex = 9;
        refreshButton.Text = "Làm mới";
        refreshButton.UseVisualStyleBackColor = false;
        refreshButton.Click += RefreshButton_Click;
        // 
        // seatPanel
        // 
        seatPanel.BackColor = Color.White;
        seatPanel.BorderStyle = BorderStyle.FixedSingle;
        seatPanel.Controls.Add(screenLabel);
        seatPanel.Controls.Add(titleLabel);
        seatPanel.Location = new Point(18, 94);
        seatPanel.Name = "seatPanel";
        seatPanel.Size = new Size(690, 496);
        seatPanel.TabIndex = 1;
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        titleLabel.Location = new Point(18, 18);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(188, 21);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Sơ đồ ghế phòng chiếu";
        screenLabel.BackColor = Color.FromArgb(226, 232, 240);
        screenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        screenLabel.Location = new Point(120, 58);
        screenLabel.Name = "screenLabel";
        screenLabel.Size = new Size(420, 28);
        screenLabel.TabIndex = 1;
        screenLabel.Text = "MÀN HÌNH";
        screenLabel.TextAlign = ContentAlignment.MiddleCenter;
        var designerSeatButtonA1 = CreateDesignerSeatButton("A1", 90, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonA2 = CreateDesignerSeatButton("A2", 148, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonA3 = CreateDesignerSeatButton("A3", 206, 120, Color.FromArgb(220, 38, 38), Color.White);
        var designerSeatButtonA4 = CreateDesignerSeatButton("A4", 264, 120, Color.FromArgb(220, 38, 38), Color.White);
        var designerSeatButtonA5 = CreateDesignerSeatButton("A5", 322, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonA6 = CreateDesignerSeatButton("A6", 380, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonA7 = CreateDesignerSeatButton("A7", 438, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonA8 = CreateDesignerSeatButton("A8", 496, 120, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB1 = CreateDesignerSeatButton("B1", 90, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB2 = CreateDesignerSeatButton("B2", 148, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB3 = CreateDesignerSeatButton("B3", 206, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB4 = CreateDesignerSeatButton("B4", 264, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB5 = CreateDesignerSeatButton("B5", 322, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB6 = CreateDesignerSeatButton("B6", 380, 168, Color.FromArgb(220, 38, 38), Color.White);
        var designerSeatButtonB7 = CreateDesignerSeatButton("B7", 438, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonB8 = CreateDesignerSeatButton("B8", 496, 168, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC1 = CreateDesignerSeatButton("C1", 90, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC2 = CreateDesignerSeatButton("C2", 148, 216, Color.FromArgb(148, 163, 184), Color.White);
        var designerSeatButtonC3 = CreateDesignerSeatButton("C3", 206, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC4 = CreateDesignerSeatButton("C4", 264, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC5 = CreateDesignerSeatButton("C5", 322, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC6 = CreateDesignerSeatButton("C6", 380, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC7 = CreateDesignerSeatButton("C7", 438, 216, Color.White, Color.FromArgb(17, 24, 39));
        var designerSeatButtonC8 = CreateDesignerSeatButton("C8", 496, 216, Color.White, Color.FromArgb(17, 24, 39));
        seatPanel.Controls.AddRange(new Control[]
        {
            designerSeatButtonA1, designerSeatButtonA2, designerSeatButtonA3, designerSeatButtonA4,
            designerSeatButtonA5, designerSeatButtonA6, designerSeatButtonA7, designerSeatButtonA8,
            designerSeatButtonB1, designerSeatButtonB2, designerSeatButtonB3, designerSeatButtonB4,
            designerSeatButtonB5, designerSeatButtonB6, designerSeatButtonB7, designerSeatButtonB8,
            designerSeatButtonC1, designerSeatButtonC2, designerSeatButtonC3, designerSeatButtonC4,
            designerSeatButtonC5, designerSeatButtonC6, designerSeatButtonC7, designerSeatButtonC8
        });
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(legendMaintenanceLabel);
        detailPanel.Controls.Add(legendSoldLabel);
        detailPanel.Controls.Add(legendSelectedLabel);
        detailPanel.Controls.Add(legendAvailableLabel);
        detailPanel.Controls.Add(detailTitleLabel);
        detailPanel.Location = new Point(724, 94);
        detailPanel.Name = "detailPanel";
        detailPanel.Size = new Size(342, 496);
        detailPanel.TabIndex = 2;
        detailTitleLabel.AutoSize = true;
        detailTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        detailTitleLabel.Location = new Point(18, 18);
        detailTitleLabel.Name = "detailTitleLabel";
        detailTitleLabel.Size = new Size(104, 21);
        detailTitleLabel.TabIndex = 0;
        detailTitleLabel.Text = "Chú thích ghế";
        legendAvailableLabel.BackColor = Color.White;
        legendAvailableLabel.BorderStyle = BorderStyle.FixedSingle;
        legendAvailableLabel.Location = new Point(24, 64);
        legendAvailableLabel.Name = "legendAvailableLabel";
        legendAvailableLabel.Size = new Size(280, 36);
        legendAvailableLabel.TabIndex = 1;
        legendAvailableLabel.Text = "Trống";
        legendAvailableLabel.TextAlign = ContentAlignment.MiddleCenter;
        legendSelectedLabel.BackColor = Color.FromArgb(37, 99, 235);
        legendSelectedLabel.ForeColor = Color.White;
        legendSelectedLabel.Location = new Point(24, 116);
        legendSelectedLabel.Name = "legendSelectedLabel";
        legendSelectedLabel.Size = new Size(280, 36);
        legendSelectedLabel.TabIndex = 2;
        legendSelectedLabel.Text = "Đang chọn";
        legendSelectedLabel.TextAlign = ContentAlignment.MiddleCenter;
        legendSoldLabel.BackColor = Color.FromArgb(220, 38, 38);
        legendSoldLabel.ForeColor = Color.White;
        legendSoldLabel.Location = new Point(24, 168);
        legendSoldLabel.Name = "legendSoldLabel";
        legendSoldLabel.Size = new Size(280, 36);
        legendSoldLabel.TabIndex = 3;
        legendSoldLabel.Text = "Đã bán";
        legendSoldLabel.TextAlign = ContentAlignment.MiddleCenter;
        legendMaintenanceLabel.BackColor = Color.FromArgb(148, 163, 184);
        legendMaintenanceLabel.ForeColor = Color.White;
        legendMaintenanceLabel.Location = new Point(24, 220);
        legendMaintenanceLabel.Name = "legendMaintenanceLabel";
        legendMaintenanceLabel.Size = new Size(280, 36);
        legendMaintenanceLabel.TabIndex = 4;
        legendMaintenanceLabel.Text = "Bảo trì";
        legendMaintenanceLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SeatManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1084, 606);
        Controls.Add(detailPanel);
        Controls.Add(seatPanel);
        Controls.Add(filterPanel);
        Name = "SeatManagementForm";
        Text = "Quản lý ghế";
        Load += SeatManagementForm_Load;
        filterPanel.ResumeLayout(false);
        filterPanel.PerformLayout();
        seatPanel.ResumeLayout(false);
        seatPanel.PerformLayout();
        detailPanel.ResumeLayout(false);
        detailPanel.PerformLayout();
        ResumeLayout(false);
    }

    private static Button CreateDesignerSeatButton(string text, int x, int y, Color backColor, Color foreColor)
    {
        var button = new Button
        {
            Name = $"designerSeatButton{text}",
            Text = text,
            Size = new Size(48, 34),
            Location = new Point(x, y),
            BackColor = backColor,
            ForeColor = foreColor,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 8F, FontStyle.Bold)
        };

        button.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        return button;
    }
}