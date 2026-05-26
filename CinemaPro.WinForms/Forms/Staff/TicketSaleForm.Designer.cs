using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class TicketSaleForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterBar;
    private TextBox searchTextBox;
    private DateTimePicker saleDatePicker;
    private ComboBox _roomCombo;
    private ComboBox _showtimeCombo;
    private RoundedButton refreshButton;
    private RoundedPanel movieInfoCard;
    private TableLayoutPanel movieInfoLayout;
    private PosterPanel posterPanel;
    private TableLayoutPanel infoLayout;
    private Label _movieTitleLabel;
    private FlowLayoutPanel badgePanel;
    private Label _movieMetaLabel;
    private Label _showtimeInfoLabel;
    private TableLayoutPanel movieSideLayout;
    private Label _roomInfoLabel;
    private TableLayoutPanel middleLayout;
    private RoundedPanel seatMapCard;
    private TableLayoutPanel seatMapLayout;
    private Label screenLabel;
    private TableLayoutPanel _seatGridPanel;
    private FlowLayoutPanel legendPanel;
    private RoundedPanel bookingCard;
    private TableLayoutPanel bookingLayout;
    private Label _selectedCountLabel;
    private FlowLayoutPanel _selectedSeatsPanel;
    private Label _unitPriceLabel;
    private Label _totalLabel;
    private ComboBox _paymentCombo;
    private RoundedButton payButton;
    private RoundedButton cancelButton;
    private RoundedPanel recentCard;
    private TableLayoutPanel recentLayout;
    private DataGridView _recentGrid;

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
        rootLayout = new TableLayoutPanel();
        filterBar = new FlowLayoutPanel();
        searchTextBox = UiStyleHelper.CreateTextBox("Nhập tên phim...");
        saleDatePicker = UiStyleHelper.CreateDatePicker();
        _roomCombo = UiStyleHelper.CreateComboBox();
        _showtimeCombo = UiStyleHelper.CreateComboBox();
        refreshButton = UiStyleHelper.CreateOutlineButton("Làm mới");
        movieInfoCard = UiStyleHelper.CreateCard();
        movieInfoLayout = new TableLayoutPanel();
        posterPanel = new PosterPanel { MovieTitle = "Avengers" };
        infoLayout = new TableLayoutPanel();
        _movieTitleLabel = new Label();
        badgePanel = new FlowLayoutPanel();
        _movieMetaLabel = UiStyleHelper.CreateValueLabel("Thời lượng: 181 phút     Định dạng: 2D     Ngôn ngữ: Phụ đề", 9.5F);
        _showtimeInfoLabel = UiStyleHelper.CreateValueLabel("Suất chiếu: 19:30     Ngày chiếu: Hôm nay", 9.5F);
        movieSideLayout = new TableLayoutPanel();
        _roomInfoLabel = UiStyleHelper.CreateValueLabel("Phòng chiếu: Phòng 2", 10F);
        middleLayout = new TableLayoutPanel();
        seatMapCard = UiStyleHelper.CreateCard();
        seatMapLayout = new TableLayoutPanel();
        screenLabel = new Label();
        _seatGridPanel = new TableLayoutPanel();
        legendPanel = new FlowLayoutPanel();
        bookingCard = UiStyleHelper.CreateCard();
        bookingLayout = new TableLayoutPanel();
        _selectedCountLabel = UiStyleHelper.CreateValueLabel("Chưa chọn ghế", 9.5F);
        _selectedSeatsPanel = new FlowLayoutPanel();
        _unitPriceLabel = UiStyleHelper.CreateValueLabel("90.000 đ", 10.5F);
        _totalLabel = new Label();
        _paymentCombo = UiStyleHelper.CreateComboBox();
        payButton = UiStyleHelper.CreateButton("Thanh toán", UiStyleHelper.Primary);
        cancelButton = UiStyleHelper.CreateOutlineButton("Hủy", UiStyleHelper.Danger);
        recentCard = UiStyleHelper.CreateCard();
        recentLayout = new TableLayoutPanel();
        _recentGrid = new DataGridView();
        rootLayout.SuspendLayout();
        filterBar.SuspendLayout();
        movieInfoCard.SuspendLayout();
        movieInfoLayout.SuspendLayout();
        infoLayout.SuspendLayout();
        badgePanel.SuspendLayout();
        movieSideLayout.SuspendLayout();
        middleLayout.SuspendLayout();
        seatMapCard.SuspendLayout();
        seatMapLayout.SuspendLayout();
        legendPanel.SuspendLayout();
        bookingCard.SuspendLayout();
        bookingLayout.SuspendLayout();
        recentCard.SuspendLayout();
        recentLayout.SuspendLayout();
        SuspendLayout();
        //
        // TicketSaleForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "TicketSaleForm";
        Text = "Bán vé";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterBar, 0, 0);
        rootLayout.Controls.Add(movieInfoCard, 0, 1);
        rootLayout.Controls.Add(middleLayout, 0, 2);
        rootLayout.Controls.Add(recentCard, 0, 3);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 4;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
        //
        // filterBar
        //
        filterBar.BackColor = UiStyleHelper.ContentBackground;
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Tìm kiếm phim", searchTextBox));
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Ngày chiếu", saleDatePicker));
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Phòng chiếu", _roomCombo));
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Suất chiếu", _showtimeCombo));
        filterBar.Controls.Add(refreshButton);
        filterBar.Dock = DockStyle.Fill;
        filterBar.FlowDirection = FlowDirection.LeftToRight;
        filterBar.Padding = new Padding(0, 0, 0, 8);
        filterBar.WrapContents = false;
        searchTextBox.Width = 270;
        saleDatePicker.Width = 140;
        _roomCombo.Width = 170;
        _showtimeCombo.Width = 210;
        _roomCombo.Items.AddRange(new object[] { "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4" });
        _roomCombo.SelectedIndex = 1;
        _showtimeCombo.Items.AddRange(new object[] { "19:30 - Avengers: Endgame", "21:15 - Dune: Phần Hai" });
        _showtimeCombo.SelectedIndex = 0;
        refreshButton.Width = 120;
        refreshButton.Click += RefreshButton_Click;
        //
        // movieInfoCard
        //
        movieInfoCard.Controls.Add(movieInfoLayout);
        movieInfoCard.Dock = DockStyle.Fill;
        movieInfoCard.Padding = new Padding(10);
        //
        // movieInfoLayout
        //
        movieInfoLayout.BackColor = Color.Transparent;
        movieInfoLayout.ColumnCount = 3;
        movieInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
        movieInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        movieInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        movieInfoLayout.Controls.Add(posterPanel, 0, 0);
        movieInfoLayout.Controls.Add(infoLayout, 1, 0);
        movieInfoLayout.Controls.Add(movieSideLayout, 2, 0);
        movieInfoLayout.Dock = DockStyle.Fill;
        movieInfoLayout.RowCount = 1;
        movieInfoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        posterPanel.Dock = DockStyle.Fill;
        //
        // infoLayout
        //
        infoLayout.BackColor = Color.Transparent;
        infoLayout.ColumnCount = 1;
        infoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        infoLayout.Controls.Add(_movieTitleLabel, 0, 0);
        infoLayout.Controls.Add(badgePanel, 0, 1);
        infoLayout.Controls.Add(_movieMetaLabel, 0, 2);
        infoLayout.Controls.Add(_showtimeInfoLabel, 0, 3);
        infoLayout.Dock = DockStyle.Fill;
        infoLayout.Padding = new Padding(18, 2, 0, 0);
        infoLayout.RowCount = 5;
        infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        infoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _movieTitleLabel.AutoEllipsis = true;
        _movieTitleLabel.Dock = DockStyle.Fill;
        _movieTitleLabel.Font = UiStyleHelper.TitleFont(16F);
        _movieTitleLabel.ForeColor = UiStyleHelper.TextDark;
        _movieTitleLabel.Text = "Avengers: Endgame";
        _movieTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        badgePanel.BackColor = Color.Transparent;
        badgePanel.Dock = DockStyle.Fill;
        badgePanel.FlowDirection = FlowDirection.LeftToRight;
        badgePanel.WrapContents = false;
        badgePanel.Controls.Add(UiStyleHelper.CreateBadge("Hành động", UiStyleHelper.Primary));
        badgePanel.Controls.Add(UiStyleHelper.CreateBadge("Phụ đề", UiStyleHelper.Accent));
        //
        // movieSideLayout
        //
        movieSideLayout.BackColor = Color.Transparent;
        movieSideLayout.ColumnCount = 1;
        movieSideLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        movieSideLayout.Controls.Add(_roomInfoLabel, 0, 0);
        movieSideLayout.Controls.Add(UiStyleHelper.CreateValueLabel("Sơ đồ ghế đang bán theo suất chiếu", 9.5F), 0, 1);
        movieSideLayout.Controls.Add(UiStyleHelper.CreateMutedLabel("Ghế đã bán và bảo trì sẽ bị khóa chọn."), 0, 2);
        movieSideLayout.Dock = DockStyle.Fill;
        movieSideLayout.Padding = new Padding(8, 10, 4, 4);
        movieSideLayout.RowCount = 4;
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // middleLayout
        //
        middleLayout.BackColor = UiStyleHelper.ContentBackground;
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
        middleLayout.Controls.Add(seatMapCard, 0, 0);
        middleLayout.Controls.Add(bookingCard, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Padding = new Padding(0, 10, 0, 10);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // seatMapCard
        //
        seatMapCard.Controls.Add(seatMapLayout);
        seatMapCard.Dock = DockStyle.Fill;
        seatMapCard.Margin = new Padding(0, 0, 12, 0);
        seatMapCard.Padding = new Padding(12);
        //
        // seatMapLayout
        //
        seatMapLayout.BackColor = Color.Transparent;
        seatMapLayout.ColumnCount = 1;
        seatMapLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        seatMapLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Sơ đồ ghế - màn hình"), 0, 0);
        seatMapLayout.Controls.Add(screenLabel, 0, 1);
        seatMapLayout.Controls.Add(_seatGridPanel, 0, 2);
        seatMapLayout.Controls.Add(legendPanel, 0, 3);
        seatMapLayout.Dock = DockStyle.Fill;
        seatMapLayout.RowCount = 4;
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        screenLabel.BackColor = ColorTranslator.FromHtml("#EAF3FF");
        screenLabel.Dock = DockStyle.Fill;
        screenLabel.Font = UiStyleHelper.SectionFont(9.5F);
        screenLabel.ForeColor = UiStyleHelper.Primary;
        screenLabel.Margin = new Padding(0, 0, 0, 8);
        screenLabel.Text = "MÀN HÌNH";
        screenLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // _seatGridPanel
        //
        _seatGridPanel.BackColor = Color.White;
        _seatGridPanel.ColumnCount = 9;
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        _seatGridPanel.Dock = DockStyle.Fill;
        _seatGridPanel.Padding = new Padding(40, 12, 40, 10);
        _seatGridPanel.RowCount = 6;
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        _seatGridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        //
        // legendPanel
        //
        legendPanel.BackColor = Color.Transparent;
        legendPanel.Dock = DockStyle.Fill;
        legendPanel.FlowDirection = FlowDirection.LeftToRight;
        legendPanel.WrapContents = false;
        legendPanel.Controls.Add(LegendItem("Ghế trống", UiStyleHelper.SeatAvailable));
        legendPanel.Controls.Add(LegendItem("Đang chọn", UiStyleHelper.SeatSelected));
        legendPanel.Controls.Add(LegendItem("Đã bán", UiStyleHelper.SeatSold));
        legendPanel.Controls.Add(LegendItem("Bảo trì", UiStyleHelper.SeatMaintenance));
        //
        // bookingCard
        //
        bookingCard.Controls.Add(bookingLayout);
        bookingCard.Dock = DockStyle.Fill;
        bookingCard.Padding = new Padding(14);
        //
        // bookingLayout
        //
        bookingLayout.BackColor = Color.Transparent;
        bookingLayout.ColumnCount = 1;
        bookingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        bookingLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Thông tin đặt vé"), 0, 0);
        bookingLayout.Controls.Add(_selectedCountLabel, 0, 1);
        bookingLayout.Controls.Add(_selectedSeatsPanel, 0, 2);
        bookingLayout.Controls.Add(UiStyleHelper.CreateMutedLabel("Đơn giá"), 0, 3);
        bookingLayout.Controls.Add(_unitPriceLabel, 0, 4);
        bookingLayout.Controls.Add(UiStyleHelper.CreateMutedLabel("Thành tiền"), 0, 5);
        bookingLayout.Controls.Add(_totalLabel, 0, 6);
        bookingLayout.Controls.Add(UiStyleHelper.FieldBlock("Phương thức thanh toán", _paymentCombo), 0, 7);
        bookingLayout.Controls.Add(payButton, 0, 8);
        bookingLayout.Controls.Add(cancelButton, 0, 9);
        bookingLayout.Dock = DockStyle.Fill;
        bookingLayout.RowCount = 10;
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _selectedSeatsPanel.BackColor = Color.Transparent;
        _selectedSeatsPanel.Dock = DockStyle.Fill;
        _selectedSeatsPanel.FlowDirection = FlowDirection.LeftToRight;
        _selectedSeatsPanel.WrapContents = true;
        _selectedSeatsPanel.Controls.Add(UiStyleHelper.CreateBadge("B5", UiStyleHelper.Success));
        _selectedSeatsPanel.Controls.Add(UiStyleHelper.CreateBadge("B6", UiStyleHelper.Success));
        _selectedCountLabel.Text = "Đã chọn 2 ghế";
        _paymentCombo.Items.AddRange(new object[] { "Tiền mặt", "VNPAY Sandbox" });
        _paymentCombo.SelectedIndex = 0;
        _totalLabel.Dock = DockStyle.Fill;
        _totalLabel.Font = UiStyleHelper.TitleFont(18F);
        _totalLabel.ForeColor = UiStyleHelper.Primary;
        _totalLabel.Text = "0 đ";
        _totalLabel.TextAlign = ContentAlignment.TopRight;
        payButton.Dock = DockStyle.Fill;
        payButton.Margin = new Padding(0, 0, 0, 6);
        payButton.Click += PayButton_Click;
        cancelButton.BorderColor = ColorTranslator.FromHtml("#FFB4B4");
        cancelButton.Dock = DockStyle.Top;
        cancelButton.ForeColor = UiStyleHelper.Danger;
        cancelButton.Height = 38;
        cancelButton.Margin = Padding.Empty;
        cancelButton.Click += CancelButton_Click;
        //
        // recentCard
        //
        recentCard.Controls.Add(recentLayout);
        recentCard.Dock = DockStyle.Fill;
        recentCard.Padding = new Padding(10);
        //
        // recentLayout
        //
        recentLayout.BackColor = Color.Transparent;
        recentLayout.ColumnCount = 1;
        recentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        recentLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Giao dịch gần nhất"), 0, 0);
        recentLayout.Controls.Add(_recentGrid, 0, 1);
        recentLayout.Dock = DockStyle.Fill;
        recentLayout.RowCount = 2;
        recentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        recentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // _recentGrid
        //
        _recentGrid.Dock = DockStyle.Fill;
        _recentGrid.AutoGenerateColumns = false;
        _recentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _recentGrid.ColumnHeadersHeight = 40;
        _recentGrid.RowHeadersVisible = false;
        _recentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Time", DataPropertyName = "Time", HeaderText = "Thời gian", FillWeight = 80, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 160, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Showtime", DataPropertyName = "Showtime", HeaderText = "Suất chiếu", FillWeight = 90, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 80, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Seats", DataPropertyName = "Seats", HeaderText = "Ghế", FillWeight = 90, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", DataPropertyName = "Quantity", HeaderText = "SL", FillWeight = 40, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", DataPropertyName = "Total", HeaderText = "Tổng tiền", FillWeight = 90, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Payment", DataPropertyName = "Payment", HeaderText = "Phương thức", FillWeight = 100, MinimumWidth = 52 });
        _recentGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 95, MinimumWidth = 52 });
        UiStyleHelper.ApplyStatusCellFormatting(_recentGrid, "Status");
        rootLayout.ResumeLayout(false);
        filterBar.ResumeLayout(false);
        movieInfoCard.ResumeLayout(false);
        movieInfoLayout.ResumeLayout(false);
        infoLayout.ResumeLayout(false);
        badgePanel.ResumeLayout(false);
        movieSideLayout.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        seatMapCard.ResumeLayout(false);
        seatMapLayout.ResumeLayout(false);
        legendPanel.ResumeLayout(false);
        bookingCard.ResumeLayout(false);
        bookingLayout.ResumeLayout(false);
        recentCard.ResumeLayout(false);
        recentLayout.ResumeLayout(false);
        ResumeLayout(false);
    }
}
