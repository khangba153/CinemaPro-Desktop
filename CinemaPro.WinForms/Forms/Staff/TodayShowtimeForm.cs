using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class TodayShowtimeForm : Form
{
    private readonly List<ShowtimeRow> _showtimes;

    public TodayShowtimeForm()
    {
        _showtimes = AppServices.CinemaStore.GetShowtimes()
            .Where(showtime => showtime.StartTime.Date == DateTime.Today)
            .OrderBy(showtime => showtime.StartTime)
            .ToList();

        InitializeComponent();
        ApplyRuntimeStyles();
        WireEvents();
        LoadData();
    }

    private void ApplyRuntimeStyles()
    {
        UiStyleHelper.ApplyStatusCellFormatting(_grid, "Status");
        StyleButton(sellButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(viewSeatButton, UiStyleHelper.Primary);
        StyleOutlineButton(printButton, UiStyleHelper.Primary);
    }

    private void WireEvents()
    {
        _grid.SelectionChanged += (_, _) => UpdateDetailFromGrid();
        sellButton.Click += (_, _) => MessageBox.Show("Demo UI: mở màn bán vé từ menu Bán vé để chọn ghế.", "Lịch chiếu hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        viewSeatButton.Click += (_, _) => MessageBox.Show("Demo UI: sơ đồ ghế đang nằm trong màn Bán vé.", "Lịch chiếu hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        printButton.Click += (_, _) => MessageBox.Show("Demo UI: danh sách suất chiếu sẽ được in ở giai đoạn sau.", "Lịch chiếu hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadData()
    {
        totalShowtimeValueLabel.Text = $"{_showtimes.Count} suất";
        soldTicketValueLabel.Text = "1.072 vé";
        activeRoomValueLabel.Text = "4 / 5";
        waitingShowtimeValueLabel.Text = $"{_showtimes.Count(s => s.Status == "Sắp chiếu")} suất";

        _grid.DataSource = _showtimes.Select((showtime, index) => new
        {
            showtime.Movie,
            showtime.Room,
            Start = showtime.StartTime.ToString("HH:mm"),
            showtime.Format,
            Price = UiStyleHelper.FormatCurrency(showtime.TicketPrice),
            Sold = 86 - index * 8,
            TotalSeats = 86,
            Occupancy = $"{Math.Max(12, 100 - index * 11)}%",
            showtime.Status
        }).ToList();

        RenderTimeline();
        if (_grid.Rows.Count > 0)
        {
            _grid.Rows[0].Selected = true;
            UpdateDetail(_showtimes[0]);
        }
    }

    private void RenderTimeline()
    {
        _timelinePanel.Controls.Clear();
        foreach (var roomGroup in _showtimes.GroupBy(showtime => showtime.Room).Take(4))
        {
            var row = new FlowLayoutPanel
            {
                Width = 1040,
                Height = 36,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = Color.White,
                Margin = new Padding(0, 2, 0, 4)
            };
            row.Controls.Add(new Label
            {
                Width = 110,
                Height = 34,
                Text = roomGroup.Key,
                Font = UiStyleHelper.SectionFont(9.5f),
                ForeColor = UiStyleHelper.TextDark,
                TextAlign = ContentAlignment.MiddleLeft
            });

            foreach (var showtime in roomGroup)
            {
                var color = showtime.Status == "Đang mở bán" ? UiStyleHelper.Success : UiStyleHelper.Primary;
                row.Controls.Add(new Label
                {
                    Width = 180,
                    Height = 34,
                    Text = $"{showtime.StartTime:HH:mm}\n{showtime.Movie}",
                    Font = UiStyleHelper.SmallFont(8.5f),
                    ForeColor = color,
                    BackColor = Color.FromArgb(22, color),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(0, 0, 12, 0)
                });
            }

            _timelinePanel.Controls.Add(row);
        }
    }

    private void UpdateDetailFromGrid()
    {
        if (_grid.SelectedRows.Count == 0)
        {
            return;
        }

        var movie = _grid.SelectedRows[0].Cells["Movie"].Value?.ToString();
        var start = _grid.SelectedRows[0].Cells["Start"].Value?.ToString();
        var showtime = _showtimes.FirstOrDefault(item => item.Movie == movie && item.StartTime.ToString("HH:mm") == start);
        if (showtime is not null)
        {
            UpdateDetail(showtime);
        }
    }

    private void UpdateDetail(ShowtimeRow showtime)
    {
        _detailLabel.Text =
            $"{showtime.Movie}\n\n" +
            $"Phòng chiếu: {showtime.Room}\n" +
            $"Giờ chiếu: {showtime.StartTime:HH:mm} - {showtime.EndTime:HH:mm}\n" +
            $"Định dạng: {showtime.Format}\n" +
            $"Giá vé: {UiStyleHelper.FormatCurrency(showtime.TicketPrice)}\n" +
            $"Trạng thái: {showtime.Status}\n\n" +
            "Chọn Mở bán vé để chuyển sang màn bán vé.";
    }

    private static void StyleButton(Button button, Color backColor, Color foreColor)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = backColor;
        button.ForeColor = foreColor;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }

    private static void StyleOutlineButton(Button button, Color accent)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Color.White;
        button.ForeColor = accent;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }
}
