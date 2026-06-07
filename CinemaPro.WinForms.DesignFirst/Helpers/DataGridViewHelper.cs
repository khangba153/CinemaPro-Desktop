namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class DataGridViewHelper
{
    public static void ConfigureReadOnlyGrid(DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.MultiSelect = false;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    public static void ClearAndShowEmptyMessage(DataGridView grid, string message)
    {
        grid.Rows.Clear();
        if (grid.Columns.Count == 0)
        {
            grid.Columns.Add("messageColumn", "Thông báo");
        }

        grid.Rows.Add(message);
    }
}
