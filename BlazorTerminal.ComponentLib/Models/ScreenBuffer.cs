using System;

namespace BlazorTerminal.ComponentLib.Models
{
    /// <summary>
    /// Represents the 2D grid of cells that make up the terminal screen.
    /// </summary>
    public class ScreenBuffer
    {
        private readonly TerminalCell[,] _cells;

        /// <summary>
        /// Number of rows in the buffer.
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// Number of columns in the buffer.
        /// </summary>
        public int Columns { get; }

        /// <summary>
        /// Access cells by row and column.
        /// </summary>
        public TerminalCell this[int row, int column]
        {
            get => _cells[row, column];
            set => _cells[row, column] = value;
        }

        /// <summary>
        /// Creates a new screen buffer.
        /// </summary>
        /// <param name="rows">Number of rows.</param>
        /// <param name="columns">Number of columns.</param>
        public ScreenBuffer(int rows, int columns)
        {
            if (rows <= 0) throw new ArgumentOutOfRangeException(nameof(rows));
            if (columns <= 0) throw new ArgumentOutOfRangeException(nameof(columns));

            Rows = rows;
            Columns = columns;
            _cells = new TerminalCell[rows, columns];
            Clear();
        }

        /// <summary>
        /// Fill the entire buffer with the supplied cell or blanks.
        /// </summary>
        public void Clear(TerminalCell? fillCell = null)
        {
            var cell = fillCell ?? new TerminalCell(' ');
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    _cells[r, c] = cell;
                }
            }
        }
    }
}
