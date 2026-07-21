using NotePad.Properties;
using RoundButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
            // Execute the lifecycle steps
            LoadAllFonts();
            DarkMode();

            // Bind the cleanup event to prevent memory corruption/leaks
            this.FormClosed += MainForm_FormClosed;
        }
        //*--------------------------------------------------------------------- *//
        //*              Read And Store Icon Fonts In Memory Attributes          *//
        //*--------------------------------------------------------------------- *//
        // 1. Unified collection to store and manage custom font families
        private PrivateFontCollection _privateFonts = new PrivateFontCollection();

        // 2. Generic font instances that will hold our custom icon fonts
        private Font _FALCON_ICONS_FONT;

        // 3. Track unmanaged memory pointers to guarantee deferred, safe cleanup upon closing
        private List<IntPtr> _fontPointers = new List<IntPtr>();

        // Win32 API to register the memory-resident font into the Windows GDI subsystem
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        //*--------------------------------------------------------------------- *//
        //*                           General Attributes                         *//
        //*--------------------------------------------------------------------- *//
        // Cuurent File Path
        private string currentFilePath = "";

        // Move Window Variables
        private int move;
        private int movX;
        private int movY;

        //*--------------------------------------------------------------------- *//
        //*                          Round Window Attributes                     *//
        //*--------------------------------------------------------------------- *//
        // Call System Function To Customize Window
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        // Static Values for the OS to Round Edges
        private const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;

        // Available Choices:
        // 1 => Default Edges 
        // 2 => Sharp Edges 
        // 3 => Round Edges 
        // 4 => Semi-Round Edges 
        private const int DWMWCP_ROUND = 4;

        //*--------------------------------------------------------------------- *//
        //*             Read And Store Icon Fonts In Memory FUNCIONS             *//
        //*--------------------------------------------------------------------- *//
        /// A generic, reusable method to load a font from resources into unmanaged memory.
        private Font CreateFontFromResource(byte[] fontResourceData, float fontSize)
        {
            // Allocate unmanaged block of memory matching the font size
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontResourceData.Length);

            // Copy the raw byte array into the allocated unmanaged memory pointer
            Marshal.Copy(fontResourceData, 0, fontPtr, fontResourceData.Length);

            // Register the font with the native OS graphics subsystem (explicitly 1 font package)
            uint numFonts = 1;
            AddFontMemResourceEx(fontPtr, (uint)fontResourceData.Length, IntPtr.Zero, ref numFonts);

            // Append the font to our managed PrivateFontCollection
            _privateFonts.AddMemoryFont(fontPtr, fontResourceData.Length);

            // Save pointer reference for bulk cleanup when the application exits
            _fontPointers.Add(fontPtr);

            // Instantiate the Font object using the most recently added index
            int lastFontIndex = _privateFonts.Families.Length - 1;
            return new Font(_privateFonts.Families[lastFontIndex], fontSize, FontStyle.Regular, GraphicsUnit.Point);
        }
        /// PLACEHOLDER A: Load your custom fonts here.
        private void LoadAllFonts()
        {
            // Change 'Properties.Resources.YOUR_FONT' to your actual resource name, and adjust the size (e.g., 24, 32)
            _FALCON_ICONS_FONT = CreateFontFromResource(Properties.Resources.FALCON_Icons_Collection_Pack_1, 15);
        }
        /// PLACEHOLDER B: Bind your fonts and glyphs to your UI controls.
        private void ChangeFontSize(FRoundButton fbutton, int newSize)
        {
            fbutton.Font = new Font(fbutton.Font.FontFamily, newSize, fbutton.Font.Style);
        }
        /// Clean up allocated resources cleanly upon form closure.
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose managed font wrappers
            if (_FALCON_ICONS_FONT != null) _FALCON_ICONS_FONT.Dispose();
            if (_privateFonts != null) _privateFonts.Dispose();

            // Release all unmanaged memory buffers at once
            foreach (IntPtr ptr in _fontPointers)
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(ptr);
                }
            }
            _fontPointers.Clear();
        }
        
        //*--------------------------------------------------------------------- *//
        //*                             CORE FUNCTIONS                           *//
        //*--------------------------------------------------------------------- *//
        //* Window Control Buttons Methods *//
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState |= FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState |= FormWindowState.Minimized;
        }
        //* Move Form Title Methods*//
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }
        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
        //* Export & Emport from File Methods *//
        private void fbtnSaveToFile_Click(object sender, EventArgs e)
        {
            // If The file is already open, save it without dialog 
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                try
                {
                    File.WriteAllText(currentFilePath, rtbContent.Text);
                    return; // End Funcion Here And Avoid Open Dialog
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error When try to Auto Save: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If The File is new (Path Empty), it open Usual Dialog
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text Files|*.txt";
            dialog.FileName = "NewNote.txt";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, rtbContent.Text);

                // Save Current Path
                currentFilePath = dialog.FileName;
                lblFileName.Text = Path.GetFileName(dialog.FileName);
            }
        }
        private void fbtnOpenFromFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text Files|*.txt";

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbContent.Text = File.ReadAllText(dialog.FileName);

                // Store Current File Path
                currentFilePath = dialog.FileName;

                string fileName = Path.GetFileName(dialog.FileName);
                lblFileName.Text = fileName;
            }
        }
        //* Clipboard Operations (Copy - Cut - Paste) *//
        private void fbtnCopy_Click(object sender, EventArgs e)
        {
            // - Copy Only Selected Text After Validation
            // - If You Want to Change The Whole Text use => rbtContent.Text
            if (!string.IsNullOrEmpty(rtbContent.SelectedText))
            {
                Clipboard.SetText(rtbContent.SelectedText);
            }
        }
        private void fbtnPaste_Click(object sender, EventArgs e)
        {
            // Paste In Selected Text Position
            if (Clipboard.ContainsText())
            {
                rtbContent.SelectedText = Clipboard.GetText();
            }
        }
        private void fbtnCut_Click(object sender, EventArgs e)
        {
            //* Cut The Selected Text Method *//
            if (!string.IsNullOrEmpty(rtbContent.SelectedText))
            {
                Clipboard.SetText(rtbContent.SelectedText);
                rtbContent.SelectedText = ""; // Clear Only Selected Text
            }
            //* Cut The Whole Text Method *//
            //if(rtbContent.Text.Length > 0)
            //    Clipboard.SetText(rtbContent.Text);
            //rtbContent.Text = "";
        }
        //* Print Document Methods *//
        private void fbtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbContent.Text, rtbContent.Font, Brushes.Black, new Point(100, 100));
        }
        //* Font Dialog *//
        private void fbtnFont_Click(object sender, EventArgs e)
        {
            var FontDialog = new FontDialog();
            var result = FontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbContent.Font = FontDialog.Font;
            }
        }
        //* Font Customization (Bold - Italic - UnderLine - StrikeOut) *//
        private void fbtnBold_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                FontStyle currentStyle = rtbContent.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Bold;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, newStyle);
            }
        }
        private void fbtnUnderLine_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                FontStyle currentStyle = rtbContent.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Underline;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, newStyle);
            }
        }
        private void fbtnItalic_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                FontStyle currentStyle = rtbContent.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Italic;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, newStyle);
            }
        }
        private void fbtnStrikeOut_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                FontStyle currentStyle = rtbContent.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Strikeout;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, newStyle);
            }
        }
        //* Font Size Methods *//
        private void fbtnFontEnlargment_Click(object sender, EventArgs e)
        {
            var textbox = rtbContent;
            Font currentFont = textbox.SelectionFont ?? textbox.Font;
            float newSize = currentFont.Size + 2;

            if (newSize <= 72)
            {
                textbox.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            }
            //* Another Zoom Method Using Zoom In Rich TextBox *//
            //if (rtbContent.ZoomFactor < 60f)
            //    rtbContent.ZoomFactor += 0.2f;
            //lblZoom.Text = rtbContent.ZoomFactor.ToString();
        }
        private void fbtnFontReducing_Click(object sender, EventArgs e)
        {
            var textbox = rtbContent;
            Font currentFont = textbox.SelectionFont ?? textbox.Font;
            float newSize = currentFont.Size - 2;

            if (newSize >= 8)
            {
                textbox.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            }
            //* Another Zoom Method Using Zoom In Rich TextBox *//
            //if (rtbContent.ZoomFactor > 0.9f)
            //    rtbContent.ZoomFactor -= 0.2f;
            //lblZoom.Text = rtbContent.ZoomFactor.ToString();
        }
        //* Font Alignment Methods (Left - Right - Center) *// 
        private void fbtnLeftAlign_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void fbtnRightAlign_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void fbtnMiddleAlign_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionAlignment = HorizontalAlignment.Center;
        }
        //* RichBox Zoom Methods*//
        private void rtbContent_SizeChanged(object sender, EventArgs e)
        {
            lblZoom.Text = rtbContent.ZoomFactor.ToString();
        }
        private void rtbContent_Resize(object sender, EventArgs e)
        {
            lblZoom.Text = rtbContent.ZoomFactor.ToString();

        }
        private void rtbContent_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            lblZoom.Text = rtbContent.ZoomFactor.ToString();

        }
        //* Character Text Length *//
        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            lblCharacterSize.Text = rtbContent.Text.Length.ToString() + " Characters";
        }
        //* Form Load Method *//
        private void frmNotePad_Load(object sender, EventArgs e)
        {
            lblCharacterSize.Text = rtbContent.Text.Length.ToString() + " Characters";

            //* Round Screen Border Code *//
            try
            {
                int attributeValue = DWMWCP_ROUND; // يمكنك تجربة القيمة 4 لحواف دائرية أنعم وأصغر
                DwmSetWindowAttribute(this.Handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref attributeValue, sizeof(int));
            }
            catch
            {

            }
        }
        //* Title Tab Icon Change Methods *//
        private void fbtnFileNameOption_MouseEnter(object sender, EventArgs e)
        {
            fbtnFileNameOption.Font = _FALCON_ICONS_FONT;
            fbtnFileNameOption.Text = "\ueF60";
        }
        private void fbtnFileNameOption_MouseLeave(object sender, EventArgs e)
        {
            fbtnFileNameOption.Font = _FALCON_ICONS_FONT;
            ChangeFontSize((FRoundButton)sender, 9);
            fbtnFileNameOption.Text = "\ueF53";
        }
        //* Shortcut Method *//
        private void frmNotePad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Save Using Ctrl + S
                fbtnSaveToFile_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.O) // Open Using Ctrl + O
                fbtnOpenFromFile_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.X) // Cut Using Ctrl + X
                fbtnCut_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.C) // Copy Using Ctrl + C
                fbtnCopy_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.V) // Paste Using Ctrl + V
            {
                fbtnPaste_Click(sender, e);
                e.SuppressKeyPress = true; // Suppress Repeated Calling 
            }

            if (e.Control && e.KeyCode == Keys.I) // Italic Using Ctrl + I
                fbtnItalic_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.B) // Bold Using Ctrl + B
                fbtnBold_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.U) // UnderLine Using Ctrl + U
                fbtnUnderLine_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.Q) // StrikeOut Using Ctrl + Q
                fbtnStrikeOut_Click(sender, e);

            if (e.Control && e.KeyCode == Keys.P) // Print Using Ctrl + P
                fbtnPrint_Click(sender, e);
        }
        //* Theme Mehods *//
        void DayMode()
        {
            // Theme Controls
            pnlThemeMode.BackColor = Color.Black;
            fbtnNightMode.BackColor = Color.Black;
            fbtnDayMode.BackColor = Color.White;

            // Set Icon Font
            fbtnUnderLine.Font = btnMinimize.Font = btnMaximize.Font
                = btnExit.Font = fbtnFileNameOption.Font = fbtnAddNewTab.Font
                = fbtnMiddleAlign.Font = fbtnLeftAlign.Font = fbtnStrikeOut.Font
                = fbtnRightAlign.Font = fbtnBold.Font = fbtnItalic.Font = fbtnFont.Font
                = fbtnPrint.Font = fbtnCut.Font = fbtnPaste.Font = fbtnCopy.Font
                = fbtnDayMode.Font = fbtnOpenFromFile.Font = fbtnSaveToFile.Font
                = fbtnNightMode.Font = _FALCON_ICONS_FONT;

            // Set Icon Color
            fbtnUnderLine.ForeColor = fbtnStrikeOut.ForeColor = fbtnItalic.ForeColor
                = fbtnFont.ForeColor = fbtnBold.ForeColor = fbtnRightAlign.ForeColor
                = fbtnAddNewTab.ForeColor = fbtnMiddleAlign.ForeColor = fbtnLeftAlign.ForeColor
                = btnExit.ForeColor = fbtnFileNameOption.ForeColor
                = fbtnPaste.ForeColor = fbtnCut.ForeColor = fbtnCopy.ForeColor = btnMinimize.ForeColor
                = fbtnOpenFromFile.ForeColor = fbtnSaveToFile.ForeColor = fbtnPrint.ForeColor
                = fbtnDayMode.ForeColor = Color.Black;
            fbtnNightMode.ForeColor = Color.White;

            // Set buttons MouseOverBackColor
            fbtnBold.FlatAppearance.MouseOverBackColor = fbtnStrikeOut.FlatAppearance.MouseOverBackColor
                = fbtnStrikeOut.FlatAppearance.MouseOverBackColor = fbtnItalic.FlatAppearance.MouseOverBackColor
                = fbtnUnderLine.FlatAppearance.MouseOverBackColor = fbtnFontEnlargment.FlatAppearance.MouseOverBackColor
                = fbtnFontReducing.FlatAppearance.MouseOverBackColor = fbtnFont.FlatAppearance.MouseOverBackColor
                = fbtnRightAlign.FlatAppearance.MouseOverBackColor = fbtnMiddleAlign.FlatAppearance.MouseOverBackColor
                = fbtnLeftAlign.FlatAppearance.MouseOverBackColor = fbtnCopy.FlatAppearance.MouseOverBackColor
                = fbtnCut.FlatAppearance.MouseOverBackColor = fbtnPaste.FlatAppearance.MouseOverBackColor
                = fbtnPrint.FlatAppearance.MouseOverBackColor = fbtnSaveToFile.FlatAppearance.MouseOverBackColor
                = fbtnOpenFromFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);

            // Windows Controls
            btnExit.Text = "\ueF60";
            btnMinimize.Text = "\ue984";
            btnMinimize.Font = new Font(btnMinimize.Font.FontFamily, 11, btnMinimize.Font.Style);
            btnMaximize.Image = Resources.Max_Dark;

            // Toolbar Controls
            fbtnUnderLine.Text = "\ue903";
            fbtnStrikeOut.Text = "\ueAA8";
            fbtnItalic.Text = "\ueDBF";
            fbtnFont.Text = "\ueEC7";
            fbtnBold.Text = "\ueFE9";

            fbtnRightAlign.Text = "\uF0B3";
            fbtnLeftAlign.Text = "\uF0B0";
            fbtnMiddleAlign.Text = "\uF0B2";

            fbtnAddNewTab.Text = "\uF0AA";

            ChangeFontSize(fbtnFileNameOption, 9);
            fbtnFileNameOption.Text = "\ueF53";

            fbtnCopy.Text = "\uef9b";
            fbtnPaste.Text = "\uec39";
            fbtnCut.Text = "\uefad";

            fbtnPrint.Text = "\uecc0";
            fbtnSaveToFile.Text = "\ue9e7";
            fbtnOpenFromFile.Text = "\ueec0";

            fbtnDayMode.Text = "\ueab1";
            fbtnNightMode.Text = "\uef6a";

            // Header
            pnlFileTitle.BackColor = Color.FromArgb(242, 244, 249);
            lblFileName.ForeColor = Color.Black;
            pnlTitle.BackColor = Color.FromArgb(211, 218, 236);
            fbtnAddNewTab.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);

            // Toolbar
            pnlToolBar.BackColor = Color.FromArgb(242, 244, 249);

            fbtnFontEnlargment.Image = Resources.increase_dark;
            fbtnFontReducing.Image = Resources.decrease_dark;

            // Footer
            pnlFooter.BackColor = Color.FromArgb(242, 244, 249);
            lblCoding.ForeColor = Color.Black;
            lblCharacterSize.ForeColor = Color.Black;
            lblLine.ForeColor = Color.Black;
            lblPlainText.ForeColor = Color.Black;
            lblUnix.ForeColor = Color.Black;
            lblZoom.ForeColor = Color.Black;
            pbFooterPad1.Image = Resources.seperator_Dark;
            pbFooterPad2.Image = Resources.seperator_Dark;
            pbFooterPad3.Image = Resources.seperator_Dark;
            pbFooterPad4.Image = Resources.seperator_Dark;
            pbFooterPad5.Image = Resources.seperator_Dark;

            // Content (Body)
            pnlContent.BackColor = Color.FromArgb(249, 249, 249);
            rtbContent.BackColor = Color.FromArgb(249, 249, 249);
            rtbContent.ForeColor = Color.Black;
        }
        void DarkMode()
        {
            // Theme Controls
            pnlThemeMode.BackColor = Color.White;
            fbtnNightMode.BackColor = Color.Black;
            fbtnDayMode.BackColor = Color.White;

            // Set Icon Font
            fbtnUnderLine.Font = btnMinimize.Font = btnMaximize.Font
                = btnExit.Font = fbtnFileNameOption.Font = fbtnAddNewTab.Font
                = fbtnMiddleAlign.Font = fbtnLeftAlign.Font = fbtnStrikeOut.Font
                = fbtnRightAlign.Font = fbtnBold.Font = fbtnItalic.Font = fbtnFont.Font
                = fbtnPrint.Font = fbtnCut.Font = fbtnPaste.Font = fbtnCopy.Font
                = fbtnDayMode.Font = fbtnOpenFromFile.Font = fbtnSaveToFile.Font
                = fbtnNightMode.Font = _FALCON_ICONS_FONT;

            // Set Icon Color
            fbtnUnderLine.ForeColor = fbtnStrikeOut.ForeColor = fbtnItalic.ForeColor
                = fbtnFont.ForeColor = fbtnBold.ForeColor = fbtnRightAlign.ForeColor 
                = fbtnAddNewTab.ForeColor = fbtnMiddleAlign.ForeColor = fbtnLeftAlign.ForeColor 
                = btnExit.ForeColor = fbtnFileNameOption.ForeColor
                = fbtnPaste.ForeColor = fbtnCut.ForeColor = fbtnCopy.ForeColor = btnMinimize.ForeColor 
                = fbtnOpenFromFile.ForeColor = fbtnSaveToFile.ForeColor = fbtnPrint.ForeColor 
                = fbtnNightMode.ForeColor = Color.White;
            fbtnDayMode.ForeColor = Color.Black;

            // Set buttons MouseOverBackColor
            fbtnBold.FlatAppearance.MouseOverBackColor = fbtnStrikeOut.FlatAppearance.MouseOverBackColor
                = fbtnStrikeOut.FlatAppearance.MouseOverBackColor = fbtnItalic.FlatAppearance.MouseOverBackColor
                = fbtnUnderLine.FlatAppearance.MouseOverBackColor = fbtnFontEnlargment.FlatAppearance.MouseOverBackColor
                = fbtnFontReducing.FlatAppearance.MouseOverBackColor = fbtnFont.FlatAppearance.MouseOverBackColor
                = fbtnRightAlign.FlatAppearance.MouseOverBackColor = fbtnMiddleAlign.FlatAppearance.MouseOverBackColor
                = fbtnLeftAlign.FlatAppearance.MouseOverBackColor = fbtnCopy.FlatAppearance.MouseOverBackColor
                = fbtnCut.FlatAppearance.MouseOverBackColor = fbtnPaste.FlatAppearance.MouseOverBackColor
                = fbtnPrint.FlatAppearance.MouseOverBackColor = fbtnSaveToFile.FlatAppearance.MouseOverBackColor
                = fbtnOpenFromFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 48, 54);


            // Windows Controls
            btnExit.Text = "\ueF60";
            btnMinimize.Font = new Font(btnMinimize.Font.FontFamily, 11, btnMinimize.Font.Style);
            btnMinimize.Text = "\ue984";
            btnMaximize.Image = Resources.Max;

            // Toolbar Controls
            fbtnUnderLine.Text = "\ue903";
            fbtnStrikeOut.Text = "\ueAA8";
            fbtnItalic.Text = "\ueDBF";
            fbtnFont.Text = "\ueEC7";
            fbtnBold.Text = "\ueFE9";

            fbtnRightAlign.Text = "\uF0B3";
            fbtnLeftAlign.Text = "\uF0B0";
            fbtnMiddleAlign.Text = "\uF0B2";

            fbtnAddNewTab.Text = "\uF0AA";

            ChangeFontSize(fbtnFileNameOption, 9);
            fbtnFileNameOption.Text = "\ueF53";

            fbtnCopy.Text = "\uef9b";
            fbtnPaste.Text = "\uec39";
            fbtnCut.Text = "\uefad";

            fbtnPrint.Text = "\uecc0";
            fbtnSaveToFile.Text = "\ue9e7";
            fbtnOpenFromFile.Text = "\ueec0";

            fbtnDayMode.Text = "\ueab1";
            fbtnNightMode.Text = "\uef6a";

            // Header
            pnlFileTitle.BackColor = Color.FromArgb(26, 31, 45);
            lblFileName.ForeColor = Color.White;
            pnlTitle.BackColor = Color.FromArgb(0, 10, 35);

            // Toolbar
            pnlToolBar.BackColor = Color.FromArgb(26, 31, 45);
            fbtnFontEnlargment.Image = Resources.increase;
            fbtnFontReducing.Image = Resources.decrease;

            // Footer
            pnlFooter.BackColor = Color.FromArgb(26, 31, 49);
            lblCoding.ForeColor = Color.White;
            lblCharacterSize.ForeColor = Color.White;
            lblLine.ForeColor = Color.White;
            lblPlainText.ForeColor = Color.White;
            lblUnix.ForeColor = Color.White;
            lblZoom.ForeColor = Color.White;
            pbFooterPad1.Image = Resources.seperator;
            pbFooterPad2.Image = Resources.seperator;
            pbFooterPad3.Image = Resources.seperator;
            pbFooterPad4.Image = Resources.seperator;
            pbFooterPad5.Image = Resources.seperator;

            // Content (Body)
            pnlContent.BackColor = Color.FromArgb(36, 36, 36);
            rtbContent.BackColor = Color.FromArgb(36, 36, 36);
            rtbContent.ForeColor = Color.White;
        }
        private void fbtnDayMode_Click(object sender, EventArgs e)
        {
            DayMode();
        }
        private void fbtnNightMode_Click(object sender, EventArgs e)
        {
            DarkMode();
        }
    }
}