using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class MovieManagementForm : Form
{
    private readonly List<MovieRow> _movies;

    public MovieManagementForm()
    {
        _movies = AppServices.CinemaStore.GetMovies().ToList();
        InitializeComponent();
        WireEvents();
        LoadData();
    }

    private void WireEvents()
    {
        _movieGrid.SelectionChanged += (_, _) => UpdateDetailFromGrid();
        searchTextBox.TextChanged += (_, _) => ApplyMovieFilter();
        genreFilterCombo.SelectedIndexChanged += (_, _) => ApplyMovieFilter();
        statusFilterCombo.SelectedIndexChanged += (_, _) => ApplyMovieFilter();
        refreshButton.Click += (_, _) =>
        {
            searchTextBox.Clear();
            genreFilterCombo.SelectedIndex = 0;
            statusFilterCombo.SelectedIndex = 0;
            ApplyMovieFilter();
        };
        addMovieButton.Click += (_, _) => MessageBox.Show("Demo UI: thêm phim sẽ được kết nối API ở giai đoạn sau.", "Quản lý phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        addShowtimeButton.Click += (_, _) => MessageBox.Show("Demo UI: lịch chiếu dùng dữ liệu giả trong phiên chạy.", "Quản lý phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        saveButton.Click += (_, _) => MessageBox.Show("Đã lưu thông tin phim trên giao diện demo.", "Quản lý phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        updateButton.Click += (_, _) => MessageBox.Show("Đã cập nhật thông tin phim trên giao diện demo.", "Quản lý phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        deleteButton.Click += (_, _) => MessageBox.Show("Demo UI: phim được đánh dấu ngừng chiếu, không xóa dữ liệu thật.", "Quản lý phim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void LoadData()
    {
        genreFilterCombo.SelectedIndex = 0;
        statusFilterCombo.SelectedIndex = 0;
        BindMovieGrid(_movies);
    }

    private void ApplyMovieFilter()
    {
        var keyword = searchTextBox.Text.Trim();
        var selectedGenre = genreFilterCombo.SelectedItem?.ToString();
        var selectedStatus = statusFilterCombo.SelectedItem?.ToString();

        var filtered = _movies.Where(movie =>
            (string.IsNullOrWhiteSpace(keyword) || movie.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || movie.MovieId.Contains(keyword, StringComparison.OrdinalIgnoreCase)) &&
            (genreFilterCombo.SelectedIndex <= 0 || string.Equals(movie.Genre, selectedGenre, StringComparison.OrdinalIgnoreCase)) &&
            (statusFilterCombo.SelectedIndex <= 0 || string.Equals(movie.Status, selectedStatus, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        BindMovieGrid(filtered);
    }

    private void BindMovieGrid(IReadOnlyList<MovieRow> movies)
    {
        _movieGrid.DataSource = movies.Select(movie => new
        {
            movie.MovieId,
            movie.Title,
            movie.Genre,
            Duration = $"{movie.Duration} phút",
            movie.Status
        }).ToList();

        if (movies.Count == 0)
        {
            ClearDetail();
            return;
        }

        _movieGrid.Rows[0].Selected = true;
        UpdateDetail(movies[0]);
    }

    private void UpdateDetailFromGrid()
    {
        if (_movieGrid.SelectedRows.Count == 0)
        {
            return;
        }

        var id = _movieGrid.SelectedRows[0].Cells["MovieId"].Value?.ToString();
        var movie = _movies.FirstOrDefault(item => item.MovieId == id);
        if (movie is not null)
        {
            UpdateDetail(movie);
        }
    }

    private void UpdateDetail(MovieRow movie)
    {
        _titleBox.Text = movie.Title;
        _genreCombo.SelectedItem = movie.Genre;
        _durationBox.Text = movie.Duration.ToString();
        _statusCombo.SelectedItem = movie.Status;
        _detailLabel.Text = $"Đạo diễn: {movie.Director}     Độ tuổi: {movie.AgeRating}     Mã phim: {movie.MovieId}";
        _showtimeGrid.DataSource = AppServices.CinemaStore.GetShowtimes()
            .Where(showtime => showtime.Movie == movie.Title)
            .Select(showtime => new
            {
                showtime.ShowtimeId,
                showtime.Room,
                Date = showtime.StartTime.ToString("dd/MM/yyyy"),
                Start = showtime.StartTime.ToString("HH:mm"),
                Price = UiStyleHelper.FormatCurrency(showtime.TicketPrice),
                showtime.Status
            })
            .ToList();
    }

    private void ClearDetail()
    {
        _titleBox.Clear();
        _durationBox.Clear();
        _detailLabel.Text = "Không tìm thấy phim phù hợp với bộ lọc hiện tại.";
        _showtimeGrid.DataSource = Array.Empty<object>();
    }
}
