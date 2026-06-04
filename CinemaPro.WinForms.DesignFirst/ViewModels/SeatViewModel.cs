namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public enum SeatStatus
{
    Available,
    Selected,
    Sold,
    Maintenance
}

public sealed class SeatInfo
{
    public string RoomId { get; set; } = "";
    public string SeatCode { get; set; } = "";
    public int RowIndex { get; set; }
    public int ColumnIndex { get; set; }
    public SeatStatus Status { get; set; }
}
