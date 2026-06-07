namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

partial class MoMoQRForm
{
    private System.ComponentModel.IContainer components = null!;
    private PictureBox qrPictureBox = null!;
    private Label instructionLabel = null!;
    private Button cancelButton = null!;
    private Label titleLabel = null!;
    private LinkLabel webPaymentLink = null!;
    private Button bypassButton = null!;

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
        this.qrPictureBox = new PictureBox();
        this.instructionLabel = new Label();
        this.cancelButton = new Button();
        this.titleLabel = new Label();
        this.webPaymentLink = new LinkLabel();
        this.bypassButton = new Button();
        ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // qrPictureBox
        // 
        this.qrPictureBox.BackColor = Color.White;
        this.qrPictureBox.BorderStyle = BorderStyle.FixedSingle;
        this.qrPictureBox.Location = new Point(40, 60);
        this.qrPictureBox.Name = "qrPictureBox";
        this.qrPictureBox.Size = new Size(300, 300);
        this.qrPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.qrPictureBox.TabIndex = 0;
        this.qrPictureBox.TabStop = false;
        // 
        // webPaymentLink
        // 
        this.webPaymentLink.AutoSize = false;
        this.webPaymentLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        this.webPaymentLink.Location = new Point(40, 365);
        this.webPaymentLink.Name = "webPaymentLink";
        this.webPaymentLink.Size = new Size(300, 20);
        this.webPaymentLink.TabIndex = 4;
        this.webPaymentLink.TabStop = true;
        this.webPaymentLink.Text = "Mở trang thanh toán thẻ trên trình duyệt (TEST)";
        this.webPaymentLink.TextAlign = ContentAlignment.MiddleCenter;
        this.webPaymentLink.Visible = false;
        this.webPaymentLink.LinkClicked += new LinkLabelLinkClickedEventHandler(this.WebPaymentLink_LinkClicked);
        // 
        // instructionLabel
        // 
        this.instructionLabel.Font = new Font("Segoe UI", 10F);
        this.instructionLabel.Location = new Point(40, 390);
        this.instructionLabel.Name = "instructionLabel";
        this.instructionLabel.Size = new Size(300, 40);
        this.instructionLabel.TabIndex = 1;
        this.instructionLabel.Text = "Mở ứng dụng MoMo trên điện thoại và quét mã QR để thanh toán.";
        this.instructionLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bypassButton
        // 
        this.bypassButton.BackColor = Color.FromArgb(16, 185, 129);
        this.bypassButton.FlatAppearance.BorderSize = 0;
        this.bypassButton.FlatStyle = FlatStyle.Flat;
        this.bypassButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.bypassButton.ForeColor = Color.White;
        this.bypassButton.Location = new Point(40, 440);
        this.bypassButton.Name = "bypassButton";
        this.bypassButton.Size = new Size(300, 40);
        this.bypassButton.TabIndex = 5;
        this.bypassButton.Text = "Giả lập Test Thành công";
        this.bypassButton.UseVisualStyleBackColor = false;
        this.bypassButton.Visible = false;
        this.bypassButton.Click += new EventHandler(this.BypassButton_Click);
        // 
        // cancelButton
        // 
        this.cancelButton.BackColor = Color.FromArgb(220, 38, 38);
        this.cancelButton.FlatAppearance.BorderSize = 0;
        this.cancelButton.FlatStyle = FlatStyle.Flat;
        this.cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.cancelButton.ForeColor = Color.White;
        this.cancelButton.Location = new Point(40, 490);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(300, 40);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Hủy giao dịch";
        this.cancelButton.UseVisualStyleBackColor = false;
        this.cancelButton.Click += new EventHandler(this.CancelButton_Click);
        // 
        // titleLabel
        // 
        this.titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.titleLabel.ForeColor = Color.FromArgb(165, 0, 100);
        this.titleLabel.Location = new Point(40, 10);
        this.titleLabel.Name = "titleLabel";
        this.titleLabel.Size = new Size(300, 40);
        this.titleLabel.TabIndex = 3;
        this.titleLabel.Text = "Thanh toán qua Ví MoMo";
        this.titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MoMoQRForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(245, 247, 251);
        this.ClientSize = new Size(380, 560);
        this.Controls.Add(this.titleLabel);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.bypassButton);
        this.Controls.Add(this.instructionLabel);
        this.Controls.Add(this.webPaymentLink);
        this.Controls.Add(this.qrPictureBox);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "MoMoQRForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Mã QR MoMo";
        this.Load += new EventHandler(this.MoMoQRForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.qrPictureBox)).EndInit();
        this.ResumeLayout(false);
    }
}
