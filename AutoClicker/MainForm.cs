using AutoClicker.Utilites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        #region DLL Imports

        #region Mouse Events
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        #endregion

        #region Topmost Window
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        #endregion

        #region Draggable Panel

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

        #endregion

        #region Variable Declarations

        public int totalClicks = 0;

        public double timeout = 1;
        public double timeoutLeft = 0;
        public bool stopped = true;

        public int cpsUpdateInterval = 250;

        public Key toggleClickerKeybind = Key.F8;
        public Key toggleClickerAltKeybind = Key.None;

        public bool altKeyDown = false;
        public bool ctrlSameKey = false;

        public int[] ctrlKeys = new int[] { 118, 119 };

        public LowLevelKeyboardListener keyboardListener;
        public Thread clickerThread;

        public bool listeningForKeybind = false;
        public bool listeningForAltKeybind = false;

        public bool windowOnTop = true;

        Stopwatch sw;
        double timeLast = 0;

        #endregion

        #region Initialization

        public MainForm()
        {
            InitializeComponent();
            InitializeUserSettings();
            InitializeComponentSettings();

            new Thread(delegate () {
                Application.EnableVisualStyles();
                Application.Run(new CrosshairForm());
             }).Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegisterKeybinds();
            PrepareClickerThread();
            TopmostWindow();

            Debug.WriteLine(Properties.Settings.Default.TotalClicks);
        }

        public void InitializeUserSettings()
        {
            toggleClickerKeybind = (Key)Properties.Settings.Default.MainKeybind;
            toggleClickerAltKeybind = (Key)Properties.Settings.Default.AltKeybind;
            windowOnTop = Properties.Settings.Default.WindowTopmost;
            ctrlSameKey = Properties.Settings.Default.CtrlSameKey;
            timeout = Properties.Settings.Default.Timeout;
        }

        public void SaveUserSettings()
        {
            Properties.Settings.Default.MainKeybind = (int)toggleClickerKeybind;
            Properties.Settings.Default.AltKeybind = (int)toggleClickerAltKeybind;
            Properties.Settings.Default.WindowTopmost = windowOnTop;
            Properties.Settings.Default.CtrlSameKey = ctrlSameKey;
            Properties.Settings.Default.Timeout = timeout;
            Properties.Settings.Default.Save();
        }

        public void InitializeComponentSettings()
        {
            timeoutInput.Text = timeout.ToString();

            keybindButton.Text = (!ctrlKeys.Contains((int)toggleClickerKeybind) || ctrlSameKey) ? toggleClickerKeybind.ToString() : "Ctrl";
            altKeybindButton.Text = (!ctrlKeys.Contains((int)toggleClickerAltKeybind) || !ctrlSameKey) ? toggleClickerAltKeybind.ToString() : "Ctrl";

            windowAlwaysTopToolStripMenuItem.Checked = windowOnTop;
            ctrlSameKeyToolStripMenuItem.Checked = ctrlSameKey;

            startButton.Enabled = stopped;
            stopButton.Enabled = !stopped;

            totalClicksDisplay.Text = $"Total clicks: {totalClicks}";
            statusLabel.Text = (stopped) ? "Stopped" : "Clicking";

            cursorPosition.Text = $"Cursor location: ({(uint)Cursor.Position.X}, {(uint)Cursor.Position.Y})";

            statsTotalClicks.Text = Properties.Settings.Default.TotalClicks.ToString();
            statsPanel.Visible = false;
        }

        #endregion

        #region Program Logic

        public void TopmostWindow()
        {
            if (windowOnTop)
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        public void RegisterKeybinds()
        {
            keyboardListener = new LowLevelKeyboardListener();
            keyboardListener.OnKeyPressed += KeyDownEvent;
            keyboardListener.OnKeyUp += KeyUpEvent;
            keyboardListener.HookKeyboard();
        }

        public void PrepareClickerThread()
        {
            clickerThread = new Thread(ClickingThread);
            clickerThread.Start();
        }

        void KeyDownEvent(object sender, KeyPressedArgs e)
        {
            if (listeningForKeybind || listeningForAltKeybind)
            {
                SetKeyBind(e);
                return;
            }

            if (e.KeyPressed == toggleClickerAltKeybind || (ctrlSameKey && ctrlKeys.Contains((int)toggleClickerAltKeybind)))
                altKeyDown = true;

            if ((e.KeyPressed == toggleClickerKeybind || (ctrlSameKey && ctrlKeys.Contains((int)toggleClickerKeybind))) && (toggleClickerAltKeybind == Key.None || altKeyDown))
                ToggleClicking();
        }

        void KeyUpEvent(object sender, KeyPressedArgs e)
        {
            Debug.WriteLine(e.KeyPressed);

            if (e.KeyPressed == toggleClickerAltKeybind || (ctrlSameKey && ctrlKeys.Contains((int)toggleClickerAltKeybind)))
                altKeyDown = false;
        }

        public void SetKeyBind(KeyPressedArgs e)
        {
            
            if (e.KeyPressed != Key.Escape)
                if (listeningForKeybind) toggleClickerKeybind = e.KeyPressed;
                else toggleClickerAltKeybind = e.KeyPressed;
            else
                if (listeningForKeybind) toggleClickerKeybind = Key.None;
                else toggleClickerAltKeybind = Key.None;

            string keyName = e.KeyPressed.ToString();

            if (ctrlSameKey && ctrlKeys.Contains((int)e.KeyPressed))
                keyName = "Ctrl";

            if (listeningForKeybind) keybindButton.Text = keyName;
            if (listeningForAltKeybind) altKeybindButton.Text = keyName;

            listeningForKeybind = false;
            listeningForAltKeybind = false;

            SaveUserSettings();
        }

        public void ToggleClicking()
        {
            ToggleClicking(!stopped);
        }

        public void ToggleClicking(bool status)
        {
            stopped = status;

            startButton.Enabled = stopped;
            stopButton.Enabled = !stopped;

            statusLabel.Text = (stopped) ? "Stopped" : "Clicking";
        }

        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void ClickingThread()
        {
            sw = Stopwatch.StartNew();

            double cursorUpdateTimer = 0;
            double cpsUpdateTimer = 0;

            double cpsClickCounter = 0;

            while (true)
            {
                Thread.Sleep(1);

                double deltaTime = sw.Elapsed.TotalMilliseconds - timeLast;
                timeLast = sw.Elapsed.TotalMilliseconds;

                timeoutLeft -= deltaTime;
                cursorUpdateTimer -= deltaTime;
                cpsUpdateTimer -= deltaTime;

                if (cursorUpdateTimer < 0)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        UpdateCursorPosition();
                    });
                    cursorUpdateTimer = 30;
                }

                if (cpsUpdateTimer < 0)
                {
                    double CPS = cpsClickCounter * (1000/cpsUpdateInterval);
                    cpsClickCounter = 0;

                    this.BeginInvoke((Action)delegate ()
                    {
                        cpsDisplay.Text = $"{CPS} CPS";
                        statsTotalClicks.Text = (Properties.Settings.Default.TotalClicks + totalClicks).ToString();
                    });

                    cpsUpdateTimer = cpsUpdateInterval;
                }

                if (stopped || timeoutLeft > 0) continue;

                totalClicks++;
                DoMouseClick();
                cpsClickCounter++;

                this.BeginInvoke((Action)delegate ()
                {
                    UpdateClickDisplay();
                });

                timeoutLeft = timeout;
            }
        }

        #endregion

        #region UI Update Methods

        private void UpdateCursorPosition()
        {
            cursorPosition.Text = $"Cursor location: ({Cursor.Position.X}, {Cursor.Position.Y})";
        }

        private void UpdateClickDisplay()
        {
            totalClicksDisplay.Text = $"Total clicks: {totalClicks}";
        }

        #endregion

        #region UI Listeners

        private void startButton_Click(object sender, EventArgs e)
        {
            ToggleClicking(false);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ToggleClicking(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clickerThread.Suspend();
            Properties.Settings.Default.TotalClicks += totalClicks;
            Properties.Settings.Default.Save();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void keybindButton_Click(object sender, EventArgs e)
        {
            if (listeningForAltKeybind)
            {
                listeningForAltKeybind = false;
                altKeybindButton.Text = toggleClickerAltKeybind.ToString();
            }

            listeningForKeybind = true;
            keybindButton.Text = "Press any key...";
        }

        private void windowAlwaysTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowOnTop = !windowOnTop;

            if (windowOnTop) SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            else SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            windowAlwaysTopToolStripMenuItem.Checked = windowOnTop;
            SaveUserSettings();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (timeoutInput.Text.Length == 0) return;

            if (!double.TryParse(timeoutInput.Text, out double result))
                timeoutInput.Text = "";

            timeout = double.Parse(timeoutInput.Text.Replace('.', ','));
            Debug.WriteLine(timeout);
            timeoutLeft = 0;

            SaveUserSettings();
        }

        private void timeoutInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.Equals('.', e.KeyChar))
                e.Handled = true;

            if (timeoutInput.Text.Contains(".") && char.Equals('.', e.KeyChar))
                e.Handled = true;

            if (timeoutInput.Text.Length == 0) return;

            if (!char.IsControl(e.KeyChar) && timeoutInput.Text.Length > 5)
                e.Handled = true;

            if (!double.TryParse(timeoutInput.Text, out double result))
                timeoutInput.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void keybindPlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void altKeybindButton_Click(object sender, EventArgs e)
        {
            if (listeningForKeybind)
            {
                listeningForKeybind = false;
                keybindButton.Text = toggleClickerKeybind.ToString();
            }

            altKeyDown = false;

            listeningForAltKeybind = true;
            altKeybindButton.Text = "Press any key...";
        }

        private void ctrlSameKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlSameKey = !ctrlSameKey;

            ctrlSameKeyToolStripMenuItem.Checked = ctrlSameKey;

            keybindButton.Text = (!ctrlKeys.Contains((int)toggleClickerKeybind) || ctrlSameKey) ? toggleClickerKeybind.ToString() : "Ctrl";
            altKeybindButton.Text = (!ctrlKeys.Contains((int)toggleClickerAltKeybind) || !ctrlSameKey) ? toggleClickerAltKeybind.ToString() : "Ctrl";

            SaveUserSettings();
        }

        private void statsReturnButton_Click(object sender, EventArgs e)
        {
            statsPanel.Visible = false;
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statsPanel.Visible = !statsPanel.Visible;
        }
    }
}
