namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class AdminDashboardForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel statMoviePanel = null!;
    private Panel statRoomPanel = null!;
    private Panel statShowtimePanel = null!;
    private Panel statTicketPanel = null!;
    private Panel statRevenuePanel = null!;
    private Label totalMovieTitleLabel = null!;
    private Label totalMovieValueLabel = null!;
    private Label totalMovieNoteLabel = null!;
    private Label totalRoomTitleLabel = null!;
    private Label totalRoomValueLabel = null!;
    private Label totalRoomNoteLabel = null!;
    private Label todayShowtimeTitleLabel = null!;
    private Label todayShowtimeValueLabel = null!;
    private Label todayShowtimeNoteLabel = null!;
    private Label todayTicketTitleLabel = null!;
    private Label todayTicketValueLabel = null!;
    private Label todayTicketNoteLabel = null!;
    private Label todayRevenueTitleLabel = null!;
    private Label todayRevenueValueLabel = null!;
    private Label todayRevenueNoteLabel = null!;
    private Panel showtimeSectionPanel = null!;
    private Label recentShowtimeTitleLabel = null!;
    private DataGridView recentShowtimeGrid = null!;
    private DataGridViewTextBoxColumn colShowtimeMovie = null!;
    private DataGridViewTextBoxColumn colShowtimeRoom = null!;
    private DataGridViewTextBoxColumn colShowtimeTime = null!;
    private DataGridViewTextBoxColumn colShowtimePrice = null!;
    private DataGridViewTextBoxColumn colShowtimeStatus = null!;
    private Panel operationPanel = null!;
    private Label operationTitleLabel = null!;
    private Label operationLine1Label = null!;
    private Label operationLine2Label = null!;
    private Label operationLine3Label = null!;
    private Label operationLine4Label = null!;
    private Panel revenueSectionPanel = null!;
    private Label revenueSectionTitleLabel = null!;
    private DataGridView revenueGrid = null!;
    private DataGridViewTextBoxColumn colRevenueMovie = null!;
    private DataGridViewTextBoxColumn colRevenueTickets = null!;
    private DataGridViewTextBoxColumn colRevenueAmount = null!;
    private DataGridViewTextBoxColumn colRevenuePayment = null!;

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
        statMoviePanel = new Panel();
        totalMovieTitleLabel = new Label();
        totalMovieValueLabel = new Label();
        totalMovieNoteLabel = new Label();
        statRoomPanel = new Panel();
        totalRoomTitleLabel = new Label();
        totalRoomValueLabel = new Label();
        totalRoomNoteLabel = new Label();
        statShowtimePanel = new Panel();
        todayShowtimeTitleLabel = new Label();
        todayShowtimeValueLabel = new Label();
        todayShowtimeNoteLabel = new Label();
        statTicketPanel = new Panel();
        todayTicketTitleLabel = new Label();
        todayTicketValueLabel = new Label();
        todayTicketNoteLabel = new Label();
        statRevenuePanel = new Panel();
        todayRevenueTitleLabel = new Label();
        todayRevenueValueLabel = new Label();
        todayRevenueNoteLabel = new Label();
        showtimeSectionPanel = new Panel();
        recentShowtimeGrid = new DataGridView();
        colShowtimeMovie = new DataGridViewTextBoxColumn();
        colShowtimeRoom = new DataGridViewTextBoxColumn();
        colShowtimeTime = new DataGridViewTextBoxColumn();
        colShowtimePrice = new DataGridViewTextBoxColumn();
        colShowtimeStatus = new DataGridViewTextBoxColumn();
        recentShowtimeTitleLabel = new Label();
        operationPanel = new Panel();
        operationLine4Label = new Label();
        operationLine3Label = new Label();
        operationLine2Label = new Label();
        operationLine1Label = new Label();
        operationTitleLabel = new Label();
        revenueSectionPanel = new Panel();
        revenueGrid = new DataGridView();
        colRevenueMovie = new DataGridViewTextBoxColumn();
        colRevenueTickets = new DataGridViewTextBoxColumn();
        colRevenueAmount = new DataGridViewTextBoxColumn();
        colRevenuePayment = new DataGridViewTextBoxColumn();
        revenueSectionTitleLabel = new Label();
        statMoviePanel.SuspendLayout();
        statRoomPanel.SuspendLayout();
        statShowtimePanel.SuspendLayout();
        statTicketPanel.SuspendLayout();
        statRevenuePanel.SuspendLayout();
        showtimeSectionPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)recentShowtimeGrid).BeginInit();
        operationPanel.SuspendLayout();
        revenueSectionPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)revenueGrid).BeginInit();
        SuspendLayout();
        // 
        // statMoviePanel
        // 
        statMoviePanel.BackColor = Color.White;
        statMoviePanel.BorderStyle = BorderStyle.FixedSingle;
        statMoviePanel.Controls.Add(totalMovieTitleLabel);
        statMoviePanel.Controls.Add(totalMovieValueLabel);
        statMoviePanel.Controls.Add(totalMovieNoteLabel);
        statMoviePanel.Location = new Point(18, 16);
        statMoviePanel.Name = "statMoviePanel";
        statMoviePanel.Size = new Size(200, 92);
        statMoviePanel.TabIndex = 0;
        // 
        // totalMovieTitleLabel
        // 
        totalMovieTitleLabel.Font = new Font("Segoe UI", 9.5F);
        totalMovieTitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        totalMovieTitleLabel.Location = new Point(18, 14);
        totalMovieTitleLabel.Name = "totalMovieTitleLabel";
        totalMovieTitleLabel.Size = new Size(152, 20);
        totalMovieTitleLabel.TabIndex = 0;
        totalMovieTitleLabel.Text = "Tổng phim";
        // 
        // totalMovieValueLabel
        // 
        totalMovieValueLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        totalMovieValueLabel.ForeColor = Color.FromArgb(37, 99, 235);
        totalMovieValueLabel.Location = new Point(18, 35);
        totalMovieValueLabel.Name = "totalMovieValueLabel";
        totalMovieValueLabel.Size = new Size(100, 34);
        totalMovieValueLabel.TabIndex = 1;
        totalMovieValueLabel.Text = "6";
        // 
        // totalMovieNoteLabel
        // 
        totalMovieNoteLabel.Font = new Font("Segoe UI", 9F);
        totalMovieNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        totalMovieNoteLabel.Location = new Point(18, 68);
        totalMovieNoteLabel.Name = "totalMovieNoteLabel";
        totalMovieNoteLabel.Size = new Size(152, 18);
        totalMovieNoteLabel.TabIndex = 2;
        totalMovieNoteLabel.Text = "Đang quản lý";
        // 
        // statRoomPanel
        // 
        statRoomPanel.BackColor = Color.White;
        statRoomPanel.BorderStyle = BorderStyle.FixedSingle;
        statRoomPanel.Controls.Add(totalRoomTitleLabel);
        statRoomPanel.Controls.Add(totalRoomValueLabel);
        statRoomPanel.Controls.Add(totalRoomNoteLabel);
        statRoomPanel.Location = new Point(230, 16);
        statRoomPanel.Name = "statRoomPanel";
        statRoomPanel.Size = new Size(200, 92);
        statRoomPanel.TabIndex = 1;
        // 
        // totalRoomTitleLabel
        // 
        totalRoomTitleLabel.Font = new Font("Segoe UI", 9.5F);
        totalRoomTitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        totalRoomTitleLabel.Location = new Point(18, 14);
        totalRoomTitleLabel.Name = "totalRoomTitleLabel";
        totalRoomTitleLabel.Size = new Size(152, 20);
        totalRoomTitleLabel.TabIndex = 0;
        totalRoomTitleLabel.Text = "Tổng phòng chiếu";
        // 
        // totalRoomValueLabel
        // 
        totalRoomValueLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        totalRoomValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        totalRoomValueLabel.Location = new Point(18, 35);
        totalRoomValueLabel.Name = "totalRoomValueLabel";
        totalRoomValueLabel.Size = new Size(100, 34);
        totalRoomValueLabel.TabIndex = 1;
        totalRoomValueLabel.Text = "5";
        // 
        // totalRoomNoteLabel
        // 
        totalRoomNoteLabel.Font = new Font("Segoe UI", 9F);
        totalRoomNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        totalRoomNoteLabel.Location = new Point(18, 68);
        totalRoomNoteLabel.Name = "totalRoomNoteLabel";
        totalRoomNoteLabel.Size = new Size(152, 18);
        totalRoomNoteLabel.TabIndex = 2;
        totalRoomNoteLabel.Text = "Phòng vận hành";
        // 
        // statShowtimePanel
        // 
        statShowtimePanel.BackColor = Color.White;
        statShowtimePanel.BorderStyle = BorderStyle.FixedSingle;
        statShowtimePanel.Controls.Add(todayShowtimeTitleLabel);
        statShowtimePanel.Controls.Add(todayShowtimeValueLabel);
        statShowtimePanel.Controls.Add(todayShowtimeNoteLabel);
        statShowtimePanel.Location = new Point(442, 16);
        statShowtimePanel.Name = "statShowtimePanel";
        statShowtimePanel.Size = new Size(200, 92);
        statShowtimePanel.TabIndex = 2;
        // 
        // todayShowtimeTitleLabel
        // 
        todayShowtimeTitleLabel.Font = new Font("Segoe UI", 9.5F);
        todayShowtimeTitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        todayShowtimeTitleLabel.Location = new Point(18, 14);
        todayShowtimeTitleLabel.Name = "todayShowtimeTitleLabel";
        todayShowtimeTitleLabel.Size = new Size(152, 20);
        todayShowtimeTitleLabel.TabIndex = 0;
        todayShowtimeTitleLabel.Text = "Suất chiếu hôm nay";
        // 
        // todayShowtimeValueLabel
        // 
        todayShowtimeValueLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        todayShowtimeValueLabel.ForeColor = Color.FromArgb(245, 158, 11);
        todayShowtimeValueLabel.Location = new Point(18, 35);
        todayShowtimeValueLabel.Name = "todayShowtimeValueLabel";
        todayShowtimeValueLabel.Size = new Size(100, 34);
        todayShowtimeValueLabel.TabIndex = 1;
        todayShowtimeValueLabel.Text = "4";
        // 
        // todayShowtimeNoteLabel
        // 
        todayShowtimeNoteLabel.Font = new Font("Segoe UI", 9F);
        todayShowtimeNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        todayShowtimeNoteLabel.Location = new Point(18, 68);
        todayShowtimeNoteLabel.Name = "todayShowtimeNoteLabel";
        todayShowtimeNoteLabel.Size = new Size(152, 18);
        todayShowtimeNoteLabel.TabIndex = 2;
        todayShowtimeNoteLabel.Text = "Theo lịch vận hành";
        // 
        // statTicketPanel
        // 
        statTicketPanel.BackColor = Color.White;
        statTicketPanel.BorderStyle = BorderStyle.FixedSingle;
        statTicketPanel.Controls.Add(todayTicketTitleLabel);
        statTicketPanel.Controls.Add(todayTicketValueLabel);
        statTicketPanel.Controls.Add(todayTicketNoteLabel);
        statTicketPanel.Location = new Point(654, 16);
        statTicketPanel.Name = "statTicketPanel";
        statTicketPanel.Size = new Size(200, 92);
        statTicketPanel.TabIndex = 3;
        // 
        // todayTicketTitleLabel
        // 
        todayTicketTitleLabel.Font = new Font("Segoe UI", 9.5F);
        todayTicketTitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        todayTicketTitleLabel.Location = new Point(18, 14);
        todayTicketTitleLabel.Name = "todayTicketTitleLabel";
        todayTicketTitleLabel.Size = new Size(152, 20);
        todayTicketTitleLabel.TabIndex = 0;
        todayTicketTitleLabel.Text = "Vé đã bán hôm nay";
        // 
        // todayTicketValueLabel
        // 
        todayTicketValueLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        todayTicketValueLabel.ForeColor = Color.FromArgb(124, 58, 237);
        todayTicketValueLabel.Location = new Point(18, 35);
        todayTicketValueLabel.Name = "todayTicketValueLabel";
        todayTicketValueLabel.Size = new Size(100, 34);
        todayTicketValueLabel.TabIndex = 1;
        todayTicketValueLabel.Text = "4";
        // 
        // todayTicketNoteLabel
        // 
        todayTicketNoteLabel.Font = new Font("Segoe UI", 9F);
        todayTicketNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        todayTicketNoteLabel.Location = new Point(18, 68);
        todayTicketNoteLabel.Name = "todayTicketNoteLabel";
        todayTicketNoteLabel.Size = new Size(152, 18);
        todayTicketNoteLabel.TabIndex = 2;
        todayTicketNoteLabel.Text = "Dữ liệu demo";
        // 
        // statRevenuePanel
        // 
        statRevenuePanel.BackColor = Color.White;
        statRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
        statRevenuePanel.Controls.Add(todayRevenueTitleLabel);
        statRevenuePanel.Controls.Add(todayRevenueValueLabel);
        statRevenuePanel.Controls.Add(todayRevenueNoteLabel);
        statRevenuePanel.Location = new Point(866, 16);
        statRevenuePanel.Name = "statRevenuePanel";
        statRevenuePanel.Size = new Size(200, 92);
        statRevenuePanel.TabIndex = 4;
        // 
        // todayRevenueTitleLabel
        // 
        todayRevenueTitleLabel.Font = new Font("Segoe UI", 9.5F);
        todayRevenueTitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        todayRevenueTitleLabel.Location = new Point(18, 14);
        todayRevenueTitleLabel.Name = "todayRevenueTitleLabel";
        todayRevenueTitleLabel.Size = new Size(152, 20);
        todayRevenueTitleLabel.TabIndex = 0;
        todayRevenueTitleLabel.Text = "Doanh thu hôm nay";
        // 
        // todayRevenueValueLabel
        // 
        todayRevenueValueLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        todayRevenueValueLabel.ForeColor = Color.FromArgb(37, 99, 235);
        todayRevenueValueLabel.Location = new Point(18, 39);
        todayRevenueValueLabel.Name = "todayRevenueValueLabel";
        todayRevenueValueLabel.Size = new Size(165, 30);
        todayRevenueValueLabel.TabIndex = 1;
        todayRevenueValueLabel.Text = "585.000 đ";
        // 
        // todayRevenueNoteLabel
        // 
        todayRevenueNoteLabel.Font = new Font("Segoe UI", 9F);
        todayRevenueNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        todayRevenueNoteLabel.Location = new Point(18, 68);
        todayRevenueNoteLabel.Name = "todayRevenueNoteLabel";
        todayRevenueNoteLabel.Size = new Size(152, 18);
        todayRevenueNoteLabel.TabIndex = 2;
        todayRevenueNoteLabel.Text = "Theo vé đã bán";
        // 
        // showtimeSectionPanel
        // 
        showtimeSectionPanel.BackColor = Color.White;
        showtimeSectionPanel.BorderStyle = BorderStyle.FixedSingle;
        showtimeSectionPanel.Controls.Add(recentShowtimeGrid);
        showtimeSectionPanel.Controls.Add(recentShowtimeTitleLabel);
        showtimeSectionPanel.Location = new Point(18, 124);
        showtimeSectionPanel.Name = "showtimeSectionPanel";
        showtimeSectionPanel.Size = new Size(690, 286);
        showtimeSectionPanel.TabIndex = 5;
        // 
        // recentShowtimeGrid
        // 
        recentShowtimeGrid.AllowUserToAddRows = false;
        recentShowtimeGrid.AllowUserToDeleteRows = false;
        recentShowtimeGrid.BackgroundColor = Color.White;
        recentShowtimeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        recentShowtimeGrid.Columns.AddRange(new DataGridViewColumn[] { colShowtimeMovie, colShowtimeRoom, colShowtimeTime, colShowtimePrice, colShowtimeStatus });
        recentShowtimeGrid.Location = new Point(18, 54);
        recentShowtimeGrid.Name = "recentShowtimeGrid";
        recentShowtimeGrid.ReadOnly = true;
        recentShowtimeGrid.RowHeadersVisible = false;
        recentShowtimeGrid.Size = new Size(652, 214);
        recentShowtimeGrid.TabIndex = 1;
        recentShowtimeGrid.Rows.Add("Avengers: Endgame", "Phòng 2", "19:30 - 22:32", "90.000 đ", "Đang bán");
        recentShowtimeGrid.Rows.Add("Mai", "Phòng 2", "10:30 - 12:41", "85.000 đ", "Đang bán");
        // 
        // colShowtimeMovie
        // 
        colShowtimeMovie.HeaderText = "Phim";
        colShowtimeMovie.Name = "colShowtimeMovie";
        colShowtimeMovie.ReadOnly = true;
        colShowtimeMovie.Width = 190;
        // 
        // colShowtimeRoom
        // 
        colShowtimeRoom.HeaderText = "Phòng";
        colShowtimeRoom.Name = "colShowtimeRoom";
        colShowtimeRoom.ReadOnly = true;
        colShowtimeRoom.Width = 90;
        // 
        // colShowtimeTime
        // 
        colShowtimeTime.HeaderText = "Giờ chiếu";
        colShowtimeTime.Name = "colShowtimeTime";
        colShowtimeTime.ReadOnly = true;
        colShowtimeTime.Width = 120;
        // 
        // colShowtimePrice
        // 
        colShowtimePrice.HeaderText = "Giá vé";
        colShowtimePrice.Name = "colShowtimePrice";
        colShowtimePrice.ReadOnly = true;
        // 
        // colShowtimeStatus
        // 
        colShowtimeStatus.HeaderText = "Trạng thái";
        colShowtimeStatus.Name = "colShowtimeStatus";
        colShowtimeStatus.ReadOnly = true;
        // 
        // recentShowtimeTitleLabel
        // 
        recentShowtimeTitleLabel.AutoSize = true;
        recentShowtimeTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        recentShowtimeTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        recentShowtimeTitleLabel.Location = new Point(18, 18);
        recentShowtimeTitleLabel.Name = "recentShowtimeTitleLabel";
        recentShowtimeTitleLabel.Size = new Size(144, 21);
        recentShowtimeTitleLabel.TabIndex = 0;
        recentShowtimeTitleLabel.Text = "Lịch chiếu gần đây";
        // 
        // operationPanel
        // 
        operationPanel.BackColor = Color.White;
        operationPanel.BorderStyle = BorderStyle.FixedSingle;
        operationPanel.Controls.Add(operationLine4Label);
        operationPanel.Controls.Add(operationLine3Label);
        operationPanel.Controls.Add(operationLine2Label);
        operationPanel.Controls.Add(operationLine1Label);
        operationPanel.Controls.Add(operationTitleLabel);
        operationPanel.Location = new Point(724, 124);
        operationPanel.Name = "operationPanel";
        operationPanel.Size = new Size(342, 286);
        operationPanel.TabIndex = 6;
        // 
        // operationLine4Label
        // 
        operationLine4Label.BorderStyle = BorderStyle.FixedSingle;
        operationLine4Label.Font = new Font("Segoe UI", 9.5F);
        operationLine4Label.ForeColor = Color.FromArgb(17, 24, 39);
        operationLine4Label.Location = new Point(20, 210);
        operationLine4Label.Name = "operationLine4Label";
        operationLine4Label.Size = new Size(300, 44);
        operationLine4Label.TabIndex = 4;
        operationLine4Label.Text = "VIP 1: đang bảo trì ghế và âm thanh";
        operationLine4Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // operationLine3Label
        // 
        operationLine3Label.BorderStyle = BorderStyle.FixedSingle;
        operationLine3Label.Font = new Font("Segoe UI", 9.5F);
        operationLine3Label.ForeColor = Color.FromArgb(17, 24, 39);
        operationLine3Label.Location = new Point(20, 156);
        operationLine3Label.Name = "operationLine3Label";
        operationLine3Label.Size = new Size(300, 44);
        operationLine3Label.TabIndex = 3;
        operationLine3Label.Text = "IMAX 1: suất 14:00 còn 18 ghế";
        operationLine3Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // operationLine2Label
        // 
        operationLine2Label.BorderStyle = BorderStyle.FixedSingle;
        operationLine2Label.Font = new Font("Segoe UI", 9.5F);
        operationLine2Label.ForeColor = Color.FromArgb(17, 24, 39);
        operationLine2Label.Location = new Point(20, 102);
        operationLine2Label.Name = "operationLine2Label";
        operationLine2Label.Size = new Size(300, 44);
        operationLine2Label.TabIndex = 2;
        operationLine2Label.Text = "Phòng 2: khách vào rạp ổn định";
        operationLine2Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // operationLine1Label
        // 
        operationLine1Label.BorderStyle = BorderStyle.FixedSingle;
        operationLine1Label.Font = new Font("Segoe UI", 9.5F);
        operationLine1Label.ForeColor = Color.FromArgb(17, 24, 39);
        operationLine1Label.Location = new Point(20, 48);
        operationLine1Label.Name = "operationLine1Label";
        operationLine1Label.Size = new Size(300, 44);
        operationLine1Label.TabIndex = 1;
        operationLine1Label.Text = "Quầy vé: 4 giao dịch trong phiên";
        operationLine1Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // operationTitleLabel
        // 
        operationTitleLabel.AutoSize = true;
        operationTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        operationTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        operationTitleLabel.Location = new Point(18, 18);
        operationTitleLabel.Name = "operationTitleLabel";
        operationTitleLabel.Size = new Size(131, 21);
        operationTitleLabel.TabIndex = 0;
        operationTitleLabel.Text = "Tình hình rạp";
        // 
        // revenueSectionPanel
        // 
        revenueSectionPanel.BackColor = Color.White;
        revenueSectionPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueSectionPanel.Controls.Add(revenueGrid);
        revenueSectionPanel.Controls.Add(revenueSectionTitleLabel);
        revenueSectionPanel.Location = new Point(18, 426);
        revenueSectionPanel.Name = "revenueSectionPanel";
        revenueSectionPanel.Size = new Size(1048, 164);
        revenueSectionPanel.TabIndex = 7;
        // 
        // revenueGrid
        // 
        revenueGrid.AllowUserToAddRows = false;
        revenueGrid.AllowUserToDeleteRows = false;
        revenueGrid.BackgroundColor = Color.White;
        revenueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        revenueGrid.Columns.AddRange(new DataGridViewColumn[] { colRevenueMovie, colRevenueTickets, colRevenueAmount, colRevenuePayment });
        revenueGrid.Location = new Point(18, 48);
        revenueGrid.Name = "revenueGrid";
        revenueGrid.ReadOnly = true;
        revenueGrid.RowHeadersVisible = false;
        revenueGrid.Size = new Size(1010, 98);
        revenueGrid.TabIndex = 1;
        revenueGrid.Rows.Add("Avengers: Endgame", "68", "6.120.000 đ", "Tiền mặt");
        revenueGrid.Rows.Add("Dune: Part Two", "54", "7.020.000 đ", "VNPAY Sandbox");
        // 
        // colRevenueMovie
        // 
        colRevenueMovie.HeaderText = "Phim";
        colRevenueMovie.Name = "colRevenueMovie";
        colRevenueMovie.ReadOnly = true;
        colRevenueMovie.Width = 320;
        // 
        // colRevenueTickets
        // 
        colRevenueTickets.HeaderText = "Vé bán";
        colRevenueTickets.Name = "colRevenueTickets";
        colRevenueTickets.ReadOnly = true;
        colRevenueTickets.Width = 120;
        // 
        // colRevenueAmount
        // 
        colRevenueAmount.HeaderText = "Doanh thu";
        colRevenueAmount.Name = "colRevenueAmount";
        colRevenueAmount.ReadOnly = true;
        colRevenueAmount.Width = 180;
        // 
        // colRevenuePayment
        // 
        colRevenuePayment.HeaderText = "Thanh toán";
        colRevenuePayment.Name = "colRevenuePayment";
        colRevenuePayment.ReadOnly = true;
        colRevenuePayment.Width = 180;
        // 
        // revenueSectionTitleLabel
        // 
        revenueSectionTitleLabel.AutoSize = true;
        revenueSectionTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        revenueSectionTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        revenueSectionTitleLabel.Location = new Point(18, 16);
        revenueSectionTitleLabel.Name = "revenueSectionTitleLabel";
        revenueSectionTitleLabel.Size = new Size(161, 21);
        revenueSectionTitleLabel.TabIndex = 0;
        revenueSectionTitleLabel.Text = "Doanh thu theo phim";
        // 
        // AdminDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1084, 606);
        Controls.Add(revenueSectionPanel);
        Controls.Add(operationPanel);
        Controls.Add(showtimeSectionPanel);
        Controls.Add(statRevenuePanel);
        Controls.Add(statTicketPanel);
        Controls.Add(statShowtimePanel);
        Controls.Add(statRoomPanel);
        Controls.Add(statMoviePanel);
        Name = "AdminDashboardForm";
        Text = "Dashboard quản trị";
        Load += AdminDashboardForm_Load;
        statMoviePanel.ResumeLayout(false);
        statRoomPanel.ResumeLayout(false);
        statShowtimePanel.ResumeLayout(false);
        statTicketPanel.ResumeLayout(false);
        statRevenuePanel.ResumeLayout(false);
        showtimeSectionPanel.ResumeLayout(false);
        showtimeSectionPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)recentShowtimeGrid).EndInit();
        operationPanel.ResumeLayout(false);
        operationPanel.PerformLayout();
        revenueSectionPanel.ResumeLayout(false);
        revenueSectionPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)revenueGrid).EndInit();
        ResumeLayout(false);
    }
}
