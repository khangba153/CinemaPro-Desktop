using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Admin;

partial class MovieManagementForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private FlowLayoutPanel filterBar;
    private Label searchFilterLabel;
    private TextBox searchTextBox;
    private Label genreFilterLabel;
    private ComboBox genreFilterCombo;
    private Label statusFilterLabel;
    private ComboBox statusFilterCombo;
    private Button addMovieButton;
    private Button addShowtimeButton;
    private Button refreshButton;
    private TableLayoutPanel mainLayout;
    private Panel movieGridCard;
    private TableLayoutPanel movieGridLayout;
    private Label movieGridTitleLabel;
    private DataGridView _movieGrid;
    private Panel detailCard;
    private TableLayoutPanel detailLayout;
    private Label detailTitleLabel;
    private Panel posterPreview;
    private Label titleInputLabel;
    private TextBox _titleBox;
    private Label genreInputLabel;
    private ComboBox _genreCombo;
    private Label durationInputLabel;
    private TextBox _durationBox;
    private Label formatInputLabel;
    private ComboBox _formatCombo;
    private Label movieStatusInputLabel;
    private ComboBox _statusCombo;
    private Label _detailLabel;
    private TableLayoutPanel detailBottomLayout;
    private TableLayoutPanel detailButtonsLayout;
    private Button saveButton;
    private Button updateButton;
    private Button deleteButton;
    private Panel showtimeCard;
    private TableLayoutPanel showtimeLayout;
    private Label showtimeTitleLabel;
    private DataGridView _showtimeGrid;

    private DataGridViewTextBoxColumn movieGridMovieIdColumn;
    private DataGridViewTextBoxColumn movieGridTitleColumn;
    private DataGridViewTextBoxColumn movieGridGenreColumn;
    private DataGridViewTextBoxColumn movieGridDurationColumn;
    private DataGridViewTextBoxColumn movieGridStatusColumn;
    private DataGridViewTextBoxColumn showtimeGridShowtimeIdColumn;
    private DataGridViewTextBoxColumn showtimeGridRoomColumn;
    private DataGridViewTextBoxColumn showtimeGridDateColumn;
    private DataGridViewTextBoxColumn showtimeGridStartColumn;
    private DataGridViewTextBoxColumn showtimeGridPriceColumn;
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
        movieGridMovieIdColumn = new DataGridViewTextBoxColumn();
        movieGridTitleColumn = new DataGridViewTextBoxColumn();
        movieGridGenreColumn = new DataGridViewTextBoxColumn();
        movieGridDurationColumn = new DataGridViewTextBoxColumn();
        movieGridStatusColumn = new DataGridViewTextBoxColumn();
        showtimeGridShowtimeIdColumn = new DataGridViewTextBoxColumn();
        showtimeGridRoomColumn = new DataGridViewTextBoxColumn();
        showtimeGridDateColumn = new DataGridViewTextBoxColumn();
        showtimeGridStartColumn = new DataGridViewTextBoxColumn();
        showtimeGridPriceColumn = new DataGridViewTextBoxColumn();
        showtimeGridStatusColumn = new DataGridViewTextBoxColumn();
        rootLayout = new TableLayoutPanel();
        filterBar = new FlowLayoutPanel();
        searchFilterLabel = new Label();
        searchTextBox = new TextBox();
        searchTextBox.PlaceholderText = "Tìm kiếm phim...";
        searchTextBox.BorderStyle = BorderStyle.FixedSingle;
        searchTextBox.Font = UiStyleHelper.BodyFont(10F);
        searchTextBox.Height = 32;
        genreFilterLabel = new Label();
        genreFilterCombo = new ComboBox();
        genreFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        genreFilterCombo.FlatStyle = FlatStyle.Flat;
        genreFilterCombo.Font = UiStyleHelper.BodyFont(10F);
        genreFilterCombo.Height = 34;
        statusFilterLabel = new Label();
        statusFilterCombo = new ComboBox();
        statusFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        statusFilterCombo.FlatStyle = FlatStyle.Flat;
        statusFilterCombo.Font = UiStyleHelper.BodyFont(10F);
        statusFilterCombo.Height = 34;
        addMovieButton = new Button();
        addShowtimeButton = new Button();
        refreshButton = new Button();
        mainLayout = new TableLayoutPanel();
        movieGridCard = new Panel();
        movieGridLayout = new TableLayoutPanel();
        movieGridTitleLabel = new Label();
        _movieGrid = new DataGridView();
        detailCard = new Panel();
        detailLayout = new TableLayoutPanel();
        detailTitleLabel = new Label();
        posterPreview = new Panel();
        titleInputLabel = new Label();
        _titleBox = new TextBox();
        _titleBox.PlaceholderText = "Tên phim";
        _titleBox.BorderStyle = BorderStyle.FixedSingle;
        _titleBox.Font = UiStyleHelper.BodyFont(10F);
        _titleBox.Height = 32;
        genreInputLabel = new Label();
        _genreCombo = new ComboBox();
        _genreCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _genreCombo.FlatStyle = FlatStyle.Flat;
        _genreCombo.Font = UiStyleHelper.BodyFont(10F);
        _genreCombo.Height = 34;
        durationInputLabel = new Label();
        _durationBox = new TextBox();
        _durationBox.PlaceholderText = "Phút";
        _durationBox.BorderStyle = BorderStyle.FixedSingle;
        _durationBox.Font = UiStyleHelper.BodyFont(10F);
        _durationBox.Height = 32;
        formatInputLabel = new Label();
        _formatCombo = new ComboBox();
        _formatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _formatCombo.FlatStyle = FlatStyle.Flat;
        _formatCombo.Font = UiStyleHelper.BodyFont(10F);
        _formatCombo.Height = 34;
        movieStatusInputLabel = new Label();
        _statusCombo = new ComboBox();
        _statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _statusCombo.FlatStyle = FlatStyle.Flat;
        _statusCombo.Font = UiStyleHelper.BodyFont(10F);
        _statusCombo.Height = 34;
        _detailLabel = new Label();
        detailBottomLayout = new TableLayoutPanel();
        detailButtonsLayout = new TableLayoutPanel();
        saveButton = new Button();
        updateButton = new Button();
        deleteButton = new Button();
        showtimeCard = new Panel();
        showtimeLayout = new TableLayoutPanel();
        showtimeTitleLabel = new Label();
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
        filterBar.Controls.Add(searchFilterLabel);
        filterBar.Controls.Add(searchTextBox);
        filterBar.Controls.Add(genreFilterLabel);
        filterBar.Controls.Add(genreFilterCombo);
        filterBar.Controls.Add(statusFilterLabel);
        filterBar.Controls.Add(statusFilterCombo);
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
        StyleInlineLabel(searchFilterLabel, "Tìm kiếm", 66);
        searchTextBox.Margin = new Padding(0, 18, 16, 0);
        searchTextBox.Size = new Size(190, 32);
        StyleInlineLabel(genreFilterLabel, "Thể loại", 50);
        genreFilterCombo.Margin = new Padding(0, 18, 16, 0);
        genreFilterCombo.Size = new Size(120, 32);
        genreFilterCombo.Items.AddRange(new object[] { "Tất cả", "Hành động", "Hoạt hình", "Gia đình", "Khoa học viễn tưởng", "Tâm lý" });
        genreFilterCombo.SelectedIndex = 0;
        StyleInlineLabel(statusFilterLabel, "Trạng thái", 66);
        statusFilterCombo.Margin = new Padding(0, 18, 16, 0);
        statusFilterCombo.Size = new Size(120, 32);
        statusFilterCombo.Items.AddRange(new object[] { "Tất cả", "Đang chiếu", "Sắp chiếu", "Ngừng chiếu" });
        statusFilterCombo.SelectedIndex = 0;
        addMovieButton.Width = 104;
        addMovieButton.Height = 38;
        addMovieButton.BackColor = UiStyleHelper.Primary;
        addMovieButton.Cursor = Cursors.Hand;
        addMovieButton.FlatStyle = FlatStyle.Flat;
        addMovieButton.FlatAppearance.BorderSize = 0;
        addMovieButton.Font = UiStyleHelper.SectionFont(9.5F);
        addMovieButton.ForeColor = Color.White;
        addMovieButton.Margin = new Padding(0, 18, 8, 0);
        addMovieButton.Text = "Thêm phim";
        addMovieButton.UseVisualStyleBackColor = false;
        addShowtimeButton.Height = 38;
        addShowtimeButton.BackColor = Color.White;
        addShowtimeButton.Cursor = Cursors.Hand;
        addShowtimeButton.FlatStyle = FlatStyle.Flat;
        addShowtimeButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        addShowtimeButton.FlatAppearance.BorderSize = 1;
        addShowtimeButton.Font = UiStyleHelper.SectionFont(9.5F);
        addShowtimeButton.ForeColor = UiStyleHelper.Success;
        addShowtimeButton.Margin = new Padding(0, 18, 8, 0);
        addShowtimeButton.Text = "Thêm lịch chiếu";
        addShowtimeButton.UseVisualStyleBackColor = false;
        addShowtimeButton.Width = 124;
        refreshButton.Height = 38;
        refreshButton.BackColor = Color.White;
        refreshButton.Cursor = Cursors.Hand;
        refreshButton.FlatStyle = FlatStyle.Flat;
        refreshButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        refreshButton.FlatAppearance.BorderSize = 1;
        refreshButton.Font = UiStyleHelper.SectionFont(9.5F);
        refreshButton.ForeColor = UiStyleHelper.Primary;
        refreshButton.Margin = new Padding(0, 18, 8, 0);
        refreshButton.Text = "Làm mới";
        refreshButton.UseVisualStyleBackColor = false;
        refreshButton.Width = 96;
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
        movieGridCard.BackColor = Color.White;
        movieGridCard.BorderStyle = BorderStyle.FixedSingle;
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
        movieGridLayout.Controls.Add(movieGridTitleLabel, 0, 0);
        movieGridLayout.Controls.Add(_movieGrid, 0, 1);
        movieGridLayout.Dock = DockStyle.Fill;
        movieGridLayout.RowCount = 2;
        movieGridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        movieGridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(movieGridTitleLabel, "DANH SÁCH PHIM");
        //
        // _movieGrid
        //
        _movieGrid.Dock = DockStyle.Fill;
        _movieGrid.AutoGenerateColumns = false;
        _movieGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _movieGrid.ColumnHeadersHeight = 40;
        _movieGrid.RowHeadersVisible = false;
        _movieGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        movieGridMovieIdColumn.Name = "MovieId";
        movieGridMovieIdColumn.DataPropertyName = "MovieId";
        movieGridMovieIdColumn.HeaderText = "Mã phim";
        movieGridMovieIdColumn.FillWeight = 80F;
        movieGridMovieIdColumn.MinimumWidth = 52;
        _movieGrid.Columns.Add(movieGridMovieIdColumn);
        movieGridTitleColumn.Name = "Title";
        movieGridTitleColumn.DataPropertyName = "Title";
        movieGridTitleColumn.HeaderText = "Tên phim";
        movieGridTitleColumn.FillWeight = 190F;
        movieGridTitleColumn.MinimumWidth = 52;
        _movieGrid.Columns.Add(movieGridTitleColumn);
        movieGridGenreColumn.Name = "Genre";
        movieGridGenreColumn.DataPropertyName = "Genre";
        movieGridGenreColumn.HeaderText = "Thể loại";
        movieGridGenreColumn.FillWeight = 100F;
        movieGridGenreColumn.MinimumWidth = 52;
        _movieGrid.Columns.Add(movieGridGenreColumn);
        movieGridDurationColumn.Name = "Duration";
        movieGridDurationColumn.DataPropertyName = "Duration";
        movieGridDurationColumn.HeaderText = "Thời lượng";
        movieGridDurationColumn.FillWeight = 82F;
        movieGridDurationColumn.MinimumWidth = 52;
        _movieGrid.Columns.Add(movieGridDurationColumn);
        movieGridStatusColumn.Name = "Status";
        movieGridStatusColumn.DataPropertyName = "Status";
        movieGridStatusColumn.HeaderText = "Trạng thái";
        movieGridStatusColumn.FillWeight = 95F;
        movieGridStatusColumn.MinimumWidth = 52;
        _movieGrid.Columns.Add(movieGridStatusColumn);
        UiStyleHelper.ApplyStatusCellFormatting(_movieGrid, "Status");
        //
        // detailCard
        //
        detailCard.BackColor = Color.White;
        detailCard.BorderStyle = BorderStyle.FixedSingle;
        detailCard.Controls.Add(detailLayout);
        detailCard.Dock = DockStyle.Fill;
        detailCard.Padding = new Padding(16);
        //
        // detailLayout
        //
        detailLayout.BackColor = Color.Transparent;
        detailLayout.ColumnCount = 3;
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
        detailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        detailLayout.Controls.Add(detailTitleLabel, 0, 0);
        detailLayout.Controls.Add(posterPreview, 0, 1);
        detailLayout.Controls.Add(titleInputLabel, 1, 1);
        detailLayout.Controls.Add(_titleBox, 2, 1);
        detailLayout.Controls.Add(genreInputLabel, 1, 2);
        detailLayout.Controls.Add(_genreCombo, 2, 2);
        detailLayout.Controls.Add(durationInputLabel, 1, 3);
        detailLayout.Controls.Add(_durationBox, 2, 3);
        detailLayout.Controls.Add(formatInputLabel, 1, 4);
        detailLayout.Controls.Add(_formatCombo, 2, 4);
        detailLayout.Controls.Add(movieStatusInputLabel, 1, 5);
        detailLayout.Controls.Add(_statusCombo, 2, 5);
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
        detailLayout.SetColumnSpan(detailTitleLabel, 3);
        detailLayout.SetRowSpan(posterPreview, 5);
        posterPreview.BackColor = ColorTranslator.FromHtml("#172554");
        posterPreview.Margin = new Padding(0, 0, 14, 12);
        detailLayout.SetColumnSpan(detailBottomLayout, 3);
        StyleCardTitle(detailTitleLabel, "THÔNG TIN PHIM");
        StyleFieldLabel(titleInputLabel, "Tên phim");
        StyleFieldLabel(genreInputLabel, "Thể loại");
        StyleFieldLabel(durationInputLabel, "Thời lượng");
        StyleFieldLabel(formatInputLabel, "Định dạng");
        StyleFieldLabel(movieStatusInputLabel, "Trạng thái");
        DockFieldControl(_titleBox);
        DockFieldControl(_genreCombo);
        DockFieldControl(_durationBox);
        DockFieldControl(_formatCombo);
        DockFieldControl(_statusCombo);
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
        saveButton.BackColor = UiStyleHelper.Primary;
        saveButton.Cursor = Cursors.Hand;
        saveButton.FlatStyle = FlatStyle.Flat;
        saveButton.FlatAppearance.BorderSize = 0;
        saveButton.Font = UiStyleHelper.SectionFont(9.5F);
        saveButton.ForeColor = Color.White;
        saveButton.Text = "Lưu";
        saveButton.UseVisualStyleBackColor = false;
        updateButton.Dock = DockStyle.Fill;
        updateButton.BackColor = Color.White;
        updateButton.Cursor = Cursors.Hand;
        updateButton.FlatStyle = FlatStyle.Flat;
        updateButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        updateButton.FlatAppearance.BorderSize = 1;
        updateButton.Font = UiStyleHelper.SectionFont(9.5F);
        updateButton.ForeColor = UiStyleHelper.Primary;
        updateButton.Text = "Cập nhật";
        updateButton.UseVisualStyleBackColor = false;
        deleteButton.BackColor = Color.White;
        deleteButton.Cursor = Cursors.Hand;
        deleteButton.Dock = DockStyle.Fill;
        deleteButton.FlatStyle = FlatStyle.Flat;
        deleteButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FFB4B4");
        deleteButton.FlatAppearance.BorderSize = 1;
        deleteButton.Font = UiStyleHelper.SectionFont(9.5F);
        deleteButton.ForeColor = UiStyleHelper.Danger;
        deleteButton.Text = "Xóa";
        deleteButton.UseVisualStyleBackColor = false;
        //
        // showtimeCard
        //
        showtimeCard.BackColor = Color.White;
        showtimeCard.BorderStyle = BorderStyle.FixedSingle;
        showtimeCard.Controls.Add(showtimeLayout);
        showtimeCard.Dock = DockStyle.Fill;
        showtimeCard.Padding = new Padding(10);
        //
        // showtimeLayout
        //
        showtimeLayout.BackColor = Color.Transparent;
        showtimeLayout.ColumnCount = 1;
        showtimeLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        showtimeLayout.Controls.Add(showtimeTitleLabel, 0, 0);
        showtimeLayout.Controls.Add(_showtimeGrid, 0, 1);
        showtimeLayout.Dock = DockStyle.Fill;
        showtimeLayout.RowCount = 2;
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        showtimeLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        StyleCardTitle(showtimeTitleLabel, "LỊCH CHIẾU CỦA PHIM ĐANG CHỌN");
        //
        // _showtimeGrid
        //
        _showtimeGrid.Dock = DockStyle.Fill;
        _showtimeGrid.AutoGenerateColumns = false;
        _showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _showtimeGrid.ColumnHeadersHeight = 40;
        _showtimeGrid.RowHeadersVisible = false;
        _showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGridShowtimeIdColumn.Name = "ShowtimeId";
        showtimeGridShowtimeIdColumn.DataPropertyName = "ShowtimeId";
        showtimeGridShowtimeIdColumn.HeaderText = "Mã lịch";
        showtimeGridShowtimeIdColumn.FillWeight = 80F;
        showtimeGridShowtimeIdColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridShowtimeIdColumn);
        showtimeGridRoomColumn.Name = "Room";
        showtimeGridRoomColumn.DataPropertyName = "Room";
        showtimeGridRoomColumn.HeaderText = "Phòng";
        showtimeGridRoomColumn.FillWeight = 100F;
        showtimeGridRoomColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridRoomColumn);
        showtimeGridDateColumn.Name = "Date";
        showtimeGridDateColumn.DataPropertyName = "Date";
        showtimeGridDateColumn.HeaderText = "Ngày chiếu";
        showtimeGridDateColumn.FillWeight = 100F;
        showtimeGridDateColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridDateColumn);
        showtimeGridStartColumn.Name = "Start";
        showtimeGridStartColumn.DataPropertyName = "Start";
        showtimeGridStartColumn.HeaderText = "Giờ chiếu";
        showtimeGridStartColumn.FillWeight = 80F;
        showtimeGridStartColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridStartColumn);
        showtimeGridPriceColumn.Name = "Price";
        showtimeGridPriceColumn.DataPropertyName = "Price";
        showtimeGridPriceColumn.HeaderText = "Giá vé";
        showtimeGridPriceColumn.FillWeight = 90F;
        showtimeGridPriceColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridPriceColumn);
        showtimeGridStatusColumn.Name = "Status";
        showtimeGridStatusColumn.DataPropertyName = "Status";
        showtimeGridStatusColumn.HeaderText = "Trạng thái";
        showtimeGridStatusColumn.FillWeight = 100F;
        showtimeGridStatusColumn.MinimumWidth = 52;
        _showtimeGrid.Columns.Add(showtimeGridStatusColumn);
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
        UiStyleHelper.CompleteDesignerGrid(_movieGrid);
        UiStyleHelper.CompleteDesignerGrid(_showtimeGrid);
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
}
