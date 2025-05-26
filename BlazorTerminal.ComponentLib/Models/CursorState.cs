namespace BlazorTerminal.ComponentLib.Models
{
    /// <summary>
    /// Represents the current state of the terminal cursor.
    /// </summary>
    public class CursorState
    {
        /// <summary>
        /// Zero-based row position of the cursor.
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Zero-based column position of the cursor.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Whether the cursor is visible.
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// The shape of the cursor when rendered.
        /// </summary>
        public CursorShape Shape { get; set; } = CursorShape.Block;
    }
}
