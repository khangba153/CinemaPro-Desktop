namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class UiStyleHelper
{
    public static readonly Color AppBackground = Color.FromArgb(245, 247, 251);
    public static readonly Color PanelBorder = Color.FromArgb(220, 227, 237);
    public static readonly Color Primary = Color.FromArgb(37, 99, 235);
    public static readonly Color PrimaryLight = Color.FromArgb(232, 240, 255);
    public static readonly Color TextDark = Color.FromArgb(17, 24, 39);
    public static readonly Color MutedText = Color.FromArgb(89, 100, 117);

    public static Font Font(float size, FontStyle style = FontStyle.Regular)
    {
        return new Font("Segoe UI", size, style, GraphicsUnit.Point);
    }

    public static void StyleGrid(DataGridView grid)
    {
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.FixedSingle;
        grid.GridColor = Color.FromArgb(229, 231, 235);
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = TextDark;
        grid.ColumnHeadersDefaultCellStyle.Font = Font(9F, FontStyle.Bold);
        grid.DefaultCellStyle.BackColor = Color.White;
        grid.DefaultCellStyle.ForeColor = TextDark;
        grid.DefaultCellStyle.SelectionBackColor = PrimaryLight;
        grid.DefaultCellStyle.SelectionForeColor = TextDark;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        grid.RowHeadersVisible = false;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.ColumnHeadersHeight = 34;
        grid.RowTemplate.Height = 32;
    }

    public static void StylePrimaryButton(Button button)
    {
        button.BackColor = Primary;
        button.ForeColor = Color.White;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = Font(9F, FontStyle.Bold);
        button.Cursor = Cursors.Hand;
    }

    public static void StyleSecondaryButton(Button button)
    {
        button.BackColor = Color.White;
        button.ForeColor = TextDark;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = PanelBorder;
        button.Font = Font(9F);
        button.Cursor = Cursors.Hand;
    }

    public static void StyleDangerButton(Button button)
    {
        button.BackColor = Color.FromArgb(220, 38, 38);
        button.ForeColor = Color.White;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = Font(9F, FontStyle.Bold);
        button.Cursor = Cursors.Hand;
    }

    public static void StyleInput(Control control)
    {
        control.Font = Font(9.5F);
        control.BackColor = Color.White;
        control.ForeColor = TextDark;
    }
}
