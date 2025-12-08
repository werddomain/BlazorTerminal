namespace BlazorTerminal.ComponentLib.TerminalGui;

/// <summary>
/// Utility class for drawing boxes and borders in the terminal.
/// </summary>
public static class Box
{
    /// <summary>
    /// Generates the lines needed to draw a box with the specified dimensions and border style.
    /// </summary>
    /// <param name="width">Width of the box (including borders).</param>
    /// <param name="height">Height of the box (including borders).</param>
    /// <param name="borderStyle">Border style to use.</param>
    /// <param name="title">Optional title to display in the top border.</param>
    /// <returns>Array of strings representing each line of the box.</returns>
    public static string[] Draw(int width, int height, BorderStyle? borderStyle = null, string? title = null)
    {
        borderStyle ??= BorderStyle.Single;

        if (width < 2 || height < 2)
            throw new ArgumentException("Box dimensions must be at least 2x2");

        var lines = new string[height];
        var innerWidth = width - 2;

        // Top border
        var topLine = borderStyle.TopLeft.ToString();
        if (!string.IsNullOrEmpty(title) && innerWidth > title.Length + 2)
        {
            topLine += " " + title + " ";
            topLine += new string(borderStyle.Horizontal, innerWidth - title.Length - 2);
        }
        else
        {
            topLine += new string(borderStyle.Horizontal, innerWidth);
        }
        topLine += borderStyle.TopRight;
        lines[0] = topLine;

        // Middle lines
        var middleLine = borderStyle.Vertical + new string(' ', innerWidth) + borderStyle.Vertical;
        for (int i = 1; i < height - 1; i++)
        {
            lines[i] = middleLine;
        }

        // Bottom border
        lines[height - 1] = borderStyle.BottomLeft + new string(borderStyle.Horizontal, innerWidth) + borderStyle.BottomRight;

        return lines;
    }

    /// <summary>
    /// Generates a horizontal line.
    /// </summary>
    public static string HorizontalLine(int length, char character = '─')
    {
        return new string(character, length);
    }

    /// <summary>
    /// Generates a vertical line (array of single-character strings).
    /// </summary>
    public static string[] VerticalLine(int height, char character = '│')
    {
        var lines = new string[height];
        var charStr = character.ToString();
        for (int i = 0; i < height; i++)
        {
            lines[i] = charStr;
        }
        return lines;
    }
}
