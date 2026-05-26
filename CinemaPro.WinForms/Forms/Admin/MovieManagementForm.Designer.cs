using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class MovieManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterBar;
    private TextBox searchTextBox;
    private ComboBox genreFilterCombo;
    private ComboBox statusFilterCombo;
    private RoundedButton addMovieButton;
    private RoundedButton addShowtimeButton;
    private RoundedButton refreshButton;
    private TableLayoutPanel mainLayout;
    private RoundedPanel movieGridCard;
    private TableLayoutPanel movieGridLayout;
    private DataGridView _movieGrid;
    private RoundedPanel detailCard;
    private TableLayoutPanel detailLayout;
    private PosterPreview posterPreview;
    private TextBox _titleBox;
    private ComboBox _genreCombo;
    private TextBox _durationBox;
    private ComboBox _formatCombo;
    private ComboBox _statusCombo;
    private Label _detailLabel;
    private TableLayoutPanel detailBottomLayout;
    private TableLayoutPanel detailButtonsLayout;
    private RoundedButton saveButton;
    private RoundedButton updateButton;
    private RoundedButton deleteButton;
    private RoundedPanel showtimeCard;
    private TableLayoutPanel showtimeLayout;
    private DataGridView _showtimeGrid;

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
        filterBar = new FlowLayoutPanel();
        searchTextBox = UiStyleHelper.CreateTextBox("Tìm kiếm phim...");
        genreFilterCombo = UiStyleHelper.CreateComboBox();
        statusFilterCombo = UiStyleHelper.CreateComboBox();
        addMovieButton = UiStyleHelper.CreateButton("Thêm phim");
        addShowtimeButton = UiStyleHelper.CreateOutlineButton("Thêm lịch chiếu", UiStyleHelper.Success);
        refreshButton = UiStyleHelper.CreateOutlineButton("Làm mới");
        mainLayout = new TableLayoutPanel();
        movieGridCard = UiStyleHelper.CreateCard();
        movieGridLayout = new TableLayoutPanel();
        _movieGrid = new DataGridView();
        detailCard = UiStyleHelper.CreateCard();
        detailLayout = new TableLayoutPanel();
        posterPreview = new PosterPreview();
        _titleBox = UiStyleHelper.CreateTextBox("Tên phim");
        _genreCombo = UiStyleHelper.CreateComboBox();
        _durationBox = UiStyleHelper.CreateTextBox("Phút");
        _formatCombo = UiStyleHelper.CreateComboBox();
        _statusCombo = UiStyleHelper.CreateComboBox();
        _detailLabel = new Label();
        detailBottomLayout = new TableLayoutPanel();
        detailButtonsLayout = new TableLayoutPanel();
        saveButton = UiStyleHelper.CreateButton("Lưu");
        updateButton = UiStyleHelper.CreateOutlineButton("Cập nhật");
        deleteButton = UiStyleHelper.CreateOutlineButton("Xóa", UiStyleHelper.Danger);
        showtimeCard = UiStyleHelper.CreateCard();
        showtimeLayout = new TableLayoutPanel();
        _showtimeGrid = new DataGridView();
        rootLayout.SuspendLayout();
        filterBar.SuspendLayout();
        mainLayout.SuspendLayout();
        movieGridCard.SuspendLayout();
        movieGridLayout.SuspendLayout();
        detailCard.SuspendLayout();
        detailLayout.SuspendLayout();
        detailBottomLayout.SuspendLayout();
        detailButtonsLayout.SuspendLayout();
        showtimeCard.SuspendLayout();
        showtimeLayout.SuspendLayout();
        SuspendLayout();
        //
        // MovieManagementForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1100, 620);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        Name = "MovieManagementForm";
        Text = "Quản lý phim";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(filterBar, 0, 0);
        rootLayout.Controls.Add(mainLayout, 0, 1);
        rootLayout.Controls.Add(showtimeCard, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
        //
        // filterBar
        //
        filterBar.BackColor = UiStyleHelper.ContentBackground;
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Tìm kiếm", searchTextBox, 260));
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Thể loại", genreFilterCombo, 160));
        filterBar.Controls.Add(UiStyleHelper.FieldBlock("Trạng thái", statusFilterCombo, 160));
        filterBar.Controls.Add(addMovieButton);
        filterBar.Controls.Add(addShowtimeButton);
        filterBar.Controls.Add(refreshButton);
        filterBar.Dock = DockStyle.Fill;
        filterBar.FlowDirection = FlowDirection.LeftToRight;
        filterBar.Padding = new Padding(0, 0, 0, 8);
        filterBar.WrapContents = false;
        //
        // filter controls
        //
        searchTextBox.Width = 260;
        genreFilterCombo.Width = 160;
        genreFilterCombo.Items.AddRange(new object[] { "Tất cả", "Hành động", "Hoạt hình", "Gia đình", "Khoa học viễn tưởng", "Tâm lý" });
        genreFilterCombo.SelectedIndex = 0;
        statusFilterCombo.Width = 160;
        statusFilterCombo.Items.AddRange(new object[] { "Tất cả", "Đang chiếu", "Sắp chiếu", "Ngừng chiếu" });
        statusFilterCombo.SelectedIndex = 0;
        addMovieButton.Width = 120;
        addShowtimeButton.ForeColor = UiStyleHelper.Success;
        addShowtimeButton.Width = 142;
        refreshButton.Width = 112;
        //
        // mainLayout
        //
        mainLayout.BackColor = UiStyleHelper.ContentBackground;
        mainLayout.ColumnCount = 2;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
        mainLayout.Controls.Add(movieGridCard, 0, 0);
        mainLayout.Controls.Add(detailCard, 1, 0);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Padding = new Padding(0, 0, 0, 10);
        mainLayout.RowCount = 1;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // movieGridCard
        //
        movieGridCard.Controls.Add(movieGridLayout);
        movieGridCard.Dock = DockStyle.Fill;
        movieGridCard.Margin = new Padding(0, 0, 12, 0);
        movieGridCard.Padding = new Padding(10);
        //
        // movieGridLayout
        //
        movieGridLayout.BackColor = Color.Transparent;
        movieGridLayout.ColumnCount = 1;
        movieGridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        movieGridLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Danh sách phim"), 0, 0);
        movieGridLayout.Controls.Add(_movieGrid, 0, 1);
        movieGridLayout.Dock = DockStyle.Fill;
        movieGridLayout.RowCount = 2;
        movieGridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        movieGridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // _movieGrid
        //
        _movieGrid.Dock = DockStyle.Fill;
        _movieGrid.AutoGenerateColumns = false;
        _movieGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _movieGrid.ColumnHeadersHeight = 40;
        _movieGrid.RowHeadersVisible = false;
        _movieGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _movieGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "MovieId", DataPropertyName = "MovieId", HeaderText = "Mã phim", FillWeight = 80, MinimumWidth = 52 });
        _movieGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Title", DataPropertyName = "Title", HeaderText = "Tên phim", FillWeight = 190, MinimumWidth = 52 });
        _movieGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Genre", DataPropertyName = "Genre", HeaderText = "Thể loại", FillWeight = 100, MinimumWidth = 52 });
        _movieGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Duration", DataPropertyName = "Duration", HeaderText = "Thời lượng", FillWeight = 82, MinimumWidth = 52 });
        _movieGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 95, MinimumWidth = 52 });
        UiStyleHelper.ApplyStatusCellFormatting(_movieGrid, "Status");
        //
        // detailCard
        //
        detailCard.Controls.Add(detailLayout);
        detailCard.Dock = DockStyle.Fill;
        detailCard.Padding = new Padding(16);
        //
        // detailLayout
        //
        detailLayout.BackColor = Color.Transparent;
        detailLayout.ColumnCount = 2;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Thông tin phim"), 0, 0);
        detailLayout.Controls.Add(posterPreview, 0, 1);
        detailLayout.Controls.Add(UiStyleHelper.FieldBlock("Tên phim", _titleBox), 1, 1);
        detailLayout.Controls.Add(UiStyleHelper.FieldBlock("Thể loại", _genreCombo), 1, 2);
        detailLayout.Controls.Add(UiStyleHelper.FieldBlock("Thời lượng", _durationBox), 1, 3);
        detailLayout.Controls.Add(UiStyleHelper.FieldBlock("Định dạng", _formatCombo), 1, 4);
        detailLayout.Controls.Add(UiStyleHelper.FieldBlock("Trạng thái", _statusCombo), 1, 5);
        detailLayout.Controls.Add(detailBottomLayout, 0, 6);
        detailLayout.Dock = DockStyle.Fill;
        detailLayout.RowCount = 7;
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
        detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailLayout.SetColumnSpan(detailLayout.GetControlFromPosition(0, 0)!, 2);
        detailLayout.SetRowSpan(posterPreview, 4);
        detailLayout.SetColumnSpan(detailBottomLayout, 2);
        //
        // detail controls
        //
        _genreCombo.Items.AddRange(new object[] { "Hành động", "Hoạt hình", "Gia đình", "Khoa học viễn tưởng", "Tâm lý" });
        _genreCombo.SelectedIndex = 0;
        _titleBox.Text = "Avengers: Endgame";
        _durationBox.Text = "181";
        _formatCombo.Items.AddRange(new object[] { "2D", "3D", "IMAX", "VIP" });
        _formatCombo.SelectedIndex = 0;
        _statusCombo.Items.AddRange(new object[] { "Đang chiếu", "Sắp chiếu", "Ngừng chiếu" });
        _statusCombo.SelectedIndex = 0;
        _detailLabel.Dock = DockStyle.Fill;
        _detailLabel.Font = UiStyleHelper.BodyFont(9.25F);
        _detailLabel.ForeColor = UiStyleHelper.TextMuted;
        _detailLabel.Text = "Đạo diễn: Anthony Russo     Độ tuổi: 13+     Mã phim: MV001";
        _detailLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // detailBottomLayout
        //
        detailBottomLayout.BackColor = Color.Transparent;
        detailBottomLayout.ColumnCount = 1;
        detailBottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailBottomLayout.Controls.Add(_detailLabel, 0, 0);
        detailBottomLayout.Controls.Add(detailButtonsLayout, 0, 1);
        detailBottomLayout.Dock = DockStyle.Fill;
        detailBottomLayout.RowCount = 2;
        detailBottomLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        detailBottomLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        //
        // detailButtonsLayout
        //
        detailButtonsLayout.ColumnCount = 3;
        detailButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        detailButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        detailButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        detailButtonsLayout.Controls.Add(saveButton, 0, 0);
        detailButtonsLayout.Controls.Add(updateButton, 1, 0);
        detailButtonsLayout.Controls.Add(deleteButton, 2, 0);
        detailButtonsLayout.Dock = DockStyle.Fill;
        detailButtonsLayout.RowCount = 1;
        detailButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        saveButton.Dock = DockStyle.Fill;
        updateButton.Dock = DockStyle.Fill;
        deleteButton.BorderColor = ColorTranslator.FromHtml("#FFB4B4");
        deleteButton.Dock = DockStyle.Fill;
        deleteButton.ForeColor = UiStyleHelper.Danger;
        //
        // showtimeCard
        //
        showtimeCard.Controls.Add(showtimeLayout);
        showtimeCard.Dock = DockStyle.Fill;
        showtimeCard.Padding = new Padding(10);
        //
        // showtimeLayout
        //
        showtimeLayout.BackColor = Color.Transparent;
        showtimeLayout.ColumnCount = 1;
        showtimeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        showtimeLayout.Controls.Add(UiStyleHelper.CreateCardTitle("Lịch chiếu của phim đang chọn"), 0, 0);
        showtimeLayout.Controls.Add(_showtimeGrid, 0, 1);
        showtimeLayout.Dock = DockStyle.Fill;
        showtimeLayout.RowCount = 2;
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // _showtimeGrid
        //
        _showtimeGrid.Dock = DockStyle.Fill;
        _showtimeGrid.AutoGenerateColumns = false;
        _showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _showtimeGrid.ColumnHeadersHeight = 40;
        _showtimeGrid.RowHeadersVisible = false;
        _showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "ShowtimeId", DataPropertyName = "ShowtimeId", HeaderText = "Mã lịch", FillWeight = 80, MinimumWidth = 52 });
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Room", DataPropertyName = "Room", HeaderText = "Phòng", FillWeight = 100, MinimumWidth = 52 });
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", HeaderText = "Ngày chiếu", FillWeight = 100, MinimumWidth = 52 });
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Start", DataPropertyName = "Start", HeaderText = "Giờ chiếu", FillWeight = 80, MinimumWidth = 52 });
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", DataPropertyName = "Price", HeaderText = "Giá vé", FillWeight = 90, MinimumWidth = 52 });
        _showtimeGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", FillWeight = 100, MinimumWidth = 52 });
        UiStyleHelper.ApplyStatusCellFormatting(_showtimeGrid, "Status");
        rootLayout.ResumeLayout(false);
        filterBar.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        movieGridCard.ResumeLayout(false);
        movieGridLayout.ResumeLayout(false);
        detailCard.ResumeLayout(false);
        detailLayout.ResumeLayout(false);
        detailBottomLayout.ResumeLayout(false);
        detailButtonsLayout.ResumeLayout(false);
        showtimeCard.ResumeLayout(false);
        showtimeLayout.ResumeLayout(false);
        ResumeLayout(false);
    }
}
