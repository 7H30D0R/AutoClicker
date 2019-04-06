namespace AutoClicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowAlwaysTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cpsDisplay = new System.Windows.Forms.Label();
            this.timeoutInput = new System.Windows.Forms.TextBox();
            this.cursorPosition = new System.Windows.Forms.Label();
            this.totalClicksDisplay = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.keybindButton = new System.Windows.Forms.Button();
            this.keybindLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wrapperPanel = new System.Windows.Forms.Panel();
            this.altKeybindButton = new System.Windows.Forms.Button();
            this.keybindPlusLabel = new System.Windows.Forms.Label();
            this.ctrlSameKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.statsTitle = new System.Windows.Forms.Label();
            this.statsTotalClicksLabel = new System.Windows.Forms.Label();
            this.statsTotalClicks = new System.Windows.Forms.Label();
            this.statsReturnButton = new System.Windows.Forms.Button();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.wrapperPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 21);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(260, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fileToolStripMenuItem.BackgroundImage = global::AutoClicker.Properties.Resources.bg;
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowAlwaysTopToolStripMenuItem,
            this.ctrlSameKeyToolStripMenuItem});
            this.optionsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // windowAlwaysTopToolStripMenuItem
            // 
            this.windowAlwaysTopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.windowAlwaysTopToolStripMenuItem.Checked = true;
            this.windowAlwaysTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windowAlwaysTopToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.windowAlwaysTopToolStripMenuItem.Name = "windowAlwaysTopToolStripMenuItem";
            this.windowAlwaysTopToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.windowAlwaysTopToolStripMenuItem.Text = "Window Always Top";
            this.windowAlwaysTopToolStripMenuItem.Click += new System.EventHandler(this.windowAlwaysTopToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainPanel.Controls.Add(this.keybindPlusLabel);
            this.mainPanel.Controls.Add(this.altKeybindButton);
            this.mainPanel.Controls.Add(this.cpsDisplay);
            this.mainPanel.Controls.Add(this.timeoutInput);
            this.mainPanel.Controls.Add(this.cursorPosition);
            this.mainPanel.Controls.Add(this.totalClicksDisplay);
            this.mainPanel.Controls.Add(this.statusLabel);
            this.mainPanel.Controls.Add(this.keybindButton);
            this.mainPanel.Controls.Add(this.keybindLabel);
            this.mainPanel.Controls.Add(this.stopButton);
            this.mainPanel.Controls.Add(this.startButton);
            this.mainPanel.Controls.Add(this.timeoutLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(260, 195);
            this.mainPanel.TabIndex = 1;
            // 
            // cpsDisplay
            // 
            this.cpsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.cpsDisplay.ForeColor = System.Drawing.Color.White;
            this.cpsDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cpsDisplay.Location = new System.Drawing.Point(14, 27);
            this.cpsDisplay.Name = "cpsDisplay";
            this.cpsDisplay.Size = new System.Drawing.Size(231, 15);
            this.cpsDisplay.TabIndex = 11;
            this.cpsDisplay.Text = "0 CPS";
            this.cpsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeoutInput
            // 
            this.timeoutInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.timeoutInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeoutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.timeoutInput.ForeColor = System.Drawing.Color.White;
            this.timeoutInput.Location = new System.Drawing.Point(132, 52);
            this.timeoutInput.Name = "timeoutInput";
            this.timeoutInput.Size = new System.Drawing.Size(113, 18);
            this.timeoutInput.TabIndex = 10;
            this.timeoutInput.Text = "1";
            this.timeoutInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.timeoutInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeoutInput_KeyPress);
            // 
            // cursorPosition
            // 
            this.cursorPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorPosition.ForeColor = System.Drawing.Color.White;
            this.cursorPosition.Location = new System.Drawing.Point(15, 168);
            this.cursorPosition.Name = "cursorPosition";
            this.cursorPosition.Size = new System.Drawing.Size(231, 17);
            this.cursorPosition.TabIndex = 9;
            this.cursorPosition.Text = "Cursor location: (x, y)";
            this.cursorPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalClicksDisplay
            // 
            this.totalClicksDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalClicksDisplay.ForeColor = System.Drawing.Color.White;
            this.totalClicksDisplay.Location = new System.Drawing.Point(14, 7);
            this.totalClicksDisplay.Name = "totalClicksDisplay";
            this.totalClicksDisplay.Size = new System.Drawing.Size(231, 25);
            this.totalClicksDisplay.TabIndex = 1;
            this.totalClicksDisplay.Text = "Total clicks: 0";
            this.totalClicksDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(14, 112);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(231, 25);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Stopped";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keybindButton
            // 
            this.keybindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.keybindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keybindButton.ForeColor = System.Drawing.Color.White;
            this.keybindButton.Location = new System.Drawing.Point(196, 83);
            this.keybindButton.Name = "keybindButton";
            this.keybindButton.Size = new System.Drawing.Size(50, 22);
            this.keybindButton.TabIndex = 7;
            this.keybindButton.Text = "F8";
            this.keybindButton.UseVisualStyleBackColor = false;
            this.keybindButton.Click += new System.EventHandler(this.keybindButton_Click);
            // 
            // keybindLabel
            // 
            this.keybindLabel.ForeColor = System.Drawing.Color.White;
            this.keybindLabel.Location = new System.Drawing.Point(15, 83);
            this.keybindLabel.Name = "keybindLabel";
            this.keybindLabel.Size = new System.Drawing.Size(114, 20);
            this.keybindLabel.TabIndex = 6;
            this.keybindLabel.Text = "Start / Stop Keybind";
            this.keybindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(132, 142);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(114, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop clicking";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(12, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start clicking";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.ForeColor = System.Drawing.Color.White;
            this.timeoutLabel.Location = new System.Drawing.Point(12, 50);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(114, 20);
            this.timeoutLabel.TabIndex = 2;
            this.timeoutLabel.Text = "Timeout (ms)";
            this.timeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 21);
            this.panel1.TabIndex = 2;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(215, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(21, 21);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "_";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(239, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 21);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Clicker by 7H30D0R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.Controls.Add(this.statsPanel);
            this.wrapperPanel.Controls.Add(this.mainPanel);
            this.wrapperPanel.Controls.Add(this.menuStrip);
            this.wrapperPanel.Controls.Add(this.panel1);
            this.wrapperPanel.Location = new System.Drawing.Point(1, 1);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(260, 240);
            this.wrapperPanel.TabIndex = 3;
            // 
            // altKeybindButton
            // 
            this.altKeybindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.altKeybindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.altKeybindButton.ForeColor = System.Drawing.Color.White;
            this.altKeybindButton.Location = new System.Drawing.Point(129, 82);
            this.altKeybindButton.Name = "altKeybindButton";
            this.altKeybindButton.Size = new System.Drawing.Size(51, 23);
            this.altKeybindButton.TabIndex = 12;
            this.altKeybindButton.Text = "F8";
            this.altKeybindButton.UseVisualStyleBackColor = false;
            this.altKeybindButton.Click += new System.EventHandler(this.altKeybindButton_Click);
            // 
            // keybindPlusLabel
            // 
            this.keybindPlusLabel.ForeColor = System.Drawing.Color.White;
            this.keybindPlusLabel.Location = new System.Drawing.Point(183, 83);
            this.keybindPlusLabel.Name = "keybindPlusLabel";
            this.keybindPlusLabel.Size = new System.Drawing.Size(10, 20);
            this.keybindPlusLabel.TabIndex = 13;
            this.keybindPlusLabel.Text = "+";
            this.keybindPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keybindPlusLabel.Click += new System.EventHandler(this.keybindPlusLabel_Click);
            // 
            // ctrlSameKeyToolStripMenuItem
            // 
            this.ctrlSameKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ctrlSameKeyToolStripMenuItem.Checked = true;
            this.ctrlSameKeyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctrlSameKeyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ctrlSameKeyToolStripMenuItem.Name = "ctrlSameKeyToolStripMenuItem";
            this.ctrlSameKeyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ctrlSameKeyToolStripMenuItem.Text = "Ctrl Same Key";
            this.ctrlSameKeyToolStripMenuItem.Click += new System.EventHandler(this.ctrlSameKeyToolStripMenuItem_Click);
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.statsPanel.Controls.Add(this.statsReturnButton);
            this.statsPanel.Controls.Add(this.statsTotalClicks);
            this.statsPanel.Controls.Add(this.statsTotalClicksLabel);
            this.statsPanel.Controls.Add(this.statsTitle);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(0, 45);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(260, 195);
            this.statsPanel.TabIndex = 14;
            this.statsPanel.Visible = false;
            // 
            // statsTitle
            // 
            this.statsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTitle.ForeColor = System.Drawing.Color.White;
            this.statsTitle.Location = new System.Drawing.Point(3, 9);
            this.statsTitle.Name = "statsTitle";
            this.statsTitle.Size = new System.Drawing.Size(257, 23);
            this.statsTitle.TabIndex = 0;
            this.statsTitle.Text = "Statistics";
            this.statsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsTotalClicksLabel
            // 
            this.statsTotalClicksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTotalClicksLabel.ForeColor = System.Drawing.Color.White;
            this.statsTotalClicksLabel.Location = new System.Drawing.Point(3, 56);
            this.statsTotalClicksLabel.Name = "statsTotalClicksLabel";
            this.statsTotalClicksLabel.Size = new System.Drawing.Size(257, 23);
            this.statsTotalClicksLabel.TabIndex = 1;
            this.statsTotalClicksLabel.Text = "Total Clicks (all time)";
            this.statsTotalClicksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsTotalClicks
            // 
            this.statsTotalClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTotalClicks.ForeColor = System.Drawing.Color.White;
            this.statsTotalClicks.Location = new System.Drawing.Point(3, 79);
            this.statsTotalClicks.Name = "statsTotalClicks";
            this.statsTotalClicks.Size = new System.Drawing.Size(257, 23);
            this.statsTotalClicks.TabIndex = 2;
            this.statsTotalClicks.Text = "0";
            this.statsTotalClicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsReturnButton
            // 
            this.statsReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.statsReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statsReturnButton.ForeColor = System.Drawing.Color.White;
            this.statsReturnButton.Location = new System.Drawing.Point(79, 152);
            this.statsReturnButton.Name = "statsReturnButton";
            this.statsReturnButton.Size = new System.Drawing.Size(114, 23);
            this.statsReturnButton.TabIndex = 6;
            this.statsReturnButton.Text = "Return to main panel";
            this.statsReturnButton.UseVisualStyleBackColor = false;
            this.statsReturnButton.Click += new System.EventHandler(this.statsReturnButton_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(262, 242);
            this.Controls.Add(this.wrapperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Auto Clicker - 7H30D0R";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.wrapperPanel.ResumeLayout(false);
            this.wrapperPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label totalClicksDisplay;
        private System.Windows.Forms.Label keybindLabel;
        private System.Windows.Forms.Button keybindButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label cursorPosition;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowAlwaysTopToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox timeoutInput;
        private System.Windows.Forms.Label cpsDisplay;
        private System.Windows.Forms.Panel wrapperPanel;
        private System.Windows.Forms.Button altKeybindButton;
        private System.Windows.Forms.Label keybindPlusLabel;
        private System.Windows.Forms.ToolStripMenuItem ctrlSameKeyToolStripMenuItem;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label statsTotalClicks;
        private System.Windows.Forms.Label statsTotalClicksLabel;
        private System.Windows.Forms.Label statsTitle;
        private System.Windows.Forms.Button statsReturnButton;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
    }
}

