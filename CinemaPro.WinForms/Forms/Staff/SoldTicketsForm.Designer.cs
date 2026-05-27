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
        components = new System.ComponentModel.Container();
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
        // SoldTicketsForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "SoldTicketsForm";
        Text = "Vé đã bán";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(contentLayout, 0, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // filterPanel
        //
        filterPanel.BackColor = UiStyleHelper.ContentBackground;
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
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        StyleInlineLabel(fromDateFilterLabel, "Từ", 32);
        fromDatePicker.Format = DateTimePickerFormat.Short;
        fromDatePicker.Margin = new Padding(0, 18, 10, 0);
        fromDatePicker.Size = new Size(102, 32);
        fromDatePicker.Value = DateTime.Today.AddDays(-7);
        StyleInlineLabel(toDateFilterLabel, "Đến", 38);
        toDatePicker.Format = DateTimePickerFormat.Short;
        toDatePicker.Margin = new Padding(0, 18, 10, 0);
        toDatePicker.Size = new Size(102, 32);
        StyleInlineLabel(movieFilterLabel, "Phim", 38);
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        movieCombo.Margin = new Padding(0, 18, 10, 0);
        movieCombo.Size = new Size(118, 32);
        StyleInlineLabel(statusFilterLabel, "Trạng thái", 70);
        statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        statusCombo.Margin = new Padding(0, 18, 10, 0);
        statusCombo.Size = new Size(108, 32);
        movieCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dune: Phần Hai" });
        movieCombo.SelectedIndex = 0;
        statusCombo.Items.AddRange(new object[] { "Tất cả trạng thái", "Chưa sử dụng", "Đã sử dụng", "Đã hủy" });
        statusCombo.SelectedIndex = 0;
        searchTextBox.AutoSize = false;
        searchTextBox.BorderStyle = BorderStyle.FixedSingle;
        searchTextBox.Margin = new Padding(0, 18, 10, 0);
        searchTextBox.PlaceholderText = "Nhập mã vé hoặc tên phim...";
        searchTextBox.Size = new Size(138, 32);
        StyleInlineLabel(searchFilterLabel, "Tìm", 34);
        searchButton.Margin = new Padding(0, 18, 8, 0);
        searchButton.Size = new Size(90, 36);
        searchButton.Text = "Tìm kiếm";
        refreshButton.Margin = new Padding(0, 18, 0, 0);
        refreshButton.Size = new Size(90, 36);
        refreshButton.Text = "Làm mới";
        //
        // contentLayout
        //
        contentLayout.BackColor = UiStyleHelper.ContentBackground;
        contentLayout.ColumnCount = 2;
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        contentLayout.Controls.Add(gridPanel, 0, 0);
        contentLayout.Controls.Add(rightLayout, 1, 0);
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
        //
        // gridLayout
        //
        gridLayout.BackColor = Color.White;
        gridLayout.ColumnCount = 1;
        gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        gridLayout.Controls.Add(gridTitleLabel, 0, 0);
        gridLayout.Controls.Add(_grid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(gridTitleLabel, "DANH SÁCH VÉ ĐÃ BÁN");
        //
        // _grid
        //
        ConfigureGrid(_grid);
        _grid.Dock = DockStyle.Fill;
        _grid.AutoGenerateColumns = false;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeight = 40;
        _grid.RowHeadersVisible = false;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridTicketIdColumn.Name = "TicketId";
        gridTicketIdColumn.DataPropertyName = "TicketId";
        gridTicketIdColumn.HeaderText = "Mã vé";
        gridTicketIdColumn.FillWeight = 92F;
        _grid.Columns.Add(gridTicketIdColumn);
        gridMovieColumn.Name = "Movie";
        gridMovieColumn.DataPropertyName = "Movie";
        gridMovieColumn.HeaderText = "Phim";
        gridMovieColumn.FillWeight = 160F;
        _grid.Columns.Add(gridMovieColumn);
        gridShowtimeColumn.Name = "Showtime";
        gridShowtimeColumn.DataPropertyName = "Showtime";
        gridShowtimeColumn.HeaderText = "Suất chiếu";
        gridShowtimeColumn.FillWeight = 110F;
        _grid.Columns.Add(gridShowtimeColumn);
        gridRoomColumn.Name = "Room";
        gridRoomColumn.DataPropertyName = "Room";
        gridRoomColumn.HeaderText = "Phòng";
        gridRoomColumn.FillWeight = 78F;
        _grid.Columns.Add(gridRoomColumn);
        gridSeatsColumn.Name = "Seats";
        gridSeatsColumn.DataPropertyName = "Seats";
        gridSeatsColumn.HeaderText = "Ghế";
        gridSeatsColumn.FillWeight = 78F;
        _grid.Columns.Add(gridSeatsColumn);
        gridQuantityColumn.Name = "Quantity";
        gridQuantityColumn.DataPropertyName = "Quantity";
        gridQuantityColumn.HeaderText = "SL";
        gridQuantityColumn.FillWeight = 42F;
        _grid.Columns.Add(gridQuantityColumn);
        gridTotalColumn.Name = "Total";
        gridTotalColumn.DataPropertyName = "Total";
        gridTotalColumn.HeaderText = "Tổng tiền";
        gridTotalColumn.FillWeight = 92F;
        _grid.Columns.Add(gridTotalColumn);
        gridPaymentMethodColumn.Name = "PaymentMethod";
        gridPaymentMethodColumn.DataPropertyName = "PaymentMethod";
        gridPaymentMethodColumn.HeaderText = "Thanh toán";
        gridPaymentMethodColumn.FillWeight = 108F;
        _grid.Columns.Add(gridPaymentMethodColumn);
        gridStatusColumn.Name = "Status";
        gridStatusColumn.DataPropertyName = "Status";
        gridStatusColumn.HeaderText = "Trạng thái";
        gridStatusColumn.FillWeight = 90F;
        _grid.Columns.Add(gridStatusColumn);
        //
        // rightLayout
        //
        rightLayout.BackColor = UiStyleHelper.ContentBackground;
        rightLayout.ColumnCount = 1;
        rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rightLayout.Controls.Add(detailPanel, 0, 0);
        rightLayout.Controls.Add(logPanel, 0, 1);
        rightLayout.Dock = DockStyle.Fill;
        rightLayout.RowCount = 2;
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        //
        // detailPanel
        //
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailLayout);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Margin = new Padding(0, 0, 0, 10);
        detailPanel.Padding = new Padding(16);
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
        detailLayout.RowCount = 5;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        StyleCardTitle(detailTitleLabel, "CHI TIẾT VÉ");
        _detailLabel.Dock = DockStyle.Fill;
        _detailLabel.Font = UiStyleHelper.BodyFont(9.75F);
        _detailLabel.ForeColor = UiStyleHelper.TextDark;
        _detailLabel.Text = "TK000001\r\n\r\nPhim: Avengers: Endgame\r\nSuất chiếu: 19:30 - 22:32\r\nPhòng: Phòng 2\r\nGhế: B5, B6\r\nTổng tiền: 180.000 đ\r\nThanh toán: Tiền mặt";
        _detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        qrCodeLabel.BackColor = Color.White;
        qrCodeLabel.BorderStyle = BorderStyle.FixedSingle;
        qrCodeLabel.Dock = DockStyle.Fill;
        qrCodeLabel.Font = UiStyleHelper.SectionFont(13F);
        qrCodeLabel.Margin = new Padding(76, 0, 76, 0);
        qrCodeLabel.Text = "QR\r\nTK000001";
        qrCodeLabel.TextAlign = ContentAlignment.MiddleCenter;
        _statusLabel.Dock = DockStyle.Fill;
        _statusLabel.Font = UiStyleHelper.SectionFont(10F);
        _statusLabel.ForeColor = UiStyleHelper.Success;
        _statusLabel.Text = "Vé chưa sử dụng";
        _statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        actionPanel.BackColor = Color.White;
        actionPanel.Controls.Add(printButton);
        actionPanel.Controls.Add(cancelTicketButton);
        actionPanel.Controls.Add(viewLogButton);
        actionPanel.Dock = DockStyle.Fill;
        actionPanel.FlowDirection = FlowDirection.LeftToRight;
        actionPanel.WrapContents = false;
        printButton.Size = new Size(86, 36);
        printButton.Text = "In vé";
        cancelTicketButton.Size = new Size(86, 36);
        cancelTicketButton.Text = "Hủy vé";
        viewLogButton.Size = new Size(86, 36);
        viewLogButton.Text = "Xem log";
        //
        // logPanel
        //
        logPanel.BackColor = Color.White;
        logPanel.BorderStyle = BorderStyle.FixedSingle;
        logPanel.Controls.Add(logLayout);
        logPanel.Dock = DockStyle.Fill;
        logPanel.Padding = new Padding(10);
        logLayout.BackColor = Color.White;
        logLayout.ColumnCount = 1;
        logLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        logLayout.Controls.Add(logTitleLabel, 0, 0);
        logLayout.Controls.Add(_logGrid, 0, 1);
        logLayout.Dock = DockStyle.Fill;
        logLayout.RowCount = 2;
        logLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        logLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(logTitleLabel, "NHẬT KÝ GIAO DỊCH");
        ConfigureGrid(_logGrid);
        _logGrid.Dock = DockStyle.Fill;
        _logGrid.AutoGenerateColumns = false;
        _logGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _logGrid.ColumnHeadersHeight = 40;
        _logGrid.RowHeadersVisible = false;
        _logGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        logGridTimeColumn.Name = "Time";
        logGridTimeColumn.DataPropertyName = "Time";
        logGridTimeColumn.HeaderText = "Thời gian";
        logGridTimeColumn.FillWeight = 100F;
        _logGrid.Columns.Add(logGridTimeColumn);
        logGridActionColumn.Name = "Action";
        logGridActionColumn.DataPropertyName = "Action";
        logGridActionColumn.HeaderText = "Hành động";
        logGridActionColumn.FillWeight = 90F;
        _logGrid.Columns.Add(logGridActionColumn);
        logGridContentColumn.Name = "Content";
        logGridContentColumn.DataPropertyName = "Content";
        logGridContentColumn.HeaderText = "Nội dung";
        logGridContentColumn.FillWeight = 150F;
        _logGrid.Columns.Add(logGridContentColumn);
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
