using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class StaffDashboardForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Label showtimeValueLabel;
    private Label soldTicketValueLabel;
    private Label revenueValueLabel;
    private Label waitingTicketValueLabel;
    private TableLayoutPanel middleLayout;
    private Panel schedulePanel;
    private TableLayoutPanel scheduleLayout;
    private DataGridView scheduleGrid;
    private Panel quickActionPanel;
    private TableLayoutPanel actionLayout;
    private Button saleButton;
    private Button checkButton;
    private Label demoHintLabel;
    private Panel shiftPanel;
    private Label shiftLabel;

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
        showtimeValueLabel = new StatCardLabel { Caption = "Suất chiếu hôm nay", Note = "Các phòng đang vận hành", AccentColor = UiStyleHelper.Primary };
        soldTicketValueLabel = new StatCardLabel { Caption = "Vé đã bán trong ca", Note = "Dữ liệu demo trong phiên", AccentColor = UiStyleHelper.Success };
        revenueValueLabel = new StatCardLabel { Caption = "Doanh thu trong ca", Note = "Tính theo vé đã bán", AccentColor = UiStyleHelper.Warning };
        waitingTicketValueLabel = new StatCardLabel { Caption = "Vé chờ kiểm tra", Note = "Sẵn sàng check-in", AccentColor = UiStyleHelper.Accent };
        middleLayout = new TableLayoutPanel();
        schedulePanel = new Panel();
        scheduleLayout = new TableLayoutPanel();
        scheduleGrid = new DataGridView();
        quickActionPanel = new Panel();
        actionLayout = new TableLayoutPanel();
        saleButton = new Button();
        checkButton = new Button();
        demoHintLabel = new Label();
        shiftPanel = new Panel();
        shiftLabel = new Label();
        showtimeValueLabel.Text = "8";
        soldTicketValueLabel.Text = "31";
        revenueValueLabel.Text = "2.790.000 đ";
        waitingTicketValueLabel.Text = "12";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        middleLayout.SuspendLayout();
        schedulePanel.SuspendLayout();
        scheduleLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)scheduleGrid).BeginInit();
        quickActionPanel.SuspendLayout();
        actionLayout.SuspendLayout();
        shiftPanel.SuspendLayout();
        SuspendLayout();
        //
        // StaffDashboardForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "StaffDashboardForm";
        Text = "Dashboard nhân viên";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(shiftPanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(showtimeValueLabel, 0, 0);
        statLayout.Controls.Add(soldTicketValueLabel, 1, 0);
        statLayout.Controls.Add(revenueValueLabel, 2, 0);
        statLayout.Controls.Add(waitingTicketValueLabel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // middleLayout
        //
        middleLayout.BackColor = UiStyleHelper.ContentBackground;
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        middleLayout.Controls.Add(schedulePanel, 0, 0);
        middleLayout.Controls.Add(quickActionPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Padding = new Padding(0, 0, 0, 10);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // schedulePanel
        //
        schedulePanel.BackColor = Color.White;
        schedulePanel.BorderStyle = BorderStyle.FixedSingle;
        schedulePanel.Controls.Add(scheduleLayout);
        schedulePanel.Dock = DockStyle.Fill;
        schedulePanel.Margin = new Padding(0, 0, 12, 0);
        schedulePanel.Padding = new Padding(10);
        scheduleLayout.BackColor = Color.White;
        scheduleLayout.ColumnCount = 1;
        scheduleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        scheduleLayout.Controls.Add(CreateCardTitleLabel("Lịch chiếu hôm nay"), 0, 0);
        scheduleLayout.Controls.Add(scheduleGrid, 0, 1);
        scheduleLayout.Dock = DockStyle.Fill;
        scheduleLayout.RowCount = 2;
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(scheduleGrid);
        scheduleGrid.Dock = DockStyle.Fill;
        scheduleGrid.AutoGenerateColumns = false;
        scheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        scheduleGrid.ColumnHeadersHeight = 40;
        scheduleGrid.RowHeadersVisible = false;
        scheduleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 170 });
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 80 });
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Start", DataPropertyName = "Start", HeaderText = "Giờ", FillWeight = 70 });
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Format", DataPropertyName = "Format", HeaderText = "Định dạng", FillWeight = 70 });
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", DataPropertyName = "Price", HeaderText = "Giá vé", FillWeight = 90 });
        scheduleGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 95 });
        //
        // quickActionPanel
        //
        quickActionPanel.BackColor = Color.White;
        quickActionPanel.BorderStyle = BorderStyle.FixedSingle;
        quickActionPanel.Controls.Add(actionLayout);
        quickActionPanel.Dock = DockStyle.Fill;
        quickActionPanel.Padding = new Padding(16);
        actionLayout.BackColor = Color.White;
        actionLayout.ColumnCount = 1;
        actionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        actionLayout.Controls.Add(CreateCardTitleLabel("Thao tác nhanh"), 0, 0);
        actionLayout.Controls.Add(saleButton, 0, 1);
        actionLayout.Controls.Add(checkButton, 0, 2);
        actionLayout.Controls.Add(demoHintLabel, 0, 3);
        actionLayout.Dock = DockStyle.Fill;
        actionLayout.RowCount = 5;
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        saleButton.Dock = DockStyle.Fill;
        saleButton.Margin = new Padding(0, 0, 0, 10);
        saleButton.Text = "Bán vé";
        checkButton.Dock = DockStyle.Fill;
        checkButton.Margin = new Padding(0, 0, 0, 10);
        checkButton.Text = "Kiểm tra vé";
        demoHintLabel.BackColor = UiStyleHelper.SurfaceMuted;
        demoHintLabel.Dock = DockStyle.Fill;
        demoHintLabel.Font = UiStyleHelper.BodyFont(9.5F);
        demoHintLabel.ForeColor = UiStyleHelper.TextMuted;
        demoHintLabel.Padding = new Padding(12);
        demoHintLabel.Text = "Gợi ý demo: bán một vé mới, mở danh sách vé đã bán, sau đó kiểm tra mã vé vừa tạo.";
        demoHintLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // shiftPanel
        //
        shiftPanel.BackColor = Color.White;
        shiftPanel.BorderStyle = BorderStyle.FixedSingle;
        shiftPanel.Controls.Add(shiftLabel);
        shiftPanel.Dock = DockStyle.Fill;
        shiftPanel.Padding = new Padding(14);
        shiftLabel.Dock = DockStyle.Fill;
        shiftLabel.Font = UiStyleHelper.SectionFont(10F);
        shiftLabel.ForeColor = UiStyleHelper.TextDark;
        shiftLabel.Text = "Ca làm việc hôm nay: 08:00 - 16:00     |     Quầy: COUNTER-01     |     Thanh toán khả dụng: Tiền mặt, VNPAY Sandbox";
        shiftLabel.TextAlign = ContentAlignment.MiddleLeft;
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        schedulePanel.ResumeLayout(false);
        scheduleLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)scheduleGrid).EndInit();
        quickActionPanel.ResumeLayout(false);
        actionLayout.ResumeLayout(false);
        shiftPanel.ResumeLayout(false);
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
        var layout = new TableLayoutPanel
        {
            BackColor = Color.White,
            ColumnCount = 1,
            Dock = DockStyle.Fill,
            RowCount = 3
        };
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
