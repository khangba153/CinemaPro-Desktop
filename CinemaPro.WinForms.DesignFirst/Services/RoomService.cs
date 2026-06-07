using CinemaPro.WinForms.DesignFirst.Models;
using CinemaPro.WinForms.DesignFirst.Repositories;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class RoomService
{
    private readonly RoomRepository _roomRepository = new();


    public List<RoomRow> GetRooms()
    {
        return _roomRepository.GetRooms();
    }


    public bool AddRoom(
        string roomName,
        string roomType,
        out string message)
    {
        if (!ValidateInput(roomName, roomType, out message))
            return false;

        roomName = roomName.Trim();

        try
        {
            if (_roomRepository.ExistsByName(roomName))
            {
                message = "Tên phòng đã tồn tại.";
                return false;
            }

            _roomRepository.Insert(roomName, roomType, 1, 1, "Active");

            message = "Đã thêm phòng chiếu thành công.";
            return true;
        }
        catch
        {
            message = "Lỗi hệ thống khi thêm phòng.";
            return false;
        }
    }

    public bool EditRoom(
        string roomId,
        string roomName,
        string roomType,
        string status,
        out string message)
    {
        if (string.IsNullOrWhiteSpace(roomId))
        {
            message = "Vui lòng chọn phòng cần sửa.";
            return false;
        }

        if (!ValidateInput(roomName, roomType, out message))
            return false;

        roomName = roomName.Trim();

        try
        {
            var room = _roomRepository.GetById(roomId);
            if (room == null)
            {
                message = "Không tìm thấy phòng.";
                return false;
            }

            if (_roomRepository.ExistsByNameExceptId(roomName, roomId))
            {
                message = "Tên phòng đã tồn tại.";
                return false;
            }

            _roomRepository.Update(roomId, roomName, roomType, status);

            message = "Đã cập nhật phòng chiếu.";
            return true;
        }
        catch
        {
            message = "Lỗi hệ thống khi cập nhật phòng.";
            return false;
        }
    }

    public bool SetMaintenance(string roomId, out string message)
    {
        if (!ValidateRoomId(roomId, out message))
            return false;

        try
        {
            var room = _roomRepository.GetById(roomId);
            if (room == null)
            {
                message = "Không tìm thấy phòng.";
                return false;
            }

            if (room.Status == "Maintenance")
            {
                message = "Phòng đã ở trạng thái bảo trì.";
                return false;
            }

            _roomRepository.SetMaintenance(roomId);

            message = "Đã chuyển phòng sang trạng thái bảo trì.";
            return true;
        }
        catch
        {
            message = "Lỗi hệ thống khi cập nhật trạng thái.";
            return false;
        }
    }

    public bool SetActive(string roomId, out string message)
    {
        if (!ValidateRoomId(roomId, out message))
            return false;

        try
        {
            var room = _roomRepository.GetById(roomId);
            if (room == null)
            {
                message = "Không tìm thấy phòng.";
                return false;
            }

            if (room.Status == "Active")
            {
                message = "Phòng đã ở trạng thái hoạt động.";
                return false;
            }

            _roomRepository.SetActive(roomId);

            message = "Đã chuyển phòng sang trạng thái hoạt động.";
            return true;
        }
        catch
        {
            message = "Lỗi hệ thống khi cập nhật trạng thái.";
            return false;
        }
    }

    private static bool ValidateInput(
        string roomName,
        string roomType,
        out string message)
    {
        if (string.IsNullOrWhiteSpace(roomName))
        {
            message = "Tên phòng không được để trống.";
            return false;
        }

        roomName = roomName.Trim();

        if (roomType is not ("2D" or "3D" or "IMAX" or "VIP"))
        {
            message = "Loại phòng không hợp lệ.";
            return false;
        }
        message = "";
        return true;
    }

    private static bool ValidateRoomId(string roomId, out string message)
    {
        if (string.IsNullOrWhiteSpace(roomId))
        {
            message = "Vui lòng chọn phòng.";
            return false;
        }

        message = "";
        return true;
    }
}
