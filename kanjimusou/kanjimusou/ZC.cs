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
using System.Threading;

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
        User Auser;

        public ZC()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            try
            {
                Auser = UserManager.Register(this.Username.Text, this.passwd1.Text);
                DL.ADL.Visible = false;
                success hehe = new success();
                hehe.Show();
                this.Visible = false;
                Thread.Sleep(500);
                welcome Awelcome = new welcome(Auser);
                Awelcome.Show();
                hehe.Close();
                this.Close();
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
            Sound.PlaySE("se_buttonclick");
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
