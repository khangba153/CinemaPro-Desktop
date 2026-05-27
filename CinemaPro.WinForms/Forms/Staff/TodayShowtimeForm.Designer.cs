using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class TodayShowtimeForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Panel totalShowtimePanel;
    private Label totalShowtimeTitleLabel;
    private Label totalShowtimeValueLabel;
    private Label totalShowtimeNoteLabel;
    private Panel soldTicketPanel;
    private Label soldTicketTitleLabel;
    private Label soldTicketValueLabel;
    private Label soldTicketNoteLabel;
    private Panel activeRoomPanel;
    private Label activeRoomTitleLabel;
    private Label activeRoomValueLabel;
    private Label activeRoomNoteLabel;
    private Panel waitingShowtimePanel;
    private Label waitingShowtimeTitleLabel;
    private Label waitingShowtimeValueLabel;
    private Label waitingShowtimeNoteLabel;
    private TableLayoutPanel middleLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private Label gridTitleLabel;
    private DataGridView _grid;
    private Panel detailPanel;
    private TableLayoutPanel detailLayout;
    private Label detailTitleLabel;
    private Label _detailLabel;
    private Button sellButton;
    private Button viewSeatButton;
    private Button printButton;
    private Panel timelinePanel;
    private TableLayoutPanel timelineLayout;
    private Label timelineTitleLabel;
    private FlowLayoutPanel _timelinePanel;
    private Label todayTimeline1Label;
    private Label todayTimeline2Label;
    private Label todayTimeline3Label;
    private Label todayTimeline4Label;
    private Label todayTimeline5Label;
    private DataGridViewTextBoxColumn todayGridMovieColumn;
    private DataGridViewTextBoxColumn todayGridRoomColumn;
    private DataGridViewTextBoxColumn todayGridStartColumn;
    private DataGridViewTextBoxColumn todayGridFormatColumn;
    private DataGridViewTextBoxColumn todayGridPriceColumn;
    private DataGridViewTextBoxColumn todayGridSoldColumn;
    private DataGridViewTextBoxColumn todayGridTotalSeatsColumn;
    private DataGridViewTextBoxColumn todayGridOccupancyColumn;
    private DataGridViewTextBoxColumn todayGridStatusColumn;

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
        statLayout = new TableLayoutPanel();
        totalShowtimePanel = new Panel();
        totalShowtimeTitleLabel = new Label();
        totalShowtimeValueLabel = new Label();
        totalShowtimeNoteLabel = new Label();
        soldTicketPanel = new Panel();
        soldTicketTitleLabel = new Label();
        soldTicketValueLabel = new Label();
        soldTicketNoteLabel = new Label();
        activeRoomPanel = new Panel();
        activeRoomTitleLabel = new Label();
        activeRoomValueLabel = new Label();
        activeRoomNoteLabel = new Label();
        waitingShowtimePanel = new Panel();
        waitingShowtimeTitleLabel = new Label();
        waitingShowtimeValueLabel = new Label();
        waitingShowtimeNoteLabel = new Label();
        middleLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        gridTitleLabel = new Label();
        _grid = new DataGridView();
        detailPanel = new Panel();
        detailLayout = new TableLayoutPanel();
        detailTitleLabel = new Label();
        _detailLabel = new Label();
        sellButton = new Button();
        viewSeatButton = new Button();
        printButton = new Button();
        timelinePanel = new Panel();
        timelineLayout = new TableLayoutPanel();
        timelineTitleLabel = new Label();
        _timelinePanel = new FlowLayoutPanel();
        todayTimeline1Label = new Label();
        todayTimeline2Label = new Label();
        todayTimeline3Label = new Label();
        todayTimeline4Label = new Label();
        todayTimeline5Label = new Label();
        todayGridMovieColumn = new DataGridViewTextBoxColumn();
        todayGridRoomColumn = new DataGridViewTextBoxColumn();
        todayGridStartColumn = new DataGridViewTextBoxColumn();
        todayGridFormatColumn = new DataGridViewTextBoxColumn();
        todayGridPriceColumn = new DataGridViewTextBoxColumn();
        todayGridSoldColumn = new DataGridViewTextBoxColumn();
        todayGridTotalSeatsColumn = new DataGridViewTextBoxColumn();
        todayGridOccupancyColumn = new DataGridViewTextBoxColumn();
        todayGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        totalShowtimePanel.SuspendLayout();
        soldTicketPanel.SuspendLayout();
        activeRoomPanel.SuspendLayout();
        waitingShowtimePanel.SuspendLayout();
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
        // rootLayout
        //
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(timelinePanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
        rootLayout.Size = new Size(1100, 620);
        rootLayout.TabIndex = 0;
        //
        // statLayout
        //
        statLayout.BackColor = Color.FromArgb(245, 248, 252);
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(totalShowtimePanel, 0, 0);
        statLayout.Controls.Add(soldTicketPanel, 1, 0);
        statLayout.Controls.Add(activeRoomPanel, 2, 0);
        statLayout.Controls.Add(waitingShowtimePanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Location = new Point(3, 4);
        statLayout.Margin = new Padding(3, 4, 3, 4);
        statLayout.Name = "statLayout";
        statLayout.Padding = new Padding(0, 0, 0, 13);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        statLayout.Size = new Size(1251, 131);
        statLayout.TabIndex = 0;
        //
        // totalShowtimeValueLabel
        //
        totalShowtimeValueLabel.BackColor = Color.White;
        totalShowtimeValueLabel.Dock = DockStyle.Fill;
        totalShowtimeValueLabel.Location = new Point(0, 0);
        totalShowtimeValueLabel.Margin = new Padding(0, 0, 14, 0);
        totalShowtimeValueLabel.Name = "totalShowtimeValueLabel";
        totalShowtimeValueLabel.Padding = new Padding(21, 16, 21, 16);
        totalShowtimeValueLabel.Size = new Size(298, 118);
        totalShowtimeValueLabel.TabIndex = 0;
        totalShowtimeValueLabel.Text = "8 suất";
        //
        // soldTicketValueLabel
        //
        soldTicketValueLabel.BackColor = Color.White;
        soldTicketValueLabel.Dock = DockStyle.Fill;
        soldTicketValueLabel.Location = new Point(312, 0);
        soldTicketValueLabel.Margin = new Padding(0, 0, 14, 0);
        soldTicketValueLabel.Name = "soldTicketValueLabel";
        soldTicketValueLabel.Padding = new Padding(21, 16, 21, 16);
        soldTicketValueLabel.Size = new Size(298, 118);
        soldTicketValueLabel.TabIndex = 1;
        soldTicketValueLabel.Text = "1.072 vé";
        //
        // activeRoomValueLabel
        //
        activeRoomValueLabel.BackColor = Color.White;
        activeRoomValueLabel.Dock = DockStyle.Fill;
        activeRoomValueLabel.Location = new Point(624, 0);
        activeRoomValueLabel.Margin = new Padding(0, 0, 14, 0);
        activeRoomValueLabel.Name = "activeRoomValueLabel";
        activeRoomValueLabel.Padding = new Padding(21, 16, 21, 16);
        activeRoomValueLabel.Size = new Size(298, 118);
        activeRoomValueLabel.TabIndex = 2;
        activeRoomValueLabel.Text = "4 / 5";
        //
        // waitingShowtimeValueLabel
        //
        waitingShowtimeValueLabel.BackColor = Color.White;
        waitingShowtimeValueLabel.Dock = DockStyle.Fill;
        waitingShowtimeValueLabel.Location = new Point(936, 0);
        waitingShowtimeValueLabel.Margin = new Padding(0, 0, 14, 0);
        waitingShowtimeValueLabel.Name = "waitingShowtimeValueLabel";
        waitingShowtimeValueLabel.Padding = new Padding(21, 16, 21, 16);
        waitingShowtimeValueLabel.Size = new Size(301, 118);
        waitingShowtimeValueLabel.TabIndex = 3;
        waitingShowtimeValueLabel.Text = "5 suất";
        waitingShowtimeValueLabel.Click += waitingShowtimeValueLabel_Click;
        //
        // totalShowtimePanel
        //
        totalShowtimePanel.BackColor = Color.White;
        totalShowtimePanel.BorderStyle = BorderStyle.FixedSingle;
        totalShowtimePanel.Controls.Add(totalShowtimeNoteLabel);
        totalShowtimePanel.Controls.Add(totalShowtimeValueLabel);
        totalShowtimePanel.Controls.Add(totalShowtimeTitleLabel);
        totalShowtimePanel.Dock = DockStyle.Fill;
        totalShowtimePanel.Margin = new Padding(0, 0, 12, 0);
        totalShowtimePanel.Padding = new Padding(16, 12, 16, 12);
        totalShowtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalShowtimeTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        totalShowtimeTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        totalShowtimeTitleLabel.Location = new Point(16, 12);
        totalShowtimeTitleLabel.Size = new Size(210, 22);
        totalShowtimeTitleLabel.Text = "Tổng suất chiếu";
        totalShowtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalShowtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalShowtimeValueLabel.Font = UiStyleHelper.TitleFont(17F);
        totalShowtimeValueLabel.ForeColor = UiStyleHelper.Primary;
        totalShowtimeValueLabel.Location = new Point(16, 36);
        totalShowtimeValueLabel.Size = new Size(210, 32);
        totalShowtimeValueLabel.Text = "8 suất";
        totalShowtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalShowtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalShowtimeNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        totalShowtimeNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        totalShowtimeNoteLabel.Location = new Point(16, 68);
        totalShowtimeNoteLabel.Size = new Size(210, 22);
        totalShowtimeNoteLabel.Text = "Trong ngày hôm nay";
        totalShowtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // soldTicketPanel
        //
        soldTicketPanel.BackColor = Color.White;
        soldTicketPanel.BorderStyle = BorderStyle.FixedSingle;
        soldTicketPanel.Controls.Add(soldTicketNoteLabel);
        soldTicketPanel.Controls.Add(soldTicketValueLabel);
        soldTicketPanel.Controls.Add(soldTicketTitleLabel);
        soldTicketPanel.Dock = DockStyle.Fill;
        soldTicketPanel.Margin = new Padding(0, 0, 12, 0);
        soldTicketPanel.Padding = new Padding(16, 12, 16, 12);
        soldTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        soldTicketTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        soldTicketTitleLabel.Location = new Point(16, 12);
        soldTicketTitleLabel.Size = new Size(210, 22);
        soldTicketTitleLabel.Text = "Vé đã bán";
        soldTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        soldTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketValueLabel.Font = UiStyleHelper.TitleFont(17F);
        soldTicketValueLabel.ForeColor = UiStyleHelper.Success;
        soldTicketValueLabel.Location = new Point(16, 36);
        soldTicketValueLabel.Size = new Size(210, 32);
        soldTicketValueLabel.Text = "1.072 vé";
        soldTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        soldTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        soldTicketNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        soldTicketNoteLabel.Location = new Point(16, 68);
        soldTicketNoteLabel.Size = new Size(210, 22);
        soldTicketNoteLabel.Text = "Theo dữ liệu demo";
        soldTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // activeRoomPanel
        //
        activeRoomPanel.BackColor = Color.White;
        activeRoomPanel.BorderStyle = BorderStyle.FixedSingle;
        activeRoomPanel.Controls.Add(activeRoomNoteLabel);
        activeRoomPanel.Controls.Add(activeRoomValueLabel);
        activeRoomPanel.Controls.Add(activeRoomTitleLabel);
        activeRoomPanel.Dock = DockStyle.Fill;
        activeRoomPanel.Margin = new Padding(0, 0, 12, 0);
        activeRoomPanel.Padding = new Padding(16, 12, 16, 12);
        activeRoomTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        activeRoomTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        activeRoomTitleLabel.Location = new Point(16, 12);
        activeRoomTitleLabel.Size = new Size(210, 22);
        activeRoomTitleLabel.Text = "Phòng hoạt động";
        activeRoomTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        activeRoomValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomValueLabel.Font = UiStyleHelper.TitleFont(17F);
        activeRoomValueLabel.ForeColor = UiStyleHelper.Accent;
        activeRoomValueLabel.Location = new Point(16, 36);
        activeRoomValueLabel.Size = new Size(210, 32);
        activeRoomValueLabel.Text = "4 / 5";
        activeRoomValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        activeRoomNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        activeRoomNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        activeRoomNoteLabel.Location = new Point(16, 68);
        activeRoomNoteLabel.Size = new Size(210, 22);
        activeRoomNoteLabel.Text = "Sẵn sàng vận hành";
        activeRoomNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // waitingShowtimePanel
        //
        waitingShowtimePanel.BackColor = Color.White;
        waitingShowtimePanel.BorderStyle = BorderStyle.FixedSingle;
        waitingShowtimePanel.Controls.Add(waitingShowtimeNoteLabel);
        waitingShowtimePanel.Controls.Add(waitingShowtimeValueLabel);
        waitingShowtimePanel.Controls.Add(waitingShowtimeTitleLabel);
        waitingShowtimePanel.Dock = DockStyle.Fill;
        waitingShowtimePanel.Margin = new Padding(0);
        waitingShowtimePanel.Padding = new Padding(16, 12, 16, 12);
        waitingShowtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingShowtimeTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        waitingShowtimeTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        waitingShowtimeTitleLabel.Location = new Point(16, 12);
        waitingShowtimeTitleLabel.Size = new Size(210, 22);
        waitingShowtimeTitleLabel.Text = "Suất sắp chiếu";
        waitingShowtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        waitingShowtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingShowtimeValueLabel.Font = UiStyleHelper.TitleFont(17F);
        waitingShowtimeValueLabel.ForeColor = UiStyleHelper.Warning;
        waitingShowtimeValueLabel.Location = new Point(16, 36);
        waitingShowtimeValueLabel.Size = new Size(210, 32);
        waitingShowtimeValueLabel.Text = "5 suất";
        waitingShowtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        waitingShowtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingShowtimeNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        waitingShowtimeNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        waitingShowtimeNoteLabel.Location = new Point(16, 68);
        waitingShowtimeNoteLabel.Size = new Size(210, 22);
        waitingShowtimeNoteLabel.Text = "Cần chuẩn bị phòng";
        waitingShowtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // middleLayout
        //
        middleLayout.BackColor = Color.FromArgb(245, 248, 252);
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        middleLayout.Controls.Add(gridPanel, 0, 0);
        middleLayout.Controls.Add(detailPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Location = new Point(3, 143);
        middleLayout.Margin = new Padding(3, 4, 3, 4);
        middleLayout.Name = "middleLayout";
        middleLayout.Padding = new Padding(0, 0, 0, 13);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        middleLayout.Size = new Size(1251, 427);
        middleLayout.TabIndex = 1;
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
        gridPanel.Size = new Size(911, 414);
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
        gridLayout.Size = new Size(887, 386);
        gridLayout.TabIndex = 0;
        //
        // gridTitleLabel
        //
        gridTitleLabel.Location = new Point(3, 0);
        gridTitleLabel.Name = "gridTitleLabel";
        gridTitleLabel.Size = new Size(114, 31);
        gridTitleLabel.TabIndex = 0;
        StyleCardTitle(gridTitleLabel, "DANH SÁCH SUẤT CHIẾU HÔM NAY");
        //
        // _grid
        //
        ConfigureGrid(_grid);
        _grid.AutoGenerateColumns = false;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeight = 40;
        _grid.Dock = DockStyle.Fill;
        _grid.Location = new Point(3, 44);
        _grid.Margin = new Padding(3, 4, 3, 4);
        _grid.Name = "_grid";
        _grid.RowHeadersVisible = false;
        _grid.RowHeadersWidth = 51;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _grid.Size = new Size(881, 338);
        _grid.TabIndex = 1;
        todayGridMovieColumn.Name = "Movie";
        todayGridMovieColumn.DataPropertyName = "Movie";
        todayGridMovieColumn.HeaderText = "Phim";
        todayGridMovieColumn.FillWeight = 180F;
        _grid.Columns.Add(todayGridMovieColumn);
        todayGridRoomColumn.Name = "Room";
        todayGridRoomColumn.DataPropertyName = "Room";
        todayGridRoomColumn.HeaderText = "Phòng";
        todayGridRoomColumn.FillWeight = 90F;
        _grid.Columns.Add(todayGridRoomColumn);
        todayGridStartColumn.Name = "Start";
        todayGridStartColumn.DataPropertyName = "Start";
        todayGridStartColumn.HeaderText = "Giờ";
        todayGridStartColumn.FillWeight = 72F;
        _grid.Columns.Add(todayGridStartColumn);
        todayGridFormatColumn.Name = "Format";
        todayGridFormatColumn.DataPropertyName = "Format";
        todayGridFormatColumn.HeaderText = "Định dạng";
        todayGridFormatColumn.FillWeight = 82F;
        _grid.Columns.Add(todayGridFormatColumn);
        todayGridPriceColumn.Name = "Price";
        todayGridPriceColumn.DataPropertyName = "Price";
        todayGridPriceColumn.HeaderText = "Giá vé";
        todayGridPriceColumn.FillWeight = 92F;
        _grid.Columns.Add(todayGridPriceColumn);
        todayGridSoldColumn.Name = "Sold";
        todayGridSoldColumn.DataPropertyName = "Sold";
        todayGridSoldColumn.HeaderText = "Đã bán";
        todayGridSoldColumn.FillWeight = 74F;
        _grid.Columns.Add(todayGridSoldColumn);
        todayGridTotalSeatsColumn.Name = "TotalSeats";
        todayGridTotalSeatsColumn.DataPropertyName = "TotalSeats";
        todayGridTotalSeatsColumn.HeaderText = "Sức chứa";
        todayGridTotalSeatsColumn.FillWeight = 78F;
        _grid.Columns.Add(todayGridTotalSeatsColumn);
        todayGridOccupancyColumn.Name = "Occupancy";
        todayGridOccupancyColumn.DataPropertyName = "Occupancy";
        todayGridOccupancyColumn.HeaderText = "Lấp đầy";
        todayGridOccupancyColumn.FillWeight = 78F;
        _grid.Columns.Add(todayGridOccupancyColumn);
        todayGridStatusColumn.Name = "Status";
        todayGridStatusColumn.DataPropertyName = "Status";
        todayGridStatusColumn.HeaderText = "Trạng thái";
        todayGridStatusColumn.FillWeight = 106F;
        _grid.Columns.Add(todayGridStatusColumn);
        //
        // detailPanel
        //
        detailPanel.BackColor = Color.White;
        detailPanel.BorderStyle = BorderStyle.FixedSingle;
        detailPanel.Controls.Add(detailLayout);
        detailPanel.Dock = DockStyle.Fill;
        detailPanel.Location = new Point(928, 4);
        detailPanel.Margin = new Padding(3, 4, 3, 4);
        detailPanel.Name = "detailPanel";
        detailPanel.Padding = new Padding(18, 21, 18, 21);
        detailPanel.Size = new Size(320, 406);
        detailPanel.TabIndex = 1;
        //
        // detailLayout
        //
        detailLayout.BackColor = Color.White;
        detailLayout.ColumnCount = 1;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(detailTitleLabel, 0, 0);
        detailLayout.Controls.Add(_detailLabel, 0, 1);
        detailLayout.Controls.Add(sellButton, 0, 2);
        detailLayout.Controls.Add(viewSeatButton, 0, 3);
        detailLayout.Controls.Add(printButton, 0, 4);
        detailLayout.Dock = DockStyle.Fill;
        detailLayout.Location = new Point(18, 21);
        detailLayout.Margin = new Padding(3, 4, 3, 4);
        detailLayout.Name = "detailLayout";
        detailLayout.RowCount = 5;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        detailLayout.Size = new Size(282, 362);
        detailLayout.TabIndex = 0;
        //
        // detailTitleLabel
        //
        detailTitleLabel.Location = new Point(3, 0);
        detailTitleLabel.Name = "detailTitleLabel";
        detailTitleLabel.Size = new Size(7, 31);
        detailTitleLabel.TabIndex = 0;
        StyleCardTitle(detailTitleLabel, "CHI TIẾT SUẤT CHIẾU");
        //
        // _detailLabel
        //
        _detailLabel.Dock = DockStyle.Fill;
        _detailLabel.Font = new Font("Segoe UI", 10F);
        _detailLabel.ForeColor = Color.FromArgb(17, 27, 63);
        _detailLabel.Location = new Point(3, 40);
        _detailLabel.Name = "_detailLabel";
        _detailLabel.Size = new Size(276, 130);
        _detailLabel.TabIndex = 1;
        _detailLabel.Text = "Avengers: Endgame\r\n\r\nPhòng chiếu: Phòng 2\r\nGiờ chiếu: 19:30 - 22:32\r\nĐịnh dạng: 2D\r\nGiá vé: 90.000 đ\r\nTrạng thái: Đang mở bán";
        _detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // sellButton
        //
        sellButton.Dock = DockStyle.Fill;
        sellButton.Location = new Point(0, 170);
        sellButton.Margin = new Padding(0, 0, 0, 11);
        sellButton.Name = "sellButton";
        sellButton.Size = new Size(282, 53);
        sellButton.TabIndex = 2;
        sellButton.Text = "Mở bán vé";
        //
        // viewSeatButton
        //
        viewSeatButton.Dock = DockStyle.Fill;
        viewSeatButton.Location = new Point(0, 234);
        viewSeatButton.Margin = new Padding(0, 0, 0, 11);
        viewSeatButton.Name = "viewSeatButton";
        viewSeatButton.Size = new Size(282, 53);
        viewSeatButton.TabIndex = 3;
        viewSeatButton.Text = "Xem sơ đồ ghế";
        //
        // printButton
        //
        printButton.Dock = DockStyle.Fill;
        printButton.Location = new Point(0, 298);
        printButton.Margin = new Padding(0);
        printButton.Name = "printButton";
        printButton.Size = new Size(282, 64);
        printButton.TabIndex = 4;
        printButton.Text = "In danh sách";
        //
        // timelinePanel
        //
        timelinePanel.BackColor = Color.White;
        timelinePanel.BorderStyle = BorderStyle.FixedSingle;
        timelinePanel.Controls.Add(timelineLayout);
        timelinePanel.Dock = DockStyle.Fill;
        timelinePanel.Location = new Point(3, 578);
        timelinePanel.Margin = new Padding(3, 4, 3, 4);
        timelinePanel.Name = "timelinePanel";
        timelinePanel.Padding = new Padding(14, 16, 14, 16);
        timelinePanel.Size = new Size(1251, 245);
        timelinePanel.TabIndex = 2;
        //
        // timelineLayout
        //
        timelineLayout.BackColor = Color.White;
        timelineLayout.ColumnCount = 1;
        timelineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        timelineLayout.Controls.Add(timelineTitleLabel, 0, 0);
        timelineLayout.Controls.Add(_timelinePanel, 0, 1);
        timelineLayout.Dock = DockStyle.Fill;
        timelineLayout.Location = new Point(14, 16);
        timelineLayout.Margin = new Padding(3, 4, 3, 4);
        timelineLayout.Name = "timelineLayout";
        timelineLayout.RowCount = 2;
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        timelineLayout.Size = new Size(1221, 211);
        timelineLayout.TabIndex = 0;
        //
        // timelineTitleLabel
        //
        timelineTitleLabel.Location = new Point(3, 0);
        timelineTitleLabel.Name = "timelineTitleLabel";
        timelineTitleLabel.Size = new Size(114, 31);
        timelineTitleLabel.TabIndex = 0;
        StyleCardTitle(timelineTitleLabel, "TIMELINE THEO PHÒNG");
        //
        // _timelinePanel
        //
        _timelinePanel.BackColor = Color.White;
        _timelinePanel.Dock = DockStyle.Fill;
        _timelinePanel.FlowDirection = FlowDirection.TopDown;
        _timelinePanel.Location = new Point(3, 44);
        _timelinePanel.Margin = new Padding(3, 4, 3, 4);
        _timelinePanel.Name = "_timelinePanel";
        _timelinePanel.Size = new Size(1215, 163);
        _timelinePanel.TabIndex = 1;
        _timelinePanel.WrapContents = false;
        _timelinePanel.Controls.Add(todayTimeline1Label);
        StyleTimelineLabel(todayTimeline1Label, "Phòng 1     19:00 - 21:00     Suất chiếu demo");
        _timelinePanel.Controls.Add(todayTimeline2Label);
        StyleTimelineLabel(todayTimeline2Label, "Phòng 2     19:00 - 21:00     Suất chiếu demo");
        _timelinePanel.Controls.Add(todayTimeline3Label);
        StyleTimelineLabel(todayTimeline3Label, "Phòng 3     19:00 - 21:00     Suất chiếu demo");
        _timelinePanel.Controls.Add(todayTimeline4Label);
        StyleTimelineLabel(todayTimeline4Label, "Phòng 4     19:00 - 21:00     Suất chiếu demo");
        _timelinePanel.Controls.Add(todayTimeline5Label);
        StyleTimelineLabel(todayTimeline5Label, "Phòng 5     19:00 - 21:00     Suất chiếu demo");
        //
        // TodayShowtimeForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "TodayShowtimeForm";
        Text = "Lịch chiếu hôm nay";
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        totalShowtimePanel.ResumeLayout(false);
        soldTicketPanel.ResumeLayout(false);
        activeRoomPanel.ResumeLayout(false);
        waitingShowtimePanel.ResumeLayout(false);
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
    private static void StyleTimelineLabel(Label label, string text)
    {
        label.BackColor = ColorTranslator.FromHtml("#EAF3FF");
        label.Font = UiStyleHelper.SectionFont(9.25F);
        label.ForeColor = UiStyleHelper.Primary;
        label.Height = 34;
        label.Margin = new Padding(0, 4, 0, 4);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Width = 980;
    }
}
