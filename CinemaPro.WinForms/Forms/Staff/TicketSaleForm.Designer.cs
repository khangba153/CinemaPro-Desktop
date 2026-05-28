using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class TicketSaleForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterBar;
    private Label searchFilterLabel;
    private TextBox searchTextBox;
    private Label saleDateFilterLabel;
    private DateTimePicker saleDatePicker;
    private Label roomFilterLabel;
    private ComboBox _roomCombo;
    private Label showtimeFilterLabel;
    private ComboBox _showtimeCombo;
    private Button refreshButton;
    private Panel movieInfoCard;
    private TableLayoutPanel movieInfoLayout;
    private Panel posterPanel;
    private TableLayoutPanel infoLayout;
    private Label _movieTitleLabel;
    private FlowLayoutPanel badgePanel;
    private Label actionBadgeLabel;
    private Label subtitleBadgeLabel;
    private Label _movieMetaLabel;
    private Label _showtimeInfoLabel;
    private TableLayoutPanel movieSideLayout;
    private Label _roomInfoLabel;
    private Label seatInstructionLabel;
    private Label seatNoteLabel;
    private TableLayoutPanel middleLayout;
    private Panel seatMapCard;
    private TableLayoutPanel seatMapLayout;
    private Label seatMapTitleLabel;
    private Label screenLabel;
    private TableLayoutPanel _seatGridPanel;
    private Label seatARowLabel;
    private Button seatA1Button;
    private Button seatA2Button;
    private Button seatA3Button;
    private Button seatA4Button;
    private Button seatA5Button;
    private Button seatA6Button;
    private Button seatA7Button;
    private Button seatA8Button;
    private Label seatBRowLabel;
    private Button seatB1Button;
    private Button seatB2Button;
    private Button seatB3Button;
    private Button seatB4Button;
    private Button seatB5Button;
    private Button seatB6Button;
    private Button seatB7Button;
    private Button seatB8Button;
    private Label seatCRowLabel;
    private Button seatC1Button;
    private Button seatC2Button;
    private Button seatC3Button;
    private Button seatC4Button;
    private Button seatC5Button;
    private Button seatC6Button;
    private Button seatC7Button;
    private Button seatC8Button;
    private Label seatDRowLabel;
    private Button seatD1Button;
    private Button seatD2Button;
    private Button seatD3Button;
    private Button seatD4Button;
    private Button seatD5Button;
    private Button seatD6Button;
    private Button seatD7Button;
    private Button seatD8Button;
    private Label seatERowLabel;
    private Button seatE1Button;
    private Button seatE2Button;
    private Button seatE3Button;
    private Button seatE4Button;
    private Button seatE5Button;
    private Button seatE6Button;
    private Button seatE7Button;
    private Button seatE8Button;
    private Label seatFRowLabel;
    private Button seatF1Button;
    private Button seatF2Button;
    private Button seatF3Button;
    private Button seatF4Button;
    private Button seatF5Button;
    private Button seatF6Button;
    private Button seatF7Button;
    private Button seatF8Button;
    private FlowLayoutPanel legendPanel;
    private Label availableSeatLegendColorLabel;
    private Label availableSeatLegendTextLabel;
    private Label selectedSeatLegendColorLabel;
    private Label selectedSeatLegendTextLabel;
    private Label soldSeatLegendColorLabel;
    private Label soldSeatLegendTextLabel;
    private Label maintenanceSeatLegendColorLabel;
    private Label maintenanceSeatLegendTextLabel;
    private Panel bookingCard;
    private TableLayoutPanel bookingLayout;
    private Label bookingTitleLabel;
    private Label _selectedCountLabel;
    private FlowLayoutPanel _selectedSeatsPanel;
    private Label selectedSeatB5BadgeLabel;
    private Label selectedSeatB6BadgeLabel;
    private Label unitPriceTitleLabel;
    private Label _unitPriceLabel;
    private Label totalTitleLabel;
    private Label _totalLabel;
    private Label paymentMethodLabel;
    private ComboBox _paymentCombo;
    private Button payButton;
    private Button cancelButton;
    private Panel recentCard;
    private TableLayoutPanel recentLayout;
    private Label recentTitleLabel;
    private DataGridView _recentGrid;

    private DataGridViewTextBoxColumn recentGridTimeColumn;
    private DataGridViewTextBoxColumn recentGridMovieColumn;
    private DataGridViewTextBoxColumn recentGridShowtimeColumn;
    private DataGridViewTextBoxColumn recentGridRoomColumn;
    private DataGridViewTextBoxColumn recentGridSeatsColumn;
    private DataGridViewTextBoxColumn recentGridQuantityColumn;
    private DataGridViewTextBoxColumn recentGridTotalColumn;
    private DataGridViewTextBoxColumn recentGridPaymentColumn;
    private DataGridViewTextBoxColumn recentGridStatusColumn;
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
        recentGridTimeColumn = new DataGridViewTextBoxColumn();
        recentGridMovieColumn = new DataGridViewTextBoxColumn();
        recentGridShowtimeColumn = new DataGridViewTextBoxColumn();
        recentGridRoomColumn = new DataGridViewTextBoxColumn();
        recentGridSeatsColumn = new DataGridViewTextBoxColumn();
        recentGridQuantityColumn = new DataGridViewTextBoxColumn();
        recentGridTotalColumn = new DataGridViewTextBoxColumn();
        recentGridPaymentColumn = new DataGridViewTextBoxColumn();
        recentGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        filterBar = new FlowLayoutPanel();
        searchFilterLabel = new Label();
        searchTextBox = new TextBox();
        searchTextBox.PlaceholderText = "Nhập tên phim...";
        searchTextBox.BorderStyle = BorderStyle.FixedSingle;
        searchTextBox.Font = UiStyleHelper.BodyFont(10F);
        searchTextBox.Height = 32;
        saleDateFilterLabel = new Label();
        saleDatePicker = new DateTimePicker();
        saleDatePicker.Font = UiStyleHelper.BodyFont(10F);
        saleDatePicker.Format = DateTimePickerFormat.Short;
        saleDatePicker.Height = 34;
        roomFilterLabel = new Label();
        _roomCombo = new ComboBox();
        _roomCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _roomCombo.FlatStyle = FlatStyle.Flat;
        _roomCombo.Font = UiStyleHelper.BodyFont(10F);
        _roomCombo.Height = 34;
        showtimeFilterLabel = new Label();
        _showtimeCombo = new ComboBox();
        _showtimeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _showtimeCombo.FlatStyle = FlatStyle.Flat;
        _showtimeCombo.Font = UiStyleHelper.BodyFont(10F);
        _showtimeCombo.Height = 34;
        refreshButton = new Button();
        movieInfoCard = new Panel();
        movieInfoLayout = new TableLayoutPanel();
        posterPanel = new Panel();
        infoLayout = new TableLayoutPanel();
        _movieTitleLabel = new Label();
        badgePanel = new FlowLayoutPanel();
        actionBadgeLabel = new Label();
        subtitleBadgeLabel = new Label();
        _movieMetaLabel = new Label();
        _movieMetaLabel.AutoEllipsis = true;
        _movieMetaLabel.Dock = DockStyle.Fill;
        _movieMetaLabel.Font = UiStyleHelper.BodyFont(9.5F);
        _movieMetaLabel.ForeColor = UiStyleHelper.TextDark;
        _movieMetaLabel.Text = "Thời lượng: 181 phút     Định dạng: 2D     Ngôn ngữ: Phụ đề";
        _movieMetaLabel.TextAlign = ContentAlignment.MiddleLeft;
        _showtimeInfoLabel = new Label();
        _showtimeInfoLabel.AutoEllipsis = true;
        _showtimeInfoLabel.Dock = DockStyle.Fill;
        _showtimeInfoLabel.Font = UiStyleHelper.BodyFont(9.5F);
        _showtimeInfoLabel.ForeColor = UiStyleHelper.TextDark;
        _showtimeInfoLabel.Text = "Suất chiếu: 19:30     Ngày chiếu: Hôm nay";
        _showtimeInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
        movieSideLayout = new TableLayoutPanel();
        _roomInfoLabel = new Label();
        _roomInfoLabel.AutoEllipsis = true;
        _roomInfoLabel.Dock = DockStyle.Fill;
        _roomInfoLabel.Font = UiStyleHelper.BodyFont(10F);
        _roomInfoLabel.ForeColor = UiStyleHelper.TextDark;
        _roomInfoLabel.Text = "Phòng chiếu: Phòng 2";
        _roomInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
        seatInstructionLabel = new Label();
        seatNoteLabel = new Label();
        middleLayout = new TableLayoutPanel();
        seatMapCard = new Panel();
        seatMapLayout = new TableLayoutPanel();
        seatMapTitleLabel = new Label();
        screenLabel = new Label();
        _seatGridPanel = new TableLayoutPanel();
        seatARowLabel = new Label();
        seatA1Button = new Button();
        seatA2Button = new Button();
        seatA3Button = new Button();
        seatA4Button = new Button();
        seatA5Button = new Button();
        seatA6Button = new Button();
        seatA7Button = new Button();
        seatA8Button = new Button();
        seatBRowLabel = new Label();
        seatB1Button = new Button();
        seatB2Button = new Button();
        seatB3Button = new Button();
        seatB4Button = new Button();
        seatB5Button = new Button();
        seatB6Button = new Button();
        seatB7Button = new Button();
        seatB8Button = new Button();
        seatCRowLabel = new Label();
        seatC1Button = new Button();
        seatC2Button = new Button();
        seatC3Button = new Button();
        seatC4Button = new Button();
        seatC5Button = new Button();
        seatC6Button = new Button();
        seatC7Button = new Button();
        seatC8Button = new Button();
        seatDRowLabel = new Label();
        seatD1Button = new Button();
        seatD2Button = new Button();
        seatD3Button = new Button();
        seatD4Button = new Button();
        seatD5Button = new Button();
        seatD6Button = new Button();
        seatD7Button = new Button();
        seatD8Button = new Button();
        seatERowLabel = new Label();
        seatE1Button = new Button();
        seatE2Button = new Button();
        seatE3Button = new Button();
        seatE4Button = new Button();
        seatE5Button = new Button();
        seatE6Button = new Button();
        seatE7Button = new Button();
        seatE8Button = new Button();
        seatFRowLabel = new Label();
        seatF1Button = new Button();
        seatF2Button = new Button();
        seatF3Button = new Button();
        seatF4Button = new Button();
        seatF5Button = new Button();
        seatF6Button = new Button();
        seatF7Button = new Button();
        seatF8Button = new Button();
        legendPanel = new FlowLayoutPanel();
        availableSeatLegendColorLabel = new Label();
        availableSeatLegendTextLabel = new Label();
        selectedSeatLegendColorLabel = new Label();
        selectedSeatLegendTextLabel = new Label();
        soldSeatLegendColorLabel = new Label();
        soldSeatLegendTextLabel = new Label();
        maintenanceSeatLegendColorLabel = new Label();
        maintenanceSeatLegendTextLabel = new Label();
        bookingCard = new Panel();
        bookingLayout = new TableLayoutPanel();
        bookingTitleLabel = new Label();
        _selectedCountLabel = new Label();
        _selectedCountLabel.AutoEllipsis = true;
        _selectedCountLabel.Dock = DockStyle.Fill;
        _selectedCountLabel.Font = UiStyleHelper.BodyFont(9.5F);
        _selectedCountLabel.ForeColor = UiStyleHelper.TextDark;
        _selectedCountLabel.Text = "Chưa chọn ghế";
        _selectedCountLabel.TextAlign = ContentAlignment.MiddleLeft;
        _selectedSeatsPanel = new FlowLayoutPanel();
        selectedSeatB5BadgeLabel = new Label();
        selectedSeatB6BadgeLabel = new Label();
        unitPriceTitleLabel = new Label();
        _unitPriceLabel = new Label();
        _unitPriceLabel.AutoEllipsis = true;
        _unitPriceLabel.Dock = DockStyle.Fill;
        _unitPriceLabel.Font = UiStyleHelper.BodyFont(10.5F);
        _unitPriceLabel.ForeColor = UiStyleHelper.TextDark;
        _unitPriceLabel.Text = "90.000 đ";
        _unitPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalTitleLabel = new Label();
        _totalLabel = new Label();
        paymentMethodLabel = new Label();
        _paymentCombo = new ComboBox();
        _paymentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _paymentCombo.FlatStyle = FlatStyle.Flat;
        _paymentCombo.Font = UiStyleHelper.BodyFont(10F);
        _paymentCombo.Height = 34;
        payButton = new Button();
        cancelButton = new Button();
        recentCard = new Panel();
        recentLayout = new TableLayoutPanel();
        recentTitleLabel = new Label();
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
        filterBar.Controls.Add(searchFilterLabel);
        filterBar.Controls.Add(searchTextBox);
        filterBar.Controls.Add(saleDateFilterLabel);
        filterBar.Controls.Add(saleDatePicker);
        filterBar.Controls.Add(roomFilterLabel);
        filterBar.Controls.Add(_roomCombo);
        filterBar.Controls.Add(showtimeFilterLabel);
        filterBar.Controls.Add(_showtimeCombo);
        filterBar.Controls.Add(refreshButton);
        filterBar.Dock = DockStyle.Fill;
        filterBar.FlowDirection = FlowDirection.LeftToRight;
        filterBar.Padding = new Padding(0, 0, 0, 8);
        filterBar.WrapContents = false;
        StyleInlineLabel(searchFilterLabel, "Phim", 38);
        searchTextBox.Margin = new Padding(0, 18, 16, 0);
        searchTextBox.Size = new Size(188, 32);
        StyleInlineLabel(saleDateFilterLabel, "Ngày", 44);
        saleDatePicker.Margin = new Padding(0, 18, 16, 0);
        saleDatePicker.Size = new Size(112, 32);
        StyleInlineLabel(roomFilterLabel, "Phòng", 48);
        _roomCombo.Margin = new Padding(0, 18, 16, 0);
        _roomCombo.Size = new Size(128, 32);
        StyleInlineLabel(showtimeFilterLabel, "Suất", 38);
        _showtimeCombo.Margin = new Padding(0, 18, 16, 0);
        _showtimeCombo.Size = new Size(172, 32);
        _roomCombo.Items.AddRange(new object[] { "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4" });
        _roomCombo.SelectedIndex = 1;
        _showtimeCombo.Items.AddRange(new object[] { "19:30 - Avengers: Endgame", "21:15 - Dune: Phần Hai" });
        _showtimeCombo.SelectedIndex = 0;
        refreshButton.Width = 96;
        refreshButton.Height = 38;
        refreshButton.BackColor = Color.White;
        refreshButton.Cursor = Cursors.Hand;
        refreshButton.FlatStyle = FlatStyle.Flat;
        refreshButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        refreshButton.FlatAppearance.BorderSize = 1;
        refreshButton.Font = UiStyleHelper.SectionFont(9.5F);
        refreshButton.ForeColor = UiStyleHelper.Primary;
        refreshButton.Margin = new Padding(0, 18, 0, 0);
        refreshButton.Text = "Làm mới";
        refreshButton.UseVisualStyleBackColor = false;
        refreshButton.Click += RefreshButton_Click;
        //
        // movieInfoCard
        //
        movieInfoCard.BackColor = Color.White;
        movieInfoCard.BorderStyle = BorderStyle.FixedSingle;
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
        posterPanel.BackColor = ColorTranslator.FromHtml("#172554");
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
        badgePanel.Controls.Add(actionBadgeLabel);
        badgePanel.Controls.Add(subtitleBadgeLabel);
        StyleBadgeLabel(actionBadgeLabel, "Hành động", UiStyleHelper.Primary);
        StyleBadgeLabel(subtitleBadgeLabel, "Phụ đề", UiStyleHelper.Accent);
        //
        // movieSideLayout
        //
        movieSideLayout.BackColor = Color.Transparent;
        movieSideLayout.ColumnCount = 1;
        movieSideLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        movieSideLayout.Controls.Add(_roomInfoLabel, 0, 0);
        movieSideLayout.Controls.Add(seatInstructionLabel, 0, 1);
        movieSideLayout.Controls.Add(seatNoteLabel, 0, 2);
        movieSideLayout.Dock = DockStyle.Fill;
        movieSideLayout.Padding = new Padding(8, 10, 4, 4);
        movieSideLayout.RowCount = 4;
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        movieSideLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleValueLabel(seatInstructionLabel, "Sơ đồ ghế đang bán theo suất chiếu", 9.5F);
        StyleMutedLabel(seatNoteLabel, "Ghế đã bán và bảo trì sẽ bị khóa chọn.");
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
        seatMapCard.BackColor = Color.White;
        seatMapCard.BorderStyle = BorderStyle.FixedSingle;
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
        seatMapLayout.Controls.Add(seatMapTitleLabel, 0, 0);
        seatMapLayout.Controls.Add(screenLabel, 0, 1);
        seatMapLayout.Controls.Add(_seatGridPanel, 0, 2);
        seatMapLayout.Controls.Add(legendPanel, 0, 3);
        seatMapLayout.Dock = DockStyle.Fill;
        seatMapLayout.RowCount = 4;
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        seatMapLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        StyleCardTitle(seatMapTitleLabel, "SƠ ĐỒ GHẾ - MÀN HÌNH");
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
        _seatGridPanel.Controls.Add(seatARowLabel, 0, 0);
        StyleSeatRowLabel(seatARowLabel, "A");
        _seatGridPanel.Controls.Add(seatA1Button, 1, 0);
        StyleSeatButton(seatA1Button, "A1");
        _seatGridPanel.Controls.Add(seatA2Button, 2, 0);
        StyleSeatButton(seatA2Button, "A2");
        _seatGridPanel.Controls.Add(seatA3Button, 3, 0);
        StyleSeatButton(seatA3Button, "A3");
        _seatGridPanel.Controls.Add(seatA4Button, 4, 0);
        StyleSeatButton(seatA4Button, "A4");
        _seatGridPanel.Controls.Add(seatA5Button, 5, 0);
        StyleSeatButton(seatA5Button, "A5");
        _seatGridPanel.Controls.Add(seatA6Button, 6, 0);
        StyleSeatButton(seatA6Button, "A6");
        _seatGridPanel.Controls.Add(seatA7Button, 7, 0);
        StyleSeatButton(seatA7Button, "A7");
        _seatGridPanel.Controls.Add(seatA8Button, 8, 0);
        StyleSeatButton(seatA8Button, "A8");
        _seatGridPanel.Controls.Add(seatBRowLabel, 0, 1);
        StyleSeatRowLabel(seatBRowLabel, "B");
        _seatGridPanel.Controls.Add(seatB1Button, 1, 1);
        StyleSeatButton(seatB1Button, "B1");
        _seatGridPanel.Controls.Add(seatB2Button, 2, 1);
        StyleSeatButton(seatB2Button, "B2");
        _seatGridPanel.Controls.Add(seatB3Button, 3, 1);
        StyleSeatButton(seatB3Button, "B3");
        _seatGridPanel.Controls.Add(seatB4Button, 4, 1);
        StyleSeatButton(seatB4Button, "B4");
        _seatGridPanel.Controls.Add(seatB5Button, 5, 1);
        StyleSeatButton(seatB5Button, "B5");
        _seatGridPanel.Controls.Add(seatB6Button, 6, 1);
        StyleSeatButton(seatB6Button, "B6");
        _seatGridPanel.Controls.Add(seatB7Button, 7, 1);
        StyleSeatButton(seatB7Button, "B7");
        _seatGridPanel.Controls.Add(seatB8Button, 8, 1);
        StyleSeatButton(seatB8Button, "B8");
        _seatGridPanel.Controls.Add(seatCRowLabel, 0, 2);
        StyleSeatRowLabel(seatCRowLabel, "C");
        _seatGridPanel.Controls.Add(seatC1Button, 1, 2);
        StyleSeatButton(seatC1Button, "C1");
        _seatGridPanel.Controls.Add(seatC2Button, 2, 2);
        StyleSeatButton(seatC2Button, "C2");
        _seatGridPanel.Controls.Add(seatC3Button, 3, 2);
        StyleSeatButton(seatC3Button, "C3");
        _seatGridPanel.Controls.Add(seatC4Button, 4, 2);
        StyleSeatButton(seatC4Button, "C4");
        _seatGridPanel.Controls.Add(seatC5Button, 5, 2);
        StyleSeatButton(seatC5Button, "C5");
        _seatGridPanel.Controls.Add(seatC6Button, 6, 2);
        StyleSeatButton(seatC6Button, "C6");
        _seatGridPanel.Controls.Add(seatC7Button, 7, 2);
        StyleSeatButton(seatC7Button, "C7");
        _seatGridPanel.Controls.Add(seatC8Button, 8, 2);
        StyleSeatButton(seatC8Button, "C8");
        _seatGridPanel.Controls.Add(seatDRowLabel, 0, 3);
        StyleSeatRowLabel(seatDRowLabel, "D");
        _seatGridPanel.Controls.Add(seatD1Button, 1, 3);
        StyleSeatButton(seatD1Button, "D1");
        _seatGridPanel.Controls.Add(seatD2Button, 2, 3);
        StyleSeatButton(seatD2Button, "D2");
        _seatGridPanel.Controls.Add(seatD3Button, 3, 3);
        StyleSeatButton(seatD3Button, "D3");
        _seatGridPanel.Controls.Add(seatD4Button, 4, 3);
        StyleSeatButton(seatD4Button, "D4");
        _seatGridPanel.Controls.Add(seatD5Button, 5, 3);
        StyleSeatButton(seatD5Button, "D5");
        _seatGridPanel.Controls.Add(seatD6Button, 6, 3);
        StyleSeatButton(seatD6Button, "D6");
        _seatGridPanel.Controls.Add(seatD7Button, 7, 3);
        StyleSeatButton(seatD7Button, "D7");
        _seatGridPanel.Controls.Add(seatD8Button, 8, 3);
        StyleSeatButton(seatD8Button, "D8");
        _seatGridPanel.Controls.Add(seatERowLabel, 0, 4);
        StyleSeatRowLabel(seatERowLabel, "E");
        _seatGridPanel.Controls.Add(seatE1Button, 1, 4);
        StyleSeatButton(seatE1Button, "E1");
        _seatGridPanel.Controls.Add(seatE2Button, 2, 4);
        StyleSeatButton(seatE2Button, "E2");
        _seatGridPanel.Controls.Add(seatE3Button, 3, 4);
        StyleSeatButton(seatE3Button, "E3");
        _seatGridPanel.Controls.Add(seatE4Button, 4, 4);
        StyleSeatButton(seatE4Button, "E4");
        _seatGridPanel.Controls.Add(seatE5Button, 5, 4);
        StyleSeatButton(seatE5Button, "E5");
        _seatGridPanel.Controls.Add(seatE6Button, 6, 4);
        StyleSeatButton(seatE6Button, "E6");
        _seatGridPanel.Controls.Add(seatE7Button, 7, 4);
        StyleSeatButton(seatE7Button, "E7");
        _seatGridPanel.Controls.Add(seatE8Button, 8, 4);
        StyleSeatButton(seatE8Button, "E8");
        _seatGridPanel.Controls.Add(seatFRowLabel, 0, 5);
        StyleSeatRowLabel(seatFRowLabel, "F");
        _seatGridPanel.Controls.Add(seatF1Button, 1, 5);
        StyleSeatButton(seatF1Button, "F1");
        _seatGridPanel.Controls.Add(seatF2Button, 2, 5);
        StyleSeatButton(seatF2Button, "F2");
        _seatGridPanel.Controls.Add(seatF3Button, 3, 5);
        StyleSeatButton(seatF3Button, "F3");
        _seatGridPanel.Controls.Add(seatF4Button, 4, 5);
        StyleSeatButton(seatF4Button, "F4");
        _seatGridPanel.Controls.Add(seatF5Button, 5, 5);
        StyleSeatButton(seatF5Button, "F5");
        _seatGridPanel.Controls.Add(seatF6Button, 6, 5);
        StyleSeatButton(seatF6Button, "F6");
        _seatGridPanel.Controls.Add(seatF7Button, 7, 5);
        StyleSeatButton(seatF7Button, "F7");
        _seatGridPanel.Controls.Add(seatF8Button, 8, 5);
        StyleSeatButton(seatF8Button, "F8");
        //
        // legendPanel
        //
        legendPanel.BackColor = Color.Transparent;
        legendPanel.Dock = DockStyle.Fill;
        legendPanel.FlowDirection = FlowDirection.LeftToRight;
        legendPanel.WrapContents = false;
        legendPanel.Controls.Add(availableSeatLegendColorLabel);
        legendPanel.Controls.Add(availableSeatLegendTextLabel);
        legendPanel.Controls.Add(selectedSeatLegendColorLabel);
        legendPanel.Controls.Add(selectedSeatLegendTextLabel);
        legendPanel.Controls.Add(soldSeatLegendColorLabel);
        legendPanel.Controls.Add(soldSeatLegendTextLabel);
        legendPanel.Controls.Add(maintenanceSeatLegendColorLabel);
        legendPanel.Controls.Add(maintenanceSeatLegendTextLabel);
        StyleLegendSquare(availableSeatLegendColorLabel, UiStyleHelper.SeatAvailable);
        StyleLegendText(availableSeatLegendTextLabel, "Ghế trống");
        StyleLegendSquare(selectedSeatLegendColorLabel, UiStyleHelper.SeatSelected);
        StyleLegendText(selectedSeatLegendTextLabel, "Đang chọn");
        StyleLegendSquare(soldSeatLegendColorLabel, UiStyleHelper.SeatSold);
        StyleLegendText(soldSeatLegendTextLabel, "Đã bán");
        StyleLegendSquare(maintenanceSeatLegendColorLabel, UiStyleHelper.SeatMaintenance);
        StyleLegendText(maintenanceSeatLegendTextLabel, "Bảo trì");
        //
        // bookingCard
        //
        bookingCard.BackColor = Color.White;
        bookingCard.BorderStyle = BorderStyle.FixedSingle;
        bookingCard.Controls.Add(bookingLayout);
        bookingCard.Dock = DockStyle.Fill;
        bookingCard.Padding = new Padding(14);
        //
        // bookingLayout
        //
        bookingLayout.BackColor = Color.Transparent;
        bookingLayout.ColumnCount = 1;
        bookingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        bookingLayout.Controls.Add(bookingTitleLabel, 0, 0);
        bookingLayout.Controls.Add(_selectedCountLabel, 0, 1);
        bookingLayout.Controls.Add(_selectedSeatsPanel, 0, 2);
        bookingLayout.Controls.Add(unitPriceTitleLabel, 0, 3);
        bookingLayout.Controls.Add(_unitPriceLabel, 0, 4);
        bookingLayout.Controls.Add(totalTitleLabel, 0, 5);
        bookingLayout.Controls.Add(_totalLabel, 0, 6);
        bookingLayout.Controls.Add(paymentMethodLabel, 0, 7);
        bookingLayout.Controls.Add(_paymentCombo, 0, 8);
        bookingLayout.Controls.Add(payButton, 0, 9);
        bookingLayout.Controls.Add(cancelButton, 0, 10);
        bookingLayout.Dock = DockStyle.Fill;
        bookingLayout.RowCount = 11;
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        bookingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(bookingTitleLabel, "THÔNG TIN ĐẶT VÉ");
        StyleMutedLabel(unitPriceTitleLabel, "Đơn giá");
        StyleMutedLabel(totalTitleLabel, "Thành tiền");
        StyleMutedLabel(paymentMethodLabel, "Phương thức thanh toán");
        _selectedSeatsPanel.BackColor = Color.Transparent;
        _selectedSeatsPanel.Dock = DockStyle.Fill;
        _selectedSeatsPanel.FlowDirection = FlowDirection.LeftToRight;
        _selectedSeatsPanel.WrapContents = true;
        _selectedSeatsPanel.Controls.Add(selectedSeatB5BadgeLabel);
        _selectedSeatsPanel.Controls.Add(selectedSeatB6BadgeLabel);
        StyleBadgeLabel(selectedSeatB5BadgeLabel, "B5", UiStyleHelper.Success);
        StyleBadgeLabel(selectedSeatB6BadgeLabel, "B6", UiStyleHelper.Success);
        _selectedCountLabel.Text = "Đã chọn 2 ghế";
        _paymentCombo.Items.AddRange(new object[] { "Tiền mặt", "VNPAY Sandbox" });
        _paymentCombo.SelectedIndex = 0;
        _paymentCombo.Dock = DockStyle.Fill;
        _paymentCombo.Margin = new Padding(0, 0, 0, 6);
        _totalLabel.Dock = DockStyle.Fill;
        _totalLabel.Font = UiStyleHelper.TitleFont(18F);
        _totalLabel.ForeColor = UiStyleHelper.Primary;
        _totalLabel.Text = "0 đ";
        _totalLabel.TextAlign = ContentAlignment.TopRight;
        payButton.Dock = DockStyle.Fill;
        payButton.BackColor = UiStyleHelper.Primary;
        payButton.Cursor = Cursors.Hand;
        payButton.FlatStyle = FlatStyle.Flat;
        payButton.FlatAppearance.BorderSize = 0;
        payButton.Font = UiStyleHelper.SectionFont(9.5F);
        payButton.ForeColor = Color.White;
        payButton.Margin = new Padding(0, 0, 0, 6);
        payButton.Text = "Thanh toán";
        payButton.UseVisualStyleBackColor = false;
        payButton.Click += PayButton_Click;
        cancelButton.BackColor = Color.White;
        cancelButton.Cursor = Cursors.Hand;
        cancelButton.Dock = DockStyle.Top;
        cancelButton.FlatStyle = FlatStyle.Flat;
        cancelButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FFB4B4");
        cancelButton.FlatAppearance.BorderSize = 1;
        cancelButton.Font = UiStyleHelper.SectionFont(9.5F);
        cancelButton.ForeColor = UiStyleHelper.Danger;
        cancelButton.Height = 38;
        cancelButton.Margin = Padding.Empty;
        cancelButton.Text = "Hủy";
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Click += CancelButton_Click;
        //
        // recentCard
        //
        recentCard.BackColor = Color.White;
        recentCard.BorderStyle = BorderStyle.FixedSingle;
        recentCard.Controls.Add(recentLayout);
        recentCard.Dock = DockStyle.Fill;
        recentCard.Padding = new Padding(10);
        //
        // recentLayout
        //
        recentLayout.BackColor = Color.Transparent;
        recentLayout.ColumnCount = 1;
        recentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        recentLayout.Controls.Add(recentTitleLabel, 0, 0);
        recentLayout.Controls.Add(_recentGrid, 0, 1);
        recentLayout.Dock = DockStyle.Fill;
        recentLayout.RowCount = 2;
        recentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        recentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(recentTitleLabel, "GIAO DỊCH GẦN NHẤT");
        //
        // _recentGrid
        //
        _recentGrid.Dock = DockStyle.Fill;
        _recentGrid.AutoGenerateColumns = false;
        _recentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _recentGrid.ColumnHeadersHeight = 40;
        _recentGrid.RowHeadersVisible = false;
        _recentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recentGridTimeColumn.Name = "Time";
        recentGridTimeColumn.DataPropertyName = "Time";
        recentGridTimeColumn.HeaderText = "Thời gian";
        recentGridTimeColumn.FillWeight = 80F;
        recentGridTimeColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridTimeColumn);
        recentGridMovieColumn.Name = "Movie";
        recentGridMovieColumn.DataPropertyName = "Movie";
        recentGridMovieColumn.HeaderText = "Phim";
        recentGridMovieColumn.FillWeight = 160F;
        recentGridMovieColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridMovieColumn);
        recentGridShowtimeColumn.Name = "Showtime";
        recentGridShowtimeColumn.DataPropertyName = "Showtime";
        recentGridShowtimeColumn.HeaderText = "Suất chiếu";
        recentGridShowtimeColumn.FillWeight = 90F;
        recentGridShowtimeColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridShowtimeColumn);
        recentGridRoomColumn.Name = "Room";
        recentGridRoomColumn.DataPropertyName = "Room";
        recentGridRoomColumn.HeaderText = "Phòng";
        recentGridRoomColumn.FillWeight = 80F;
        recentGridRoomColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridRoomColumn);
        recentGridSeatsColumn.Name = "Seats";
        recentGridSeatsColumn.DataPropertyName = "Seats";
        recentGridSeatsColumn.HeaderText = "Ghế";
        recentGridSeatsColumn.FillWeight = 90F;
        recentGridSeatsColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridSeatsColumn);
        recentGridQuantityColumn.Name = "Quantity";
        recentGridQuantityColumn.DataPropertyName = "Quantity";
        recentGridQuantityColumn.HeaderText = "SL";
        recentGridQuantityColumn.FillWeight = 40F;
        recentGridQuantityColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridQuantityColumn);
        recentGridTotalColumn.Name = "Total";
        recentGridTotalColumn.DataPropertyName = "Total";
        recentGridTotalColumn.HeaderText = "Tổng tiền";
        recentGridTotalColumn.FillWeight = 90F;
        recentGridTotalColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridTotalColumn);
        recentGridPaymentColumn.Name = "Payment";
        recentGridPaymentColumn.DataPropertyName = "Payment";
        recentGridPaymentColumn.HeaderText = "Phương thức";
        recentGridPaymentColumn.FillWeight = 100F;
        recentGridPaymentColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridPaymentColumn);
        recentGridStatusColumn.Name = "Status";
        recentGridStatusColumn.DataPropertyName = "Status";
        recentGridStatusColumn.HeaderText = "Trạng thái";
        recentGridStatusColumn.FillWeight = 95F;
        recentGridStatusColumn.MinimumWidth = 52;
        _recentGrid.Columns.Add(recentGridStatusColumn);
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
        UiStyleHelper.CompleteDesignerGrid(_recentGrid);
        ResumeLayout(false);
    }

    private static void StyleInlineLabel(Label label, string text, int width)
    {
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 21, 8, 0);
        label.Size = new Size(width, 28);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleCardTitle(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(10F);
        label.ForeColor = UiStyleHelper.Primary;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleValueLabel(Label label, string text, float size)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.BodyFont(size);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleMutedLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleBadgeLabel(Label label, string text, Color color)
    {
        label.AutoSize = false;
        label.BackColor = color;
        label.Font = UiStyleHelper.SmallFont(8.5F);
        label.ForeColor = Color.White;
        label.Margin = new Padding(0, 2, 6, 0);
        label.Size = new Size(78, 22);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
    }

    private static void StyleLegendSquare(Label label, Color color)
    {
        label.BackColor = color;
        label.BorderStyle = BorderStyle.FixedSingle;
        label.Margin = new Padding(0, 5, 6, 0);
        label.Size = new Size(20, 18);
    }

    private static void StyleLegendText(Label label, string text)
    {
        label.Font = UiStyleHelper.SmallFont(9F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 1, 18, 0);
        label.Size = new Size(74, 24);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }
    private static void StyleSeatRowLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(10F);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Margin = new Padding(0, 4, 10, 4);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
    }

    private static void StyleSeatButton(Button button, string seatCode)
    {
        button.BackColor = UiStyleHelper.SeatAvailable;
        button.Cursor = Cursors.Hand;
        button.Dock = DockStyle.Fill;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
        button.FlatAppearance.BorderSize = 1;
        button.Font = UiStyleHelper.SectionFont(8.75F);
        button.ForeColor = UiStyleHelper.TextDark;
        button.Margin = new Padding(6, 4, 6, 4);
        button.Name = "seat" + seatCode + "Button";
        button.Tag = seatCode;
        button.Text = seatCode;
        if (seatCode is "B5" or "B6")
        {
            button.BackColor = UiStyleHelper.SeatSelected;
            button.FlatAppearance.BorderColor = UiStyleHelper.Success;
        }
        else if (seatCode is "C3" or "C4")
        {
            button.BackColor = UiStyleHelper.SeatSold;
            button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FFA3A3");
        }
        else if (seatCode is "D7")
        {
            button.BackColor = UiStyleHelper.SeatMaintenance;
        }
        button.UseVisualStyleBackColor = false;
    }
}
