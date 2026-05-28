using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class AdminDashboardForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Panel movieStatPanel;
    private Label movieTitleLabel;
    private Label movieValueLabel;
    private Label movieNoteLabel;
    private Panel roomStatPanel;
    private Label roomTitleLabel;
    private Label roomValueLabel;
    private Label roomNoteLabel;
    private Panel showtimeStatPanel;
    private Label showtimeStatTitleLabel;
    private Label showtimeValueLabel;
    private Label showtimeNoteLabel;
    private Panel ticketStatPanel;
    private Label ticketTitleLabel;
    private Label ticketValueLabel;
    private Label ticketNoteLabel;
    private Panel revenueStatPanel;
    private Label revenueStatTitleLabel;
    private Label revenueValueLabel;
    private Label revenueNoteLabel;
    private TableLayoutPanel middleLayout;
    private Panel showtimePanel;
    private TableLayoutPanel showtimeLayout;
    private Label showtimeTitleLabel;
    private DataGridView showtimeGrid;
    private Panel operationPanel;
    private TableLayoutPanel operationLayout;
    private Label operationTitleLabel;
    private Panel unusedPanel;
    private Label unusedTitleLabel;
    private Label unusedValueLabel;
    private Panel usedPanel;
    private Label usedTitleLabel;
    private Label usedValueLabel;
    private Panel canceledPanel;
    private Label canceledTitleLabel;
    private Label canceledValueLabel;
    private Panel maintenancePanel;
    private Label maintenanceTitleLabel;
    private Label maintenanceValueLabel;
    private TableLayoutPanel bottomLayout;
    private Panel revenuePanel;
    private TableLayoutPanel revenueLayout;
    private Label revenueTitleLabel;
    private DataGridView revenueGrid;
    private Panel recentTicketPanel;
    private TableLayoutPanel recentTicketLayout;
    private Label recentTicketTitleLabel;
    private DataGridView recentTicketGrid;

    private DataGridViewTextBoxColumn showtimeGridMovieColumn;
    private DataGridViewTextBoxColumn showtimeGridRoomColumn;
    private DataGridViewTextBoxColumn showtimeGridStartColumn;
    private DataGridViewTextBoxColumn showtimeGridEndColumn;
    private DataGridViewTextBoxColumn showtimeGridPriceColumn;
    private DataGridViewTextBoxColumn showtimeGridStatusColumn;
    private DataGridViewTextBoxColumn revenueGridMovieColumn;
    private DataGridViewTextBoxColumn revenueGridTicketsSoldColumn;
    private DataGridViewTextBoxColumn revenueGridRevenueColumn;
    private DataGridViewTextBoxColumn recentTicketGridTicketIdColumn;
    private DataGridViewTextBoxColumn recentTicketGridMovieColumn;
    private DataGridViewTextBoxColumn recentTicketGridSeatsColumn;
    private DataGridViewTextBoxColumn recentTicketGridTotalColumn;
    private DataGridViewTextBoxColumn recentTicketGridStatusColumn;
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
        showtimeGridMovieColumn = new DataGridViewTextBoxColumn();
        showtimeGridRoomColumn = new DataGridViewTextBoxColumn();
        showtimeGridStartColumn = new DataGridViewTextBoxColumn();
        showtimeGridEndColumn = new DataGridViewTextBoxColumn();
        showtimeGridPriceColumn = new DataGridViewTextBoxColumn();
        showtimeGridStatusColumn = new DataGridViewTextBoxColumn();
        revenueGridMovieColumn = new DataGridViewTextBoxColumn();
        revenueGridTicketsSoldColumn = new DataGridViewTextBoxColumn();
        revenueGridRevenueColumn = new DataGridViewTextBoxColumn();
        recentTicketGridTicketIdColumn = new DataGridViewTextBoxColumn();
        recentTicketGridMovieColumn = new DataGridViewTextBoxColumn();
        recentTicketGridSeatsColumn = new DataGridViewTextBoxColumn();
        recentTicketGridTotalColumn = new DataGridViewTextBoxColumn();
        recentTicketGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        statLayout = new TableLayoutPanel();
        movieStatPanel = new Panel();
        movieTitleLabel = new Label();
        movieValueLabel = new Label();
        movieNoteLabel = new Label();
        roomStatPanel = new Panel();
        roomTitleLabel = new Label();
        roomValueLabel = new Label();
        roomNoteLabel = new Label();
        showtimeStatPanel = new Panel();
        showtimeStatTitleLabel = new Label();
        showtimeValueLabel = new Label();
        showtimeNoteLabel = new Label();
        ticketStatPanel = new Panel();
        ticketTitleLabel = new Label();
        ticketValueLabel = new Label();
        ticketNoteLabel = new Label();
        revenueStatPanel = new Panel();
        revenueStatTitleLabel = new Label();
        revenueValueLabel = new Label();
        revenueNoteLabel = new Label();
        middleLayout = new TableLayoutPanel();
        showtimePanel = new Panel();
        showtimeLayout = new TableLayoutPanel();
        showtimeTitleLabel = new Label();
        showtimeGrid = new DataGridView();
        operationPanel = new Panel();
        operationLayout = new TableLayoutPanel();
        operationTitleLabel = new Label();
        unusedPanel = new Panel();
        unusedTitleLabel = new Label();
        unusedValueLabel = new Label();
        usedPanel = new Panel();
        usedTitleLabel = new Label();
        usedValueLabel = new Label();
        canceledPanel = new Panel();
        canceledTitleLabel = new Label();
        canceledValueLabel = new Label();
        maintenancePanel = new Panel();
        maintenanceTitleLabel = new Label();
        maintenanceValueLabel = new Label();
        bottomLayout = new TableLayoutPanel();
        revenuePanel = new Panel();
        revenueLayout = new TableLayoutPanel();
        revenueTitleLabel = new Label();
        revenueGrid = new DataGridView();
        recentTicketPanel = new Panel();
        recentTicketLayout = new TableLayoutPanel();
        recentTicketTitleLabel = new Label();
        recentTicketGrid = new DataGridView();
        movieValueLabel.Text = "6";
        roomValueLabel.Text = "5";
        showtimeValueLabel.Text = "8";
        ticketValueLabel.Text = "268";
        revenueValueLabel.Text = "23.4 triệu";
        unusedValueLabel.Text = "2";
        usedValueLabel.Text = "1";
        canceledValueLabel.Text = "1";
        maintenanceValueLabel.Text = "1";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        movieStatPanel.SuspendLayout();
        roomStatPanel.SuspendLayout();
        showtimeStatPanel.SuspendLayout();
        ticketStatPanel.SuspendLayout();
        revenueStatPanel.SuspendLayout();
        middleLayout.SuspendLayout();
        showtimePanel.SuspendLayout();
        showtimeLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        operationPanel.SuspendLayout();
        operationLayout.SuspendLayout();
        unusedPanel.SuspendLayout();
        usedPanel.SuspendLayout();
        canceledPanel.SuspendLayout();
        maintenancePanel.SuspendLayout();
        bottomLayout.SuspendLayout();
        revenuePanel.SuspendLayout();
        revenueLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)revenueGrid).BeginInit();
        recentTicketPanel.SuspendLayout();
        recentTicketLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)recentTicketGrid).BeginInit();
        SuspendLayout();
        //
        // AdminDashboardForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "AdminDashboardForm";
        Text = "Dashboard quản trị";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(bottomLayout, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 5;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        statLayout.Controls.Add(movieStatPanel, 0, 0);
        statLayout.Controls.Add(roomStatPanel, 1, 0);
        statLayout.Controls.Add(showtimeStatPanel, 2, 0);
        statLayout.Controls.Add(ticketStatPanel, 3, 0);
        statLayout.Controls.Add(revenueStatPanel, 4, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // movieStatPanel
        //
        movieStatPanel.BackColor = Color.White;
        movieStatPanel.BorderStyle = BorderStyle.FixedSingle;
        movieStatPanel.Controls.Add(movieNoteLabel);
        movieStatPanel.Controls.Add(movieValueLabel);
        movieStatPanel.Controls.Add(movieTitleLabel);
        movieStatPanel.Dock = DockStyle.Fill;
        movieStatPanel.Margin = new Padding(0, 0, 12, 0);
        movieStatPanel.Padding = new Padding(16, 12, 16, 12);
        movieTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        movieTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        movieTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        movieTitleLabel.Location = new Point(16, 12);
        movieTitleLabel.Size = new Size(170, 22);
        movieTitleLabel.Text = "Tổng phim";
        movieTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        movieValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        movieValueLabel.Font = UiStyleHelper.TitleFont(17F);
        movieValueLabel.ForeColor = UiStyleHelper.Primary;
        movieValueLabel.Location = new Point(16, 36);
        movieValueLabel.Size = new Size(170, 32);
        movieValueLabel.Text = "6";
        movieValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        movieNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        movieNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        movieNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        movieNoteLabel.Location = new Point(16, 68);
        movieNoteLabel.Size = new Size(170, 22);
        movieNoteLabel.Text = "Đang quản lý";
        movieNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // roomStatPanel
        //
        roomStatPanel.BackColor = Color.White;
        roomStatPanel.BorderStyle = BorderStyle.FixedSingle;
        roomStatPanel.Controls.Add(roomNoteLabel);
        roomStatPanel.Controls.Add(roomValueLabel);
        roomStatPanel.Controls.Add(roomTitleLabel);
        roomStatPanel.Dock = DockStyle.Fill;
        roomStatPanel.Margin = new Padding(0, 0, 12, 0);
        roomStatPanel.Padding = new Padding(16, 12, 16, 12);
        roomTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        roomTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        roomTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        roomTitleLabel.Location = new Point(16, 12);
        roomTitleLabel.Size = new Size(170, 22);
        roomTitleLabel.Text = "Tổng phòng chiếu";
        roomTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        roomValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        roomValueLabel.Font = UiStyleHelper.TitleFont(17F);
        roomValueLabel.ForeColor = UiStyleHelper.Success;
        roomValueLabel.Location = new Point(16, 36);
        roomValueLabel.Size = new Size(170, 32);
        roomValueLabel.Text = "5";
        roomValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        roomNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        roomNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        roomNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        roomNoteLabel.Location = new Point(16, 68);
        roomNoteLabel.Size = new Size(170, 22);
        roomNoteLabel.Text = "Phòng vận hành";
        roomNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // showtimeStatPanel
        //
        showtimeStatPanel.BackColor = Color.White;
        showtimeStatPanel.BorderStyle = BorderStyle.FixedSingle;
        showtimeStatPanel.Controls.Add(showtimeNoteLabel);
        showtimeStatPanel.Controls.Add(showtimeValueLabel);
        showtimeStatPanel.Controls.Add(showtimeStatTitleLabel);
        showtimeStatPanel.Dock = DockStyle.Fill;
        showtimeStatPanel.Margin = new Padding(0, 0, 12, 0);
        showtimeStatPanel.Padding = new Padding(16, 12, 16, 12);
        showtimeStatTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeStatTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        showtimeStatTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        showtimeStatTitleLabel.Location = new Point(16, 12);
        showtimeStatTitleLabel.Size = new Size(170, 22);
        showtimeStatTitleLabel.Text = "Suất chiếu hôm nay";
        showtimeStatTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        showtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeValueLabel.Font = UiStyleHelper.TitleFont(17F);
        showtimeValueLabel.ForeColor = UiStyleHelper.Warning;
        showtimeValueLabel.Location = new Point(16, 36);
        showtimeValueLabel.Size = new Size(170, 32);
        showtimeValueLabel.Text = "8";
        showtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        showtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        showtimeNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        showtimeNoteLabel.Location = new Point(16, 68);
        showtimeNoteLabel.Size = new Size(170, 22);
        showtimeNoteLabel.Text = "Theo lịch vận hành";
        showtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // ticketStatPanel
        //
        ticketStatPanel.BackColor = Color.White;
        ticketStatPanel.BorderStyle = BorderStyle.FixedSingle;
        ticketStatPanel.Controls.Add(ticketNoteLabel);
        ticketStatPanel.Controls.Add(ticketValueLabel);
        ticketStatPanel.Controls.Add(ticketTitleLabel);
        ticketStatPanel.Dock = DockStyle.Fill;
        ticketStatPanel.Margin = new Padding(0, 0, 12, 0);
        ticketStatPanel.Padding = new Padding(16, 12, 16, 12);
        ticketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ticketTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        ticketTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        ticketTitleLabel.Location = new Point(16, 12);
        ticketTitleLabel.Size = new Size(170, 22);
        ticketTitleLabel.Text = "Vé đã bán hôm nay";
        ticketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        ticketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ticketValueLabel.Font = UiStyleHelper.TitleFont(17F);
        ticketValueLabel.ForeColor = UiStyleHelper.Accent;
        ticketValueLabel.Location = new Point(16, 36);
        ticketValueLabel.Size = new Size(170, 32);
        ticketValueLabel.Text = "268";
        ticketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        ticketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ticketNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        ticketNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        ticketNoteLabel.Location = new Point(16, 68);
        ticketNoteLabel.Size = new Size(170, 22);
        ticketNoteLabel.Text = "Dữ liệu demo";
        ticketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // revenueStatPanel
        //
        revenueStatPanel.BackColor = Color.White;
        revenueStatPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueStatPanel.Controls.Add(revenueNoteLabel);
        revenueStatPanel.Controls.Add(revenueValueLabel);
        revenueStatPanel.Controls.Add(revenueStatTitleLabel);
        revenueStatPanel.Dock = DockStyle.Fill;
        revenueStatPanel.Margin = new Padding(0);
        revenueStatPanel.Padding = new Padding(16, 12, 16, 12);
        revenueStatTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueStatTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        revenueStatTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueStatTitleLabel.Location = new Point(16, 12);
        revenueStatTitleLabel.Size = new Size(170, 22);
        revenueStatTitleLabel.Text = "Doanh thu hôm nay";
        revenueStatTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueValueLabel.Font = UiStyleHelper.TitleFont(14F);
        revenueValueLabel.ForeColor = UiStyleHelper.Primary;
        revenueValueLabel.Location = new Point(16, 36);
        revenueValueLabel.Size = new Size(170, 32);
        revenueValueLabel.Text = "23.4 triệu";
        revenueValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        revenueNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueNoteLabel.Location = new Point(16, 68);
        revenueNoteLabel.Size = new Size(170, 22);
        revenueNoteLabel.Text = "Tạm tính";
        revenueNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // middleLayout
        //
        middleLayout.BackColor = UiStyleHelper.ContentBackground;
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        middleLayout.Controls.Add(showtimePanel, 0, 0);
        middleLayout.Controls.Add(operationPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Padding = new Padding(0, 0, 0, 10);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // showtimePanel
        //
        showtimePanel.BackColor = Color.White;
        showtimePanel.BorderStyle = BorderStyle.FixedSingle;
        showtimePanel.Controls.Add(showtimeLayout);
        showtimePanel.Dock = DockStyle.Fill;
        showtimePanel.Margin = new Padding(0, 0, 12, 0);
        showtimePanel.Padding = new Padding(10);
        showtimeLayout.BackColor = Color.White;
        showtimeLayout.ColumnCount = 1;
        showtimeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        showtimeLayout.Controls.Add(showtimeTitleLabel, 0, 0);
        showtimeLayout.Controls.Add(showtimeGrid, 0, 1);
        showtimeLayout.Dock = DockStyle.Fill;
        showtimeLayout.RowCount = 2;
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(showtimeTitleLabel, "LỊCH CHIẾU GẦN ĐÂY");
        ConfigureGrid(showtimeGrid);
        showtimeGrid.Dock = DockStyle.Fill;
        showtimeGrid.AutoGenerateColumns = false;
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        showtimeGrid.ColumnHeadersHeight = 40;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGridMovieColumn.Name = "Movie";
        showtimeGridMovieColumn.DataPropertyName = "Movie";
        showtimeGridMovieColumn.HeaderText = "Phim";
        showtimeGridMovieColumn.FillWeight = 170F;
        showtimeGrid.Columns.Add(showtimeGridMovieColumn);
        showtimeGridRoomColumn.Name = "Room";
        showtimeGridRoomColumn.DataPropertyName = "Room";
        showtimeGridRoomColumn.HeaderText = "Phòng";
        showtimeGridRoomColumn.FillWeight = 80F;
        showtimeGrid.Columns.Add(showtimeGridRoomColumn);
        showtimeGridStartColumn.Name = "Start";
        showtimeGridStartColumn.DataPropertyName = "Start";
        showtimeGridStartColumn.HeaderText = "Bắt đầu";
        showtimeGridStartColumn.FillWeight = 80F;
        showtimeGrid.Columns.Add(showtimeGridStartColumn);
        showtimeGridEndColumn.Name = "End";
        showtimeGridEndColumn.DataPropertyName = "End";
        showtimeGridEndColumn.HeaderText = "Kết thúc";
        showtimeGridEndColumn.FillWeight = 80F;
        showtimeGrid.Columns.Add(showtimeGridEndColumn);
        showtimeGridPriceColumn.Name = "Price";
        showtimeGridPriceColumn.DataPropertyName = "Price";
        showtimeGridPriceColumn.HeaderText = "Giá vé";
        showtimeGridPriceColumn.FillWeight = 90F;
        showtimeGrid.Columns.Add(showtimeGridPriceColumn);
        showtimeGridStatusColumn.Name = "Status";
        showtimeGridStatusColumn.DataPropertyName = "Status";
        showtimeGridStatusColumn.HeaderText = "Trạng thái";
        showtimeGridStatusColumn.FillWeight = 95F;
        showtimeGrid.Columns.Add(showtimeGridStatusColumn);
        //
        // operationPanel
        //
        operationPanel.BackColor = Color.White;
        operationPanel.BorderStyle = BorderStyle.FixedSingle;
        operationPanel.Controls.Add(operationLayout);
        operationPanel.Dock = DockStyle.Fill;
        operationPanel.Padding = new Padding(16);
        operationLayout.BackColor = Color.White;
        operationLayout.ColumnCount = 1;
        operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        operationLayout.Controls.Add(operationTitleLabel, 0, 0);
        operationLayout.Controls.Add(unusedPanel, 0, 1);
        operationLayout.Controls.Add(usedPanel, 0, 2);
        operationLayout.Controls.Add(canceledPanel, 0, 3);
        operationLayout.Controls.Add(maintenancePanel, 0, 4);
        operationLayout.Dock = DockStyle.Fill;
        operationLayout.RowCount = 6;
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(operationTitleLabel, "TÌNH TRẠNG VẬN HÀNH");
        StyleStatusPanel(unusedPanel, unusedTitleLabel, unusedValueLabel, "Vé chưa sử dụng", UiStyleHelper.Warning);
        StyleStatusPanel(usedPanel, usedTitleLabel, usedValueLabel, "Vé đã sử dụng", UiStyleHelper.Success);
        StyleStatusPanel(canceledPanel, canceledTitleLabel, canceledValueLabel, "Vé đã hủy", UiStyleHelper.Danger);
        StyleStatusPanel(maintenancePanel, maintenanceTitleLabel, maintenanceValueLabel, "Phòng cần bảo trì", UiStyleHelper.Danger);
        //
        // bottomLayout
        //
        bottomLayout.BackColor = UiStyleHelper.ContentBackground;
        bottomLayout.ColumnCount = 2;
        bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
        bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
        bottomLayout.Controls.Add(revenuePanel, 0, 0);
        bottomLayout.Controls.Add(recentTicketPanel, 1, 0);
        bottomLayout.Dock = DockStyle.Fill;
        bottomLayout.RowCount = 1;
        bottomLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // revenuePanel
        //
        revenuePanel.BackColor = Color.White;
        revenuePanel.BorderStyle = BorderStyle.FixedSingle;
        revenuePanel.Controls.Add(revenueLayout);
        revenuePanel.Dock = DockStyle.Fill;
        revenuePanel.Margin = new Padding(0, 0, 12, 0);
        revenuePanel.Padding = new Padding(10);
        revenueLayout.BackColor = Color.White;
        revenueLayout.ColumnCount = 1;
        revenueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        revenueLayout.Controls.Add(revenueTitleLabel, 0, 0);
        revenueLayout.Controls.Add(revenueGrid, 0, 1);
        revenueLayout.Dock = DockStyle.Fill;
        revenueLayout.RowCount = 2;
        revenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        revenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(revenueTitleLabel, "DOANH THU THEO PHIM");
        ConfigureGrid(revenueGrid);
        revenueGrid.Dock = DockStyle.Fill;
        revenueGrid.AutoGenerateColumns = false;
        revenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        revenueGrid.ColumnHeadersHeight = 40;
        revenueGrid.RowHeadersVisible = false;
        revenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        revenueGridMovieColumn.Name = "Movie";
        revenueGridMovieColumn.DataPropertyName = "Movie";
        revenueGridMovieColumn.HeaderText = "Phim";
        revenueGridMovieColumn.FillWeight = 180F;
        revenueGrid.Columns.Add(revenueGridMovieColumn);
        revenueGridTicketsSoldColumn.Name = "TicketsSold";
        revenueGridTicketsSoldColumn.DataPropertyName = "TicketsSold";
        revenueGridTicketsSoldColumn.HeaderText = "Số vé";
        revenueGridTicketsSoldColumn.FillWeight = 80F;
        revenueGrid.Columns.Add(revenueGridTicketsSoldColumn);
        revenueGridRevenueColumn.Name = "Revenue";
        revenueGridRevenueColumn.DataPropertyName = "Revenue";
        revenueGridRevenueColumn.HeaderText = "Doanh thu";
        revenueGridRevenueColumn.FillWeight = 120F;
        revenueGrid.Columns.Add(revenueGridRevenueColumn);
        //
        // recentTicketPanel
        //
        recentTicketPanel.BackColor = Color.White;
        recentTicketPanel.BorderStyle = BorderStyle.FixedSingle;
        recentTicketPanel.Controls.Add(recentTicketLayout);
        recentTicketPanel.Dock = DockStyle.Fill;
        recentTicketPanel.Padding = new Padding(10);
        recentTicketLayout.BackColor = Color.White;
        recentTicketLayout.ColumnCount = 1;
        recentTicketLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        recentTicketLayout.Controls.Add(recentTicketTitleLabel, 0, 0);
        recentTicketLayout.Controls.Add(recentTicketGrid, 0, 1);
        recentTicketLayout.Dock = DockStyle.Fill;
        recentTicketLayout.RowCount = 2;
        recentTicketLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        recentTicketLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(recentTicketTitleLabel, "VÉ BÁN GẦN ĐÂY");
        ConfigureGrid(recentTicketGrid);
        recentTicketGrid.Dock = DockStyle.Fill;
        recentTicketGrid.AutoGenerateColumns = false;
        recentTicketGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        recentTicketGrid.ColumnHeadersHeight = 40;
        recentTicketGrid.RowHeadersVisible = false;
        recentTicketGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recentTicketGridTicketIdColumn.Name = "TicketId";
        recentTicketGridTicketIdColumn.DataPropertyName = "TicketId";
        recentTicketGridTicketIdColumn.HeaderText = "Mã vé";
        recentTicketGridTicketIdColumn.FillWeight = 90F;
        recentTicketGrid.Columns.Add(recentTicketGridTicketIdColumn);
        recentTicketGridMovieColumn.Name = "Movie";
        recentTicketGridMovieColumn.DataPropertyName = "Movie";
        recentTicketGridMovieColumn.HeaderText = "Phim";
        recentTicketGridMovieColumn.FillWeight = 150F;
        recentTicketGrid.Columns.Add(recentTicketGridMovieColumn);
        recentTicketGridSeatsColumn.Name = "Seats";
        recentTicketGridSeatsColumn.DataPropertyName = "Seats";
        recentTicketGridSeatsColumn.HeaderText = "Ghế";
        recentTicketGridSeatsColumn.FillWeight = 70F;
        recentTicketGrid.Columns.Add(recentTicketGridSeatsColumn);
        recentTicketGridTotalColumn.Name = "Total";
        recentTicketGridTotalColumn.DataPropertyName = "Total";
        recentTicketGridTotalColumn.HeaderText = "Tổng tiền";
        recentTicketGridTotalColumn.FillWeight = 90F;
        recentTicketGrid.Columns.Add(recentTicketGridTotalColumn);
        recentTicketGridStatusColumn.Name = "Status";
        recentTicketGridStatusColumn.DataPropertyName = "Status";
        recentTicketGridStatusColumn.HeaderText = "Trạng thái";
        recentTicketGridStatusColumn.FillWeight = 90F;
        recentTicketGrid.Columns.Add(recentTicketGridStatusColumn);
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        movieStatPanel.ResumeLayout(false);
        roomStatPanel.ResumeLayout(false);
        showtimeStatPanel.ResumeLayout(false);
        ticketStatPanel.ResumeLayout(false);
        revenueStatPanel.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        showtimePanel.ResumeLayout(false);
        showtimeLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        operationPanel.ResumeLayout(false);
        operationLayout.ResumeLayout(false);
        unusedPanel.ResumeLayout(false);
        usedPanel.ResumeLayout(false);
        canceledPanel.ResumeLayout(false);
        maintenancePanel.ResumeLayout(false);
        bottomLayout.ResumeLayout(false);
        revenuePanel.ResumeLayout(false);
        revenueLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)revenueGrid).EndInit();
        recentTicketPanel.ResumeLayout(false);
        recentTicketLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)recentTicketGrid).EndInit();
        UiStyleHelper.CompleteDesignerGrid(showtimeGrid);
        UiStyleHelper.CompleteDesignerGrid(revenueGrid);
        UiStyleHelper.CompleteDesignerGrid(recentTicketGrid);
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

    private static void StyleStatusPanel(Panel panel, Label titleLabel, Label valueLabel, string title, Color accent)
    {
        panel.BackColor = UiStyleHelper.SurfaceMuted;
        panel.BorderStyle = BorderStyle.FixedSingle;
        panel.Controls.Add(valueLabel);
        panel.Controls.Add(titleLabel);
        panel.Dock = DockStyle.Fill;
        panel.Margin = new Padding(0, 0, 0, 10);
        panel.Padding = new Padding(12);
        titleLabel.Dock = DockStyle.Fill;
        titleLabel.Font = UiStyleHelper.BodyFont(9.5F);
        titleLabel.ForeColor = UiStyleHelper.TextDark;
        titleLabel.Text = title;
        titleLabel.TextAlign = ContentAlignment.MiddleLeft;
        valueLabel.Dock = DockStyle.Right;
        valueLabel.Font = UiStyleHelper.TitleFont(17F);
        valueLabel.ForeColor = accent;
        valueLabel.TextAlign = ContentAlignment.MiddleRight;
        valueLabel.Width = 70;
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
