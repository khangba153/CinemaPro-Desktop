using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class ShowtimeManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterPanel;
    private Label movieFilterLabel;
    private ComboBox movieFilterCombo;
    private Label dateFilterLabel;
    private DateTimePicker showDateFilterPicker;
    private Label roomFilterLabel;
    private ComboBox roomFilterCombo;
    private Button addButton;
    private Button refreshButton;
    private Button conflictButton;
    private TableLayoutPanel mainLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private Label gridTitleLabel;
    private DataGridView showtimeGrid;
    private Panel editorPanel;
    private TableLayoutPanel editorLayout;
    private Label editorTitleLabel;
    private Label movieInputLabel;
    private ComboBox movieCombo;
    private Label roomInputLabel;
    private ComboBox roomCombo;
    private Label dateInputLabel;
    private DateTimePicker datePicker;
    private TableLayoutPanel timeLayout;
    private Label startInputLabel;
    private DateTimePicker startPicker;
    private Label endInputLabel;
    private DateTimePicker endPicker;
    private Label formatInputLabel;
    private ComboBox formatCombo;
    private Label priceInputLabel;
    private TextBox priceBox;
    private Label showtimeStatusInputLabel;
    private ComboBox statusCombo;
    private TableLayoutPanel editorButtonLayout;
    private Button saveButton;
    private Button updateButton;
    private Button cancelShowtimeButton;
    private Panel timelineCard;
    private TableLayoutPanel timelineLayout;
    private Label timelineTitleLabel;
    private FlowLayoutPanel timelinePanel;
    private Label timeline1Label;
    private Label timeline2Label;
    private Label timeline3Label;
    private Label timeline4Label;
    private Label timeline5Label;

    private DataGridViewTextBoxColumn showtimeGridShowtimeIdColumn;
    private DataGridViewTextBoxColumn showtimeGridMovieColumn;
    private DataGridViewTextBoxColumn showtimeGridRoomColumn;
    private DataGridViewTextBoxColumn showtimeGridDateColumn;
    private DataGridViewTextBoxColumn showtimeGridStartColumn;
    private DataGridViewTextBoxColumn showtimeGridEndColumn;
    private DataGridViewTextBoxColumn showtimeGridPriceColumn;
    private DataGridViewTextBoxColumn showtimeGridFormatColumn;
    private DataGridViewTextBoxColumn showtimeGridStatusColumn;
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
        showtimeGridShowtimeIdColumn = new DataGridViewTextBoxColumn();
        showtimeGridMovieColumn = new DataGridViewTextBoxColumn();
        showtimeGridRoomColumn = new DataGridViewTextBoxColumn();
        showtimeGridDateColumn = new DataGridViewTextBoxColumn();
        showtimeGridStartColumn = new DataGridViewTextBoxColumn();
        showtimeGridEndColumn = new DataGridViewTextBoxColumn();
        showtimeGridPriceColumn = new DataGridViewTextBoxColumn();
        showtimeGridFormatColumn = new DataGridViewTextBoxColumn();
        showtimeGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        filterPanel = new FlowLayoutPanel();
        movieFilterLabel = new Label();
        movieFilterCombo = new ComboBox();
        dateFilterLabel = new Label();
        showDateFilterPicker = new DateTimePicker();
        roomFilterLabel = new Label();
        roomFilterCombo = new ComboBox();
        addButton = new Button();
        refreshButton = new Button();
        conflictButton = new Button();
        mainLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        gridTitleLabel = new Label();
        showtimeGrid = new DataGridView();
        editorPanel = new Panel();
        editorLayout = new TableLayoutPanel();
        editorTitleLabel = new Label();
        movieInputLabel = new Label();
        movieCombo = new ComboBox();
        roomInputLabel = new Label();
        roomCombo = new ComboBox();
        dateInputLabel = new Label();
        datePicker = new DateTimePicker();
        timeLayout = new TableLayoutPanel();
        startInputLabel = new Label();
        startPicker = new DateTimePicker();
        endInputLabel = new Label();
        endPicker = new DateTimePicker();
        formatInputLabel = new Label();
        formatCombo = new ComboBox();
        priceInputLabel = new Label();
        priceBox = new TextBox();
        showtimeStatusInputLabel = new Label();
        statusCombo = new ComboBox();
        editorButtonLayout = new TableLayoutPanel();
        saveButton = new Button();
        updateButton = new Button();
        cancelShowtimeButton = new Button();
        timelineCard = new Panel();
        timelineLayout = new TableLayoutPanel();
        timelineTitleLabel = new Label();
        timelinePanel = new FlowLayoutPanel();
        timeline1Label = new Label();
        timeline2Label = new Label();
        timeline3Label = new Label();
        timeline4Label = new Label();
        timeline5Label = new Label();
        rootLayout.SuspendLayout();
        filterPanel.SuspendLayout();
        mainLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).BeginInit();
        editorPanel.SuspendLayout();
        editorLayout.SuspendLayout();
        timeLayout.SuspendLayout();
        editorButtonLayout.SuspendLayout();
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
        filterPanel.Controls.Add(movieFilterLabel);
        filterPanel.Controls.Add(movieFilterCombo);
        filterPanel.Controls.Add(dateFilterLabel);
        filterPanel.Controls.Add(showDateFilterPicker);
        filterPanel.Controls.Add(roomFilterLabel);
        filterPanel.Controls.Add(roomFilterCombo);
        filterPanel.Controls.Add(addButton);
        filterPanel.Controls.Add(refreshButton);
        filterPanel.Controls.Add(conflictButton);
        filterPanel.Dock = DockStyle.Fill;
        filterPanel.FlowDirection = FlowDirection.LeftToRight;
        filterPanel.Padding = new Padding(0, 0, 0, 8);
        filterPanel.WrapContents = false;
        StyleInlineLabel(movieFilterLabel, "Phim", 38);
        ConfigureCombo(movieFilterCombo);
        movieFilterCombo.Margin = new Padding(0, 18, 16, 0);
        movieFilterCombo.Size = new Size(176, 32);
        StyleInlineLabel(roomFilterLabel, "Phòng", 48);
        ConfigureCombo(roomFilterCombo);
        roomFilterCombo.Margin = new Padding(0, 18, 16, 0);
        roomFilterCombo.Size = new Size(132, 32);
        movieFilterCombo.Items.AddRange(new object[] { "Tất cả phim", "Avengers: Endgame", "Dora, Phá Vỡ Pando", "Dune: Phần Hai" });
        movieFilterCombo.SelectedIndex = 0;
        roomFilterCombo.Items.AddRange(new object[] { "Tất cả phòng", "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4" });
        roomFilterCombo.SelectedIndex = 0;
        StyleInlineLabel(dateFilterLabel, "Ngày", 44);
        showDateFilterPicker.Format = DateTimePickerFormat.Short;
        showDateFilterPicker.Margin = new Padding(0, 18, 16, 0);
        showDateFilterPicker.Size = new Size(118, 32);
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
        gridLayout.Controls.Add(gridTitleLabel, 0, 0);
        gridLayout.Controls.Add(showtimeGrid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(gridTitleLabel, "DANH SÁCH LỊCH CHIẾU");
        ConfigureGrid(showtimeGrid);
        showtimeGrid.Dock = DockStyle.Fill;
        showtimeGrid.AutoGenerateColumns = false;
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        showtimeGrid.ColumnHeadersHeight = 40;
        showtimeGrid.RowHeadersVisible = false;
        showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGridShowtimeIdColumn.Name = "ShowtimeId";
        showtimeGridShowtimeIdColumn.DataPropertyName = "ShowtimeId";
        showtimeGridShowtimeIdColumn.HeaderText = "Mã lịch";
        showtimeGridShowtimeIdColumn.FillWeight = 80F;
        showtimeGrid.Columns.Add(showtimeGridShowtimeIdColumn);
        showtimeGridMovieColumn.Name = "Movie";
        showtimeGridMovieColumn.DataPropertyName = "Movie";
        showtimeGridMovieColumn.HeaderText = "Phim";
        showtimeGridMovieColumn.FillWeight = 175F;
        showtimeGrid.Columns.Add(showtimeGridMovieColumn);
        showtimeGridRoomColumn.Name = "Room";
        showtimeGridRoomColumn.DataPropertyName = "Room";
        showtimeGridRoomColumn.HeaderText = "Phòng";
        showtimeGridRoomColumn.FillWeight = 90F;
        showtimeGrid.Columns.Add(showtimeGridRoomColumn);
        showtimeGridDateColumn.Name = "Date";
        showtimeGridDateColumn.DataPropertyName = "Date";
        showtimeGridDateColumn.HeaderText = "Ngày";
        showtimeGridDateColumn.FillWeight = 92F;
        showtimeGrid.Columns.Add(showtimeGridDateColumn);
        showtimeGridStartColumn.Name = "Start";
        showtimeGridStartColumn.DataPropertyName = "Start";
        showtimeGridStartColumn.HeaderText = "Bắt đầu";
        showtimeGridStartColumn.FillWeight = 84F;
        showtimeGrid.Columns.Add(showtimeGridStartColumn);
        showtimeGridEndColumn.Name = "End";
        showtimeGridEndColumn.DataPropertyName = "End";
        showtimeGridEndColumn.HeaderText = "Kết thúc";
        showtimeGridEndColumn.FillWeight = 84F;
        showtimeGrid.Columns.Add(showtimeGridEndColumn);
        showtimeGridPriceColumn.Name = "Price";
        showtimeGridPriceColumn.DataPropertyName = "Price";
        showtimeGridPriceColumn.HeaderText = "Giá vé";
        showtimeGridPriceColumn.FillWeight = 92F;
        showtimeGrid.Columns.Add(showtimeGridPriceColumn);
        showtimeGridFormatColumn.Name = "Format";
        showtimeGridFormatColumn.DataPropertyName = "Format";
        showtimeGridFormatColumn.HeaderText = "Định dạng";
        showtimeGridFormatColumn.FillWeight = 80F;
        showtimeGrid.Columns.Add(showtimeGridFormatColumn);
        showtimeGridStatusColumn.Name = "Status";
        showtimeGridStatusColumn.DataPropertyName = "Status";
        showtimeGridStatusColumn.HeaderText = "Trạng thái";
        showtimeGridStatusColumn.FillWeight = 110F;
        showtimeGrid.Columns.Add(showtimeGridStatusColumn);
        //
        // editorPanel
        //
        editorPanel.BackColor = Color.White;
        editorPanel.BorderStyle = BorderStyle.FixedSingle;
        editorPanel.Controls.Add(editorLayout);
        editorPanel.Dock = DockStyle.Fill;
        editorPanel.Padding = new Padding(14);
        editorLayout.BackColor = Color.White;
        editorLayout.ColumnCount = 2;
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        editorLayout.Controls.Add(editorTitleLabel, 0, 0);
        editorLayout.Controls.Add(movieInputLabel, 0, 1);
        editorLayout.Controls.Add(movieCombo, 1, 1);
        editorLayout.Controls.Add(roomInputLabel, 0, 2);
        editorLayout.Controls.Add(roomCombo, 1, 2);
        editorLayout.Controls.Add(dateInputLabel, 0, 3);
        editorLayout.Controls.Add(datePicker, 1, 3);
        editorLayout.Controls.Add(timeLayout, 0, 4);
        editorLayout.Controls.Add(formatInputLabel, 0, 5);
        editorLayout.Controls.Add(formatCombo, 1, 5);
        editorLayout.Controls.Add(priceInputLabel, 0, 6);
        editorLayout.Controls.Add(priceBox, 1, 6);
        editorLayout.Controls.Add(showtimeStatusInputLabel, 0, 7);
        editorLayout.Controls.Add(statusCombo, 1, 7);
        editorLayout.Controls.Add(editorButtonLayout, 0, 8);
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
        editorLayout.SetColumnSpan(editorTitleLabel, 2);
        editorLayout.SetColumnSpan(timeLayout, 2);
        editorLayout.SetColumnSpan(editorButtonLayout, 2);
        StyleCardTitle(editorTitleLabel, "THÔNG TIN SUẤT CHIẾU");
        StyleFieldLabel(movieInputLabel, "Phim");
        StyleFieldLabel(roomInputLabel, "Phòng");
        StyleFieldLabel(dateInputLabel, "Ngày");
        StyleFieldLabel(formatInputLabel, "Định dạng");
        StyleFieldLabel(priceInputLabel, "Giá vé");
        StyleFieldLabel(showtimeStatusInputLabel, "Trạng thái");
        ConfigureCombo(movieCombo);
        ConfigureCombo(roomCombo);
        ConfigureCombo(formatCombo);
        ConfigureCombo(statusCombo);
        DockFieldControl(movieCombo);
        DockFieldControl(roomCombo);
        DockFieldControl(datePicker);
        DockFieldControl(formatCombo);
        DockFieldControl(priceBox);
        DockFieldControl(statusCombo);
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
        // timeLayout
        //
        timeLayout.ColumnCount = 4;
        timeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
        timeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        timeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
        timeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        timeLayout.Controls.Add(startInputLabel, 0, 0);
        timeLayout.Controls.Add(startPicker, 1, 0);
        timeLayout.Controls.Add(endInputLabel, 2, 0);
        timeLayout.Controls.Add(endPicker, 3, 0);
        timeLayout.Dock = DockStyle.Fill;
        timeLayout.RowCount = 1;
        timeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleFieldLabel(startInputLabel, "Bắt đầu");
        StyleFieldLabel(endInputLabel, "Kết thúc");
        DockFieldControl(startPicker);
        DockFieldControl(endPicker);
        //
        // editorButtonLayout
        //
        editorButtonLayout.ColumnCount = 3;
        editorButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        editorButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        editorButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        editorButtonLayout.Controls.Add(saveButton, 0, 0);
        editorButtonLayout.Controls.Add(updateButton, 1, 0);
        editorButtonLayout.Controls.Add(cancelShowtimeButton, 2, 0);
        editorButtonLayout.Dock = DockStyle.Fill;
        editorButtonLayout.RowCount = 1;
        editorButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StylePrimaryButton(saveButton, "Tạo suất", 0);
        StyleSecondaryButton(updateButton, "Sửa suất", 0);
        StyleDangerButton(cancelShowtimeButton, "Hủy suất", 0);
        saveButton.Dock = DockStyle.Fill;
        updateButton.Dock = DockStyle.Fill;
        cancelShowtimeButton.Dock = DockStyle.Fill;
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
        timelineLayout.Controls.Add(timelineTitleLabel, 0, 0);
        timelineLayout.Controls.Add(timelinePanel, 0, 1);
        timelineLayout.Dock = DockStyle.Fill;
        timelineLayout.RowCount = 2;
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        timelineLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(timelineTitleLabel, "KIỂM TRA LỊCH PHÒNG");
        timelinePanel.BackColor = Color.White;
        timelinePanel.Dock = DockStyle.Fill;
        timelinePanel.FlowDirection = FlowDirection.TopDown;
        timelinePanel.WrapContents = false;
        timelinePanel.Controls.Add(timeline1Label);
        StyleTimelineLabel(timeline1Label, "Phòng 1     19:00 - 21:00     Suất chiếu demo");
        timelinePanel.Controls.Add(timeline2Label);
        StyleTimelineLabel(timeline2Label, "Phòng 2     19:00 - 21:00     Suất chiếu demo");
        timelinePanel.Controls.Add(timeline3Label);
        StyleTimelineLabel(timeline3Label, "Phòng 3     19:00 - 21:00     Suất chiếu demo");
        timelinePanel.Controls.Add(timeline4Label);
        StyleTimelineLabel(timeline4Label, "Phòng 4     19:00 - 21:00     Suất chiếu demo");
        timelinePanel.Controls.Add(timeline5Label);
        StyleTimelineLabel(timeline5Label, "Phòng 5     19:00 - 21:00     Suất chiếu demo");
        rootLayout.ResumeLayout(false);
        filterPanel.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)showtimeGrid).EndInit();
        editorPanel.ResumeLayout(false);
        editorLayout.ResumeLayout(false);
        timeLayout.ResumeLayout(false);
        editorButtonLayout.ResumeLayout(false);
        timelineCard.ResumeLayout(false);
        timelineLayout.ResumeLayout(false);
        ResumeLayout(false);
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

    private static void StyleFieldLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Margin = new Padding(0, 0, 8, 0);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void DockFieldControl(Control control)
    {
        control.Dock = DockStyle.Fill;
        control.Margin = new Padding(0, 12, 0, 12);
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
    private static void StyleTimelineLabel(Label label, string text)
    {
        label.BackColor = ColorTranslator.FromHtml("#EAF3FF");
        label.Font = UiStyleHelper.SectionFont(9.25F);
        label.ForeColor = UiStyleHelper.Primary;
        label.Height = 34;
        label.Margin = new Padding(0, 4, 0, 4);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Width = 980;
    }
}
