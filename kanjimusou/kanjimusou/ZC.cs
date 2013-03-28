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
        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public ZC()
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.05;
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

        private void submit_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            try
            {
                Auser = UserManager.Register(this.Username.Text, this.passwd1.Text);
                this.OnClose(true);
                DL.ADL.OnClose(false);
                Auser.Achievement.AchievementReach += DL.ADL.OnAchievementReach;
                Auser.FinishHanzi += Auser.Achievement.OnFinishHanzi;
                welcome Awelcome = new welcome(Auser);
                Awelcome.OnShow();
                
            }
            catch (UserException a)
            {
                wrong Wrong = new wrong(a.Message);
                Wrong.OnShow();
             
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
            this.OnClose(true);
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

        public void OnShow()
        {
            this.Show();
            showing = true;
            Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时
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
