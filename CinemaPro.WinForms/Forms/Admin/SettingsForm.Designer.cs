using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private Panel cinemaInfoPanel;
    private TableLayoutPanel cinemaInfoLayout;
    private Label cinemaInfoTitleLabel;
    private Label cinemaNameLabel;
    private TextBox cinemaNameTextBox;
    private Label addressLabel;
    private TextBox addressTextBox;
    private Label hotlineLabel;
    private TextBox hotlineTextBox;
    private Label emailLabel;
    private TextBox emailTextBox;
    private Panel ticketConfigPanel;
    private TableLayoutPanel ticketConfigLayout;
    private Label ticketConfigTitleLabel;
    private Label defaultPriceLabel;
    private TextBox defaultPriceTextBox;
    private Label saleWindowLabel;
    private TextBox saleWindowTextBox;
    private Label ticketFormatLabel;
    private ComboBox ticketFormatCombo;
    private CheckBox autoPrintCheckBox;
    private Panel systemInfoPanel;
    private TableLayoutPanel systemInfoLayout;
    private Label systemInfoTitleLabel;
    private Label versionLabel;
    private Label versionValueLabel;
    private Label dataStatusLabel;
    private Label dataStatusValueLabel;
    private Label databaseLabel;
    private Label databaseValueLabel;
    private Label syncLabel;
    private Label syncValueLabel;
    private Label workstationLabel;
    private Label workstationValueLabel;
    private Label serverLabel;
    private Label serverValueLabel;
    private Label osLabel;
    private Label osValueLabel;
    private Panel paymentPanel;
    private TableLayoutPanel paymentLayout;
    private Label paymentTitleLabel;
    private Label cashPaymentLabel;
    private CheckBox cashCheckBox;
    private Label vnpayPaymentLabel;
    private CheckBox vnpayCheckBox;
    private Label momoPaymentLabel;
    private CheckBox momoCheckBox;
    private Label transferPaymentLabel;
    private CheckBox transferCheckBox;
    private Panel permissionPanel;
    private TableLayoutPanel permissionLayout;
    private Label permissionTitleLabel;
    private Label adminPermissionLabel;
    private Label adminPermissionValueLabel;
    private Label staffPermissionLabel;
    private Label staffPermissionValueLabel;
    private Label permissionSummaryLabel;
    private Panel appearancePanel;
    private TableLayoutPanel appearanceLayout;
    private Label appearanceTitleLabel;
    private Label themeLabel;
    private ComboBox themeCombo;
    private Label languageLabel;
    private ComboBox languageCombo;
    private Label fontSizeLabel;
    private ComboBox fontSizeCombo;
    private Button saveSettingsButton;
    private Panel backupPanel;
    private TableLayoutPanel backupLayout;
    private Label backupTitleLabel;
    private Label lastBackupLabel;
    private Label lastBackupValueLabel;
    private Label backupSizeLabel;
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
        rootLayout = new TableLayoutPanel();
        cinemaInfoPanel = new Panel();
        cinemaInfoLayout = new TableLayoutPanel();
        cinemaInfoTitleLabel = new Label();
        cinemaNameLabel = new Label();
        cinemaNameTextBox = new TextBox();
        addressLabel = new Label();
        addressTextBox = new TextBox();
        hotlineLabel = new Label();
        hotlineTextBox = new TextBox();
        emailLabel = new Label();
        emailTextBox = new TextBox();
        ticketConfigPanel = new Panel();
        ticketConfigLayout = new TableLayoutPanel();
        ticketConfigTitleLabel = new Label();
        defaultPriceLabel = new Label();
        defaultPriceTextBox = new TextBox();
        saleWindowLabel = new Label();
        saleWindowTextBox = new TextBox();
        ticketFormatLabel = new Label();
        ticketFormatCombo = new ComboBox();
        autoPrintCheckBox = new CheckBox();
        systemInfoPanel = new Panel();
        systemInfoLayout = new TableLayoutPanel();
        systemInfoTitleLabel = new Label();
        versionLabel = new Label();
        versionValueLabel = new Label();
        dataStatusLabel = new Label();
        dataStatusValueLabel = new Label();
        databaseLabel = new Label();
        databaseValueLabel = new Label();
        syncLabel = new Label();
        syncValueLabel = new Label();
        workstationLabel = new Label();
        workstationValueLabel = new Label();
        serverLabel = new Label();
        serverValueLabel = new Label();
        osLabel = new Label();
        osValueLabel = new Label();
        paymentPanel = new Panel();
        paymentLayout = new TableLayoutPanel();
        paymentTitleLabel = new Label();
        cashPaymentLabel = new Label();
        cashCheckBox = new CheckBox();
        vnpayPaymentLabel = new Label();
        vnpayCheckBox = new CheckBox();
        momoPaymentLabel = new Label();
        momoCheckBox = new CheckBox();
        transferPaymentLabel = new Label();
        transferCheckBox = new CheckBox();
        permissionPanel = new Panel();
        permissionLayout = new TableLayoutPanel();
        permissionTitleLabel = new Label();
        adminPermissionLabel = new Label();
        adminPermissionValueLabel = new Label();
        staffPermissionLabel = new Label();
        staffPermissionValueLabel = new Label();
        permissionSummaryLabel = new Label();
        appearancePanel = new Panel();
        appearanceLayout = new TableLayoutPanel();
        appearanceTitleLabel = new Label();
        themeLabel = new Label();
        languageLabel = new Label();
        fontSizeLabel = new Label();
        themeCombo = new ComboBox();
        languageCombo = new ComboBox();
        fontSizeCombo = new ComboBox();
        saveSettingsButton = new Button();
        backupPanel = new Panel();
        backupLayout = new TableLayoutPanel();
        backupTitleLabel = new Label();
        lastBackupLabel = new Label();
        lastBackupValueLabel = new Label();
        backupSizeLabel = new Label();
        backupSizeValueLabel = new Label();
        backupButton = new Button();
        restoreButton = new Button();
        testConnectionButton = new Button();
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
        // rootLayout
        //
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
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
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
        rootLayout.Size = new Size(1257, 827);
        rootLayout.TabIndex = 0;
        //
        // cinemaInfoPanel
        //
        cinemaInfoPanel.Controls.Add(cinemaInfoLayout);
        cinemaInfoPanel.Location = new Point(3, 4);
        cinemaInfoPanel.Margin = new Padding(3, 4, 3, 4);
        cinemaInfoPanel.Name = "cinemaInfoPanel";
        cinemaInfoPanel.Size = new Size(229, 133);
        cinemaInfoPanel.TabIndex = 0;
        //
        // cinemaInfoLayout
        //
        cinemaInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.Controls.Add(cinemaInfoTitleLabel, 0, 0);
        cinemaInfoLayout.Controls.Add(cinemaNameLabel, 0, 1);
        cinemaInfoLayout.Controls.Add(cinemaNameTextBox, 1, 1);
        cinemaInfoLayout.Controls.Add(addressLabel, 0, 2);
        cinemaInfoLayout.Controls.Add(addressTextBox, 1, 2);
        cinemaInfoLayout.Controls.Add(hotlineLabel, 0, 3);
        cinemaInfoLayout.Controls.Add(hotlineTextBox, 1, 3);
        cinemaInfoLayout.Controls.Add(emailLabel, 0, 4);
        cinemaInfoLayout.Controls.Add(emailTextBox, 1, 4);
        cinemaInfoLayout.Location = new Point(0, 0);
        cinemaInfoLayout.Margin = new Padding(3, 4, 3, 4);
        cinemaInfoLayout.Name = "cinemaInfoLayout";
        cinemaInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        cinemaInfoLayout.Size = new Size(229, 133);
        cinemaInfoLayout.TabIndex = 0;
        //
        // cinemaInfoTitleLabel
        //
        cinemaInfoLayout.SetColumnSpan(cinemaInfoTitleLabel, 2);
        cinemaInfoTitleLabel.Location = new Point(3, 0);
        cinemaInfoTitleLabel.Name = "cinemaInfoTitleLabel";
        cinemaInfoTitleLabel.Size = new Size(114, 20);
        cinemaInfoTitleLabel.TabIndex = 0;
        //
        // cinemaNameLabel
        //
        cinemaNameLabel.Location = new Point(3, 20);
        cinemaNameLabel.Name = "cinemaNameLabel";
        cinemaNameLabel.Size = new Size(14, 20);
        cinemaNameLabel.TabIndex = 1;
        //
        // cinemaNameTextBox
        //
        cinemaNameTextBox.Location = new Point(23, 24);
        cinemaNameTextBox.Margin = new Padding(3, 4, 3, 4);
        cinemaNameTextBox.Name = "cinemaNameTextBox";
        cinemaNameTextBox.Size = new Size(114, 27);
        cinemaNameTextBox.TabIndex = 2;
        //
        // addressLabel
        //
        addressLabel.Location = new Point(3, 40);
        addressLabel.Name = "addressLabel";
        addressLabel.Size = new Size(14, 20);
        addressLabel.TabIndex = 3;
        //
        // addressTextBox
        //
        addressTextBox.Location = new Point(23, 44);
        addressTextBox.Margin = new Padding(3, 4, 3, 4);
        addressTextBox.Name = "addressTextBox";
        addressTextBox.Size = new Size(114, 27);
        addressTextBox.TabIndex = 4;
        //
        // hotlineLabel
        //
        hotlineLabel.Location = new Point(3, 60);
        hotlineLabel.Name = "hotlineLabel";
        hotlineLabel.Size = new Size(14, 20);
        hotlineLabel.TabIndex = 5;
        //
        // hotlineTextBox
        //
        hotlineTextBox.Location = new Point(23, 64);
        hotlineTextBox.Margin = new Padding(3, 4, 3, 4);
        hotlineTextBox.Name = "hotlineTextBox";
        hotlineTextBox.Size = new Size(114, 27);
        hotlineTextBox.TabIndex = 6;
        //
        // emailLabel
        //
        emailLabel.Location = new Point(3, 80);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(14, 31);
        emailLabel.TabIndex = 7;
        //
        // emailTextBox
        //
        emailTextBox.Location = new Point(23, 84);
        emailTextBox.Margin = new Padding(3, 4, 3, 4);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(114, 27);
        emailTextBox.TabIndex = 8;
        //
        // ticketConfigPanel
        //
        ticketConfigPanel.Controls.Add(ticketConfigLayout);
        ticketConfigPanel.Location = new Point(430, 4);
        ticketConfigPanel.Margin = new Padding(3, 4, 3, 4);
        ticketConfigPanel.Name = "ticketConfigPanel";
        ticketConfigPanel.Size = new Size(229, 133);
        ticketConfigPanel.TabIndex = 1;
        //
        // ticketConfigLayout
        //
        ticketConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.Controls.Add(ticketConfigTitleLabel, 0, 0);
        ticketConfigLayout.Controls.Add(defaultPriceLabel, 0, 1);
        ticketConfigLayout.Controls.Add(defaultPriceTextBox, 1, 1);
        ticketConfigLayout.Controls.Add(saleWindowLabel, 0, 2);
        ticketConfigLayout.Controls.Add(saleWindowTextBox, 1, 2);
        ticketConfigLayout.Controls.Add(ticketFormatLabel, 0, 3);
        ticketConfigLayout.Controls.Add(ticketFormatCombo, 1, 3);
        ticketConfigLayout.Controls.Add(autoPrintCheckBox, 0, 4);
        ticketConfigLayout.Location = new Point(0, 0);
        ticketConfigLayout.Margin = new Padding(3, 4, 3, 4);
        ticketConfigLayout.Name = "ticketConfigLayout";
        ticketConfigLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        ticketConfigLayout.Size = new Size(229, 133);
        ticketConfigLayout.TabIndex = 0;
        //
        // ticketConfigTitleLabel
        //
        ticketConfigLayout.SetColumnSpan(ticketConfigTitleLabel, 2);
        ticketConfigTitleLabel.Location = new Point(3, 0);
        ticketConfigTitleLabel.Name = "ticketConfigTitleLabel";
        ticketConfigTitleLabel.Size = new Size(114, 20);
        ticketConfigTitleLabel.TabIndex = 0;
        //
        // defaultPriceLabel
        //
        defaultPriceLabel.Location = new Point(3, 20);
        defaultPriceLabel.Name = "defaultPriceLabel";
        defaultPriceLabel.Size = new Size(14, 20);
        defaultPriceLabel.TabIndex = 1;
        //
        // defaultPriceTextBox
        //
        defaultPriceTextBox.Location = new Point(23, 24);
        defaultPriceTextBox.Margin = new Padding(3, 4, 3, 4);
        defaultPriceTextBox.Name = "defaultPriceTextBox";
        defaultPriceTextBox.Size = new Size(114, 27);
        defaultPriceTextBox.TabIndex = 2;
        //
        // saleWindowLabel
        //
        saleWindowLabel.Location = new Point(3, 40);
        saleWindowLabel.Name = "saleWindowLabel";
        saleWindowLabel.Size = new Size(14, 20);
        saleWindowLabel.TabIndex = 3;
        //
        // saleWindowTextBox
        //
        saleWindowTextBox.Location = new Point(23, 44);
        saleWindowTextBox.Margin = new Padding(3, 4, 3, 4);
        saleWindowTextBox.Name = "saleWindowTextBox";
        saleWindowTextBox.Size = new Size(114, 27);
        saleWindowTextBox.TabIndex = 4;
        //
        // ticketFormatLabel
        //
        ticketFormatLabel.Location = new Point(3, 60);
        ticketFormatLabel.Name = "ticketFormatLabel";
        ticketFormatLabel.Size = new Size(14, 20);
        ticketFormatLabel.TabIndex = 5;
        //
        // ticketFormatCombo
        //
        ticketFormatCombo.Items.AddRange(new object[] { "A4 (210 x 297 mm)", "A5", "80mm thermal" });
        ticketFormatCombo.Location = new Point(23, 64);
        ticketFormatCombo.Margin = new Padding(3, 4, 3, 4);
        ticketFormatCombo.Name = "ticketFormatCombo";
        ticketFormatCombo.Size = new Size(138, 28);
        ticketFormatCombo.TabIndex = 6;
        //
        // autoPrintCheckBox
        //
        autoPrintCheckBox.Checked = true;
        autoPrintCheckBox.CheckState = CheckState.Checked;
        ticketConfigLayout.SetColumnSpan(autoPrintCheckBox, 2);
        autoPrintCheckBox.Location = new Point(3, 84);
        autoPrintCheckBox.Margin = new Padding(3, 4, 3, 4);
        autoPrintCheckBox.Name = "autoPrintCheckBox";
        autoPrintCheckBox.Size = new Size(119, 32);
        autoPrintCheckBox.TabIndex = 7;
        //
        // systemInfoPanel
        //
        systemInfoPanel.Controls.Add(systemInfoLayout);
        systemInfoPanel.Location = new Point(857, 4);
        systemInfoPanel.Margin = new Padding(3, 4, 3, 4);
        systemInfoPanel.Name = "systemInfoPanel";
        rootLayout.SetRowSpan(systemInfoPanel, 2);
        systemInfoPanel.Size = new Size(229, 133);
        systemInfoPanel.TabIndex = 2;
        //
        // systemInfoLayout
        //
        systemInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        systemInfoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        systemInfoLayout.Controls.Add(systemInfoTitleLabel, 0, 0);
        systemInfoLayout.Controls.Add(versionLabel, 0, 1);
        systemInfoLayout.Controls.Add(versionValueLabel, 1, 1);
        systemInfoLayout.Controls.Add(dataStatusLabel, 0, 2);
        systemInfoLayout.Controls.Add(dataStatusValueLabel, 1, 2);
        systemInfoLayout.Controls.Add(databaseLabel, 0, 3);
        systemInfoLayout.Controls.Add(databaseValueLabel, 1, 3);
        systemInfoLayout.Controls.Add(syncLabel, 0, 4);
        systemInfoLayout.Controls.Add(syncValueLabel, 1, 4);
        systemInfoLayout.Controls.Add(workstationLabel, 0, 5);
        systemInfoLayout.Controls.Add(workstationValueLabel, 1, 5);
        systemInfoLayout.Controls.Add(serverLabel, 0, 6);
        systemInfoLayout.Controls.Add(serverValueLabel, 1, 6);
        systemInfoLayout.Controls.Add(osLabel, 0, 7);
        systemInfoLayout.Controls.Add(osValueLabel, 1, 7);
        systemInfoLayout.Location = new Point(0, 0);
        systemInfoLayout.Margin = new Padding(3, 4, 3, 4);
        systemInfoLayout.Name = "systemInfoLayout";
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        systemInfoLayout.Size = new Size(229, 133);
        systemInfoLayout.TabIndex = 0;
        //
        // systemInfoTitleLabel
        //
        systemInfoLayout.SetColumnSpan(systemInfoTitleLabel, 2);
        systemInfoTitleLabel.Location = new Point(3, 0);
        systemInfoTitleLabel.Name = "systemInfoTitleLabel";
        systemInfoTitleLabel.Size = new Size(114, 20);
        systemInfoTitleLabel.TabIndex = 0;
        //
        // versionLabel
        //
        versionLabel.Location = new Point(3, 20);
        versionLabel.Name = "versionLabel";
        versionLabel.Size = new Size(14, 20);
        versionLabel.TabIndex = 1;
        //
        // versionValueLabel
        //
        versionValueLabel.Location = new Point(23, 20);
        versionValueLabel.Name = "versionValueLabel";
        versionValueLabel.Size = new Size(114, 20);
        versionValueLabel.TabIndex = 2;
        //
        // dataStatusLabel
        //
        dataStatusLabel.Location = new Point(3, 40);
        dataStatusLabel.Name = "dataStatusLabel";
        dataStatusLabel.Size = new Size(14, 20);
        dataStatusLabel.TabIndex = 3;
        //
        // dataStatusValueLabel
        //
        dataStatusValueLabel.Location = new Point(23, 40);
        dataStatusValueLabel.Name = "dataStatusValueLabel";
        dataStatusValueLabel.Size = new Size(114, 20);
        dataStatusValueLabel.TabIndex = 4;
        //
        // databaseLabel
        //
        databaseLabel.Location = new Point(3, 60);
        databaseLabel.Name = "databaseLabel";
        databaseLabel.Size = new Size(14, 20);
        databaseLabel.TabIndex = 5;
        //
        // databaseValueLabel
        //
        databaseValueLabel.Location = new Point(23, 60);
        databaseValueLabel.Name = "databaseValueLabel";
        databaseValueLabel.Size = new Size(114, 20);
        databaseValueLabel.TabIndex = 6;
        //
        // syncLabel
        //
        syncLabel.Location = new Point(3, 80);
        syncLabel.Name = "syncLabel";
        syncLabel.Size = new Size(14, 20);
        syncLabel.TabIndex = 7;
        //
        // syncValueLabel
        //
        syncValueLabel.Location = new Point(23, 80);
        syncValueLabel.Name = "syncValueLabel";
        syncValueLabel.Size = new Size(114, 20);
        syncValueLabel.TabIndex = 8;
        //
        // workstationLabel
        //
        workstationLabel.Location = new Point(3, 100);
        workstationLabel.Name = "workstationLabel";
        workstationLabel.Size = new Size(14, 20);
        workstationLabel.TabIndex = 9;
        //
        // workstationValueLabel
        //
        workstationValueLabel.Location = new Point(23, 100);
        workstationValueLabel.Name = "workstationValueLabel";
        workstationValueLabel.Size = new Size(114, 20);
        workstationValueLabel.TabIndex = 10;
        //
        // serverLabel
        //
        serverLabel.Location = new Point(3, 120);
        serverLabel.Name = "serverLabel";
        serverLabel.Size = new Size(14, 20);
        serverLabel.TabIndex = 11;
        //
        // serverValueLabel
        //
        serverValueLabel.Location = new Point(23, 120);
        serverValueLabel.Name = "serverValueLabel";
        serverValueLabel.Size = new Size(114, 20);
        serverValueLabel.TabIndex = 12;
        //
        // osLabel
        //
        osLabel.Location = new Point(3, 140);
        osLabel.Name = "osLabel";
        osLabel.Size = new Size(14, 20);
        osLabel.TabIndex = 13;
        //
        // osValueLabel
        //
        osValueLabel.Location = new Point(23, 140);
        osValueLabel.Name = "osValueLabel";
        osValueLabel.Size = new Size(114, 20);
        osValueLabel.TabIndex = 14;
        //
        // paymentPanel
        //
        paymentPanel.Controls.Add(paymentLayout);
        paymentPanel.Location = new Point(3, 318);
        paymentPanel.Margin = new Padding(3, 4, 3, 4);
        paymentPanel.Name = "paymentPanel";
        paymentPanel.Size = new Size(229, 133);
        paymentPanel.TabIndex = 3;
        //
        // paymentLayout
        //
        paymentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        paymentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        paymentLayout.Controls.Add(paymentTitleLabel, 0, 0);
        paymentLayout.Controls.Add(cashPaymentLabel, 0, 1);
        paymentLayout.Controls.Add(cashCheckBox, 1, 1);
        paymentLayout.Controls.Add(vnpayPaymentLabel, 0, 2);
        paymentLayout.Controls.Add(vnpayCheckBox, 1, 2);
        paymentLayout.Controls.Add(momoPaymentLabel, 0, 3);
        paymentLayout.Controls.Add(momoCheckBox, 1, 3);
        paymentLayout.Controls.Add(transferPaymentLabel, 0, 4);
        paymentLayout.Controls.Add(transferCheckBox, 1, 4);
        paymentLayout.Location = new Point(0, 0);
        paymentLayout.Margin = new Padding(3, 4, 3, 4);
        paymentLayout.Name = "paymentLayout";
        paymentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        paymentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        paymentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        paymentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        paymentLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        paymentLayout.Size = new Size(229, 133);
        paymentLayout.TabIndex = 0;
        //
        // paymentTitleLabel
        //
        paymentLayout.SetColumnSpan(paymentTitleLabel, 2);
        paymentTitleLabel.Location = new Point(3, 0);
        paymentTitleLabel.Name = "paymentTitleLabel";
        paymentTitleLabel.Size = new Size(114, 20);
        paymentTitleLabel.TabIndex = 0;
        //
        // cashPaymentLabel
        //
        cashPaymentLabel.Location = new Point(3, 20);
        cashPaymentLabel.Name = "cashPaymentLabel";
        cashPaymentLabel.Size = new Size(14, 20);
        cashPaymentLabel.TabIndex = 1;
        //
        // cashCheckBox
        //
        cashCheckBox.Checked = true;
        cashCheckBox.CheckState = CheckState.Checked;
        cashCheckBox.Location = new Point(23, 24);
        cashCheckBox.Margin = new Padding(3, 4, 3, 4);
        cashCheckBox.Name = "cashCheckBox";
        cashCheckBox.Size = new Size(119, 12);
        cashCheckBox.TabIndex = 2;
        //
        // vnpayPaymentLabel
        //
        vnpayPaymentLabel.Location = new Point(3, 40);
        vnpayPaymentLabel.Name = "vnpayPaymentLabel";
        vnpayPaymentLabel.Size = new Size(14, 20);
        vnpayPaymentLabel.TabIndex = 3;
        //
        // vnpayCheckBox
        //
        vnpayCheckBox.Checked = true;
        vnpayCheckBox.CheckState = CheckState.Checked;
        vnpayCheckBox.Location = new Point(23, 44);
        vnpayCheckBox.Margin = new Padding(3, 4, 3, 4);
        vnpayCheckBox.Name = "vnpayCheckBox";
        vnpayCheckBox.Size = new Size(119, 12);
        vnpayCheckBox.TabIndex = 4;
        //
        // momoPaymentLabel
        //
        momoPaymentLabel.Location = new Point(3, 60);
        momoPaymentLabel.Name = "momoPaymentLabel";
        momoPaymentLabel.Size = new Size(14, 20);
        momoPaymentLabel.TabIndex = 5;
        //
        // momoCheckBox
        //
        momoCheckBox.Location = new Point(23, 64);
        momoCheckBox.Margin = new Padding(3, 4, 3, 4);
        momoCheckBox.Name = "momoCheckBox";
        momoCheckBox.Size = new Size(119, 12);
        momoCheckBox.TabIndex = 6;
        //
        // transferPaymentLabel
        //
        transferPaymentLabel.Location = new Point(3, 80);
        transferPaymentLabel.Name = "transferPaymentLabel";
        transferPaymentLabel.Size = new Size(14, 31);
        transferPaymentLabel.TabIndex = 7;
        //
        // transferCheckBox
        //
        transferCheckBox.Location = new Point(23, 84);
        transferCheckBox.Margin = new Padding(3, 4, 3, 4);
        transferCheckBox.Name = "transferCheckBox";
        transferCheckBox.Size = new Size(119, 32);
        transferCheckBox.TabIndex = 8;
        //
        // permissionPanel
        //
        permissionPanel.Controls.Add(permissionLayout);
        permissionPanel.Location = new Point(430, 318);
        permissionPanel.Margin = new Padding(3, 4, 3, 4);
        permissionPanel.Name = "permissionPanel";
        permissionPanel.Size = new Size(229, 133);
        permissionPanel.TabIndex = 4;
        //
        // permissionLayout
        //
        permissionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        permissionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        permissionLayout.Controls.Add(permissionTitleLabel, 0, 0);
        permissionLayout.Controls.Add(adminPermissionLabel, 0, 1);
        permissionLayout.Controls.Add(adminPermissionValueLabel, 1, 1);
        permissionLayout.Controls.Add(staffPermissionLabel, 0, 2);
        permissionLayout.Controls.Add(staffPermissionValueLabel, 1, 2);
        permissionLayout.Controls.Add(permissionSummaryLabel, 0, 3);
        permissionLayout.Location = new Point(0, 0);
        permissionLayout.Margin = new Padding(3, 4, 3, 4);
        permissionLayout.Name = "permissionLayout";
        permissionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        permissionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        permissionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        permissionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        permissionLayout.Size = new Size(229, 133);
        permissionLayout.TabIndex = 0;
        //
        // permissionTitleLabel
        //
        permissionLayout.SetColumnSpan(permissionTitleLabel, 2);
        permissionTitleLabel.Location = new Point(3, 0);
        permissionTitleLabel.Name = "permissionTitleLabel";
        permissionTitleLabel.Size = new Size(114, 20);
        permissionTitleLabel.TabIndex = 0;
        //
        // adminPermissionLabel
        //
        adminPermissionLabel.Location = new Point(3, 20);
        adminPermissionLabel.Name = "adminPermissionLabel";
        adminPermissionLabel.Size = new Size(14, 20);
        adminPermissionLabel.TabIndex = 1;
        //
        // adminPermissionValueLabel
        //
        adminPermissionValueLabel.Location = new Point(23, 20);
        adminPermissionValueLabel.Name = "adminPermissionValueLabel";
        adminPermissionValueLabel.Size = new Size(114, 20);
        adminPermissionValueLabel.TabIndex = 2;
        //
        // staffPermissionLabel
        //
        staffPermissionLabel.Location = new Point(3, 40);
        staffPermissionLabel.Name = "staffPermissionLabel";
        staffPermissionLabel.Size = new Size(14, 20);
        staffPermissionLabel.TabIndex = 3;
        //
        // staffPermissionValueLabel
        //
        staffPermissionValueLabel.Location = new Point(23, 40);
        staffPermissionValueLabel.Name = "staffPermissionValueLabel";
        staffPermissionValueLabel.Size = new Size(114, 20);
        staffPermissionValueLabel.TabIndex = 4;
        //
        // permissionSummaryLabel
        //
        permissionSummaryLabel.BackColor = Color.FromArgb(234, 243, 255);
        permissionLayout.SetColumnSpan(permissionSummaryLabel, 2);
        permissionSummaryLabel.Dock = DockStyle.Fill;
        permissionSummaryLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        permissionSummaryLabel.ForeColor = Color.FromArgb(13, 110, 253);
        permissionSummaryLabel.Location = new Point(3, 60);
        permissionSummaryLabel.Name = "permissionSummaryLabel";
        permissionSummaryLabel.Size = new Size(223, 73);
        permissionSummaryLabel.TabIndex = 5;
        permissionSummaryLabel.Text = "Tổng số tài khoản hoạt động: 15";
        permissionSummaryLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // appearancePanel
        //
        rootLayout.SetColumnSpan(appearancePanel, 2);
        appearancePanel.Controls.Add(appearanceLayout);
        appearancePanel.Location = new Point(3, 599);
        appearancePanel.Margin = new Padding(3, 4, 3, 4);
        appearancePanel.Name = "appearancePanel";
        appearancePanel.Size = new Size(229, 133);
        appearancePanel.TabIndex = 5;
        //
        // appearanceLayout
        //
        appearanceLayout.BackColor = Color.White;
        appearanceLayout.ColumnCount = 4;
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        appearanceLayout.Controls.Add(appearanceTitleLabel, 0, 0);
        appearanceLayout.Controls.Add(themeLabel, 0, 1);
        appearanceLayout.Controls.Add(languageLabel, 1, 1);
        appearanceLayout.Controls.Add(fontSizeLabel, 2, 1);
        appearanceLayout.Controls.Add(themeCombo, 0, 2);
        appearanceLayout.Controls.Add(languageCombo, 1, 2);
        appearanceLayout.Controls.Add(fontSizeCombo, 2, 2);
        appearanceLayout.Controls.Add(saveSettingsButton, 3, 2);
        appearanceLayout.Dock = DockStyle.Fill;
        appearanceLayout.Location = new Point(0, 0);
        appearanceLayout.Margin = new Padding(3, 4, 3, 4);
        appearanceLayout.Name = "appearanceLayout";
        appearanceLayout.RowCount = 3;
        appearanceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        appearanceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        appearanceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        appearanceLayout.Size = new Size(229, 133);
        appearanceLayout.TabIndex = 0;
        //
        // appearanceTitleLabel
        //
        appearanceLayout.SetColumnSpan(appearanceTitleLabel, 4);
        appearanceTitleLabel.Location = new Point(3, 0);
        appearanceTitleLabel.Name = "appearanceTitleLabel";
        appearanceTitleLabel.Size = new Size(114, 31);
        appearanceTitleLabel.TabIndex = 0;
        //
        // themeLabel
        //
        themeLabel.Location = new Point(3, 40);
        themeLabel.Name = "themeLabel";
        themeLabel.Size = new Size(50, 31);
        themeLabel.TabIndex = 1;
        //
        // languageLabel
        //
        languageLabel.Location = new Point(60, 40);
        languageLabel.Name = "languageLabel";
        languageLabel.Size = new Size(50, 31);
        languageLabel.TabIndex = 2;
        //
        // fontSizeLabel
        //
        fontSizeLabel.Location = new Point(117, 40);
        fontSizeLabel.Name = "fontSizeLabel";
        fontSizeLabel.Size = new Size(50, 31);
        fontSizeLabel.TabIndex = 3;
        //
        // themeCombo
        //
        themeCombo.Items.AddRange(new object[] { "Sáng", "Tối" });
        themeCombo.Location = new Point(3, 76);
        themeCombo.Margin = new Padding(3, 4, 3, 4);
        themeCombo.Name = "themeCombo";
        themeCombo.Size = new Size(50, 28);
        themeCombo.TabIndex = 4;
        //
        // languageCombo
        //
        languageCombo.Items.AddRange(new object[] { "Tiếng Việt", "English" });
        languageCombo.Location = new Point(60, 76);
        languageCombo.Margin = new Padding(3, 4, 3, 4);
        languageCombo.Name = "languageCombo";
        languageCombo.Size = new Size(50, 28);
        languageCombo.TabIndex = 5;
        //
        // fontSizeCombo
        //
        fontSizeCombo.Items.AddRange(new object[] { "Trung bình (M)", "Nhỏ (S)", "Lớn (L)" });
        fontSizeCombo.Location = new Point(117, 76);
        fontSizeCombo.Margin = new Padding(3, 4, 3, 4);
        fontSizeCombo.Name = "fontSizeCombo";
        fontSizeCombo.Size = new Size(50, 28);
        fontSizeCombo.TabIndex = 6;
        //
        // saveSettingsButton
        //
        saveSettingsButton.Dock = DockStyle.Fill;
        saveSettingsButton.Location = new Point(180, 72);
        saveSettingsButton.Margin = new Padding(9, 0, 0, 0);
        saveSettingsButton.Name = "saveSettingsButton";
        saveSettingsButton.Size = new Size(49, 61);
        saveSettingsButton.TabIndex = 7;
        //
        // backupPanel
        //
        backupPanel.Controls.Add(backupLayout);
        backupPanel.Location = new Point(857, 599);
        backupPanel.Margin = new Padding(3, 4, 3, 4);
        backupPanel.Name = "backupPanel";
        backupPanel.Size = new Size(229, 133);
        backupPanel.TabIndex = 6;
        //
        // backupLayout
        //
        backupLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        backupLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        backupLayout.Controls.Add(backupTitleLabel, 0, 0);
        backupLayout.Controls.Add(lastBackupLabel, 0, 1);
        backupLayout.Controls.Add(lastBackupValueLabel, 1, 1);
        backupLayout.Controls.Add(backupSizeLabel, 0, 2);
        backupLayout.Controls.Add(backupSizeValueLabel, 1, 2);
        backupLayout.Controls.Add(backupButton, 0, 3);
        backupLayout.Controls.Add(restoreButton, 1, 3);
        backupLayout.Controls.Add(testConnectionButton, 0, 4);
        backupLayout.Location = new Point(0, 0);
        backupLayout.Margin = new Padding(3, 4, 3, 4);
        backupLayout.Name = "backupLayout";
        backupLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        backupLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        backupLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        backupLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        backupLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        backupLayout.Size = new Size(229, 133);
        backupLayout.TabIndex = 0;
        //
        // backupTitleLabel
        //
        backupLayout.SetColumnSpan(backupTitleLabel, 2);
        backupTitleLabel.Location = new Point(3, 0);
        backupTitleLabel.Name = "backupTitleLabel";
        backupTitleLabel.Size = new Size(114, 20);
        backupTitleLabel.TabIndex = 0;
        //
        // lastBackupLabel
        //
        lastBackupLabel.Location = new Point(3, 20);
        lastBackupLabel.Name = "lastBackupLabel";
        lastBackupLabel.Size = new Size(14, 20);
        lastBackupLabel.TabIndex = 1;
        //
        // lastBackupValueLabel
        //
        lastBackupValueLabel.Location = new Point(23, 20);
        lastBackupValueLabel.Name = "lastBackupValueLabel";
        lastBackupValueLabel.Size = new Size(114, 20);
        lastBackupValueLabel.TabIndex = 2;
        //
        // backupSizeLabel
        //
        backupSizeLabel.Location = new Point(3, 40);
        backupSizeLabel.Name = "backupSizeLabel";
        backupSizeLabel.Size = new Size(14, 20);
        backupSizeLabel.TabIndex = 3;
        //
        // backupSizeValueLabel
        //
        backupSizeValueLabel.Location = new Point(23, 40);
        backupSizeValueLabel.Name = "backupSizeValueLabel";
        backupSizeValueLabel.Size = new Size(114, 20);
        backupSizeValueLabel.TabIndex = 4;
        //
        // backupButton
        //
        backupButton.Dock = DockStyle.Fill;
        backupButton.Location = new Point(0, 65);
        backupButton.Margin = new Padding(0, 5, 7, 0);
        backupButton.Name = "backupButton";
        backupButton.Size = new Size(13, 15);
        backupButton.TabIndex = 5;
        //
        // restoreButton
        //
        restoreButton.Dock = DockStyle.Fill;
        restoreButton.Location = new Point(27, 65);
        restoreButton.Margin = new Padding(7, 5, 0, 0);
        restoreButton.Name = "restoreButton";
        restoreButton.Size = new Size(202, 15);
        restoreButton.TabIndex = 6;
        //
        // testConnectionButton
        //
        backupLayout.SetColumnSpan(testConnectionButton, 2);
        testConnectionButton.Dock = DockStyle.Fill;
        testConnectionButton.Location = new Point(0, 85);
        testConnectionButton.Margin = new Padding(0, 5, 0, 0);
        testConnectionButton.Name = "testConnectionButton";
        testConnectionButton.Size = new Size(229, 48);
        testConnectionButton.TabIndex = 7;
        //
        // SettingsForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SettingsForm";
        Text = "Cài đặt hệ thống";
        rootLayout.ResumeLayout(false);
        cinemaInfoPanel.ResumeLayout(false);
        cinemaInfoLayout.ResumeLayout(false);
        cinemaInfoLayout.PerformLayout();
        ticketConfigPanel.ResumeLayout(false);
        ticketConfigLayout.ResumeLayout(false);
        ticketConfigLayout.PerformLayout();
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

    private static void ConfigureCard(Panel panel, Padding margin)
    {
        panel.BackColor = Color.White;
        panel.BorderStyle = BorderStyle.FixedSingle;
        panel.Dock = DockStyle.Fill;
        panel.Margin = margin;
        panel.Padding = new Padding(16);
    }

    private static void ConfigureTwoColumnCardLayout(TableLayoutPanel layout, int rows, int labelWidth)
    {
        layout.BackColor = Color.White;
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, labelWidth));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Dock = DockStyle.Fill;
        layout.RowCount = rows;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        AddRemainingRowStyles(layout, rows);
    }

    private static void AddRemainingRowStyles(TableLayoutPanel layout, int rows)
    {
        if (rows == 4)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            return;
        }

        if (rows == 5)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            return;
        }

        if (rows == 8)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.32F));
        }
    }

    private static void StyleCardTitle(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(10F);
        label.ForeColor = UiStyleHelper.Primary;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleFieldLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 0, 8, 0);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleValueLabel(Label label, string text)
    {
        label.AutoEllipsis = true;
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SectionFont(9.25F);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleRight;
    }

    private static void ConfigureTextBox(TextBox textBox, string text)
    {
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Dock = DockStyle.Fill;
        textBox.Font = UiStyleHelper.BodyFont(10F);
        textBox.Margin = new Padding(0, 8, 0, 8);
        textBox.Text = text;
    }

    private static void ConfigureCombo(ComboBox combo)
    {
        combo.Dock = DockStyle.Fill;
        combo.DropDownStyle = ComboBoxStyle.DropDownList;
        combo.FlatStyle = FlatStyle.Flat;
        combo.Font = UiStyleHelper.BodyFont(10F);
        combo.Margin = new Padding(0, 8, 0, 8);
    }

    private static void ConfigureCheckBox(CheckBox checkBox, string text)
    {
        checkBox.Dock = DockStyle.Fill;
        checkBox.Font = UiStyleHelper.SectionFont(9.25F);
        checkBox.ForeColor = UiStyleHelper.TextDark;
        checkBox.Text = text;
        checkBox.TextAlign = ContentAlignment.MiddleRight;
        checkBox.UseVisualStyleBackColor = true;
    }

    private static void StylePrimaryButton(Button button, string text)
    {
        button.BackColor = UiStyleHelper.Primary;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = Color.White;
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleSecondaryButton(Button button, string text)
    {
        button.BackColor = Color.White;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = UiStyleHelper.Primary;
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }
}
