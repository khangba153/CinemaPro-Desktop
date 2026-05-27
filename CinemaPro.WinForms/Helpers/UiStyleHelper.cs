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
}
