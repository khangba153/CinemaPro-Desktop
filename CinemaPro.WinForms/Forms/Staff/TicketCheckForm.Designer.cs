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
        _confirmButton = new Button();
        cancelButton = new Button();
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
        // TicketCheckForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "TicketCheckForm";
        Text = "Kiểm tra vé";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(middleLayout, 0, 1);
        rootLayout.Controls.Add(historyPanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
        //
        // filterPanel
        //
        filterPanel.BackColor = UiStyleHelper.ContentBackground;
        filterPanel.Controls.Add(ticketCodeLabel);
        filterPanel.Controls.Add(_ticketCodeTextBox);
        filterPanel.Controls.Add(checkButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 8, 0, 8);
        filterPanel.WrapContents = false;
        //
        // ticketCodeLabel
        //
        ticketCodeLabel.Font = UiStyleHelper.SmallFont(9.25F);
        ticketCodeLabel.ForeColor = UiStyleHelper.TextMuted;
        ticketCodeLabel.Margin = new Padding(0, 6, 10, 0);
        ticketCodeLabel.Size = new Size(150, 44);
        ticketCodeLabel.Text = "Nhập mã vé hoặc QR";
        ticketCodeLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // _ticketCodeTextBox
        //
        _ticketCodeTextBox.AutoSize = false;
        _ticketCodeTextBox.BorderStyle = BorderStyle.FixedSingle;
        _ticketCodeTextBox.Font = UiStyleHelper.BodyFont(10F);
        _ticketCodeTextBox.Margin = new Padding(0, 10, 12, 0);
        _ticketCodeTextBox.PlaceholderText = "Quét mã QR hoặc nhập mã vé...";
        _ticketCodeTextBox.Size = new Size(520, 32);
        //
        // checkButton
        //
        checkButton.Margin = new Padding(0, 8, 12, 0);
        checkButton.Size = new Size(170, 36);
        checkButton.Text = "Kiểm tra vé";
        //
        // refreshButton
        //
        refreshButton.Margin = new Padding(0, 8, 0, 0);
        refreshButton.Size = new Size(130, 36);
        refreshButton.Text = "Làm mới";
        //
        // middleLayout
        //
        middleLayout.BackColor = UiStyleHelper.ContentBackground;
        middleLayout.ColumnCount = 2;
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        middleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        middleLayout.Controls.Add(resultPanel, 0, 0);
        middleLayout.Controls.Add(overviewPanel, 1, 0);
        middleLayout.Dock = DockStyle.Fill;
        middleLayout.Padding = new Padding(0, 0, 0, 10);
        middleLayout.RowCount = 1;
        middleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // resultPanel
        //
        resultPanel.BackColor = UiStyleHelper.CardBackground;
        resultPanel.BorderStyle = BorderStyle.FixedSingle;
        resultPanel.Controls.Add(resultLayout);
        resultPanel.Dock = DockStyle.Fill;
        resultPanel.Margin = new Padding(0, 0, 12, 0);
        resultPanel.Padding = new Padding(20);
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
        resultLayout.RowCount = 3;
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        resultLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
        resultLayout.SetColumnSpan(resultActionsPanel, 2);
        //
        // _resultTitleLabel
        //
        _resultTitleLabel.Dock = DockStyle.Fill;
        _resultTitleLabel.Font = UiStyleHelper.TitleFont(20F);
        _resultTitleLabel.ForeColor = UiStyleHelper.TextDark;
        _resultTitleLabel.Text = "Sẵn sàng kiểm tra";
        _resultTitleLabel.TextAlign = ContentAlignment.BottomCenter;
        //
        // _resultNoteLabel
        //
        _resultNoteLabel.Dock = DockStyle.Fill;
        _resultNoteLabel.Font = UiStyleHelper.BodyFont(10F);
        _resultNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        _resultNoteLabel.Text = "Nhập mã vé để bắt đầu.";
        _resultNoteLabel.TextAlign = ContentAlignment.TopCenter;
        //
        // _ticketInfoLabel
        //
        _ticketInfoLabel.Dock = DockStyle.Fill;
        _ticketInfoLabel.Font = UiStyleHelper.BodyFont(10.5F);
        _ticketInfoLabel.ForeColor = UiStyleHelper.TextDark;
        _ticketInfoLabel.Padding = new Padding(16, 0, 0, 0);
        _ticketInfoLabel.Text = "Mã vé demo: TK000001\r\nPhim: Avengers: Endgame\r\nSuất chiếu: 19:30 - 22:32\r\nPhòng: Phòng 2\r\nGhế: B6\r\nTrạng thái: Chưa sử dụng";
        _ticketInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
        resultLayout.SetRowSpan(_ticketInfoLabel, 2);
        //
        // resultActionsPanel
        //
        resultActionsPanel.BackColor = Color.White;
        resultActionsPanel.Controls.Add(cancelButton);
        resultActionsPanel.Controls.Add(_confirmButton);
        resultActionsPanel.Dock = DockStyle.Fill;
        resultActionsPanel.FlowDirection = FlowDirection.RightToLeft;
        resultActionsPanel.Padding = new Padding(0, 10, 0, 0);
        resultActionsPanel.WrapContents = false;
        //
        // _confirmButton
        //
        _confirmButton.Margin = new Padding(8, 0, 0, 0);
        _confirmButton.Size = new Size(190, 38);
        _confirmButton.Text = "Xác nhận vào rạp";
        //
        // cancelButton
        //
        cancelButton.Margin = new Padding(8, 0, 0, 0);
        cancelButton.Size = new Size(120, 38);
        cancelButton.Text = "Hủy";
        //
        // overviewPanel
        //
        overviewPanel.BackColor = UiStyleHelper.CardBackground;
        overviewPanel.BorderStyle = BorderStyle.FixedSingle;
        overviewPanel.Controls.Add(overviewLayout);
        overviewPanel.Dock = DockStyle.Fill;
        overviewPanel.Padding = new Padding(16);
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
        overviewLayout.RowCount = 5;
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
        overviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        overviewTitleLabel.Dock = DockStyle.Fill;
        overviewTitleLabel.Font = UiStyleHelper.SectionFont(10F);
        overviewTitleLabel.ForeColor = UiStyleHelper.Primary;
        overviewTitleLabel.Text = "TỔNG QUAN HÔM NAY";
        overviewTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        checkedInPanel.BackColor = UiStyleHelper.SurfaceMuted;
        checkedInPanel.BorderStyle = BorderStyle.FixedSingle;
        checkedInPanel.Controls.Add(checkedInValueLabel);
        checkedInPanel.Controls.Add(checkedInTitleLabel);
        checkedInPanel.Dock = DockStyle.Fill;
        checkedInPanel.Margin = new Padding(0, 4, 0, 8);
        checkedInPanel.Padding = new Padding(12);
        checkedInTitleLabel.Dock = DockStyle.Fill;
        checkedInTitleLabel.Font = UiStyleHelper.BodyFont(9.5F);
        checkedInTitleLabel.ForeColor = UiStyleHelper.TextDark;
        checkedInTitleLabel.Text = "Đã check-in hôm nay";
        checkedInTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        checkedInValueLabel.Dock = DockStyle.Right;
        checkedInValueLabel.Font = UiStyleHelper.TitleFont(18F);
        checkedInValueLabel.ForeColor = UiStyleHelper.Success;
        checkedInValueLabel.Text = "0";
        checkedInValueLabel.TextAlign = ContentAlignment.MiddleRight;
        checkedInValueLabel.Width = 70;
        unusedPanel.BackColor = UiStyleHelper.SurfaceMuted;
        unusedPanel.BorderStyle = BorderStyle.FixedSingle;
        unusedPanel.Controls.Add(unusedValueLabel);
        unusedPanel.Controls.Add(unusedTitleLabel);
        unusedPanel.Dock = DockStyle.Fill;
        unusedPanel.Margin = new Padding(0, 4, 0, 8);
        unusedPanel.Padding = new Padding(12);
        unusedTitleLabel.Dock = DockStyle.Fill;
        unusedTitleLabel.Font = UiStyleHelper.BodyFont(9.5F);
        unusedTitleLabel.ForeColor = UiStyleHelper.TextDark;
        unusedTitleLabel.Text = "Vé chưa sử dụng";
        unusedTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        unusedValueLabel.Dock = DockStyle.Right;
        unusedValueLabel.Font = UiStyleHelper.TitleFont(18F);
        unusedValueLabel.ForeColor = UiStyleHelper.Warning;
        unusedValueLabel.Text = "0";
        unusedValueLabel.TextAlign = ContentAlignment.MiddleRight;
        unusedValueLabel.Width = 70;
        canceledPanel.BackColor = UiStyleHelper.SurfaceMuted;
        canceledPanel.BorderStyle = BorderStyle.FixedSingle;
        canceledPanel.Controls.Add(canceledValueLabel);
        canceledPanel.Controls.Add(canceledTitleLabel);
        canceledPanel.Dock = DockStyle.Fill;
        canceledPanel.Margin = new Padding(0, 4, 0, 8);
        canceledPanel.Padding = new Padding(12);
        canceledTitleLabel.Dock = DockStyle.Fill;
        canceledTitleLabel.Font = UiStyleHelper.BodyFont(9.5F);
        canceledTitleLabel.ForeColor = UiStyleHelper.TextDark;
        canceledTitleLabel.Text = "Vé đã hủy";
        canceledTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        canceledValueLabel.Dock = DockStyle.Right;
        canceledValueLabel.Font = UiStyleHelper.TitleFont(18F);
        canceledValueLabel.ForeColor = UiStyleHelper.Danger;
        canceledValueLabel.Text = "0";
        canceledValueLabel.TextAlign = ContentAlignment.MiddleRight;
        canceledValueLabel.Width = 70;
        //
        // historyPanel
        //
        historyPanel.BackColor = UiStyleHelper.CardBackground;
        historyPanel.BorderStyle = BorderStyle.FixedSingle;
        historyPanel.Controls.Add(historyLayout);
        historyPanel.Dock = DockStyle.Fill;
        historyPanel.Padding = new Padding(10);
        //
        // historyLayout
        //
        historyLayout.BackColor = Color.White;
        historyLayout.ColumnCount = 1;
        historyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        historyLayout.Controls.Add(historyTitleLabel, 0, 0);
        historyLayout.Controls.Add(_historyGrid, 0, 1);
        historyLayout.Dock = DockStyle.Fill;
        historyLayout.RowCount = 2;
        historyLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        historyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        historyTitleLabel.Dock = DockStyle.Fill;
        historyTitleLabel.Font = UiStyleHelper.SectionFont(10F);
        historyTitleLabel.ForeColor = UiStyleHelper.Primary;
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
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TicketId", DataPropertyName = "TicketId", HeaderText = "Mã vé", FillWeight = 110 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 170 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Seats", DataPropertyName = "Seats", HeaderText = "Ghế", FillWeight = 70 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Showtime", DataPropertyName = "Showtime", HeaderText = "Giờ chiếu", FillWeight = 120 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Result", DataPropertyName = "Result", HeaderText = "Kết quả", FillWeight = 90 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Staff", DataPropertyName = "Staff", HeaderText = "Nhân viên", FillWeight = 110 });
        _historyGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "CheckedAt", DataPropertyName = "CheckedAt", HeaderText = "Thời gian kiểm tra", FillWeight = 140 });
        _historyGrid.Dock = DockStyle.Fill;
        _historyGrid.EnableHeadersVisualStyles = false;
        _historyGrid.MultiSelect = false;
        _historyGrid.ReadOnly = true;
        _historyGrid.RowHeadersVisible = false;
        _historyGrid.RowTemplate.Height = 34;
        _historyGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        ResumeLayout(false);
    }

    private static Label CreateCardTitleLabel(string text) => new()
    {
        Dock = DockStyle.Fill,
        Font = UiStyleHelper.SectionFont(10F),
        ForeColor = UiStyleHelper.Primary,
        Text = text.ToUpperInvariant(),
        TextAlign = ContentAlignment.MiddleLeft
    };

    private static Label CreateOverviewTitleLabel() => CreateCardTitleLabel("Tổng quan hôm nay");

    private static Panel CreateOverviewItemPanel(string label, Label valueLabel, Color accent)
    {
        var panel = new Panel
        {
            BackColor = UiStyleHelper.SurfaceMuted,
            BorderStyle = BorderStyle.FixedSingle,
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 4, 0, 8),
            Padding = new Padding(12)
        };
        valueLabel.Dock = DockStyle.Right;
        valueLabel.Font = UiStyleHelper.TitleFont(18F);
        valueLabel.ForeColor = accent;
        valueLabel.Text = "0";
        valueLabel.TextAlign = ContentAlignment.MiddleRight;
        valueLabel.Width = 70;
        panel.Controls.Add(valueLabel);
        panel.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Font = UiStyleHelper.BodyFont(9.5F),
            ForeColor = UiStyleHelper.TextDark,
            Text = label,
            TextAlign = ContentAlignment.MiddleLeft
        });
        return panel;
    }
}
