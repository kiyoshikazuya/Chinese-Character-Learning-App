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
    public partial class welcome : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;
        User Auser;

        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public welcome()
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
        }

        public welcome(User A):this()
        {
            Auser = A;
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            this.userName.Text = Auser.Username;
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.02;
            if (showing)
            {
                if (Opacity + d >= 0.9)
                {
                    Opacity = 0.85;
                    Atimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {

                if (Opacity - d <= 0.0)
                {
                    Opacity = 0.0;
                    Atimer.Stop();
                    if (doClose) this.Close();
                    else this.Visible = false;
                }
                else
                {
                    Opacity -= d;
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            learn Learn = new learn(Auser);
            Learn.OnShow();
            this.OnClose(true);
        }

        private void information_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            achievement Achievement = new achievement(Auser);
            Achievement.Shown += new EventHandler(BlockWindow);
            Achievement.FormClosed += new FormClosedEventHandler(UnblockWindow);
            Achievement.OnShow();
        }

        private void welcome_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            DL.ADL.OnShow();
            this.OnClose(true);
        }

        void UnblockWindow(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        void BlockWindow(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        public void OnShow()
        {
            this.Show();
            showing = true;
            Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时
            if (!Sound.IsPlayingBGM) Sound.PlayBGM("bgm_opening");
            this.Enabled = true;
        }

        public void OnClose(bool doClose)
        {
            this.doClose = doClose;
            showing = false;
            Atimer.Start();
        }


    }
}
