using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class SeatManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private ComboBox roomCombo;
    private Button changeStatusButton;
    private Button maintenanceButton;
    private Button refreshButton;
    private Panel seatCard;
    private TableLayoutPanel seatLayout;
    private Label screenLabel;
    private TableLayoutPanel seatPanel;
    private FlowLayoutPanel legendPanel;
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
        roomCombo = new ComboBox();
        changeStatusButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        seatCard = new Panel();
        seatLayout = new TableLayoutPanel();
        screenLabel = new Label();
        seatPanel = new TableLayoutPanel();
        legendPanel = new FlowLayoutPanel();
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
        filterPanel.Controls.Add(CreateFilterBlock("Chọn phòng", roomCombo, 250));
        filterPanel.Controls.Add(changeStatusButton);
        filterPanel.Controls.Add(maintenanceButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        ConfigureCombo(roomCombo);
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
        seatLayout.Controls.Add(CreateCardTitleLabel("Sơ đồ ghế theo phòng"), 0, 0);
        seatLayout.Controls.Add(screenLabel, 0, 1);
        seatLayout.Controls.Add(seatPanel, 0, 2);
        seatLayout.Controls.Add(legendPanel, 0, 3);
        seatLayout.Dock = DockStyle.Fill;
        seatLayout.RowCount = 4;
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        seatLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
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
        for (var index = 0; index < 8; index++)
        {
            seatPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        }
        seatPanel.Dock = DockStyle.Fill;
        seatPanel.Padding = new Padding(44, 14, 44, 14);
        seatPanel.RowCount = 6;
        for (var index = 0; index < 6; index++)
        {
            seatPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        }
        legendPanel.BackColor = Color.White;
        legendPanel.Controls.Add(CreateLegend("Trống", UiStyleHelper.SeatAvailable));
        legendPanel.Controls.Add(CreateLegend("Đang chọn", UiStyleHelper.SeatSelected));
        legendPanel.Controls.Add(CreateLegend("Đã bán", UiStyleHelper.SeatSold));
        legendPanel.Controls.Add(CreateLegend("Bảo trì", UiStyleHelper.SeatMaintenance));
        legendPanel.Dock = DockStyle.Fill;
        legendPanel.FlowDirection = FlowDirection.LeftToRight;
        legendPanel.WrapContents = false;
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

    private static TableLayoutPanel CreateFilterBlock(string label, Control control, int width)
    {
        var block = new TableLayoutPanel { ColumnCount = 1, Height = 58, Margin = new Padding(0, 0, 12, 0), RowCount = 2, Width = width };
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        block.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.25F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        control.Dock = DockStyle.Fill;
        block.Controls.Add(control, 0, 1);
        return block;
    }

    private static Control CreateLegend(string text, Color color)
    {
        var panel = new FlowLayoutPanel { Width = 118, Height = 26, FlowDirection = FlowDirection.LeftToRight };
        panel.Controls.Add(new Label { Width = 22, Height = 18, BackColor = color, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 4, 8, 0) });
        panel.Controls.Add(new Label { Width = 80, Height = 24, Text = text, Font = UiStyleHelper.SmallFont(9F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.MiddleLeft });
        return panel;
    }

    private static Label CreateCardTitleLabel(string text) => new()
    {
        Dock = DockStyle.Fill,
        Font = UiStyleHelper.SectionFont(10F),
        ForeColor = UiStyleHelper.Primary,
        Text = text.ToUpperInvariant(),
        TextAlign = ContentAlignment.MiddleLeft
    };

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
}
