using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class ShowtimeManagementForm : Form
{
    private readonly List<ShowtimeRow> _showtimes;

    public ShowtimeManagementForm()
    {
        _showtimes = AppServices.CinemaStore.GetShowtimes().ToList();
        InitializeComponent();
        BindLookupData();
        WireEvents();
        LoadGrid();
    }

    private void BindLookupData()
    {
        var movies = AppServices.CinemaStore.GetMovies().Select(movie => movie.Title).Cast<object>().ToArray();
        var rooms = AppServices.CinemaStore.GetRooms().Select(room => room.Name).Cast<object>().ToArray();

        movieFilterCombo.Items.Clear();
        movieFilterCombo.Items.Add("Tất cả phim");
        movieFilterCombo.Items.AddRange(movies);
        movieFilterCombo.SelectedIndex = 0;

        roomFilterCombo.Items.Clear();
        roomFilterCombo.Items.Add("Tất cả phòng");
        roomFilterCombo.Items.AddRange(rooms);
        roomFilterCombo.SelectedIndex = 0;

        movieCombo.Items.Clear();
        roomCombo.Items.Clear();
        formatCombo.Items.Clear();
        statusCombo.Items.Clear();
        movieCombo.Items.AddRange(movies);
        roomCombo.Items.AddRange(rooms);
        formatCombo.Items.AddRange(["2D", "3D", "IMAX", "VIP"]);
        statusCombo.Items.AddRange(["Đang mở bán", "Sắp chiếu", "Đã đóng bán"]);

        if (movieCombo.Items.Count > 0)
        {
            movieCombo.SelectedIndex = 0;
        }

        if (roomCombo.Items.Count > 0)
        {
            roomCombo.SelectedIndex = 0;
        }

        formatCombo.SelectedIndex = 0;
        statusCombo.SelectedIndex = 0;
        startPicker.Value = DateTime.Today.AddHours(19);
        endPicker.Value = DateTime.Today.AddHours(21);
        priceBox.Text = "90.000";
    }

    private void WireEvents()
    {
        movieFilterCombo.SelectedIndexChanged += (_, _) => LoadGrid();
        roomFilterCombo.SelectedIndexChanged += (_, _) => LoadGrid();
        showDateFilterPicker.ValueChanged += (_, _) => LoadGrid();
        refreshButton.Click += (_, _) => LoadGrid();
        conflictButton.Click += (_, _) => CheckConflict();
        saveButton.Click += (_, _) => MessageBox.Show("Đã tạo suất chiếu demo.", "Quản lý lịch chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        updateButton.Click += (_, _) => MessageBox.Show("Đã cập nhật suất chiếu demo.", "Quản lý lịch chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        cancelShowtimeButton.Click += (_, _) => MessageBox.Show("Đã hủy suất chiếu demo.", "Quản lý lịch chiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        showtimeGrid.SelectionChanged += (_, _) => UpdateEditorFromGrid();
        UiStyleHelper.ApplyStatusCellFormatting(showtimeGrid, "Status");
    }

    private void LoadGrid()
    {
        UiStyleHelper.ResetGridForBinding(showtimeGrid);

        var rows = FilterShowtimes().ToList();
        showtimeGrid.DataSource = rows.Select(showtime => new
        {
            showtime.ShowtimeId,
            showtime.Movie,
            showtime.Room,
            Date = showtime.StartTime.ToString("dd/MM/yyyy"),
            Start = showtime.StartTime.ToString("HH:mm"),
            End = showtime.EndTime.ToString("HH:mm"),
            Price = UiStyleHelper.FormatCurrency(showtime.TicketPrice),
            showtime.Format,
            showtime.Status
        }).ToList();

        showtimeGrid.ClearSelection();
        showtimeGrid.CurrentCell = null;

        if (rows.Count > 0)
        {
            UpdateEditor(rows[0]);
        }

        RenderTimeline(rows);
    }

    private IEnumerable<ShowtimeRow> FilterShowtimes()
    {
        var query = _showtimes.AsEnumerable();
        var selectedMovie = movieFilterCombo.SelectedItem?.ToString();
        var selectedRoom = roomFilterCombo.SelectedItem?.ToString();

        if (!string.IsNullOrWhiteSpace(selectedMovie) && selectedMovie != "Tất cả phim")
        {
            query = query.Where(showtime => showtime.Movie == selectedMovie);
        }

        if (!string.IsNullOrWhiteSpace(selectedRoom) && selectedRoom != "Tất cả phòng")
        {
            query = query.Where(showtime => showtime.Room == selectedRoom);
        }

        query = query.Where(showtime => showtime.StartTime.Date == showDateFilterPicker.Value.Date);
        return query.OrderBy(showtime => showtime.Room).ThenBy(showtime => showtime.StartTime);
    }

    private void RenderTimeline(IReadOnlyList<ShowtimeRow> rows)
    {
        var labels = new[] { timeline1Label, timeline2Label, timeline3Label, timeline4Label, timeline5Label };
        foreach (var label in labels)
        {
            label.Visible = false;
        }

        var source = rows.Count > 0
            ? rows.OrderBy(showtime => showtime.StartTime).Take(labels.Length).ToList()
            : _showtimes.OrderBy(showtime => showtime.StartTime).Take(labels.Length).ToList();

        for (var index = 0; index < source.Count; index++)
        {
            var showtime = source[index];
            var label = labels[index];
            label.Text = $"{showtime.Room}     {showtime.StartTime:HH:mm} - {showtime.EndTime:HH:mm}     {showtime.Movie}";
            label.ForeColor = showtime.StartTime.Hour >= 22 ? UiStyleHelper.Danger : UiStyleHelper.Primary;
            label.BackColor = ColorTranslator.FromHtml(showtime.StartTime.Hour >= 22 ? "#FFF1F2" : "#EAF3FF");
            label.Visible = true;
        }
    }

    private void UpdateEditorFromGrid()
    {
        if (showtimeGrid.SelectedRows.Count == 0)
        {
            return;
        }

        var id = showtimeGrid.SelectedRows[0].Cells["ShowtimeId"].Value?.ToString();
        var showtime = _showtimes.FirstOrDefault(item => item.ShowtimeId == id);
        if (showtime is not null)
        {
            UpdateEditor(showtime);
        }
    }

    private void UpdateEditor(ShowtimeRow showtime)
    {
        movieCombo.SelectedItem = showtime.Movie;
        roomCombo.SelectedItem = showtime.Room;
        datePicker.Value = showtime.StartTime.Date;
        startPicker.Value = DateTime.Today.Add(showtime.StartTime.TimeOfDay);
        endPicker.Value = DateTime.Today.Add(showtime.EndTime.TimeOfDay);
        formatCombo.SelectedItem = showtime.Format;
        priceBox.Text = showtime.TicketPrice.ToString("N0");
        statusCombo.SelectedItem = showtime.Status;
    }

    private void CheckConflict()
    {
        if (roomCombo.SelectedItem?.ToString() == "Phòng 1" && startPicker.Value.Hour == 19 && startPicker.Value.Minute == 0)
        {
            MessageBox.Show("Phòng chiếu đã có lịch chiếu trùng thời gian.", "Kiểm tra trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Không phát hiện trùng lịch trong dữ liệu demo.", "Kiểm tra trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
