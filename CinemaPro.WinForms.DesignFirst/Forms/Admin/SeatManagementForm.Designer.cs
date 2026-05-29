namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class SeatManagementForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel filterPanel = null!;
    private ComboBox roomComboBox = null!;
    private Button changeStatusButton = null!;
    private Button maintenanceButton = null!;
    private Button refreshButton = null!;
    private Panel seatPanel = null!;
    private Panel detailPanel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        filterPanel = new Panel();
        roomComboBox = new ComboBox();
        changeStatusButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        seatPanel = new Panel();
        detailPanel = new Panel();
        var roomLabel = new Label();
        var screenLabel = new Label();
        var title = new Label();
        var detailTitle = new Label();
        var legend1 = new Label();
        var legend2 = new Label();
        var legend3 = new Label();
        var legend4 = new Label();
        filterPanel.SuspendLayout();
        seatPanel.SuspendLayout();
        detailPanel.SuspendLayout();
        SuspendLayout();
        filterPanel.BackColor = Color.White;
        filterPanel.BorderStyle = BorderStyle.FixedSingle;
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Controls.Add(maintenanceButton);
        filterPanel.Controls.Add(changeStatusButton);
        filterPanel.Controls.Add(roomComboBox);
        filterPanel.Controls.Add(roomLabel);
        filterPanel.Location = new Point(18, 14);
        filterPanel.Size = new Size(1048, 62);
        roomLabel.AutoSize = true;
        roomLabel.Location = new Point(18, 23);
        roomLabel.Text = "Chọn phòng";
        roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        roomComboBox.Location = new Point(104, 19);
        roomComboBox.Size = new Size(220, 23);
        changeStatusButton.BackColor = Color.FromArgb(37, 99, 235);
        changeStatusButton.FlatAppearance.BorderSize = 0;
        changeStatusButton.FlatStyle = FlatStyle.Flat;
        changeStatusButton.ForeColor = Color.White;
        changeStatusButton.Location = new Point(352, 15);
        changeStatusButton.Size = new Size(138, 34);
        changeStatusButton.Text = "Đổi trạng thái ghế";
        changeStatusButton.Click += ActionButton_Click;
        maintenanceButton.BackColor = Color.White;
        maintenanceButton.FlatStyle = FlatStyle.Flat;
        maintenanceButton.Location = new Point(506, 15);
        maintenanceButton.Size = new Size(120, 34);
        maintenanceButton.Text = "Đặt bảo trì";
        maintenanceButton.Click += ActionButton_Click;
        refreshButton.BackColor = Color.White;
        refreshButton.FlatStyle = FlatStyle.Flat;
        refreshButton.Location = new Point(642, 15);
        refreshButton.Size = new Size(100, 34);
        refreshButton.Text = "Làm mới";
        refreshButton.Click += ActionButton_Click;
        seatPanel.BackColor = Color.White;
        seatPanel.BorderStyle = BorderStyle.FixedSingle;
        seatPanel.Controls.Add(screenLabel);
        seatPanel.Controls.Add(title);
        seatPanel.Location = new Point(18, 94);
        seatPanel.Size = new Size(690, 496);
        title.AutoSize = true;
        title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        title.Location = new Point(18, 18);
        title.Text = "Sơ đồ ghế phòng chiếu";
        screenLabel.BackColor = Color.FromArgb(226, 232, 240);
        screenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        screenLabel.Location = new Point(120, 58);
        screenLabel.Size = new Size(420, 28);
        screenLabel.Text = "MÀN HÌNH";
        screenLabel.TextAlign = ContentAlignment.MiddleCenter;
        var designerSeatButtonA1 = new Button { Name = "designerSeatButtonA1", Text = "A1", Size = new Size(48, 34), Location = new Point(90, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA2 = new Button { Name = "designerSeatButtonA2", Text = "A2", Size = new Size(48, 34), Location = new Point(148, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA3 = new Button { Name = "designerSeatButtonA3", Text = "A3", Size = new Size(48, 34), Location = new Point(206, 120), BackColor = Color.FromArgb(220, 38, 38), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA4 = new Button { Name = "designerSeatButtonA4", Text = "A4", Size = new Size(48, 34), Location = new Point(264, 120), BackColor = Color.FromArgb(220, 38, 38), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA5 = new Button { Name = "designerSeatButtonA5", Text = "A5", Size = new Size(48, 34), Location = new Point(322, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA6 = new Button { Name = "designerSeatButtonA6", Text = "A6", Size = new Size(48, 34), Location = new Point(380, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA7 = new Button { Name = "designerSeatButtonA7", Text = "A7", Size = new Size(48, 34), Location = new Point(438, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonA8 = new Button { Name = "designerSeatButtonA8", Text = "A8", Size = new Size(48, 34), Location = new Point(496, 120), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB1 = new Button { Name = "designerSeatButtonB1", Text = "B1", Size = new Size(48, 34), Location = new Point(90, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB2 = new Button { Name = "designerSeatButtonB2", Text = "B2", Size = new Size(48, 34), Location = new Point(148, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB3 = new Button { Name = "designerSeatButtonB3", Text = "B3", Size = new Size(48, 34), Location = new Point(206, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB4 = new Button { Name = "designerSeatButtonB4", Text = "B4", Size = new Size(48, 34), Location = new Point(264, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB5 = new Button { Name = "designerSeatButtonB5", Text = "B5", Size = new Size(48, 34), Location = new Point(322, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB6 = new Button { Name = "designerSeatButtonB6", Text = "B6", Size = new Size(48, 34), Location = new Point(380, 168), BackColor = Color.FromArgb(220, 38, 38), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB7 = new Button { Name = "designerSeatButtonB7", Text = "B7", Size = new Size(48, 34), Location = new Point(438, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonB8 = new Button { Name = "designerSeatButtonB8", Text = "B8", Size = new Size(48, 34), Location = new Point(496, 168), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC1 = new Button { Name = "designerSeatButtonC1", Text = "C1", Size = new Size(48, 34), Location = new Point(90, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC2 = new Button { Name = "designerSeatButtonC2", Text = "C2", Size = new Size(48, 34), Location = new Point(148, 216), BackColor = Color.FromArgb(148, 163, 184), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC3 = new Button { Name = "designerSeatButtonC3", Text = "C3", Size = new Size(48, 34), Location = new Point(206, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC4 = new Button { Name = "designerSeatButtonC4", Text = "C4", Size = new Size(48, 34), Location = new Point(264, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC5 = new Button { Name = "designerSeatButtonC5", Text = "C5", Size = new Size(48, 34), Location = new Point(322, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC6 = new Button { Name = "designerSeatButtonC6", Text = "C6", Size = new Size(48, 34), Location = new Point(380, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC7 = new Button { Name = "designerSeatButtonC7", Text = "C7", Size = new Size(48, 34), Location = new Point(438, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        var designerSeatButtonC8 = new Button { Name = "designerSeatButtonC8", Text = "C8", Size = new Size(48, 34), Location = new Point(496, 216), BackColor = Color.White, ForeColor = Color.FromArgb(17, 24, 39), FlatStyle = FlatStyle.Flat };
        seatPanel.Controls.AddRange(new Control[]
        {
            designerSeatButtonA1, designerSeatButtonA2, designerSeatButtonA3, designerSeatButtonA4,
            designerSeatButtonA5, designerSeatButtonA6, designerSeatButtonA7, designerSeatButtonA8,
            designerSeatButtonB1, designerSeatButtonB2, designerSeatButtonB3, designerSeatButtonB4,
            designerSeatButtonB5, designerSeatButtonB6, designerSeatButtonB7, designerSeatButtonB8,
            designerSeatButtonC1, designerSeatButtonC2, designerSeatButtonC3, designerSeatButtonC4,
            designerSeatButtonC5, designerSeatButtonC6, designerSeatButtonC7, designerSeatButtonC8
        });
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(legend4);
        detailPanel.Controls.Add(legend3);
        detailPanel.Controls.Add(legend2);
        detailPanel.Controls.Add(legend1);
        detailPanel.Controls.Add(detailTitle);
        detailPanel.Location = new Point(724, 94);
        detailPanel.Size = new Size(342, 496);
        detailTitle.AutoSize = true;
        detailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        detailTitle.Location = new Point(18, 18);
        detailTitle.Text = "Chú thích ghế";
        legend1.BackColor = Color.White;
        legend1.BorderStyle = BorderStyle.FixedSingle;
        legend1.Location = new Point(24, 64);
        legend1.Size = new Size(280, 36);
        legend1.Text = "Trống";
        legend1.TextAlign = ContentAlignment.MiddleCenter;
        legend2.BackColor = Color.FromArgb(37, 99, 235);
        legend2.ForeColor = Color.White;
        legend2.Location = new Point(24, 116);
        legend2.Size = new Size(280, 36);
        legend2.Text = "Đang chọn";
        legend2.TextAlign = ContentAlignment.MiddleCenter;
        legend3.BackColor = Color.FromArgb(220, 38, 38);
        legend3.ForeColor = Color.White;
        legend3.Location = new Point(24, 168);
        legend3.Size = new Size(280, 36);
        legend3.Text = "Đã bán";
        legend3.TextAlign = ContentAlignment.MiddleCenter;
        legend4.BackColor = Color.FromArgb(148, 163, 184);
        legend4.ForeColor = Color.White;
        legend4.Location = new Point(24, 220);
        legend4.Size = new Size(280, 36);
        legend4.Text = "Bảo trì";
        legend4.TextAlign = ContentAlignment.MiddleCenter;
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
}
