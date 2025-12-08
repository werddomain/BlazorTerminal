# TerminalGui - Advanced GUI Components for BlazorTerminal

This module provides advanced terminal GUI capabilities inspired by TUI (Terminal User Interface) libraries like OpenTUI, but built specifically for Blazor applications.

## Features

### 1. Border Styles

Multiple predefined border styles for drawing boxes and panels:

```csharp
BorderStyle.Single   // ┌─┐│└┘
BorderStyle.Double   // ╔═╗║╚╝
BorderStyle.Rounded  // ╭─╮│╰╯
BorderStyle.Bold     // ┏━┓┃┗┛
BorderStyle.Ascii    // +-+|++  (for compatibility)
```

### 2. Box Drawing

Draw boxes with customizable borders and optional titles:

```csharp
terminal.DrawBox(row: 5, column: 10, width: 30, height: 10,
                 borderStyle: BorderStyle.Double,
                 title: "My Box");
```

### 3. Panels

Bordered containers that can hold multiple lines of content:

```csharp
var panel = new Panel(row: 5, column: 10, width: 40, height: 8, title: "Info")
{
    BorderStyle = BorderStyle.Rounded
};
panel.AddLine("Line 1");
panel.AddLine("Line 2");
terminal.DrawPanel(panel);
```

### 4. Progress Bars

Visual progress indicators with customizable appearance:

```csharp
var progressBar = new ProgressBar(width: 50, progress: 0.75)
{
    Label = "Loading",
    FilledChar = '█',
    EmptyChar = '░',
    ShowPercentage = true
};
terminal.DrawProgressBar(row: 10, column: 5, progressBar);
```

### 5. Menus

Selectable menu components:

```csharp
var menu = new Menu("Option 1", "Option 2", "Option 3")
{
    SelectedIndex = 0,
    BorderStyle = BorderStyle.Single,
    Title = "Main Menu"
};
terminal.DrawMenu(row: 5, column: 10, menu);
```

## Terminal Control Extensions

The `TerminalControl` component has been enhanced with new methods:

### Cursor Control
```csharp
terminal.SetCursorPosition(row: 10, column: 5);
```

### Screen Management
```csharp
terminal.Clear();  // Clear the entire screen
```

### Drawing at Specific Positions
```csharp
terminal.DrawAt(row: 5, column: 10, text: "Hello");
```

## Usage Example

```csharp
@page "/"
@using BlazorTerminal.ComponentLib.TerminalGui

<TerminalControl @ref="terminal" Rows="30" Columns="100" />

@code {
    private TerminalControl? terminal;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && terminal != null)
        {
            // Draw a welcome box
            terminal.DrawBox(2, 5, 50, 5, BorderStyle.Double, "Welcome");

            // Add a panel with system info
            var panel = new Panel(8, 5, 50, 6, "System Info")
            {
                BorderStyle = BorderStyle.Single
            };
            panel.AddLine("  Platform: Blazor");
            panel.AddLine("  Version: 1.0");
            terminal.DrawPanel(panel);

            // Show a progress bar
            var progress = new ProgressBar(40, 0.5)
            {
                Label = "Processing"
            };
            terminal.DrawProgressBar(15, 5, progress);
        }
    }
}
```

## Architecture

The TerminalGui module is organized as follows:

- **BorderStyle.cs** - Defines border characters for different styles
- **Box.cs** - Utility methods for drawing boxes and lines
- **Panel.cs** - Bordered container component
- **ProgressBar.cs** - Progress indicator component
- **Menu.cs** - Selectable menu component

All components are designed to work seamlessly with the `TerminalControl` component and can be combined to create rich terminal-based user interfaces.

## Inspiration

This module is inspired by terminal UI libraries such as:
- OpenTUI (TypeScript/Zig)
- Blessed (Node.js)
- ncurses (C)
- Spectre.Console (C#)

However, it's built from the ground up for Blazor and provides a Blazor-native API for creating terminal GUIs.
