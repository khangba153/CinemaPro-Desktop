using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class RevenueReportForm
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
    private Label paymentFilterLabel;
    private ComboBox paymentCombo;
    private Button viewButton;
    private Button exportButton;
    private TableLayoutPanel statLayout;
    private Panel revenueTodayPanel;
    private Label revenueTodayTitleLabel;
    private Label revenueTodayValueLabel;
    private Label revenueTodayNoteLabel;
    private Panel totalTicketPanel;
    private Label totalTicketTitleLabel;
    private Label totalTicketValueLabel;
    private Label totalTicketNoteLabel;
    private Panel bestMoviePanel;
    private Label bestMovieTitleLabel;
    private Label bestMovieValueLabel;
    private Label bestMovieNoteLabel;
    private Panel bestShowtimePanel;
    private Label bestShowtimeTitleLabel;
    private Label bestShowtimeValueLabel;
    private Label bestShowtimeNoteLabel;
    private TableLayoutPanel summaryLayout;
    private Panel dailyRevenuePanel;
    private TableLayoutPanel dailyRevenueLayout;
    private Label dailyRevenueTitleLabel;
    private DataGridView dailyRevenueGrid;
    private Panel movieRevenuePanel;
    private TableLayoutPanel movieRevenueLayout;
    private Label movieRevenueTitleLabel;
    private DataGridView movieRevenueGrid;
    private Panel reportPanel;
    private TableLayoutPanel reportLayout;
    private Label reportTitleLabel;
    private DataGridView reportGrid;

    private DataGridViewTextBoxColumn dailyRevenueGridDateColumn;
    private DataGridViewTextBoxColumn dailyRevenueGridTicketsSoldColumn;
    private DataGridViewTextBoxColumn dailyRevenueGridRevenueColumn;
    private DataGridViewTextBoxColumn movieRevenueGridMovieColumn;
    private DataGridViewTextBoxColumn movieRevenueGridTicketsSoldColumn;
    private DataGridViewTextBoxColumn movieRevenueGridRevenueColumn;
    private DataGridViewTextBoxColumn reportGridDateColumn;
    private DataGridViewTextBoxColumn reportGridMovieColumn;
    private DataGridViewTextBoxColumn reportGridTicketsSoldColumn;
    private DataGridViewTextBoxColumn reportGridRevenueColumn;
    private DataGridViewTextBoxColumn reportGridBestShowtimeColumn;
    private DataGridViewTextBoxColumn reportGridOccupancyColumn;
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
        dailyRevenueGridDateColumn = new DataGridViewTextBoxColumn();
        dailyRevenueGridTicketsSoldColumn = new DataGridViewTextBoxColumn();
        dailyRevenueGridRevenueColumn = new DataGridViewTextBoxColumn();
        movieRevenueGridMovieColumn = new DataGridViewTextBoxColumn();
        movieRevenueGridTicketsSoldColumn = new DataGridViewTextBoxColumn();
        movieRevenueGridRevenueColumn = new DataGridViewTextBoxColumn();
        reportGridDateColumn = new DataGridViewTextBoxColumn();
        reportGridMovieColumn = new DataGridViewTextBoxColumn();
        reportGridTicketsSoldColumn = new DataGridViewTextBoxColumn();
        reportGridRevenueColumn = new DataGridViewTextBoxColumn();
        reportGridBestShowtimeColumn = new DataGridViewTextBoxColumn();
        reportGridOccupancyColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        filterPanel = new FlowLayoutPanel();
        fromDateFilterLabel = new Label();
        fromDatePicker = new DateTimePicker();
        toDateFilterLabel = new Label();
        toDatePicker = new DateTimePicker();
        movieFilterLabel = new Label();
        movieCombo = new ComboBox();
        paymentFilterLabel = new Label();
        paymentCombo = new ComboBox();
        viewButton = new Button();
        exportButton = new Button();
        statLayout = new TableLayoutPanel();
        revenueTodayPanel = new Panel();
        revenueTodayTitleLabel = new Label();
        revenueTodayValueLabel = new Label();
        revenueTodayNoteLabel = new Label();
        totalTicketPanel = new Panel();
        totalTicketTitleLabel = new Label();
        totalTicketValueLabel = new Label();
        totalTicketNoteLabel = new Label();
        bestMoviePanel = new Panel();
        bestMovieTitleLabel = new Label();
        bestMovieValueLabel = new Label();
        bestMovieNoteLabel = new Label();
        bestShowtimePanel = new Panel();
        bestShowtimeTitleLabel = new Label();
        bestShowtimeValueLabel = new Label();
        bestShowtimeNoteLabel = new Label();
        summaryLayout = new TableLayoutPanel();
        dailyRevenuePanel = new Panel();
        dailyRevenueLayout = new TableLayoutPanel();
        dailyRevenueTitleLabel = new Label();
        dailyRevenueGrid = new DataGridView();
        movieRevenuePanel = new Panel();
        movieRevenueLayout = new TableLayoutPanel();
        movieRevenueTitleLabel = new Label();
        movieRevenueGrid = new DataGridView();
        reportPanel = new Panel();
        reportLayout = new TableLayoutPanel();
        reportTitleLabel = new Label();
        reportGrid = new DataGridView();
        revenueTodayValueLabel.Text = "23.4 triệu";
        totalTicketValueLabel.Text = "268";
        bestMovieValueLabel.Text = "Avengers";
        bestShowtimeValueLabel.Text = "19:30";
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        statLayout.SuspendLayout();
        revenueTodayPanel.SuspendLayout();
        totalTicketPanel.SuspendLayout();
        bestMoviePanel.SuspendLayout();
        bestShowtimePanel.SuspendLayout();
        summaryLayout.SuspendLayout();
        dailyRevenuePanel.SuspendLayout();
        dailyRevenueLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dailyRevenueGrid).BeginInit();
        movieRevenuePanel.SuspendLayout();
        movieRevenueLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)movieRevenueGrid).BeginInit();
        reportPanel.SuspendLayout();
        reportLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
        SuspendLayout();
        //
        // RevenueReportForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "RevenueReportForm";
        Text = "Thống kê doanh thu";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(statLayout, 0, 1);
        rootLayout.Controls.Add(summaryLayout, 0, 2);
        rootLayout.Controls.Add(reportPanel, 0, 3);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 4;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
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
        filterPanel.Controls.Add(paymentFilterLabel);
        filterPanel.Controls.Add(paymentCombo);
        filterPanel.Controls.Add(viewButton);
        filterPanel.Controls.Add(exportButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        StyleInlineLabel(fromDateFilterLabel, "Từ ngày", 58);
        fromDatePicker.Format = DateTimePickerFormat.Short;
        fromDatePicker.Margin = new Padding(0, 18, 14, 0);
        fromDatePicker.Size = new Size(118, 32);
        fromDatePicker.Value = DateTime.Today.AddDays(-7);
        StyleInlineLabel(toDateFilterLabel, "Đến ngày", 68);
        toDatePicker.Format = DateTimePickerFormat.Short;
        toDatePicker.Margin = new Padding(0, 18, 14, 0);
        toDatePicker.Size = new Size(118, 32);
        StyleInlineLabel(movieFilterLabel, "Phim", 38);
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        movieCombo.Margin = new Padding(0, 18, 14, 0);
        movieCombo.Size = new Size(148, 32);
        StyleInlineLabel(paymentFilterLabel, "Thanh toán", 82);
        paymentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        paymentCombo.Margin = new Padding(0, 18, 14, 0);
        paymentCombo.Size = new Size(150, 32);
        movieCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dune: Phần Hai" });
        movieCombo.SelectedIndex = 0;
        paymentCombo.Items.AddRange(new object[] { "Tất cả phương thức", "Tiền mặt", "VNPAY Sandbox" });
        paymentCombo.SelectedIndex = 0;
        viewButton.Margin = new Padding(0, 18, 8, 0);
        viewButton.Size = new Size(130, 36);
        viewButton.Text = "Xem báo cáo";
        exportButton.Margin = new Padding(0, 18, 0, 0);
        exportButton.Size = new Size(130, 36);
        exportButton.Text = "Xuất báo cáo";
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(revenueTodayPanel, 0, 0);
        statLayout.Controls.Add(totalTicketPanel, 1, 0);
        statLayout.Controls.Add(bestMoviePanel, 2, 0);
        statLayout.Controls.Add(bestShowtimePanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // revenueTodayPanel
        //
        revenueTodayPanel.BackColor = Color.White;
        revenueTodayPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueTodayPanel.Controls.Add(revenueTodayNoteLabel);
        revenueTodayPanel.Controls.Add(revenueTodayValueLabel);
        revenueTodayPanel.Controls.Add(revenueTodayTitleLabel);
        revenueTodayPanel.Dock = DockStyle.Fill;
        revenueTodayPanel.Margin = new Padding(0, 0, 12, 0);
        revenueTodayPanel.Padding = new Padding(16, 12, 16, 12);
        revenueTodayTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        revenueTodayTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueTodayTitleLabel.Location = new Point(16, 12);
        revenueTodayTitleLabel.Size = new Size(210, 22);
        revenueTodayTitleLabel.Text = "Doanh thu hôm nay";
        revenueTodayTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueTodayValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayValueLabel.Font = UiStyleHelper.TitleFont(17F);
        revenueTodayValueLabel.ForeColor = UiStyleHelper.Primary;
        revenueTodayValueLabel.Location = new Point(16, 36);
        revenueTodayValueLabel.Size = new Size(210, 32);
        revenueTodayValueLabel.Text = "23.4 triệu";
        revenueTodayValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueTodayNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        revenueTodayNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueTodayNoteLabel.Location = new Point(16, 68);
        revenueTodayNoteLabel.Size = new Size(210, 22);
        revenueTodayNoteLabel.Text = "Theo dữ liệu demo";
        revenueTodayNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // totalTicketPanel
        //
        totalTicketPanel.BackColor = Color.White;
        totalTicketPanel.BorderStyle = BorderStyle.FixedSingle;
        totalTicketPanel.Controls.Add(totalTicketNoteLabel);
        totalTicketPanel.Controls.Add(totalTicketValueLabel);
        totalTicketPanel.Controls.Add(totalTicketTitleLabel);
        totalTicketPanel.Dock = DockStyle.Fill;
        totalTicketPanel.Margin = new Padding(0, 0, 12, 0);
        totalTicketPanel.Padding = new Padding(16, 12, 16, 12);
        totalTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        totalTicketTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        totalTicketTitleLabel.Location = new Point(16, 12);
        totalTicketTitleLabel.Size = new Size(210, 22);
        totalTicketTitleLabel.Text = "Tổng vé đã bán";
        totalTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketValueLabel.Font = UiStyleHelper.TitleFont(17F);
        totalTicketValueLabel.ForeColor = UiStyleHelper.Success;
        totalTicketValueLabel.Location = new Point(16, 36);
        totalTicketValueLabel.Size = new Size(210, 32);
        totalTicketValueLabel.Text = "268";
        totalTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        totalTicketNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        totalTicketNoteLabel.Location = new Point(16, 68);
        totalTicketNoteLabel.Size = new Size(210, 22);
        totalTicketNoteLabel.Text = "Toàn bộ kỳ lọc";
        totalTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // bestMoviePanel
        //
        bestMoviePanel.BackColor = Color.White;
        bestMoviePanel.BorderStyle = BorderStyle.FixedSingle;
        bestMoviePanel.Controls.Add(bestMovieNoteLabel);
        bestMoviePanel.Controls.Add(bestMovieValueLabel);
        bestMoviePanel.Controls.Add(bestMovieTitleLabel);
        bestMoviePanel.Dock = DockStyle.Fill;
        bestMoviePanel.Margin = new Padding(0, 0, 12, 0);
        bestMoviePanel.Padding = new Padding(16, 12, 16, 12);
        bestMovieTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        bestMovieTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        bestMovieTitleLabel.Location = new Point(16, 12);
        bestMovieTitleLabel.Size = new Size(210, 22);
        bestMovieTitleLabel.Text = "Phim bán chạy";
        bestMovieTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        bestMovieValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieValueLabel.Font = UiStyleHelper.TitleFont(17F);
        bestMovieValueLabel.ForeColor = UiStyleHelper.Warning;
        bestMovieValueLabel.Location = new Point(16, 36);
        bestMovieValueLabel.Size = new Size(210, 32);
        bestMovieValueLabel.Text = "Avengers";
        bestMovieValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        bestMovieNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        bestMovieNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        bestMovieNoteLabel.Location = new Point(16, 68);
        bestMovieNoteLabel.Size = new Size(210, 22);
        bestMovieNoteLabel.Text = "Nhiều vé nhất";
        bestMovieNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // bestShowtimePanel
        //
        bestShowtimePanel.BackColor = Color.White;
        bestShowtimePanel.BorderStyle = BorderStyle.FixedSingle;
        bestShowtimePanel.Controls.Add(bestShowtimeNoteLabel);
        bestShowtimePanel.Controls.Add(bestShowtimeValueLabel);
        bestShowtimePanel.Controls.Add(bestShowtimeTitleLabel);
        bestShowtimePanel.Dock = DockStyle.Fill;
        bestShowtimePanel.Margin = new Padding(0);
        bestShowtimePanel.Padding = new Padding(16, 12, 16, 12);
        bestShowtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        bestShowtimeTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        bestShowtimeTitleLabel.Location = new Point(16, 12);
        bestShowtimeTitleLabel.Size = new Size(210, 22);
        bestShowtimeTitleLabel.Text = "Suất nhiều vé nhất";
        bestShowtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        bestShowtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeValueLabel.Font = UiStyleHelper.TitleFont(17F);
        bestShowtimeValueLabel.ForeColor = UiStyleHelper.Accent;
        bestShowtimeValueLabel.Location = new Point(16, 36);
        bestShowtimeValueLabel.Size = new Size(210, 32);
        bestShowtimeValueLabel.Text = "19:30";
        bestShowtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        bestShowtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        bestShowtimeNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        bestShowtimeNoteLabel.Location = new Point(16, 68);
        bestShowtimeNoteLabel.Size = new Size(210, 22);
        bestShowtimeNoteLabel.Text = "Khung giờ nổi bật";
        bestShowtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // summaryLayout
        //
        summaryLayout.BackColor = UiStyleHelper.ContentBackground;
        summaryLayout.ColumnCount = 2;
        summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        summaryLayout.Controls.Add(dailyRevenuePanel, 0, 0);
        summaryLayout.Controls.Add(movieRevenuePanel, 1, 0);
        summaryLayout.Dock = DockStyle.Fill;
        summaryLayout.Padding = new Padding(0, 0, 0, 10);
        summaryLayout.RowCount = 1;
        summaryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // dailyRevenuePanel
        //
        dailyRevenuePanel.BackColor = Color.White;
        dailyRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
        dailyRevenuePanel.Controls.Add(dailyRevenueLayout);
        dailyRevenuePanel.Dock = DockStyle.Fill;
        dailyRevenuePanel.Margin = new Padding(0, 0, 12, 0);
        dailyRevenuePanel.Padding = new Padding(10);
        dailyRevenueLayout.BackColor = Color.White;
        dailyRevenueLayout.ColumnCount = 1;
        dailyRevenueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        dailyRevenueLayout.Controls.Add(dailyRevenueTitleLabel, 0, 0);
        dailyRevenueLayout.Controls.Add(dailyRevenueGrid, 0, 1);
        dailyRevenueLayout.Dock = DockStyle.Fill;
        dailyRevenueLayout.RowCount = 2;
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(dailyRevenueTitleLabel, "DOANH THU THEO NGÀY");
        ConfigureGrid(dailyRevenueGrid);
        dailyRevenueGrid.Dock = DockStyle.Fill;
        dailyRevenueGrid.AutoGenerateColumns = false;
        dailyRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dailyRevenueGrid.ColumnHeadersHeight = 40;
        dailyRevenueGrid.RowHeadersVisible = false;
        dailyRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dailyRevenueGridDateColumn.Name = "Date";
        dailyRevenueGridDateColumn.DataPropertyName = "Date";
        dailyRevenueGridDateColumn.HeaderText = "Ngày";
        dailyRevenueGridDateColumn.FillWeight = 120F;
        dailyRevenueGrid.Columns.Add(dailyRevenueGridDateColumn);
        dailyRevenueGridTicketsSoldColumn.Name = "TicketsSold";
        dailyRevenueGridTicketsSoldColumn.DataPropertyName = "TicketsSold";
        dailyRevenueGridTicketsSoldColumn.HeaderText = "Số vé";
        dailyRevenueGridTicketsSoldColumn.FillWeight = 90F;
        dailyRevenueGrid.Columns.Add(dailyRevenueGridTicketsSoldColumn);
        dailyRevenueGridRevenueColumn.Name = "Revenue";
        dailyRevenueGridRevenueColumn.DataPropertyName = "Revenue";
        dailyRevenueGridRevenueColumn.HeaderText = "Doanh thu";
        dailyRevenueGridRevenueColumn.FillWeight = 140F;
        dailyRevenueGrid.Columns.Add(dailyRevenueGridRevenueColumn);
        //
        // movieRevenuePanel
        //
        movieRevenuePanel.BackColor = Color.White;
        movieRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
        movieRevenuePanel.Controls.Add(movieRevenueLayout);
        movieRevenuePanel.Dock = DockStyle.Fill;
        movieRevenuePanel.Padding = new Padding(10);
        movieRevenueLayout.BackColor = Color.White;
        movieRevenueLayout.ColumnCount = 1;
        movieRevenueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        movieRevenueLayout.Controls.Add(movieRevenueTitleLabel, 0, 0);
        movieRevenueLayout.Controls.Add(movieRevenueGrid, 0, 1);
        movieRevenueLayout.Dock = DockStyle.Fill;
        movieRevenueLayout.RowCount = 2;
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(movieRevenueTitleLabel, "DOANH THU THEO PHIM");
        ConfigureGrid(movieRevenueGrid);
        movieRevenueGrid.Dock = DockStyle.Fill;
        movieRevenueGrid.AutoGenerateColumns = false;
        movieRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        movieRevenueGrid.ColumnHeadersHeight = 40;
        movieRevenueGrid.RowHeadersVisible = false;
        movieRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        movieRevenueGridMovieColumn.Name = "Movie";
        movieRevenueGridMovieColumn.DataPropertyName = "Movie";
        movieRevenueGridMovieColumn.HeaderText = "Phim";
        movieRevenueGridMovieColumn.FillWeight = 180F;
        movieRevenueGrid.Columns.Add(movieRevenueGridMovieColumn);
        movieRevenueGridTicketsSoldColumn.Name = "TicketsSold";
        movieRevenueGridTicketsSoldColumn.DataPropertyName = "TicketsSold";
        movieRevenueGridTicketsSoldColumn.HeaderText = "Số vé";
        movieRevenueGridTicketsSoldColumn.FillWeight = 80F;
        movieRevenueGrid.Columns.Add(movieRevenueGridTicketsSoldColumn);
        movieRevenueGridRevenueColumn.Name = "Revenue";
        movieRevenueGridRevenueColumn.DataPropertyName = "Revenue";
        movieRevenueGridRevenueColumn.HeaderText = "Doanh thu";
        movieRevenueGridRevenueColumn.FillWeight = 120F;
        movieRevenueGrid.Columns.Add(movieRevenueGridRevenueColumn);
        //
        // reportPanel
        //
        reportPanel.BackColor = Color.White;
        reportPanel.BorderStyle = BorderStyle.FixedSingle;
        reportPanel.Controls.Add(reportLayout);
        reportPanel.Dock = DockStyle.Fill;
        reportPanel.Padding = new Padding(10);
        reportLayout.BackColor = Color.White;
        reportLayout.ColumnCount = 1;
        reportLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        reportLayout.Controls.Add(reportTitleLabel, 0, 0);
        reportLayout.Controls.Add(reportGrid, 0, 1);
        reportLayout.Dock = DockStyle.Fill;
        reportLayout.RowCount = 2;
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(reportTitleLabel, "BÁO CÁO BÁN VÉ");
        ConfigureGrid(reportGrid);
        reportGrid.Dock = DockStyle.Fill;
        reportGrid.AutoGenerateColumns = false;
        reportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        reportGrid.ColumnHeadersHeight = 40;
        reportGrid.RowHeadersVisible = false;
        reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        reportGridDateColumn.Name = "Date";
        reportGridDateColumn.DataPropertyName = "Date";
        reportGridDateColumn.HeaderText = "Ngày";
        reportGridDateColumn.FillWeight = 90F;
        reportGrid.Columns.Add(reportGridDateColumn);
        reportGridMovieColumn.Name = "Movie";
        reportGridMovieColumn.DataPropertyName = "Movie";
        reportGridMovieColumn.HeaderText = "Phim";
        reportGridMovieColumn.FillWeight = 180F;
        reportGrid.Columns.Add(reportGridMovieColumn);
        reportGridTicketsSoldColumn.Name = "TicketsSold";
        reportGridTicketsSoldColumn.DataPropertyName = "TicketsSold";
        reportGridTicketsSoldColumn.HeaderText = "Số vé";
        reportGridTicketsSoldColumn.FillWeight = 80F;
        reportGrid.Columns.Add(reportGridTicketsSoldColumn);
        reportGridRevenueColumn.Name = "Revenue";
        reportGridRevenueColumn.DataPropertyName = "Revenue";
        reportGridRevenueColumn.HeaderText = "Doanh thu";
        reportGridRevenueColumn.FillWeight = 120F;
        reportGrid.Columns.Add(reportGridRevenueColumn);
        reportGridBestShowtimeColumn.Name = "BestShowtime";
        reportGridBestShowtimeColumn.DataPropertyName = "BestShowtime";
        reportGridBestShowtimeColumn.HeaderText = "Suất nổi bật";
        reportGridBestShowtimeColumn.FillWeight = 100F;
        reportGrid.Columns.Add(reportGridBestShowtimeColumn);
        reportGridOccupancyColumn.Name = "Occupancy";
        reportGridOccupancyColumn.DataPropertyName = "Occupancy";
        reportGridOccupancyColumn.HeaderText = "Tỷ lệ lấp đầy";
        reportGridOccupancyColumn.FillWeight = 100F;
        reportGrid.Columns.Add(reportGridOccupancyColumn);
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        revenueTodayPanel.ResumeLayout(false);
        totalTicketPanel.ResumeLayout(false);
        bestMoviePanel.ResumeLayout(false);
        bestShowtimePanel.ResumeLayout(false);
        summaryLayout.ResumeLayout(false);
        dailyRevenuePanel.ResumeLayout(false);
        dailyRevenueLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dailyRevenueGrid).EndInit();
        movieRevenuePanel.ResumeLayout(false);
        movieRevenueLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)movieRevenueGrid).EndInit();
        reportPanel.ResumeLayout(false);
        reportLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
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
