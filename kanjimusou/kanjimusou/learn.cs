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
    public partial class learn : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;

        List<Hanzi> Ahanzilist = new List<Hanzi>(HanziIO.ReadAll());

        static public User Auser;
        static public Hanzi Ahanzi;
        int i = 0;

        public static learn Ale;

        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public learn()
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            Ale = this;
            Ahanzi = HanziIO.Read(Ahanzilist[i].Zi);
            this.hanziPictureBox1.Hanzi = Ahanzi;
            hanziPictureBox1.CorrectDrew += new BihuaHandler(OnCorrectDrew);
            hanziPictureBox1.WrongDrew += new BihuaHandler(OnWrongDrew);
            hanziPictureBox1.Completed += new BihuaHandler(OnCompleted);
            this.paraphrase.Text = Ahanzi.Info;
            this.infoLabel.Text = "已成功载入汉字 " + "'" + Ahanzi.Zi + "'";
        }

        public learn(User A)
        {
            Auser = A;
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            Ale = this;
            Ahanzi = HanziIO.Read(Ahanzilist[i].Zi);
            this.hanziPictureBox1.Hanzi = Ahanzi;
            hanziPictureBox1.CorrectDrew += new BihuaHandler(OnCorrectDrew);
            hanziPictureBox1.WrongDrew += new BihuaHandler(OnWrongDrew);
            hanziPictureBox1.Completed += new BihuaHandler(OnCompleted);
            this.paraphrase.Text = Ahanzi.Info;
            this.infoLabel.Text = "已成功载入汉字 " + "'" + Ahanzi.Zi + "'";
        }

        public learn(User A,Hanzi H)
        {
            Auser = A;
            Ahanzi = H;
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            Ale = this;
            this.hanziPictureBox1.Hanzi = Ahanzi;
            hanziPictureBox1.CorrectDrew += new BihuaHandler(OnCorrectDrew);
            hanziPictureBox1.WrongDrew += new BihuaHandler(OnWrongDrew);
            hanziPictureBox1.Completed += new BihuaHandler(OnCompleted);
            this.paraphrase.Text = Ahanzi.Info;
            this.infoLabel.Text = "已成功载入汉字 " + "'" + Ahanzi.Zi + "'";
        }

        public void OnCorrectDrew(Object sender, HanziEventArgs e)
        {
            infoLabel.Text = String.Format("成功画了一笔，已画了{0}画", e.Bihuashu);
        }

        public void OnWrongDrew(Object sender, HanziEventArgs e)
        {
            infoLabel.Text = String.Format("错误的一笔，已画了{0}画", e.Bihuashu);
        }

        public void OnCompleted(Object sender, HanziEventArgs e)
        {
            infoLabel.Text = String.Format("已完成整个汉字");
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.UndoDraw();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.ClearDraw();
        }

        private void tips_Click(object sender, EventArgs e)
        {
            if (this.hanziPictureBox1.IsShowHelper) this.hanziPictureBox1.IsShowHelper = false;
            else this.hanziPictureBox1.IsShowHelper = true;
            hanziPictureBox1.Refresh();
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

        private void learn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);

        }

        private void close_it_Click(object sender, EventArgs e)
        {   
            Sound.PlaySE("se_buttonclick");
            prompt Prompt = new prompt(this,Auser);
            Prompt.Shown += BlockWindow;
            Prompt.FormClosed += UnblockWindow;
            Prompt.OnShow();
        }

        private void next_Click(object sender, EventArgs e)
        {   
            Sound.PlaySE("se_buttonclick");
           
            try
            {
                if (i+1 >= Ahanzilist.Count())
                    throw new UserException("已学完当前所有课程！");
                Ahanzi = HanziIO.Read(Ahanzilist[++i].Zi);
                this.hanziPictureBox1.Hanzi = Ahanzi;
                this.paraphrase.Text = Ahanzi.Info;
                this.infoLabel.Text = "已成功载入汉字 " + "'" + Ahanzi.Zi + "'";
            }

            catch (UserException A)
            {
                wrong Awrong = new wrong(A.Message);
                Awrong.OnShow();
            }
            
        }

        private void sound_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            if (Sound.IsPlayingBGM) Sound.StopBGM(); 
            else Sound.PlayBGM("bgm_study");
        }

        private void more_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            string link = "http://zh.wikipedia.org/wiki/" + Ahanzi.Zi;
            System.Diagnostics.Process.Start("iexplore.exe", link); 
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
            Sound.PlayBGM("bgm_study");
            this.Enabled = true;
        }

        public void OnClose(bool doClose)
        {
            Sound.StopBGM();
            this.doClose = doClose;
            showing = false;
            Atimer.Start();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");

            try
            {
                if (i - 1 < 0 )
                    throw new UserException("已返回字表顶端！");
                Ahanzi = HanziIO.Read(Ahanzilist[--i].Zi);
                this.hanziPictureBox1.Hanzi = Ahanzi;
                this.paraphrase.Text = Ahanzi.Info;
                this.infoLabel.Text = "已成功载入汉字 " + "'" + Ahanzi.Zi + "'";
            }

            catch (UserException A)
            {
                wrong Awrong = new wrong(A.Message);
                Awrong.OnShow();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Image TheHanzi = hanziPictureBox1.DrawImage;
            //TheHanzi.Save(, ImageFormat.Png);
            //TheHanzi.Dispose();

        }

    }
}
