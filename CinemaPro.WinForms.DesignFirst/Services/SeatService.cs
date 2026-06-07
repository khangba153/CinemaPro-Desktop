using CinemaPro.WinForms.DesignFirst.Repositories;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class SeatService
{
    private readonly SeatLayoutRepository _seatLayoutRepository = new();
    private readonly SeatRepository _seatRepository = new();

    public IReadOnlyList<SeatInfo> GetSeats(string roomId) => _seatRepository.GetSeats(roomId);

    public IReadOnlyList<SeatInfo> GetSeatsForShowtime(string showtimeId) => _seatRepository.GetSeatsForShowtime(showtimeId);

    public void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats)
    {
        _seatLayoutRepository.UpdateRoomSeatLayout(roomId, rowCount, columnCount, seats);
    }

    public bool SetSeatStatus(string roomId, string seatCode, SeatStatus status, out string message)
    {
        if (!int.TryParse(roomId, out var parsedRoomId) || string.IsNullOrWhiteSpace(seatCode))
        {
            message = "Vui lòng chọn ghế cần cập nhật.";
            return false;
        }

        var databaseStatus = status == SeatStatus.Maintenance ? "Maintenance" : "Active";
        _seatRepository.UpdateSeatStatus(parsedRoomId, seatCode, databaseStatus);
        message = status == SeatStatus.Maintenance ? "Đã đặt ghế bảo trì." : "Đã chuyển ghế về trạng thái sử dụng.";
        return true;
    }
}
