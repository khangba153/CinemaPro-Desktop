namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class RoomService
{
    private readonly RoomRepository _roomRepository = new();

    public IReadOnlyList<RoomRow> GetRooms() => _roomRepository.GetRooms();

    public bool AddRoom(string roomName, string roomType, int rowCount, int seatsPerRow, out string message)
    {
        if (!Validate(roomName, roomType, rowCount, seatsPerRow, out message))
        {
            return false;
        }

        _roomRepository.Insert(roomName.Trim(), roomType, rowCount, seatsPerRow, "Active");
        message = "Đã thêm phòng chiếu.";
        return true;
    }

    public bool UpdateRoom(string roomId, string roomName, string roomType, int rowCount, int seatsPerRow, string status, out string message)
    {
        if (!int.TryParse(roomId, out var id))
        {
            message = "Vui lòng chọn phòng cần sửa.";
            return false;
        }

        if (!Validate(roomName, roomType, rowCount, seatsPerRow, out message))
        {
            return false;
        }

        if (status is not ("Active" or "Maintenance" or "Inactive"))
        {
            message = "Trạng thái phòng không hợp lệ.";
            return false;
        }

        _roomRepository.Update(id, roomName.Trim(), roomType, rowCount, seatsPerRow, status);
        message = "Đã cập nhật phòng chiếu.";
        return true;
    }

    public bool SetMaintenance(string roomId, out string message)
    {
        return SetRoomStatus(roomId, "Maintenance", out message);
    }

    public bool SetRoomStatus(string roomId, string status, out string message)
    {
        if (!int.TryParse(roomId, out var id))
        {
            message = "Vui lòng chọn phòng cần đổi trạng thái.";
            return false;
        }

        if (status is not ("Active" or "Maintenance" or "Inactive"))
        {
            message = "Trạng thái phòng không hợp lệ.";
            return false;
        }

        _roomRepository.UpdateStatus(id, status);
        message = status switch
        {
            "Active" => "Đã đưa phòng vào hoạt động.",
            "Maintenance" => "Đã chuyển phòng sang trạng thái bảo trì.",
            _ => "Đã ngừng sử dụng phòng."
        };
        return true;
    }

    private static bool Validate(string roomName, string roomType, int rowCount, int seatsPerRow, out string message)
    {
        if (string.IsNullOrWhiteSpace(roomName))
        {
            message = "Vui lòng nhập tên phòng.";
            return false;
        }

        if (roomType is not ("2D" or "3D" or "IMAX" or "VIP"))
        {
            message = "Loại phòng không hợp lệ.";
            return false;
        }

        if (rowCount <= 0 || seatsPerRow <= 0)
        {
            message = "Số hàng và số ghế mỗi hàng phải lớn hơn 0.";
            return false;
        }

        message = "";
        return true;
    }
}
