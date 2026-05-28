using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class SoldTicketsForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private Label fromDateFilterLabel;
    private DateTimePicker fromDatePicker;
    private Label toDateFilterLabel;
    private DateTimePicker toDatePicker;
    private Label movieFilterLabel;
    private ComboBox movieCombo;
    private Label statusFilterLabel;
    private ComboBox statusCombo;
    private Label searchFilterLabel;
    private TextBox searchTextBox;
    private Button searchButton;
    private Button refreshButton;
    private TableLayoutPanel contentLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private Label gridTitleLabel;
    private DataGridView _grid;
    private TableLayoutPanel rightLayout;
    private Panel detailPanel;
    private TableLayoutPanel detailLayout;
    private Label detailTitleLabel;
    private Label _detailLabel;
    private Label qrCodeLabel;
    private Label _statusLabel;
    private FlowLayoutPanel actionPanel;
    private Button printButton;
    private Button cancelTicketButton;
    private Button viewLogButton;
    private Panel logPanel;
    private TableLayoutPanel logLayout;
    private Label logTitleLabel;
    private DataGridView _logGrid;

    private DataGridViewTextBoxColumn gridTicketIdColumn;
    private DataGridViewTextBoxColumn gridMovieColumn;
    private DataGridViewTextBoxColumn gridShowtimeColumn;
    private DataGridViewTextBoxColumn gridRoomColumn;
    private DataGridViewTextBoxColumn gridSeatsColumn;
    private DataGridViewTextBoxColumn gridQuantityColumn;
    private DataGridViewTextBoxColumn gridTotalColumn;
    private DataGridViewTextBoxColumn gridPaymentMethodColumn;
    private DataGridViewTextBoxColumn gridStatusColumn;
    private DataGridViewTextBoxColumn logGridTimeColumn;
    private DataGridViewTextBoxColumn logGridActionColumn;
    private DataGridViewTextBoxColumn logGridContentColumn;
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
        rootLayout = new TableLayoutPanel();
        filterPanel = new FlowLayoutPanel();
        fromDateFilterLabel = new Label();
        fromDatePicker = new DateTimePicker();
        toDateFilterLabel = new Label();
        toDatePicker = new DateTimePicker();
        movieFilterLabel = new Label();
        movieCombo = new ComboBox();
        statusFilterLabel = new Label();
        statusCombo = new ComboBox();
        searchFilterLabel = new Label();
        searchTextBox = new TextBox();
        searchButton = new Button();
        refreshButton = new Button();
        contentLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        gridTitleLabel = new Label();
        _grid = new DataGridView();
        rightLayout = new TableLayoutPanel();
        detailPanel = new Panel();
        detailLayout = new TableLayoutPanel();
        detailTitleLabel = new Label();
        _detailLabel = new Label();
        qrCodeLabel = new Label();
        _statusLabel = new Label();
        actionPanel = new FlowLayoutPanel();
        printButton = new Button();
        cancelTicketButton = new Button();
        viewLogButton = new Button();
        logPanel = new Panel();
        logLayout = new TableLayoutPanel();
        logTitleLabel = new Label();
        _logGrid = new DataGridView();
        gridTicketIdColumn = new DataGridViewTextBoxColumn();
        gridMovieColumn = new DataGridViewTextBoxColumn();
        gridShowtimeColumn = new DataGridViewTextBoxColumn();
        gridRoomColumn = new DataGridViewTextBoxColumn();
        gridSeatsColumn = new DataGridViewTextBoxColumn();
        gridQuantityColumn = new DataGridViewTextBoxColumn();
        gridTotalColumn = new DataGridViewTextBoxColumn();
        gridPaymentMethodColumn = new DataGridViewTextBoxColumn();
        gridStatusColumn = new DataGridViewTextBoxColumn();
        logGridTimeColumn = new DataGridViewTextBoxColumn();
        logGridActionColumn = new DataGridViewTextBoxColumn();
        logGridContentColumn = new DataGridViewTextBoxColumn();
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        contentLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        rightLayout.SuspendLayout();
        detailPanel.SuspendLayout();
        detailLayout.SuspendLayout();
        actionPanel.SuspendLayout();
        logPanel.SuspendLayout();
        logLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_logGrid).BeginInit();
        SuspendLayout();
        // 
        // rootLayout
        // 
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(contentLayout, 0, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.Size = new Size(1100, 620);
        rootLayout.TabIndex = 0;
        // 
        // filterPanel
        // 
        filterPanel.BackColor = Color.FromArgb(245, 248, 252);
        filterPanel.Controls.Add(fromDateFilterLabel);
        filterPanel.Controls.Add(fromDatePicker);
        filterPanel.Controls.Add(toDateFilterLabel);
        filterPanel.Controls.Add(toDatePicker);
        filterPanel.Controls.Add(movieFilterLabel);
        filterPanel.Controls.Add(movieCombo);
        filterPanel.Controls.Add(statusFilterLabel);
        filterPanel.Controls.Add(statusCombo);
        filterPanel.Controls.Add(searchFilterLabel);
        filterPanel.Controls.Add(searchTextBox);
        filterPanel.Controls.Add(searchButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.Location = new Point(3, 4);
        filterPanel.Margin = new Padding(3, 4, 3, 4);
        filterPanel.Name = "filterPanel";
        filterPanel.Padding = new Padding(0, 0, 0, 11);
        filterPanel.Size = new Size(1094, 77);
        filterPanel.TabIndex = 0;
        filterPanel.WrapContents = false;
        // 
        // fromDateFilterLabel
        // 
        fromDateFilterLabel.Location = new Point(3, 0);
        fromDateFilterLabel.Name = "fromDateFilterLabel";
        fromDateFilterLabel.Size = new Size(114, 31);
        fromDateFilterLabel.TabIndex = 0;
        // 
        // fromDatePicker
        // 
        fromDatePicker.Format = DateTimePickerFormat.Short;
        fromDatePicker.Location = new Point(120, 24);
        fromDatePicker.Margin = new Padding(0, 24, 11, 0);
        fromDatePicker.Name = "fromDatePicker";
        fromDatePicker.Size = new Size(116, 27);
        fromDatePicker.TabIndex = 1;
        fromDatePicker.Value = new DateTime(2026, 5, 21, 0, 0, 0, 0);
        // 
        // toDateFilterLabel
        // 
        toDateFilterLabel.Location = new Point(250, 0);
        toDateFilterLabel.Name = "toDateFilterLabel";
        toDateFilterLabel.Size = new Size(114, 31);
        toDateFilterLabel.TabIndex = 2;
        // 
        // toDatePicker
        // 
        toDatePicker.Format = DateTimePickerFormat.Short;
        toDatePicker.Location = new Point(367, 24);
        toDatePicker.Margin = new Padding(0, 24, 11, 0);
        toDatePicker.Name = "toDatePicker";
        toDatePicker.Size = new Size(116, 27);
        toDatePicker.TabIndex = 3;
        // 
        // movieFilterLabel
        // 
        movieFilterLabel.Location = new Point(497, 0);
        movieFilterLabel.Name = "movieFilterLabel";
        movieFilterLabel.Size = new Size(114, 31);
        movieFilterLabel.TabIndex = 4;
        // 
        // movieCombo
        // 
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        movieCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dune: Phần Hai" });
        movieCombo.Location = new Point(614, 24);
        movieCombo.Margin = new Padding(0, 24, 11, 0);
        movieCombo.Name = "movieCombo";
        movieCombo.Size = new Size(134, 28);
        movieCombo.TabIndex = 5;
        // 
        // statusFilterLabel
        // 
        statusFilterLabel.Location = new Point(762, 0);
        statusFilterLabel.Name = "statusFilterLabel";
        statusFilterLabel.Size = new Size(114, 31);
        statusFilterLabel.TabIndex = 6;
        // 
        // statusCombo
        // 
        statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        statusCombo.Items.AddRange(new object[] { "Tất cả trạng thái", "Chưa sử dụng", "Đã sử dụng", "Đã hủy" });
        statusCombo.Location = new Point(879, 24);
        statusCombo.Margin = new Padding(0, 24, 11, 0);
        statusCombo.Name = "statusCombo";
        statusCombo.Size = new Size(123, 28);
        statusCombo.TabIndex = 7;
        // 
        // searchFilterLabel
        // 
        searchFilterLabel.Location = new Point(1016, 0);
        searchFilterLabel.Name = "searchFilterLabel";
        searchFilterLabel.Size = new Size(114, 31);
        searchFilterLabel.TabIndex = 8;
        // 
        // searchTextBox
        // 
        searchTextBox.BorderStyle = BorderStyle.FixedSingle;
        searchTextBox.Location = new Point(1133, 24);
        searchTextBox.Margin = new Padding(0, 24, 11, 0);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Nhập mã vé hoặc tên phim...";
        searchTextBox.Size = new Size(157, 42);
        searchTextBox.TabIndex = 9;
        // 
        // searchButton
        // 
        searchButton.Location = new Point(1301, 24);
        searchButton.Margin = new Padding(0, 24, 9, 0);
        searchButton.Name = "searchButton";
        searchButton.Size = new Size(103, 48);
        searchButton.TabIndex = 10;
        searchButton.Text = "Tìm kiếm";
        // 
        // refreshButton
        // 
        refreshButton.Location = new Point(1413, 24);
        refreshButton.Margin = new Padding(0, 24, 0, 0);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(103, 48);
        refreshButton.TabIndex = 11;
        refreshButton.Text = "Làm mới";
        // 
        // contentLayout
        // 
        contentLayout.BackColor = Color.FromArgb(245, 248, 252);
        contentLayout.ColumnCount = 2;
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        contentLayout.Controls.Add(gridPanel, 0, 0);
        contentLayout.Controls.Add(rightLayout, 1, 0);
        contentLayout.Dock = DockStyle.Fill;
        contentLayout.Location = new Point(3, 89);
        contentLayout.Margin = new Padding(3, 4, 3, 4);
        contentLayout.Name = "contentLayout";
        contentLayout.RowCount = 1;
        contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        contentLayout.Size = new Size(1094, 527);
        contentLayout.TabIndex = 1;
        // 
        // gridPanel
        // 
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(gridLayout);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Location = new Point(0, 0);
        gridPanel.Margin = new Padding(0, 0, 14, 0);
        gridPanel.Name = "gridPanel";
        gridPanel.Padding = new Padding(11, 13, 11, 13);
        gridPanel.Size = new Size(861, 734);
        gridPanel.TabIndex = 0;
        // 
        // gridLayout
        // 
        gridLayout.BackColor = Color.White;
        gridLayout.ColumnCount = 1;
        gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        gridLayout.Controls.Add(gridTitleLabel, 0, 0);
        gridLayout.Controls.Add(_grid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.Location = new Point(11, 13);
        gridLayout.Margin = new Padding(3, 4, 3, 4);
        gridLayout.Name = "gridLayout";
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        gridLayout.Size = new Size(837, 706);
        gridLayout.TabIndex = 0;
        // 
        // gridTitleLabel
        // 
        gridTitleLabel.Location = new Point(3, 0);
        gridTitleLabel.Name = "gridTitleLabel";
        gridTitleLabel.Size = new Size(114, 31);
        gridTitleLabel.TabIndex = 0;
        // 
        // _grid
        // 
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeight = 40;
        _grid.Dock = DockStyle.Fill;
        _grid.Location = new Point(3, 44);
        _grid.Margin = new Padding(3, 4, 3, 4);
        _grid.Name = "_grid";
        _grid.RowHeadersVisible = false;
        _grid.RowHeadersWidth = 51;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _grid.Size = new Size(831, 658);
        _grid.TabIndex = 1;
        _grid.CellContentClick += _grid_CellContentClick;
        // 
        // rightLayout
        // 
        rightLayout.BackColor = Color.FromArgb(245, 248, 252);
        rightLayout.ColumnCount = 1;
        rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rightLayout.Controls.Add(detailPanel, 0, 0);
        rightLayout.Controls.Add(logPanel, 0, 1);
        rightLayout.Dock = DockStyle.Fill;
        rightLayout.Location = new Point(878, 4);
        rightLayout.Margin = new Padding(3, 4, 3, 4);
        rightLayout.Name = "rightLayout";
        rightLayout.RowCount = 2;
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        rightLayout.Size = new Size(370, 726);
        rightLayout.TabIndex = 1;
        // 
        // detailPanel
        // 
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailLayout);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Location = new Point(0, 0);
        detailPanel.Margin = new Padding(0, 0, 0, 13);
        detailPanel.Name = "detailPanel";
        detailPanel.Padding = new Padding(18, 21, 18, 21);
        detailPanel.Size = new Size(370, 422);
        detailPanel.TabIndex = 0;
        // 
        // detailLayout
        // 
        detailLayout.BackColor = Color.White;
        detailLayout.ColumnCount = 1;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(detailTitleLabel, 0, 0);
        detailLayout.Controls.Add(_detailLabel, 0, 1);
        detailLayout.Controls.Add(qrCodeLabel, 0, 2);
        detailLayout.Controls.Add(_statusLabel, 0, 3);
        detailLayout.Controls.Add(actionPanel, 0, 4);
        detailLayout.Dock = DockStyle.Fill;
        detailLayout.Location = new Point(18, 21);
        detailLayout.Margin = new Padding(3, 4, 3, 4);
        detailLayout.Name = "detailLayout";
        detailLayout.RowCount = 5;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        detailLayout.Size = new Size(332, 378);
        detailLayout.TabIndex = 0;
        // 
        // detailTitleLabel
        // 
        detailTitleLabel.Location = new Point(3, 0);
        detailTitleLabel.Name = "detailTitleLabel";
        detailTitleLabel.Size = new Size(114, 31);
        detailTitleLabel.TabIndex = 0;
        // 
        // _detailLabel
        // 
        _detailLabel.Dock = DockStyle.Fill;
        _detailLabel.Font = new Font("Segoe UI", 9.75F);
        _detailLabel.ForeColor = Color.FromArgb(17, 27, 63);
        _detailLabel.Location = new Point(3, 40);
        _detailLabel.Name = "_detailLabel";
        _detailLabel.Size = new Size(326, 77);
        _detailLabel.TabIndex = 1;
        _detailLabel.Text = "TK000001\r\n\r\nPhim: Avengers: Endgame\r\nSuất chiếu: 19:30 - 22:32\r\nPhòng: Phòng 2\r\nGhế: B5, B6\r\nTổng tiền: 180.000 đ\r\nThanh toán: Tiền mặt";
        _detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // qrCodeLabel
        // 
        qrCodeLabel.BackColor = Color.White;
        qrCodeLabel.BorderStyle = BorderStyle.FixedSingle;
        qrCodeLabel.Dock = DockStyle.Fill;
        qrCodeLabel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        qrCodeLabel.Location = new Point(87, 117);
        qrCodeLabel.Margin = new Padding(87, 0, 87, 0);
        qrCodeLabel.Name = "qrCodeLabel";
        qrCodeLabel.Size = new Size(158, 165);
        qrCodeLabel.TabIndex = 2;
        qrCodeLabel.Text = "QR\r\nTK000001";
        qrCodeLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _statusLabel
        // 
        _statusLabel.Dock = DockStyle.Fill;
        _statusLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        _statusLabel.ForeColor = Color.FromArgb(22, 163, 74);
        _statusLabel.Location = new Point(3, 282);
        _statusLabel.Name = "_statusLabel";
        _statusLabel.Size = new Size(326, 40);
        _statusLabel.TabIndex = 3;
        _statusLabel.Text = "Vé chưa sử dụng";
        _statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // actionPanel
        // 
        actionPanel.BackColor = Color.White;
        actionPanel.Controls.Add(printButton);
        actionPanel.Controls.Add(cancelTicketButton);
        actionPanel.Controls.Add(viewLogButton);
        actionPanel.Dock = DockStyle.Fill;
        actionPanel.Location = new Point(3, 326);
        actionPanel.Margin = new Padding(3, 4, 3, 4);
        actionPanel.Name = "actionPanel";
        actionPanel.Size = new Size(326, 48);
        actionPanel.TabIndex = 4;
        actionPanel.WrapContents = false;
        // 
        // printButton
        // 
        printButton.Location = new Point(3, 4);
        printButton.Margin = new Padding(3, 4, 3, 4);
        printButton.Name = "printButton";
        printButton.Size = new Size(98, 48);
        printButton.TabIndex = 0;
        printButton.Text = "In vé";
        // 
        // cancelTicketButton
        // 
        cancelTicketButton.Location = new Point(107, 4);
        cancelTicketButton.Margin = new Padding(3, 4, 3, 4);
        cancelTicketButton.Name = "cancelTicketButton";
        cancelTicketButton.Size = new Size(98, 48);
        cancelTicketButton.TabIndex = 1;
        cancelTicketButton.Text = "Hủy vé";
        // 
        // viewLogButton
        // 
        viewLogButton.Location = new Point(211, 4);
        viewLogButton.Margin = new Padding(3, 4, 3, 4);
        viewLogButton.Name = "viewLogButton";
        viewLogButton.Size = new Size(98, 48);
        viewLogButton.TabIndex = 2;
        viewLogButton.Text = "Xem log";
        // 
        // logPanel
        // 
        logPanel.BackColor = Color.White;
        logPanel.BorderStyle = BorderStyle.FixedSingle;
        logPanel.Controls.Add(logLayout);
        logPanel.Dock = DockStyle.Fill;
        logPanel.Location = new Point(3, 439);
        logPanel.Margin = new Padding(3, 4, 3, 4);
        logPanel.Name = "logPanel";
        logPanel.Padding = new Padding(11, 13, 11, 13);
        logPanel.Size = new Size(364, 283);
        logPanel.TabIndex = 1;
        // 
        // logLayout
        // 
        logLayout.BackColor = Color.White;
        logLayout.ColumnCount = 1;
        logLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        logLayout.Controls.Add(logTitleLabel, 0, 0);
        logLayout.Controls.Add(_logGrid, 0, 1);
        logLayout.Dock = DockStyle.Fill;
        logLayout.Location = new Point(11, 13);
        logLayout.Margin = new Padding(3, 4, 3, 4);
        logLayout.Name = "logLayout";
        logLayout.RowCount = 2;
        logLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
        logLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        logLayout.Size = new Size(340, 255);
        logLayout.TabIndex = 0;
        // 
        // logTitleLabel
        // 
        logTitleLabel.Location = new Point(3, 0);
        logTitleLabel.Name = "logTitleLabel";
        logTitleLabel.Size = new Size(114, 31);
        logTitleLabel.TabIndex = 0;
        // 
        // _logGrid
        // 
        _logGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _logGrid.ColumnHeadersHeight = 40;
        _logGrid.Dock = DockStyle.Fill;
        _logGrid.Location = new Point(3, 41);
        _logGrid.Margin = new Padding(3, 4, 3, 4);
        _logGrid.Name = "_logGrid";
        _logGrid.RowHeadersVisible = false;
        _logGrid.RowHeadersWidth = 51;
        _logGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _logGrid.Size = new Size(334, 210);
        _logGrid.TabIndex = 1;
        // 
        // SoldTicketsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SoldTicketsForm";
        Text = "Vé đã bán";
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        contentLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        rightLayout.ResumeLayout(false);
        detailPanel.ResumeLayout(false);
        detailLayout.ResumeLayout(false);
        actionPanel.ResumeLayout(false);
        logPanel.ResumeLayout(false);
        logLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_logGrid).EndInit();
        ConfigureDesignerSurface();
        ResumeLayout(false);
    }

    private void ConfigureDesignerSurface()
    {
        StyleInlineLabel(fromDateFilterLabel, "Từ ngày", 58);
        StyleInlineLabel(toDateFilterLabel, "Đến ngày", 62);
        StyleInlineLabel(movieFilterLabel, "Phim", 42);
        StyleInlineLabel(statusFilterLabel, "Trạng thái", 72);
        StyleInlineLabel(searchFilterLabel, "Tìm", 34);
        fromDatePicker.Size = new Size(104, 27);
        toDatePicker.Size = new Size(104, 27);
        movieCombo.Size = new Size(122, 28);
        statusCombo.Size = new Size(118, 28);
        searchTextBox.Size = new Size(136, 27);
        searchButton.Size = new Size(88, 40);
        refreshButton.Size = new Size(82, 40);

        StyleCardTitle(gridTitleLabel, "DANH SÁCH VÉ ĐÃ BÁN");
        StyleCardTitle(detailTitleLabel, "CHI TIẾT VÉ");
        StyleCardTitle(logTitleLabel, "NHẬT KÝ GIAO DỊCH");

        ConfigureColumn(gridTicketIdColumn, "TicketId", "Mã vé", 86F);
        ConfigureColumn(gridMovieColumn, "Movie", "Phim", 160F);
        ConfigureColumn(gridShowtimeColumn, "Showtime", "Suất chiếu", 110F);
        ConfigureColumn(gridRoomColumn, "Room", "Phòng", 80F);
        ConfigureColumn(gridSeatsColumn, "Seats", "Ghế", 70F);
        ConfigureColumn(gridQuantityColumn, "Quantity", "SL", 45F);
        ConfigureColumn(gridTotalColumn, "Total", "Tổng tiền", 95F);
        ConfigureColumn(gridPaymentMethodColumn, "PaymentMethod", "Thanh toán", 105F);
        ConfigureColumn(gridStatusColumn, "Status", "Trạng thái", 95F);
        ConfigureGridWithColumns(_grid, gridTicketIdColumn, gridMovieColumn, gridShowtimeColumn, gridRoomColumn, gridSeatsColumn, gridQuantityColumn, gridTotalColumn, gridPaymentMethodColumn, gridStatusColumn);

        ConfigureColumn(logGridTimeColumn, "Time", "Thời gian", 84F);
        ConfigureColumn(logGridActionColumn, "Action", "Thao tác", 98F);
        ConfigureColumn(logGridContentColumn, "Content", "Nội dung", 180F);
        ConfigureGridWithColumns(_logGrid, logGridTimeColumn, logGridActionColumn, logGridContentColumn);
    }

    private static void ConfigureColumn(DataGridViewTextBoxColumn column, string dataPropertyName, string headerText, float fillWeight)
    {
        column.Name = dataPropertyName;
        column.DataPropertyName = dataPropertyName;
        column.HeaderText = headerText;
        column.FillWeight = fillWeight;
    }

    private static void ConfigureGridWithColumns(DataGridView grid, params DataGridViewTextBoxColumn[] columns)
    {
        grid.Columns.Clear();
        grid.Columns.AddRange(columns);
        ConfigureGrid(grid);
        UiStyleHelper.CompleteDesignerGrid(grid);
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
}
