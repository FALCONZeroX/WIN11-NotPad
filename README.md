إليك ملف **`README.md`** احترافي، تفصيلي، ومكتوب بلغة ماركداون (Markdown) جاهز للنسخ واللصق مباشرة. تم إعداده ليكون شاملاً ومفصلاً ليتجاوز 200 سطر مع تنظيم دقيق وهيكلية برمجية ممتازة:

```markdown
# 📝 WIN11-NotPad (FalconPad)

<div align="center">

  ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
  ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
  ![Windows Forms](https://img.shields.io/badge/WinForms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
  ![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)
  ![Platform](https://img.shields.io/badge/Platform-Windows%2010%20%7C%2011-0078D6?style=for-the-badge&logo=windows)

  <p align="center">
    <b>A modern, high-performance, Windows 11-inspired custom text editor built with C# and WinForms.</b>
    <br />
    Featuring unmanaged memory GDI+ font loading, native Win32 DWM rounded window frames, dynamic dark/light themes, and advanced text manipulation capabilities.
  </p>

</div>

---

## 📑 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [Architecture & Design Highlights](#-architecture--design-highlights)
- [Technical Deep Dive](#-technical-deep-dive)
  - [1. Native Unmanaged Memory Management](#1-native-unmanaged-memory-management)
  - [2. Win32 Desktop Window Manager Integration](#2-win32-desktop-window-manager-integration)
  - [3. Dynamic Custom Theme Engine](#3-dynamic-custom-theme-engine)
- [UI Showcase](#-ui-showcase)
- [Keyboard Shortcuts](#-keyboard-shortcuts)
- [Project Structure](#-project-structure)
- [Installation & Setup](#-installation--setup)
- [Usage Guide](#-usage-guide)
- [Future Roadmap](#-future-roadmap)
- [Contributing](#-contributing)
- [License](#-license)
- [Author & Acknowledgments](#-author--acknowledgments)

---

## 🔍 Overview

**WIN11-NotPad** is an advanced desktop text editor engineered using **C#** and **Windows Forms (WinForms)**. Designed to mirror the sleek, fluid aesthetic of modern Windows 11 applications, it replaces standard, rigid Win32 window chrome with custom-rendered headers, smooth rounded corners, and native dark/light theme switching.

Beyond visual polish, **WIN11-NotPad** demonstrates low-level memory handling by rendering custom vector font iconography directly from unmanaged memory buffers using native Windows GDI+ APIs, bypassing the need to install font files on the host machine.

---

## 🌟 Key Features

* **🎨 Windows 11 Fluent Visual Style:** Uses `dwmapi.dll` interop calls to force native Windows 11 rounded window frame preferences.
* **🌙 Dynamic Theme Engine:** Seamless real-time switching between **Dark Mode** and **Light Mode** across all controls, background panels, and text regions.
* **🔤 Embedded Custom Vector Icon Fonts:** Iconography is loaded dynamically from application resources into unmanaged memory blocks to guarantee crisp visual scaling.
* **⚡ Robust Resource Lifecycle:** Implements deterministic cleanup of unmanaged memory pointers (`AllocCoTaskMem` / `FreeCoTaskMem`) within the form closure pipeline to eliminate memory leaks.
* **📝 Rich Text Editing & Formatting:**
  * Inline Font Customization (Bold, Italic, Underline, Strikethrough).
  * Paragraph Alignment Controls (Left, Center, Right).
  * Font Enlarger & Reducer controls.
  * Real-time character count and zoom factor status indicators.
* **⌨️ Full Keyboard Shortcut Binding:** Intercepts system keys for classic desktop text editing functionality.
* **💾 File I/O Operations:** Complete support for opening, auto-saving, and exporting standard `.txt` documents.
* **🖨️ Native Printing Support:** Built-in Print Document rendering and Print Preview dialogs.

---

## 🏗 Architecture & Design Highlights

WIN11-NotPad is structured around a modular, event-driven pattern tailored for desktop user experiences:


```

