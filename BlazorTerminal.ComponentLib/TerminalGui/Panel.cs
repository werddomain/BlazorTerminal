namespace BlazorTerminal.ComponentLib.TerminalGui;

/// <summary>
/// Represents a bordered panel that can contain text or other content.
/// </summary>
public class Panel
{
    public int Row { get; set; }
    public int Column { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? Title { get; set; }
    public BorderStyle BorderStyle { get; set; } = BorderStyle.Single;
    public List<string> Content { get; set; } = new();

    public Panel(int row, int column, int width, int height, string? title = null)
    {
        Row = row;
        Column = column;
        Width = width;
        Height = height;
        Title = title;
    }

    /// <summary>
    /// Adds a line of text to the panel content.
    /// </summary>
    public void AddLine(string text)
    {
        Content.Add(text);
    }

    /// <summary>
    /// Clears all content from the panel.
    /// </summary>
    public void Clear()
    {
        Content.Clear();
    }

    /// <summary>
    /// Renders the panel as an array of strings, ready to be written to the terminal.
    /// </summary>
    public string[] Render()
    {
        var box = Box.Draw(Width, Height, BorderStyle, Title);
        var innerWidth = Width - 2;
        var innerHeight = Height - 2;

        // Insert content into the box
        for (int i = 0; i < innerHeight && i < Content.Count; i++)
        {
            var line = Content[i];
            // Truncate or pad the line to fit inside the box
            if (line.Length > innerWidth)
            {
                line = line.Substring(0, innerWidth);
            }
            else if (line.Length < innerWidth)
            {
                line = line.PadRight(innerWidth);
            }

            // Replace the middle part of the box line with content
            box[i + 1] = BorderStyle.Vertical + line + BorderStyle.Vertical;
        }

        return box;
    }
}
