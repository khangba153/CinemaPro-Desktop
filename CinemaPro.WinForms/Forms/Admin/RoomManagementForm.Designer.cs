using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class RoomManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Label totalRoomsValueLabel;
    private Label activeRoomsValueLabel;
    private Label totalSeatsValueLabel;
    private Label maintenanceRoomsValueLabel;
    private FlowLayoutPanel actionPanel;
    private Button addRoomButton;
    private Button updateRoomButton;
    private Button createSeatsButton;
    private Button maintenanceButton;
    private Button refreshButton;
    private TableLayoutPanel contentLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private DataGridView roomGrid;
    private TableLayoutPanel rightLayout;
    private Panel editorPanel;
    private TableLayoutPanel editorLayout;
    private TextBox roomNameTextBox;
    private ComboBox roomTypeCombo;
    private TextBox rowCountTextBox;
    private TextBox seatsPerRowTextBox;
    private ComboBox roomStatusCombo;
    private Label detailLabel;
    private Panel previewPanel;
    private TableLayoutPanel previewLayout;
    private TableLayoutPanel seatPreviewPanel;

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
        statLayout = new TableLayoutPanel();
        totalRoomsValueLabel = new StatCardLabel { Caption = "Tổng phòng", Note = "Tất cả phòng chiếu", AccentColor = UiStyleHelper.Primary };
        activeRoomsValueLabel = new StatCardLabel { Caption = "Đang hoạt động", Note = "Sẵn sàng bán vé", AccentColor = UiStyleHelper.Success };
        totalSeatsValueLabel = new StatCardLabel { Caption = "Tổng ghế", Note = "Theo cấu hình phòng", AccentColor = UiStyleHelper.Accent };
        maintenanceRoomsValueLabel = new StatCardLabel { Caption = "Bảo trì", Note = "Cần kiểm tra", AccentColor = UiStyleHelper.Danger };
        actionPanel = new FlowLayoutPanel();
        addRoomButton = new Button();
        updateRoomButton = new Button();
        createSeatsButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        contentLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        roomGrid = new DataGridView();
        rightLayout = new TableLayoutPanel();
        editorPanel = new Panel();
        editorLayout = new TableLayoutPanel();
        roomNameTextBox = new TextBox();
        roomTypeCombo = new ComboBox();
        rowCountTextBox = new TextBox();
        seatsPerRowTextBox = new TextBox();
        roomStatusCombo = new ComboBox();
        detailLabel = new Label();
        previewPanel = new Panel();
        previewLayout = new TableLayoutPanel();
        seatPreviewPanel = new TableLayoutPanel();
        totalRoomsValueLabel.Text = "5";
        activeRoomsValueLabel.Text = "4";
        totalSeatsValueLabel.Text = "398";
        maintenanceRoomsValueLabel.Text = "1";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        actionPanel.SuspendLayout();
        contentLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)roomGrid).BeginInit();
        rightLayout.SuspendLayout();
        editorPanel.SuspendLayout();
        editorLayout.SuspendLayout();
        previewPanel.SuspendLayout();
        previewLayout.SuspendLayout();
        SuspendLayout();
        //
        // RoomManagementForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "RoomManagementForm";
        Text = "Quản lý phòng chiếu";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(statLayout, 0, 0);
        rootLayout.Controls.Add(actionPanel, 0, 1);
        rootLayout.Controls.Add(contentLayout, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // statLayout
        //
        statLayout.BackColor = UiStyleHelper.ContentBackground;
        statLayout.ColumnCount = 4;
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statLayout.Controls.Add(totalRoomsValueLabel, 0, 0);
        statLayout.Controls.Add(activeRoomsValueLabel, 1, 0);
        statLayout.Controls.Add(totalSeatsValueLabel, 2, 0);
        statLayout.Controls.Add(maintenanceRoomsValueLabel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // actionPanel
        //
        actionPanel.BackColor = UiStyleHelper.ContentBackground;
        actionPanel.Controls.Add(addRoomButton);
        actionPanel.Controls.Add(updateRoomButton);
        actionPanel.Controls.Add(createSeatsButton);
        actionPanel.Controls.Add(maintenanceButton);
        actionPanel.Controls.Add(refreshButton);
        actionPanel.Dock = DockStyle.Fill;
        actionPanel.FlowDirection = FlowDirection.LeftToRight;
        actionPanel.Padding = new Padding(0, 4, 0, 8);
        actionPanel.WrapContents = false;
        StylePrimaryButton(addRoomButton, "Thêm phòng", 118);
        StyleSecondaryButton(updateRoomButton, "Sửa phòng", 112);
        StyleSecondaryButton(createSeatsButton, "Tạo ghế", 108);
        StyleDangerButton(maintenanceButton, "Bảo trì phòng", 128);
        StyleSecondaryButton(refreshButton, "Làm mới", 104);
        //
        // contentLayout
        //
        contentLayout.BackColor = UiStyleHelper.ContentBackground;
        contentLayout.ColumnCount = 2;
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
        contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        contentLayout.Controls.Add(gridPanel, 0, 0);
        contentLayout.Controls.Add(rightLayout, 1, 0);
        contentLayout.Dock = DockStyle.Fill;
        contentLayout.RowCount = 1;
        contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // gridPanel
        //
        gridPanel.BackColor = Color.White;
        gridPanel.BorderStyle = BorderStyle.FixedSingle;
        gridPanel.Controls.Add(gridLayout);
        gridPanel.Dock = DockStyle.Fill;
        gridPanel.Margin = new Padding(0, 0, 12, 0);
        gridPanel.Padding = new Padding(10);
        gridLayout.BackColor = Color.White;
        gridLayout.ColumnCount = 1;
        gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        gridLayout.Controls.Add(CreateCardTitleLabel("Danh sách phòng chiếu"), 0, 0);
        gridLayout.Controls.Add(roomGrid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(roomGrid);
        roomGrid.Dock = DockStyle.Fill;
        roomGrid.AutoGenerateColumns = false;
        roomGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        roomGrid.ColumnHeadersHeight = 40;
        roomGrid.RowHeadersVisible = false;
        roomGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "RoomId", DataPropertyName = "RoomId", HeaderText = "Mã phòng", FillWeight = 80 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", HeaderText = "Tên phòng", FillWeight = 120 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "RoomType", DataPropertyName = "RoomType", HeaderText = "Loại", FillWeight = 80 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "SeatRows", DataPropertyName = "SeatRows", HeaderText = "Số hàng", FillWeight = 75 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "SeatsPerRow", DataPropertyName = "SeatsPerRow", HeaderText = "Ghế/hàng", FillWeight = 80 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "SeatCount", DataPropertyName = "SeatCount", HeaderText = "Tổng ghế", FillWeight = 90 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 110 });
        roomGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Note", DataPropertyName = "Note", HeaderText = "Ghi chú", FillWeight = 150 });
        //
        // rightLayout
        //
        rightLayout.BackColor = UiStyleHelper.ContentBackground;
        rightLayout.ColumnCount = 1;
        rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rightLayout.Controls.Add(editorPanel, 0, 0);
        rightLayout.Controls.Add(previewPanel, 0, 1);
        rightLayout.Dock = DockStyle.Fill;
        rightLayout.RowCount = 2;
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
        rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 46F));
        //
        // editorPanel
        //
        editorPanel.BackColor = Color.White;
        editorPanel.BorderStyle = BorderStyle.FixedSingle;
        editorPanel.Controls.Add(editorLayout);
        editorPanel.Dock = DockStyle.Fill;
        editorPanel.Margin = new Padding(0, 0, 0, 10);
        editorPanel.Padding = new Padding(14);
        editorLayout.BackColor = Color.White;
        editorLayout.ColumnCount = 1;
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        editorLayout.Controls.Add(CreateCardTitleLabel("Thông tin phòng"), 0, 0);
        editorLayout.Controls.Add(CreateFilterBlock("Tên phòng", roomNameTextBox), 0, 1);
        editorLayout.Controls.Add(CreateFilterBlock("Loại phòng", roomTypeCombo), 0, 2);
        editorLayout.Controls.Add(CreateTwoInputRow("Số hàng", rowCountTextBox, "Ghế mỗi hàng", seatsPerRowTextBox), 0, 3);
        editorLayout.Controls.Add(CreateFilterBlock("Trạng thái", roomStatusCombo), 0, 4);
        editorLayout.Controls.Add(detailLabel, 0, 5);
        editorLayout.Dock = DockStyle.Fill;
        editorLayout.RowCount = 6;
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureTextBox(roomNameTextBox);
        ConfigureTextBox(rowCountTextBox);
        ConfigureTextBox(seatsPerRowTextBox);
        ConfigureCombo(roomTypeCombo);
        ConfigureCombo(roomStatusCombo);
        roomNameTextBox.Text = "Phòng 1";
        rowCountTextBox.Text = "7";
        seatsPerRowTextBox.Text = "10";
        roomTypeCombo.Items.AddRange(new object[] { "2D", "3D", "IMAX", "VIP" });
        roomTypeCombo.SelectedIndex = 0;
        roomStatusCombo.Items.AddRange(new object[] { "Đang hoạt động", "Bảo trì" });
        roomStatusCombo.SelectedIndex = 0;
        detailLabel.Dock = DockStyle.Fill;
        detailLabel.Font = UiStyleHelper.BodyFont(9.5F);
        detailLabel.ForeColor = UiStyleHelper.TextMuted;
        detailLabel.Text = "Mã phòng: P01\r\nTổng ghế: 70\r\nGhi chú: Sẵn sàng bán vé.";
        detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // previewPanel
        //
        previewPanel.BackColor = Color.White;
        previewPanel.BorderStyle = BorderStyle.FixedSingle;
        previewPanel.Controls.Add(previewLayout);
        previewPanel.Dock = DockStyle.Fill;
        previewPanel.Padding = new Padding(12);
        previewLayout.BackColor = Color.White;
        previewLayout.ColumnCount = 1;
        previewLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        previewLayout.Controls.Add(CreateCardTitleLabel("Sơ đồ ghế mẫu"), 0, 0);
        previewLayout.Controls.Add(seatPreviewPanel, 0, 1);
        previewLayout.Dock = DockStyle.Fill;
        previewLayout.RowCount = 2;
        previewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        previewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        seatPreviewPanel.BackColor = Color.White;
        seatPreviewPanel.ColumnCount = 11;
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
        for (var i = 0; i < 10; i++)
        {
            seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        }
        seatPreviewPanel.Dock = DockStyle.Fill;
        seatPreviewPanel.Padding = new Padding(8, 8, 8, 4);
        seatPreviewPanel.RowCount = 6;
        for (var i = 0; i < 6; i++)
        {
            seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        }
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        actionPanel.ResumeLayout(false);
        contentLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)roomGrid).EndInit();
        rightLayout.ResumeLayout(false);
        editorPanel.ResumeLayout(false);
        editorLayout.ResumeLayout(false);
        previewPanel.ResumeLayout(false);
        previewLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static TableLayoutPanel CreateFilterBlock(string label, Control control)
    {
        var block = new TableLayoutPanel { ColumnCount = 1, Dock = DockStyle.Fill, RowCount = 2 };
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        block.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        block.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.25F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        control.Dock = DockStyle.Fill;
        block.Controls.Add(control, 0, 1);
        return block;
    }

    private static TableLayoutPanel CreateTwoInputRow(string leftLabel, Control leftControl, string rightLabel, Control rightControl)
    {
        var panel = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.Controls.Add(CreateFilterBlock(leftLabel, leftControl), 0, 0);
        panel.Controls.Add(CreateFilterBlock(rightLabel, rightControl), 1, 0);
        return panel;
    }

    private static Panel CreateStatPanel(string label, Label valueLabel, string note, Color accent)
    {
        var panel = new Panel { BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Dock = DockStyle.Fill, Margin = new Padding(0, 0, 12, 0), Padding = new Padding(18, 14, 18, 14) };
        var layout = new TableLayoutPanel { BackColor = Color.White, ColumnCount = 1, Dock = DockStyle.Fill, RowCount = 3 };
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        layout.Controls.Add(new Label { Dock = DockStyle.Fill, Text = label, Font = UiStyleHelper.SmallFont(9.5F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.BottomLeft }, 0, 0);
        valueLabel.Dock = DockStyle.Fill;
        valueLabel.Font = UiStyleHelper.TitleFont(17F);
        valueLabel.ForeColor = accent;
        valueLabel.TextAlign = ContentAlignment.MiddleLeft;
        layout.Controls.Add(valueLabel, 0, 1);
        layout.Controls.Add(new Label { Dock = DockStyle.Fill, Text = note, Font = UiStyleHelper.SmallFont(8.75F), ForeColor = UiStyleHelper.TextMuted, TextAlign = ContentAlignment.TopLeft }, 0, 2);
        panel.Controls.Add(layout);
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

    private static void ConfigureGrid(DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoGenerateColumns = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersHeight = 40;
        grid.Dock = DockStyle.Fill;
        grid.EnableHeadersVisualStyles = false;
        grid.MultiSelect = false;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 34;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    private static void StylePrimaryButton(Button button, string text, int width)
    {
        button.BackColor = UiStyleHelper.Primary;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.25F);
        button.ForeColor = Color.White;
        button.Margin = new Padding(0, 0, 8, 0);
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
        button.Margin = new Padding(0, 0, 8, 0);
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
