using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatLayoutBuilderForm : Form
{
    public IReadOnlyList<SeatInfo> CreatedSeats { get; private set; } = [];

    public SeatLayoutBuilderForm()
    {
        InitializeComponent();
    }

    public SeatLayoutBuilderForm(string roomId, string roomName, int rowCount, int columnCount, IReadOnlyList<SeatInfo> existingSeats)
    {
        InitializeComponent();
    }

    private void SelectAllButton_Click(object? sender, EventArgs e)
    {
    }

    private void ClearAllButton_Click(object? sender, EventArgs e)
    {
    }

    private void CreateButton_Click(object? sender, EventArgs e)
    {
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
    }
}
