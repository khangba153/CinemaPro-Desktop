namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class MovieManagementForm : Form
{
    private readonly MovieService _movieService = new();
    private string _selectedMovieId = "";

    public MovieManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(movieGrid);
        movieGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        movieGrid.MultiSelect = false;
        movieGrid.SelectionChanged += (_, _) => FillDetailFromSelectedRow();
    }

    private void MovieManagementForm_Load(object? sender, EventArgs e)
    {
        LoadComboboxes();
        ageComboBox.SelectedIndex = 1;
        LoadMovies();
    }

    private void RefreshButton_Click(object? sender, EventArgs e)
    {
        LoadMovies();
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var status = movieStatusComboBox.Text;
            var genre = movieGenreComboBox.Text;

            if (sender == addButton)
            {
                ShowResult(_movieService.AddMovie(titleTextBox.Text, genre, durationTextBox.Text, ageComboBox.Text, directorTextBox.Text, status, out var message), message);
                return;
            }

            if (sender == editButton)
            {
                ShowResult(_movieService.UpdateMovie(_selectedMovieId, titleTextBox.Text, genre, durationTextBox.Text, ageComboBox.Text, directorTextBox.Text, status, out var message), message);
                return;
            }

            if (sender == deleteButton)
            {
                var nextStatus = movieStatusComboBox.Text == "Stopped" ? "NowShowing" : "Stopped";
                ShowResult(_movieService.SetMovieStatus(_selectedMovieId, nextStatus, out var message), message);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể xử lý phim.\n\n" + ex.Message, "Lỗi database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadMovies()
    {
        var movies = _movieService.GetMovies().AsEnumerable();
        if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
        {
            movies = movies.Where(movie => movie.Title.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }

        if (!genreComboBox.Text.StartsWith("Tất cả", StringComparison.OrdinalIgnoreCase))
        {
            movies = movies.Where(movie => movie.Genre == genreComboBox.Text);
        }

        if (!statusComboBox.Text.StartsWith("Tất cả", StringComparison.OrdinalIgnoreCase))
        {
            movies = movies.Where(movie => movie.Status == statusComboBox.Text);
        }

        movieGrid.Rows.Clear();
        foreach (var movie in movies)
        {
            var rowIndex = movieGrid.Rows.Add(movie.MovieId, movie.Title, movie.Genre, $"{movie.DurationMinutes} phút", movie.AgeRating, movie.Director, movie.Status);
            movieGrid.Rows[rowIndex].Tag = movie;
        }

        if (movieGrid.Rows.Count > 0)
        {
            movieGrid.ClearSelection();
            movieGrid.Rows[0].Selected = true;
            FillDetailFromSelectedRow();
            return;
        }

        ClearDetail();
    }

    private void LoadComboboxes()
    {
        genreComboBox.Items.Clear();
        genreComboBox.Items.Add("Tất cả thể loại");
        genreComboBox.Items.AddRange(_movieService.GetGenres().Cast<object>().ToArray());
        genreComboBox.SelectedIndex = 0;

        movieGenreComboBox.Items.Clear();
        movieGenreComboBox.Items.AddRange(_movieService.GetGenres().Cast<object>().ToArray());
        if (movieGenreComboBox.Items.Count > 0)
        {
            movieGenreComboBox.SelectedIndex = 0;
        }

        statusComboBox.Items.Clear();
        statusComboBox.Items.AddRange(new object[] { "Tất cả trạng thái", "NowShowing", "ComingSoon", "Stopped" });
        statusComboBox.SelectedIndex = 0;

        movieStatusComboBox.Items.Clear();
        movieStatusComboBox.Items.AddRange(new object[] { "NowShowing", "ComingSoon", "Stopped" });
        movieStatusComboBox.SelectedIndex = 0;
    }

    private void FillDetailFromSelectedRow()
    {
        if (movieGrid.SelectedRows.Count == 0 || movieGrid.SelectedRows[0].Tag is not MovieRow movie)
        {
            return;
        }

        _selectedMovieId = movie.MovieId;
        titleTextBox.Text = movie.Title;
        directorTextBox.Text = movie.Director;
        durationTextBox.Text = movie.DurationMinutes.ToString();
        ageComboBox.Text = movie.AgeRating;
        movieGenreComboBox.Text = movie.Genre;
        movieStatusComboBox.Text = movie.Status;
        deleteButton.Text = movie.Status == "Stopped" ? "Mở chiếu lại" : "Ngừng chiếu";
        deleteButton.ForeColor = movie.Status == "Stopped" ? Color.FromArgb(22, 163, 74) : Color.FromArgb(220, 38, 38);
    }

    private void ClearDetail()
    {
        _selectedMovieId = "";
        titleTextBox.Clear();
        directorTextBox.Clear();
        durationTextBox.Clear();
        if (ageComboBox.Items.Count > 0)
        {
            ageComboBox.SelectedIndex = 0;
        }

        if (movieGenreComboBox.Items.Count > 0)
        {
            movieGenreComboBox.SelectedIndex = 0;
        }

        if (movieStatusComboBox.Items.Count > 0)
        {
            movieStatusComboBox.SelectedIndex = 0;
        }

        deleteButton.Text = "Ngừng chiếu";
        deleteButton.ForeColor = Color.FromArgb(220, 38, 38);
    }

    private void ShowResult(bool success, string message)
    {
        MessageBox.Show(message, success ? "Thành công" : "Không thể xử lý", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (success)
        {
            LoadComboboxes();
            LoadMovies();
        }
    }
}
