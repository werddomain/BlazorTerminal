namespace BlazorTerminal.ComponentLib.Models
{
    /// <summary>
    /// Represents a single character cell on the terminal screen.
    /// </summary>
    public struct TerminalCell
    {
        /// <summary>
        /// The character displayed in the cell.
        /// </summary>
        public char Character { get; set; }

        /// <summary>
        /// Styling applied to the character.
        /// </summary>
        public TerminalStyle Style { get; set; }

        public TerminalCell(char character)
        {
            Character = character;
            Style = new TerminalStyle();
        }
    }
}
