using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private Panel cinemaInfoPanel;
    private TableLayoutPanel cinemaInfoLayout;
    private TextBox cinemaNameTextBox;
    private TextBox addressTextBox;
    private TextBox hotlineTextBox;
    private TextBox emailTextBox;
    private Panel ticketConfigPanel;
    private TableLayoutPanel ticketConfigLayout;
    private TextBox defaultPriceTextBox;
    private TextBox saleWindowTextBox;
    private ComboBox ticketFormatCombo;
    private CheckBox autoPrintCheckBox;
    private Panel systemInfoPanel;
    private TableLayoutPanel systemInfoLayout;
    private Label versionValueLabel;
    private Label dataStatusValueLabel;
    private Label databaseValueLabel;
    private Label syncValueLabel;
    private Label workstationValueLabel;
    private Label serverValueLabel;
    private Label osValueLabel;
    private Panel paymentPanel;
    private TableLayoutPanel paymentLayout;
    private CheckBox cashCheckBox;
    private CheckBox vnpayCheckBox;
    private CheckBox momoCheckBox;
    private CheckBox transferCheckBox;
    private Panel permissionPanel;
    private TableLayoutPanel permissionLayout;
    private Panel appearancePanel;
    private TableLayoutPanel appearanceLayout;
    private ComboBox themeCombo;
    private ComboBox languageCombo;
    private ComboBox fontSizeCombo;
    private Button saveSettingsButton;
    private Panel backupPanel;
    private TableLayoutPanel backupLayout;
    private Label lastBackupValueLabel;
    private Label backupSizeValueLabel;
    private Button backupButton;
    private Button restoreButton;
    private Button testConnectionButton;

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
        cinemaInfoPanel = new Panel();
        cinemaInfoLayout = new TableLayoutPanel();
        cinemaNameTextBox = new TextBox();
        addressTextBox = new TextBox();
        hotlineTextBox = new TextBox();
        emailTextBox = new TextBox();
        ticketConfigPanel = new Panel();
        ticketConfigLayout = new TableLayoutPanel();
        defaultPriceTextBox = new TextBox();
        saleWindowTextBox = new TextBox();
        ticketFormatCombo = new ComboBox();
        autoPrintCheckBox = new CheckBox();
        systemInfoPanel = new Panel();
        systemInfoLayout = new TableLayoutPanel();
        versionValueLabel = new Label();
        dataStatusValueLabel = new Label();
        databaseValueLabel = new Label();
        syncValueLabel = new Label();
        workstationValueLabel = new Label();
        serverValueLabel = new Label();
        osValueLabel = new Label();
        paymentPanel = new Panel();
        paymentLayout = new TableLayoutPanel();
        cashCheckBox = new CheckBox();
        vnpayCheckBox = new CheckBox();
        momoCheckBox = new CheckBox();
        transferCheckBox = new CheckBox();
        permissionPanel = new Panel();
        permissionLayout = new TableLayoutPanel();
        appearancePanel = new Panel();
        appearanceLayout = new TableLayoutPanel();
        themeCombo = new ComboBox();
        languageCombo = new ComboBox();
        fontSizeCombo = new ComboBox();
        saveSettingsButton = new Button();
        backupPanel = new Panel();
        backupLayout = new TableLayoutPanel();
        lastBackupValueLabel = new Label();
        backupSizeValueLabel = new Label();
        backupButton = new Button();
        restoreButton = new Button();
        testConnectionButton = new Button();
        versionValueLabel.Text = "1.0.0";
        dataStatusValueLabel.Text = "Demo in-memory";
        databaseValueLabel.Text = "Chưa cấu hình database";
        syncValueLabel.Text = "26/05/2026 09:30:00";
        workstationValueLabel.Text = "COUNTER-01";
        serverValueLabel.Text = "Chưa kết nối máy chủ";
        osValueLabel.Text = "Windows";
        lastBackupValueLabel.Text = "26/05/2026 02:15";
        backupSizeValueLabel.Text = "256.45 MB";
        rootLayout.SuspendLayout();
        cinemaInfoPanel.SuspendLayout();
        cinemaInfoLayout.SuspendLayout();
        ticketConfigPanel.SuspendLayout();
        ticketConfigLayout.SuspendLayout();
        systemInfoPanel.SuspendLayout();
        systemInfoLayout.SuspendLayout();
        paymentPanel.SuspendLayout();
        paymentLayout.SuspendLayout();
        permissionPanel.SuspendLayout();
        permissionLayout.SuspendLayout();
        appearancePanel.SuspendLayout();
        appearanceLayout.SuspendLayout();
        backupPanel.SuspendLayout();
        backupLayout.SuspendLayout();
        SuspendLayout();
        //
        // SettingsForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "SettingsForm";
        Text = "Cài đặt hệ thống";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 3;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        rootLayout.Controls.Add(cinemaInfoPanel, 0, 0);
        rootLayout.Controls.Add(ticketConfigPanel, 1, 0);
        rootLayout.Controls.Add(systemInfoPanel, 2, 0);
        rootLayout.Controls.Add(paymentPanel, 0, 1);
        rootLayout.Controls.Add(permissionPanel, 1, 1);
        rootLayout.Controls.Add(appearancePanel, 0, 2);
        rootLayout.Controls.Add(backupPanel, 2, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
        rootLayout.SetRowSpan(systemInfoPanel, 2);
        rootLayout.SetColumnSpan(appearancePanel, 2);
        //
        // cinemaInfoPanel
        //
        ConfigureCard(cinemaInfoPanel, new Padding(0, 0, 12, 12));
        cinemaInfoPanel.Controls.Add(cinemaInfoLayout);
        ConfigureCardLayout(cinemaInfoLayout, 5);
        cinemaInfoLayout.Controls.Add(CreateCardTitleLabel("Thông tin rạp"), 0, 0);
        cinemaInfoLayout.Controls.Add(CreateFieldBlock("Tên rạp", cinemaNameTextBox), 0, 1);
        cinemaInfoLayout.Controls.Add(CreateFieldBlock("Địa chỉ", addressTextBox), 0, 2);
        cinemaInfoLayout.Controls.Add(CreateFieldBlock("Hotline", hotlineTextBox), 0, 3);
        cinemaInfoLayout.Controls.Add(CreateFieldBlock("Email", emailTextBox), 0, 4);
        ConfigureTextBox(cinemaNameTextBox);
        ConfigureTextBox(addressTextBox);
        ConfigureTextBox(hotlineTextBox);
        ConfigureTextBox(emailTextBox);
        cinemaNameTextBox.Text = "CinemaPro Center";
        addressTextBox.Text = "123 Nguyễn Văn Linh, Đà Nẵng";
        hotlineTextBox.Text = "0236 123 4567";
        emailTextBox.Text = "contact@cinemapro.vn";
        //
        // ticketConfigPanel
        //
        ConfigureCard(ticketConfigPanel, new Padding(0, 0, 12, 12));
        ticketConfigPanel.Controls.Add(ticketConfigLayout);
        ConfigureCardLayout(ticketConfigLayout, 5);
        ticketConfigLayout.Controls.Add(CreateCardTitleLabel("Cấu hình bán vé"), 0, 0);
        ticketConfigLayout.Controls.Add(CreateFieldBlock("Đơn giá mặc định", defaultPriceTextBox), 0, 1);
        ticketConfigLayout.Controls.Add(CreateFieldBlock("Thời gian mở bán", saleWindowTextBox), 0, 2);
        ticketConfigLayout.Controls.Add(CreateFieldBlock("Định dạng vé", ticketFormatCombo), 0, 3);
        ticketConfigLayout.Controls.Add(autoPrintCheckBox, 0, 4);
        ConfigureTextBox(defaultPriceTextBox);
        ConfigureTextBox(saleWindowTextBox);
        ConfigureCombo(ticketFormatCombo);
        ConfigureCheckBox(autoPrintCheckBox, "In vé tự động sau thanh toán");
        defaultPriceTextBox.Text = "90.000";
        saleWindowTextBox.Text = "30 ngày trước suất chiếu";
        ticketFormatCombo.Items.AddRange(new object[] { "A4 (210 x 297 mm)", "A5", "80mm thermal" });
        ticketFormatCombo.SelectedIndex = 0;
        autoPrintCheckBox.Checked = true;
        //
        // systemInfoPanel
        //
        ConfigureCard(systemInfoPanel, new Padding(0, 0, 0, 12));
        systemInfoPanel.Controls.Add(systemInfoLayout);
        ConfigureCardLayout(systemInfoLayout, 8);
        systemInfoLayout.Controls.Add(CreateCardTitleLabel("Thông tin hệ thống"), 0, 0);
        systemInfoLayout.Controls.Add(CreateInfoLine("Phiên bản phần mềm", versionValueLabel), 0, 1);
        systemInfoLayout.Controls.Add(CreateInfoLine("Nguồn dữ liệu", dataStatusValueLabel), 0, 2);
        systemInfoLayout.Controls.Add(CreateInfoLine("Database", databaseValueLabel), 0, 3);
        systemInfoLayout.Controls.Add(CreateInfoLine("Thời gian đồng bộ cuối", syncValueLabel), 0, 4);
        systemInfoLayout.Controls.Add(CreateInfoLine("Máy trạm", workstationValueLabel), 0, 5);
        systemInfoLayout.Controls.Add(CreateInfoLine("Máy chủ", serverValueLabel), 0, 6);
        systemInfoLayout.Controls.Add(CreateInfoLine("Hệ điều hành", osValueLabel), 0, 7);
        //
        // paymentPanel
        //
        ConfigureCard(paymentPanel, new Padding(0, 0, 12, 12));
        paymentPanel.Controls.Add(paymentLayout);
        ConfigureCardLayout(paymentLayout, 5);
        paymentLayout.Controls.Add(CreateCardTitleLabel("Thanh toán"), 0, 0);
        paymentLayout.Controls.Add(CreatePaymentLine("Tiền mặt", cashCheckBox), 0, 1);
        paymentLayout.Controls.Add(CreatePaymentLine("VNPAY Sandbox", vnpayCheckBox), 0, 2);
        paymentLayout.Controls.Add(CreatePaymentLine("MoMo Sandbox", momoCheckBox), 0, 3);
        paymentLayout.Controls.Add(CreatePaymentLine("Chuyển khoản", transferCheckBox), 0, 4);
        cashCheckBox.Checked = true;
        vnpayCheckBox.Checked = true;
        //
        // permissionPanel
        //
        ConfigureCard(permissionPanel, new Padding(0, 0, 12, 12));
        permissionPanel.Controls.Add(permissionLayout);
        ConfigureCardLayout(permissionLayout, 4);
        permissionLayout.Controls.Add(CreateCardTitleLabel("Tài khoản & phân quyền"), 0, 0);
        permissionLayout.Controls.Add(CreateStaticInfoLine("Admin", "3 tài khoản"), 0, 1);
        permissionLayout.Controls.Add(CreateStaticInfoLine("Staff", "12 tài khoản"), 0, 2);
        permissionLayout.Controls.Add(new Label
        {
            BackColor = ColorTranslator.FromHtml("#EAF3FF"),
            Dock = DockStyle.Fill,
            Font = UiStyleHelper.SectionFont(10F),
            ForeColor = UiStyleHelper.Primary,
            Text = "Tổng số tài khoản đang hoạt động: 15",
            TextAlign = ContentAlignment.MiddleCenter
        }, 0, 3);
        //
        // appearancePanel
        //
        ConfigureCard(appearancePanel, new Padding(0, 0, 12, 0));
        appearancePanel.Controls.Add(appearanceLayout);
        appearanceLayout.BackColor = Color.White;
        appearanceLayout.ColumnCount = 4;
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.Controls.Add(CreateCardTitleLabel("Giao diện"), 0, 0);
        appearanceLayout.Controls.Add(CreateFieldBlock("Giao diện", themeCombo), 0, 1);
        appearanceLayout.Controls.Add(CreateFieldBlock("Ngôn ngữ", languageCombo), 1, 1);
        appearanceLayout.Controls.Add(CreateFieldBlock("Cỡ chữ", fontSizeCombo), 2, 1);
        appearanceLayout.Controls.Add(saveSettingsButton, 3, 1);
        appearanceLayout.Dock = DockStyle.Fill;
        appearanceLayout.RowCount = 2;
        appearanceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        appearanceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appearanceLayout.SetColumnSpan(appearanceLayout.GetControlFromPosition(0, 0), 4);
        ConfigureCombo(themeCombo);
        ConfigureCombo(languageCombo);
        ConfigureCombo(fontSizeCombo);
        themeCombo.Items.AddRange(new object[] { "Sáng", "Tối" });
        themeCombo.SelectedIndex = 0;
        languageCombo.Items.AddRange(new object[] { "Tiếng Việt", "English" });
        languageCombo.SelectedIndex = 0;
        fontSizeCombo.Items.AddRange(new object[] { "Trung bình (M)", "Nhỏ (S)", "Lớn (L)" });
        fontSizeCombo.SelectedIndex = 0;
        StylePrimaryButton(saveSettingsButton, "Lưu cài đặt", 0);
        saveSettingsButton.Dock = DockStyle.Fill;
        saveSettingsButton.Margin = new Padding(8, 22, 0, 8);
        //
        // backupPanel
        //
        ConfigureCard(backupPanel, Padding.Empty);
        backupPanel.Controls.Add(backupLayout);
        ConfigureCardLayout(backupLayout, 5);
        backupLayout.Controls.Add(CreateCardTitleLabel("Sao lưu dữ liệu"), 0, 0);
        backupLayout.Controls.Add(CreateInfoLine("Sao lưu gần nhất", lastBackupValueLabel), 0, 1);
        backupLayout.Controls.Add(CreateInfoLine("Dung lượng bản sao lưu", backupSizeValueLabel), 0, 2);
        backupLayout.Controls.Add(CreateBackupButtonRow(), 0, 3);
        backupLayout.Controls.Add(testConnectionButton, 0, 4);
        StyleSecondaryButton(testConnectionButton, "Kiểm tra kết nối", 0);
        testConnectionButton.Dock = DockStyle.Fill;
        testConnectionButton.Margin = new Padding(0, 4, 0, 0);
        rootLayout.ResumeLayout(false);
        cinemaInfoPanel.ResumeLayout(false);
        cinemaInfoLayout.ResumeLayout(false);
        ticketConfigPanel.ResumeLayout(false);
        ticketConfigLayout.ResumeLayout(false);
        systemInfoPanel.ResumeLayout(false);
        systemInfoLayout.ResumeLayout(false);
        paymentPanel.ResumeLayout(false);
        paymentLayout.ResumeLayout(false);
        permissionPanel.ResumeLayout(false);
        permissionLayout.ResumeLayout(false);
        appearancePanel.ResumeLayout(false);
        appearanceLayout.ResumeLayout(false);
        backupPanel.ResumeLayout(false);
        backupLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel CreateBackupButtonRow()
    {
        var panel = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        StylePrimaryButton(backupButton, "Sao lưu ngay", 0);
        StyleSecondaryButton(restoreButton, "Khôi phục", 0);
        backupButton.Dock = DockStyle.Fill;
        restoreButton.Dock = DockStyle.Fill;
        backupButton.Margin = new Padding(0, 4, 6, 0);
        restoreButton.Margin = new Padding(6, 4, 0, 0);
        panel.Controls.Add(backupButton, 0, 0);
        panel.Controls.Add(restoreButton, 1, 0);
        return panel;
    }

    private static void ConfigureCard(Panel panel, Padding margin)
    {
        panel.BackColor = Color.White;
        panel.BorderStyle = BorderStyle.FixedSingle;
        panel.Dock = DockStyle.Fill;
        panel.Margin = margin;
        panel.Padding = new Padding(16);
    }

    private static void ConfigureCardLayout(TableLayoutPanel layout, int rows)
    {
        layout.BackColor = Color.White;
        layout.ColumnCount = 1;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Dock = DockStyle.Fill;
        layout.RowCount = rows;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        for (var i = 1; i < rows; i++)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / (rows - 1)));
        }
    }

    private static TableLayoutPanel CreateFieldBlock(string label, Control control)
    {
        var block = new TableLayoutPanel { ColumnCount = 1, Dock = DockStyle.Fill, RowCount = 2 };
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        block.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.25F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        control.Dock = DockStyle.Fill;
        block.Controls.Add(control, 0, 1);
        return block;
    }

    private static Label CreateCardTitleLabel(string text) => new()
    {
        Dock = DockStyle.Fill,
        Font = UiStyleHelper.SectionFont(10F),
        ForeColor = UiStyleHelper.Primary,
        Text = text.ToUpperInvariant(),
        TextAlign = ContentAlignment.MiddleLeft
    };

    private static TableLayoutPanel CreateInfoLine(string label, Label valueLabel)
    {
        var panel = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.BodyFont(9.25F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
        valueLabel.Dock = DockStyle.Fill;
        valueLabel.Font = UiStyleHelper.SectionFont(9.25F);
        valueLabel.ForeColor = UiStyleHelper.TextDark;
        valueLabel.TextAlign = ContentAlignment.MiddleRight;
        valueLabel.AutoEllipsis = true;
        panel.Controls.Add(valueLabel, 1, 0);
        return panel;
    }

    private static TableLayoutPanel CreateStaticInfoLine(string label, string value)
    {
        var valueLabel = new Label { Text = value };
        return CreateInfoLine(label, valueLabel);
    }

    private static TableLayoutPanel CreatePaymentLine(string label, CheckBox checkBox)
    {
        var panel = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        panel.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SectionFont(9.25F), ForeColor = UiStyleHelper.TextDark, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
        ConfigureCheckBox(checkBox, "Bật");
        checkBox.TextAlign = ContentAlignment.MiddleRight;
        panel.Controls.Add(checkBox, 1, 0);
        return panel;
    }

    private static void ConfigureTextBox(TextBox textBox)
    {
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Font = UiStyleHelper.BodyFont(10F);
        textBox.Height = 32;
    }

    private static void ConfigureCombo(ComboBox combo)
    {
        combo.DropDownStyle = ComboBoxStyle.DropDownList;
        combo.FlatStyle = FlatStyle.Flat;
        combo.Font = UiStyleHelper.BodyFont(10F);
        combo.Height = 34;
    }

    private static void ConfigureCheckBox(CheckBox checkBox, string text)
    {
        checkBox.Dock = DockStyle.Fill;
        checkBox.Font = UiStyleHelper.SectionFont(9.25F);
        checkBox.ForeColor = UiStyleHelper.TextDark;
        checkBox.Text = text;
        checkBox.UseVisualStyleBackColor = true;
    }

    private static void StylePrimaryButton(Button button, string text, int width)
    {
        button.BackColor = UiStyleHelper.Primary;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = Color.White;
        button.Size = new Size(width > 0 ? width : 110, 36);
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
        button.Size = new Size(width > 0 ? width : 110, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }
}
