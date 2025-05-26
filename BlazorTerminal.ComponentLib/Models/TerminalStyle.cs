namespace BlazorTerminal.ComponentLib.Models
{
    /// <summary>
    /// Encapsulates basic styling information for a terminal cell.
    /// Colors are represented as CSS strings (e.g. "#ffffff" or "red").
    /// </summary>
    public class TerminalStyle
    {
        /// <summary>
        /// Foreground text color.
        /// </summary>
        public string ForegroundColor { get; set; } = "#ffffff";

        /// <summary>
        /// Background text color.
        /// </summary>
        public string BackgroundColor { get; set; } = "#000000";

        /// <summary>
        /// Additional text attributes like bold or underline.
        /// </summary>
        public TextAttribute Attributes { get; set; } = TextAttribute.None;

        /// <summary>
        /// Creates a deep copy of the style.
        /// </summary>
        public TerminalStyle Clone() => new()
        {
            ForegroundColor = ForegroundColor,
            BackgroundColor = BackgroundColor,
            Attributes = Attributes
        };
    }
}
