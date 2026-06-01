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
        headerPanel.Location = new Point(16, 14);
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(712, 118);
        headerPanel.TabIndex = 0;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        titleLabel.Location = new Point(18, 16);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(187, 25);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Tạo sơ đồ ghế";
        // 
        // instructionLabel
        // 
        instructionLabel.ForeColor = Color.FromArgb(71, 85, 105);
        instructionLabel.Location = new Point(20, 48);
        instructionLabel.Name = "instructionLabel";
        instructionLabel.Size = new Size(660, 36);
        instructionLabel.TabIndex = 1;
        instructionLabel.Text = "Click vào ô để bật/tắt ghế sử dụng. Ô màu xanh là ghế thật, ô trống là lối đi. Mã ghế được đánh lại từ trái sang phải trong từng hàng.";
        // 
        // roomCaptionLabel
        // 
        roomCaptionLabel.AutoSize = true;
        roomCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        roomCaptionLabel.ForeColor = Color.FromArgb(100, 116, 139);
        roomCaptionLabel.Location = new Point(20, 88);
        roomCaptionLabel.Name = "roomCaptionLabel";
        roomCaptionLabel.Size = new Size(45, 15);
        roomCaptionLabel.TabIndex = 2;
        roomCaptionLabel.Text = "Phòng:";
        // 
        // roomValueLabel
        // 
        roomValueLabel.AutoSize = true;
        roomValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        roomValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        roomValueLabel.Location = new Point(72, 88);
        roomValueLabel.Name = "roomValueLabel";
        roomValueLabel.Size = new Size(52, 15);
        roomValueLabel.TabIndex = 3;
        roomValueLabel.Text = "Phòng 1";
        // 
        // sizeCaptionLabel
        // 
        sizeCaptionLabel.AutoSize = true;
        sizeCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        sizeCaptionLabel.ForeColor = Color.FromArgb(100, 116, 139);
        sizeCaptionLabel.Location = new Point(250, 88);
        sizeCaptionLabel.Name = "sizeCaptionLabel";
        sizeCaptionLabel.Size = new Size(65, 15);
        sizeCaptionLabel.TabIndex = 4;
        sizeCaptionLabel.Text = "Kích thước:";
        // 
        // sizeValueLabel
        // 
        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        sizeValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        sizeValueLabel.Location = new Point(324, 88);
        sizeValueLabel.Name = "sizeValueLabel";
        sizeValueLabel.Size = new Size(79, 15);
        sizeValueLabel.TabIndex = 5;
        sizeValueLabel.Text = "5 hàng x 8 cột";
        // 
        // gridPanel
        // 
        gridPanel.AutoScroll = true;
        gridPanel.BackColor = Color.FromArgb(248, 250, 252);
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Location = new Point(16, 144);
        gridPanel.Name = "gridPanel";
        gridPanel.Size = new Size(712, 356);
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
        actionPanel.Location = new Point(16, 512);
        actionPanel.Name = "actionPanel";
        actionPanel.Size = new Size(712, 66);
        actionPanel.TabIndex = 2;
        // 
        // summaryLabel
        // 
        summaryLabel.ForeColor = Color.FromArgb(71, 85, 105);
        summaryLabel.Location = new Point(18, 22);
        summaryLabel.Name = "summaryLabel";
        summaryLabel.Size = new Size(230, 20);
        summaryLabel.TabIndex = 0;
        summaryLabel.Text = "Đã chọn 40 ghế. Ô trống là lối đi.";
        // 
        // selectAllButton
        // 
        selectAllButton.BackColor = Color.White;
        selectAllButton.FlatStyle = FlatStyle.Flat;
        selectAllButton.Location = new Point(278, 16);
        selectAllButton.Name = "selectAllButton";
        selectAllButton.Size = new Size(98, 34);
        selectAllButton.TabIndex = 1;
        selectAllButton.Text = "Chọn tất cả";
        selectAllButton.UseVisualStyleBackColor = false;
        selectAllButton.Click += SelectAllButton_Click;
        // 
        // clearAllButton
        // 
        clearAllButton.BackColor = Color.White;
        clearAllButton.FlatStyle = FlatStyle.Flat;
        clearAllButton.Location = new Point(388, 16);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(98, 34);
        clearAllButton.TabIndex = 2;
        clearAllButton.Text = "Bỏ chọn hết";
        clearAllButton.UseVisualStyleBackColor = false;
        clearAllButton.Click += ClearAllButton_Click;
        // 
        // createButton
        // 
        createButton.BackColor = Color.FromArgb(37, 99, 235);
        createButton.FlatAppearance.BorderSize = 0;
        createButton.FlatStyle = FlatStyle.Flat;
        createButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        createButton.ForeColor = Color.White;
        createButton.Location = new Point(500, 16);
        createButton.Name = "createButton";
        createButton.Size = new Size(92, 34);
        createButton.TabIndex = 3;
        createButton.Text = "Tạo ghế";
        createButton.UseVisualStyleBackColor = false;
        createButton.Click += CreateButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.BackColor = Color.White;
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.FlatStyle = FlatStyle.Flat;
        cancelButton.Location = new Point(604, 16);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(82, 34);
        cancelButton.TabIndex = 4;
        cancelButton.Text = "Hủy";
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Click += CancelButton_Click;
        // 
        // SeatLayoutBuilderForm
        // 
        AcceptButton = createButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        CancelButton = cancelButton;
        ClientSize = new Size(744, 592);
        Controls.Add(actionPanel);
        Controls.Add(gridPanel);
        Controls.Add(headerPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
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
