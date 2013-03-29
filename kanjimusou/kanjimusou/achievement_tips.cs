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
    public partial class achievement_tips : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;

        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public achievement_tips()
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
        }
        public achievement_tips(string tip):this()
        {
            this.arcInfo.Text = tip;
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.05;
            if (showing)
            {
                if (Opacity + d >= 0.9)
                {
                    Opacity = 0.9;
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

        private void achievement_tips_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void closee_Click(object sender, EventArgs e)
        {
            this.OnClose(true);
        }

        public void OnShow()
        {
            this.Show();
            Sound.PlaySE("se_achievementfinish");
            showing = true;
            Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时
            this.Enabled = true;
        }

        public void OnClose(bool doClose)
        {
            this.doClose = doClose;
            this.Enabled = false;
            showing = false;
            Atimer.Start();
        }

    }
}
