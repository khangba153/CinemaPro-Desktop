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
        rootLayout = new TableLayoutPanel();
        statLayout = new TableLayoutPanel();
        showtimeStatPanel = new Panel();
        showtimeNoteLabel = new Label();
        showtimeValueLabel = new Label();
        showtimeTitleLabel = new Label();
        soldTicketStatPanel = new Panel();
        soldTicketNoteLabel = new Label();
        soldTicketValueLabel = new Label();
        soldTicketTitleLabel = new Label();
        revenueStatPanel = new Panel();
        revenueNoteLabel = new Label();
        revenueValueLabel = new Label();
        revenueTitleLabel = new Label();
        waitingTicketStatPanel = new Panel();
        waitingTicketNoteLabel = new Label();
        waitingTicketValueLabel = new Label();
        waitingTicketTitleLabel = new Label();
        middleLayout = new TableLayoutPanel();
        schedulePanel = new Panel();
        scheduleLayout = new TableLayoutPanel();
        scheduleTitleLabel = new Label();
        scheduleGrid = new DataGridView();
        scheduleGridMovieColumn = new DataGridViewTextBoxColumn();
        scheduleGridRoomColumn = new DataGridViewTextBoxColumn();
        scheduleGridStartColumn = new DataGridViewTextBoxColumn();
        scheduleGridFormatColumn = new DataGridViewTextBoxColumn();
        scheduleGridPriceColumn = new DataGridViewTextBoxColumn();
        scheduleGridStatusColumn = new DataGridViewTextBoxColumn();
        quickActionPanel = new Panel();
        actionLayout = new TableLayoutPanel();
        quickActionTitleLabel = new Label();
        saleButton = new Button();
        checkButton = new Button();
        demoHintLabel = new Label();
        shiftPanel = new Panel();
        shiftLabel = new Label();
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
        // rootLayout
        // 
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(shiftPanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
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
        statLayout.Controls.Add(showtimeStatPanel, 0, 0);
        statLayout.Controls.Add(soldTicketStatPanel, 1, 0);
        statLayout.Controls.Add(revenueStatPanel, 2, 0);
        statLayout.Controls.Add(waitingTicketStatPanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Location = new Point(3, 4);
        statLayout.Margin = new Padding(3, 4, 3, 4);
        statLayout.Name = "statLayout";
        statLayout.Padding = new Padding(0, 0, 0, 13);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        statLayout.Size = new Size(1094, 131);
        statLayout.TabIndex = 0;
        // 
        // showtimeStatPanel
        // 
        showtimeStatPanel.BackColor = Color.White;
        showtimeStatPanel.BorderStyle = BorderStyle.FixedSingle;
        showtimeStatPanel.Controls.Add(showtimeNoteLabel);
        showtimeStatPanel.Controls.Add(showtimeValueLabel);
        showtimeStatPanel.Controls.Add(showtimeTitleLabel);
        showtimeStatPanel.Dock = DockStyle.Fill;
        showtimeStatPanel.Location = new Point(0, 0);
        showtimeStatPanel.Margin = new Padding(0, 0, 14, 0);
        showtimeStatPanel.Name = "showtimeStatPanel";
        showtimeStatPanel.Padding = new Padding(18, 16, 18, 16);
        showtimeStatPanel.Size = new Size(298, 118);
        showtimeStatPanel.TabIndex = 0;
        // 
        // showtimeNoteLabel
        // 
        showtimeNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeNoteLabel.Font = new Font("Segoe UI", 8.75F);
        showtimeNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        showtimeNoteLabel.Location = new Point(18, 91);
        showtimeNoteLabel.Name = "showtimeNoteLabel";
        showtimeNoteLabel.Size = new Size(308, 29);
        showtimeNoteLabel.TabIndex = 0;
        showtimeNoteLabel.Text = "Các phòng đang vận hành";
        showtimeNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // showtimeValueLabel
        // 
        showtimeValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        showtimeValueLabel.ForeColor = Color.FromArgb(13, 110, 253);
        showtimeValueLabel.Location = new Point(18, 48);
        showtimeValueLabel.Name = "showtimeValueLabel";
        showtimeValueLabel.Size = new Size(308, 43);
        showtimeValueLabel.TabIndex = 1;
        showtimeValueLabel.Text = "8";
        showtimeValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // showtimeTitleLabel
        // 
        showtimeTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        showtimeTitleLabel.Font = new Font("Segoe UI", 9.5F);
        showtimeTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        showtimeTitleLabel.Location = new Point(18, 16);
        showtimeTitleLabel.Name = "showtimeTitleLabel";
        showtimeTitleLabel.Size = new Size(308, 29);
        showtimeTitleLabel.TabIndex = 2;
        showtimeTitleLabel.Text = "Suất chiếu hôm nay";
        showtimeTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // soldTicketStatPanel
        // 
        soldTicketStatPanel.BackColor = Color.White;
        soldTicketStatPanel.BorderStyle = BorderStyle.FixedSingle;
        soldTicketStatPanel.Controls.Add(soldTicketNoteLabel);
        soldTicketStatPanel.Controls.Add(soldTicketValueLabel);
        soldTicketStatPanel.Controls.Add(soldTicketTitleLabel);
        soldTicketStatPanel.Dock = DockStyle.Fill;
        soldTicketStatPanel.Location = new Point(312, 0);
        soldTicketStatPanel.Margin = new Padding(0, 0, 14, 0);
        soldTicketStatPanel.Name = "soldTicketStatPanel";
        soldTicketStatPanel.Padding = new Padding(18, 16, 18, 16);
        soldTicketStatPanel.Size = new Size(298, 118);
        soldTicketStatPanel.TabIndex = 1;
        // 
        // soldTicketNoteLabel
        // 
        soldTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketNoteLabel.Font = new Font("Segoe UI", 8.75F);
        soldTicketNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        soldTicketNoteLabel.Location = new Point(18, 91);
        soldTicketNoteLabel.Name = "soldTicketNoteLabel";
        soldTicketNoteLabel.Size = new Size(308, 29);
        soldTicketNoteLabel.TabIndex = 0;
        soldTicketNoteLabel.Text = "Dữ liệu demo trong phiên";
        soldTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // soldTicketValueLabel
        // 
        soldTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        soldTicketValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        soldTicketValueLabel.Location = new Point(18, 48);
        soldTicketValueLabel.Name = "soldTicketValueLabel";
        soldTicketValueLabel.Size = new Size(308, 43);
        soldTicketValueLabel.TabIndex = 1;
        soldTicketValueLabel.Text = "31";
        soldTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // soldTicketTitleLabel
        // 
        soldTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        soldTicketTitleLabel.Font = new Font("Segoe UI", 9.5F);
        soldTicketTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        soldTicketTitleLabel.Location = new Point(18, 16);
        soldTicketTitleLabel.Name = "soldTicketTitleLabel";
        soldTicketTitleLabel.Size = new Size(308, 29);
        soldTicketTitleLabel.TabIndex = 2;
        soldTicketTitleLabel.Text = "Vé đã bán trong ca";
        soldTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // revenueStatPanel
        // 
        revenueStatPanel.BackColor = Color.White;
        revenueStatPanel.BorderStyle = BorderStyle.FixedSingle;
        revenueStatPanel.Controls.Add(revenueNoteLabel);
        revenueStatPanel.Controls.Add(revenueValueLabel);
        revenueStatPanel.Controls.Add(revenueTitleLabel);
        revenueStatPanel.Dock = DockStyle.Fill;
        revenueStatPanel.Location = new Point(624, 0);
        revenueStatPanel.Margin = new Padding(0, 0, 14, 0);
        revenueStatPanel.Name = "revenueStatPanel";
        revenueStatPanel.Padding = new Padding(18, 16, 18, 16);
        revenueStatPanel.Size = new Size(298, 118);
        revenueStatPanel.TabIndex = 2;
        // 
        // revenueNoteLabel
        // 
        revenueNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueNoteLabel.Font = new Font("Segoe UI", 8.75F);
        revenueNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        revenueNoteLabel.Location = new Point(18, 91);
        revenueNoteLabel.Name = "revenueNoteLabel";
        revenueNoteLabel.Size = new Size(308, 29);
        revenueNoteLabel.TabIndex = 0;
        revenueNoteLabel.Text = "Tính theo vé đã bán";
        revenueNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // revenueValueLabel
        // 
        revenueValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueValueLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        revenueValueLabel.ForeColor = Color.FromArgb(249, 115, 22);
        revenueValueLabel.Location = new Point(18, 48);
        revenueValueLabel.Name = "revenueValueLabel";
        revenueValueLabel.Size = new Size(308, 43);
        revenueValueLabel.TabIndex = 1;
        revenueValueLabel.Text = "2.790.000 đ";
        revenueValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // revenueTitleLabel
        // 
        revenueTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        revenueTitleLabel.Font = new Font("Segoe UI", 9.5F);
        revenueTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        revenueTitleLabel.Location = new Point(18, 16);
        revenueTitleLabel.Name = "revenueTitleLabel";
        revenueTitleLabel.Size = new Size(308, 29);
        revenueTitleLabel.TabIndex = 2;
        revenueTitleLabel.Text = "Doanh thu trong ca";
        revenueTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // waitingTicketStatPanel
        // 
        waitingTicketStatPanel.BackColor = Color.White;
        waitingTicketStatPanel.BorderStyle = BorderStyle.FixedSingle;
        waitingTicketStatPanel.Controls.Add(waitingTicketNoteLabel);
        waitingTicketStatPanel.Controls.Add(waitingTicketValueLabel);
        waitingTicketStatPanel.Controls.Add(waitingTicketTitleLabel);
        waitingTicketStatPanel.Dock = DockStyle.Fill;
        waitingTicketStatPanel.Location = new Point(936, 0);
        waitingTicketStatPanel.Margin = new Padding(0);
        waitingTicketStatPanel.Name = "waitingTicketStatPanel";
        waitingTicketStatPanel.Padding = new Padding(18, 16, 18, 16);
        waitingTicketStatPanel.Size = new Size(315, 118);
        waitingTicketStatPanel.TabIndex = 3;
        // 
        // waitingTicketNoteLabel
        // 
        waitingTicketNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketNoteLabel.Font = new Font("Segoe UI", 8.75F);
        waitingTicketNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        waitingTicketNoteLabel.Location = new Point(18, 91);
        waitingTicketNoteLabel.Name = "waitingTicketNoteLabel";
        waitingTicketNoteLabel.Size = new Size(324, 29);
        waitingTicketNoteLabel.TabIndex = 0;
        waitingTicketNoteLabel.Text = "Sẵn sàng check-in";
        waitingTicketNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // waitingTicketValueLabel
        // 
        waitingTicketValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketValueLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
        waitingTicketValueLabel.ForeColor = Color.FromArgb(124, 58, 237);
        waitingTicketValueLabel.Location = new Point(18, 48);
        waitingTicketValueLabel.Name = "waitingTicketValueLabel";
        waitingTicketValueLabel.Size = new Size(324, 43);
        waitingTicketValueLabel.TabIndex = 1;
        waitingTicketValueLabel.Text = "12";
        waitingTicketValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // waitingTicketTitleLabel
        // 
        waitingTicketTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        waitingTicketTitleLabel.Font = new Font("Segoe UI", 9.5F);
        waitingTicketTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        waitingTicketTitleLabel.Location = new Point(18, 16);
        waitingTicketTitleLabel.Name = "waitingTicketTitleLabel";
        waitingTicketTitleLabel.Size = new Size(324, 29);
        waitingTicketTitleLabel.TabIndex = 2;
        waitingTicketTitleLabel.Text = "Vé chờ kiểm tra";
        waitingTicketTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // middleLayout
        // 
        middleLayout.BackColor = Color.FromArgb(245, 248, 252);
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        middleLayout.Controls.Add(schedulePanel, 0, 0);
        middleLayout.Controls.Add(quickActionPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Location = new Point(3, 143);
        middleLayout.Margin = new Padding(3, 4, 3, 4);
        middleLayout.Name = "middleLayout";
        middleLayout.Padding = new Padding(0, 0, 0, 13);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        middleLayout.Size = new Size(1094, 360);
        middleLayout.TabIndex = 1;
        // 
        // schedulePanel
        // 
        schedulePanel.BackColor = Color.White;
        schedulePanel.BorderStyle = BorderStyle.FixedSingle;
        schedulePanel.Controls.Add(scheduleLayout);
        schedulePanel.Dock = DockStyle.Fill;
        schedulePanel.Location = new Point(0, 0);
        schedulePanel.Margin = new Padding(0, 0, 14, 0);
        schedulePanel.Name = "schedulePanel";
        schedulePanel.Padding = new Padding(11, 13, 11, 13);
        schedulePanel.Size = new Size(836, 555);
        schedulePanel.TabIndex = 0;
        // 
        // scheduleLayout
        // 
        scheduleLayout.BackColor = Color.White;
        scheduleLayout.ColumnCount = 1;
        scheduleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        scheduleLayout.Controls.Add(scheduleTitleLabel, 0, 0);
        scheduleLayout.Controls.Add(scheduleGrid, 0, 1);
        scheduleLayout.Dock = DockStyle.Fill;
        scheduleLayout.Location = new Point(11, 13);
        scheduleLayout.Margin = new Padding(3, 4, 3, 4);
        scheduleLayout.Name = "scheduleLayout";
        scheduleLayout.RowCount = 2;
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        scheduleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        scheduleLayout.Size = new Size(812, 527);
        scheduleLayout.TabIndex = 0;
        // 
        // scheduleTitleLabel
        // 
        scheduleTitleLabel.Location = new Point(3, 0);
        scheduleTitleLabel.Name = "scheduleTitleLabel";
        scheduleTitleLabel.Size = new Size(110, 31);
        scheduleTitleLabel.TabIndex = 0;
        // 
        // scheduleGrid
        // 
        scheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        scheduleGrid.BackgroundColor = Color.White;
        scheduleGrid.ColumnHeadersHeight = 40;
        scheduleGrid.Dock = DockStyle.Fill;
        scheduleGrid.Location = new Point(3, 44);
        scheduleGrid.Margin = new Padding(3, 4, 3, 4);
        scheduleGrid.Name = "scheduleGrid";
        scheduleGrid.RowHeadersVisible = false;
        scheduleGrid.RowHeadersWidth = 51;
        scheduleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        scheduleGrid.Size = new Size(806, 479);
        scheduleGrid.TabIndex = 1;
        ConfigureGrid(scheduleGrid);
        ConfigureColumn(scheduleGridMovieColumn, "Movie", "Phim", 180F);
        ConfigureColumn(scheduleGridRoomColumn, "Room", "Phòng", 90F);
        ConfigureColumn(scheduleGridStartColumn, "Start", "Bắt đầu", 80F);
        ConfigureColumn(scheduleGridFormatColumn, "Format", "Định dạng", 80F);
        ConfigureColumn(scheduleGridPriceColumn, "Price", "Giá vé", 95F);
        ConfigureColumn(scheduleGridStatusColumn, "Status", "Trạng thái", 100F);
        scheduleGrid.Columns.AddRange(scheduleGridMovieColumn, scheduleGridRoomColumn, scheduleGridStartColumn, scheduleGridFormatColumn, scheduleGridPriceColumn, scheduleGridStatusColumn);
        // 
        // quickActionPanel
        // 
        quickActionPanel.BackColor = Color.White;
        quickActionPanel.BorderStyle = BorderStyle.FixedSingle;
        quickActionPanel.Controls.Add(actionLayout);
        quickActionPanel.Dock = DockStyle.Fill;
        quickActionPanel.Location = new Point(853, 4);
        quickActionPanel.Margin = new Padding(3, 4, 3, 4);
        quickActionPanel.Name = "quickActionPanel";
        quickActionPanel.Padding = new Padding(18, 21, 18, 21);
        quickActionPanel.Size = new Size(395, 547);
        quickActionPanel.TabIndex = 1;
        // 
        // actionLayout
        // 
        actionLayout.BackColor = Color.White;
        actionLayout.ColumnCount = 1;
        actionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        actionLayout.Controls.Add(quickActionTitleLabel, 0, 0);
        actionLayout.Controls.Add(saleButton, 0, 1);
        actionLayout.Controls.Add(checkButton, 0, 2);
        actionLayout.Controls.Add(demoHintLabel, 0, 3);
        actionLayout.Dock = DockStyle.Fill;
        actionLayout.Location = new Point(18, 21);
        actionLayout.Margin = new Padding(3, 4, 3, 4);
        actionLayout.Name = "actionLayout";
        actionLayout.RowCount = 5;
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
        actionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        actionLayout.Size = new Size(357, 503);
        actionLayout.TabIndex = 0;
        // 
        // quickActionTitleLabel
        // 
        quickActionTitleLabel.Location = new Point(3, 0);
        quickActionTitleLabel.Name = "quickActionTitleLabel";
        quickActionTitleLabel.Size = new Size(21, 31);
        quickActionTitleLabel.TabIndex = 0;
        // 
        // saleButton
        // 
        saleButton.Dock = DockStyle.Fill;
        saleButton.Location = new Point(0, 45);
        saleButton.Margin = new Padding(0, 0, 0, 13);
        saleButton.Name = "saleButton";
        saleButton.Size = new Size(357, 59);
        saleButton.TabIndex = 1;
        saleButton.Text = "Bán vé";
        // 
        // checkButton
        // 
        checkButton.Dock = DockStyle.Fill;
        checkButton.Location = new Point(0, 117);
        checkButton.Margin = new Padding(0, 0, 0, 13);
        checkButton.Name = "checkButton";
        checkButton.Size = new Size(357, 59);
        checkButton.TabIndex = 2;
        checkButton.Text = "Kiểm tra vé";
        // 
        // demoHintLabel
        // 
        demoHintLabel.BackColor = Color.FromArgb(248, 250, 252);
        demoHintLabel.Dock = DockStyle.Fill;
        demoHintLabel.Font = new Font("Segoe UI", 9.5F);
        demoHintLabel.ForeColor = Color.FromArgb(100, 116, 139);
        demoHintLabel.Location = new Point(3, 189);
        demoHintLabel.Name = "demoHintLabel";
        demoHintLabel.Padding = new Padding(14, 16, 14, 16);
        demoHintLabel.Size = new Size(351, 125);
        demoHintLabel.TabIndex = 3;
        demoHintLabel.Text = "Gợi ý demo: bán một vé mới, mở danh sách vé đã bán, sau đó kiểm tra mã vé vừa tạo.";
        demoHintLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // shiftPanel
        // 
        shiftPanel.BackColor = Color.White;
        shiftPanel.BorderStyle = BorderStyle.FixedSingle;
        shiftPanel.Controls.Add(shiftLabel);
        shiftPanel.Dock = DockStyle.Fill;
        shiftPanel.Location = new Point(3, 719);
        shiftPanel.Margin = new Padding(3, 4, 3, 4);
        shiftPanel.Name = "shiftPanel";
        shiftPanel.Padding = new Padding(16, 19, 16, 19);
        shiftPanel.Size = new Size(1094, 104);
        shiftPanel.TabIndex = 2;
        // 
        // shiftLabel
        // 
        shiftLabel.Dock = DockStyle.Fill;
        shiftLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        shiftLabel.ForeColor = Color.FromArgb(17, 27, 63);
        shiftLabel.Location = new Point(16, 19);
        shiftLabel.Name = "shiftLabel";
        shiftLabel.Size = new Size(1060, 64);
        shiftLabel.TabIndex = 0;
        shiftLabel.Text = "Ca làm việc hôm nay: 08:00 - 16:00     |     Quầy: COUNTER-01     |     Thanh toán khả dụng: Tiền mặt, VNPAY Sandbox";
        shiftLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // StaffDashboardForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "StaffDashboardForm";
        Text = "Dashboard nhân viên";
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
        UiStyleHelper.CompleteDesignerGrid(scheduleGrid);
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

    private static void ConfigureColumn(DataGridViewTextBoxColumn column, string dataPropertyName, string headerText, float fillWeight)
    {
        column.Name = dataPropertyName;
        column.DataPropertyName = dataPropertyName;
        column.HeaderText = headerText;
        column.FillWeight = fillWeight;
    }
}
