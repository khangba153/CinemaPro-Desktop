using System;
using System.Collections.Generic;
using CinemaPro.WinForms.DesignFirst.Models;
using CinemaPro.WinForms.DesignFirst.ViewModels;
using CinemaPro.WinForms.DesignFirst.Repositories;

namespace CinemaPro.WinForms.DesignFirst.Services
{
    public class ShowtimeService
    {
        private readonly ShowtimeRepository _repository = new ShowtimeRepository();

        public List<ShowtimeRow> GetAllShowtimes()
        {
            return _repository.GetAllWithDetails();
        }

       
        public List<TodayShowtimeViewModel> GetTodayShowtimes()
        {
            return _repository.GetTodayShowtimes();
        }

       
        public void CreateShowtime(Showtime showtime)
        {
            if (string.IsNullOrWhiteSpace(showtime.ShowtimeCode))
                throw new ArgumentException("Mã suất chiếu không được để trống.");

            if (showtime.MovieId <= 0)
                throw new ArgumentException("Vui lòng chọn một bộ phim hợp lệ.");

            if (showtime.RoomId <= 0)
                throw new ArgumentException("Vui lòng chọn một phòng chiếu hợp lệ.");

            if (showtime.StartAt >= showtime.EndAt)
                throw new ArgumentException("Thời gian kết thúc suất chiếu phải lớn hơn thời gian bắt đầu.");

            if (showtime.StartAt < DateTime.Now)
                throw new ArgumentException("Không thể tạo lịch chiếu ở khung giờ quá khứ.");

            if (showtime.BasePrice < 0)
                throw new ArgumentException("Giá vé cơ bản không được nhỏ hơn 0.");

            bool isConflict = _repository.IsRoomConflicting(showtime.RoomId, showtime.StartAt, showtime.EndAt);
            if (isConflict)
                throw new InvalidOperationException("Phòng chiếu này đã có lịch chiếu khác trong khung giờ bạn đã chọn.");

            bool isSuccess = _repository.Insert(showtime);
            if (!isSuccess)
                throw new Exception("Thêm suất chiếu thất bại. Vui lòng kiểm tra lại dữ liệu.");
        }

        public void UpdateShowtime(Showtime showtime)
        {
            if (showtime.ShowtimeId <= 0)
                throw new ArgumentException("Suất chiếu không tồn tại hoặc ID không hợp lệ.");

            if (showtime.StartAt >= showtime.EndAt)
                throw new ArgumentException("Thời gian kết thúc suất chiếu phải lớn hơn thời gian bắt đầu.");

            if (showtime.BasePrice < 0)
                throw new ArgumentException("Giá vé cơ bản không được nhỏ hơn 0.");

            bool isConflict = _repository.IsRoomConflicting(showtime.RoomId, showtime.StartAt, showtime.EndAt, showtime.ShowtimeId);
            if (isConflict)
                throw new InvalidOperationException("Không thể cập nhật. Khung giờ mới bị trùng với lịch chiếu khác của phòng này.");

            bool isSuccess = _repository.Update(showtime);
            if (!isSuccess)
                throw new Exception("Cập nhật suất chiếu thất bại.");
        }

        public void CancelOrCloseShowtime(int showtimeId, string status)
        {
            if (showtimeId <= 0)
                throw new ArgumentException("Vui lòng chọn một suất chiếu cụ thể trên bảng trước khi hủy.");

            string query = "UPDATE dbo.Showtimes SET ShowtimeStatus = @Status, UpdatedAt = SYSDATETIME() WHERE ShowtimeId = @ShowtimeId";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
        new Microsoft.Data.SqlClient.SqlParameter("@Status", status),
        new Microsoft.Data.SqlClient.SqlParameter("@ShowtimeId", showtimeId)
            };

            int rowsAffected = CinemaPro.WinForms.DesignFirst.Data.DatabaseHelper.ExecuteNonQuery(query, parameters);

            if (rowsAffected == 0)
            {
                throw new Exception($"Lỗi thực thi: Lệnh UPDATE đã chạy nhưng không có dòng nào có ID = {showtimeId} trong Database bị tác động!");
            }
        }
    }
}