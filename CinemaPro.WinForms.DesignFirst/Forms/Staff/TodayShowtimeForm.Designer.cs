namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

partial class TodayShowtimeForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel showtimeCountPanel = null!;
    private Label showtimeCountValueLabel = null!;
    private Panel sellingPanel = null!;
    private Label sellingValueLabel = null!;
    private Panel gridPanel = null!;
    private DataGridView showtimeGrid = null!;
    private Panel timelinePanel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        showtimeCountPanel = new Panel();
        showtimeCountValueLabel = new Label();
        sellingPanel = new Panel();
        sellingValueLabel = new Label();
        gridPanel = new Panel();
        showtimeGrid = new DataGridView();
        timelinePanel = new Panel();
        var label1 = new Label();
        var label2 = new Label();
        var gridTitle = new Label();
        var timelineTitle = new Label();
        var timelineText = new Label();
        showtimeCountPanel.SuspendLayout();
        sellingPanel.SuspendLayout();
        gridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        timelinePanel.SuspendLayout();
        SuspendLayout();
        showtimeCountPanel.BackColor = Color.White;
        showtimeCountPanel.BorderStyle = BorderStyle.FixedSingle;
        showtimeCountPanel.Controls.Add(showtimeCountValueLabel);
        showtimeCountPanel.Controls.Add(label1);
        showtimeCountPanel.Location = new Point(18, 14);
        showtimeCountPanel.Size = new Size(250, 92);
        label1.Location = new Point(18, 16);
        label1.Text = "Suất chiếu hôm nay";
        showtimeCountValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        showtimeCountValueLabel.ForeColor = Color.FromArgb(37, 99, 235);
        showtimeCountValueLabel.Location = new Point(18, 38);
        showtimeCountValueLabel.Size = new Size(120, 42);
        showtimeCountValueLabel.Text = "4";
        sellingPanel.BackColor = Color.White;
        sellingPanel.BorderStyle = BorderStyle.FixedSingle;
        sellingPanel.Controls.Add(sellingValueLabel);
        sellingPanel.Controls.Add(label2);
        sellingPanel.Location = new Point(284, 14);
        sellingPanel.Size = new Size(250, 92);
        label2.Location = new Point(18, 16);
        label2.Text = "Đang mở bán";
        sellingValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        sellingValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        sellingValueLabel.Location = new Point(18, 38);
        sellingValueLabel.Size = new Size(120, 42);
        sellingValueLabel.Text = "4";
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(showtimeGrid);
        gridPanel.Controls.Add(gridTitle);
        gridPanel.Location = new Point(18, 126);
        gridPanel.Size = new Size(710, 464);
        gridTitle.AutoSize = true;
        gridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        gridTitle.Location = new Point(18, 18);
        gridTitle.Text = "Danh sách suất chiếu";
        showtimeGrid.AllowUserToAddRows = false;
        showtimeGrid.AllowUserToDeleteRows = false;
        showtimeGrid.BackgroundColor = Color.White;
        showtimeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        showtimeGrid.Columns.Add("colMovie", "Tên phim");
        showtimeGrid.Columns.Add("colRoom", "Phòng");
        showtimeGrid.Columns.Add("colStart", "Giờ bắt đầu");
        showtimeGrid.Columns.Add("colEnd", "Giờ kết thúc");
        showtimeGrid.Columns.Add("colPrice", "Giá vé");
        showtimeGrid.Columns.Add("colStatus", "Trạng thái");
        showtimeGrid.Location = new Point(18, 56);
        showtimeGrid.ReadOnly = true;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.Size = new Size(672, 386);
        showtimeGrid.Rows.Add("Avengers: Endgame", "Phòng 2", "19:30", "22:32", "90.000 đ", "Đang bán");
        timelinePanel.BackColor = Color.White;
        timelinePanel.BorderStyle = BorderStyle.FixedSingle;
        timelinePanel.Controls.Add(timelineText);
        timelinePanel.Controls.Add(timelineTitle);
        timelinePanel.Location = new Point(744, 126);
        timelinePanel.Size = new Size(322, 464);
        timelineTitle.AutoSize = true;
        timelineTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        timelineTitle.Location = new Point(18, 18);
        timelineTitle.Text = "Timeline theo phòng";
        timelineText.Font = new Font("Segoe UI", 10F);
        timelineText.Location = new Point(20, 60);
        timelineText.Size = new Size(280, 260);
        timelineText.Text = "Phòng 1\r\n09:00 Kung Fu Panda 4\r\n19:00 Lật Mặt 7\r\n\r\nPhòng 2\r\n10:30 Mai\r\n19:30 Avengers: Endgame\r\n\r\nIMAX 1\r\n14:00 Dune: Part Two";
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1084, 606);
        Controls.Add(timelinePanel);
        Controls.Add(gridPanel);
        Controls.Add(sellingPanel);
        Controls.Add(showtimeCountPanel);
        Name = "TodayShowtimeForm";
        Text = "Lịch chiếu hôm nay";
        Load += TodayShowtimeForm_Load;
        showtimeCountPanel.ResumeLayout(false);
        sellingPanel.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        timelinePanel.ResumeLayout(false);
        timelinePanel.PerformLayout();
        ResumeLayout(false);
    }
}
