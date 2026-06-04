using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class RoomService
{
    private readonly RoomRepository _roomRepository = new();


    public List<RoomRow> GetRooms()
    {
        return _roomRepository.GetRooms();
    }

    public bool AddRoom(string roomName, string roomType, int rowCount, int seatsPerRow, out string message)
    {
        _roomRepository.Insert(roomName.Trim(), roomType, rowCount, seatsPerRow, "Active");
        message = "Đã thêm phòng chiếu.";
        return true;
    }

    public bool EditRoom(string roomId, string roomName, string roomType, int rowCount, int seatsPerRow, string status, out string message)
    {
        _roomRepository.Update(roomId, roomName.Trim(), roomType, rowCount, seatsPerRow, status);
        message = "Đã cập nhật phòng chiếu.";
        return true;
    }
}