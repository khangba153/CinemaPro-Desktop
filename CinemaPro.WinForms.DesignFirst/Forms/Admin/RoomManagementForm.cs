namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RoomManagementForm : Form
{
    private readonly RoomService _roomService = new();
    public RoomManagementForm()
    {
        InitializeComponent();
    }

    private void RoomManagementForm_Load(object? sender, EventArgs e)
    {
        LoadRooms();
    }

    private void AddRoomButton_Click(object sender, EventArgs e)
    {

    }

    private void LoadRooms()
    {
        roomGrid.Rows.Clear();
        foreach (var room in _roomService.GetRooms())
        {
            var rowIndex = roomGrid.Rows.Add(room.RoomId, room.RoomName, room.RoomType, room.SeatRowCount, room.SeatsPerRow, room.RoomStatus);
            roomGrid.Rows[rowIndex].Tag = room;
        }

        //if (roomGrid.Rows.Count > 0)
        //{
        //    roomGrid.ClearSelection();
        //    roomGrid.Rows[0].Selected = true;
        //    FillDetailFromSelectedRow();
        //}
    }
}
