namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

partial class PaymentForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel paymentPanel = null!;
    private Label titleLabel = null!;
    private Label ticketCodeLabel = null!;
    private Label ticketCodeValueLabel = null!;
    private Label movieLabel = null!;
    private Label movieValueLabel = null!;
    private Label showtimeLabel = null!;
    private Label showtimeValueLabel = null!;
    private Label roomLabel = null!;
    private Label roomValueLabel = null!;
    private Label seatsLabel = null!;
    private Label seatsValueLabel = null!;
    private Label amountLabel = null!;
    private Label amountValueLabel = null!;
    private Label methodLabel = null!;
    private Label methodValueLabel = null!;
    private Panel qrPanel = null!;
    private Label qrLabel = null!;
    private Button confirmButton = null!;
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
        paymentPanel = new Panel();
        cancelButton = new Button();
        confirmButton = new Button();
        qrPanel = new Panel();
        qrLabel = new Label();
        methodValueLabel = new Label();
        methodLabel = new Label();
        amountValueLabel = new Label();
        amountLabel = new Label();
        seatsValueLabel = new Label();
        seatsLabel = new Label();
        roomValueLabel = new Label();
        roomLabel = new Label();
        showtimeValueLabel = new Label();
        showtimeLabel = new Label();
        movieValueLabel = new Label();
        movieLabel = new Label();
        ticketCodeValueLabel = new Label();
        ticketCodeLabel = new Label();
        titleLabel = new Label();
        paymentPanel.SuspendLayout();
        qrPanel.SuspendLayout();
        SuspendLayout();
        // 
        // paymentPanel
        // 
        paymentPanel.BackColor = Color.White;
        paymentPanel.BorderStyle = BorderStyle.FixedSingle;
        paymentPanel.Controls.Add(cancelButton);
        paymentPanel.Controls.Add(confirmButton);
        paymentPanel.Controls.Add(qrPanel);
        paymentPanel.Controls.Add(methodValueLabel);
        paymentPanel.Controls.Add(methodLabel);
        paymentPanel.Controls.Add(amountValueLabel);
        paymentPanel.Controls.Add(amountLabel);
        paymentPanel.Controls.Add(seatsValueLabel);
        paymentPanel.Controls.Add(seatsLabel);
        paymentPanel.Controls.Add(roomValueLabel);
        paymentPanel.Controls.Add(roomLabel);
        paymentPanel.Controls.Add(showtimeValueLabel);
        paymentPanel.Controls.Add(showtimeLabel);
        paymentPanel.Controls.Add(movieValueLabel);
        paymentPanel.Controls.Add(movieLabel);
        paymentPanel.Controls.Add(ticketCodeValueLabel);
        paymentPanel.Controls.Add(ticketCodeLabel);
        paymentPanel.Controls.Add(titleLabel);
        paymentPanel.Location = new Point(22, 22);
        paymentPanel.Name = "paymentPanel";
        paymentPanel.Size = new Size(500, 500);
        paymentPanel.TabIndex = 0;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        titleLabel.Location = new Point(26, 22);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(211, 30);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Xác nhận thanh toán";
        // 
        // ticketCodeLabel
        // 
        ticketCodeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        ticketCodeLabel.ForeColor = Color.FromArgb(100, 116, 139);
        ticketCodeLabel.Location = new Point(28, 78);
        ticketCodeLabel.Name = "ticketCodeLabel";
        ticketCodeLabel.Size = new Size(110, 22);
        ticketCodeLabel.TabIndex = 1;
        ticketCodeLabel.Text = "Mã vé";
        // 
        // ticketCodeValueLabel
        // 
        ticketCodeValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        ticketCodeValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        ticketCodeValueLabel.Location = new Point(150, 78);
        ticketCodeValueLabel.Name = "ticketCodeValueLabel";
        ticketCodeValueLabel.Size = new Size(310, 22);
        ticketCodeValueLabel.TabIndex = 2;
        ticketCodeValueLabel.Text = "TK-TẠM";
        // 
        // movieLabel
        // 
        movieLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        movieLabel.ForeColor = Color.FromArgb(100, 116, 139);
        movieLabel.Location = new Point(28, 114);
        movieLabel.Name = "movieLabel";
        movieLabel.Size = new Size(110, 22);
        movieLabel.TabIndex = 3;
        movieLabel.Text = "Phim";
        // 
        // movieValueLabel
        // 
        movieValueLabel.Font = new Font("Segoe UI", 10F);
        movieValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        movieValueLabel.Location = new Point(150, 114);
        movieValueLabel.Name = "movieValueLabel";
        movieValueLabel.Size = new Size(310, 22);
        movieValueLabel.TabIndex = 4;
        movieValueLabel.Text = "Avengers: Endgame";
        // 
        // showtimeLabel
        // 
        showtimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        showtimeLabel.ForeColor = Color.FromArgb(100, 116, 139);
        showtimeLabel.Location = new Point(28, 150);
        showtimeLabel.Name = "showtimeLabel";
        showtimeLabel.Size = new Size(110, 22);
        showtimeLabel.TabIndex = 5;
        showtimeLabel.Text = "Suất chiếu";
        // 
        // showtimeValueLabel
        // 
        showtimeValueLabel.Font = new Font("Segoe UI", 10F);
        showtimeValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        showtimeValueLabel.Location = new Point(150, 150);
        showtimeValueLabel.Name = "showtimeValueLabel";
        showtimeValueLabel.Size = new Size(310, 22);
        showtimeValueLabel.TabIndex = 6;
        showtimeValueLabel.Text = "19:30 - 22:32";
        // 
        // roomLabel
        // 
        roomLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        roomLabel.ForeColor = Color.FromArgb(100, 116, 139);
        roomLabel.Location = new Point(28, 186);
        roomLabel.Name = "roomLabel";
        roomLabel.Size = new Size(110, 22);
        roomLabel.TabIndex = 7;
        roomLabel.Text = "Phòng";
        // 
        // roomValueLabel
        // 
        roomValueLabel.Font = new Font("Segoe UI", 10F);
        roomValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        roomValueLabel.Location = new Point(150, 186);
        roomValueLabel.Name = "roomValueLabel";
        roomValueLabel.Size = new Size(310, 22);
        roomValueLabel.TabIndex = 8;
        roomValueLabel.Text = "Phòng 2";
        // 
        // seatsLabel
        // 
        seatsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        seatsLabel.ForeColor = Color.FromArgb(100, 116, 139);
        seatsLabel.Location = new Point(28, 222);
        seatsLabel.Name = "seatsLabel";
        seatsLabel.Size = new Size(110, 22);
        seatsLabel.TabIndex = 9;
        seatsLabel.Text = "Ghế";
        // 
        // seatsValueLabel
        // 
        seatsValueLabel.Font = new Font("Segoe UI", 10F);
        seatsValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        seatsValueLabel.Location = new Point(150, 222);
        seatsValueLabel.Name = "seatsValueLabel";
        seatsValueLabel.Size = new Size(310, 22);
        seatsValueLabel.TabIndex = 10;
        seatsValueLabel.Text = "B6, B7";
        // 
        // amountLabel
        // 
        amountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        amountLabel.ForeColor = Color.FromArgb(100, 116, 139);
        amountLabel.Location = new Point(28, 262);
        amountLabel.Name = "amountLabel";
        amountLabel.Size = new Size(110, 22);
        amountLabel.TabIndex = 11;
        amountLabel.Text = "Tổng tiền";
        // 
        // amountValueLabel
        // 
        amountValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        amountValueLabel.ForeColor = Color.FromArgb(37, 99, 235);
        amountValueLabel.Location = new Point(150, 254);
        amountValueLabel.Name = "amountValueLabel";
        amountValueLabel.Size = new Size(310, 34);
        amountValueLabel.TabIndex = 12;
        amountValueLabel.Text = "180.000 đ";
        // 
        // methodLabel
        // 
        methodLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        methodLabel.ForeColor = Color.FromArgb(100, 116, 139);
        methodLabel.Location = new Point(28, 306);
        methodLabel.Name = "methodLabel";
        methodLabel.Size = new Size(110, 22);
        methodLabel.TabIndex = 13;
        methodLabel.Text = "Thanh toán";
        // 
        // methodValueLabel
        // 
        methodValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        methodValueLabel.ForeColor = Color.FromArgb(17, 24, 39);
        methodValueLabel.Location = new Point(150, 306);
        methodValueLabel.Name = "methodValueLabel";
        methodValueLabel.Size = new Size(310, 22);
        methodValueLabel.TabIndex = 14;
        methodValueLabel.Text = "Tiền mặt";
        // 
        // qrPanel
        // 
        qrPanel.BackColor = Color.FromArgb(248, 250, 252);
        qrPanel.BorderStyle = BorderStyle.FixedSingle;
        qrPanel.Controls.Add(qrLabel);
        qrPanel.Location = new Point(28, 346);
        qrPanel.Name = "qrPanel";
        qrPanel.Size = new Size(132, 92);
        qrPanel.TabIndex = 15;
        qrLabel.Dock = DockStyle.Fill;
        qrLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        qrLabel.ForeColor = Color.FromArgb(100, 116, 139);
        qrLabel.Location = new Point(0, 0);
        qrLabel.Name = "qrLabel";
        qrLabel.Size = new Size(130, 90);
        qrLabel.TabIndex = 0;
        qrLabel.Text = "QR giả\r\nCinemaPro";
        qrLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // confirmButton
        // 
        confirmButton.BackColor = Color.FromArgb(37, 99, 235);
        confirmButton.FlatAppearance.BorderSize = 0;
        confirmButton.FlatStyle = FlatStyle.Flat;
        confirmButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        confirmButton.ForeColor = Color.White;
        confirmButton.Location = new Point(182, 374);
        confirmButton.Name = "confirmButton";
        confirmButton.Size = new Size(132, 44);
        confirmButton.TabIndex = 16;
        confirmButton.Text = "Xác nhận";
        confirmButton.UseVisualStyleBackColor = false;
        confirmButton.Click += ConfirmButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.BackColor = Color.White;
        cancelButton.FlatStyle = FlatStyle.Flat;
        cancelButton.Font = new Font("Segoe UI", 10F);
        cancelButton.ForeColor = Color.FromArgb(17, 24, 39);
        cancelButton.Location = new Point(326, 374);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(132, 44);
        cancelButton.TabIndex = 17;
        cancelButton.Text = "Hủy";
        cancelButton.UseVisualStyleBackColor = false;
        cancelButton.Click += CancelButton_Click;
        // 
        // PaymentForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(544, 544);
        Controls.Add(paymentPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PaymentForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Xác nhận thanh toán";
        paymentPanel.ResumeLayout(false);
        paymentPanel.PerformLayout();
        qrPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
}
