using System;

namespace BlazorTerminal.ComponentLib.Models
{
    /// <summary>
    /// Flags representing common text attributes for a terminal cell.
    /// </summary>
    [Flags]
    public enum TextAttribute
    {
        None = 0,
        Bold = 1 << 0,
        Italic = 1 << 1,
        Underline = 1 << 2,
        Inverse = 1 << 3
    }
}
