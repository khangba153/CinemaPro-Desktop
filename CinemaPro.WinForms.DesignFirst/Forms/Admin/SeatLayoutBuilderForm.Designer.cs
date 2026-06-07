namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

partial class SeatLayoutBuilderForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel headerPanel = null!;
    private Label titleLabel = null!;
    private Label instructionLabel = null!;
    private Label roomCaptionLabel = null!;
    private Label roomValueLabel = null!;
    private Label sizeCaptionLabel = null!;
    private Label sizeValueLabel = null!;
    private Panel gridPanel = null!;
    private Panel actionPanel = null!;
    private Label summaryLabel = null!;
    private Button selectAllButton = null!;
    private Button clearAllButton = null!;
    private Button createButton = null!;
    private Button cancelButton = null!;

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
        headerPanel = new Panel();
        sizeValueLabel = new Label();
        sizeCaptionLabel = new Label();
        roomValueLabel = new Label();
        roomCaptionLabel = new Label();
        instructionLabel = new Label();
        titleLabel = new Label();
        gridPanel = new Panel();
        actionPanel = new Panel();
        cancelButton = new Button();
        createButton = new Button();
        clearAllButton = new Button();
        selectAllButton = new Button();
        summaryLabel = new Label();
        headerPanel.SuspendLayout();
        actionPanel.SuspendLayout();
        SuspendLayout();
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.White;
        headerPanel.BorderStyle = BorderStyle.FixedSingle;
        headerPanel.Controls.Add(sizeValueLabel);
        headerPanel.Controls.Add(sizeCaptionLabel);
        headerPanel.Controls.Add(roomValueLabel);
        headerPanel.Controls.Add(roomCaptionLabel);
        headerPanel.Controls.Add(instructionLabel);
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Location = new Point(18, 19);
        headerPanel.Margin = new Padding(3, 4, 3, 4);
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(813, 157);
        headerPanel.TabIndex = 0;
        // 
        // sizeValueLabel
        // 
        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        sizeValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        sizeValueLabel.Location = new Point(370, 117);
        sizeValueLabel.Name = "sizeValueLabel";
        sizeValueLabel.Size = new Size(108, 20);
        sizeValueLabel.TabIndex = 5;
        sizeValueLabel.Text = "5 hàng x 8 cột";
        // 
        // sizeCaptionLabel
        // 
        sizeCaptionLabel.AutoSize = true;
        sizeCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        sizeCaptionLabel.ForeColor = Color.FromArgb(100, 116, 139);
        sizeCaptionLabel.Location = new Point(286, 117);
        sizeCaptionLabel.Name = "sizeCaptionLabel";
        sizeCaptionLabel.Size = new Size(88, 20);
        sizeCaptionLabel.TabIndex = 4;
        sizeCaptionLabel.Text = "Kích thước:";
        // 
        // roomValueLabel
        // 
        roomValueLabel.AutoSize = true;
        roomValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        roomValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        roomValueLabel.Location = new Point(82, 117);
        roomValueLabel.Name = "roomValueLabel";
        roomValueLabel.Size = new Size(67, 20);
        roomValueLabel.TabIndex = 3;
        roomValueLabel.Text = "Phòng 1";
        // 
        // roomCaptionLabel
        // 
        roomCaptionLabel.AutoSize = true;
        roomCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        roomCaptionLabel.ForeColor = Color.FromArgb(100, 116, 139);
        roomCaptionLabel.Location = new Point(23, 117);
        roomCaptionLabel.Name = "roomCaptionLabel";
        roomCaptionLabel.Size = new Size(58, 20);
        roomCaptionLabel.TabIndex = 2;
        roomCaptionLabel.Text = "Phòng:";
        // 
        // instructionLabel
        // 
        instructionLabel.ForeColor = Color.FromArgb(71, 85, 105);
        instructionLabel.Location = new Point(23, 64);
        instructionLabel.Name = "instructionLabel";
        instructionLabel.Size = new Size(754, 48);
        instructionLabel.TabIndex = 1;
        instructionLabel.Text = "Click vào ô để bật/tắt ghế sử dụng. Ô màu xanh là ghế thật, ô trống là lối đi. Mã ghế được đánh lại từ trái sang phải trong từng hàng.";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        titleLabel.Location = new Point(21, 21);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(175, 32);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Tạo sơ đồ ghế";
        // 
        // gridPanel
        // 
        gridPanel.AutoScroll = true;
        gridPanel.BackColor = Color.FromArgb(248, 250, 252);
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Location = new Point(18, 192);
        gridPanel.Margin = new Padding(3, 4, 3, 4);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(813, 474);
        gridPanel.TabIndex = 1;
        // 
        // actionPanel
        // 
        actionPanel.BackColor = Color.White;
        actionPanel.BorderStyle = BorderStyle.FixedSingle;
        actionPanel.Controls.Add(cancelButton);
        actionPanel.Controls.Add(createButton);
        actionPanel.Controls.Add(clearAllButton);
        actionPanel.Controls.Add(selectAllButton);
        actionPanel.Controls.Add(summaryLabel);
        actionPanel.Location = new Point(18, 683);
        actionPanel.Margin = new Padding(3, 4, 3, 4);
        actionPanel.Name = "actionPanel";
        actionPanel.Size = new Size(813, 87);
        actionPanel.TabIndex = 2;
        // 
        // cancelButton
        // 
        cancelButton.BackColor = Color.White;
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.FlatStyle = FlatStyle.Flat;
        cancelButton.Location = new Point(690, 21);
        cancelButton.Margin = new Padding(3, 4, 3, 4);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(94, 45);
        cancelButton.TabIndex = 4;
        cancelButton.Text = "Hủy";
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Click += CancelButton_Click;
        // 
        // createButton
        // 
        createButton.BackColor = Color.FromArgb(37, 99, 235);
        createButton.FlatAppearance.BorderSize = 0;
        createButton.FlatStyle = FlatStyle.Flat;
        createButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        createButton.ForeColor = Color.White;
        createButton.Location = new Point(571, 21);
        createButton.Margin = new Padding(3, 4, 3, 4);
        createButton.Name = "createButton";
        createButton.Size = new Size(105, 45);
        createButton.TabIndex = 3;
        createButton.Text = "Tạo ghế";
        createButton.UseVisualStyleBackColor = false;
        createButton.Click += CreateButton_Click;
        // 
        // clearAllButton
        // 
        clearAllButton.BackColor = Color.White;
        clearAllButton.FlatStyle = FlatStyle.Flat;
        clearAllButton.Location = new Point(443, 21);
        clearAllButton.Margin = new Padding(3, 4, 3, 4);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(112, 45);
        clearAllButton.TabIndex = 2;
        clearAllButton.Text = "Bỏ chọn hết";
        clearAllButton.UseVisualStyleBackColor = false;
        clearAllButton.Click += ClearAllButton_Click;
        // 
        // selectAllButton
        // 
        selectAllButton.BackColor = Color.White;
        selectAllButton.FlatStyle = FlatStyle.Flat;
        selectAllButton.Location = new Point(318, 21);
        selectAllButton.Margin = new Padding(3, 4, 3, 4);
        selectAllButton.Name = "selectAllButton";
        selectAllButton.Size = new Size(112, 45);
        selectAllButton.TabIndex = 1;
        selectAllButton.Text = "Chọn tất cả";
        selectAllButton.UseVisualStyleBackColor = false;
        selectAllButton.Click += SelectAllButton_Click;
        // 
        // summaryLabel
        // 
        summaryLabel.ForeColor = Color.FromArgb(71, 85, 105);
        summaryLabel.Location = new Point(21, 29);
        summaryLabel.Name = "summaryLabel";
        summaryLabel.Size = new Size(263, 27);
        summaryLabel.TabIndex = 0;
        summaryLabel.Text = "Đã chọn 40 ghế. Ô trống là lối đi.";
        // 
        // SeatLayoutBuilderForm
        // 
        AcceptButton = createButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        CancelButton = cancelButton;
        ClientSize = new Size(850, 789);
        Controls.Add(actionPanel);
        Controls.Add(gridPanel);
        Controls.Add(headerPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SeatLayoutBuilderForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Tạo sơ đồ ghế";
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        actionPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
