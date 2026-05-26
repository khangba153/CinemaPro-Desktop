using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class RevenueReportForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private DateTimePicker fromDatePicker;
    private DateTimePicker toDatePicker;
    private ComboBox movieCombo;
    private ComboBox paymentCombo;
    private Button viewButton;
    private Button exportButton;
    private TableLayoutPanel statLayout;
    private Label revenueTodayValueLabel;
    private Label totalTicketValueLabel;
    private Label bestMovieValueLabel;
    private Label bestShowtimeValueLabel;
    private TableLayoutPanel summaryLayout;
    private Panel dailyRevenuePanel;
    private TableLayoutPanel dailyRevenueLayout;
    private DataGridView dailyRevenueGrid;
    private Panel movieRevenuePanel;
    private TableLayoutPanel movieRevenueLayout;
    private DataGridView movieRevenueGrid;
    private Panel reportPanel;
    private TableLayoutPanel reportLayout;
    private DataGridView reportGrid;

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
        paymentCombo = new ComboBox();
        viewButton = new Button();
        exportButton = new Button();
        statLayout = new TableLayoutPanel();
        revenueTodayValueLabel = new StatCardLabel { Caption = "Doanh thu hôm nay", Note = "Theo dữ liệu demo", AccentColor = UiStyleHelper.Primary };
        totalTicketValueLabel = new StatCardLabel { Caption = "Tổng vé đã bán", Note = "Toàn bộ kỳ lọc", AccentColor = UiStyleHelper.Success };
        bestMovieValueLabel = new StatCardLabel { Caption = "Phim bán chạy", Note = "Nhiều vé nhất", AccentColor = UiStyleHelper.Warning };
        bestShowtimeValueLabel = new StatCardLabel { Caption = "Suất nhiều vé nhất", Note = "Khung giờ nổi bật", AccentColor = UiStyleHelper.Accent };
        summaryLayout = new TableLayoutPanel();
        dailyRevenuePanel = new Panel();
        dailyRevenueLayout = new TableLayoutPanel();
        dailyRevenueGrid = new DataGridView();
        movieRevenuePanel = new Panel();
        movieRevenueLayout = new TableLayoutPanel();
        movieRevenueGrid = new DataGridView();
        reportPanel = new Panel();
        reportLayout = new TableLayoutPanel();
        reportGrid = new DataGridView();
        revenueTodayValueLabel.Text = "23.4 triệu";
        totalTicketValueLabel.Text = "268";
        bestMovieValueLabel.Text = "Avengers";
        bestShowtimeValueLabel.Text = "19:30";
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        statLayout.SuspendLayout();
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
        filterPanel.Controls.Add(CreateFilterBlock("Từ ngày", fromDatePicker, 132));
        filterPanel.Controls.Add(CreateFilterBlock("Đến ngày", toDatePicker, 132));
        filterPanel.Controls.Add(CreateFilterBlock("Phim", movieCombo, 180));
        filterPanel.Controls.Add(CreateFilterBlock("Phương thức thanh toán", paymentCombo, 170));
        filterPanel.Controls.Add(viewButton);
        filterPanel.Controls.Add(exportButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        fromDatePicker.Format = DateTimePickerFormat.Short;
        fromDatePicker.Value = DateTime.Today.AddDays(-7);
        toDatePicker.Format = DateTimePickerFormat.Short;
        movieCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        paymentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
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
        statLayout.Controls.Add(revenueTodayValueLabel, 0, 0);
        statLayout.Controls.Add(totalTicketValueLabel, 1, 0);
        statLayout.Controls.Add(bestMovieValueLabel, 2, 0);
        statLayout.Controls.Add(bestShowtimeValueLabel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
        dailyRevenueLayout.Controls.Add(CreateCardTitleLabel("Doanh thu theo ngày"), 0, 0);
        dailyRevenueLayout.Controls.Add(dailyRevenueGrid, 0, 1);
        dailyRevenueLayout.Dock = DockStyle.Fill;
        dailyRevenueLayout.RowCount = 2;
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        dailyRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(dailyRevenueGrid);
        dailyRevenueGrid.Dock = DockStyle.Fill;
        dailyRevenueGrid.AutoGenerateColumns = false;
        dailyRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dailyRevenueGrid.ColumnHeadersHeight = 40;
        dailyRevenueGrid.RowHeadersVisible = false;
        dailyRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dailyRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", HeaderText = "Ngày", FillWeight = 120 });
        dailyRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketsSold", DataPropertyName = "TicketsSold", HeaderText = "Số vé", FillWeight = 90 });
        dailyRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Revenue", DataPropertyName = "Revenue", HeaderText = "Doanh thu", FillWeight = 140 });
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
        movieRevenueLayout.Controls.Add(CreateCardTitleLabel("Doanh thu theo phim"), 0, 0);
        movieRevenueLayout.Controls.Add(movieRevenueGrid, 0, 1);
        movieRevenueLayout.Dock = DockStyle.Fill;
        movieRevenueLayout.RowCount = 2;
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        movieRevenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(movieRevenueGrid);
        movieRevenueGrid.Dock = DockStyle.Fill;
        movieRevenueGrid.AutoGenerateColumns = false;
        movieRevenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        movieRevenueGrid.ColumnHeadersHeight = 40;
        movieRevenueGrid.RowHeadersVisible = false;
        movieRevenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        movieRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 180 });
        movieRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketsSold", DataPropertyName = "TicketsSold", HeaderText = "Số vé", FillWeight = 80 });
        movieRevenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Revenue", DataPropertyName = "Revenue", HeaderText = "Doanh thu", FillWeight = 120 });
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
        reportLayout.Controls.Add(CreateCardTitleLabel("Báo cáo bán vé"), 0, 0);
        reportLayout.Controls.Add(reportGrid, 0, 1);
        reportLayout.Dock = DockStyle.Fill;
        reportLayout.RowCount = 2;
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        reportLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(reportGrid);
        reportGrid.Dock = DockStyle.Fill;
        reportGrid.AutoGenerateColumns = false;
        reportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        reportGrid.ColumnHeadersHeight = 40;
        reportGrid.RowHeadersVisible = false;
        reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", HeaderText = "Ngày", FillWeight = 90 });
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 180 });
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketsSold", DataPropertyName = "TicketsSold", HeaderText = "Số vé", FillWeight = 80 });
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Revenue", DataPropertyName = "Revenue", HeaderText = "Doanh thu", FillWeight = 120 });
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "BestShowtime", DataPropertyName = "BestShowtime", HeaderText = "Suất nổi bật", FillWeight = 100 });
        reportGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Occupancy", DataPropertyName = "Occupancy", HeaderText = "Tỷ lệ lấp đầy", FillWeight = 100 });
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        statLayout.ResumeLayout(false);
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
        block.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.25F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        control.Dock = DockStyle.Fill;
        block.Controls.Add(control, 0, 1);
        return block;
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
