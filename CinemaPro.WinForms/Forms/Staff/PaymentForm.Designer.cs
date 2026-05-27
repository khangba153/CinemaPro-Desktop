using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class PaymentForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel card;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel detailsTable;
    private Label titleLabel;
    private Label ticketIdLabel;
    private Label ticketIdValueLabel;
    private Label movieLabel;
    private Label movieValueLabel;
    private Label showtimeLabel;
    private Label showtimeValueLabel;
    private Label roomLabel;
    private Label roomValueLabel;
    private Label seatsLabel;
    private Label seatsValueLabel;
    private Label totalLabel;
    private Label totalValueLabel;
    private Label paymentMethodLabel;
    private Label paymentMethodValueLabel;
    private Button confirmButton;
    private Button closeButton;

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
        card = new Panel();
        rootLayout = new TableLayoutPanel();
        titleLabel = new Label();
        detailsTable = new TableLayoutPanel();
        ticketIdLabel = new Label();
        ticketIdValueLabel = new Label();
        movieLabel = new Label();
        movieValueLabel = new Label();
        showtimeLabel = new Label();
        showtimeValueLabel = new Label();
        roomLabel = new Label();
        roomValueLabel = new Label();
        seatsLabel = new Label();
        seatsValueLabel = new Label();
        totalLabel = new Label();
        totalValueLabel = new Label();
        paymentMethodLabel = new Label();
        paymentMethodValueLabel = new Label();
        confirmButton = new Button();
        closeButton = new Button();
        card.SuspendLayout();
        rootLayout.SuspendLayout();
        detailsTable.SuspendLayout();
        SuspendLayout();
        //
        // PaymentForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(520, 560);
        Controls.Add(card);
        Font = UiStyleHelper.BodyFont();
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PaymentForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Xác nhận thanh toán";
        //
        // card
        //
        card.BackColor = UiStyleHelper.CardBackground;
        card.BorderStyle = BorderStyle.FixedSingle;
        card.Controls.Add(rootLayout);
        card.Dock = DockStyle.Fill;
        card.Margin = new Padding(18);
        card.Padding = new Padding(24);
        //
        // rootLayout
        //
        rootLayout.BackColor = Color.Transparent;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(titleLabel, 0, 0);
        rootLayout.Controls.Add(detailsTable, 0, 1);
        rootLayout.Controls.Add(confirmButton, 0, 2);
        rootLayout.Controls.Add(closeButton, 0, 3);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 4;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        //
        // titleLabel
        //
        titleLabel.Dock = DockStyle.Fill;
        titleLabel.Font = UiStyleHelper.TitleFont(18);
        titleLabel.ForeColor = UiStyleHelper.TextDark;
        titleLabel.Text = "Xác nhận thanh toán";
        titleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // detailsTable
        //
        detailsTable.BackColor = UiStyleHelper.SurfaceMuted;
        detailsTable.ColumnCount = 2;
        detailsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
        detailsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
        detailsTable.Dock = DockStyle.Fill;
        detailsTable.Padding = new Padding(16);
        detailsTable.RowCount = 7;
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285714F));
        detailsTable.Controls.Add(ticketIdLabel, 0, 0);
        detailsTable.Controls.Add(ticketIdValueLabel, 1, 0);
        detailsTable.Controls.Add(movieLabel, 0, 1);
        detailsTable.Controls.Add(movieValueLabel, 1, 1);
        detailsTable.Controls.Add(showtimeLabel, 0, 2);
        detailsTable.Controls.Add(showtimeValueLabel, 1, 2);
        detailsTable.Controls.Add(roomLabel, 0, 3);
        detailsTable.Controls.Add(roomValueLabel, 1, 3);
        detailsTable.Controls.Add(seatsLabel, 0, 4);
        detailsTable.Controls.Add(seatsValueLabel, 1, 4);
        detailsTable.Controls.Add(totalLabel, 0, 5);
        detailsTable.Controls.Add(totalValueLabel, 1, 5);
        detailsTable.Controls.Add(paymentMethodLabel, 0, 6);
        detailsTable.Controls.Add(paymentMethodValueLabel, 1, 6);
        StyleDetailCaption(ticketIdLabel, "Mã vé");
        StyleDetailCaption(movieLabel, "Tên phim");
        StyleDetailCaption(showtimeLabel, "Suất chiếu");
        StyleDetailCaption(roomLabel, "Phòng");
        StyleDetailCaption(seatsLabel, "Ghế");
        StyleDetailCaption(totalLabel, "Tổng tiền");
        StyleDetailCaption(paymentMethodLabel, "Thanh toán");
        StyleDetailValue(ticketIdValueLabel, "TK000001");
        StyleDetailValue(movieValueLabel, "Avengers: Endgame");
        StyleDetailValue(showtimeValueLabel, "19:30 - 22:32");
        StyleDetailValue(roomValueLabel, "Phòng 2");
        StyleDetailValue(seatsValueLabel, "B5, B6");
        StyleDetailValue(totalValueLabel, "180.000 đ");
        StyleDetailValue(paymentMethodValueLabel, "Tiền mặt");
        //
        // confirmButton
        //
        confirmButton.BackColor = UiStyleHelper.Primary;
        confirmButton.Cursor = Cursors.Hand;
        confirmButton.Dock = DockStyle.Fill;
        confirmButton.FlatStyle = FlatStyle.Flat;
        confirmButton.FlatAppearance.BorderSize = 0;
        confirmButton.Font = UiStyleHelper.SectionFont(9.5F);
        confirmButton.ForeColor = Color.White;
        confirmButton.Margin = new Padding(0, 14, 0, 0);
        confirmButton.Text = "Xác nhận";
        confirmButton.UseVisualStyleBackColor = false;
        confirmButton.Click += ConfirmButton_Click;
        //
        // closeButton
        //
        closeButton.BackColor = Color.White;
        closeButton.Cursor = Cursors.Hand;
        closeButton.Dock = DockStyle.Fill;
        closeButton.FlatStyle = FlatStyle.Flat;
        closeButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        closeButton.FlatAppearance.BorderSize = 1;
        closeButton.Font = UiStyleHelper.SectionFont(9.5F);
        closeButton.ForeColor = UiStyleHelper.Primary;
        closeButton.Margin = new Padding(0, 8, 0, 0);
        closeButton.Text = "Đóng";
        closeButton.UseVisualStyleBackColor = false;
        closeButton.Click += CloseButton_Click;
        card.ResumeLayout(false);
        rootLayout.ResumeLayout(false);
        detailsTable.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static void StyleDetailCaption(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9.5F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleDetailValue(Label label, string text)
    {
        label.AutoEllipsis = true;
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(9.5F);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }
}
