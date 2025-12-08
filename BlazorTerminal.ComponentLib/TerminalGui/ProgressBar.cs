namespace BlazorTerminal.ComponentLib.TerminalGui;

/// <summary>
/// Represents a progress bar component for the terminal.
/// </summary>
public class ProgressBar
{
    public int Width { get; set; }
    public double Progress { get; set; } // 0.0 to 1.0
    public char FilledChar { get; set; } = '█';
    public char EmptyChar { get; set; } = '░';
    public bool ShowPercentage { get; set; } = true;
    public string? Label { get; set; }

    public ProgressBar(int width, double progress = 0.0)
    {
        Width = width;
        Progress = Math.Clamp(progress, 0.0, 1.0);
    }

    /// <summary>
    /// Updates the progress value (0.0 to 1.0).
    /// </summary>
    public void SetProgress(double progress)
    {
        Progress = Math.Clamp(progress, 0.0, 1.0);
    }

    /// <summary>
    /// Renders the progress bar as a string.
    /// </summary>
    public string Render()
    {
        var availableWidth = Width;
        var percentage = (int)(Progress * 100);
        var percentageText = ShowPercentage ? $" {percentage,3}%" : "";

        if (ShowPercentage)
        {
            availableWidth -= percentageText.Length;
        }

        if (!string.IsNullOrEmpty(Label))
        {
            availableWidth -= Label.Length + 1;
        }

        var filledWidth = (int)(availableWidth * Progress);
        var emptyWidth = availableWidth - filledWidth;

        var bar = new string(FilledChar, filledWidth) + new string(EmptyChar, emptyWidth);

        var result = "";
        if (!string.IsNullOrEmpty(Label))
        {
            result += Label + " ";
        }
        result += bar;
        if (ShowPercentage)
        {
            result += percentageText;
        }

        return result;
    }
}
