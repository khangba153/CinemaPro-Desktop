using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class SoldTicketsForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private DateTimePicker fromDatePicker;
    private DateTimePicker toDatePicker;
    private ComboBox movieCombo;
    private ComboBox statusCombo;
    private TextBox searchTextBox;
    private Button searchButton;
    private Button refreshButton;
    private TableLayoutPanel contentLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private DataGridView _grid;
    private TableLayoutPanel rightLayout;
    private Panel detailPanel;
    private TableLayoutPanel detailLayout;
    private Label _detailLabel;
    private Label qrCodeLabel;
    private Label _statusLabel;
    private FlowLayoutPanel actionPanel;
    private Button printButton;
    private Button cancelTicketButton;
    private Button viewLogButton;
    private Panel logPanel;
    private TableLayoutPanel logLayout;
    private DataGridView _logGrid;

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
        filterPanel = new FlowLayoutPanel();
        fromDatePicker = new DateTimePicker();
        toDatePicker = new DateTimePicker();
        movieCombo = new ComboBox();
        statusCombo = new ComboBox();
        searchTextBox = new TextBox();
        searchButton = new Button();
        refreshButton = new Button();
        contentLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        _grid = new DataGridView();
        rightLayout = new TableLayoutPanel();
        detailPanel = new Panel();
        detailLayout = new TableLayoutPanel();
        _detailLabel = new Label();
        qrCodeLabel = new Label();
        _statusLabel = new Label();
        actionPanel = new FlowLayoutPanel();
        printButton = new Button();
        cancelTicketButton = new Button();
        viewLogButton = new Button();
        logPanel = new Panel();
        logLayout = new TableLayoutPanel();
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
        filterPanel.Controls.Add(CreateFilterBlock("Từ ngày", fromDatePicker, 132));
        filterPanel.Controls.Add(CreateFilterBlock("Đến ngày", toDatePicker, 132));
        filterPanel.Controls.Add(CreateFilterBlock("Phim", movieCombo, 170));
        filterPanel.Controls.Add(CreateFilterBlock("Trạng thái vé", statusCombo, 150));
        filterPanel.Controls.Add(CreateFilterBlock("Tìm kiếm", searchTextBox, 210));
        filterPanel.Controls.Add(searchButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        fromDatePicker.Format = DateTimePickerFormat.Short;
        fromDatePicker.Value = DateTime.Today.AddDays(-7);
        toDatePicker.Format = DateTimePickerFormat.Short;
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        movieCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dune: Phần Hai" });
        movieCombo.SelectedIndex = 0;
        statusCombo.Items.AddRange(new object[] { "Tất cả trạng thái", "Chưa sử dụng", "Đã sử dụng", "Đã hủy" });
        statusCombo.SelectedIndex = 0;
        searchTextBox.AutoSize = false;
        searchTextBox.BorderStyle = BorderStyle.FixedSingle;
        searchTextBox.PlaceholderText = "Nhập mã vé hoặc tên phim...";
        searchButton.Margin = new Padding(0, 18, 8, 0);
        searchButton.Size = new Size(112, 36);
        searchButton.Text = "Tìm kiếm";
        refreshButton.Margin = new Padding(0, 18, 0, 0);
        refreshButton.Size = new Size(112, 36);
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
        gridLayout.Controls.Add(CreateCardTitleLabel("Danh sách vé đã bán"), 0, 0);
        gridLayout.Controls.Add(_grid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketId", DataPropertyName = "TicketId", HeaderText = "Mã vé", FillWeight = 92 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 160 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Showtime", DataPropertyName = "Showtime", HeaderText = "Suất chiếu", FillWeight = 110 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 78 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Seats", DataPropertyName = "Seats", HeaderText = "Ghế", FillWeight = 78 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", DataPropertyName = "Quantity", HeaderText = "SL", FillWeight = 42 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", DataPropertyName = "Total", HeaderText = "Tổng tiền", FillWeight = 92 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "PaymentMethod", DataPropertyName = "PaymentMethod", HeaderText = "Thanh toán", FillWeight = 108 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 90 });
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
        detailLayout.Controls.Add(CreateCardTitleLabel("Chi tiết vé"), 0, 0);
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
        logLayout.Controls.Add(CreateCardTitleLabel("Nhật ký giao dịch"), 0, 0);
        logLayout.Controls.Add(_logGrid, 0, 1);
        logLayout.Dock = DockStyle.Fill;
        logLayout.RowCount = 2;
        logLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        logLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(_logGrid);
        _logGrid.Dock = DockStyle.Fill;
        _logGrid.AutoGenerateColumns = false;
        _logGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _logGrid.ColumnHeadersHeight = 40;
        _logGrid.RowHeadersVisible = false;
        _logGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _logGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Time", DataPropertyName = "Time", HeaderText = "Thời gian", FillWeight = 100 });
        _logGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Action", DataPropertyName = "Action", HeaderText = "Hành động", FillWeight = 90 });
        _logGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Content", DataPropertyName = "Content", HeaderText = "Nội dung", FillWeight = 150 });
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

    private static TableLayoutPanel CreateFilterBlock(string label, Control control, int width)
    {
        var block = new TableLayoutPanel
        {
            ColumnCount = 1,
            Height = 58,
            Margin = new Padding(0, 0, 12, 0),
            RowCount = 2,
            Width = width
        };
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        block.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Font = UiStyleHelper.SmallFont(9.25F),
            ForeColor = UiStyleHelper.TextMuted,
            Text = label,
            TextAlign = ContentAlignment.BottomLeft
        }, 0, 0);
        control.Dock = DockStyle.Fill;
        block.Controls.Add(control, 0, 1);
        return block;
    }

    private static Label CreateCardTitleLabel(string text) => new()
    {
        Dock = DockStyle.Fill,
        Font = UiStyleHelper.SectionFont(10F),
        ForeColor = UiStyleHelper.Primary,
        Text = text.ToUpperInvariant(),
        TextAlign = ContentAlignment.MiddleLeft
    };

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
