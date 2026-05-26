using System.ComponentModel;
using System.Drawing.Drawing2D;

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

    public static Panel CreatePage(Form form)
    {
        form.BackColor = ContentBackground;
        form.Font = BodyFont();
        form.Padding = Padding.Empty;

        var body = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = ContentBackground
        };
        form.Controls.Add(body);
        return body;
    }

    public static Panel CreatePage(Form form, string title, string subtitle) => CreatePage(form);

    public static RoundedPanel CreateCard(int radius = 8) => new()
    {
        BackColor = CardBackground,
        BorderColor = CardBorder,
        BorderRadius = radius,
        Padding = new Padding(14)
    };

    public static Label CreateCardTitle(string text) => new()
    {
        Dock = DockStyle.Fill,
        Text = text.ToUpperInvariant(),
        Font = SectionFont(10),
        ForeColor = Primary,
        TextAlign = ContentAlignment.MiddleLeft,
        AutoEllipsis = true
    };

    public static Label CreateSectionLabel(string text) => new()
    {
        AutoSize = true,
        Text = text,
        Font = SectionFont(10.5f),
        ForeColor = Primary,
        Margin = new Padding(0, 0, 0, 8)
    };

    public static RoundedButton CreateButton(string text, Color? backColor = null, Color? foreColor = null) => new()
    {
        Text = text,
        BackColor = backColor ?? Primary,
        ForeColor = foreColor ?? Color.White,
        HoverBackColor = ControlPaint.Dark(backColor ?? Primary, 0.06f),
        BorderColor = backColor ?? Primary,
        BorderRadius = 7,
        Height = 38,
        Width = 124,
        Font = SectionFont(9.5f),
        Cursor = Cursors.Hand,
        Margin = new Padding(0, 0, 8, 0)
    };

    public static RoundedButton CreateOutlineButton(string text, Color? accent = null) => new()
    {
        Text = text,
        BackColor = Color.White,
        ForeColor = accent ?? Primary,
        HoverBackColor = ColorTranslator.FromHtml("#F0F7FF"),
        BorderColor = ColorTranslator.FromHtml("#9BC2FF"),
        BorderRadius = 7,
        Height = 38,
        Width = 124,
        Font = SectionFont(9.5f),
        Cursor = Cursors.Hand,
        Margin = new Padding(0, 0, 8, 0)
    };

    public static TextBox CreateTextBox(string placeholder = "") => new()
    {
        AutoSize = false,
        BorderStyle = BorderStyle.FixedSingle,
        Font = BodyFont(10),
        PlaceholderText = placeholder,
        Height = 32,
        Margin = new Padding(0, 4, 0, 8)
    };

    public static ComboBox CreateComboBox() => new()
    {
        DropDownStyle = ComboBoxStyle.DropDownList,
        FlatStyle = FlatStyle.Flat,
        Font = BodyFont(10),
        Height = 34,
        Margin = new Padding(0, 4, 0, 8)
    };

    public static DateTimePicker CreateDatePicker(DateTime? value = null) => new()
    {
        Format = DateTimePickerFormat.Short,
        Font = BodyFont(10),
        Height = 34,
        Value = value ?? DateTime.Today,
        Margin = new Padding(0, 4, 0, 8)
    };

    public static DataGridView CreateGrid()
    {
        var grid = new DataGridView
        {
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            BackgroundColor = CardBackground,
            BorderStyle = BorderStyle.None,
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
            Dock = DockStyle.Fill,
            EnableHeadersVisualStyles = false,
            ReadOnly = true,
            RowHeadersVisible = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false
        };

        grid.Font = BodyFont(9.25f);
        grid.GridColor = CardBorder;
        grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackground;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = TextDark;
        grid.ColumnHeadersDefaultCellStyle.Font = SectionFont(9.25f);
        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 6, 6, 6);
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBackground;
        grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextDark;
        grid.ColumnHeadersHeight = 40;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        grid.DefaultCellStyle.BackColor = CardBackground;
        grid.DefaultCellStyle.ForeColor = TextDark;
        grid.DefaultCellStyle.Font = BodyFont(9.25f);
        grid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9F2FF");
        grid.DefaultCellStyle.SelectionForeColor = TextDark;
        grid.DefaultCellStyle.Padding = new Padding(7, 3, 7, 3);
        grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        grid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FBFDFF");
        grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9F2FF");
        grid.RowTemplate.Height = 34;
        grid.DataBindingComplete += (_, _) =>
        {
            grid.ClearSelection();
            grid.CurrentCell = null;
        };
        return grid;
    }

    public static RoundedPanel CreateStatCard(string label, string value, Color accent, string icon = "\uE9D2", string note = "")
    {
        var card = CreateCard();
        card.Dock = DockStyle.Fill;
        card.Height = 94;
        card.Margin = new Padding(0, 0, 12, 0);
        card.Padding = new Padding(18, 14, 18, 14);

        var layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 3,
            BackColor = Color.Transparent
        };
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
        card.Controls.Add(layout);

        var iconLabel = new Label
        {
            Dock = DockStyle.Fill,
            Text = icon,
            Font = IconFont(26),
            ForeColor = accent,
            TextAlign = ContentAlignment.MiddleCenter
        };
        layout.Controls.Add(iconLabel, 0, 0);
        layout.SetRowSpan(iconLabel, 3);

        layout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = label,
            Font = SmallFont(9.5f),
            ForeColor = TextMuted,
            TextAlign = ContentAlignment.BottomLeft,
            AutoEllipsis = true
        }, 1, 0);
        layout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = value,
            Font = value.Length > 12 ? TitleFont(14) : TitleFont(17),
            ForeColor = accent,
            TextAlign = ContentAlignment.MiddleLeft,
            AutoEllipsis = true
        }, 1, 1);
        layout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = note,
            Font = SmallFont(8.75f),
            ForeColor = TextMuted,
            TextAlign = ContentAlignment.TopLeft,
            AutoEllipsis = true
        }, 1, 2);

        return card;
    }

    public static Control CreateFilterBar(params Control[] controls)
    {
        var bar = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Padding = new Padding(0, 0, 0, 8),
            BackColor = ContentBackground
        };

        foreach (var control in controls)
        {
            control.Margin = new Padding(0, 0, 12, 0);
            bar.Controls.Add(control);
        }

        return bar;
    }

    public static Control FieldBlock(string label, Control control, int labelWidth = 0)
    {
        var panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            Width = labelWidth > 0 ? labelWidth : Math.Max(control.Width, 150),
            Height = 58,
            ColumnCount = 1,
            RowCount = 2,
            Margin = Padding.Empty
        };
        panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
        panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
        panel.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = label,
            Font = SmallFont(9.25f),
            ForeColor = TextMuted,
            TextAlign = ContentAlignment.BottomLeft
        }, 0, 0);
        control.Dock = DockStyle.Fill;
        panel.Controls.Add(control, 0, 1);
        return panel;
    }

    public static Label CreateMutedLabel(string text) => new()
    {
        Dock = DockStyle.Fill,
        Text = text,
        Font = SmallFont(9.25f),
        ForeColor = TextMuted,
        TextAlign = ContentAlignment.MiddleLeft,
        AutoEllipsis = true
    };

    public static Label CreateValueLabel(string text, float size = 10) => new()
    {
        Dock = DockStyle.Fill,
        Text = text,
        Font = SectionFont(size),
        ForeColor = TextDark,
        TextAlign = ContentAlignment.MiddleLeft,
        AutoEllipsis = true
    };

    public static Label CreateBadge(string text, Color accent) => new()
    {
        AutoSize = false,
        Height = 26,
        Width = Math.Max(88, text.Length * 8 + 24),
        Text = text,
        Font = SectionFont(8.75f),
        ForeColor = accent,
        BackColor = Color.FromArgb(24, accent),
        TextAlign = ContentAlignment.MiddleCenter,
        Margin = new Padding(0, 0, 6, 6)
    };

    public static Label CreateInfoRow(string label, string value)
    {
        return new Label
        {
            Dock = DockStyle.Top,
            Height = 31,
            Text = $"{label}:  {value}",
            Font = BodyFont(9.5f),
            ForeColor = TextDark,
            TextAlign = ContentAlignment.MiddleLeft,
            AutoEllipsis = true
        };
    }

    public static void AddTextColumn(this DataGridView grid, string property, string header, int fillWeight = 100)
    {
        grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = property,
            DataPropertyName = property,
            HeaderText = header,
            FillWeight = fillWeight,
            MinimumWidth = 52
        });
    }

    public static TableLayoutPanel CreateTwoColumnLayout() => new()
    {
        Dock = DockStyle.Fill,
        ColumnCount = 2,
        RowCount = 1
    };

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

    public static GraphicsPath CreateRoundRectangle(Rectangle bounds, int radius)
    {
        var correctedRadius = Math.Max(1, Math.Min(radius, Math.Min(bounds.Width, bounds.Height) / 2));
        var diameter = correctedRadius * 2;
        var path = new GraphicsPath();
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}

