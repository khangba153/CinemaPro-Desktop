namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class ShowtimeService
{
    private readonly ShowtimeRepository _showtimeRepository = new();

    public bool HasConflict(string roomId, DateTime startAt, DateTime endAt, string? exceptShowtimeId, out string message)
    {
        if (!int.TryParse(roomId, out var parsedRoomId))
        {
            message = "Vui lòng chọn phòng chiếu.";
            return true;
        }

        var parsedExceptId = int.TryParse(exceptShowtimeId, out var id) ? id : (int?)null;
        var conflict = _showtimeRepository.HasRoomConflict(parsedRoomId, startAt, endAt, parsedExceptId);
        message = conflict
            ? "Phòng chiếu đã có lịch chiếu trùng thời gian."
            : "Không phát hiện trùng lịch.";
        return conflict;
    }

    public bool CreateShowtime(string movieId, string roomId, DateTime startAt, DateTime endAt, string priceText, string format, string status, out string message)
    {
        if (!Validate(movieId, roomId, startAt, endAt, priceText, format, status, out var parsedMovieId, out var parsedRoomId, out var price, out message))
        {
            return false;
        }

        if (_showtimeRepository.HasRoomConflict(parsedRoomId, startAt, endAt))
        {
            message = "Phòng chiếu đã có lịch chiếu trùng thời gian.";
            return false;
        }

        _showtimeRepository.Insert(parsedMovieId, parsedRoomId, startAt, endAt, price, format, status);
        message = "Đã tạo suất chiếu.";
        return true;
    }

    public bool UpdateShowtime(string showtimeId, string movieId, string roomId, DateTime startAt, DateTime endAt, string priceText, string format, string status, out string message)
    {
        if (!int.TryParse(showtimeId, out var parsedShowtimeId))
        {
            message = "Vui lòng chọn suất chiếu cần sửa.";
            return false;
        }

        if (!Validate(movieId, roomId, startAt, endAt, priceText, format, status, out var parsedMovieId, out var parsedRoomId, out var price, out message))
        {
            return false;
        }

        if (_showtimeRepository.HasRoomConflict(parsedRoomId, startAt, endAt, parsedShowtimeId))
        {
            message = "Phòng chiếu đã có lịch chiếu trùng thời gian.";
            return false;
        }

        _showtimeRepository.Update(parsedShowtimeId, parsedMovieId, parsedRoomId, startAt, endAt, price, format, status);
        message = "Đã cập nhật suất chiếu.";
        return true;
    }

    public bool CancelShowtime(string showtimeId, out string message)
    {
        if (!int.TryParse(showtimeId, out var parsedShowtimeId))
        {
            message = "Vui lòng chọn suất chiếu cần hủy.";
            return false;
        }

        _showtimeRepository.Cancel(parsedShowtimeId);
        message = "Đã hủy suất chiếu.";
        return true;
    }

    private static bool Validate(
        string movieId,
        string roomId,
        DateTime startAt,
        DateTime endAt,
        string priceText,
        string format,
        string status,
        out int parsedMovieId,
        out int parsedRoomId,
        out decimal price,
        out string message)
    {
        parsedMovieId = 0;
        parsedRoomId = 0;
        price = 0;

        if (!int.TryParse(movieId, out parsedMovieId))
        {
            message = "Vui lòng chọn phim.";
            return false;
        }

        if (!int.TryParse(roomId, out parsedRoomId))
        {
            message = "Vui lòng chọn phòng.";
            return false;
        }

        if (endAt <= startAt)
        {
            message = "Giờ kết thúc phải sau giờ bắt đầu.";
            return false;
        }

        if (!decimal.TryParse(priceText.Trim(), out price) || price < 0)
        {
            message = "Giá vé không hợp lệ.";
            return false;
        }

        if (format is not ("2D" or "3D" or "IMAX" or "VIP"))
        {
            message = "Định dạng chiếu không hợp lệ.";
            return false;
        }

        if (status is not ("Open" or "Closed" or "Cancelled" or "Finished"))
        {
            message = "Trạng thái suất chiếu không hợp lệ.";
            return false;
        }

        message = "";
        return true;
    }
}
