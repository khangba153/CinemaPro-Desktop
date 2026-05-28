using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class TicketCheckForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private Label ticketCodeLabel;
    private TextBox _ticketCodeTextBox;
    private Button checkButton;
    private Button refreshButton;
    private TableLayoutPanel middleLayout;
    private Panel resultPanel;
    private TableLayoutPanel resultLayout;
    private Label _resultTitleLabel;
    private Label _resultNoteLabel;
    private Label _ticketInfoLabel;
    private FlowLayoutPanel resultActionsPanel;
    private Button _confirmButton;
    private Button cancelButton;
    private Panel overviewPanel;
    private TableLayoutPanel overviewLayout;
    private Label overviewTitleLabel;
    private Panel checkedInPanel;
    private Label checkedInValueLabel;
    private Label checkedInTitleLabel;
    private Panel unusedPanel;
    private Label unusedValueLabel;
    private Label unusedTitleLabel;
    private Panel canceledPanel;
    private Label canceledValueLabel;
    private Label canceledTitleLabel;
    private Panel historyPanel;
    private TableLayoutPanel historyLayout;
    private Label historyTitleLabel;
    private DataGridView _historyGrid;
    private DataGridViewTextBoxColumn historyTicketIdColumn;
    private DataGridViewTextBoxColumn historyMovieColumn;
    private DataGridViewTextBoxColumn historySeatsColumn;
    private DataGridViewTextBoxColumn historyShowtimeColumn;
    private DataGridViewTextBoxColumn historyResultColumn;
    private DataGridViewTextBoxColumn historyStaffColumn;
    private DataGridViewTextBoxColumn historyCheckedAtColumn;

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
        ticketCodeLabel = new Label();
        _ticketCodeTextBox = new TextBox();
        checkButton = new Button();
        refreshButton = new Button();
        middleLayout = new TableLayoutPanel();
        resultPanel = new Panel();
        resultLayout = new TableLayoutPanel();
        _resultTitleLabel = new Label();
        _resultNoteLabel = new Label();
        _ticketInfoLabel = new Label();
        resultActionsPanel = new FlowLayoutPanel();
        cancelButton = new Button();
        _confirmButton = new Button();
        overviewPanel = new Panel();
        overviewLayout = new TableLayoutPanel();
        overviewTitleLabel = new Label();
        checkedInPanel = new Panel();
        checkedInValueLabel = new Label();
        checkedInTitleLabel = new Label();
        unusedPanel = new Panel();
        unusedValueLabel = new Label();
        unusedTitleLabel = new Label();
        canceledPanel = new Panel();
        canceledValueLabel = new Label();
        canceledTitleLabel = new Label();
        historyPanel = new Panel();
        historyLayout = new TableLayoutPanel();
        historyTitleLabel = new Label();
        _historyGrid = new DataGridView();
        historyTicketIdColumn = new DataGridViewTextBoxColumn();
        historyMovieColumn = new DataGridViewTextBoxColumn();
        historySeatsColumn = new DataGridViewTextBoxColumn();
        historyShowtimeColumn = new DataGridViewTextBoxColumn();
        historyResultColumn = new DataGridViewTextBoxColumn();
        historyStaffColumn = new DataGridViewTextBoxColumn();
        historyCheckedAtColumn = new DataGridViewTextBoxColumn();
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        middleLayout.SuspendLayout();
        resultPanel.SuspendLayout();
        resultLayout.SuspendLayout();
        resultActionsPanel.SuspendLayout();
        overviewPanel.SuspendLayout();
        overviewLayout.SuspendLayout();
        checkedInPanel.SuspendLayout();
        unusedPanel.SuspendLayout();
        canceledPanel.SuspendLayout();
        historyPanel.SuspendLayout();
        historyLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_historyGrid).BeginInit();
        SuspendLayout();
        //
        // rootLayout
        //
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(historyPanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
        rootLayout.Size = new Size(1100, 620);
        rootLayout.TabIndex = 0;
        //
        // filterPanel
        //
        filterPanel.BackColor = Color.FromArgb(245, 248, 252);
        filterPanel.Controls.Add(ticketCodeLabel);
        filterPanel.Controls.Add(_ticketCodeTextBox);
        filterPanel.Controls.Add(checkButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.Location = new Point(3, 4);
        filterPanel.Margin = new Padding(3, 4, 3, 4);
        filterPanel.Name = "filterPanel";
        filterPanel.Padding = new Padding(0, 11, 0, 11);
        filterPanel.Size = new Size(1094, 68);
        filterPanel.TabIndex = 0;
        filterPanel.WrapContents = false;
        //
        // ticketCodeLabel
        //
        ticketCodeLabel.Font = new Font("Segoe UI", 9.25F);
        ticketCodeLabel.ForeColor = Color.FromArgb(100, 116, 139);
        ticketCodeLabel.Location = new Point(0, 19);
        ticketCodeLabel.Margin = new Padding(0, 8, 11, 0);
        ticketCodeLabel.Name = "ticketCodeLabel";
        ticketCodeLabel.Size = new Size(136, 42);
        ticketCodeLabel.TabIndex = 0;
        ticketCodeLabel.Text = "Nhập mã vé hoặc QR";
        ticketCodeLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // _ticketCodeTextBox
        //
        _ticketCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
        _ticketCodeTextBox.Font = new Font("Segoe UI", 10F);
        _ticketCodeTextBox.Location = new Point(147, 24);
        _ticketCodeTextBox.Margin = new Padding(0, 13, 14, 0);
        _ticketCodeTextBox.Name = "_ticketCodeTextBox";
        _ticketCodeTextBox.PlaceholderText = "Quét mã QR hoặc nhập mã vé...";
        _ticketCodeTextBox.Size = new Size(520, 42);
        _ticketCodeTextBox.TabIndex = 1;
        //
        // checkButton
        //
        checkButton.Location = new Point(681, 22);
        checkButton.Margin = new Padding(0, 11, 14, 0);
        checkButton.Name = "checkButton";
        checkButton.Size = new Size(158, 44);
        checkButton.TabIndex = 2;
        checkButton.Text = "Kiểm tra vé";
        //
        // refreshButton
        //
        refreshButton.Location = new Point(853, 22);
        refreshButton.Margin = new Padding(0, 11, 0, 0);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(124, 44);
        refreshButton.TabIndex = 3;
        refreshButton.Text = "Làm mới";
        //
        // middleLayout
        //
        middleLayout.BackColor = Color.FromArgb(245, 248, 252);
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        middleLayout.Controls.Add(resultPanel, 0, 0);
        middleLayout.Controls.Add(overviewPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Location = new Point(3, 100);
        middleLayout.Margin = new Padding(3, 4, 3, 4);
        middleLayout.Name = "middleLayout";
        middleLayout.Padding = new Padding(0, 0, 0, 13);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        middleLayout.Size = new Size(1094, 366);
        middleLayout.TabIndex = 1;
        //
        // resultPanel
        //
        resultPanel.BackColor = Color.White;
        resultPanel.BorderStyle = BorderStyle.FixedSingle;
        resultPanel.Controls.Add(resultLayout);
        resultPanel.Dock = DockStyle.Fill;
        resultPanel.Location = new Point(0, 0);
        resultPanel.Margin = new Padding(0, 0, 14, 0);
        resultPanel.Name = "resultPanel";
        resultPanel.Padding = new Padding(23, 27, 23, 27);
        resultPanel.Size = new Size(861, 457);
        resultPanel.TabIndex = 0;
        //
        // resultLayout
        //
        resultLayout.BackColor = Color.White;
        resultLayout.ColumnCount = 2;
        resultLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
        resultLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
        resultLayout.Controls.Add(_resultTitleLabel, 0, 0);
        resultLayout.Controls.Add(_resultNoteLabel, 0, 1);
        resultLayout.Controls.Add(_ticketInfoLabel, 1, 0);
        resultLayout.Controls.Add(resultActionsPanel, 0, 2);
        resultLayout.Dock = DockStyle.Fill;
        resultLayout.Location = new Point(23, 27);
        resultLayout.Margin = new Padding(3, 4, 3, 4);
        resultLayout.Name = "resultLayout";
        resultLayout.RowCount = 3;
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        resultLayout.Size = new Size(813, 401);
        resultLayout.TabIndex = 0;
        //
        // _resultTitleLabel
        //
        _resultTitleLabel.Dock = DockStyle.Fill;
        _resultTitleLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        _resultTitleLabel.ForeColor = Color.FromArgb(17, 27, 63);
        _resultTitleLabel.Location = new Point(3, 0);
        _resultTitleLabel.Name = "_resultTitleLabel";
        _resultTitleLabel.Size = new Size(286, 96);
        _resultTitleLabel.TabIndex = 0;
        _resultTitleLabel.Text = "Sẵn sàng kiểm tra";
        _resultTitleLabel.TextAlign = ContentAlignment.BottomCenter;
        //
        // _resultNoteLabel
        //
        _resultNoteLabel.Dock = DockStyle.Fill;
        _resultNoteLabel.Font = new Font("Segoe UI", 10F);
        _resultNoteLabel.ForeColor = Color.FromArgb(100, 116, 139);
        _resultNoteLabel.Location = new Point(3, 96);
        _resultNoteLabel.Name = "_resultNoteLabel";
        _resultNoteLabel.Size = new Size(286, 233);
        _resultNoteLabel.TabIndex = 1;
        _resultNoteLabel.Text = "Nhập mã vé để bắt đầu.";
        _resultNoteLabel.TextAlign = ContentAlignment.TopCenter;
        //
        // _ticketInfoLabel
        //
        _ticketInfoLabel.Dock = DockStyle.Fill;
        _ticketInfoLabel.Font = new Font("Segoe UI", 10.5F);
        _ticketInfoLabel.ForeColor = Color.FromArgb(17, 27, 63);
        _ticketInfoLabel.Location = new Point(295, 0);
        _ticketInfoLabel.Name = "_ticketInfoLabel";
        _ticketInfoLabel.Padding = new Padding(18, 0, 0, 0);
        resultLayout.SetRowSpan(_ticketInfoLabel, 2);
        _ticketInfoLabel.Size = new Size(515, 329);
        _ticketInfoLabel.TabIndex = 2;
        _ticketInfoLabel.Text = "Mã vé demo: TK000001\r\nPhim: Avengers: Endgame\r\nSuất chiếu: 19:30 - 22:32\r\nPhòng: Phòng 2\r\nGhế: B6\r\nTrạng thái: Chưa sử dụng";
        _ticketInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // resultActionsPanel
        //
        resultActionsPanel.BackColor = Color.White;
        resultLayout.SetColumnSpan(resultActionsPanel, 2);
        resultActionsPanel.Controls.Add(cancelButton);
        resultActionsPanel.Controls.Add(_confirmButton);
        resultActionsPanel.Dock = DockStyle.Fill;
        resultActionsPanel.FlowDirection = FlowDirection.RightToLeft;
        resultActionsPanel.Location = new Point(3, 333);
        resultActionsPanel.Margin = new Padding(3, 4, 3, 4);
        resultActionsPanel.Name = "resultActionsPanel";
        resultActionsPanel.Padding = new Padding(0, 13, 0, 0);
        resultActionsPanel.Size = new Size(807, 64);
        resultActionsPanel.TabIndex = 3;
        resultActionsPanel.WrapContents = false;
        //
        // cancelButton
        //
        cancelButton.Location = new Point(670, 13);
        cancelButton.Margin = new Padding(9, 0, 0, 0);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(137, 51);
        cancelButton.TabIndex = 0;
        cancelButton.Text = "Hủy";
        cancelButton.Click += cancelButton_Click_1;
        //
        // _confirmButton
        //
        _confirmButton.Location = new Point(444, 13);
        _confirmButton.Margin = new Padding(9, 0, 0, 0);
        _confirmButton.Name = "_confirmButton";
        _confirmButton.Size = new Size(217, 51);
        _confirmButton.TabIndex = 1;
        _confirmButton.Text = "Xác nhận vào rạp";
        //
        // overviewPanel
        //
        overviewPanel.BackColor = Color.White;
        overviewPanel.BorderStyle = BorderStyle.FixedSingle;
        overviewPanel.Controls.Add(overviewLayout);
        overviewPanel.Dock = DockStyle.Fill;
        overviewPanel.Location = new Point(878, 4);
        overviewPanel.Margin = new Padding(3, 4, 3, 4);
        overviewPanel.Name = "overviewPanel";
        overviewPanel.Padding = new Padding(18, 21, 18, 21);
        overviewPanel.Size = new Size(370, 449);
        overviewPanel.TabIndex = 1;
        //
        // overviewLayout
        //
        overviewLayout.BackColor = Color.White;
        overviewLayout.ColumnCount = 1;
        overviewLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        overviewLayout.Controls.Add(overviewTitleLabel, 0, 0);
        overviewLayout.Controls.Add(checkedInPanel, 0, 1);
        overviewLayout.Controls.Add(unusedPanel, 0, 2);
        overviewLayout.Controls.Add(canceledPanel, 0, 3);
        overviewLayout.Dock = DockStyle.Fill;
        overviewLayout.Location = new Point(18, 21);
        overviewLayout.Margin = new Padding(3, 4, 3, 4);
        overviewLayout.Name = "overviewLayout";
        overviewLayout.RowCount = 5;
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        overviewLayout.Size = new Size(332, 405);
        overviewLayout.TabIndex = 0;
        //
        // overviewTitleLabel
        //
        overviewTitleLabel.Dock = DockStyle.Fill;
        overviewTitleLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        overviewTitleLabel.ForeColor = Color.FromArgb(13, 110, 253);
        overviewTitleLabel.Location = new Point(3, 0);
        overviewTitleLabel.Name = "overviewTitleLabel";
        overviewTitleLabel.Size = new Size(326, 43);
        overviewTitleLabel.TabIndex = 0;
        overviewTitleLabel.Text = "TỔNG QUAN HÔM NAY";
        overviewTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // checkedInPanel
        //
        checkedInPanel.BackColor = Color.FromArgb(248, 250, 252);
        checkedInPanel.BorderStyle = BorderStyle.FixedSingle;
        checkedInPanel.Controls.Add(checkedInValueLabel);
        checkedInPanel.Controls.Add(checkedInTitleLabel);
        checkedInPanel.Dock = DockStyle.Fill;
        checkedInPanel.Location = new Point(0, 48);
        checkedInPanel.Margin = new Padding(0, 5, 0, 11);
        checkedInPanel.Name = "checkedInPanel";
        checkedInPanel.Padding = new Padding(14, 16, 14, 16);
        checkedInPanel.Size = new Size(332, 85);
        checkedInPanel.TabIndex = 1;
        //
        // checkedInValueLabel
        //
        checkedInValueLabel.Dock = DockStyle.Right;
        checkedInValueLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        checkedInValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        checkedInValueLabel.Location = new Point(236, 16);
        checkedInValueLabel.Name = "checkedInValueLabel";
        checkedInValueLabel.Size = new Size(80, 51);
        checkedInValueLabel.TabIndex = 0;
        checkedInValueLabel.Text = "0";
        checkedInValueLabel.TextAlign = ContentAlignment.MiddleRight;
        //
        // checkedInTitleLabel
        //
        checkedInTitleLabel.Dock = DockStyle.Fill;
        checkedInTitleLabel.Font = new Font("Segoe UI", 9.5F);
        checkedInTitleLabel.ForeColor = Color.FromArgb(17, 27, 63);
        checkedInTitleLabel.Location = new Point(14, 16);
        checkedInTitleLabel.Name = "checkedInTitleLabel";
        checkedInTitleLabel.Size = new Size(302, 51);
        checkedInTitleLabel.TabIndex = 1;
        checkedInTitleLabel.Text = "Đã check-in hôm nay";
        checkedInTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // unusedPanel
        //
        unusedPanel.BackColor = Color.FromArgb(248, 250, 252);
        unusedPanel.BorderStyle = BorderStyle.FixedSingle;
        unusedPanel.Controls.Add(unusedValueLabel);
        unusedPanel.Controls.Add(unusedTitleLabel);
        unusedPanel.Dock = DockStyle.Fill;
        unusedPanel.Location = new Point(0, 149);
        unusedPanel.Margin = new Padding(0, 5, 0, 11);
        unusedPanel.Name = "unusedPanel";
        unusedPanel.Padding = new Padding(14, 16, 14, 16);
        unusedPanel.Size = new Size(332, 85);
        unusedPanel.TabIndex = 2;
        //
        // unusedValueLabel
        //
        unusedValueLabel.Dock = DockStyle.Right;
        unusedValueLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        unusedValueLabel.ForeColor = Color.FromArgb(249, 115, 22);
        unusedValueLabel.Location = new Point(236, 16);
        unusedValueLabel.Name = "unusedValueLabel";
        unusedValueLabel.Size = new Size(80, 51);
        unusedValueLabel.TabIndex = 0;
        unusedValueLabel.Text = "0";
        unusedValueLabel.TextAlign = ContentAlignment.MiddleRight;
        //
        // unusedTitleLabel
        //
        unusedTitleLabel.Dock = DockStyle.Fill;
        unusedTitleLabel.Font = new Font("Segoe UI", 9.5F);
        unusedTitleLabel.ForeColor = Color.FromArgb(17, 27, 63);
        unusedTitleLabel.Location = new Point(14, 16);
        unusedTitleLabel.Name = "unusedTitleLabel";
        unusedTitleLabel.Size = new Size(302, 51);
        unusedTitleLabel.TabIndex = 1;
        unusedTitleLabel.Text = "Vé chưa sử dụng";
        unusedTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // canceledPanel
        //
        canceledPanel.BackColor = Color.FromArgb(248, 250, 252);
        canceledPanel.BorderStyle = BorderStyle.FixedSingle;
        canceledPanel.Controls.Add(canceledValueLabel);
        canceledPanel.Controls.Add(canceledTitleLabel);
        canceledPanel.Dock = DockStyle.Fill;
        canceledPanel.Location = new Point(0, 250);
        canceledPanel.Margin = new Padding(0, 5, 0, 11);
        canceledPanel.Name = "canceledPanel";
        canceledPanel.Padding = new Padding(14, 16, 14, 16);
        canceledPanel.Size = new Size(332, 85);
        canceledPanel.TabIndex = 3;
        //
        // canceledValueLabel
        //
        canceledValueLabel.Dock = DockStyle.Right;
        canceledValueLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        canceledValueLabel.ForeColor = Color.FromArgb(239, 68, 68);
        canceledValueLabel.Location = new Point(236, 16);
        canceledValueLabel.Name = "canceledValueLabel";
        canceledValueLabel.Size = new Size(80, 51);
        canceledValueLabel.TabIndex = 0;
        canceledValueLabel.Text = "0";
        canceledValueLabel.TextAlign = ContentAlignment.MiddleRight;
        //
        // canceledTitleLabel
        //
        canceledTitleLabel.Dock = DockStyle.Fill;
        canceledTitleLabel.Font = new Font("Segoe UI", 9.5F);
        canceledTitleLabel.ForeColor = Color.FromArgb(17, 27, 63);
        canceledTitleLabel.Location = new Point(14, 16);
        canceledTitleLabel.Name = "canceledTitleLabel";
        canceledTitleLabel.Size = new Size(302, 51);
        canceledTitleLabel.TabIndex = 1;
        canceledTitleLabel.Text = "Vé đã hủy";
        canceledTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // historyPanel
        //
        historyPanel.BackColor = Color.White;
        historyPanel.BorderStyle = BorderStyle.FixedSingle;
        historyPanel.Controls.Add(historyLayout);
        historyPanel.Dock = DockStyle.Fill;
        historyPanel.Location = new Point(3, 578);
        historyPanel.Margin = new Padding(3, 4, 3, 4);
        historyPanel.Name = "historyPanel";
        historyPanel.Padding = new Padding(11, 13, 11, 13);
        historyPanel.Size = new Size(1094, 166);
        historyPanel.TabIndex = 2;
        //
        // historyLayout
        //
        historyLayout.BackColor = Color.White;
        historyLayout.ColumnCount = 1;
        historyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        historyLayout.Controls.Add(historyTitleLabel, 0, 0);
        historyLayout.Controls.Add(_historyGrid, 0, 1);
        historyLayout.Dock = DockStyle.Fill;
        historyLayout.Location = new Point(11, 13);
        historyLayout.Margin = new Padding(3, 4, 3, 4);
        historyLayout.Name = "historyLayout";
        historyLayout.RowCount = 2;
        historyLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
        historyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        historyLayout.Size = new Size(1070, 138);
        historyLayout.TabIndex = 0;
        //
        // historyTitleLabel
        //
        historyTitleLabel.Dock = DockStyle.Fill;
        historyTitleLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        historyTitleLabel.ForeColor = Color.FromArgb(13, 110, 253);
        historyTitleLabel.Location = new Point(3, 0);
        historyTitleLabel.Name = "historyTitleLabel";
        historyTitleLabel.Size = new Size(1064, 37);
        historyTitleLabel.TabIndex = 0;
        historyTitleLabel.Text = "LỊCH SỬ KIỂM TRA VÉ";
        historyTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // _historyGrid
        //
        _historyGrid.AllowUserToAddRows = false;
        _historyGrid.AllowUserToDeleteRows = false;
        _historyGrid.AllowUserToResizeRows = false;
        _historyGrid.AutoGenerateColumns = false;
        _historyGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _historyGrid.BackgroundColor = Color.White;
        _historyGrid.BorderStyle = BorderStyle.None;
        _historyGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        _historyGrid.ColumnHeadersHeight = 40;
        _historyGrid.Dock = DockStyle.Fill;
        _historyGrid.EnableHeadersVisualStyles = false;
        _historyGrid.Location = new Point(3, 41);
        _historyGrid.Margin = new Padding(3, 4, 3, 4);
        _historyGrid.MultiSelect = false;
        _historyGrid.Name = "_historyGrid";
        _historyGrid.ReadOnly = true;
        _historyGrid.RowHeadersVisible = false;
        _historyGrid.RowHeadersWidth = 51;
        _historyGrid.RowTemplate.Height = 34;
        _historyGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _historyGrid.Size = new Size(1064, 93);
        _historyGrid.TabIndex = 1;
        historyTicketIdColumn.Name = "TicketId";
        historyTicketIdColumn.DataPropertyName = "TicketId";
        historyTicketIdColumn.HeaderText = "Mã vé";
        historyTicketIdColumn.FillWeight = 95F;
        _historyGrid.Columns.Add(historyTicketIdColumn);
        historyMovieColumn.Name = "Movie";
        historyMovieColumn.DataPropertyName = "Movie";
        historyMovieColumn.HeaderText = "Phim";
        historyMovieColumn.FillWeight = 190F;
        _historyGrid.Columns.Add(historyMovieColumn);
        historySeatsColumn.Name = "Seats";
        historySeatsColumn.DataPropertyName = "Seats";
        historySeatsColumn.HeaderText = "Ghế";
        historySeatsColumn.FillWeight = 80F;
        _historyGrid.Columns.Add(historySeatsColumn);
        historyShowtimeColumn.Name = "Showtime";
        historyShowtimeColumn.DataPropertyName = "Showtime";
        historyShowtimeColumn.HeaderText = "Suất chiếu";
        historyShowtimeColumn.FillWeight = 130F;
        _historyGrid.Columns.Add(historyShowtimeColumn);
        historyResultColumn.Name = "Result";
        historyResultColumn.DataPropertyName = "Result";
        historyResultColumn.HeaderText = "Kết quả";
        historyResultColumn.FillWeight = 110F;
        _historyGrid.Columns.Add(historyResultColumn);
        historyStaffColumn.Name = "Staff";
        historyStaffColumn.DataPropertyName = "Staff";
        historyStaffColumn.HeaderText = "Nhân viên";
        historyStaffColumn.FillWeight = 120F;
        _historyGrid.Columns.Add(historyStaffColumn);
        historyCheckedAtColumn.Name = "CheckedAt";
        historyCheckedAtColumn.DataPropertyName = "CheckedAt";
        historyCheckedAtColumn.HeaderText = "Thời gian";
        historyCheckedAtColumn.FillWeight = 150F;
        _historyGrid.Columns.Add(historyCheckedAtColumn);
        //
        // TicketCheckForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "TicketCheckForm";
        Text = "Kiểm tra vé";
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        middleLayout.ResumeLayout(false);
        resultPanel.ResumeLayout(false);
        resultLayout.ResumeLayout(false);
        resultActionsPanel.ResumeLayout(false);
        overviewPanel.ResumeLayout(false);
        overviewLayout.ResumeLayout(false);
        checkedInPanel.ResumeLayout(false);
        unusedPanel.ResumeLayout(false);
        canceledPanel.ResumeLayout(false);
        historyPanel.ResumeLayout(false);
        historyLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_historyGrid).EndInit();
        UiStyleHelper.CompleteDesignerGrid(_historyGrid);
        ResumeLayout(false);
    }
}
