namespace CinemaPro.WinForms.Helpers;

public static class UiStyleHelper
{
    public static readonly Color Sidebar = ColorTranslator.FromHtml("#EEF6FF");
    public static readonly Color SidebarHover = ColorTranslator.FromHtml("#E3F0FF");
    public static readonly Color SidebarActive = ColorTranslator.FromHtml("#0D6EFD");
    public static readonly Color SidebarText = ColorTranslator.FromHtml("#172554");
    public static readonly Color ContentBackground = ColorTranslator.FromHtml("#F5F8FC");
    public static readonly Color CardBackground = Color.White;
    public static readonly Color CardBorder = ColorTranslator.FromHtml("#DDE6F2");
    public static readonly Color FieldBorder = ColorTranslator.FromHtml("#CFDAEA");
    public static readonly Color HeaderBackground = ColorTranslator.FromHtml("#F0F5FB");
    public static readonly Color TextDark = ColorTranslator.FromHtml("#111B3F");
    public static readonly Color TextMuted = ColorTranslator.FromHtml("#64748B");
    public static readonly Color TextLight = Color.White;
    public static readonly Color Primary = ColorTranslator.FromHtml("#0D6EFD");
    public static readonly Color PrimaryDark = ColorTranslator.FromHtml("#0B5ED7");
    public static readonly Color Accent = ColorTranslator.FromHtml("#7C3AED");
    public static readonly Color Success = ColorTranslator.FromHtml("#16A34A");
    public static readonly Color Warning = ColorTranslator.FromHtml("#F97316");
    public static readonly Color Danger = ColorTranslator.FromHtml("#EF4444");
    public static readonly Color SurfaceMuted = ColorTranslator.FromHtml("#F8FAFC");
    public static readonly Color SeatAvailable = Color.White;
    public static readonly Color SeatSelected = ColorTranslator.FromHtml("#BDEDBE");
    public static readonly Color SeatSold = ColorTranslator.FromHtml("#FFD6D6");
    public static readonly Color SeatMaintenance = ColorTranslator.FromHtml("#E5E7EB");

    public static Font TitleFont(float size = 20) => new("Segoe UI Semibold", size, FontStyle.Bold);

    public static Font SectionFont(float size = 10) => new("Segoe UI Semibold", size, FontStyle.Bold);

    public static Font BodyFont(float size = 10) => new("Segoe UI", size, FontStyle.Regular);

    public static Font SmallFont(float size = 9) => new("Segoe UI", size, FontStyle.Regular);

    public static Font IconFont(float size = 15) => new("Segoe MDL2 Assets", size, FontStyle.Regular);

    public static void PrepareChildForm(Form form)
    {
        form.BackColor = ContentBackground;
        form.Font = BodyFont();
        form.FormBorderStyle = FormBorderStyle.None;
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        form.AutoScroll = false;
    }

    public static string FormatCurrency(decimal value) => string.Format("{0:N0} đ", value);

    public static string ToDisplayStatus(string status) => status switch
    {
        "Unused" => "Chưa sử dụng",
        "Used" => "Đã sử dụng",
        "Canceled" => "Đã hủy",
        _ => status
    };

    public static Color StatusColor(string status) => status switch
    {
        "Unused" or "Mở bán" or "Đang mở bán" or "Đang chiếu" or "Hoạt động" or "Đang hoạt động" or "Sẵn sàng" => Success,
        "Used" or "Đã sử dụng" or "Đã thanh toán" => Primary,
        "Canceled" or "Đã hủy" or "Ngừng chiếu" or "Khóa" or "Bảo trì" => Danger,
        "Sắp chiếu" or "Chờ thanh toán" or "Gần hết ghế" => Warning,
        _ => TextMuted
    };

