using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class AdminDashboardForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Label movieValueLabel;
    private Label roomValueLabel;
    private Label showtimeValueLabel;
    private Label ticketValueLabel;
    private Label revenueValueLabel;
    private TableLayoutPanel middleLayout;
    private Panel showtimePanel;
    private TableLayoutPanel showtimeLayout;
    private DataGridView showtimeGrid;
    private Panel operationPanel;
    private TableLayoutPanel operationLayout;
    private Label unusedValueLabel;
    private Label usedValueLabel;
    private Label canceledValueLabel;
    private Label maintenanceValueLabel;
    private TableLayoutPanel bottomLayout;
    private Panel revenuePanel;
    private TableLayoutPanel revenueLayout;
    private DataGridView revenueGrid;
    private Panel recentTicketPanel;
    private TableLayoutPanel recentTicketLayout;
    private DataGridView recentTicketGrid;

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
        movieValueLabel = new StatCardLabel { Caption = "Tổng phim", Note = "Đang quản lý", AccentColor = UiStyleHelper.Primary };
        roomValueLabel = new StatCardLabel { Caption = "Tổng phòng chiếu", Note = "Phòng vận hành", AccentColor = UiStyleHelper.Success };
        showtimeValueLabel = new StatCardLabel { Caption = "Suất chiếu hôm nay", Note = "Theo lịch vận hành", AccentColor = UiStyleHelper.Warning };
        ticketValueLabel = new StatCardLabel { Caption = "Vé đã bán hôm nay", Note = "Dữ liệu demo", AccentColor = UiStyleHelper.Accent };
        revenueValueLabel = new StatCardLabel { Caption = "Doanh thu hôm nay", Note = "Tạm tính", AccentColor = UiStyleHelper.Primary };
        middleLayout = new TableLayoutPanel();
        showtimePanel = new Panel();
        showtimeLayout = new TableLayoutPanel();
        showtimeGrid = new DataGridView();
        operationPanel = new Panel();
        operationLayout = new TableLayoutPanel();
        unusedValueLabel = new Label();
        usedValueLabel = new Label();
        canceledValueLabel = new Label();
        maintenanceValueLabel = new Label();
        bottomLayout = new TableLayoutPanel();
        revenuePanel = new Panel();
        revenueLayout = new TableLayoutPanel();
        revenueGrid = new DataGridView();
        recentTicketPanel = new Panel();
        recentTicketLayout = new TableLayoutPanel();
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
        middleLayout.SuspendLayout();
        showtimePanel.SuspendLayout();
        showtimeLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        operationPanel.SuspendLayout();
        operationLayout.SuspendLayout();
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
        statLayout.Controls.Add(movieValueLabel, 0, 0);
        statLayout.Controls.Add(roomValueLabel, 1, 0);
        statLayout.Controls.Add(showtimeValueLabel, 2, 0);
        statLayout.Controls.Add(ticketValueLabel, 3, 0);
        statLayout.Controls.Add(revenueValueLabel, 4, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
        showtimeLayout.Controls.Add(CreateCardTitleLabel("Lịch chiếu gần đây"), 0, 0);
        showtimeLayout.Controls.Add(showtimeGrid, 0, 1);
        showtimeLayout.Dock = DockStyle.Fill;
        showtimeLayout.RowCount = 2;
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(showtimeGrid);
        showtimeGrid.Dock = DockStyle.Fill;
        showtimeGrid.AutoGenerateColumns = false;
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        showtimeGrid.ColumnHeadersHeight = 40;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 170 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 80 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Start", DataPropertyName = "Start", HeaderText = "Bắt đầu", FillWeight = 80 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "End", DataPropertyName = "End", HeaderText = "Kết thúc", FillWeight = 80 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", DataPropertyName = "Price", HeaderText = "Giá vé", FillWeight = 90 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 95 });
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
        operationLayout.Controls.Add(CreateCardTitleLabel("Tình trạng vận hành"), 0, 0);
        operationLayout.Controls.Add(CreateStatusLine("Vé chưa sử dụng", unusedValueLabel, UiStyleHelper.Warning), 0, 1);
        operationLayout.Controls.Add(CreateStatusLine("Vé đã sử dụng", usedValueLabel, UiStyleHelper.Success), 0, 2);
        operationLayout.Controls.Add(CreateStatusLine("Vé đã hủy", canceledValueLabel, UiStyleHelper.Danger), 0, 3);
        operationLayout.Controls.Add(CreateStatusLine("Phòng cần bảo trì", maintenanceValueLabel, UiStyleHelper.Danger), 0, 4);
        operationLayout.Dock = DockStyle.Fill;
        operationLayout.RowCount = 6;
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
        revenueLayout.Controls.Add(CreateCardTitleLabel("Doanh thu theo phim"), 0, 0);
        revenueLayout.Controls.Add(revenueGrid, 0, 1);
        revenueLayout.Dock = DockStyle.Fill;
        revenueLayout.RowCount = 2;
        revenueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        revenueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(revenueGrid);
        revenueGrid.Dock = DockStyle.Fill;
        revenueGrid.AutoGenerateColumns = false;
        revenueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        revenueGrid.ColumnHeadersHeight = 40;
        revenueGrid.RowHeadersVisible = false;
        revenueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        revenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 180 });
        revenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketsSold", DataPropertyName = "TicketsSold", HeaderText = "Số vé", FillWeight = 80 });
        revenueGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Revenue", DataPropertyName = "Revenue", HeaderText = "Doanh thu", FillWeight = 120 });
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
        recentTicketLayout.Controls.Add(CreateCardTitleLabel("Vé bán gần đây"), 0, 0);
        recentTicketLayout.Controls.Add(recentTicketGrid, 0, 1);
        recentTicketLayout.Dock = DockStyle.Fill;
        recentTicketLayout.RowCount = 2;
        recentTicketLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        recentTicketLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(recentTicketGrid);
        recentTicketGrid.Dock = DockStyle.Fill;
        recentTicketGrid.AutoGenerateColumns = false;
        recentTicketGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        recentTicketGrid.ColumnHeadersHeight = 40;
        recentTicketGrid.RowHeadersVisible = false;
        recentTicketGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        recentTicketGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketId", DataPropertyName = "TicketId", HeaderText = "Mã vé", FillWeight = 90 });
        recentTicketGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 150 });
        recentTicketGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Seats", DataPropertyName = "Seats", HeaderText = "Ghế", FillWeight = 70 });
        recentTicketGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", DataPropertyName = "Total", HeaderText = "Tổng tiền", FillWeight = 90 });
        recentTicketGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 90 });
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        showtimePanel.ResumeLayout(false);
        showtimeLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        operationPanel.ResumeLayout(false);
        operationLayout.ResumeLayout(false);
        bottomLayout.ResumeLayout(false);
        revenuePanel.ResumeLayout(false);
        revenueLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)revenueGrid).EndInit();
        recentTicketPanel.ResumeLayout(false);
        recentTicketLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)recentTicketGrid).EndInit();
        ResumeLayout(false);
    }

    private static Panel CreateStatPanel(string label, Label valueLabel, string note, Color accent)
    {
        var panel = new Panel
        {
            BackColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle,
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 0, 12, 0),
            Padding = new Padding(18, 14, 18, 14)
        };
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

    private static Panel CreateStatusLine(string label, Label valueLabel, Color accent)
    {
        var panel = new Panel
        {
            BackColor = UiStyleHelper.SurfaceMuted,
            BorderStyle = BorderStyle.FixedSingle,
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 0, 0, 10),
            Padding = new Padding(12)
        };
        valueLabel.Dock = DockStyle.Right;
        valueLabel.Font = UiStyleHelper.TitleFont(17F);
        valueLabel.ForeColor = accent;
        valueLabel.TextAlign = ContentAlignment.MiddleRight;
        valueLabel.Width = 70;
        panel.Controls.Add(valueLabel);
        panel.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.BodyFont(9.5F), ForeColor = UiStyleHelper.TextDark, TextAlign = ContentAlignment.MiddleLeft });
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
