namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class ShowtimeManagementForm : Form
{
    private readonly ShowtimeService _showtimeService = new();
    private string _selectedShowtimeId = "";

    public ShowtimeManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(showtimeGrid);
        showtimeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        showtimeGrid.MultiSelect = false;
        showtimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        showtimeGrid.SelectionChanged += (_, _) => FillInputFromSelectedRow();
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

        formatComboBox.Items.Clear();
        formatComboBox.Items.AddRange(new object[] { "2D", "3D", "IMAX", "VIP" });
        formatComboBox.SelectedIndex = 0;

        statusComboBox.Items.Clear();
        statusComboBox.Items.AddRange(new object[] { "Open", "Closed", "Cancelled", "Finished" });
        statusComboBox.SelectedIndex = 0;

        LoadShowtimes();
    }

    private void LoadShowtimes()
    {
        showtimeGrid.Rows.Clear();
        foreach (var showtime in AppServices.CinemaStore.GetShowtimes())
        {
            var rowIndex = showtimeGrid.Rows.Add(
                showtime.ShowtimeId,
                showtime.MovieTitle,
                showtime.RoomName,
                showtime.DateText,
                showtime.TimeText,
                FormatHelper.Vnd(showtime.Price),
                showtime.Status);

            showtimeGrid.Rows[rowIndex].Tag = showtime;
        }

        if (showtimeGrid.Rows.Count > 0)
        {
            showtimeGrid.ClearSelection();
            showtimeGrid.Rows[0].Selected = true;
            FillInputFromSelectedRow();
        }
    }

    private void CheckConflictButton_Click(object? sender, EventArgs e)
    {
        var conflict = _showtimeService.HasConflict(GetSelectedRoomId(), BuildStartAt(), BuildEndAt(), _selectedShowtimeId, out var message);
        MessageBox.Show(message, "Kiểm tra lịch", MessageBoxButtons.OK, conflict ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        try
        {
            if (sender == createButton)
            {
                ShowResult(_showtimeService.CreateShowtime(GetSelectedMovieId(), GetSelectedRoomId(), BuildStartAt(), BuildEndAt(), priceTextBox.Text, formatComboBox.Text, statusComboBox.Text, out var message), message);
                return;
            }

            if (sender == editButton)
            {
                ShowResult(_showtimeService.UpdateShowtime(_selectedShowtimeId, GetSelectedMovieId(), GetSelectedRoomId(), BuildStartAt(), BuildEndAt(), priceTextBox.Text, formatComboBox.Text, statusComboBox.Text, out var message), message);
                return;
            }

            if (sender == cancelButton)
            {
                ShowResult(_showtimeService.CancelShowtime(_selectedShowtimeId, out var message), message);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể xử lý suất chiếu.\n\n" + ex.Message, "Lỗi database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FillInputFromSelectedRow()
    {
        if (showtimeGrid.SelectedRows.Count == 0 || showtimeGrid.SelectedRows[0].Tag is not ShowtimeRow showtime)
        {
            return;
        }

        _selectedShowtimeId = showtime.ShowtimeId;
        movieComboBox.SelectedValue = showtime.MovieId;
        roomComboBox.SelectedValue = showtime.RoomId;
        showDatePicker.Value = showtime.Date;
        startTimePicker.Value = DateTime.Today.Add(showtime.StartTime);
        endTimePicker.Value = DateTime.Today.Add(showtime.EndTime);
        priceTextBox.Text = showtime.Price.ToString("0");
        formatComboBox.Text = showtime.Format;
        statusComboBox.Text = showtime.Status;
    }

    private string GetSelectedMovieId()
    {
        return movieComboBox.SelectedValue?.ToString() ?? "";
    }

    private string GetSelectedRoomId()
    {
        return roomComboBox.SelectedValue?.ToString() ?? "";
    }

    private DateTime BuildStartAt()
    {
        return showDatePicker.Value.Date + startTimePicker.Value.TimeOfDay;
    }

    private DateTime BuildEndAt()
    {
        return showDatePicker.Value.Date + endTimePicker.Value.TimeOfDay;
    }

    private void ShowResult(bool success, string message)
    {
        MessageBox.Show(message, success ? "Thành công" : "Không thể xử lý", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (success)
        {
            LoadShowtimes();
        }
    }

    private void SetColumnWidth(string columnName, int width)
    {
        if (showtimeGrid.Columns[columnName] is DataGridViewColumn column)
        {
            column.Width = width;
        }
    }
}
