using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class SeatManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private Label roomFilterLabel;
    private ComboBox roomCombo;
    private Button changeStatusButton;
    private Button maintenanceButton;
    private Button refreshButton;
    private Panel seatCard;
    private TableLayoutPanel seatLayout;
    private Label seatTitleLabel;
    private Label screenLabel;
    private TableLayoutPanel seatPanel;
    private Label seatARowLabel;
    private Button seatA1Button;
    private Button seatA2Button;
    private Button seatA3Button;
    private Button seatA4Button;
    private Button seatA5Button;
    private Button seatA6Button;
    private Button seatA7Button;
    private Button seatA8Button;
    private Label seatBRowLabel;
    private Button seatB1Button;
    private Button seatB2Button;
    private Button seatB3Button;
    private Button seatB4Button;
    private Button seatB5Button;
    private Button seatB6Button;
    private Button seatB7Button;
    private Button seatB8Button;
    private Label seatCRowLabel;
    private Button seatC1Button;
    private Button seatC2Button;
    private Button seatC3Button;
    private Button seatC4Button;
    private Button seatC5Button;
    private Button seatC6Button;
    private Button seatC7Button;
    private Button seatC8Button;
    private Label seatDRowLabel;
    private Button seatD1Button;
    private Button seatD2Button;
    private Button seatD3Button;
    private Button seatD4Button;
    private Button seatD5Button;
    private Button seatD6Button;
    private Button seatD7Button;
    private Button seatD8Button;
    private Label seatERowLabel;
    private Button seatE1Button;
    private Button seatE2Button;
    private Button seatE3Button;
    private Button seatE4Button;
    private Button seatE5Button;
    private Button seatE6Button;
    private Button seatE7Button;
    private Button seatE8Button;
    private Label seatFRowLabel;
    private Button seatF1Button;
    private Button seatF2Button;
    private Button seatF3Button;
    private Button seatF4Button;
    private Button seatF5Button;
    private Button seatF6Button;
    private Button seatF7Button;
    private Button seatF8Button;
    private FlowLayoutPanel legendPanel;
    private Label availableLegendColorLabel;
    private Label availableLegendTextLabel;
    private Label selectedLegendColorLabel;
    private Label selectedLegendTextLabel;
    private Label soldLegendColorLabel;
    private Label soldLegendTextLabel;
    private Label maintenanceLegendColorLabel;
    private Label maintenanceLegendTextLabel;
    private Panel summaryCard;
    private Label summaryLabel;

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
        roomFilterLabel = new Label();
        roomCombo = new ComboBox();
        changeStatusButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        seatCard = new Panel();
        seatLayout = new TableLayoutPanel();
        seatTitleLabel = new Label();
        screenLabel = new Label();
        seatPanel = new TableLayoutPanel();
        seatARowLabel = new Label();
        seatA1Button = new Button();
        seatA2Button = new Button();
        seatA3Button = new Button();
        seatA4Button = new Button();
        seatA5Button = new Button();
        seatA6Button = new Button();
        seatA7Button = new Button();
        seatA8Button = new Button();
        seatBRowLabel = new Label();
        seatB1Button = new Button();
        seatB2Button = new Button();
        seatB3Button = new Button();
        seatB4Button = new Button();
        seatB5Button = new Button();
        seatB6Button = new Button();
        seatB7Button = new Button();
        seatB8Button = new Button();
        seatCRowLabel = new Label();
        seatC1Button = new Button();
        seatC2Button = new Button();
        seatC3Button = new Button();
        seatC4Button = new Button();
        seatC5Button = new Button();
        seatC6Button = new Button();
        seatC7Button = new Button();
        seatC8Button = new Button();
        seatDRowLabel = new Label();
        seatD1Button = new Button();
        seatD2Button = new Button();
        seatD3Button = new Button();
        seatD4Button = new Button();
        seatD5Button = new Button();
        seatD6Button = new Button();
        seatD7Button = new Button();
        seatD8Button = new Button();
        seatERowLabel = new Label();
        seatE1Button = new Button();
        seatE2Button = new Button();
        seatE3Button = new Button();
        seatE4Button = new Button();
        seatE5Button = new Button();
        seatE6Button = new Button();
        seatE7Button = new Button();
        seatE8Button = new Button();
        seatFRowLabel = new Label();
        seatF1Button = new Button();
        seatF2Button = new Button();
        seatF3Button = new Button();
        seatF4Button = new Button();
        seatF5Button = new Button();
        seatF6Button = new Button();
        seatF7Button = new Button();
        seatF8Button = new Button();
        legendPanel = new FlowLayoutPanel();
        availableLegendColorLabel = new Label();
        availableLegendTextLabel = new Label();
        selectedLegendColorLabel = new Label();
        selectedLegendTextLabel = new Label();
        soldLegendColorLabel = new Label();
        soldLegendTextLabel = new Label();
        maintenanceLegendColorLabel = new Label();
        maintenanceLegendTextLabel = new Label();
        summaryCard = new Panel();
        summaryLabel = new Label();
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        seatCard.SuspendLayout();
        seatLayout.SuspendLayout();
        summaryCard.SuspendLayout();
        SuspendLayout();
        //
        // SeatManagementForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "SeatManagementForm";
        Text = "Quản lý ghế";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(seatCard, 0, 1);
        rootLayout.Controls.Add(summaryCard, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
        //
        // filterPanel
        //
        filterPanel.BackColor = UiStyleHelper.ContentBackground;
        filterPanel.Controls.Add(roomFilterLabel);
        filterPanel.Controls.Add(roomCombo);
        filterPanel.Controls.Add(changeStatusButton);
        filterPanel.Controls.Add(maintenanceButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        StyleInlineLabel(roomFilterLabel, "Chọn phòng", 82);
        ConfigureCombo(roomCombo);
        roomCombo.Margin = new Padding(0, 18, 16, 0);
        roomCombo.Size = new Size(230, 32);
        roomCombo.Items.AddRange(new object[] { "Phòng 1 (2D)", "Phòng 2 (2D)", "Phòng 3 (3D)", "Phòng 4 (IMAX)", "Phòng VIP (VIP)" });
        roomCombo.SelectedIndex = 0;
        StylePrimaryButton(changeStatusButton, "Đổi trạng thái ghế", 154);
        StyleDangerButton(maintenanceButton, "Đặt bảo trì", 118);
        StyleSecondaryButton(refreshButton, "Làm mới", 104);
        //
        // seatCard
        //
        seatCard.BackColor = Color.White;
        seatCard.BorderStyle = BorderStyle.FixedSingle;
        seatCard.Controls.Add(seatLayout);
        seatCard.Dock = DockStyle.Fill;
        seatCard.Padding = new Padding(16);
        seatLayout.BackColor = Color.White;
        seatLayout.ColumnCount = 1;
        seatLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        seatLayout.Controls.Add(seatTitleLabel, 0, 0);
        seatLayout.Controls.Add(screenLabel, 0, 1);
        seatLayout.Controls.Add(seatPanel, 0, 2);
        seatLayout.Controls.Add(legendPanel, 0, 3);
        seatLayout.Dock = DockStyle.Fill;
        seatLayout.RowCount = 4;
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        StyleCardTitle(seatTitleLabel, "SƠ ĐỒ GHẾ THEO PHÒNG");
        screenLabel.BackColor = ColorTranslator.FromHtml("#EAF3FF");
        screenLabel.Dock = DockStyle.Fill;
        screenLabel.Font = UiStyleHelper.SectionFont(9.5F);
        screenLabel.ForeColor = UiStyleHelper.Primary;
        screenLabel.Margin = new Padding(0, 0, 0, 8);
        screenLabel.Text = "MÀN HÌNH";
        screenLabel.TextAlign = ContentAlignment.MiddleCenter;
        seatPanel.BackColor = Color.White;
        seatPanel.ColumnCount = 9;
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatPanel.Dock = DockStyle.Fill;
        seatPanel.Padding = new Padding(44, 14, 44, 14);
        seatPanel.RowCount = 6;
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPanel.Controls.Add(seatARowLabel, 0, 0);
        StyleSeatRowLabel(seatARowLabel, "A");
        seatPanel.Controls.Add(seatA1Button, 1, 0);
        StyleSeatButton(seatA1Button, "A1");
        seatPanel.Controls.Add(seatA2Button, 2, 0);
        StyleSeatButton(seatA2Button, "A2");
        seatPanel.Controls.Add(seatA3Button, 3, 0);
        StyleSeatButton(seatA3Button, "A3");
        seatPanel.Controls.Add(seatA4Button, 4, 0);
        StyleSeatButton(seatA4Button, "A4");
        seatPanel.Controls.Add(seatA5Button, 5, 0);
        StyleSeatButton(seatA5Button, "A5");
        seatPanel.Controls.Add(seatA6Button, 6, 0);
        StyleSeatButton(seatA6Button, "A6");
        seatPanel.Controls.Add(seatA7Button, 7, 0);
        StyleSeatButton(seatA7Button, "A7");
        seatPanel.Controls.Add(seatA8Button, 8, 0);
        StyleSeatButton(seatA8Button, "A8");
        seatPanel.Controls.Add(seatBRowLabel, 0, 1);
        StyleSeatRowLabel(seatBRowLabel, "B");
        seatPanel.Controls.Add(seatB1Button, 1, 1);
        StyleSeatButton(seatB1Button, "B1");
        seatPanel.Controls.Add(seatB2Button, 2, 1);
        StyleSeatButton(seatB2Button, "B2");
        seatPanel.Controls.Add(seatB3Button, 3, 1);
        StyleSeatButton(seatB3Button, "B3");
        seatPanel.Controls.Add(seatB4Button, 4, 1);
        StyleSeatButton(seatB4Button, "B4");
        seatPanel.Controls.Add(seatB5Button, 5, 1);
        StyleSeatButton(seatB5Button, "B5");
        seatPanel.Controls.Add(seatB6Button, 6, 1);
        StyleSeatButton(seatB6Button, "B6");
        seatPanel.Controls.Add(seatB7Button, 7, 1);
        StyleSeatButton(seatB7Button, "B7");
        seatPanel.Controls.Add(seatB8Button, 8, 1);
        StyleSeatButton(seatB8Button, "B8");
        seatPanel.Controls.Add(seatCRowLabel, 0, 2);
        StyleSeatRowLabel(seatCRowLabel, "C");
        seatPanel.Controls.Add(seatC1Button, 1, 2);
        StyleSeatButton(seatC1Button, "C1");
        seatPanel.Controls.Add(seatC2Button, 2, 2);
        StyleSeatButton(seatC2Button, "C2");
        seatPanel.Controls.Add(seatC3Button, 3, 2);
        StyleSeatButton(seatC3Button, "C3");
        seatPanel.Controls.Add(seatC4Button, 4, 2);
        StyleSeatButton(seatC4Button, "C4");
        seatPanel.Controls.Add(seatC5Button, 5, 2);
        StyleSeatButton(seatC5Button, "C5");
        seatPanel.Controls.Add(seatC6Button, 6, 2);
        StyleSeatButton(seatC6Button, "C6");
        seatPanel.Controls.Add(seatC7Button, 7, 2);
        StyleSeatButton(seatC7Button, "C7");
        seatPanel.Controls.Add(seatC8Button, 8, 2);
        StyleSeatButton(seatC8Button, "C8");
        seatPanel.Controls.Add(seatDRowLabel, 0, 3);
        StyleSeatRowLabel(seatDRowLabel, "D");
        seatPanel.Controls.Add(seatD1Button, 1, 3);
        StyleSeatButton(seatD1Button, "D1");
        seatPanel.Controls.Add(seatD2Button, 2, 3);
        StyleSeatButton(seatD2Button, "D2");
        seatPanel.Controls.Add(seatD3Button, 3, 3);
        StyleSeatButton(seatD3Button, "D3");
        seatPanel.Controls.Add(seatD4Button, 4, 3);
        StyleSeatButton(seatD4Button, "D4");
        seatPanel.Controls.Add(seatD5Button, 5, 3);
        StyleSeatButton(seatD5Button, "D5");
        seatPanel.Controls.Add(seatD6Button, 6, 3);
        StyleSeatButton(seatD6Button, "D6");
        seatPanel.Controls.Add(seatD7Button, 7, 3);
        StyleSeatButton(seatD7Button, "D7");
        seatPanel.Controls.Add(seatD8Button, 8, 3);
        StyleSeatButton(seatD8Button, "D8");
        seatPanel.Controls.Add(seatERowLabel, 0, 4);
        StyleSeatRowLabel(seatERowLabel, "E");
        seatPanel.Controls.Add(seatE1Button, 1, 4);
        StyleSeatButton(seatE1Button, "E1");
        seatPanel.Controls.Add(seatE2Button, 2, 4);
        StyleSeatButton(seatE2Button, "E2");
        seatPanel.Controls.Add(seatE3Button, 3, 4);
        StyleSeatButton(seatE3Button, "E3");
        seatPanel.Controls.Add(seatE4Button, 4, 4);
        StyleSeatButton(seatE4Button, "E4");
        seatPanel.Controls.Add(seatE5Button, 5, 4);
        StyleSeatButton(seatE5Button, "E5");
        seatPanel.Controls.Add(seatE6Button, 6, 4);
        StyleSeatButton(seatE6Button, "E6");
        seatPanel.Controls.Add(seatE7Button, 7, 4);
        StyleSeatButton(seatE7Button, "E7");
        seatPanel.Controls.Add(seatE8Button, 8, 4);
        StyleSeatButton(seatE8Button, "E8");
        seatPanel.Controls.Add(seatFRowLabel, 0, 5);
        StyleSeatRowLabel(seatFRowLabel, "F");
        seatPanel.Controls.Add(seatF1Button, 1, 5);
        StyleSeatButton(seatF1Button, "F1");
        seatPanel.Controls.Add(seatF2Button, 2, 5);
        StyleSeatButton(seatF2Button, "F2");
        seatPanel.Controls.Add(seatF3Button, 3, 5);
        StyleSeatButton(seatF3Button, "F3");
        seatPanel.Controls.Add(seatF4Button, 4, 5);
        StyleSeatButton(seatF4Button, "F4");
        seatPanel.Controls.Add(seatF5Button, 5, 5);
        StyleSeatButton(seatF5Button, "F5");
        seatPanel.Controls.Add(seatF6Button, 6, 5);
        StyleSeatButton(seatF6Button, "F6");
        seatPanel.Controls.Add(seatF7Button, 7, 5);
        StyleSeatButton(seatF7Button, "F7");
        seatPanel.Controls.Add(seatF8Button, 8, 5);
        StyleSeatButton(seatF8Button, "F8");
        legendPanel.BackColor = Color.White;
        legendPanel.Controls.Add(availableLegendColorLabel);
        legendPanel.Controls.Add(availableLegendTextLabel);
        legendPanel.Controls.Add(selectedLegendColorLabel);
        legendPanel.Controls.Add(selectedLegendTextLabel);
        legendPanel.Controls.Add(soldLegendColorLabel);
        legendPanel.Controls.Add(soldLegendTextLabel);
        legendPanel.Controls.Add(maintenanceLegendColorLabel);
        legendPanel.Controls.Add(maintenanceLegendTextLabel);
        legendPanel.Dock = DockStyle.Fill;
        legendPanel.FlowDirection = FlowDirection.LeftToRight;
        legendPanel.WrapContents = false;
        StyleLegendSquare(availableLegendColorLabel, UiStyleHelper.SeatAvailable);
        StyleLegendText(availableLegendTextLabel, "Trống");
        StyleLegendSquare(selectedLegendColorLabel, UiStyleHelper.SeatSelected);
        StyleLegendText(selectedLegendTextLabel, "Đang chọn");
        StyleLegendSquare(soldLegendColorLabel, UiStyleHelper.SeatSold);
        StyleLegendText(soldLegendTextLabel, "Đã bán");
        StyleLegendSquare(maintenanceLegendColorLabel, UiStyleHelper.SeatMaintenance);
        StyleLegendText(maintenanceLegendTextLabel, "Bảo trì");
        //
        // summaryCard
        //
        summaryCard.BackColor = Color.White;
        summaryCard.BorderStyle = BorderStyle.FixedSingle;
        summaryCard.Controls.Add(summaryLabel);
        summaryCard.Dock = DockStyle.Fill;
        summaryCard.Margin = new Padding(0, 10, 0, 0);
        summaryCard.Padding = new Padding(16);
        summaryLabel.Dock = DockStyle.Fill;
        summaryLabel.Font = UiStyleHelper.SectionFont(10F);
        summaryLabel.ForeColor = UiStyleHelper.TextDark;
        summaryLabel.Text = "Phòng: Phòng 1 (2D)     |     Tổng ghế demo: 48     |     Chọn một ghế để xem trạng thái.";
        summaryLabel.TextAlign = ContentAlignment.MiddleLeft;
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        seatCard.ResumeLayout(false);
        seatLayout.ResumeLayout(false);
        summaryCard.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static void StyleLegendSquare(Label label, Color color)
    {
        label.BackColor = color;
        label.BorderStyle = BorderStyle.FixedSingle;
        label.Margin = new Padding(0, 5, 6, 0);
        label.Size = new Size(20, 18);
    }

    private static void StyleLegendText(Label label, string text)
    {
        label.Font = UiStyleHelper.SmallFont(9F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 1, 18, 0);
        label.Size = new Size(74, 24);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleInlineLabel(Label label, string text, int width)
    {
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 21, 8, 0);
        label.Size = new Size(width, 28);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleCardTitle(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(10F);
        label.ForeColor = UiStyleHelper.Primary;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void ConfigureCombo(ComboBox combo)
    {
        combo.DropDownStyle = ComboBoxStyle.DropDownList;
        combo.FlatStyle = FlatStyle.Flat;
        combo.Font = UiStyleHelper.BodyFont(10F);
        combo.Height = 34;
    }

    private static void StylePrimaryButton(Button button, string text, int width)
    {
        button.BackColor = UiStyleHelper.Primary;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = Color.White;
        button.Margin = new Padding(0, 18, 8, 0);
        button.Size = new Size(width, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleSecondaryButton(Button button, string text, int width)
    {
        button.BackColor = Color.White;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = UiStyleHelper.Primary;
        button.Margin = new Padding(0, 18, 8, 0);
        button.Size = new Size(width, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleDangerButton(Button button, string text, int width)
    {
        StyleSecondaryButton(button, text, width);
        button.ForeColor = UiStyleHelper.Danger;
    }
    private static void StyleSeatRowLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(10F);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Margin = new Padding(0, 4, 10, 4);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
    }

    private static void StyleSeatButton(Button button, string seatCode)
    {
        button.BackColor = UiStyleHelper.SeatAvailable;
        button.Cursor = Cursors.Hand;
        button.Dock = DockStyle.Fill;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
        button.FlatAppearance.BorderSize = 1;
        button.Font = UiStyleHelper.SectionFont(8.75F);
        button.ForeColor = UiStyleHelper.TextDark;
        button.Margin = new Padding(6, 4, 6, 4);
        button.Name = "seat" + seatCode + "Button";
        button.Tag = seatCode;
        button.Text = seatCode;
        if (seatCode is "B5" or "B6")
        {
            button.BackColor = UiStyleHelper.SeatSelected;
            button.FlatAppearance.BorderColor = UiStyleHelper.Success;
        }
        else if (seatCode is "C3" or "C4")
        {
            button.BackColor = UiStyleHelper.SeatSold;
            button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FFA3A3");
        }
        else if (seatCode is "D7")
        {
            button.BackColor = UiStyleHelper.SeatMaintenance;
        }
        button.UseVisualStyleBackColor = false;
    }
}
