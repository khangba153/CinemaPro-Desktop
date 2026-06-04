namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class RoomRow
{
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string RoomType { get; set; } = "";
    public int Rows { get; set; }
    public int SeatsPerRow { get; set; }
    public string Status { get; set; } = "";
}
