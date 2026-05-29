using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class MovieManagementForm : Form
{
    public MovieManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(movieGrid);
    }

    private void MovieManagementForm_Load(object? sender, EventArgs e)
    {
        genreComboBox.SelectedIndex = 0;
        statusComboBox.SelectedIndex = 0;
        ageComboBox.SelectedIndex = 1;
        LoadMovies();
    }

    private void RefreshButton_Click(object? sender, EventArgs e) => LoadMovies();

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Chức năng quản lý phim đang dùng dữ liệu demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadMovies()
    {
        var movies = AppServices.CinemaStore.GetMovies().AsEnumerable();
        if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
        {
            movies = movies.Where(movie => movie.Title.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase));
        }

        movieGrid.Rows.Clear();
        foreach (var movie in movies)
        {
            movieGrid.Rows.Add(movie.MovieId, movie.Title, movie.Genre, $"{movie.DurationMinutes} phút", movie.AgeRating, movie.Director, movie.Status);
        }
    }
}
