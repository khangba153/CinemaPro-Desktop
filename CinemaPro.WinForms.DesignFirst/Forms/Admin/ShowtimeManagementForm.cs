using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class ShowtimeManagementForm : Form
{
    public ShowtimeManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(showtimeGrid);
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        SetColumnWidth("colId", 70);
        SetColumnWidth("colMovie", 170);
        SetColumnWidth("colRoom", 88);
        SetColumnWidth("colDate", 96);
        SetColumnWidth("colTime", 120);
        SetColumnWidth("colPrice", 90);
        SetColumnWidth("colStatus", 90);
    }

    private void ShowtimeManagementForm_Load(object? sender, EventArgs e)
    {
        movieComboBox.DisplayMember = nameof(MovieRow.Title);
        movieComboBox.ValueMember = nameof(MovieRow.MovieId);
        movieComboBox.DataSource = AppServices.CinemaStore.GetMovies().ToList();
        roomComboBox.DisplayMember = nameof(RoomRow.RoomName);
        roomComboBox.ValueMember = nameof(RoomRow.RoomId);
        roomComboBox.DataSource = AppServices.CinemaStore.GetRooms().ToList();
        formatComboBox.SelectedIndex = 0;
        statusComboBox.SelectedIndex = 0;
        LoadShowtimes();
    }

    private void LoadShowtimes()
    {
        showtimeGrid.Rows.Clear();
        foreach (var showtime in AppServices.CinemaStore.GetShowtimes())
        {
            showtimeGrid.Rows.Add(showtime.ShowtimeId, showtime.MovieTitle, showtime.RoomName, showtime.DateText, showtime.TimeText, FormatHelper.Vnd(showtime.Price), showtime.Status);
        }
    }

    private void CheckConflictButton_Click(object? sender, EventArgs e)
    {
        if (roomComboBox.Text == "Phòng 1" && startTimePicker.Value.Hour == 19 && startTimePicker.Value.Minute == 0)
        {
            MessageBox.Show("Phòng chiếu đã có lịch chiếu trùng thời gian.", "Kiểm tra lịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Không phát hiện trùng lịch trong dữ liệu demo.", "Kiểm tra lịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Thao tác lịch chiếu chỉ mô phỏng trên UI demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void SetColumnWidth(string columnName, int width)
    {
        if (showtimeGrid.Columns[columnName] is DataGridViewColumn column)
        {
            column.Width = width;
        }
    }
}
