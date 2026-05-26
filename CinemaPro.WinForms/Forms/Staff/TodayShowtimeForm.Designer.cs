using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class TodayShowtimeForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Label totalShowtimeValueLabel;
    private Label soldTicketValueLabel;
    private Label activeRoomValueLabel;
    private Label waitingShowtimeValueLabel;
    private TableLayoutPanel middleLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private DataGridView _grid;
    private Panel detailPanel;
    private TableLayoutPanel detailLayout;
    private Label _detailLabel;
    private Button sellButton;
    private Button viewSeatButton;
    private Button printButton;
    private Panel timelinePanel;
    private TableLayoutPanel timelineLayout;
    private FlowLayoutPanel _timelinePanel;

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
        statLayout = new TableLayoutPanel();
        totalShowtimeValueLabel = new StatCardLabel { Caption = "Tổng suất chiếu", Note = "Trong ngày hôm nay", AccentColor = UiStyleHelper.Primary };
        soldTicketValueLabel = new StatCardLabel { Caption = "Vé đã bán", Note = "Theo dữ liệu demo", AccentColor = UiStyleHelper.Success };
        activeRoomValueLabel = new StatCardLabel { Caption = "Phòng hoạt động", Note = "Sẵn sàng vận hành", AccentColor = UiStyleHelper.Accent };
        waitingShowtimeValueLabel = new StatCardLabel { Caption = "Suất sắp chiếu", Note = "Cần chuẩn bị phòng", AccentColor = UiStyleHelper.Warning };
        middleLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        _grid = new DataGridView();
        detailPanel = new Panel();
        detailLayout = new TableLayoutPanel();
        _detailLabel = new Label();
        sellButton = new Button();
        viewSeatButton = new Button();
        printButton = new Button();
        timelinePanel = new Panel();
        timelineLayout = new TableLayoutPanel();
        _timelinePanel = new FlowLayoutPanel();
        totalShowtimeValueLabel.Text = "8 suất";
        soldTicketValueLabel.Text = "1.072 vé";
        activeRoomValueLabel.Text = "4 / 5";
        waitingShowtimeValueLabel.Text = "5 suất";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        middleLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        detailPanel.SuspendLayout();
        detailLayout.SuspendLayout();
        timelinePanel.SuspendLayout();
        timelineLayout.SuspendLayout();
        SuspendLayout();
        //
        // TodayShowtimeForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "TodayShowtimeForm";
        Text = "Lịch chiếu hôm nay";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(timelinePanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(totalShowtimeValueLabel, 0, 0);
        statLayout.Controls.Add(soldTicketValueLabel, 1, 0);
        statLayout.Controls.Add(activeRoomValueLabel, 2, 0);
        statLayout.Controls.Add(waitingShowtimeValueLabel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // middleLayout
        //
        middleLayout.BackColor = UiStyleHelper.ContentBackground;
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        middleLayout.Controls.Add(gridPanel, 0, 0);
        middleLayout.Controls.Add(detailPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Padding = new Padding(0, 0, 0, 10);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // gridPanel
        //
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(gridLayout);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Margin = new Padding(0, 0, 12, 0);
        gridPanel.Padding = new Padding(10);
        gridLayout.BackColor = Color.White;
        gridLayout.ColumnCount = 1;
        gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        gridLayout.Controls.Add(CreateCardTitleLabel("Danh sách suất chiếu hôm nay"), 0, 0);
        gridLayout.Controls.Add(_grid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(_grid);
        _grid.Dock = DockStyle.Fill;
        _grid.AutoGenerateColumns = false;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeight = 40;
        _grid.RowHeadersVisible = false;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 170 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Start", DataPropertyName = "Start", HeaderText = "Bắt đầu", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Format", DataPropertyName = "Format", HeaderText = "Định dạng", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", DataPropertyName = "Price", HeaderText = "Giá vé", FillWeight = 90 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sold", DataPropertyName = "Sold", HeaderText = "Đã bán", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalSeats", DataPropertyName = "TotalSeats", HeaderText = "Tổng ghế", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Occupancy", DataPropertyName = "Occupancy", HeaderText = "Lấp đầy", FillWeight = 80 });
        _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 100 });
        //
        // detailPanel
        //
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailLayout);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Padding = new Padding(16);
        detailLayout.BackColor = Color.White;
        detailLayout.ColumnCount = 1;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(CreateCardTitleLabel("Chi tiết suất chiếu"), 0, 0);
        detailLayout.Controls.Add(_detailLabel, 0, 1);
        detailLayout.Controls.Add(sellButton, 0, 2);
        detailLayout.Controls.Add(viewSeatButton, 0, 3);
        detailLayout.Controls.Add(printButton, 0, 4);
        detailLayout.Dock = DockStyle.Fill;
        detailLayout.RowCount = 5;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        _detailLabel.Dock = DockStyle.Fill;
        _detailLabel.Font = UiStyleHelper.BodyFont(10F);
        _detailLabel.ForeColor = UiStyleHelper.TextDark;
        _detailLabel.Text = "Avengers: Endgame\r\n\r\nPhòng chiếu: Phòng 2\r\nGiờ chiếu: 19:30 - 22:32\r\nĐịnh dạng: 2D\r\nGiá vé: 90.000 đ\r\nTrạng thái: Đang mở bán";
        _detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        sellButton.Dock = DockStyle.Fill;
        sellButton.Margin = new Padding(0, 0, 0, 8);
        sellButton.Text = "Mở bán vé";
        viewSeatButton.Dock = DockStyle.Fill;
        viewSeatButton.Margin = new Padding(0, 0, 0, 8);
        viewSeatButton.Text = "Xem sơ đồ ghế";
        printButton.Dock = DockStyle.Fill;
        printButton.Margin = Padding.Empty;
        printButton.Text = "In danh sách";
        //
        // timelinePanel
        //
        timelinePanel.BackColor = Color.White;
        timelinePanel.BorderStyle = BorderStyle.FixedSingle;
        timelinePanel.Controls.Add(timelineLayout);
        timelinePanel.Dock = DockStyle.Fill;
        timelinePanel.Padding = new Padding(12);
        timelineLayout.BackColor = Color.White;
        timelineLayout.ColumnCount = 1;
        timelineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        timelineLayout.Controls.Add(CreateCardTitleLabel("Timeline theo phòng chiếu"), 0, 0);
        timelineLayout.Controls.Add(_timelinePanel, 0, 1);
        timelineLayout.Dock = DockStyle.Fill;
        timelineLayout.RowCount = 2;
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _timelinePanel.BackColor = Color.White;
        _timelinePanel.Dock = DockStyle.Fill;
        _timelinePanel.FlowDirection = FlowDirection.TopDown;
        _timelinePanel.WrapContents = false;
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        detailPanel.ResumeLayout(false);
        detailLayout.ResumeLayout(false);
        timelinePanel.ResumeLayout(false);
        timelineLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static Panel CreateStatPanel(string label, Label valueLabel, string note, Color accent)
    {
        var panel = new Panel { BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Dock = DockStyle.Fill, Margin = new Padding(0, 0, 12, 0), Padding = new Padding(18, 14, 18, 14) };
        var layout = new TableLayoutPanel { BackColor = Color.White, ColumnCount = 1, Dock = DockStyle.Fill, RowCount = 3 };
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        layout.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.5F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        valueLabel.Dock = DockStyle.Fill;
        valueLabel.Font = UiStyleHelper.TitleFont(17F);
        valueLabel.ForeColor = accent;
        valueLabel.TextAlign = ContentAlignment.MiddleLeft;
        layout.Controls.Add(valueLabel, 0, 1);
        layout.Controls.Add(new Label { Dock = DockStyle.Fill, Text = note, Font = UiStyleHelper.SmallFont(8.75F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.TopLeft }, 0, 2);
        panel.Controls.Add(layout);
        return panel;
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
