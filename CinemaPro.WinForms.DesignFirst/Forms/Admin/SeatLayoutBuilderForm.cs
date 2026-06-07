using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatLayoutBuilderForm : Form
{
    private const int SeatButtonSize = 44;
    private const int SeatGap = 8;
    private readonly List<Button> _cellButtons = [];
    private bool[,] _selectedCells = new bool[0, 0];
    private string _roomId = "";
    private int _rowCount;
    private int _columnCount;

    public IReadOnlyList<SeatInfo> CreatedSeats { get; private set; } = [];

    public SeatLayoutBuilderForm()
    {
        InitializeComponent();
        InitializeBuilder("Phòng chiếu", 5, 8, []);
    }

    public SeatLayoutBuilderForm(string roomId, string roomName, int rowCount, int columnCount, IReadOnlyList<SeatInfo> existingSeats)
    {
        InitializeComponent();
        _roomId = roomId;
        InitializeBuilder(roomName, rowCount, columnCount, existingSeats);
    }

    private void SelectAllButton_Click(object? sender, EventArgs e)
    {
        SetAllCells(true);
    }

    private void ClearAllButton_Click(object? sender, EventArgs e)
    {
        SetAllCells(false);
    }

    private void CreateButton_Click(object? sender, EventArgs e)
    {
        var seats = new List<SeatInfo>();

        for (var row = 0; row < _rowCount; row++)
        {
            var seatNumberInRow = 1;

            for (var column = 0; column < _columnCount; column++)
            {
                if (!_selectedCells[row, column])
                {
                    continue;
                }

                seats.Add(new SeatInfo
                {
                    RoomId = _roomId,
                    SeatCode = GetRowLabel(row) + seatNumberInRow,
                    RowIndex = row,
                    ColumnIndex = column,
                    Status = SeatStatus.Available
                });

                seatNumberInRow++;
            }
        }

        if (seats.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một ô ghế.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void InitializeBuilder(string roomName, int rowCount, int columnCount, IReadOnlyList<SeatInfo> existingSeats)
    {
        _rowCount = Math.Max(1, rowCount);
        _columnCount = Math.Max(1, columnCount);
        _selectedCells = new bool[_rowCount, _columnCount];

        roomValueLabel.Text = roomName;
        sizeValueLabel.Text = $"{_rowCount} hàng x {_columnCount} cột";

        if (existingSeats.Count == 0)
        {
            SetAllCells(true, renderAfterChange: false);
        }
        else
        {
            foreach (var seat in existingSeats)
            {
                if (seat.RowIndex >= 0
                    && seat.RowIndex < _rowCount
                    && seat.ColumnIndex >= 0
                    && seat.ColumnIndex < _columnCount)
                {
                    _selectedCells[seat.RowIndex, seat.ColumnIndex] = true;
                }
            }
        }

        RenderGrid();
    }

    private void RenderGrid()
    {
        foreach (var button in _cellButtons)
        {
            gridPanel.Controls.Remove(button);
            button.Dispose();
        }

        _cellButtons.Clear();

        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                var button = new Button
                {
                    Size = new Size(SeatButtonSize, SeatButtonSize),
                    Location = new Point(
                        24 + column * (SeatButtonSize + SeatGap),
                        24 + row * (SeatButtonSize + SeatGap)),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    Tag = (row, column),
                    Cursor = Cursors.Hand
                };

                button.FlatAppearance.BorderSize = 1;
                button.Click += CellButton_Click;
                _cellButtons.Add(button);
                gridPanel.Controls.Add(button);
            }
        }

        RefreshCellButtons();
    }

    private void CellButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button { Tag: ValueTuple<int, int> position })
        {
            return;
        }

        _selectedCells[position.Item1, position.Item2] = !_selectedCells[position.Item1, position.Item2];
        RefreshCellButtons();
    }

    private void SetAllCells(bool selected, bool renderAfterChange = true)
    {
        for (var row = 0; row < _rowCount; row++)
        {
            for (var column = 0; column < _columnCount; column++)
            {
                _selectedCells[row, column] = selected;
            }
        }

        if (renderAfterChange)
        {
            RefreshCellButtons();
        }
    }

    private void RefreshCellButtons()
    {
        var selectedCount = 0;

        foreach (var button in _cellButtons)
        {
            if (button.Tag is not ValueTuple<int, int> position)
            {
                continue;
            }

            var isSelected = _selectedCells[position.Item1, position.Item2];
            if (isSelected)
            {
                selectedCount++;
            }

            button.Text = isSelected ? GetPreviewSeatCode(position.Item1, position.Item2) : "";
            button.BackColor = isSelected ? Color.FromArgb(37, 99, 235) : Color.White;
            button.ForeColor = isSelected ? Color.White : Color.FromArgb(148, 163, 184);
            button.FlatAppearance.BorderColor = isSelected ? Color.FromArgb(37, 99, 235) : Color.FromArgb(203, 213, 225);
        }

        summaryLabel.Text = $"Đã chọn {selectedCount} ghế. Ô trắng là lối đi.";
    }

    private string GetPreviewSeatCode(int rowIndex, int columnIndex)
    {
        var seatNumber = 1;

        for (var column = 0; column <= columnIndex; column++)
        {
            if (_selectedCells[rowIndex, column])
            {
                seatNumber++;
            }
        }

        return GetRowLabel(rowIndex) + (seatNumber - 1);
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
