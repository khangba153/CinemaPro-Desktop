using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaPro.WinForms.DesignFirst.ViewModels;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.Data;
using System.Data;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff
{
    public partial class TodayShowtimeForm : Form
    {
        private readonly ShowtimeService _showtimeService = new ShowtimeService();

        public TodayShowtimeForm()
        {
            InitializeComponent();
        }

        private void TodayShowtimeForm_Load(object? sender, EventArgs e)
        {
            LoadTodayData();
        }

        private void LoadTodayData()
        {
            try
            {
                List<TodayShowtimeViewModel> todayList = _showtimeService.GetTodayShowtimes();

                if (showtimeGrid != null)
                {
                    showtimeGrid.Columns.Clear();
                    showtimeGrid.AutoGenerateColumns = true;

                    showtimeGrid.DataSource = null;
                    showtimeGrid.DataSource = todayList;

                    if (showtimeGrid.Columns.Contains("ShowtimeId")) showtimeGrid.Columns["ShowtimeId"].Visible = false;
                    if (showtimeGrid.Columns.Contains("Date")) showtimeGrid.Columns["Date"].Visible = false;
                    if (showtimeGrid.Columns.Contains("StartTime")) showtimeGrid.Columns["StartTime"].Visible = false;
                    if (showtimeGrid.Columns.Contains("EndTime")) showtimeGrid.Columns["EndTime"].Visible = false;

                    if (showtimeGrid.Columns.Contains("MovieTitle")) showtimeGrid.Columns["MovieTitle"].HeaderText = "Tên phim";
                    if (showtimeGrid.Columns.Contains("RoomName")) showtimeGrid.Columns["RoomName"].HeaderText = "Phòng";
                    if (showtimeGrid.Columns.Contains("StartTime")) showtimeGrid.Columns["StartTime"].HeaderText = "Giờ bắt đầu";
                    if (showtimeGrid.Columns.Contains("EndTime")) showtimeGrid.Columns["EndTime"].HeaderText = "Giờ kết thúc";
                    if (showtimeGrid.Columns.Contains("Price")) showtimeGrid.Columns["Price"].HeaderText = "Giá vé";
                    if (showtimeGrid.Columns.Contains("Status")) showtimeGrid.Columns["Status"].HeaderText = "Trạng thái";

                    if (showtimeGrid.Columns.Contains("ShowtimeCode")) showtimeGrid.Columns["ShowtimeCode"].Visible = false;
                    if (showtimeGrid.Columns.Contains("MovieCode")) showtimeGrid.Columns["MovieCode"].Visible = false;
                    if (showtimeGrid.Columns.Contains("RoomCode")) showtimeGrid.Columns["RoomCode"].Visible = false;
                    if (showtimeGrid.Columns.Contains("TimeText")) showtimeGrid.Columns["TimeText"].Visible = false;
                    if (showtimeGrid.Columns.Contains("Format")) showtimeGrid.Columns["Format"].Visible = false;
                    if (showtimeGrid.Columns.Contains("SoldSeatCount")) showtimeGrid.Columns["SoldSeatCount"].Visible = false;
                }

                int totalShowtimes = todayList.Count;
                if (showtimeCountValueLabel != null)
                {
                    showtimeCountValueLabel.Text = totalShowtimes.ToString();
                }

                int activeSellingCount = todayList.FindAll(s => s.Status.Equals("Open", StringComparison.OrdinalIgnoreCase) || s.Status == "Đang bán").Count;
                if (sellingValueLabel != null)
                {
                    sellingValueLabel.Text = activeSellingCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu lịch chiếu hôm nay: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showtimeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && showtimeGrid != null)
            {
                DataGridViewRow row = showtimeGrid.Rows[e.RowIndex];

                string showtimeId = row.Cells["ShowtimeId"].Value.ToString();
                string movieTitle = row.Cells["MovieTitle"].Value.ToString();
                string roomName = row.Cells["RoomName"].Value.ToString();

                MessageBox.Show($"[Nghiệp vụ Staff] Hệ thống chuẩn bị chuyển tiếp sang màn hình sơ đồ ghế cho phim:\n🎬 {movieTitle} - {roomName}",
                                "Thông báo điều phối", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}