using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class RoomService
{
    private readonly RoomRepository _roomRepository = new();


    public List<Room> GetRooms()
    {
        return _roomRepository.GetRooms();
    }

    //public void AddRoom(Room room)
    //{
    //    _roomRepository.AddRoom(room);
    //}
}