public class RoundedPanel : Panel
{
    public RoundedPanel()
    {
        DoubleBuffered = true;
        Resize += (_, _) => Invalidate();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderRadius { get; set; } = 8;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor { get; set; } = UiStyleHelper.CardBorder;

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = UiStyleHelper.CreateRoundRectangle(new Rectangle(0, 0, Width - 1, Height - 1), BorderRadius);
        using var brush = new SolidBrush(BackColor);
        using var pen = new Pen(BorderColor);
        e.Graphics.FillPath(brush, path);
        e.Graphics.DrawPath(pen, path);
        base.OnPaint(e);
    }
}

public class RoundedButton : Button
{
    private Color _normalBackColor;
    private bool _isHovering;

    public RoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        UseVisualStyleBackColor = false;
        DoubleBuffered = true;
        _normalBackColor = BackColor;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderRadius { get; set; } = 7;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color HoverBackColor { get; set; } = Color.Empty;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor { get; set; } = Color.Empty;

    protected override void OnBackColorChanged(EventArgs e)
    {
        base.OnBackColorChanged(e);
        if (!_isHovering)
        {
            _normalBackColor = BackColor;
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        if (HoverBackColor != Color.Empty)
        {
            _isHovering = true;
            base.BackColor = HoverBackColor;
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _isHovering = false;
        base.BackColor = _normalBackColor;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = UiStyleHelper.CreateRoundRectangle(new Rectangle(0, 0, Width - 1, Height - 1), BorderRadius);
        using var brush = new SolidBrush(BackColor);
        using var pen = new Pen(BorderColor == Color.Empty ? BackColor : BorderColor);
        pevent.Graphics.FillPath(brush, path);
        pevent.Graphics.DrawPath(pen, path);
        TextRenderer.DrawText(
            pevent.Graphics,
            Text,
            Font,
            ClientRectangle,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
    }
}

public sealed class StatCardLabel : Label
{
    public StatCardLabel()
    {
        DoubleBuffered = true;
        AutoSize = false;
        BackColor = UiStyleHelper.CardBackground;
        Dock = DockStyle.Fill;
        Margin = new Padding(0, 0, 12, 0);
        Padding = new Padding(18, 12, 18, 12);
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Caption { get; set; } = string.Empty;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Note { get; set; } = string.Empty;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color AccentColor { get; set; } = UiStyleHelper.Primary;

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.Clear(BackColor);
        using var borderPen = new Pen(UiStyleHelper.CardBorder);
        e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);

        var textBounds = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Horizontal, Height - Padding.Vertical);
        TextRenderer.DrawText(
            e.Graphics,
            Caption,
            UiStyleHelper.SmallFont(9.5f),
            new Rectangle(textBounds.Left, textBounds.Top, textBounds.Width, 22),
            UiStyleHelper.TextMuted,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            UiStyleHelper.TitleFont(Text.Length > 12 ? 14f : 17f),
            new Rectangle(textBounds.Left, textBounds.Top + 22, textBounds.Width, 34),
            AccentColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

        TextRenderer.DrawText(
            e.Graphics,
            Note,
            UiStyleHelper.SmallFont(8.75f),
            new Rectangle(textBounds.Left, textBounds.Top + 56, textBounds.Width, 22),
            UiStyleHelper.TextMuted,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
    }
}

public sealed class MiniBarChartPanel : Panel
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IReadOnlyList<(string Label, decimal Value)> Bars { get; set; } = [];

    public MiniBarChartPanel()
    {
        DoubleBuffered = true;
        BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (Bars.Count == 0)
        {
            return;
        }

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        var left = 42;
        var bottom = Height - 34;
        var top = 16;
        var max = Math.Max(1, Bars.Max(bar => bar.Value));
        using var gridPen = new Pen(ColorTranslator.FromHtml("#E6EDF5"));
        using var barBrush = new SolidBrush(UiStyleHelper.Primary);
        using var textBrush = new SolidBrush(UiStyleHelper.TextMuted);
        using var valueBrush = new SolidBrush(UiStyleHelper.TextDark);
        using var font = UiStyleHelper.SmallFont(8.5f);
        using var valueFont = UiStyleHelper.SectionFont(8.5f);

        for (var i = 0; i <= 3; i++)
        {
            var y = top + (bottom - top) * i / 3;
            e.Graphics.DrawLine(gridPen, left, y, Width - 16, y);
        }

        var slot = Math.Max(1, (Width - left - 24) / Bars.Count);
        var barWidth = Math.Min(42, Math.Max(18, slot / 2));

        for (var i = 0; i < Bars.Count; i++)
        {
            var bar = Bars[i];
            var height = (int)((bottom - top - 12) * (bar.Value / max));
            var x = left + i * slot + (slot - barWidth) / 2;
            var y = bottom - height;
            using var path = UiStyleHelper.CreateRoundRectangle(new Rectangle(x, y, barWidth, height + 1), 4);
            e.Graphics.FillPath(barBrush, path);
            e.Graphics.DrawString(ShortNumber(bar.Value), valueFont, valueBrush, x - 4, y - 18);
            e.Graphics.DrawString(bar.Label, font, textBrush, x - 4, bottom + 6);
        }
    }

    private static string ShortNumber(decimal value)
    {
        return value >= 1_000_000 ? $"{value / 1_000_000:0.#}M" : value.ToString("N0");
    }
}

public sealed class FakeQrPanel : Panel
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Code { get; set; } = "TK000001";

    public FakeQrPanel()
    {
        DoubleBuffered = true;
        BackColor = Color.White;
        BorderStyle = BorderStyle.FixedSingle;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var seed = Math.Abs(Code.GetHashCode());
        var random = new Random(seed);
        var cell = Math.Max(3, Math.Min(8, Width / 20));
        var size = cell * 17;
        var offsetX = (Width - size) / 2;
        var offsetY = (Height - size) / 2;
        using var brush = new SolidBrush(Color.Black);

        DrawFinder(e.Graphics, brush, offsetX, offsetY, cell);
        DrawFinder(e.Graphics, brush, offsetX + cell * 12, offsetY, cell);
        DrawFinder(e.Graphics, brush, offsetX, offsetY + cell * 12, cell);

        for (var row = 0; row < 17; row++)
        {
            for (var col = 0; col < 17; col++)
            {
                if (IsFinderArea(row, col))
                {
                    continue;
                }

                if (random.NextDouble() > 0.54)
                {
                    e.Graphics.FillRectangle(brush, offsetX + col * cell, offsetY + row * cell, cell, cell);
                }
            }
        }
    }

    private static bool IsFinderArea(int row, int col)
    {
        return row < 5 && col < 5 || row < 5 && col > 11 || row > 11 && col < 5;
    }

    private static void DrawFinder(Graphics graphics, Brush brush, int x, int y, int cell)
    {
        graphics.FillRectangle(brush, x, y, cell * 5, cell * 5);
        graphics.FillRectangle(Brushes.White, x + cell, y + cell, cell * 3, cell * 3);
        graphics.FillRectangle(brush, x + cell * 2, y + cell * 2, cell, cell);
    }
}
