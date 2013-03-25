using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kanjimusou
{
    public partial class prompt : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;


        public prompt()
        {
            InitializeComponent();
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            DL.ADL.Close();
        }

        private void prompt_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doNotClose_Click(object sender, EventArgs e)
        {
            welcome Welcome = new welcome();
            Welcome.Show();
        }
    }
}
