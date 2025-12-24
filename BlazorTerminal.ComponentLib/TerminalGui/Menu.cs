namespace BlazorTerminal.ComponentLib.TerminalGui;

/// <summary>
/// Represents a menu component with selectable items.
/// </summary>
public class Menu
{
    public List<string> Items { get; set; } = new();
    public int SelectedIndex { get; set; } = 0;
    public string Prefix { get; set; } = "> ";
    public string UnselectedPrefix { get; set; } = "  ";
    public BorderStyle? BorderStyle { get; set; }
    public string? Title { get; set; }

    public Menu(params string[] items)
    {
        Items.AddRange(items);
    }

    /// <summary>
    /// Adds an item to the menu.
    /// </summary>
    public void AddItem(string item)
    {
        Items.Add(item);
    }

    /// <summary>
    /// Moves the selection up.
    /// </summary>
    public void SelectPrevious()
    {
        if (SelectedIndex > 0)
        {
            SelectedIndex--;
        }
    }

    /// <summary>
    /// Moves the selection down.
    /// </summary>
    public void SelectNext()
    {
        if (SelectedIndex < Items.Count - 1)
        {
            SelectedIndex++;
        }
    }

    /// <summary>
    /// Gets the currently selected item.
    /// </summary>
    public string? GetSelectedItem()
    {
        return SelectedIndex >= 0 && SelectedIndex < Items.Count ? Items[SelectedIndex] : null;
    }

    /// <summary>
    /// Renders the menu as an array of strings.
    /// </summary>
    public string[] Render()
    {
        var lines = new List<string>();

        for (int i = 0; i < Items.Count; i++)
        {
            var prefix = i == SelectedIndex ? Prefix : UnselectedPrefix;
            lines.Add(prefix + Items[i]);
        }

        // If a border is requested, wrap in a panel
        if (BorderStyle != null)
        {
            var maxWidth = lines.Max(l => l.Length);
            var panel = new Panel(0, 0, maxWidth + 4, lines.Count + 2, Title)
            {
                BorderStyle = BorderStyle
            };

            foreach (var line in lines)
            {
                panel.AddLine(line);
            }

            return panel.Render();
        }

        return lines.ToArray();
    }
}
