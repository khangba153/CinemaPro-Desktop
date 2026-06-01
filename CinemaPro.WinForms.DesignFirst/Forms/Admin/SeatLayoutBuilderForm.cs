using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatLayoutBuilderForm : Form
{
    private readonly string _roomId;
    private readonly int _rowCount;
    private readonly int _columnCount;
    private readonly bool[,] _selectedCells;
    private readonly Button[,] _cellButtons;

    public IReadOnlyList<SeatInfo> CreatedSeats { get; private set; } = [];

    public SeatLayoutBuilderForm(string roomId, string roomName, int rowCount, int columnCount, IReadOnlyList<SeatInfo> existingSeats)
    {
        _roomId = roomId;
        _rowCount = rowCount;
        _columnCount = columnCount;
        _selectedCells = new bool[rowCount, columnCount];
        _cellButtons = new Button[rowCount, columnCount];

        InitializeComponent();

        roomValueLabel.Text = roomName;
        sizeValueLabel.Text = $"{rowCount} hàng x {columnCount} cột";
        PrepareInitialSelection(existingSeats);
        RenderGrid();
    }

    private void PrepareInitialSelection(IReadOnlyList<SeatInfo> existingSeats)
    {
        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                _selectedCells[row, column] = true;
            }
        }

        if (existingSeats.Count == 0)
        {
            return;
        }

        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                _selectedCells[row, column] = false;
            }
        }

        foreach (var seat in existingSeats)
        {
            if (seat.RowIndex >= 0 && seat.RowIndex < _rowCount && seat.ColumnIndex >= 0 && seat.ColumnIndex < _columnCount)
            {
                _selectedCells[seat.RowIndex, seat.ColumnIndex] = true;
            }
        }
    }

    private void RenderGrid()
    {
        gridPanel.Controls.Clear();

        const int buttonWidth = 44;
        const int buttonHeight = 34;
        const int gap = 8;
        const int startX = 22;
        const int startY = 18;

        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                var button = new Button
                {
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(startX + column * (buttonWidth + gap), startY + row * (buttonHeight + gap)),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = new Point(row, column),
                    Cursor = Cursors.Hand
                };

                button.FlatAppearance.BorderSize = 1;
                button.Click += SeatCellButton_Click;
                _cellButtons[row, column] = button;
                gridPanel.Controls.Add(button);
            }
        }

        UpdateCellTextsAndStyles();
    }

    private void SeatCellButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button button || button.Tag is not Point position)
        {
            return;
        }

        _selectedCells[position.X, position.Y] = !_selectedCells[position.X, position.Y];
        UpdateCellTextsAndStyles();
    }

    private void UpdateCellTextsAndStyles()
    {
        var selectedCount = 0;

        for (var row = 0; row < _rowCount; row++)
        {
            var seatNumber = 1;
            var rowLabel = GetRowLabel(row);

            for (var column = 0; column < _columnCount; column++)
            {
                var button = _cellButtons[row, column];
                if (_selectedCells[row, column])
                {
                    button.Text = $"{rowLabel}{seatNumber}";
                    button.BackColor = Color.FromArgb(37, 99, 235);
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
                    seatNumber++;
                    selectedCount++;
                }
                else
                {
                    button.Text = "";
                    button.BackColor = Color.FromArgb(241, 245, 249);
                    button.ForeColor = Color.FromArgb(100, 116, 139);
                    button.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                }
            }
        }

        summaryLabel.Text = $"Đã chọn {selectedCount} ghế. Ô trống là lối đi.";
    }

    private void SelectAllButton_Click(object? sender, EventArgs e)
    {
        SetAllCells(true);
    }

    private void ClearAllButton_Click(object? sender, EventArgs e)
    {
        SetAllCells(false);
    }

    private void SetAllCells(bool selected)
    {
        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                _selectedCells[row, column] = selected;
            }
        }

        UpdateCellTextsAndStyles();
    }

    private void CreateButton_Click(object? sender, EventArgs e)
    {
        var seats = new List<SeatInfo>();

        for (var row = 0; row < _rowCount; row++)
        {
            var seatNumber = 1;
            var rowLabel = GetRowLabel(row);

            for (var column = 0; column < _columnCount; column++)
            {
                if (!_selectedCells[row, column])
                {
                    continue;
                }

                seats.Add(new SeatInfo
                {
                    RoomId = _roomId,
                    SeatCode = $"{rowLabel}{seatNumber}",
                    RowIndex = row,
                    ColumnIndex = column,
                    Status = SeatStatus.Available
                });

                seatNumber++;
            }
        }

        if (seats.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất 1 ô ghế.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        CreatedSeats = seats;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private static string GetRowLabel(int rowIndex)
    {
        var label = "";
        var value = rowIndex;

        do
        {
            label = (char)('A' + value % 26) + label;
            value = value / 26 - 1;
        }
        while (value >= 0);

        return label;
    }
}
