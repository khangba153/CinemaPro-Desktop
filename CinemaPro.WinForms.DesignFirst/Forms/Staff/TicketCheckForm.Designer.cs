namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

partial class TicketCheckForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel scanPanel = null!;
    private Label scanLabel = null!;
    private TextBox ticketCodeTextBox = null!;
    private Button checkButton = null!;
    private Button resetButton = null!;
    private Panel resultPanel = null!;
    private Label resultTitleLabel = null!;
    private Label resultDetailLabel = null!;
    private Button confirmEntryButton = null!;
    private Panel statsPanel = null!;
    private Label statsTitleLabel = null!;
    private Label unusedTitleLabel = null!;
    private Label unusedValueLabel = null!;
    private Label usedTitleLabel = null!;
    private Label usedValueLabel = null!;
    private Label demoCodeLabel = null!;
    private Panel historyPanel = null!;
    private Label historyTitleLabel = null!;
    private DataGridView historyGrid = null!;
    private DataGridViewTextBoxColumn colTime = null!;
    private DataGridViewTextBoxColumn colCode = null!;
    private DataGridViewTextBoxColumn colResult = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        scanPanel = new Panel();
        resetButton = new Button();
        checkButton = new Button();
        ticketCodeTextBox = new TextBox();
        scanLabel = new Label();
        resultPanel = new Panel();
        confirmEntryButton = new Button();
        resultDetailLabel = new Label();
        resultTitleLabel = new Label();
        statsPanel = new Panel();
        demoCodeLabel = new Label();
        usedValueLabel = new Label();
        usedTitleLabel = new Label();
        unusedValueLabel = new Label();
        unusedTitleLabel = new Label();
        statsTitleLabel = new Label();
        historyPanel = new Panel();
        historyGrid = new DataGridView();
        colTime = new DataGridViewTextBoxColumn();
        colCode = new DataGridViewTextBoxColumn();
        colResult = new DataGridViewTextBoxColumn();
        historyTitleLabel = new Label();
        scanPanel.SuspendLayout();
        resultPanel.SuspendLayout();
        statsPanel.SuspendLayout();
        historyPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)historyGrid).BeginInit();
        SuspendLayout();
        // 
        // scanPanel
        // 
        scanPanel.BackColor = Color.White;
        scanPanel.BorderStyle = BorderStyle.FixedSingle;
        scanPanel.Controls.Add(resetButton);
        scanPanel.Controls.Add(checkButton);
        scanPanel.Controls.Add(ticketCodeTextBox);
        scanPanel.Controls.Add(scanLabel);
        scanPanel.Location = new Point(18, 14);
        scanPanel.Name = "scanPanel";
        scanPanel.Size = new Size(1048, 70);
        scanPanel.TabIndex = 0;
        scanLabel.AutoSize = true;
        scanLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        scanLabel.ForeColor = Color.FromArgb(17, 24, 39);
        scanLabel.Location = new Point(20, 25);
        scanLabel.Name = "scanLabel";
        scanLabel.Size = new Size(115, 17);
        scanLabel.TabIndex = 0;
        scanLabel.Text = "Nhập mã vé/QR";
        ticketCodeTextBox.Font = new Font("Segoe UI", 11F);
        ticketCodeTextBox.Location = new Point(150, 21);
        ticketCodeTextBox.Name = "ticketCodeTextBox";
        ticketCodeTextBox.PlaceholderText = "Quét mã QR hoặc nhập mã vé...";
        ticketCodeTextBox.Size = new Size(430, 27);
        ticketCodeTextBox.TabIndex = 1;
        ticketCodeTextBox.Text = "TK000001";
        checkButton.BackColor = Color.FromArgb(37, 99, 235);
        checkButton.FlatAppearance.BorderSize = 0;
        checkButton.FlatStyle = FlatStyle.Flat;
        checkButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        checkButton.ForeColor = Color.White;
        checkButton.Location = new Point(604, 17);
        checkButton.Name = "checkButton";
        checkButton.Size = new Size(142, 36);
        checkButton.TabIndex = 2;
        checkButton.Text = "Kiểm tra vé";
        checkButton.UseVisualStyleBackColor = false;
        checkButton.Click += CheckButton_Click;
        resetButton.BackColor = Color.White;
        resetButton.FlatStyle = FlatStyle.Flat;
        resetButton.Font = new Font("Segoe UI", 9.5F);
        resetButton.ForeColor = Color.FromArgb(17, 24, 39);
        resetButton.Location = new Point(762, 17);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(120, 36);
        resetButton.TabIndex = 3;
        resetButton.Text = "Làm mới";
        resetButton.UseVisualStyleBackColor = false;
        resetButton.Click += ResetButton_Click;
        // 
        // resultPanel
        // 
        resultPanel.BackColor = Color.White;
        resultPanel.BorderStyle = BorderStyle.FixedSingle;
        resultPanel.Controls.Add(confirmEntryButton);
        resultPanel.Controls.Add(resultDetailLabel);
        resultPanel.Controls.Add(resultTitleLabel);
        resultPanel.Location = new Point(18, 100);
        resultPanel.Name = "resultPanel";
        resultPanel.Size = new Size(704, 300);
        resultPanel.TabIndex = 1;
        resultTitleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        resultTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        resultTitleLabel.Location = new Point(28, 32);
        resultTitleLabel.Name = "resultTitleLabel";
        resultTitleLabel.Size = new Size(300, 64);
        resultTitleLabel.TabIndex = 0;
        resultTitleLabel.Text = "Sẵn sàng kiểm tra";
        resultTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        resultDetailLabel.Font = new Font("Segoe UI", 11F);
        resultDetailLabel.ForeColor = Color.FromArgb(17, 24, 39);
        resultDetailLabel.Location = new Point(336, 38);
        resultDetailLabel.Name = "resultDetailLabel";
        resultDetailLabel.Size = new Size(330, 190);
        resultDetailLabel.TabIndex = 1;
        resultDetailLabel.Text = "Nhập mã vé demo TK000001, TK000002 hoặc mã vé mới tạo từ màn Bán vé.";
        confirmEntryButton.BackColor = Color.FromArgb(226, 232, 240);
        confirmEntryButton.Enabled = false;
        confirmEntryButton.FlatAppearance.BorderSize = 0;
        confirmEntryButton.FlatStyle = FlatStyle.Flat;
        confirmEntryButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        confirmEntryButton.ForeColor = Color.FromArgb(100, 116, 139);
        confirmEntryButton.Location = new Point(28, 226);
        confirmEntryButton.Name = "confirmEntryButton";
        confirmEntryButton.Size = new Size(638, 46);
        confirmEntryButton.TabIndex = 2;
        confirmEntryButton.Text = "Kiểm tra vé hợp lệ để xác nhận";
        confirmEntryButton.UseVisualStyleBackColor = false;
        confirmEntryButton.Click += ConfirmEntryButton_Click;
        // 
        // statsPanel
        // 
        statsPanel.BackColor = Color.White;
        statsPanel.BorderStyle = BorderStyle.FixedSingle;
        statsPanel.Controls.Add(demoCodeLabel);
        statsPanel.Controls.Add(usedValueLabel);
        statsPanel.Controls.Add(usedTitleLabel);
        statsPanel.Controls.Add(unusedValueLabel);
        statsPanel.Controls.Add(unusedTitleLabel);
        statsPanel.Controls.Add(statsTitleLabel);
        statsPanel.Location = new Point(740, 100);
        statsPanel.Name = "statsPanel";
        statsPanel.Size = new Size(326, 300);
        statsPanel.TabIndex = 2;
        statsTitleLabel.AutoSize = true;
        statsTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        statsTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        statsTitleLabel.Location = new Point(20, 20);
        statsTitleLabel.Name = "statsTitleLabel";
        statsTitleLabel.Size = new Size(133, 21);
        statsTitleLabel.TabIndex = 0;
        statsTitleLabel.Text = "Thống kê hôm nay";
        unusedTitleLabel.Font = new Font("Segoe UI", 9F);
        unusedTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        unusedTitleLabel.Location = new Point(24, 70);
        unusedTitleLabel.Name = "unusedTitleLabel";
        unusedTitleLabel.Size = new Size(160, 22);
        unusedTitleLabel.TabIndex = 1;
        unusedTitleLabel.Text = "Vé chưa sử dụng";
        unusedValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        unusedValueLabel.ForeColor = Color.FromArgb(37, 99, 235);
        unusedValueLabel.Location = new Point(24, 94);
        unusedValueLabel.Name = "unusedValueLabel";
        unusedValueLabel.Size = new Size(100, 44);
        unusedValueLabel.TabIndex = 2;
        unusedValueLabel.Text = "2";
        usedTitleLabel.Font = new Font("Segoe UI", 9F);
        usedTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        usedTitleLabel.Location = new Point(174, 70);
        usedTitleLabel.Name = "usedTitleLabel";
        usedTitleLabel.Size = new Size(120, 22);
        usedTitleLabel.TabIndex = 3;
        usedTitleLabel.Text = "Vé đã vào rạp";
        usedValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        usedValueLabel.ForeColor = Color.FromArgb(22, 163, 74);
        usedValueLabel.Location = new Point(174, 94);
        usedValueLabel.Name = "usedValueLabel";
        usedValueLabel.Size = new Size(100, 44);
        usedValueLabel.TabIndex = 4;
        usedValueLabel.Text = "1";
        demoCodeLabel.BorderStyle = BorderStyle.FixedSingle;
        demoCodeLabel.Font = new Font("Segoe UI", 10F);
        demoCodeLabel.ForeColor = Color.FromArgb(17, 24, 39);
        demoCodeLabel.Location = new Point(24, 170);
        demoCodeLabel.Name = "demoCodeLabel";
        demoCodeLabel.Size = new Size(270, 88);
        demoCodeLabel.TabIndex = 5;
        demoCodeLabel.Text = "Mã demo:\r\nTK000001: hợp lệ\r\nTK000002: đã sử dụng\r\nTK000003: đã hủy";
        demoCodeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // historyPanel
        // 
        historyPanel.BackColor = Color.White;
        historyPanel.BorderStyle = BorderStyle.FixedSingle;
        historyPanel.Controls.Add(historyGrid);
        historyPanel.Controls.Add(historyTitleLabel);
        historyPanel.Location = new Point(18, 416);
        historyPanel.Name = "historyPanel";
        historyPanel.Size = new Size(1048, 174);
        historyPanel.TabIndex = 3;
        historyTitleLabel.AutoSize = true;
        historyTitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        historyTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        historyTitleLabel.Location = new Point(18, 14);
        historyTitleLabel.Name = "historyTitleLabel";
        historyTitleLabel.Size = new Size(128, 20);
        historyTitleLabel.TabIndex = 0;
        historyTitleLabel.Text = "Lịch sử kiểm tra";
        historyGrid.AllowUserToAddRows = false;
        historyGrid.AllowUserToDeleteRows = false;
        historyGrid.BackgroundColor = Color.White;
        historyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        historyGrid.Columns.AddRange(new DataGridViewColumn[] { colTime, colCode, colResult });
        historyGrid.Location = new Point(18, 44);
        historyGrid.Name = "historyGrid";
        historyGrid.ReadOnly = true;
        historyGrid.RowHeadersVisible = false;
        historyGrid.Size = new Size(1010, 112);
        historyGrid.TabIndex = 1;
        historyGrid.Rows.Add("09:15:22", "TK000001", "Chưa sử dụng");
        colTime.HeaderText = "Thời gian";
        colTime.Name = "colTime";
        colTime.ReadOnly = true;
        colTime.Width = 120;
        colCode.HeaderText = "Mã vé";
        colCode.Name = "colCode";
        colCode.ReadOnly = true;
        colCode.Width = 160;
        colResult.HeaderText = "Kết quả";
        colResult.Name = "colResult";
        colResult.ReadOnly = true;
        colResult.Width = 220;
        // 
        // TicketCheckForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1084, 606);
        Controls.Add(historyPanel);
        Controls.Add(statsPanel);
        Controls.Add(resultPanel);
        Controls.Add(scanPanel);
        Name = "TicketCheckForm";
        Text = "Kiểm tra vé";
        Load += TicketCheckForm_Load;
        scanPanel.ResumeLayout(false);
        scanPanel.PerformLayout();
        resultPanel.ResumeLayout(false);
        statsPanel.ResumeLayout(false);
        statsPanel.PerformLayout();
        historyPanel.ResumeLayout(false);
        historyPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)historyGrid).EndInit();
        ResumeLayout(false);
    }
}
