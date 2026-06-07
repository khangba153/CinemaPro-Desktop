using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaPro.WinForms.DesignFirst.Models;
using CinemaPro.WinForms.DesignFirst.ViewModels;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.Data;
using System.Data;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin
{
    public partial class ShowtimeManagementForm : Form
    {
        private readonly ShowtimeService _showtimeService = new ShowtimeService();
        private int _selectedShowtimeId = 0; 

        public ShowtimeManagementForm()
        {
            InitializeComponent();
        }

        private void ShowtimeManagementForm_Load(object? sender, EventArgs e)
        {
            LoadShowtimeGrid();
            LoadComboBoxData();
        }

        private void LoadShowtimeGrid()
        {
            try
            {
                List<ShowtimeRow> list = _showtimeService.GetAllShowtimes();

                if (showtimeGrid != null)
                {
                    showtimeGrid.Columns.Clear();
                    showtimeGrid.AutoGenerateColumns = true;

                    showtimeGrid.DataSource = null;
                    showtimeGrid.DataSource = list;

                    if (showtimeGrid.Columns.Contains("ShowtimeId")) showtimeGrid.Columns["ShowtimeId"].Visible = false;
                    if (showtimeGrid.Columns.Contains("MovieId")) showtimeGrid.Columns["MovieId"].Visible = false;
                    if (showtimeGrid.Columns.Contains("RoomId")) showtimeGrid.Columns["RoomId"].Visible = false;
                    if (showtimeGrid.Columns.Contains("Date")) showtimeGrid.Columns["Date"].Visible = false;
                    if (showtimeGrid.Columns.Contains("StartTime")) showtimeGrid.Columns["StartTime"].Visible = false;
                    if (showtimeGrid.Columns.Contains("EndTime")) showtimeGrid.Columns["EndTime"].Visible = false;

                    if (showtimeGrid.Columns.Contains("ShowtimeCode")) showtimeGrid.Columns["ShowtimeCode"].HeaderText = "Mã";
                    if (showtimeGrid.Columns.Contains("MovieTitle")) showtimeGrid.Columns["MovieTitle"].HeaderText = "Phim";
                    if (showtimeGrid.Columns.Contains("RoomName")) showtimeGrid.Columns["RoomName"].HeaderText = "Phòng";
                    if (showtimeGrid.Columns.Contains("DateText")) showtimeGrid.Columns["DateText"].HeaderText = "Ngày";
                    if (showtimeGrid.Columns.Contains("TimeText")) showtimeGrid.Columns["TimeText"].HeaderText = "Giờ";
                    if (showtimeGrid.Columns.Contains("Price")) showtimeGrid.Columns["Price"].HeaderText = "Giá vé";
                    if (showtimeGrid.Columns.Contains("Format")) showtimeGrid.Columns["Format"].HeaderText = "Định dạng";
                    if (showtimeGrid.Columns.Contains("Status")) showtimeGrid.Columns["Status"].HeaderText = "Trạng thái";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lịch chiếu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckConflictButton_Click(object? sender, EventArgs e)
        {
            try
            {
                int roomId = Convert.ToInt32(roomComboBox.SelectedValue);
                DateTime startAt = CombineDateAndTime(showDatePicker, startTimePicker);
                DateTime endAt = CombineDateAndTime(showDatePicker, endTimePicker);

                if (startAt >= endAt)
                {
                    MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu!", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var repository = new CinemaPro.WinForms.DesignFirst.Repositories.ShowtimeRepository();
                int? excludeId = _selectedShowtimeId > 0 ? (int?)_selectedShowtimeId : null;

                bool isConflict = repository.IsRoomConflicting(roomId, startAt, endAt, excludeId);

                if (isConflict)
                {
                    MessageBox.Show("⚠️ LỖI: Phòng chiếu này đã có lịch chiếu trùng vào thời gian được chọn!", "Kết quả kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("✅ Tuyệt vời: Khung giờ và phòng chiếu này hiện đang trống, có thể xếp lịch!", "Kết quả kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại cấu hình chọn Phòng/Thời gian: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActionButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(priceTextBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá vé cho suất chiếu!", "Dữ liệu thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    priceTextBox.Focus();
                    return;
                }

                if (!decimal.TryParse(priceTextBox.Text.Trim(), out decimal validPrice))
                {
                    MessageBox.Show("Giá vé phải là một số hợp lệ (không chứa ký tự chữ hoặc ký hiệu tiền tệ)!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    priceTextBox.Focus();
                    return;
                }

                DateTime startAt = CombineDateAndTime(showDatePicker, startTimePicker);
                DateTime endAt = CombineDateAndTime(showDatePicker, endTimePicker);

                string cleanRoomName = roomComboBox.Text.Replace(" ", "");
                string autoGeneratedCode = $"{cleanRoomName}-{startAt:ddMM}-{startAt:HHmm}";

                var showtime = new Showtime
                {
                    ShowtimeId = _selectedShowtimeId,
                    ShowtimeCode = autoGeneratedCode,
                    MovieId = Convert.ToInt32(movieComboBox.SelectedValue),
                    RoomId = Convert.ToInt32(roomComboBox.SelectedValue),
                    StartAt = startAt,
                    EndAt = endAt,
                    BasePrice = validPrice,
                    ShowtimeFormat = formatComboBox.SelectedItem?.ToString() ?? "2D",
                    ShowtimeStatus = statusComboBox.SelectedItem?.ToString() ?? "Open"
                };

                if (_selectedShowtimeId == 0)
                {
                    _showtimeService.CreateShowtime(showtime);
                    MessageBox.Show($"Tạo suất chiếu thành công với mã tự sinh [{autoGeneratedCode}]!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _showtimeService.UpdateShowtime(showtime);
                    MessageBox.Show("Cập nhật thông tin suất chiếu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetFormInput();
                LoadShowtimeGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "⚠️ Trùng lịch chiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_selectedShowtimeId == 0)
                {
                    MessageBox.Show("Vui lòng click chọn một suất chiếu trên bảng danh sách trước khi bấm Hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn HỦY suất chiếu này không? Trạng thái sẽ chuyển sang 'Cancelled' và hệ thống bán vé sẽ đóng suất này lại.",
                                                   "Xác nhận hủy lịch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    _showtimeService.CancelOrCloseShowtime(_selectedShowtimeId, "Cancelled");

                    MessageBox.Show("Hủy suất chiếu thành công! Dữ liệu đã được cập nhật.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetFormInput();
                    LoadShowtimeGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi hủy suất chiếu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showtimeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showtimeGrid.Rows[e.RowIndex];

                _selectedShowtimeId = Convert.ToInt32(row.Cells["ShowtimeId"].Value);
                movieComboBox.Text = row.Cells["MovieTitle"].Value.ToString();
                roomComboBox.Text = row.Cells["RoomName"].Value.ToString();

                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                TimeSpan startTime = (TimeSpan)row.Cells["StartTime"].Value;
                TimeSpan endTime = (TimeSpan)row.Cells["EndTime"].Value;

                showDatePicker.Value = date;
                startTimePicker.Value = date.Add(startTime);
                endTimePicker.Value = date.Add(endTime);

                priceTextBox.Text = Convert.ToDecimal(row.Cells["Price"].Value).ToString("0");
                formatComboBox.SelectedItem = row.Cells["Format"].Value.ToString();
                statusComboBox.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                DataTable dtMovies = DatabaseHelper.ExecuteQuery("SELECT MovieId, MovieTitle FROM dbo.Movies WHERE MovieStatus <> 'Stopped'");
                movieComboBox.DataSource = dtMovies;
                movieComboBox.ValueMember = "MovieId";
                movieComboBox.DisplayMember = "MovieTitle";

                DataTable dtRooms = DatabaseHelper.ExecuteQuery("SELECT RoomId, RoomName FROM dbo.Rooms WHERE RoomStatus = 'Active'");
                roomComboBox.DataSource = dtRooms;
                roomComboBox.ValueMember = "RoomId";
                roomComboBox.DisplayMember = "RoomName";

                formatComboBox.Items.Clear();
                formatComboBox.Items.AddRange(new string[] { "2D", "3D", "IMAX", "VIP" });
                if (formatComboBox.Items.Count > 0) formatComboBox.SelectedIndex = 0;

                statusComboBox.Items.Clear();
                statusComboBox.Items.AddRange(new string[] { "Open", "Closed", "Cancelled", "Finished" });
                if (statusComboBox.Items.Count > 0) statusComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục Phim/Phòng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DateTime CombineDateAndTime(DateTimePicker datePicker, DateTimePicker timePicker)
        {
            return datePicker.Value.Date.Add(timePicker.Value.TimeOfDay);
        }

        private void ResetFormInput()
        {
            _selectedShowtimeId = 0;
            priceTextBox.Clear();
            if (movieComboBox.Items.Count > 0) movieComboBox.SelectedIndex = 0;
            if (roomComboBox.Items.Count > 0) roomComboBox.SelectedIndex = 0;
            showDatePicker.Value = DateTime.Today;
            startTimePicker.Value = DateTime.Now;
            endTimePicker.Value = DateTime.Now.AddHours(2);
            if (formatComboBox.Items.Count > 0) formatComboBox.SelectedIndex = 0;
            if (statusComboBox.Items.Count > 0) statusComboBox.SelectedIndex = 0;
        }
    }
}