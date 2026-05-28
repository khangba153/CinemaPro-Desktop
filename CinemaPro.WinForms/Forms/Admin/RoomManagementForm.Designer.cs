using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class RoomManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private TableLayoutPanel statLayout;
    private Panel totalRoomsPanel;
    private Label totalRoomsTitleLabel;
    private Label totalRoomsValueLabel;
    private Label totalRoomsNoteLabel;
    private Panel activeRoomsPanel;
    private Label activeRoomsTitleLabel;
    private Label activeRoomsValueLabel;
    private Label activeRoomsNoteLabel;
    private Panel totalSeatsPanel;
    private Label totalSeatsTitleLabel;
    private Label totalSeatsValueLabel;
    private Label totalSeatsNoteLabel;
    private Panel maintenanceRoomsPanel;
    private Label maintenanceRoomsTitleLabel;
    private Label maintenanceRoomsValueLabel;
    private Label maintenanceRoomsNoteLabel;
    private FlowLayoutPanel actionPanel;
    private Button addRoomButton;
    private Button updateRoomButton;
    private Button createSeatsButton;
    private Button maintenanceButton;
    private Button refreshButton;
    private TableLayoutPanel contentLayout;
    private Panel gridPanel;
    private TableLayoutPanel gridLayout;
    private Label gridTitleLabel;
    private DataGridView roomGrid;
    private TableLayoutPanel rightLayout;
    private Panel editorPanel;
    private TableLayoutPanel editorLayout;
    private Label editorTitleLabel;
    private Label roomNameInputLabel;
    private TextBox roomNameTextBox;
    private Label roomTypeInputLabel;
    private ComboBox roomTypeCombo;
    private TableLayoutPanel seatConfigLayout;
    private Label rowCountInputLabel;
    private TextBox rowCountTextBox;
    private Label seatsPerRowInputLabel;
    private TextBox seatsPerRowTextBox;
    private Label roomStatusInputLabel;
    private ComboBox roomStatusCombo;
    private Label detailLabel;
    private Panel previewPanel;
    private TableLayoutPanel previewLayout;
    private Label previewTitleLabel;
    private TableLayoutPanel seatPreviewPanel;
    private Label previewSeatARowLabel;
    private Label previewSeatA1Label;
    private Label previewSeatA2Label;
    private Label previewSeatA3Label;
    private Label previewSeatA4Label;
    private Label previewSeatA5Label;
    private Label previewSeatA6Label;
    private Label previewSeatA7Label;
    private Label previewSeatA8Label;
    private Label previewSeatA9Label;
    private Label previewSeatA10Label;
    private Label previewSeatBRowLabel;
    private Label previewSeatB1Label;
    private Label previewSeatB2Label;
    private Label previewSeatB3Label;
    private Label previewSeatB4Label;
    private Label previewSeatB5Label;
    private Label previewSeatB6Label;
    private Label previewSeatB7Label;
    private Label previewSeatB8Label;
    private Label previewSeatB9Label;
    private Label previewSeatB10Label;
    private Label previewSeatCRowLabel;
    private Label previewSeatC1Label;
    private Label previewSeatC2Label;
    private Label previewSeatC3Label;
    private Label previewSeatC4Label;
    private Label previewSeatC5Label;
    private Label previewSeatC6Label;
    private Label previewSeatC7Label;
    private Label previewSeatC8Label;
    private Label previewSeatC9Label;
    private Label previewSeatC10Label;
    private Label previewSeatDRowLabel;
    private Label previewSeatD1Label;
    private Label previewSeatD2Label;
    private Label previewSeatD3Label;
    private Label previewSeatD4Label;
    private Label previewSeatD5Label;
    private Label previewSeatD6Label;
    private Label previewSeatD7Label;
    private Label previewSeatD8Label;
    private Label previewSeatD9Label;
    private Label previewSeatD10Label;
    private Label previewSeatERowLabel;
    private Label previewSeatE1Label;
    private Label previewSeatE2Label;
    private Label previewSeatE3Label;
    private Label previewSeatE4Label;
    private Label previewSeatE5Label;
    private Label previewSeatE6Label;
    private Label previewSeatE7Label;
    private Label previewSeatE8Label;
    private Label previewSeatE9Label;
    private Label previewSeatE10Label;
    private Label previewSeatFRowLabel;
    private Label previewSeatF1Label;
    private Label previewSeatF2Label;
    private Label previewSeatF3Label;
    private Label previewSeatF4Label;
    private Label previewSeatF5Label;
    private Label previewSeatF6Label;
    private Label previewSeatF7Label;
    private Label previewSeatF8Label;
    private Label previewSeatF9Label;
    private Label previewSeatF10Label;

    private DataGridViewTextBoxColumn roomGridRoomIdColumn;
    private DataGridViewTextBoxColumn roomGridNameColumn;
    private DataGridViewTextBoxColumn roomGridRoomTypeColumn;
    private DataGridViewTextBoxColumn roomGridSeatRowsColumn;
    private DataGridViewTextBoxColumn roomGridSeatsPerRowColumn;
    private DataGridViewTextBoxColumn roomGridSeatCountColumn;
    private DataGridViewTextBoxColumn roomGridStatusColumn;
    private DataGridViewTextBoxColumn roomGridNoteColumn;
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
        roomGridRoomIdColumn = new DataGridViewTextBoxColumn();
        roomGridNameColumn = new DataGridViewTextBoxColumn();
        roomGridRoomTypeColumn = new DataGridViewTextBoxColumn();
        roomGridSeatRowsColumn = new DataGridViewTextBoxColumn();
        roomGridSeatsPerRowColumn = new DataGridViewTextBoxColumn();
        roomGridSeatCountColumn = new DataGridViewTextBoxColumn();
        roomGridStatusColumn = new DataGridViewTextBoxColumn();
        roomGridNoteColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        statLayout = new TableLayoutPanel();
        totalRoomsPanel = new Panel();
        totalRoomsTitleLabel = new Label();
        totalRoomsValueLabel = new Label();
        totalRoomsNoteLabel = new Label();
        activeRoomsPanel = new Panel();
        activeRoomsTitleLabel = new Label();
        activeRoomsValueLabel = new Label();
        activeRoomsNoteLabel = new Label();
        totalSeatsPanel = new Panel();
        totalSeatsTitleLabel = new Label();
        totalSeatsValueLabel = new Label();
        totalSeatsNoteLabel = new Label();
        maintenanceRoomsPanel = new Panel();
        maintenanceRoomsTitleLabel = new Label();
        maintenanceRoomsValueLabel = new Label();
        maintenanceRoomsNoteLabel = new Label();
        actionPanel = new FlowLayoutPanel();
        addRoomButton = new Button();
        updateRoomButton = new Button();
        createSeatsButton = new Button();
        maintenanceButton = new Button();
        refreshButton = new Button();
        contentLayout = new TableLayoutPanel();
        gridPanel = new Panel();
        gridLayout = new TableLayoutPanel();
        gridTitleLabel = new Label();
        roomGrid = new DataGridView();
        rightLayout = new TableLayoutPanel();
        editorPanel = new Panel();
        editorLayout = new TableLayoutPanel();
        editorTitleLabel = new Label();
        roomNameInputLabel = new Label();
        roomNameTextBox = new TextBox();
        roomTypeInputLabel = new Label();
        roomTypeCombo = new ComboBox();
        seatConfigLayout = new TableLayoutPanel();
        rowCountInputLabel = new Label();
        rowCountTextBox = new TextBox();
        seatsPerRowInputLabel = new Label();
        seatsPerRowTextBox = new TextBox();
        roomStatusInputLabel = new Label();
        roomStatusCombo = new ComboBox();
        detailLabel = new Label();
        previewPanel = new Panel();
        previewLayout = new TableLayoutPanel();
        previewTitleLabel = new Label();
        seatPreviewPanel = new TableLayoutPanel();
        previewSeatARowLabel = new Label();
        previewSeatA1Label = new Label();
        previewSeatA2Label = new Label();
        previewSeatA3Label = new Label();
        previewSeatA4Label = new Label();
        previewSeatA5Label = new Label();
        previewSeatA6Label = new Label();
        previewSeatA7Label = new Label();
        previewSeatA8Label = new Label();
        previewSeatA9Label = new Label();
        previewSeatA10Label = new Label();
        previewSeatBRowLabel = new Label();
        previewSeatB1Label = new Label();
        previewSeatB2Label = new Label();
        previewSeatB3Label = new Label();
        previewSeatB4Label = new Label();
        previewSeatB5Label = new Label();
        previewSeatB6Label = new Label();
        previewSeatB7Label = new Label();
        previewSeatB8Label = new Label();
        previewSeatB9Label = new Label();
        previewSeatB10Label = new Label();
        previewSeatCRowLabel = new Label();
        previewSeatC1Label = new Label();
        previewSeatC2Label = new Label();
        previewSeatC3Label = new Label();
        previewSeatC4Label = new Label();
        previewSeatC5Label = new Label();
        previewSeatC6Label = new Label();
        previewSeatC7Label = new Label();
        previewSeatC8Label = new Label();
        previewSeatC9Label = new Label();
        previewSeatC10Label = new Label();
        previewSeatDRowLabel = new Label();
        previewSeatD1Label = new Label();
        previewSeatD2Label = new Label();
        previewSeatD3Label = new Label();
        previewSeatD4Label = new Label();
        previewSeatD5Label = new Label();
        previewSeatD6Label = new Label();
        previewSeatD7Label = new Label();
        previewSeatD8Label = new Label();
        previewSeatD9Label = new Label();
        previewSeatD10Label = new Label();
        previewSeatERowLabel = new Label();
        previewSeatE1Label = new Label();
        previewSeatE2Label = new Label();
        previewSeatE3Label = new Label();
        previewSeatE4Label = new Label();
        previewSeatE5Label = new Label();
        previewSeatE6Label = new Label();
        previewSeatE7Label = new Label();
        previewSeatE8Label = new Label();
        previewSeatE9Label = new Label();
        previewSeatE10Label = new Label();
        previewSeatFRowLabel = new Label();
        previewSeatF1Label = new Label();
        previewSeatF2Label = new Label();
        previewSeatF3Label = new Label();
        previewSeatF4Label = new Label();
        previewSeatF5Label = new Label();
        previewSeatF6Label = new Label();
        previewSeatF7Label = new Label();
        previewSeatF8Label = new Label();
        previewSeatF9Label = new Label();
        previewSeatF10Label = new Label();
        totalRoomsValueLabel.Text = "5";
        activeRoomsValueLabel.Text = "4";
        totalSeatsValueLabel.Text = "398";
        maintenanceRoomsValueLabel.Text = "1";
        rootLayout.SuspendLayout();
        statLayout.SuspendLayout();
        totalRoomsPanel.SuspendLayout();
        activeRoomsPanel.SuspendLayout();
        totalSeatsPanel.SuspendLayout();
        maintenanceRoomsPanel.SuspendLayout();
        actionPanel.SuspendLayout();
        contentLayout.SuspendLayout();
        gridPanel.SuspendLayout();
        gridLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)roomGrid).BeginInit();
        rightLayout.SuspendLayout();
        editorPanel.SuspendLayout();
        editorLayout.SuspendLayout();
        seatConfigLayout.SuspendLayout();
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
        statLayout.Controls.Add(totalRoomsPanel, 0, 0);
        statLayout.Controls.Add(activeRoomsPanel, 1, 0);
        statLayout.Controls.Add(totalSeatsPanel, 2, 0);
        statLayout.Controls.Add(maintenanceRoomsPanel, 3, 0);
        statLayout.Dock = DockStyle.Fill;
        statLayout.Padding = new Padding(0, 0, 0, 10);
        statLayout.RowCount = 1;
        statLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // totalRoomsPanel
        //
        totalRoomsPanel.BackColor = Color.White;
        totalRoomsPanel.BorderStyle = BorderStyle.FixedSingle;
        totalRoomsPanel.Controls.Add(totalRoomsNoteLabel);
        totalRoomsPanel.Controls.Add(totalRoomsValueLabel);
        totalRoomsPanel.Controls.Add(totalRoomsTitleLabel);
        totalRoomsPanel.Dock = DockStyle.Fill;
        totalRoomsPanel.Margin = new Padding(0, 0, 12, 0);
        totalRoomsPanel.Padding = new Padding(16, 12, 16, 12);
        totalRoomsTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalRoomsTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        totalRoomsTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        totalRoomsTitleLabel.Location = new Point(16, 12);
        totalRoomsTitleLabel.Size = new Size(210, 22);
        totalRoomsTitleLabel.Text = "Tổng phòng";
        totalRoomsTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalRoomsValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalRoomsValueLabel.Font = UiStyleHelper.TitleFont(17F);
        totalRoomsValueLabel.ForeColor = UiStyleHelper.Primary;
        totalRoomsValueLabel.Location = new Point(16, 36);
        totalRoomsValueLabel.Size = new Size(210, 32);
        totalRoomsValueLabel.Text = "5";
        totalRoomsValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalRoomsNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalRoomsNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        totalRoomsNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        totalRoomsNoteLabel.Location = new Point(16, 68);
        totalRoomsNoteLabel.Size = new Size(210, 22);
        totalRoomsNoteLabel.Text = "Tất cả phòng chiếu";
        totalRoomsNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // activeRoomsPanel
        //
        activeRoomsPanel.BackColor = Color.White;
        activeRoomsPanel.BorderStyle = BorderStyle.FixedSingle;
        activeRoomsPanel.Controls.Add(activeRoomsNoteLabel);
        activeRoomsPanel.Controls.Add(activeRoomsValueLabel);
        activeRoomsPanel.Controls.Add(activeRoomsTitleLabel);
        activeRoomsPanel.Dock = DockStyle.Fill;
        activeRoomsPanel.Margin = new Padding(0, 0, 12, 0);
        activeRoomsPanel.Padding = new Padding(16, 12, 16, 12);
        activeRoomsTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomsTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        activeRoomsTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        activeRoomsTitleLabel.Location = new Point(16, 12);
        activeRoomsTitleLabel.Size = new Size(210, 22);
        activeRoomsTitleLabel.Text = "Đang hoạt động";
        activeRoomsTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        activeRoomsValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomsValueLabel.Font = UiStyleHelper.TitleFont(17F);
        activeRoomsValueLabel.ForeColor = UiStyleHelper.Success;
        activeRoomsValueLabel.Location = new Point(16, 36);
        activeRoomsValueLabel.Size = new Size(210, 32);
        activeRoomsValueLabel.Text = "4";
        activeRoomsValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        activeRoomsNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        activeRoomsNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        activeRoomsNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        activeRoomsNoteLabel.Location = new Point(16, 68);
        activeRoomsNoteLabel.Size = new Size(210, 22);
        activeRoomsNoteLabel.Text = "Sẵn sàng bán vé";
        activeRoomsNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // totalSeatsPanel
        //
        totalSeatsPanel.BackColor = Color.White;
        totalSeatsPanel.BorderStyle = BorderStyle.FixedSingle;
        totalSeatsPanel.Controls.Add(totalSeatsNoteLabel);
        totalSeatsPanel.Controls.Add(totalSeatsValueLabel);
        totalSeatsPanel.Controls.Add(totalSeatsTitleLabel);
        totalSeatsPanel.Dock = DockStyle.Fill;
        totalSeatsPanel.Margin = new Padding(0, 0, 12, 0);
        totalSeatsPanel.Padding = new Padding(16, 12, 16, 12);
        totalSeatsTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalSeatsTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        totalSeatsTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        totalSeatsTitleLabel.Location = new Point(16, 12);
        totalSeatsTitleLabel.Size = new Size(210, 22);
        totalSeatsTitleLabel.Text = "Tổng ghế";
        totalSeatsTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalSeatsValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalSeatsValueLabel.Font = UiStyleHelper.TitleFont(17F);
        totalSeatsValueLabel.ForeColor = UiStyleHelper.Accent;
        totalSeatsValueLabel.Location = new Point(16, 36);
        totalSeatsValueLabel.Size = new Size(210, 32);
        totalSeatsValueLabel.Text = "398";
        totalSeatsValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        totalSeatsNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        totalSeatsNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        totalSeatsNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        totalSeatsNoteLabel.Location = new Point(16, 68);
        totalSeatsNoteLabel.Size = new Size(210, 22);
        totalSeatsNoteLabel.Text = "Theo cấu hình phòng";
        totalSeatsNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // maintenanceRoomsPanel
        //
        maintenanceRoomsPanel.BackColor = Color.White;
        maintenanceRoomsPanel.BorderStyle = BorderStyle.FixedSingle;
        maintenanceRoomsPanel.Controls.Add(maintenanceRoomsNoteLabel);
        maintenanceRoomsPanel.Controls.Add(maintenanceRoomsValueLabel);
        maintenanceRoomsPanel.Controls.Add(maintenanceRoomsTitleLabel);
        maintenanceRoomsPanel.Dock = DockStyle.Fill;
        maintenanceRoomsPanel.Margin = new Padding(0);
        maintenanceRoomsPanel.Padding = new Padding(16, 12, 16, 12);
        maintenanceRoomsTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        maintenanceRoomsTitleLabel.Font = UiStyleHelper.SmallFont(9.5F);
        maintenanceRoomsTitleLabel.ForeColor = UiStyleHelper.TextMuted;
        maintenanceRoomsTitleLabel.Location = new Point(16, 12);
        maintenanceRoomsTitleLabel.Size = new Size(210, 22);
        maintenanceRoomsTitleLabel.Text = "Bảo trì";
        maintenanceRoomsTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        maintenanceRoomsValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        maintenanceRoomsValueLabel.Font = UiStyleHelper.TitleFont(17F);
        maintenanceRoomsValueLabel.ForeColor = UiStyleHelper.Danger;
        maintenanceRoomsValueLabel.Location = new Point(16, 36);
        maintenanceRoomsValueLabel.Size = new Size(210, 32);
        maintenanceRoomsValueLabel.Text = "1";
        maintenanceRoomsValueLabel.TextAlign = ContentAlignment.MiddleLeft;
        maintenanceRoomsNoteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        maintenanceRoomsNoteLabel.Font = UiStyleHelper.SmallFont(8.75F);
        maintenanceRoomsNoteLabel.ForeColor = UiStyleHelper.TextMuted;
        maintenanceRoomsNoteLabel.Location = new Point(16, 68);
        maintenanceRoomsNoteLabel.Size = new Size(210, 22);
        maintenanceRoomsNoteLabel.Text = "Cần kiểm tra";
        maintenanceRoomsNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        gridLayout.Controls.Add(gridTitleLabel, 0, 0);
        gridLayout.Controls.Add(roomGrid, 0, 1);
        gridLayout.Dock = DockStyle.Fill;
        gridLayout.RowCount = 2;
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(gridTitleLabel, "DANH SÁCH PHÒNG CHIẾU");
        ConfigureGrid(roomGrid);
        roomGrid.Dock = DockStyle.Fill;
        roomGrid.AutoGenerateColumns = false;
        roomGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        roomGrid.ColumnHeadersHeight = 40;
        roomGrid.RowHeadersVisible = false;
        roomGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        roomGridRoomIdColumn.Name = "RoomId";
        roomGridRoomIdColumn.DataPropertyName = "RoomId";
        roomGridRoomIdColumn.HeaderText = "Mã phòng";
        roomGridRoomIdColumn.FillWeight = 80F;
        roomGrid.Columns.Add(roomGridRoomIdColumn);
        roomGridNameColumn.Name = "Name";
        roomGridNameColumn.DataPropertyName = "Name";
        roomGridNameColumn.HeaderText = "Tên phòng";
        roomGridNameColumn.FillWeight = 120F;
        roomGrid.Columns.Add(roomGridNameColumn);
        roomGridRoomTypeColumn.Name = "RoomType";
        roomGridRoomTypeColumn.DataPropertyName = "RoomType";
        roomGridRoomTypeColumn.HeaderText = "Loại";
        roomGridRoomTypeColumn.FillWeight = 80F;
        roomGrid.Columns.Add(roomGridRoomTypeColumn);
        roomGridSeatRowsColumn.Name = "SeatRows";
        roomGridSeatRowsColumn.DataPropertyName = "SeatRows";
        roomGridSeatRowsColumn.HeaderText = "Số hàng";
        roomGridSeatRowsColumn.FillWeight = 75F;
        roomGrid.Columns.Add(roomGridSeatRowsColumn);
        roomGridSeatsPerRowColumn.Name = "SeatsPerRow";
        roomGridSeatsPerRowColumn.DataPropertyName = "SeatsPerRow";
        roomGridSeatsPerRowColumn.HeaderText = "Ghế/hàng";
        roomGridSeatsPerRowColumn.FillWeight = 80F;
        roomGrid.Columns.Add(roomGridSeatsPerRowColumn);
        roomGridSeatCountColumn.Name = "SeatCount";
        roomGridSeatCountColumn.DataPropertyName = "SeatCount";
        roomGridSeatCountColumn.HeaderText = "Tổng ghế";
        roomGridSeatCountColumn.FillWeight = 90F;
        roomGrid.Columns.Add(roomGridSeatCountColumn);
        roomGridStatusColumn.Name = "Status";
        roomGridStatusColumn.DataPropertyName = "Status";
        roomGridStatusColumn.HeaderText = "Trạng thái";
        roomGridStatusColumn.FillWeight = 110F;
        roomGrid.Columns.Add(roomGridStatusColumn);
        roomGridNoteColumn.Name = "Note";
        roomGridNoteColumn.DataPropertyName = "Note";
        roomGridNoteColumn.HeaderText = "Ghi chú";
        roomGridNoteColumn.FillWeight = 150F;
        roomGrid.Columns.Add(roomGridNoteColumn);
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
        editorLayout.ColumnCount = 2;
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
        editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        editorLayout.Controls.Add(editorTitleLabel, 0, 0);
        editorLayout.Controls.Add(roomNameInputLabel, 0, 1);
        editorLayout.Controls.Add(roomNameTextBox, 1, 1);
        editorLayout.Controls.Add(roomTypeInputLabel, 0, 2);
        editorLayout.Controls.Add(roomTypeCombo, 1, 2);
        editorLayout.Controls.Add(seatConfigLayout, 0, 3);
        editorLayout.Controls.Add(roomStatusInputLabel, 0, 4);
        editorLayout.Controls.Add(roomStatusCombo, 1, 4);
        editorLayout.Controls.Add(detailLabel, 0, 5);
        editorLayout.Dock = DockStyle.Fill;
        editorLayout.RowCount = 6;
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        editorLayout.SetColumnSpan(editorTitleLabel, 2);
        editorLayout.SetColumnSpan(seatConfigLayout, 2);
        editorLayout.SetColumnSpan(detailLabel, 2);
        StyleCardTitle(editorTitleLabel, "THÔNG TIN PHÒNG");
        StyleFieldLabel(roomNameInputLabel, "Tên phòng");
        StyleFieldLabel(roomTypeInputLabel, "Loại phòng");
        StyleFieldLabel(roomStatusInputLabel, "Trạng thái");
        ConfigureTextBox(roomNameTextBox);
        ConfigureTextBox(rowCountTextBox);
        ConfigureTextBox(seatsPerRowTextBox);
        ConfigureCombo(roomTypeCombo);
        ConfigureCombo(roomStatusCombo);
        DockFieldControl(roomNameTextBox);
        DockFieldControl(roomTypeCombo);
        DockFieldControl(roomStatusCombo);
        //
        // seatConfigLayout
        //
        seatConfigLayout.ColumnCount = 4;
        seatConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
        seatConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        seatConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
        seatConfigLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
        seatConfigLayout.Controls.Add(rowCountInputLabel, 0, 0);
        seatConfigLayout.Controls.Add(rowCountTextBox, 1, 0);
        seatConfigLayout.Controls.Add(seatsPerRowInputLabel, 2, 0);
        seatConfigLayout.Controls.Add(seatsPerRowTextBox, 3, 0);
        seatConfigLayout.Dock = DockStyle.Fill;
        seatConfigLayout.RowCount = 1;
        seatConfigLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleFieldLabel(rowCountInputLabel, "Số hàng");
        StyleFieldLabel(seatsPerRowInputLabel, "Ghế/hàng");
        DockFieldControl(rowCountTextBox);
        DockFieldControl(seatsPerRowTextBox);
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
        previewLayout.Controls.Add(previewTitleLabel, 0, 0);
        previewLayout.Controls.Add(seatPreviewPanel, 0, 1);
        previewLayout.Dock = DockStyle.Fill;
        previewLayout.RowCount = 2;
        previewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        previewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(previewTitleLabel, "SƠ ĐỒ GHẾ MẪU");
        seatPreviewPanel.BackColor = Color.White;
        seatPreviewPanel.ColumnCount = 11;
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        seatPreviewPanel.Dock = DockStyle.Fill;
        seatPreviewPanel.Padding = new Padding(8, 8, 8, 4);
        seatPreviewPanel.RowCount = 6;
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatPreviewPanel.Controls.Add(previewSeatARowLabel, 0, 0);
        StyleSeatPreviewLabel(previewSeatARowLabel, "A", true);
        seatPreviewPanel.Controls.Add(previewSeatA1Label, 1, 0);
        StyleSeatPreviewLabel(previewSeatA1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatA2Label, 2, 0);
        StyleSeatPreviewLabel(previewSeatA2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatA3Label, 3, 0);
        StyleSeatPreviewLabel(previewSeatA3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatA4Label, 4, 0);
        StyleSeatPreviewLabel(previewSeatA4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatA5Label, 5, 0);
        StyleSeatPreviewLabel(previewSeatA5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatA6Label, 6, 0);
        StyleSeatPreviewLabel(previewSeatA6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatA7Label, 7, 0);
        StyleSeatPreviewLabel(previewSeatA7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatA8Label, 8, 0);
        StyleSeatPreviewLabel(previewSeatA8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatA9Label, 9, 0);
        StyleSeatPreviewLabel(previewSeatA9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatA10Label, 10, 0);
        StyleSeatPreviewLabel(previewSeatA10Label, "10", false);
        seatPreviewPanel.Controls.Add(previewSeatBRowLabel, 0, 1);
        StyleSeatPreviewLabel(previewSeatBRowLabel, "B", true);
        seatPreviewPanel.Controls.Add(previewSeatB1Label, 1, 1);
        StyleSeatPreviewLabel(previewSeatB1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatB2Label, 2, 1);
        StyleSeatPreviewLabel(previewSeatB2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatB3Label, 3, 1);
        StyleSeatPreviewLabel(previewSeatB3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatB4Label, 4, 1);
        StyleSeatPreviewLabel(previewSeatB4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatB5Label, 5, 1);
        StyleSeatPreviewLabel(previewSeatB5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatB6Label, 6, 1);
        StyleSeatPreviewLabel(previewSeatB6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatB7Label, 7, 1);
        StyleSeatPreviewLabel(previewSeatB7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatB8Label, 8, 1);
        StyleSeatPreviewLabel(previewSeatB8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatB9Label, 9, 1);
        StyleSeatPreviewLabel(previewSeatB9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatB10Label, 10, 1);
        StyleSeatPreviewLabel(previewSeatB10Label, "10", false);
        seatPreviewPanel.Controls.Add(previewSeatCRowLabel, 0, 2);
        StyleSeatPreviewLabel(previewSeatCRowLabel, "C", true);
        seatPreviewPanel.Controls.Add(previewSeatC1Label, 1, 2);
        StyleSeatPreviewLabel(previewSeatC1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatC2Label, 2, 2);
        StyleSeatPreviewLabel(previewSeatC2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatC3Label, 3, 2);
        StyleSeatPreviewLabel(previewSeatC3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatC4Label, 4, 2);
        StyleSeatPreviewLabel(previewSeatC4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatC5Label, 5, 2);
        StyleSeatPreviewLabel(previewSeatC5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatC6Label, 6, 2);
        StyleSeatPreviewLabel(previewSeatC6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatC7Label, 7, 2);
        StyleSeatPreviewLabel(previewSeatC7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatC8Label, 8, 2);
        StyleSeatPreviewLabel(previewSeatC8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatC9Label, 9, 2);
        StyleSeatPreviewLabel(previewSeatC9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatC10Label, 10, 2);
        StyleSeatPreviewLabel(previewSeatC10Label, "10", false);
        seatPreviewPanel.Controls.Add(previewSeatDRowLabel, 0, 3);
        StyleSeatPreviewLabel(previewSeatDRowLabel, "D", true);
        seatPreviewPanel.Controls.Add(previewSeatD1Label, 1, 3);
        StyleSeatPreviewLabel(previewSeatD1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatD2Label, 2, 3);
        StyleSeatPreviewLabel(previewSeatD2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatD3Label, 3, 3);
        StyleSeatPreviewLabel(previewSeatD3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatD4Label, 4, 3);
        StyleSeatPreviewLabel(previewSeatD4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatD5Label, 5, 3);
        StyleSeatPreviewLabel(previewSeatD5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatD6Label, 6, 3);
        StyleSeatPreviewLabel(previewSeatD6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatD7Label, 7, 3);
        StyleSeatPreviewLabel(previewSeatD7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatD8Label, 8, 3);
        StyleSeatPreviewLabel(previewSeatD8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatD9Label, 9, 3);
        StyleSeatPreviewLabel(previewSeatD9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatD10Label, 10, 3);
        StyleSeatPreviewLabel(previewSeatD10Label, "10", false);
        seatPreviewPanel.Controls.Add(previewSeatERowLabel, 0, 4);
        StyleSeatPreviewLabel(previewSeatERowLabel, "E", true);
        seatPreviewPanel.Controls.Add(previewSeatE1Label, 1, 4);
        StyleSeatPreviewLabel(previewSeatE1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatE2Label, 2, 4);
        StyleSeatPreviewLabel(previewSeatE2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatE3Label, 3, 4);
        StyleSeatPreviewLabel(previewSeatE3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatE4Label, 4, 4);
        StyleSeatPreviewLabel(previewSeatE4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatE5Label, 5, 4);
        StyleSeatPreviewLabel(previewSeatE5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatE6Label, 6, 4);
        StyleSeatPreviewLabel(previewSeatE6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatE7Label, 7, 4);
        StyleSeatPreviewLabel(previewSeatE7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatE8Label, 8, 4);
        StyleSeatPreviewLabel(previewSeatE8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatE9Label, 9, 4);
        StyleSeatPreviewLabel(previewSeatE9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatE10Label, 10, 4);
        StyleSeatPreviewLabel(previewSeatE10Label, "10", false);
        seatPreviewPanel.Controls.Add(previewSeatFRowLabel, 0, 5);
        StyleSeatPreviewLabel(previewSeatFRowLabel, "F", true);
        seatPreviewPanel.Controls.Add(previewSeatF1Label, 1, 5);
        StyleSeatPreviewLabel(previewSeatF1Label, "1", false);
        seatPreviewPanel.Controls.Add(previewSeatF2Label, 2, 5);
        StyleSeatPreviewLabel(previewSeatF2Label, "2", false);
        seatPreviewPanel.Controls.Add(previewSeatF3Label, 3, 5);
        StyleSeatPreviewLabel(previewSeatF3Label, "3", false);
        seatPreviewPanel.Controls.Add(previewSeatF4Label, 4, 5);
        StyleSeatPreviewLabel(previewSeatF4Label, "4", false);
        seatPreviewPanel.Controls.Add(previewSeatF5Label, 5, 5);
        StyleSeatPreviewLabel(previewSeatF5Label, "5", false);
        seatPreviewPanel.Controls.Add(previewSeatF6Label, 6, 5);
        StyleSeatPreviewLabel(previewSeatF6Label, "6", false);
        seatPreviewPanel.Controls.Add(previewSeatF7Label, 7, 5);
        StyleSeatPreviewLabel(previewSeatF7Label, "7", false);
        seatPreviewPanel.Controls.Add(previewSeatF8Label, 8, 5);
        StyleSeatPreviewLabel(previewSeatF8Label, "8", false);
        seatPreviewPanel.Controls.Add(previewSeatF9Label, 9, 5);
        StyleSeatPreviewLabel(previewSeatF9Label, "9", false);
        seatPreviewPanel.Controls.Add(previewSeatF10Label, 10, 5);
        StyleSeatPreviewLabel(previewSeatF10Label, "10", false);
        rootLayout.ResumeLayout(false);
        statLayout.ResumeLayout(false);
        totalRoomsPanel.ResumeLayout(false);
        activeRoomsPanel.ResumeLayout(false);
        totalSeatsPanel.ResumeLayout(false);
        maintenanceRoomsPanel.ResumeLayout(false);
        actionPanel.ResumeLayout(false);
        contentLayout.ResumeLayout(false);
        gridPanel.ResumeLayout(false);
        gridLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)roomGrid).EndInit();
        rightLayout.ResumeLayout(false);
        editorPanel.ResumeLayout(false);
        editorLayout.ResumeLayout(false);
        seatConfigLayout.ResumeLayout(false);
        previewPanel.ResumeLayout(false);
        previewLayout.ResumeLayout(false);
        UiStyleHelper.CompleteDesignerGrid(roomGrid);
        ResumeLayout(false);
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
    private static void StyleSeatPreviewLabel(Label label, string text, bool isRowHeader)
    {
        label.BackColor = isRowHeader ? Color.White : UiStyleHelper.SeatAvailable;
        label.BorderStyle = isRowHeader ? BorderStyle.None : BorderStyle.FixedSingle;
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(isRowHeader ? 9.5F : 8.5F);
        label.ForeColor = UiStyleHelper.TextDark;
        label.Margin = new Padding(4, 3, 4, 3);
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
    }
}