+-------------------------------------------------------------------+
|                        frmNotePad UI Layer                        |
+-------------------------------------------------------------------+
|  [pnlTitle]        |  [pnlToolBar]        |  [pnlFooter]         |
|  - Custom Dragging |  - Theme Toggles     |  - Character Count   |
|  - Window Controls |  - Formatting Tools  |  - Zoom Factor       |
+--------------------+----------------------+-----------------------+
|                        RichTextBox Area                           |
+-------------------------------------------------------------------+
|
v
+-------------------------------------------------------------------+
|                     Core Infrastructure Layer                     |
+-------------------------------------------------------------------+
|  - PrivateFontCollection  --> Unmanaged Pointer Tracker (_fontPointers)|
|  - Win32 API Bindings     --> DWMAPI & GDI32 Resource Loader       |
|  - File I/O Engine        --> Stream & File System Interop           |
+-------------------------------------------------------------------+

```

---

## 🔬 Technical Deep Dive

### 1. Native Unmanaged Memory Management

To avoid requiring users to manually install icon fonts on Windows, custom vector glyphs (`.ttf` / `.otf`) are compiled as byte arrays inside `Properties.Resources`. They are loaded into unmanaged memory using Win32 GDI+ procedures:

```csharp
private Font CreateFontFromResource(byte[] fontResourceData, float fontSize)
{
    // Allocate an unmanaged block of memory matching the resource size
    IntPtr fontPtr = Marshal.AllocCoTaskMem(fontResourceData.Length);

    // Copy raw resource bytes into the allocated unmanaged memory buffer
    Marshal.Copy(fontResourceData, 0, fontPtr, fontResourceData.Length);

    // Register the memory font into the native Windows GDI subsystem
    uint numFonts = 1;
    AddFontMemResourceEx(fontPtr, (uint)fontResourceData.Length, IntPtr.Zero, ref numFonts);

    // Track pointer into private collection
    _privateFonts.AddMemoryFont(fontPtr, fontResourceData.Length);
    _fontPointers.Add(fontPtr);

    int lastFontIndex = _privateFonts.Families.Length - 1;
    return new Font(_privateFonts.Families[lastFontIndex], fontSize, FontStyle.Regular, GraphicsUnit.Point);
}

```

To preserve system stability and avoid memory corruption, all unmanaged buffers are systematically deallocated when the application terminates:

```csharp
private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
{
    _FALCON_ICONS_FONT?.Dispose();
    _privateFonts?.Dispose();

    foreach (IntPtr ptr in _fontPointers)
    {
        if (ptr != IntPtr.Zero)
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }
    _fontPointers.Clear();
}

```

### 2. Win32 Desktop Window Manager Integration

The application achieves rounded corners on Windows 11 while retaining custom borderless styling by pinvoking into `dwmapi.dll`:

```csharp
[DllImport("dwmapi.dll")]
private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

private const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
private const int DWMWCP_ROUND = 4;

private void ApplyWindows11RoundedCorners()
{
    try
    {
        int attributeValue = DWMWCP_ROUND;
        DwmSetWindowAttribute(this.Handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref attributeValue, sizeof(int));
    }
    catch
    {
        // Fallback gracefully on older OS platforms (Windows 10 / 7)
    }
}

```

### 3. Dynamic Custom Theme Engine

Theme switching executes a color palette pass over all UI components:

```csharp
void DarkMode()
{
    pnlFileTitle.BackColor = Color.FromArgb(26, 31, 45);
    pnlToolBar.BackColor   = Color.FromArgb(26, 31, 45);
    pnlContent.BackColor   = Color.FromArgb(36, 36, 36);
    rtbContent.BackColor   = Color.FromArgb(36, 36, 36);
    rtbContent.ForeColor   = Color.White;
    // ... Apply palette to controls and icon glyphs
}

