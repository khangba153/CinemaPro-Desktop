using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class ShowtimeManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private ComboBox movieFilterCombo;
    private DateTimePicker showDateFilterPicker;
    private ComboBox roomFilterCombo;
    private Button addButton;
    private Button refreshButton;
    private Button conflictButton;
    private TableLayoutPanel mainLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private DataGridView showtimeGrid;
    private Panel editorPanel;
    private TableLayoutPanel editorLayout;
    private ComboBox movieCombo;
    private ComboBox roomCombo;
    private DateTimePicker datePicker;
    private DateTimePicker startPicker;
    private DateTimePicker endPicker;
    private ComboBox formatCombo;
    private TextBox priceBox;
    private ComboBox statusCombo;
    private Button saveButton;
    private Button updateButton;
    private Button cancelShowtimeButton;
    private Panel timelineCard;
    private TableLayoutPanel timelineLayout;
    private FlowLayoutPanel timelinePanel;

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
        movieFilterCombo = new ComboBox();
        showDateFilterPicker = new DateTimePicker();
        roomFilterCombo = new ComboBox();
        addButton = new Button();
        refreshButton = new Button();
        conflictButton = new Button();
        mainLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        showtimeGrid = new DataGridView();
        editorPanel = new Panel();
        editorLayout = new TableLayoutPanel();
        movieCombo = new ComboBox();
        roomCombo = new ComboBox();
        datePicker = new DateTimePicker();
        startPicker = new DateTimePicker();
        endPicker = new DateTimePicker();
        formatCombo = new ComboBox();
        priceBox = new TextBox();
        statusCombo = new ComboBox();
        saveButton = new Button();
        updateButton = new Button();
        cancelShowtimeButton = new Button();
        timelineCard = new Panel();
        timelineLayout = new TableLayoutPanel();
        timelinePanel = new FlowLayoutPanel();
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        mainLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        editorPanel.SuspendLayout();
        editorLayout.SuspendLayout();
        timelineCard.SuspendLayout();
        timelineLayout.SuspendLayout();
        SuspendLayout();
        //
        // ShowtimeManagementForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "ShowtimeManagementForm";
        Text = "Quản lý lịch chiếu";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterPanel, 0, 0);
        rootLayout.Controls.Add(mainLayout, 0, 1);
        rootLayout.Controls.Add(timelineCard, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
        //
        // filterPanel
        //
        filterPanel.BackColor = UiStyleHelper.ContentBackground;
        filterPanel.Controls.Add(CreateFilterBlock("Phim", movieFilterCombo, 190));
        filterPanel.Controls.Add(CreateFilterBlock("Ngày chiếu", showDateFilterPicker, 132));
        filterPanel.Controls.Add(CreateFilterBlock("Phòng", roomFilterCombo, 150));
        filterPanel.Controls.Add(addButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Controls.Add(conflictButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        ConfigureCombo(movieFilterCombo);
        ConfigureCombo(roomFilterCombo);
        movieFilterCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dora, Phá Vỡ Pando", "Dune: Phần Hai" });
        movieFilterCombo.SelectedIndex = 0;
        roomFilterCombo.Items.AddRange(new object[] { "Tất cả phòng", "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4" });
        roomFilterCombo.SelectedIndex = 0;
        showDateFilterPicker.Format = DateTimePickerFormat.Short;
        showDateFilterPicker.Value = DateTime.Today;
        StylePrimaryButton(addButton, "Thêm lịch chiếu", 132);
        StyleSecondaryButton(refreshButton, "Làm mới", 106);
        StyleSecondaryButton(conflictButton, "Kiểm tra trùng lịch", 154);
        //
        // mainLayout
        //
        mainLayout.BackColor = UiStyleHelper.ContentBackground;
        mainLayout.ColumnCount = 2;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        mainLayout.Controls.Add(gridPanel, 0, 0);
        mainLayout.Controls.Add(editorPanel, 1, 0);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Padding = new Padding(0, 0, 0, 10);
        mainLayout.RowCount = 1;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
        gridLayout.Controls.Add(CreateCardTitleLabel("Danh sách lịch chiếu"), 0, 0);
        gridLayout.Controls.Add(showtimeGrid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureGrid(showtimeGrid);
        showtimeGrid.Dock = DockStyle.Fill;
        showtimeGrid.AutoGenerateColumns = false;
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        showtimeGrid.ColumnHeadersHeight = 40;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "ShowtimeId", DataPropertyName = "ShowtimeId", HeaderText = "Mã lịch", FillWeight = 80 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Movie", DataPropertyName = "Movie", HeaderText = "Phim", FillWeight = 175 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 90 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", HeaderText = "Ngày", FillWeight = 92 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Start", DataPropertyName = "Start", HeaderText = "Bắt đầu", FillWeight = 84 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "End", DataPropertyName = "End", HeaderText = "Kết thúc", FillWeight = 84 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", DataPropertyName = "Price", HeaderText = "Giá vé", FillWeight = 92 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Format", DataPropertyName = "Format", HeaderText = "Định dạng", FillWeight = 80 });
        showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 110 });
        //
        // editorPanel
        //
        editorPanel.BackColor = Color.White;
        editorPanel.BorderStyle = BorderStyle.FixedSingle;
        editorPanel.Controls.Add(editorLayout);
        editorPanel.Dock = DockStyle.Fill;
        editorPanel.Padding = new Padding(14);
        editorLayout.BackColor = Color.White;
        editorLayout.ColumnCount = 1;
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        editorLayout.Controls.Add(CreateCardTitleLabel("Thông tin suất chiếu"), 0, 0);
        editorLayout.Controls.Add(CreateFilterBlock("Phim", movieCombo, 0), 0, 1);
        editorLayout.Controls.Add(CreateFilterBlock("Phòng chiếu", roomCombo, 0), 0, 2);
        editorLayout.Controls.Add(CreateFilterBlock("Ngày chiếu", datePicker, 0), 0, 3);
        editorLayout.Controls.Add(CreateTimeRow(), 0, 4);
        editorLayout.Controls.Add(CreateFilterBlock("Định dạng", formatCombo, 0), 0, 5);
        editorLayout.Controls.Add(CreateFilterBlock("Giá vé", priceBox, 0), 0, 6);
        editorLayout.Controls.Add(CreateFilterBlock("Trạng thái", statusCombo, 0), 0, 7);
        editorLayout.Controls.Add(CreateButtonRow(), 0, 8);
        editorLayout.Dock = DockStyle.Fill;
        editorLayout.RowCount = 10;
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ConfigureCombo(movieCombo);
        ConfigureCombo(roomCombo);
        ConfigureCombo(formatCombo);
        ConfigureCombo(statusCombo);
        movieCombo.Items.AddRange(new object[] { "Avengers: Endgame", "Dora, Phá Vỡ Pando", "Dune: Phần Hai" });
        movieCombo.SelectedIndex = 0;
        roomCombo.Items.AddRange(new object[] { "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4" });
        roomCombo.SelectedIndex = 1;
        formatCombo.Items.AddRange(new object[] { "2D", "3D", "IMAX", "VIP" });
        formatCombo.SelectedIndex = 0;
        statusCombo.Items.AddRange(new object[] { "Đang mở bán", "Sắp chiếu", "Đã đóng bán" });
        statusCombo.SelectedIndex = 0;
        datePicker.Format = DateTimePickerFormat.Short;
        startPicker.Format = DateTimePickerFormat.Time;
        startPicker.ShowUpDown = true;
        endPicker.Format = DateTimePickerFormat.Time;
        endPicker.ShowUpDown = true;
        priceBox.BorderStyle = BorderStyle.FixedSingle;
        priceBox.Font = UiStyleHelper.BodyFont(10F);
        priceBox.Height = 32;
        priceBox.Text = "90.000";
        //
        // timelineCard
        //
        timelineCard.BackColor = Color.White;
        timelineCard.BorderStyle = BorderStyle.FixedSingle;
        timelineCard.Controls.Add(timelineLayout);
        timelineCard.Dock = DockStyle.Fill;
        timelineCard.Padding = new Padding(12);
        timelineLayout.BackColor = Color.White;
        timelineLayout.ColumnCount = 1;
        timelineLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        timelineLayout.Controls.Add(CreateCardTitleLabel("Kiểm tra lịch phòng"), 0, 0);
        timelineLayout.Controls.Add(timelinePanel, 0, 1);
        timelineLayout.Dock = DockStyle.Fill;
        timelineLayout.RowCount = 2;
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        timelinePanel.BackColor = Color.White;
        timelinePanel.Dock = DockStyle.Fill;
        timelinePanel.FlowDirection = FlowDirection.TopDown;
        timelinePanel.WrapContents = false;
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        editorPanel.ResumeLayout(false);
        editorLayout.ResumeLayout(false);
        timelineCard.ResumeLayout(false);
        timelineLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel CreateTimeRow()
    {
        var panel = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        panel.Controls.Add(CreateFilterBlock("Giờ bắt đầu", startPicker, 0), 0, 0);
        panel.Controls.Add(CreateFilterBlock("Giờ kết thúc", endPicker, 0), 1, 0);
        return panel;
    }

    private TableLayoutPanel CreateButtonRow()
    {
        var panel = new TableLayoutPanel { ColumnCount = 3, Dock = DockStyle.Fill, RowCount = 1 };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        StylePrimaryButton(saveButton, "Tạo suất", 0);
        StyleSecondaryButton(updateButton, "Sửa suất", 0);
        StyleDangerButton(cancelShowtimeButton, "Hủy suất", 0);
        panel.Controls.Add(saveButton, 0, 0);
        panel.Controls.Add(updateButton, 1, 0);
        panel.Controls.Add(cancelShowtimeButton, 2, 0);
        return panel;
    }

    private static TableLayoutPanel CreateFilterBlock(string label, Control control, int width)
    {
        var block = new TableLayoutPanel
        {
            ColumnCount = 1,
            Height = 58,
            Margin = new Padding(0, 0, 12, 0),
            RowCount = 2,
            Width = width > 0 ? width : 150
        };
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
        button.Margin = new Padding(0, 18, 8, 0);
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
        button.Margin = new Padding(0, 18, 8, 0);
        button.Size = new Size(width > 0 ? width : 110, 36);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }

    private static void StyleDangerButton(Button button, string text, int width)
    {
        StyleSecondaryButton(button, text, width);
        button.ForeColor = UiStyleHelper.Danger;
    }
}
