using RoundPanel;

namespace NotePad
{
    partial class frmNotePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotePad));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.fbtnAddNewTab = new RoundButton.FRoundButton();
            this.pnlFileTitle = new System.Windows.Forms.Panel();
            this.fbtnFileNameOption = new RoundButton.FRoundButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblCoding = new System.Windows.Forms.Label();
            this.pbFooterPad5 = new System.Windows.Forms.PictureBox();
            this.lblUnix = new System.Windows.Forms.Label();
            this.pbFooterPad4 = new System.Windows.Forms.PictureBox();
            this.lblZoom = new System.Windows.Forms.Label();
            this.pbFooterPad3 = new System.Windows.Forms.PictureBox();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.pbFooterPad2 = new System.Windows.Forms.PictureBox();
            this.lblCharacterSize = new System.Windows.Forms.Label();
            this.pbFooterPad1 = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.fbtnOpenFromFile = new RoundButton.FRoundButton();
            this.fbtnSaveToFile = new RoundButton.FRoundButton();
            this.fbtnPrint = new RoundButton.FRoundButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.fbtnCut = new RoundButton.FRoundButton();
            this.fbtnPaste = new RoundButton.FRoundButton();
            this.fbtnCopy = new RoundButton.FRoundButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.fbtnLeftAlign = new RoundButton.FRoundButton();
            this.fbtnMiddleAlign = new RoundButton.FRoundButton();
            this.fbtnRightAlign = new RoundButton.FRoundButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fbtnFont = new RoundButton.FRoundButton();
            this.fbtnFontReducing = new RoundButton.FRoundButton();
            this.fbtnFontEnlargment = new RoundButton.FRoundButton();
            this.fbtnUnderLine = new RoundButton.FRoundButton();
            this.fbtnBold = new RoundButton.FRoundButton();
            this.fbtnItalic = new RoundButton.FRoundButton();
            this.fbtnStrikeOut = new RoundButton.FRoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlThemeMode = new RoundPanel.FRoundPanel();
            this.fbtnDayMode = new RoundButton.FRoundButton();
            this.fbtnNightMode = new RoundButton.FRoundButton();
            this.pbPadding = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlTitle.SuspendLayout();
            this.pnlFileTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad1)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlThemeMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPadding)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.pnlTitle.Controls.Add(this.fbtnAddNewTab);
            this.pnlTitle.Controls.Add(this.pnlFileTitle);
            this.pnlTitle.Controls.Add(this.pbAppIcon);
            this.pnlTitle.Controls.Add(this.btnMinimize);
            this.pnlTitle.Controls.Add(this.btnMaximize);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1228, 53);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // fbtnAddNewTab
            // 
            this.fbtnAddNewTab.BackColor = System.Drawing.Color.Transparent;
            this.fbtnAddNewTab.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnAddNewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbtnAddNewTab.BorderRadius = 22;
            this.fbtnAddNewTab.BorderSize = 0;
            this.fbtnAddNewTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.fbtnAddNewTab.FlatAppearance.BorderSize = 0;
            this.fbtnAddNewTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnAddNewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnAddNewTab.ForeColor = System.Drawing.Color.White;
            this.fbtnAddNewTab.Location = new System.Drawing.Point(467, 0);
            this.fbtnAddNewTab.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnAddNewTab.Name = "fbtnAddNewTab";
            this.fbtnAddNewTab.Size = new System.Drawing.Size(62, 53);
            this.fbtnAddNewTab.TabIndex = 14;
            this.fbtnAddNewTab.TextColor = System.Drawing.Color.White;
            this.fbtnAddNewTab.UseVisualStyleBackColor = false;
            // 
            // pnlFileTitle
            // 
            this.pnlFileTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.pnlFileTitle.Controls.Add(this.fbtnFileNameOption);
            this.pnlFileTitle.Controls.Add(this.lblFileName);
            this.pnlFileTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFileTitle.Location = new System.Drawing.Point(68, 0);
            this.pnlFileTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFileTitle.Name = "pnlFileTitle";
            this.pnlFileTitle.Size = new System.Drawing.Size(399, 53);
            this.pnlFileTitle.TabIndex = 13;
            // 
            // fbtnFileNameOption
            // 
            this.fbtnFileNameOption.BackColor = System.Drawing.Color.Transparent;
            this.fbtnFileNameOption.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnFileNameOption.BorderRadius = 22;
            this.fbtnFileNameOption.BorderSize = 0;
            this.fbtnFileNameOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.fbtnFileNameOption.FlatAppearance.BorderSize = 0;
            this.fbtnFileNameOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnFileNameOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFileNameOption.ForeColor = System.Drawing.Color.White;
            this.fbtnFileNameOption.Location = new System.Drawing.Point(336, 0);
            this.fbtnFileNameOption.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFileNameOption.Name = "fbtnFileNameOption";
            this.fbtnFileNameOption.Size = new System.Drawing.Size(62, 53);
            this.fbtnFileNameOption.TabIndex = 15;
            this.fbtnFileNameOption.TextColor = System.Drawing.Color.White;
            this.fbtnFileNameOption.UseVisualStyleBackColor = false;
            this.fbtnFileNameOption.MouseEnter += new System.EventHandler(this.fbtnFileNameOption_MouseEnter);
            this.fbtnFileNameOption.MouseLeave += new System.EventHandler(this.fbtnFileNameOption_MouseLeave);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFileName.Font = new System.Drawing.Font("JetBrains Mono NL Medium", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(0, 0);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(336, 53);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "NewNote.txt";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAppIcon.Image = global::NotePad.Properties.Resources.NotePad_in;
            this.pbAppIcon.Location = new System.Drawing.Point(0, 0);
            this.pbAppIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.Size = new System.Drawing.Size(68, 53);
            this.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAppIcon.TabIndex = 8;
            this.pbAppIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1012, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(72, 53);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::NotePad.Properties.Resources.Max;
            this.btnMaximize.Location = new System.Drawing.Point(1084, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(75, 53);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1159, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.pnlFooter.Controls.Add(this.lblCoding);
            this.pnlFooter.Controls.Add(this.pbFooterPad5);
            this.pnlFooter.Controls.Add(this.lblUnix);
            this.pnlFooter.Controls.Add(this.pbFooterPad4);
            this.pnlFooter.Controls.Add(this.lblZoom);
            this.pnlFooter.Controls.Add(this.pbFooterPad3);
            this.pnlFooter.Controls.Add(this.lblPlainText);
            this.pnlFooter.Controls.Add(this.pbFooterPad2);
            this.pnlFooter.Controls.Add(this.lblCharacterSize);
            this.pnlFooter.Controls.Add(this.pbFooterPad1);
            this.pnlFooter.Controls.Add(this.lblLine);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 639);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1228, 45);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblCoding
            // 
            this.lblCoding.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoding.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoding.ForeColor = System.Drawing.Color.White;
            this.lblCoding.Location = new System.Drawing.Point(1008, 0);
            this.lblCoding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCoding.Size = new System.Drawing.Size(146, 45);
            this.lblCoding.TabIndex = 33;
            this.lblCoding.Text = "UTF-8";
            this.lblCoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFooterPad5
            // 
            this.pbFooterPad5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFooterPad5.Image = global::NotePad.Properties.Resources.seperator;
            this.pbFooterPad5.Location = new System.Drawing.Point(960, 0);
            this.pbFooterPad5.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooterPad5.Name = "pbFooterPad5";
            this.pbFooterPad5.Size = new System.Drawing.Size(48, 45);
            this.pbFooterPad5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFooterPad5.TabIndex = 32;
            this.pbFooterPad5.TabStop = false;
            // 
            // lblUnix
            // 
            this.lblUnix.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUnix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnix.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnix.ForeColor = System.Drawing.Color.White;
            this.lblUnix.Location = new System.Drawing.Point(818, 0);
            this.lblUnix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnix.Name = "lblUnix";
            this.lblUnix.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUnix.Size = new System.Drawing.Size(142, 45);
            this.lblUnix.TabIndex = 30;
            this.lblUnix.Text = "Unix (LF)";
            this.lblUnix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFooterPad4
            // 
            this.pbFooterPad4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFooterPad4.Image = global::NotePad.Properties.Resources.seperator;
            this.pbFooterPad4.Location = new System.Drawing.Point(770, 0);
            this.pbFooterPad4.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooterPad4.Name = "pbFooterPad4";
            this.pbFooterPad4.Size = new System.Drawing.Size(48, 45);
            this.pbFooterPad4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFooterPad4.TabIndex = 29;
            this.pbFooterPad4.TabStop = false;
            // 
            // lblZoom
            // 
            this.lblZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblZoom.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.ForeColor = System.Drawing.Color.White;
            this.lblZoom.Location = new System.Drawing.Point(650, 0);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblZoom.Size = new System.Drawing.Size(120, 45);
            this.lblZoom.TabIndex = 26;
            this.lblZoom.Text = "100%";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFooterPad3
            // 
            this.pbFooterPad3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFooterPad3.Image = global::NotePad.Properties.Resources.seperator;
            this.pbFooterPad3.Location = new System.Drawing.Point(602, 0);
            this.pbFooterPad3.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooterPad3.Name = "pbFooterPad3";
            this.pbFooterPad3.Size = new System.Drawing.Size(48, 45);
            this.pbFooterPad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFooterPad3.TabIndex = 25;
            this.pbFooterPad3.TabStop = false;
            // 
            // lblPlainText
            // 
            this.lblPlainText.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPlainText.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.ForeColor = System.Drawing.Color.White;
            this.lblPlainText.Location = new System.Drawing.Point(446, 0);
            this.lblPlainText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPlainText.Size = new System.Drawing.Size(156, 45);
            this.lblPlainText.TabIndex = 21;
            this.lblPlainText.Text = "PlainText";
            this.lblPlainText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFooterPad2
            // 
            this.pbFooterPad2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFooterPad2.Image = global::NotePad.Properties.Resources.seperator;
            this.pbFooterPad2.Location = new System.Drawing.Point(398, 0);
            this.pbFooterPad2.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooterPad2.Name = "pbFooterPad2";
            this.pbFooterPad2.Size = new System.Drawing.Size(48, 45);
            this.pbFooterPad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFooterPad2.TabIndex = 19;
            this.pbFooterPad2.TabStop = false;
            // 
            // lblCharacterSize
            // 
            this.lblCharacterSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCharacterSize.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterSize.ForeColor = System.Drawing.Color.White;
            this.lblCharacterSize.Location = new System.Drawing.Point(208, 0);
            this.lblCharacterSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharacterSize.Name = "lblCharacterSize";
            this.lblCharacterSize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCharacterSize.Size = new System.Drawing.Size(190, 45);
            this.lblCharacterSize.TabIndex = 14;
            this.lblCharacterSize.Text = "2,939 Character";
            this.lblCharacterSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFooterPad1
            // 
            this.pbFooterPad1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFooterPad1.Image = global::NotePad.Properties.Resources.seperator;
            this.pbFooterPad1.Location = new System.Drawing.Point(160, 0);
            this.pbFooterPad1.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooterPad1.Name = "pbFooterPad1";
            this.pbFooterPad1.Size = new System.Drawing.Size(48, 45);
            this.pbFooterPad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFooterPad1.TabIndex = 13;
            this.pbFooterPad1.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLine.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(0, 0);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblLine.Size = new System.Drawing.Size(160, 45);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "Ln 2, Col 23";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.pnlToolBar.Controls.Add(this.fbtnOpenFromFile);
            this.pnlToolBar.Controls.Add(this.fbtnSaveToFile);
            this.pnlToolBar.Controls.Add(this.fbtnPrint);
            this.pnlToolBar.Controls.Add(this.pictureBox4);
            this.pnlToolBar.Controls.Add(this.fbtnCut);
            this.pnlToolBar.Controls.Add(this.fbtnPaste);
            this.pnlToolBar.Controls.Add(this.fbtnCopy);
            this.pnlToolBar.Controls.Add(this.pictureBox3);
            this.pnlToolBar.Controls.Add(this.fbtnLeftAlign);
            this.pnlToolBar.Controls.Add(this.fbtnMiddleAlign);
            this.pnlToolBar.Controls.Add(this.fbtnRightAlign);
            this.pnlToolBar.Controls.Add(this.pictureBox2);
            this.pnlToolBar.Controls.Add(this.fbtnFont);
            this.pnlToolBar.Controls.Add(this.fbtnFontReducing);
            this.pnlToolBar.Controls.Add(this.fbtnFontEnlargment);
            this.pnlToolBar.Controls.Add(this.fbtnUnderLine);
            this.pnlToolBar.Controls.Add(this.fbtnBold);
            this.pnlToolBar.Controls.Add(this.fbtnItalic);
            this.pnlToolBar.Controls.Add(this.fbtnStrikeOut);
            this.pnlToolBar.Controls.Add(this.pictureBox1);
            this.pnlToolBar.Controls.Add(this.pnlThemeMode);
            this.pnlToolBar.Controls.Add(this.pbPadding);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 53);
            this.pnlToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1228, 53);
            this.pnlToolBar.TabIndex = 3;
            // 
            // fbtnOpenFromFile
            // 
            this.fbtnOpenFromFile.BackColor = System.Drawing.Color.Transparent;
            this.fbtnOpenFromFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnOpenFromFile.BorderRadius = 22;
            this.fbtnOpenFromFile.BorderSize = 0;
            this.fbtnOpenFromFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnOpenFromFile.FlatAppearance.BorderSize = 0;
            this.fbtnOpenFromFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnOpenFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnOpenFromFile.ForeColor = System.Drawing.Color.White;
            this.fbtnOpenFromFile.Location = new System.Drawing.Point(13, 0);
            this.fbtnOpenFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnOpenFromFile.Name = "fbtnOpenFromFile";
            this.fbtnOpenFromFile.Size = new System.Drawing.Size(62, 53);
            this.fbtnOpenFromFile.TabIndex = 89;
            this.fbtnOpenFromFile.TextColor = System.Drawing.Color.White;
            this.fbtnOpenFromFile.UseVisualStyleBackColor = false;
            this.fbtnOpenFromFile.Click += new System.EventHandler(this.fbtnOpenFromFile_Click);
            // 
            // fbtnSaveToFile
            // 
            this.fbtnSaveToFile.BackColor = System.Drawing.Color.Transparent;
            this.fbtnSaveToFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnSaveToFile.BorderRadius = 22;
            this.fbtnSaveToFile.BorderSize = 0;
            this.fbtnSaveToFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnSaveToFile.FlatAppearance.BorderSize = 0;
            this.fbtnSaveToFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnSaveToFile.ForeColor = System.Drawing.Color.White;
            this.fbtnSaveToFile.Location = new System.Drawing.Point(75, 0);
            this.fbtnSaveToFile.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnSaveToFile.Name = "fbtnSaveToFile";
            this.fbtnSaveToFile.Size = new System.Drawing.Size(62, 53);
            this.fbtnSaveToFile.TabIndex = 88;
            this.fbtnSaveToFile.TextColor = System.Drawing.Color.White;
            this.fbtnSaveToFile.UseVisualStyleBackColor = false;
            this.fbtnSaveToFile.Click += new System.EventHandler(this.fbtnSaveToFile_Click);
            // 
            // fbtnPrint
            // 
            this.fbtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.fbtnPrint.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnPrint.BorderRadius = 22;
            this.fbtnPrint.BorderSize = 0;
            this.fbtnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnPrint.FlatAppearance.BorderSize = 0;
            this.fbtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnPrint.ForeColor = System.Drawing.Color.White;
            this.fbtnPrint.Location = new System.Drawing.Point(137, 0);
            this.fbtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnPrint.Name = "fbtnPrint";
            this.fbtnPrint.Size = new System.Drawing.Size(62, 53);
            this.fbtnPrint.TabIndex = 87;
            this.fbtnPrint.TextColor = System.Drawing.Color.White;
            this.fbtnPrint.UseVisualStyleBackColor = false;
            this.fbtnPrint.Click += new System.EventHandler(this.fbtnPrint_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Location = new System.Drawing.Point(199, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 53);
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            // 
            // fbtnCut
            // 
            this.fbtnCut.BackColor = System.Drawing.Color.Transparent;
            this.fbtnCut.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnCut.BorderRadius = 22;
            this.fbtnCut.BorderSize = 0;
            this.fbtnCut.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnCut.FlatAppearance.BorderSize = 0;
            this.fbtnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnCut.ForeColor = System.Drawing.Color.White;
            this.fbtnCut.Location = new System.Drawing.Point(219, 0);
            this.fbtnCut.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnCut.Name = "fbtnCut";
            this.fbtnCut.Size = new System.Drawing.Size(62, 53);
            this.fbtnCut.TabIndex = 82;
            this.fbtnCut.TextColor = System.Drawing.Color.White;
            this.fbtnCut.UseVisualStyleBackColor = false;
            this.fbtnCut.Click += new System.EventHandler(this.fbtnCut_Click);
            // 
            // fbtnPaste
            // 
            this.fbtnPaste.BackColor = System.Drawing.Color.Transparent;
            this.fbtnPaste.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnPaste.BorderRadius = 22;
            this.fbtnPaste.BorderSize = 0;
            this.fbtnPaste.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnPaste.FlatAppearance.BorderSize = 0;
            this.fbtnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnPaste.ForeColor = System.Drawing.Color.White;
            this.fbtnPaste.Location = new System.Drawing.Point(281, 0);
            this.fbtnPaste.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnPaste.Name = "fbtnPaste";
            this.fbtnPaste.Size = new System.Drawing.Size(62, 53);
            this.fbtnPaste.TabIndex = 81;
            this.fbtnPaste.TextColor = System.Drawing.Color.White;
            this.fbtnPaste.UseVisualStyleBackColor = false;
            this.fbtnPaste.Click += new System.EventHandler(this.fbtnPaste_Click);
            // 
            // fbtnCopy
            // 
            this.fbtnCopy.BackColor = System.Drawing.Color.Transparent;
            this.fbtnCopy.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnCopy.BorderRadius = 22;
            this.fbtnCopy.BorderSize = 0;
            this.fbtnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnCopy.FlatAppearance.BorderSize = 0;
            this.fbtnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnCopy.ForeColor = System.Drawing.Color.White;
            this.fbtnCopy.Location = new System.Drawing.Point(343, 0);
            this.fbtnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnCopy.Name = "fbtnCopy";
            this.fbtnCopy.Size = new System.Drawing.Size(62, 53);
            this.fbtnCopy.TabIndex = 80;
            this.fbtnCopy.TextColor = System.Drawing.Color.White;
            this.fbtnCopy.UseVisualStyleBackColor = false;
            this.fbtnCopy.Click += new System.EventHandler(this.fbtnCopy_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(405, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 53);
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // fbtnLeftAlign
            // 
            this.fbtnLeftAlign.BackColor = System.Drawing.Color.Transparent;
            this.fbtnLeftAlign.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnLeftAlign.BorderRadius = 22;
            this.fbtnLeftAlign.BorderSize = 0;
            this.fbtnLeftAlign.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnLeftAlign.FlatAppearance.BorderSize = 0;
            this.fbtnLeftAlign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnLeftAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnLeftAlign.ForeColor = System.Drawing.Color.White;
            this.fbtnLeftAlign.Location = new System.Drawing.Point(425, 0);
            this.fbtnLeftAlign.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnLeftAlign.Name = "fbtnLeftAlign";
            this.fbtnLeftAlign.Size = new System.Drawing.Size(62, 53);
            this.fbtnLeftAlign.TabIndex = 70;
            this.fbtnLeftAlign.TextColor = System.Drawing.Color.White;
            this.fbtnLeftAlign.UseVisualStyleBackColor = false;
            this.fbtnLeftAlign.Click += new System.EventHandler(this.fbtnLeftAlign_Click);
            // 
            // fbtnMiddleAlign
            // 
            this.fbtnMiddleAlign.BackColor = System.Drawing.Color.Transparent;
            this.fbtnMiddleAlign.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnMiddleAlign.BorderRadius = 22;
            this.fbtnMiddleAlign.BorderSize = 0;
            this.fbtnMiddleAlign.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnMiddleAlign.FlatAppearance.BorderSize = 0;
            this.fbtnMiddleAlign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnMiddleAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnMiddleAlign.ForeColor = System.Drawing.Color.White;
            this.fbtnMiddleAlign.Location = new System.Drawing.Point(487, 0);
            this.fbtnMiddleAlign.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnMiddleAlign.Name = "fbtnMiddleAlign";
            this.fbtnMiddleAlign.Size = new System.Drawing.Size(62, 53);
            this.fbtnMiddleAlign.TabIndex = 69;
            this.fbtnMiddleAlign.TextColor = System.Drawing.Color.White;
            this.fbtnMiddleAlign.UseVisualStyleBackColor = false;
            this.fbtnMiddleAlign.Click += new System.EventHandler(this.fbtnMiddleAlign_Click);
            // 
            // fbtnRightAlign
            // 
            this.fbtnRightAlign.BackColor = System.Drawing.Color.Transparent;
            this.fbtnRightAlign.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnRightAlign.BorderRadius = 22;
            this.fbtnRightAlign.BorderSize = 0;
            this.fbtnRightAlign.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnRightAlign.FlatAppearance.BorderSize = 0;
            this.fbtnRightAlign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnRightAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnRightAlign.ForeColor = System.Drawing.Color.White;
            this.fbtnRightAlign.Location = new System.Drawing.Point(549, 0);
            this.fbtnRightAlign.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnRightAlign.Name = "fbtnRightAlign";
            this.fbtnRightAlign.Size = new System.Drawing.Size(62, 53);
            this.fbtnRightAlign.TabIndex = 68;
            this.fbtnRightAlign.TextColor = System.Drawing.Color.White;
            this.fbtnRightAlign.UseVisualStyleBackColor = false;
            this.fbtnRightAlign.Click += new System.EventHandler(this.fbtnRightAlign_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(611, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 53);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // fbtnFont
            // 
            this.fbtnFont.BackColor = System.Drawing.Color.Transparent;
            this.fbtnFont.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnFont.BorderRadius = 22;
            this.fbtnFont.BorderSize = 0;
            this.fbtnFont.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnFont.FlatAppearance.BorderSize = 0;
            this.fbtnFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFont.ForeColor = System.Drawing.Color.White;
            this.fbtnFont.Location = new System.Drawing.Point(631, 0);
            this.fbtnFont.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFont.Name = "fbtnFont";
            this.fbtnFont.Size = new System.Drawing.Size(62, 53);
            this.fbtnFont.TabIndex = 50;
            this.fbtnFont.TextColor = System.Drawing.Color.White;
            this.fbtnFont.UseVisualStyleBackColor = false;
            this.fbtnFont.Click += new System.EventHandler(this.fbtnFont_Click);
            // 
            // fbtnFontReducing
            // 
            this.fbtnFontReducing.BackColor = System.Drawing.Color.Transparent;
            this.fbtnFontReducing.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnFontReducing.BorderRadius = 22;
            this.fbtnFontReducing.BorderSize = 0;
            this.fbtnFontReducing.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnFontReducing.FlatAppearance.BorderSize = 0;
            this.fbtnFontReducing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnFontReducing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFontReducing.ForeColor = System.Drawing.Color.White;
            this.fbtnFontReducing.Image = global::NotePad.Properties.Resources.decrease;
            this.fbtnFontReducing.Location = new System.Drawing.Point(693, 0);
            this.fbtnFontReducing.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFontReducing.Name = "fbtnFontReducing";
            this.fbtnFontReducing.Size = new System.Drawing.Size(62, 53);
            this.fbtnFontReducing.TabIndex = 49;
            this.fbtnFontReducing.TextColor = System.Drawing.Color.White;
            this.fbtnFontReducing.UseVisualStyleBackColor = false;
            this.fbtnFontReducing.Click += new System.EventHandler(this.fbtnFontReducing_Click);
            // 
            // fbtnFontEnlargment
            // 
            this.fbtnFontEnlargment.BackColor = System.Drawing.Color.Transparent;
            this.fbtnFontEnlargment.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnFontEnlargment.BorderRadius = 22;
            this.fbtnFontEnlargment.BorderSize = 0;
            this.fbtnFontEnlargment.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnFontEnlargment.FlatAppearance.BorderSize = 0;
            this.fbtnFontEnlargment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnFontEnlargment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFontEnlargment.ForeColor = System.Drawing.Color.White;
            this.fbtnFontEnlargment.Image = global::NotePad.Properties.Resources.increase;
            this.fbtnFontEnlargment.Location = new System.Drawing.Point(755, 0);
            this.fbtnFontEnlargment.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFontEnlargment.Name = "fbtnFontEnlargment";
            this.fbtnFontEnlargment.Size = new System.Drawing.Size(62, 53);
            this.fbtnFontEnlargment.TabIndex = 48;
            this.fbtnFontEnlargment.TextColor = System.Drawing.Color.White;
            this.fbtnFontEnlargment.UseVisualStyleBackColor = false;
            this.fbtnFontEnlargment.Click += new System.EventHandler(this.fbtnFontEnlargment_Click);
            // 
            // fbtnUnderLine
            // 
            this.fbtnUnderLine.BackColor = System.Drawing.Color.Transparent;
            this.fbtnUnderLine.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnUnderLine.BorderRadius = 22;
            this.fbtnUnderLine.BorderSize = 0;
            this.fbtnUnderLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnUnderLine.FlatAppearance.BorderSize = 0;
            this.fbtnUnderLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnUnderLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnUnderLine.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnUnderLine.ForeColor = System.Drawing.Color.White;
            this.fbtnUnderLine.Location = new System.Drawing.Point(817, 0);
            this.fbtnUnderLine.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnUnderLine.Name = "fbtnUnderLine";
            this.fbtnUnderLine.Size = new System.Drawing.Size(62, 53);
            this.fbtnUnderLine.TabIndex = 47;
            this.fbtnUnderLine.TextColor = System.Drawing.Color.White;
            this.fbtnUnderLine.UseVisualStyleBackColor = false;
            this.fbtnUnderLine.Click += new System.EventHandler(this.fbtnUnderLine_Click);
            // 
            // fbtnBold
            // 
            this.fbtnBold.BackColor = System.Drawing.Color.Transparent;
            this.fbtnBold.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnBold.BorderRadius = 22;
            this.fbtnBold.BorderSize = 0;
            this.fbtnBold.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnBold.FlatAppearance.BorderSize = 0;
            this.fbtnBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnBold.ForeColor = System.Drawing.Color.White;
            this.fbtnBold.Location = new System.Drawing.Point(879, 0);
            this.fbtnBold.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnBold.Name = "fbtnBold";
            this.fbtnBold.Size = new System.Drawing.Size(62, 53);
            this.fbtnBold.TabIndex = 32;
            this.fbtnBold.TextColor = System.Drawing.Color.White;
            this.fbtnBold.UseVisualStyleBackColor = false;
            this.fbtnBold.Click += new System.EventHandler(this.fbtnBold_Click);
            // 
            // fbtnItalic
            // 
            this.fbtnItalic.BackColor = System.Drawing.Color.Transparent;
            this.fbtnItalic.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnItalic.BorderRadius = 22;
            this.fbtnItalic.BorderSize = 0;
            this.fbtnItalic.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnItalic.FlatAppearance.BorderSize = 0;
            this.fbtnItalic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnItalic.ForeColor = System.Drawing.Color.White;
            this.fbtnItalic.Location = new System.Drawing.Point(941, 0);
            this.fbtnItalic.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnItalic.Name = "fbtnItalic";
            this.fbtnItalic.Size = new System.Drawing.Size(62, 53);
            this.fbtnItalic.TabIndex = 31;
            this.fbtnItalic.TextColor = System.Drawing.Color.White;
            this.fbtnItalic.UseVisualStyleBackColor = false;
            this.fbtnItalic.Click += new System.EventHandler(this.fbtnItalic_Click);
            // 
            // fbtnStrikeOut
            // 
            this.fbtnStrikeOut.BackColor = System.Drawing.Color.Transparent;
            this.fbtnStrikeOut.BackgroundColor = System.Drawing.Color.Transparent;
            this.fbtnStrikeOut.BorderRadius = 22;
            this.fbtnStrikeOut.BorderSize = 0;
            this.fbtnStrikeOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbtnStrikeOut.FlatAppearance.BorderSize = 0;
            this.fbtnStrikeOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.fbtnStrikeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnStrikeOut.ForeColor = System.Drawing.Color.White;
            this.fbtnStrikeOut.Location = new System.Drawing.Point(1003, 0);
            this.fbtnStrikeOut.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnStrikeOut.Name = "fbtnStrikeOut";
            this.fbtnStrikeOut.Size = new System.Drawing.Size(62, 53);
            this.fbtnStrikeOut.TabIndex = 30;
            this.fbtnStrikeOut.TextColor = System.Drawing.Color.White;
            this.fbtnStrikeOut.UseVisualStyleBackColor = false;
            this.fbtnStrikeOut.Click += new System.EventHandler(this.fbtnStrikeOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1065, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 53);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pnlThemeMode
            // 
            this.pnlThemeMode.BackColor = System.Drawing.Color.White;
            this.pnlThemeMode.Controls.Add(this.fbtnDayMode);
            this.pnlThemeMode.Controls.Add(this.fbtnNightMode);
            this.pnlThemeMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThemeMode.Location = new System.Drawing.Point(1080, 0);
            this.pnlThemeMode.Margin = new System.Windows.Forms.Padding(4);
            this.pnlThemeMode.Name = "pnlThemeMode";
            this.pnlThemeMode.Size = new System.Drawing.Size(120, 53);
            this.pnlThemeMode.TabIndex = 90;
            // 
            // fbtnDayMode
            // 
            this.fbtnDayMode.BackColor = System.Drawing.Color.White;
            this.fbtnDayMode.BackgroundColor = System.Drawing.Color.White;
            this.fbtnDayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbtnDayMode.BorderRadius = 30;
            this.fbtnDayMode.BorderSize = 0;
            this.fbtnDayMode.FlatAppearance.BorderSize = 0;
            this.fbtnDayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnDayMode.ForeColor = System.Drawing.Color.White;
            this.fbtnDayMode.Location = new System.Drawing.Point(57, 4);
            this.fbtnDayMode.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnDayMode.Name = "fbtnDayMode";
            this.fbtnDayMode.Size = new System.Drawing.Size(44, 44);
            this.fbtnDayMode.TabIndex = 0;
            this.fbtnDayMode.TextColor = System.Drawing.Color.White;
            this.fbtnDayMode.UseVisualStyleBackColor = false;
            this.fbtnDayMode.Click += new System.EventHandler(this.fbtnDayMode_Click);
            // 
            // fbtnNightMode
            // 
            this.fbtnNightMode.BackColor = System.Drawing.Color.Black;
            this.fbtnNightMode.BackgroundColor = System.Drawing.Color.Black;
            this.fbtnNightMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbtnNightMode.BorderRadius = 30;
            this.fbtnNightMode.BorderSize = 0;
            this.fbtnNightMode.FlatAppearance.BorderSize = 0;
            this.fbtnNightMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnNightMode.ForeColor = System.Drawing.Color.White;
            this.fbtnNightMode.Location = new System.Drawing.Point(10, 4);
            this.fbtnNightMode.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnNightMode.Name = "fbtnNightMode";
            this.fbtnNightMode.Size = new System.Drawing.Size(44, 44);
            this.fbtnNightMode.TabIndex = 0;
            this.fbtnNightMode.TextColor = System.Drawing.Color.White;
            this.fbtnNightMode.UseVisualStyleBackColor = false;
            this.fbtnNightMode.Click += new System.EventHandler(this.fbtnNightMode_Click);
            // 
            // pbPadding
            // 
            this.pbPadding.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbPadding.Location = new System.Drawing.Point(1200, 0);
            this.pbPadding.Margin = new System.Windows.Forms.Padding(4);
            this.pbPadding.Name = "pbPadding";
            this.pbPadding.Size = new System.Drawing.Size(28, 53);
            this.pbPadding.TabIndex = 7;
            this.pbPadding.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlContent.Controls.Add(this.rtbContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 106);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30, 29, 30, 29);
            this.pnlContent.Size = new System.Drawing.Size(1228, 533);
            this.pnlContent.TabIndex = 5;
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.ForeColor = System.Drawing.Color.White;
            this.rtbContent.Location = new System.Drawing.Point(30, 29);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(4);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(1168, 475);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "We Shot feller as need shotin\'\nSave feller as need savin\'\nand feed\'em as need fee" +
    "din\'\n\"Dutch Van Der Linde\"";
            this.rtbContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtbContent_ContentsResized);
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 684);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlToolBar);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.frmNotePad_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNotePad_KeyDown);
            this.pnlTitle.ResumeLayout(false);
            this.pnlFileTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterPad1)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlThemeMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPadding)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.PictureBox pbAppIcon;
        private System.Windows.Forms.PictureBox pbPadding;
        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private RoundButton.FRoundButton fbtnPrint;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RoundButton.FRoundButton fbtnCut;
        private RoundButton.FRoundButton fbtnPaste;
        private RoundButton.FRoundButton fbtnCopy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RoundButton.FRoundButton fbtnLeftAlign;
        private RoundButton.FRoundButton fbtnMiddleAlign;
        private RoundButton.FRoundButton fbtnRightAlign;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundButton.FRoundButton fbtnFont;
        private RoundButton.FRoundButton fbtnFontReducing;
        private RoundButton.FRoundButton fbtnFontEnlargment;
        private RoundButton.FRoundButton fbtnUnderLine;
        private RoundButton.FRoundButton fbtnBold;
        private RoundButton.FRoundButton fbtnItalic;
        private RoundButton.FRoundButton fbtnStrikeOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton.FRoundButton fbtnOpenFromFile;
        private RoundButton.FRoundButton fbtnSaveToFile;
        private System.Windows.Forms.Panel pnlFileTitle;
        private RoundButton.FRoundButton fbtnAddNewTab;
        private System.Windows.Forms.Label lblFileName;
        private RoundButton.FRoundButton fbtnFileNameOption;
        private System.Windows.Forms.Label lblCoding;
        private System.Windows.Forms.PictureBox pbFooterPad5;
        private System.Windows.Forms.Label lblUnix;
        private System.Windows.Forms.PictureBox pbFooterPad4;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.PictureBox pbFooterPad3;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.PictureBox pbFooterPad2;
        private System.Windows.Forms.Label lblCharacterSize;
        private System.Windows.Forms.PictureBox pbFooterPad1;
        private FRoundPanel pnlThemeMode;
        private RoundButton.FRoundButton fbtnNightMode;
        private RoundButton.FRoundButton fbtnDayMode;
    }
}

