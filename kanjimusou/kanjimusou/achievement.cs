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
    public partial class achievement : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;
        public User Auser;

        public achievement()
        {
            InitializeComponent();
            //课程
            //今日
            //总
        }
        public achievement(User A)
            : this()
        {
            Auser = A;
            this.nameOfAch.Text = Auser.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            prompt Apro = new prompt(this,Auser);
            Apro.Show();
        }

        private void achievement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void share_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            prompt Apro = new prompt(this,Auser);
            Apro.Show();
        }


    }
}