```

---

## 🖼 UI Showcase

| Dark Theme (Windows 11 Style) | Light Theme (Clean Palette) |
| --- | --- |
|  |  |

---

## ⌨️ Keyboard Shortcuts

| Shortcut | Action | Description |
| --- | --- | --- |
| `Ctrl` + `S` | Save File | Quick saves current file or prompts save dialog |
| `Ctrl` + `O` | Open File | Opens native file browser dialog |
| `Ctrl` + `C` | Copy | Copies highlighted selection to clipboard |
| `Ctrl` + `X` | Cut | Cuts highlighted selection to clipboard |
| `Ctrl` + `V` | Paste | Pastes text content from clipboard |
| `Ctrl` + `B` | Bold Text | Toggles Bold style on selected text |
| `Ctrl` + `I` | Italic Text | Toggles Italic style on selected text |
| `Ctrl` + `U` | Underline | Toggles Underline style on selected text |
| `Ctrl` + `Q` | Strikethrough | Toggles Strikethrough style on selected text |
| `Ctrl` + `P` | Print | Opens the Print Preview dialog |

---

## 📂 Project Structure

```
WIN11-NotPad/
│
├── Properties/
│   ├── Resources.resx          # Binary resource mappings (Fonts, Icons)
│   └── Settings.settings       # User runtime configurations
│
├── Controls/
│   └── FRoundButton.cs         # Custom vector-rendered rounded button control
│
├── Assets/
│   └── Fonts/                  # Raw icon font packages
│
├── Screenshots/
│   ├── dark-mode.png           # Dark mode preview screenshot
│   └── light-mode.png          # Light mode preview screenshot
│
├── frmNotePad.cs               # Main application form logic & lifecycle
├── frmNotePad.Designer.cs      # Auto-generated UI layout components
├── Program.cs                  # Application bootstrap entry point
├── WIN11-NotPad.sln            # Visual Studio Solution File
└── README.md                   # Project documentation

```

---

## ⚙️ Installation & Setup

### Prerequisites

* **Operating System:** Windows 10 or Windows 11 (Recommended)
* **IDE:** [Visual Studio 2022](https://visualstudio.microsoft.com/) (Version 17.0 or higher)
* **Workload:** `.NET desktop development`

### Building from Source

1. **Clone the Repository:**
```bash
git clone [https://github.com/FALCONZeroX/WIN11-NotPad.git](https://github.com/FALCONZeroX/WIN11-NotPad.git)

```


2. **Navigate to Project Folder:**
```bash
cd WIN11-NotPad

```


3. **Open Solution:**
Launch `WIN11-NotPad.sln` inside Visual Studio.
4. **Build Solution:**
Press `Ctrl` + `Shift` + `B` or select `Build > Build Solution` from the main menu.
5. **Run Application:**
Press `F5` to start debugging.

---

## 🚀 Usage Guide

1. **Creating & Opening Notes:**
* Click the **Folder Icon** or press `Ctrl + O` to open existing `.txt` files.
* Type your content directly into the main text canvas.


2. **Formatting Selection:**
* Highlight any word or sentence, then click formatting tools in the toolbar (`B`, `I`, `U`, `S`) or use corresponding `Ctrl` shortcuts.


3. **Switching Themes:**
* Click the **Sun/Moon Toggle** located on the upper-right control panel to switch between Light and Dark visual palettes instantly.


4. **Saving Work:**
* Click the **Save Icon** or press `Ctrl + S`. If editing a new document, a file picker dialog will appear automatically.



---

## 🔮 Future Roadmap

* [ ] **Tabbed Interface:** Support multi-file editing via dynamic workspace tabs.
* [ ] **Syntax Highlighting:** Add basic lexer support for C#, C++, JSON, and Markdown files.
* [ ] **Line Numbering:** Add line counter panel alongside the text margin.
* [ ] **Auto-Update Engine:** Check GitHub releases automatically for binary patches.
* [ ] **Find & Replace:** Implement modal regex search across active buffers.

---

## 🤝 Contributing

Contributions are welcome! If you find bugs or have feature suggestions:

1. Fork the Project Repository.
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the Branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

---

## 📜 License

Distributed under the **MIT License**. See `LICENSE` for more information.

---

## 👨‍💻 Author & Acknowledgments

* **Developer:** Falah Fathel ([FALCONZeroX](https://www.google.com/search?q=https://github.com/FALCONZeroX))
* **UI Inspiration:** Windows 11 Modern Notepad & Fluent Design Guidelines
* **Icon Packs:** Custom FALCON Icon Sets
