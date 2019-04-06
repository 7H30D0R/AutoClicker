using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public class CrosshairForm : Form
    {

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

        public PictureBox pictureBox;
        public bool active = true;

        public CrosshairForm()
        {

            var img = new Bitmap(@"C:\Users\marcu\Pictures\unknown.png");

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            pictureBox = new PictureBox();
            //this.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            pictureBox.Image = img;
            pictureBox.Width = img.Width;
            pictureBox.Height = img.Height;
            pictureBox.Click += new EventHandler(onClick);
            //pictureBox.Dock = DockStyle.Fill;
            //this.Controls.Add(pictureBox);
            this.TopMost = true;
            this.Cursor = Cursors.Hand;
            this.ShowInTaskbar = false;

            FirstControl fc = new FirstControl();
            fc.Width = Screen.PrimaryScreen.Bounds.Width;
            fc.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Controls.Add(fc);

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            /*new Thread(delegate ()
            {
                while (active) {
                    Thread.Sleep(25);
                    this.BeginInvoke((Action)delegate ()
                    {
                        pictureBox.Location = new Point(Cursor.Position.X - (int)(img.Width / 2), Cursor.Position.Y - (int)(img.Height / 2));
                    });
                }
            }).Start();*/
        }

        public void onClick(object sender, EventArgs e)
        {
            active = false;
            Close();
        }
    }

    public class FirstControl : Control
    {
        public FirstControl() {
            new Thread(delegate ()
            {
                while (true)
                {
                    Thread.Sleep(25);
                    this.BeginInvoke((Action)delegate ()
                    {
                        this.Invalidate();
                    });
                }
            }).Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(e);
            // Call methods of the System.Drawing.Graphics object.  
            e.Graphics.DrawString("lololol", Font, new SolidBrush(ForeColor), ClientRectangle);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255,0,0)), new Rectangle(Cursor.Position.X, 0, 2, Screen.PrimaryScreen.Bounds.Height));
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), new Rectangle(0, Cursor.Position.Y, Screen.PrimaryScreen.Bounds.Width, 2));

            e.Graphics.Flush();
        }
    }
}
