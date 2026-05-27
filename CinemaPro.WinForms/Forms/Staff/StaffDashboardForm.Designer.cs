using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class StaffDashboardForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Panel showtimeStatPanel;
    private Label showtimeTitleLabel;
    private Label showtimeValueLabel;
    private Label showtimeNoteLabel;
    private Panel soldTicketStatPanel;
    private Label soldTicketTitleLabel;
    private Label soldTicketValueLabel;
    private Label soldTicketNoteLabel;
    private Panel revenueStatPanel;
    private Label revenueTitleLabel;
    private Label revenueValueLabel;
    private Label revenueNoteLabel;
    private Panel waitingTicketStatPanel;
    private Label waitingTicketTitleLabel;
    private Label waitingTicketValueLabel;
    private Label waitingTicketNoteLabel;
    private TableLayoutPanel middleLayout;
    private Panel schedulePanel;
    private TableLayoutPanel scheduleLayout;
    private Label scheduleTitleLabel;
    private DataGridView scheduleGrid;
    private Panel quickActionPanel;
    private TableLayoutPanel actionLayout;
    private Label quickActionTitleLabel;
    private Button saleButton;
    private Button checkButton;
    private Label demoHintLabel;
    private Panel shiftPanel;
    private Label shiftLabel;

    private DataGridViewTextBoxColumn scheduleGridMovieColumn;
    private DataGridViewTextBoxColumn scheduleGridRoomColumn;
    private DataGridViewTextBoxColumn scheduleGridStartColumn;
    private DataGridViewTextBoxColumn scheduleGridFormatColumn;
    private DataGridViewTextBoxColumn scheduleGridPriceColumn;
    private DataGridViewTextBoxColumn scheduleGridStatusColumn;
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
        scheduleGridMovieColumn = new DataGridViewTextBoxColumn();
        scheduleGridRoomColumn = new DataGridViewTextBoxColumn();
        scheduleGridStartColumn = new DataGridViewTextBoxColumn();
        scheduleGridFormatColumn = new DataGridViewTextBoxColumn();
        scheduleGridPriceColumn = new DataGridViewTextBoxColumn();
        scheduleGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        statLayout = new TableLayoutPanel();
        showtimeStatPanel = new Panel();
        showtimeTitleLabel = new Label();
        showtimeValueLabel = new Label();
        showtimeNoteLabel = new Label();
        soldTicketStatPanel = new Panel();
        soldTicketTitleLabel = new Label();
        soldTicketValueLabel = new Label();
        soldTicketNoteLabel = new Label();
        revenueStatPanel = new Panel();
        revenueTitleLabel = new Label();
        revenueValueLabel = new Label();
        revenueNoteLabel = new Label();
        waitingTicketStatPanel = new Panel();
        waitingTicketTitleLabel = new Label();
        waitingTicketValueLabel = new Label();
        waitingTicketNoteLabel = new Label();
        middleLayout = new TableLayoutPanel();
        schedulePanel = new Panel();
        scheduleLayout = new TableLayoutPanel();
        scheduleTitleLabel = new Label();
        scheduleGrid = new DataGridView();
        quickActionPanel = new Panel();
        actionLayout = new TableLayoutPanel();
        quickActionTitleLabel = new Label();
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
        showtimeStatPanel.SuspendLayout();
        soldTicketStatPanel.SuspendLayout();
        revenueStatPanel.SuspendLayout();
        waitingTicketStatPanel.SuspendLayout();
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
        statLayout.Controls.Add(showtimeStatPanel, 0, 0);
        statLayout.Controls.Add(soldTicketStatPanel, 1, 0);
        statLayout.Controls.Add(revenueStatPanel, 2, 0);
        statLayout.Controls.Add(waitingTicketStatPanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // showtimeStatPanel
        //
        showtimeStatPanel.BackColor = Color.White;
        showtimeStatPanel.BorderStyle = BorderStyle.FixedSingle;
        showtimeStatPanel.Controls.Add(showtimeNoteLabel);
        showtimeStatPanel.Controls.Add(showtimeValueLabel);
        showtimeStatPanel.Controls.Add(showtimeTitleLabel);
        showtimeStatPanel.Dock = DockStyle.Fill;
        showtimeStatPanel.Margin = new Padding(0, 0, 12, 0);
        showtimeStatPanel.Padding = new Padding(16, 12, 16, 12);
        showtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        showtimeTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        showtimeTitleLabel.Location = new Point(16, 12);
        showtimeTitleLabel.Size = new Size(210, 22);
        showtimeTitleLabel.Text = "Suất chiếu hôm nay";
        showtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        showtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeValueLabel.Font = UiStyleHelper.TitleFont(17F);
        showtimeValueLabel.ForeColor = UiStyleHelper.Primary;
        showtimeValueLabel.Location = new Point(16, 36);
        showtimeValueLabel.Size = new Size(210, 32);
        showtimeValueLabel.Text = "8";
        showtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        showtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        showtimeNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        showtimeNoteLabel.Location = new Point(16, 68);
        showtimeNoteLabel.Size = new Size(210, 22);
        showtimeNoteLabel.Text = "Các phòng đang vận hành";
        showtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // soldTicketStatPanel
        //
        soldTicketStatPanel.BackColor = Color.White;
        soldTicketStatPanel.BorderStyle = BorderStyle.FixedSingle;
        soldTicketStatPanel.Controls.Add(soldTicketNoteLabel);
        soldTicketStatPanel.Controls.Add(soldTicketValueLabel);
        soldTicketStatPanel.Controls.Add(soldTicketTitleLabel);
        soldTicketStatPanel.Dock = DockStyle.Fill;
        soldTicketStatPanel.Margin = new Padding(0, 0, 12, 0);
        soldTicketStatPanel.Padding = new Padding(16, 12, 16, 12);
        soldTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        soldTicketTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        soldTicketTitleLabel.Location = new Point(16, 12);
        soldTicketTitleLabel.Size = new Size(210, 22);
        soldTicketTitleLabel.Text = "Vé đã bán trong ca";
        soldTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        soldTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketValueLabel.Font = UiStyleHelper.TitleFont(17F);
        soldTicketValueLabel.ForeColor = UiStyleHelper.Success;
        soldTicketValueLabel.Location = new Point(16, 36);
        soldTicketValueLabel.Size = new Size(210, 32);
        soldTicketValueLabel.Text = "31";
        soldTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        soldTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        soldTicketNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        soldTicketNoteLabel.Location = new Point(16, 68);
        soldTicketNoteLabel.Size = new Size(210, 22);
        soldTicketNoteLabel.Text = "Dữ liệu demo trong phiên";
        soldTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // revenueStatPanel
        //
        revenueStatPanel.BackColor = Color.White;
        revenueStatPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueStatPanel.Controls.Add(revenueNoteLabel);
        revenueStatPanel.Controls.Add(revenueValueLabel);
        revenueStatPanel.Controls.Add(revenueTitleLabel);
        revenueStatPanel.Dock = DockStyle.Fill;
        revenueStatPanel.Margin = new Padding(0, 0, 12, 0);
        revenueStatPanel.Padding = new Padding(16, 12, 16, 12);
        revenueTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        revenueTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueTitleLabel.Location = new Point(16, 12);
        revenueTitleLabel.Size = new Size(210, 22);
        revenueTitleLabel.Text = "Doanh thu trong ca";
        revenueTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueValueLabel.Font = UiStyleHelper.TitleFont(14F);
        revenueValueLabel.ForeColor = UiStyleHelper.Warning;
        revenueValueLabel.Location = new Point(16, 36);
        revenueValueLabel.Size = new Size(210, 32);
        revenueValueLabel.Text = "2.790.000 đ";
        revenueValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        revenueNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        revenueNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        revenueNoteLabel.Location = new Point(16, 68);
        revenueNoteLabel.Size = new Size(210, 22);
        revenueNoteLabel.Text = "Tính theo vé đã bán";
        revenueNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // waitingTicketStatPanel
        //
        waitingTicketStatPanel.BackColor = Color.White;
        waitingTicketStatPanel.BorderStyle = BorderStyle.FixedSingle;
        waitingTicketStatPanel.Controls.Add(waitingTicketNoteLabel);
        waitingTicketStatPanel.Controls.Add(waitingTicketValueLabel);
        waitingTicketStatPanel.Controls.Add(waitingTicketTitleLabel);
        waitingTicketStatPanel.Dock = DockStyle.Fill;
        waitingTicketStatPanel.Margin = new Padding(0);
        waitingTicketStatPanel.Padding = new Padding(16, 12, 16, 12);
        waitingTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        waitingTicketTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        waitingTicketTitleLabel.Location = new Point(16, 12);
        waitingTicketTitleLabel.Size = new Size(210, 22);
        waitingTicketTitleLabel.Text = "Vé chờ kiểm tra";
        waitingTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        waitingTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketValueLabel.Font = UiStyleHelper.TitleFont(17F);
        waitingTicketValueLabel.ForeColor = UiStyleHelper.Accent;
        waitingTicketValueLabel.Location = new Point(16, 36);
        waitingTicketValueLabel.Size = new Size(210, 32);
        waitingTicketValueLabel.Text = "12";
        waitingTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        waitingTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        waitingTicketNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        waitingTicketNoteLabel.Location = new Point(16, 68);
        waitingTicketNoteLabel.Size = new Size(210, 22);
        waitingTicketNoteLabel.Text = "Sẵn sàng check-in";
        waitingTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        scheduleLayout.Controls.Add(scheduleTitleLabel, 0, 0);
        scheduleLayout.Controls.Add(scheduleGrid, 0, 1);
        scheduleLayout.Dock = DockStyle.Fill;
        scheduleLayout.RowCount = 2;
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(scheduleTitleLabel, "LỊCH CHIẾU HÔM NAY");
        ConfigureGrid(scheduleGrid);
        scheduleGrid.Dock = DockStyle.Fill;
        scheduleGrid.AutoGenerateColumns = false;
        scheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        scheduleGrid.ColumnHeadersHeight = 40;
        scheduleGrid.RowHeadersVisible = false;
        scheduleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        scheduleGridMovieColumn.Name = "Movie";
        scheduleGridMovieColumn.DataPropertyName = "Movie";
        scheduleGridMovieColumn.HeaderText = "Phim";
        scheduleGridMovieColumn.FillWeight = 170F;
        scheduleGrid.Columns.Add(scheduleGridMovieColumn);
        scheduleGridRoomColumn.Name = "Room";
        scheduleGridRoomColumn.DataPropertyName = "Room";
        scheduleGridRoomColumn.HeaderText = "Phòng";
        scheduleGridRoomColumn.FillWeight = 80F;
        scheduleGrid.Columns.Add(scheduleGridRoomColumn);
        scheduleGridStartColumn.Name = "Start";
        scheduleGridStartColumn.DataPropertyName = "Start";
        scheduleGridStartColumn.HeaderText = "Giờ";
        scheduleGridStartColumn.FillWeight = 70F;
        scheduleGrid.Columns.Add(scheduleGridStartColumn);
        scheduleGridFormatColumn.Name = "Format";
        scheduleGridFormatColumn.DataPropertyName = "Format";
        scheduleGridFormatColumn.HeaderText = "Định dạng";
        scheduleGridFormatColumn.FillWeight = 70F;
        scheduleGrid.Columns.Add(scheduleGridFormatColumn);
        scheduleGridPriceColumn.Name = "Price";
        scheduleGridPriceColumn.DataPropertyName = "Price";
        scheduleGridPriceColumn.HeaderText = "Giá vé";
        scheduleGridPriceColumn.FillWeight = 90F;
        scheduleGrid.Columns.Add(scheduleGridPriceColumn);
        scheduleGridStatusColumn.Name = "Status";
        scheduleGridStatusColumn.DataPropertyName = "Status";
        scheduleGridStatusColumn.HeaderText = "Trạng thái";
        scheduleGridStatusColumn.FillWeight = 95F;
        scheduleGrid.Columns.Add(scheduleGridStatusColumn);
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
        actionLayout.Controls.Add(quickActionTitleLabel, 0, 0);
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
        StyleCardTitle(quickActionTitleLabel, "THAO TÁC NHANH");
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
        showtimeStatPanel.ResumeLayout(false);
        soldTicketStatPanel.ResumeLayout(false);
        revenueStatPanel.ResumeLayout(false);
        waitingTicketStatPanel.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        schedulePanel.ResumeLayout(false);
        scheduleLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)scheduleGrid).EndInit();
        quickActionPanel.ResumeLayout(false);
        actionLayout.ResumeLayout(false);
        shiftPanel.ResumeLayout(false);
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
}