    public static void ApplyStatusCellFormatting(DataGridView grid, params string[] columns)
    {
        var statusColumns = columns.ToHashSet(StringComparer.OrdinalIgnoreCase);
        grid.CellFormatting += (_, e) =>
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var column = grid.Columns[e.ColumnIndex];
            if (!statusColumns.Contains(column.DataPropertyName) && !statusColumns.Contains(column.Name) && !statusColumns.Contains(column.HeaderText))
            {
                return;
            }

            var raw = e.Value?.ToString() ?? string.Empty;
            e.Value = ToDisplayStatus(raw);
            e.CellStyle.ForeColor = StatusColor(raw);
            e.CellStyle.Font = SectionFont(8.75f);
            e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            e.FormattingApplied = true;
        };
    }

    public static void CompleteDesignerGrid(DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoGenerateColumns = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        grid.ColumnHeadersHeight = 38;
        grid.EnableHeadersVisualStyles = false;
        grid.GridColor = CardBorder;
        grid.MultiSelect = false;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowTemplate.Height = 32;
        grid.RowTemplate.Resizable = DataGridViewTriState.False;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackground;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = TextDark;
        grid.ColumnHeadersDefaultCellStyle.Font = SectionFont(9F);
        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBackground;
        grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextDark;
        grid.DefaultCellStyle.BackColor = Color.White;
        grid.DefaultCellStyle.ForeColor = TextDark;
        grid.DefaultCellStyle.Font = SmallFont(9F);
        grid.DefaultCellStyle.Padding = new Padding(6, 2, 6, 2);
        grid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9F2FF");
        grid.DefaultCellStyle.SelectionForeColor = TextDark;
        grid.RowsDefaultCellStyle.BackColor = Color.White;
        grid.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9F2FF");
        grid.RowsDefaultCellStyle.SelectionForeColor = TextDark;
        grid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FBFDFF");
        grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9F2FF");

        AddDesignerPreviewRows(grid);
    }

    public static void ResetGridForBinding(params DataGridView[] grids)
    {
        foreach (var grid in grids)
        {
            grid.DataSource = null;
            if (grid.Rows.Count > 0)
            {
                grid.Rows.Clear();
            }
        }
    }

    private static void AddDesignerPreviewRows(DataGridView grid)
    {
        if (grid.Columns.Count == 0 || grid.Rows.Count > 0)
        {
            return;
        }

        try
        {
            var visibleRows = Math.Clamp((grid.Height - grid.ColumnHeadersHeight - 12) / Math.Max(1, grid.RowTemplate.Height), 4, 12);
            for (var rowIndex = 0; rowIndex < visibleRows; rowIndex++)
            {
                grid.Rows.Add(BuildDesignerPreviewRow(grid, rowIndex));
            }
        }
        catch (InvalidOperationException)
        {
            // Some design hosts keep the grid temporarily data-bound; preview rows are optional.
        }
    }

    private static object[] BuildDesignerPreviewRow(DataGridView grid, int rowIndex)
    {
        var row = new object[grid.Columns.Count];
        for (var columnIndex = 0; columnIndex < grid.Columns.Count; columnIndex++)
        {
            row[columnIndex] = DesignerPreviewValue(grid.Columns[columnIndex], rowIndex);
        }

        return row;
    }

    private static string DesignerPreviewValue(DataGridViewColumn column, int rowIndex)
    {
        var key = $"{column.DataPropertyName} {column.Name} {column.HeaderText}";
        if (ContainsAny(key, "TicketId", "Mã vé")) return rowIndex == 0 ? "TK000001" : "TK000002";
        if (ContainsAny(key, "MovieId", "Mã phim")) return rowIndex == 0 ? "MV001" : "MV002";
        if (ContainsAny(key, "ShowtimeId", "Mã lịch")) return rowIndex == 0 ? "ST001" : "ST002";
        if (ContainsAny(key, "RoomId", "Mã phòng")) return rowIndex == 0 ? "R01" : "R02";
        if (ContainsAny(key, "UserId")) return rowIndex == 0 ? "U001" : "U002";
        if (ContainsAny(key, "FullName", "Họ tên")) return rowIndex == 0 ? "Nguyễn Văn Quản" : "Trần Thị Mai";
        if (ContainsAny(key, "Username")) return rowIndex == 0 ? "admin" : "staff01";
        if (ContainsAny(key, "Role")) return rowIndex == 0 ? "Admin" : "Staff";
        if (ContainsAny(key, "Movie", "Title", "Tên phim", "Phim")) return rowIndex == 0 ? "Avengers: Endgame" : "Dune: Phần Hai";
        if (ContainsAny(key, "RoomType", "Loại phòng")) return rowIndex == 0 ? "IMAX" : "2D";
        if (ContainsAny(key, "Room", "Phòng")) return rowIndex == 0 ? "Phòng 2" : "Phòng 1";
        if (ContainsAny(key, "Genre", "Thể loại")) return rowIndex == 0 ? "Hành động" : "Khoa học viễn tưởng";
        if (ContainsAny(key, "Duration", "Thời lượng")) return rowIndex == 0 ? "181 phút" : "166 phút";
        if (ContainsAny(key, "Format", "Định dạng")) return rowIndex == 0 ? "2D" : "IMAX";
        if (ContainsAny(key, "Date", "Ngày")) return rowIndex == 0 ? "28/05/2026" : "29/05/2026";
        if (ContainsAny(key, "Start", "Giờ", "Bắt đầu")) return rowIndex == 0 ? "19:30" : "21:45";
        if (ContainsAny(key, "End", "Kết thúc")) return rowIndex == 0 ? "22:32" : "00:10";
        if (ContainsAny(key, "Price", "Giá")) return rowIndex == 0 ? "90.000 đ" : "120.000 đ";
        if (ContainsAny(key, "Revenue", "Doanh thu")) return rowIndex == 0 ? "8.240.000 đ" : "6.810.000 đ";
        if (ContainsAny(key, "Total", "Tổng tiền", "Tổng")) return rowIndex == 0 ? "180.000 đ" : "240.000 đ";
        if (ContainsAny(key, "TicketsSold", "Sold", "Số vé", "Đã bán")) return rowIndex == 0 ? "86" : "72";
        if (ContainsAny(key, "SeatRows", "Số hàng")) return rowIndex == 0 ? "8" : "7";
        if (ContainsAny(key, "SeatsPerRow", "mỗi hàng")) return rowIndex == 0 ? "10" : "12";
        if (ContainsAny(key, "SeatCount", "Sức chứa")) return rowIndex == 0 ? "86" : "96";
        if (ContainsAny(key, "Seats", "Ghế")) return rowIndex == 0 ? "B5, B6" : "C7, C8";
        if (ContainsAny(key, "Quantity", "SL")) return rowIndex == 0 ? "2" : "2";
        if (ContainsAny(key, "PaymentMethod", "Thanh toán")) return rowIndex == 0 ? "Tiền mặt" : "VNPAY Sandbox";
        if (ContainsAny(key, "Occupancy", "Lấp đầy")) return rowIndex == 0 ? "82%" : "68%";
        if (ContainsAny(key, "BestShowtime", "Suất chiếu")) return rowIndex == 0 ? "19:30 - Phòng 2" : "21:45 - Phòng 1";
        if (ContainsAny(key, "Action", "Thao tác")) return rowIndex == 0 ? "Thanh toán" : "Kiểm vé";
        if (ContainsAny(key, "Content", "Nội dung")) return rowIndex == 0 ? "Bán vé thành công" : "Vé hợp lệ";
        if (ContainsAny(key, "Time", "Thời gian")) return rowIndex == 0 ? "09:15" : "09:42";
        if (ContainsAny(key, "Staff", "Nhân viên")) return rowIndex == 0 ? "Trần Thị Mai" : "Lê Quốc Bảo";
        if (ContainsAny(key, "CheckedAt")) return rowIndex == 0 ? "28/05/2026 09:15" : "28/05/2026 09:42";
        if (ContainsAny(key, "Note", "Ghi chú")) return rowIndex == 0 ? "Sẵn sàng vận hành" : "Đang vệ sinh";
        if (ContainsAny(key, "Status", "Kết quả", "Trạng thái")) return rowIndex == 0 ? "Đang mở bán" : "Sắp chiếu";
        return rowIndex == 0 ? "Dữ liệu demo" : "Đang cập nhật";
    }

    private static bool ContainsAny(string source, params string[] values)
    {
        foreach (var value in values)
        {
            if (source.Contains(value, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}
