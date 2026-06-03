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
            var status = statusComboBox.Text.StartsWith("Tất cả", StringComparison.OrdinalIgnoreCase)
                ? "NowShowing"
                : statusComboBox.Text;
            var genre = genreComboBox.Text.StartsWith("Tất cả", StringComparison.OrdinalIgnoreCase)
                ? _movieService.GetGenres().FirstOrDefault() ?? ""
                : genreComboBox.Text;

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
                ShowResult(_movieService.StopMovie(_selectedMovieId, out var message), message);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể xử lý phim.\n\n" + ex.Message, "Lỗi database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadMovies()
    {
        var movies = AppServices.CinemaStore.GetMovies().AsEnumerable();
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
        }
    }

    private void LoadComboboxes()
    {
        genreComboBox.Items.Clear();
        genreComboBox.Items.Add("Tất cả thể loại");
        genreComboBox.Items.AddRange(_movieService.GetGenres().Cast<object>().ToArray());
        genreComboBox.SelectedIndex = 0;

        statusComboBox.Items.Clear();
        statusComboBox.Items.AddRange(new object[] { "Tất cả trạng thái", "NowShowing", "ComingSoon", "Stopped" });
        statusComboBox.SelectedIndex = 0;
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
        genreComboBox.Text = movie.Genre;
        statusComboBox.Text = movie.Status;
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
