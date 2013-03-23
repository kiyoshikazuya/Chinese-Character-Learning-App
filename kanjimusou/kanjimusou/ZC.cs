using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kanjimusou.Lib;

namespace Kanjimusou
{
    public partial class ZC : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;


        public ZC()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager.Register(this.Username.Text, this.passwd1.Text);
            }
            catch (UserException a)
            {
                wrong Wrong = new wrong(a.Message);
                Wrong.Show();
            }
        }

        private void logon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwd2_TextChanged(object sender, EventArgs e)
        {
            
            if (passwd1.Text == passwd2.Text)
            {
                this.Error.Visible = false;
                this.submit.Visible = true;
            }
        }

        private void passwd1_TextChanged(object sender, EventArgs e)
        {
            this.Error.Visible = true;
        }
    }
}
