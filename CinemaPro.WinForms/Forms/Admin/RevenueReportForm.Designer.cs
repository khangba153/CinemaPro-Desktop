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
        revenueTodayNoteLabel = new Label();
        revenueTodayValueLabel = new Label();
        revenueTodayTitleLabel = new Label();
        totalTicketPanel = new Panel();
        totalTicketNoteLabel = new Label();
        totalTicketValueLabel = new Label();
        totalTicketTitleLabel = new Label();
        bestMoviePanel = new Panel();
        bestMovieNoteLabel = new Label();
        bestMovieValueLabel = new Label();
        bestMovieTitleLabel = new Label();
        bestShowtimePanel = new Panel();
        bestShowtimeNoteLabel = new Label();
        bestShowtimeValueLabel = new Label();
        bestShowtimeTitleLabel = new Label();
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
        // rootLayout
        // 
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(statLayout, 0, 1);
        rootLayout.Controls.Add(summaryLayout, 0, 2);
        rootLayout.Controls.Add(reportPanel, 0, 3);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 4;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
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
        filterPanel.Controls.Add(paymentFilterLabel);
        filterPanel.Controls.Add(paymentCombo);
        filterPanel.Controls.Add(viewButton);
        filterPanel.Controls.Add(exportButton);
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
        fromDatePicker.Margin = new Padding(0, 24, 16, 0);
        fromDatePicker.Name = "fromDatePicker";
        fromDatePicker.Size = new Size(123, 27);
        fromDatePicker.TabIndex = 1;
        fromDatePicker.Value = new DateTime(2026, 5, 21, 0, 0, 0, 0);
        // 
        // toDateFilterLabel
        // 
        toDateFilterLabel.Location = new Point(262, 0);
        toDateFilterLabel.Name = "toDateFilterLabel";
        toDateFilterLabel.Size = new Size(114, 31);
        toDateFilterLabel.TabIndex = 2;
        // 
        // toDatePicker
        // 
        toDatePicker.Format = DateTimePickerFormat.Short;
        toDatePicker.Location = new Point(379, 24);
        toDatePicker.Margin = new Padding(0, 24, 16, 0);
        toDatePicker.Name = "toDatePicker";
        toDatePicker.Size = new Size(123, 27);
        toDatePicker.TabIndex = 3;
        // 
        // movieFilterLabel
        // 
        movieFilterLabel.Location = new Point(521, 0);
        movieFilterLabel.Name = "movieFilterLabel";
        movieFilterLabel.Size = new Size(114, 31);
        movieFilterLabel.TabIndex = 4;
        // 
        // movieCombo
        // 
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        movieCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dune: Phần Hai" });
        movieCombo.Location = new Point(638, 24);
        movieCombo.Margin = new Padding(0, 24, 16, 0);
        movieCombo.Name = "movieCombo";
        movieCombo.Size = new Size(143, 28);
        movieCombo.TabIndex = 5;
        // 
        // paymentFilterLabel
        // 
        paymentFilterLabel.Location = new Point(800, 0);
        paymentFilterLabel.Name = "paymentFilterLabel";
        paymentFilterLabel.Size = new Size(114, 31);
        paymentFilterLabel.TabIndex = 6;
        // 
        // paymentCombo
        // 
        paymentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        paymentCombo.Items.AddRange(new object[] { "Tất cả phương thức", "Tiền mặt", "VNPAY Sandbox" });
        paymentCombo.Location = new Point(917, 24);
        paymentCombo.Margin = new Padding(0, 24, 16, 0);
        paymentCombo.Name = "paymentCombo";
        paymentCombo.Size = new Size(148, 28);
        paymentCombo.TabIndex = 7;
        // 
        // viewButton
        // 
        viewButton.Location = new Point(1081, 24);
        viewButton.Margin = new Padding(0, 24, 9, 0);
        viewButton.Name = "viewButton";
        viewButton.Size = new Size(128, 48);
        viewButton.TabIndex = 8;
        viewButton.Text = "Xem báo cáo";
        // 
        // exportButton
        // 
        exportButton.Location = new Point(1218, 24);
        exportButton.Margin = new Padding(0, 24, 0, 0);
        exportButton.Name = "exportButton";
        exportButton.Size = new Size(128, 48);
        exportButton.TabIndex = 9;
        exportButton.Text = "Xuất báo cáo";
        // 
        // statLayout
        // 
        statLayout.BackColor = Color.FromArgb(245, 248, 252);
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
        statLayout.Location = new Point(3, 89);
        statLayout.Margin = new Padding(3, 4, 3, 4);
        statLayout.Name = "statLayout";
        statLayout.Padding = new Padding(0, 0, 0, 13);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        statLayout.Size = new Size(1094, 131);
        statLayout.TabIndex = 1;
        // 
        // revenueTodayPanel
        // 
        revenueTodayPanel.BackColor = Color.White;
        revenueTodayPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueTodayPanel.Controls.Add(revenueTodayNoteLabel);
        revenueTodayPanel.Controls.Add(revenueTodayValueLabel);
        revenueTodayPanel.Controls.Add(revenueTodayTitleLabel);
        revenueTodayPanel.Dock = DockStyle.Fill;
        revenueTodayPanel.Location = new Point(0, 0);
        revenueTodayPanel.Margin = new Padding(0, 0, 14, 0);
        revenueTodayPanel.Name = "revenueTodayPanel";
        revenueTodayPanel.Padding = new Padding(18, 16, 18, 16);
        revenueTodayPanel.Size = new Size(326, 118);
        revenueTodayPanel.TabIndex = 0;
        // 
        // revenueTodayNoteLabel
        // 
        revenueTodayNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayNoteLabel.Font = new Font("Segoe UI", 8.75F);
        revenueTodayNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        revenueTodayNoteLabel.Location = new Point(18, 91);
        revenueTodayNoteLabel.Name = "revenueTodayNoteLabel";
        revenueTodayNoteLabel.Size = new Size(336, 29);
        revenueTodayNoteLabel.TabIndex = 0;
        revenueTodayNoteLabel.Text = "Theo dữ liệu demo";
        revenueTodayNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // revenueTodayValueLabel
        // 
        revenueTodayValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        revenueTodayValueLabel.ForeColor = Color.FromArgb(13, 110, 253);
        revenueTodayValueLabel.Location = new Point(18, 48);
        revenueTodayValueLabel.Name = "revenueTodayValueLabel";
        revenueTodayValueLabel.Size = new Size(336, 43);
        revenueTodayValueLabel.TabIndex = 1;
        revenueTodayValueLabel.Text = "23.4 triệu";
        revenueTodayValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // revenueTodayTitleLabel
        // 
        revenueTodayTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTodayTitleLabel.Font = new Font("Segoe UI", 9.5F);
        revenueTodayTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        revenueTodayTitleLabel.Location = new Point(18, 16);
        revenueTodayTitleLabel.Name = "revenueTodayTitleLabel";
        revenueTodayTitleLabel.Size = new Size(336, 29);
        revenueTodayTitleLabel.TabIndex = 2;
        revenueTodayTitleLabel.Text = "Doanh thu hôm nay";
        revenueTodayTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // totalTicketPanel
        // 
        totalTicketPanel.BackColor = Color.White;
        totalTicketPanel.BorderStyle = BorderStyle.FixedSingle;
        totalTicketPanel.Controls.Add(totalTicketNoteLabel);
        totalTicketPanel.Controls.Add(totalTicketValueLabel);
        totalTicketPanel.Controls.Add(totalTicketTitleLabel);
        totalTicketPanel.Dock = DockStyle.Fill;
        totalTicketPanel.Location = new Point(340, 0);
        totalTicketPanel.Margin = new Padding(0, 0, 14, 0);
        totalTicketPanel.Name = "totalTicketPanel";
        totalTicketPanel.Padding = new Padding(18, 16, 18, 16);
        totalTicketPanel.Size = new Size(326, 118);
        totalTicketPanel.TabIndex = 1;
        // 
        // totalTicketNoteLabel
        // 
        totalTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketNoteLabel.Font = new Font("Segoe UI", 8.75F);
        totalTicketNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        totalTicketNoteLabel.Location = new Point(18, 91);
        totalTicketNoteLabel.Name = "totalTicketNoteLabel";
        totalTicketNoteLabel.Size = new Size(336, 29);
        totalTicketNoteLabel.TabIndex = 0;
        totalTicketNoteLabel.Text = "Toàn bộ kỳ lọc";
        totalTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // totalTicketValueLabel
        // 
        totalTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        totalTicketValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        totalTicketValueLabel.Location = new Point(18, 48);
        totalTicketValueLabel.Name = "totalTicketValueLabel";
        totalTicketValueLabel.Size = new Size(336, 43);
        totalTicketValueLabel.TabIndex = 1;
        totalTicketValueLabel.Text = "268";
        totalTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // totalTicketTitleLabel
        // 
        totalTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalTicketTitleLabel.Font = new Font("Segoe UI", 9.5F);
        totalTicketTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        totalTicketTitleLabel.Location = new Point(18, 16);
        totalTicketTitleLabel.Name = "totalTicketTitleLabel";
        totalTicketTitleLabel.Size = new Size(336, 29);
        totalTicketTitleLabel.TabIndex = 2;
        totalTicketTitleLabel.Text = "Tổng vé đã bán";
        totalTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestMoviePanel
        // 
        bestMoviePanel.BackColor = Color.White;
        bestMoviePanel.BorderStyle = BorderStyle.FixedSingle;
        bestMoviePanel.Controls.Add(bestMovieNoteLabel);
        bestMoviePanel.Controls.Add(bestMovieValueLabel);
        bestMoviePanel.Controls.Add(bestMovieTitleLabel);
        bestMoviePanel.Dock = DockStyle.Fill;
        bestMoviePanel.Location = new Point(680, 0);
        bestMoviePanel.Margin = new Padding(0, 0, 14, 0);
        bestMoviePanel.Name = "bestMoviePanel";
        bestMoviePanel.Padding = new Padding(18, 16, 18, 16);
        bestMoviePanel.Size = new Size(326, 118);
        bestMoviePanel.TabIndex = 2;
        // 
        // bestMovieNoteLabel
        // 
        bestMovieNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieNoteLabel.Font = new Font("Segoe UI", 8.75F);
        bestMovieNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        bestMovieNoteLabel.Location = new Point(18, 91);
        bestMovieNoteLabel.Name = "bestMovieNoteLabel";
        bestMovieNoteLabel.Size = new Size(336, 29);
        bestMovieNoteLabel.TabIndex = 0;
        bestMovieNoteLabel.Text = "Nhiều vé nhất";
        bestMovieNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestMovieValueLabel
        // 
        bestMovieValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        bestMovieValueLabel.ForeColor = Color.FromArgb(249, 115, 22);
        bestMovieValueLabel.Location = new Point(18, 48);
        bestMovieValueLabel.Name = "bestMovieValueLabel";
        bestMovieValueLabel.Size = new Size(336, 43);
        bestMovieValueLabel.TabIndex = 1;
        bestMovieValueLabel.Text = "Avengers";
        bestMovieValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestMovieTitleLabel
        // 
        bestMovieTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestMovieTitleLabel.Font = new Font("Segoe UI", 9.5F);
        bestMovieTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        bestMovieTitleLabel.Location = new Point(18, 16);
        bestMovieTitleLabel.Name = "bestMovieTitleLabel";
        bestMovieTitleLabel.Size = new Size(336, 29);
        bestMovieTitleLabel.TabIndex = 2;
        bestMovieTitleLabel.Text = "Phim bán chạy";
        bestMovieTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestShowtimePanel
        // 
        bestShowtimePanel.BackColor = Color.White;
        bestShowtimePanel.BorderStyle = BorderStyle.FixedSingle;
        bestShowtimePanel.Controls.Add(bestShowtimeNoteLabel);
        bestShowtimePanel.Controls.Add(bestShowtimeValueLabel);
        bestShowtimePanel.Controls.Add(bestShowtimeTitleLabel);
        bestShowtimePanel.Dock = DockStyle.Fill;
        bestShowtimePanel.Location = new Point(1020, 0);
        bestShowtimePanel.Margin = new Padding(0);
        bestShowtimePanel.Name = "bestShowtimePanel";
        bestShowtimePanel.Padding = new Padding(18, 16, 18, 16);
        bestShowtimePanel.Size = new Size(341, 118);
        bestShowtimePanel.TabIndex = 3;
        // 
        // bestShowtimeNoteLabel
        // 
        bestShowtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeNoteLabel.Font = new Font("Segoe UI", 8.75F);
        bestShowtimeNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        bestShowtimeNoteLabel.Location = new Point(18, 91);
        bestShowtimeNoteLabel.Name = "bestShowtimeNoteLabel";
        bestShowtimeNoteLabel.Size = new Size(350, 29);
        bestShowtimeNoteLabel.TabIndex = 0;
        bestShowtimeNoteLabel.Text = "Khung giờ nổi bật";
        bestShowtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestShowtimeValueLabel
        // 
        bestShowtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        bestShowtimeValueLabel.ForeColor = Color.FromArgb(124, 58, 237);
        bestShowtimeValueLabel.Location = new Point(18, 48);
        bestShowtimeValueLabel.Name = "bestShowtimeValueLabel";
        bestShowtimeValueLabel.Size = new Size(350, 43);
        bestShowtimeValueLabel.TabIndex = 1;
        bestShowtimeValueLabel.Text = "19:30";
        bestShowtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bestShowtimeTitleLabel
        // 
        bestShowtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        bestShowtimeTitleLabel.Font = new Font("Segoe UI", 9.5F);
        bestShowtimeTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        bestShowtimeTitleLabel.Location = new Point(18, 16);
        bestShowtimeTitleLabel.Name = "bestShowtimeTitleLabel";
        bestShowtimeTitleLabel.Size = new Size(350, 29);
        bestShowtimeTitleLabel.TabIndex = 2;
        bestShowtimeTitleLabel.Text = "Suất nhiều vé nhất";
        bestShowtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // summaryLayout
        // 
        summaryLayout.BackColor = Color.FromArgb(245, 248, 252);
        summaryLayout.ColumnCount = 2;
        summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        summaryLayout.Controls.Add(dailyRevenuePanel, 0, 0);
        summaryLayout.Controls.Add(movieRevenuePanel, 1, 0);
        summaryLayout.Dock = DockStyle.Fill;
        summaryLayout.Location = new Point(3, 228);
        summaryLayout.Margin = new Padding(3, 4, 3, 4);
        summaryLayout.Name = "summaryLayout";
        summaryLayout.Padding = new Padding(0, 0, 0, 13);
        summaryLayout.RowCount = 1;
        summaryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        summaryLayout.Size = new Size(1094, 202);
        summaryLayout.TabIndex = 2;
        // 
        // dailyRevenuePanel
        // 
        dailyRevenuePanel.BackColor = Color.White;
        dailyRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
        dailyRevenuePanel.Controls.Add(dailyRevenueLayout);
        dailyRevenuePanel.Dock = DockStyle.Fill;
        dailyRevenuePanel.Location = new Point(0, 0);
        dailyRevenuePanel.Margin = new Padding(0, 0, 14, 0);
        dailyRevenuePanel.Name = "dailyRevenuePanel";
        dailyRevenuePanel.Padding = new Padding(11, 13, 11, 13);
        dailyRevenuePanel.Size = new Size(775, 292);
        dailyRevenuePanel.TabIndex = 0;
        // 
        // dailyRevenueLayout
        // 
        dailyRevenueLayout.BackColor = Color.White;
        dailyRevenueLayout.ColumnCount = 1;
        dailyRevenueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        dailyRevenueLayout.Controls.Add(dailyRevenueTitleLabel, 0, 0);
        dailyRevenueLayout.Controls.Add(dailyRevenueGrid, 0, 1);
        dailyRevenueLayout.Dock = DockStyle.Fill;
        dailyRevenueLayout.Location = new Point(11, 13);
        dailyRevenueLayout.Margin = new Padding(3, 4, 3, 4);
        dailyRevenueLayout.Name = "dailyRevenueLayout";
        dailyRevenueLayout.RowCount = 2;
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        dailyRevenueLayout.Size = new Size(751, 264);
        dailyRevenueLayout.TabIndex = 0;
        // 
        // dailyRevenueTitleLabel
        // 
        dailyRevenueTitleLabel.Location = new Point(3, 0);
        dailyRevenueTitleLabel.Name = "dailyRevenueTitleLabel";
        dailyRevenueTitleLabel.Size = new Size(87, 31);
        dailyRevenueTitleLabel.TabIndex = 0;
        // 
        // dailyRevenueGrid
        // 
        dailyRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dailyRevenueGrid.ColumnHeadersHeight = 40;
        dailyRevenueGrid.Dock = DockStyle.Fill;
        dailyRevenueGrid.Location = new Point(3, 44);
        dailyRevenueGrid.Margin = new Padding(3, 4, 3, 4);
        dailyRevenueGrid.Name = "dailyRevenueGrid";
        dailyRevenueGrid.RowHeadersVisible = false;
        dailyRevenueGrid.RowHeadersWidth = 51;
        dailyRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dailyRevenueGrid.Size = new Size(745, 216);
        dailyRevenueGrid.TabIndex = 1;
        // 
        // movieRevenuePanel
        // 
        movieRevenuePanel.BackColor = Color.White;
        movieRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
        movieRevenuePanel.Controls.Add(movieRevenueLayout);
        movieRevenuePanel.Dock = DockStyle.Fill;
        movieRevenuePanel.Location = new Point(792, 4);
        movieRevenuePanel.Margin = new Padding(3, 4, 3, 4);
        movieRevenuePanel.Name = "movieRevenuePanel";
        movieRevenuePanel.Padding = new Padding(11, 13, 11, 13);
        movieRevenuePanel.Size = new Size(566, 284);
        movieRevenuePanel.TabIndex = 1;
        // 
        // movieRevenueLayout
        // 
        movieRevenueLayout.BackColor = Color.White;
        movieRevenueLayout.ColumnCount = 1;
        movieRevenueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        movieRevenueLayout.Controls.Add(movieRevenueTitleLabel, 0, 0);
        movieRevenueLayout.Controls.Add(movieRevenueGrid, 0, 1);
        movieRevenueLayout.Dock = DockStyle.Fill;
        movieRevenueLayout.Location = new Point(11, 13);
        movieRevenueLayout.Margin = new Padding(3, 4, 3, 4);
        movieRevenueLayout.Name = "movieRevenueLayout";
        movieRevenueLayout.RowCount = 2;
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        movieRevenueLayout.Size = new Size(542, 256);
        movieRevenueLayout.TabIndex = 0;
        // 
        // movieRevenueTitleLabel
        // 
        movieRevenueTitleLabel.Location = new Point(3, 0);
        movieRevenueTitleLabel.Name = "movieRevenueTitleLabel";
        movieRevenueTitleLabel.Size = new Size(57, 31);
        movieRevenueTitleLabel.TabIndex = 0;
        // 
        // movieRevenueGrid
        // 
        movieRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        movieRevenueGrid.ColumnHeadersHeight = 40;
        movieRevenueGrid.Dock = DockStyle.Fill;
        movieRevenueGrid.Location = new Point(3, 44);
        movieRevenueGrid.Margin = new Padding(3, 4, 3, 4);
        movieRevenueGrid.Name = "movieRevenueGrid";
        movieRevenueGrid.RowHeadersVisible = false;
        movieRevenueGrid.RowHeadersWidth = 51;
        movieRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        movieRevenueGrid.Size = new Size(536, 208);
        movieRevenueGrid.TabIndex = 1;
        // 
        // reportPanel
        // 
        reportPanel.BackColor = Color.White;
        reportPanel.BorderStyle = BorderStyle.FixedSingle;
        reportPanel.Controls.Add(reportLayout);
        reportPanel.Dock = DockStyle.Fill;
        reportPanel.Location = new Point(3, 541);
        reportPanel.Margin = new Padding(3, 4, 3, 4);
        reportPanel.Name = "reportPanel";
        reportPanel.Padding = new Padding(11, 13, 11, 13);
        reportPanel.Size = new Size(1094, 190);
        reportPanel.TabIndex = 3;
        // 
        // reportLayout
        // 
        reportLayout.BackColor = Color.White;
        reportLayout.ColumnCount = 1;
        reportLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        reportLayout.Controls.Add(reportTitleLabel, 0, 0);
        reportLayout.Controls.Add(reportGrid, 0, 1);
        reportLayout.Dock = DockStyle.Fill;
        reportLayout.Location = new Point(11, 13);
        reportLayout.Margin = new Padding(3, 4, 3, 4);
        reportLayout.Name = "reportLayout";
        reportLayout.RowCount = 2;
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        reportLayout.Size = new Size(1070, 162);
        reportLayout.TabIndex = 0;
        // 
        // reportTitleLabel
        // 
        reportTitleLabel.Location = new Point(3, 0);
        reportTitleLabel.Name = "reportTitleLabel";
        reportTitleLabel.Size = new Size(114, 31);
        reportTitleLabel.TabIndex = 0;
        // 
        // reportGrid
        // 
        reportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        reportGrid.ColumnHeadersHeight = 40;
        reportGrid.Dock = DockStyle.Fill;
        reportGrid.Location = new Point(3, 44);
        reportGrid.Margin = new Padding(3, 4, 3, 4);
        reportGrid.Name = "reportGrid";
        reportGrid.RowHeadersVisible = false;
        reportGrid.RowHeadersWidth = 51;
        reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        reportGrid.Size = new Size(1064, 114);
        reportGrid.TabIndex = 1;
        // 
        // RevenueReportForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "RevenueReportForm";
        Text = "Thống kê doanh thu";
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
        ConfigureDesignerSurface();
        ResumeLayout(false);
    }

    private void ConfigureDesignerSurface()
    {
        StyleInlineLabel(fromDateFilterLabel, "Từ ngày", 56);
        StyleInlineLabel(toDateFilterLabel, "Đến ngày", 64);
        StyleInlineLabel(movieFilterLabel, "Phim", 42);
        StyleInlineLabel(paymentFilterLabel, "Thanh toán", 82);
        fromDatePicker.Size = new Size(112, 27);
        toDatePicker.Size = new Size(112, 27);
        movieCombo.Size = new Size(136, 28);
        paymentCombo.Size = new Size(138, 28);
        viewButton.Size = new Size(112, 42);
        exportButton.Size = new Size(118, 42);
        viewButton.Font = UiStyleHelper.SectionFont(9.25F);
        exportButton.Font = UiStyleHelper.SectionFont(9.25F);
        viewButton.BackColor = UiStyleHelper.Primary;
        viewButton.ForeColor = Color.White;
        viewButton.FlatStyle = FlatStyle.Flat;
        viewButton.FlatAppearance.BorderSize = 0;
        exportButton.BackColor = Color.White;
        exportButton.ForeColor = UiStyleHelper.Primary;
        exportButton.FlatStyle = FlatStyle.Flat;
        exportButton.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;

        StyleCardTitle(dailyRevenueTitleLabel, "DOANH THU THEO NGÀY");
        StyleCardTitle(movieRevenueTitleLabel, "DOANH THU THEO PHIM");
        StyleCardTitle(reportTitleLabel, "CHI TIẾT BÁO CÁO");

        ConfigureColumn(dailyRevenueGridDateColumn, "Date", "Ngày", 90F);
        ConfigureColumn(dailyRevenueGridTicketsSoldColumn, "TicketsSold", "Số vé", 80F);
        ConfigureColumn(dailyRevenueGridRevenueColumn, "Revenue", "Doanh thu", 120F);
        ConfigureGridWithColumns(dailyRevenueGrid, dailyRevenueGridDateColumn, dailyRevenueGridTicketsSoldColumn, dailyRevenueGridRevenueColumn);

        ConfigureColumn(movieRevenueGridMovieColumn, "Movie", "Phim", 170F);
        ConfigureColumn(movieRevenueGridTicketsSoldColumn, "TicketsSold", "Số vé", 75F);
        ConfigureColumn(movieRevenueGridRevenueColumn, "Revenue", "Doanh thu", 110F);
        ConfigureGridWithColumns(movieRevenueGrid, movieRevenueGridMovieColumn, movieRevenueGridTicketsSoldColumn, movieRevenueGridRevenueColumn);

        ConfigureColumn(reportGridDateColumn, "Date", "Ngày", 80F);
        ConfigureColumn(reportGridMovieColumn, "Movie", "Phim", 180F);
        ConfigureColumn(reportGridTicketsSoldColumn, "TicketsSold", "Số vé", 70F);
        ConfigureColumn(reportGridRevenueColumn, "Revenue", "Doanh thu", 105F);
        ConfigureColumn(reportGridBestShowtimeColumn, "BestShowtime", "Suất nổi bật", 120F);
        ConfigureColumn(reportGridOccupancyColumn, "Occupancy", "Lấp đầy", 80F);
        ConfigureGridWithColumns(reportGrid, reportGridDateColumn, reportGridMovieColumn, reportGridTicketsSoldColumn, reportGridRevenueColumn, reportGridBestShowtimeColumn, reportGridOccupancyColumn);
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
