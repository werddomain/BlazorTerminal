# BlazorTerminal

**Work in progress**

A flexible and feature-rich terminal emulator component for Blazor applications, built with C# and designed for WebAssembly. Bring a powerful terminal experience to your web projects with minimal JavaScript interop.

## Overview

BlazorTerminalControl provides a reusable Blazor component that emulates a terminal interface, similar to xterm.js, but with a primary focus on leveraging the .NET ecosystem and Blazor's component model. It's designed to be easily integrated into Blazor WebAssembly and Blazor Server applications, offering a robust API for interaction and customization.

## Features

* **Rich Text Display:** Supports plain text, ANSI escape codes for colors (foreground/background), and text styling (bold, underline, inverse).
* **Input Handling:** Captures keyboard input, including special keys and combinations, and exposes events for application-level processing.
* **Cursor Management:** Accurate cursor positioning, visibility control, and optional blinking/shape customization.
* **Scrolling & Scrollback:** Maintains a configurable scrollback buffer, allowing users to review previous output.
* **Selection & Clipboard:** Basic text selection and copy-to-clipboard functionality.
* **Customizable API:** Programmatically write data, clear the screen, and control terminal options.
* **Theming:** Easy customization of fonts, colors, and overall appearance. Comes with pre-built themes (e.g., dark, light) and allows for custom themes.
* **Performance-Oriented:** Designed for efficient rendering and handling of terminal data streams.
* **Unicode Support:** Aims to correctly render a wide range of Unicode characters.
* **Blazor-Native:** Prioritizes pure C# and Blazor implementation, minimizing JavaScript dependencies.

## Installation

BlazorTerminalControl is available as a NuGet package. You can install it using the .NET CLI or the NuGet Package Manager in Visual Studio.

**Using .NET CLI:**
```bash
dotnet add package YourCompany.Blazor.TerminalControl # Replace with your actual package ID
