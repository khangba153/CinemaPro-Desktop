namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class SeatService
{
    private readonly SeatRepository _seatRepository = new();

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
