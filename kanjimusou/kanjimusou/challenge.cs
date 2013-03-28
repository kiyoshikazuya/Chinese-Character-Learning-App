using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanjimusou.Lib;

namespace Kanjimusou
{
    public partial class challenge : Form
    {

        private User user;
        private Challenge cha;

        private bool showing = true;
        private bool doClose = true;
        private int timeMaxLength;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public challenge( User user )
        {
            InitializeComponent();
            this.user = user;
            this.cha = new Challenge(user);
            Hanzi Ahanzi = HanziIO.Read("中");
            hanziPictureBox1.Hanzi = Ahanzi;
            hanziPictureBox1.Completed += cha.OnFinishHanzi;
            cha.FinishLevel += OnFinishLevel;
            cha.FinishLevel += user.Achievement.OnFinishLevel;
            cha.Lose += OnLose;
   
            next.Visible = true;
            next.Enabled = true;
            timer1.Interval = 25;
            timeMaxLength = resttime.Width;
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.03;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.resttime.Width = (int)(timeMaxLength*
                (cha.NowTime)/cha.NowMaxTime);
        }

        private void next_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            next.Enabled = false;
            cha.NextLevel();
            hanziPictureBox1.Hanzi = cha.NowZi;
            nowLevel.Text = cha.NowLevel.ToString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            welcome Welcome = new welcome(user);
            this.OnClose(true);
            Welcome.OnShow();
        }

        void OnFinishLevel(int lvl)
        {
            timer1.Stop();
            if (next.InvokeRequired)
            {
                next.Invoke(new Action<int>(OnFinishLevel), lvl);
            }
            else
            {
                next.Enabled = true;
            }
        }

        void OnLose(int lvl)
        {
            timer1.Stop();
            if (next.InvokeRequired)
            {
                next.Invoke(new Action<int>(OnFinishLevel), lvl);
            }
            else
            {
                next.Enabled = true;
            }


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
            Sound.PlayBGM("bgm_challenge");
            this.Enabled = true;
        }

        public void OnClose(bool doClose)
        {
            Sound.StopBGM();
            this.doClose = doClose;
            showing = false;
            Atimer.Start();
        }

    }
}
