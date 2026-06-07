namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class MovieService
{
    private readonly EfMovieRepository _movieRepository = new();

    public IReadOnlyList<MovieRow> GetMovies() => _movieRepository.GetMovies();

    public IReadOnlyList<string> GetGenres() => _movieRepository.GetGenreNames();

    public bool AddMovie(string title, string genre, string durationText, string ageRating, string director, string status, out string message)
    {
        if (!TryValidate(title, genre, durationText, ageRating, status, out var duration, out message))
        {
            return false;
        }

        _movieRepository.Insert(title.Trim(), genre, duration, ageRating, director.Trim(), status);
        message = "Đã thêm phim.";
        return true;
    }

    public bool UpdateMovie(string movieId, string title, string genre, string durationText, string ageRating, string director, string status, out string message)
    {
        if (!int.TryParse(movieId, out var id))
        {
            message = "Vui lòng chọn phim cần sửa.";
            return false;
        }

        if (!TryValidate(title, genre, durationText, ageRating, status, out var duration, out message))
        {
            return false;
        }

        _movieRepository.Update(id, title.Trim(), genre, duration, ageRating, director.Trim(), status);
        message = "Đã cập nhật phim.";
        return true;
    }

    public bool StopMovie(string movieId, out string message)
    {
        return SetMovieStatus(movieId, "Stopped", out message);
    }

    public bool SetMovieStatus(string movieId, string status, out string message)
    {
        if (!int.TryParse(movieId, out var id))
        {
            message = "Vui lòng chọn phim cần đổi trạng thái.";
            return false;
        }

        if (status is not ("NowShowing" or "ComingSoon" or "Stopped"))
        {
            message = "Trạng thái phim không hợp lệ.";
            return false;
        }

        _movieRepository.UpdateStatus(id, status);
        message = status == "Stopped"
            ? "Đã ngừng chiếu phim."
            : "Đã mở chiếu lại phim.";
        return true;
    }

    private static bool TryValidate(string title, string genre, string durationText, string ageRating, string status, out int duration, out string message)
    {
        duration = 0;

        if (string.IsNullOrWhiteSpace(title))
        {
            message = "Vui lòng nhập tên phim.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(genre) || genre.StartsWith("Tất cả", StringComparison.OrdinalIgnoreCase))
        {
            message = "Vui lòng chọn thể loại.";
            return false;
        }

        if (!int.TryParse(durationText.Trim(), out duration) || duration <= 0)
        {
            message = "Thời lượng phải là số lớn hơn 0.";
            return false;
        }

        if (ageRating is not ("P" or "C13" or "C16" or "C18"))
        {
            message = "Độ tuổi không hợp lệ.";
            return false;
        }

        if (status is not ("NowShowing" or "ComingSoon" or "Stopped"))
        {
            message = "Trạng thái phim không hợp lệ.";
            return false;
        }

        message = "";
        return true;
    }
}
