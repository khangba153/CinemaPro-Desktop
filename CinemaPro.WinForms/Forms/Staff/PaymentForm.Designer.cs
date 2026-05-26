using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Staff;

partial class PaymentForm
{
    private System.ComponentModel.IContainer components = null;
    private RoundedPanel card;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel detailsTable;
    private Label titleLabel;
    private RoundedButton confirmButton;
    private RoundedButton closeButton;

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
        card = new RoundedPanel();
        rootLayout = new TableLayoutPanel();
        titleLabel = new Label();
        detailsTable = new TableLayoutPanel();
        confirmButton = new RoundedButton();
        closeButton = new RoundedButton();
        card.SuspendLayout();
        rootLayout.SuspendLayout();
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
        card.BorderColor = UiStyleHelper.CardBorder;
        card.BorderRadius = 8;
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
        //
        // confirmButton
        //
        confirmButton.BackColor = UiStyleHelper.Primary;
        confirmButton.BorderColor = UiStyleHelper.Primary;
        confirmButton.BorderRadius = 7;
        confirmButton.Cursor = Cursors.Hand;
        confirmButton.Dock = DockStyle.Fill;
        confirmButton.Font = UiStyleHelper.SectionFont(9.5F);
        confirmButton.ForeColor = Color.White;
        confirmButton.HoverBackColor = UiStyleHelper.PrimaryDark;
        confirmButton.Margin = new Padding(0, 14, 0, 0);
        confirmButton.Text = "Xác nhận";
        confirmButton.Click += ConfirmButton_Click;
        //
        // closeButton
        //
        closeButton.BackColor = Color.White;
        closeButton.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        closeButton.BorderRadius = 7;
        closeButton.Cursor = Cursors.Hand;
        closeButton.Dock = DockStyle.Fill;
        closeButton.Font = UiStyleHelper.SectionFont(9.5F);
        closeButton.ForeColor = UiStyleHelper.Primary;
        closeButton.HoverBackColor = ColorTranslator.FromHtml("#F0F7FF");
        closeButton.Margin = new Padding(0, 8, 0, 0);
        closeButton.Text = "Đóng";
        closeButton.Click += CloseButton_Click;
        card.ResumeLayout(false);
        rootLayout.ResumeLayout(false);
        ResumeLayout(false);
    }
}
