namespace BlazorTerminal.ComponentLib.TerminalGui;

/// <summary>
/// Defines the characters used to draw borders around terminal UI elements.
/// </summary>
public class BorderStyle
{
    public char TopLeft { get; init; }
    public char TopRight { get; init; }
    public char BottomLeft { get; init; }
    public char BottomRight { get; init; }
    public char Horizontal { get; init; }
    public char Vertical { get; init; }

    public BorderStyle(char topLeft, char topRight, char bottomLeft, char bottomRight, char horizontal, char vertical)
    {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
        Horizontal = horizontal;
        Vertical = vertical;
    }

    /// <summary>
    /// Single-line ASCII border style using simple characters.
    /// </summary>
    public static BorderStyle Single { get; } = new BorderStyle('┌', '┐', '└', '┘', '─', '│');

    /// <summary>
    /// Double-line border style.
    /// </summary>
    public static BorderStyle Double { get; } = new BorderStyle('╔', '╗', '╚', '╝', '═', '║');

    /// <summary>
    /// Rounded corner border style.
    /// </summary>
    public static BorderStyle Rounded { get; } = new BorderStyle('╭', '╮', '╰', '╯', '─', '│');

    /// <summary>
    /// Bold/thick border style.
    /// </summary>
    public static BorderStyle Bold { get; } = new BorderStyle('┏', '┓', '┗', '┛', '━', '┃');

    /// <summary>
    /// Simple ASCII border style using basic characters for compatibility.
    /// </summary>
    public static BorderStyle Ascii { get; } = new BorderStyle('+', '+', '+', '+', '-', '|');
}
