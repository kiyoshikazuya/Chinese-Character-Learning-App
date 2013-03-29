using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
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

        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public achievement()
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
        }

        public achievement(User A)
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            Auser = A;
            this.nameOfAch.Text = Auser.Username;

            if (Auser.LearnLog.Count == 0) label1.Visible = true;
            else label1.Visible = false;

            int tmp = Auser.LearnLog.Count;
            if ((tmp - 4 >= 0) && Auser.LearnLog.Keys.ElementAt(tmp - 4) != null)
            {
                pictureBox1.Image = new Bitmap(
                    Auser.LearnLog[Auser.LearnLog.Keys.ElementAt(tmp-4)].ImageList[0],
                    new Size(pictureBox1.Width, pictureBox1.Height));
            }
            if ((tmp - 3 >= 0) && Auser.LearnLog.Keys.ElementAt(tmp - 3) != null)
            {
                pictureBox2.Image = new Bitmap(
                    Auser.LearnLog[Auser.LearnLog.Keys.ElementAt(tmp - 3)].ImageList[0],
                    new Size(pictureBox2.Width, pictureBox2.Height));
            }
            if ((tmp - 2 >= 0) && Auser.LearnLog.Keys.ElementAt(tmp - 2) != null)
            {
                pictureBox3.Image = new Bitmap(
                    Auser.LearnLog[Auser.LearnLog.Keys.ElementAt(tmp - 2)].ImageList[0],
                    new Size(pictureBox3.Width, pictureBox3.Height));
            }
            if ((tmp - 1 >= 0) && Auser.LearnLog.Keys.ElementAt(tmp - 1) != null)
            {
                pictureBox4.Image = new Bitmap(
                    Auser.LearnLog[Auser.LearnLog.Keys.ElementAt(tmp - 1)].ImageList[0],
                    new Size(pictureBox4.Width, pictureBox4.Height));
            }

            foreach (AchievementElement achE in Auser.Achievement.ArcList)
            {
                arcListBox.Items.Add(achE.ArcInfo);
            }

            maxLevel.Text = Auser.MaxReachedLevel.ToString();



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

        private void button1_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick"); 
            this.OnClose(true);
        }

        private void achievement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void share_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            saveFileDialog1.ShowDialog();
            Image image = new Bitmap(Width, Height, CreateGraphics());
            Graphics g = Graphics.FromImage(image);
            Opacity = 1;
            share.Hide();
            g.CopyFromScreen(Location.X, Location.Y, 0, 0, Size);
            Opacity = 0.9;
            share.Show();
            try
            {
                image.Save(saveFileDialog1.FileName);
            }
            catch (ExternalException ex)
            {
            }
            catch (ArgumentException ex)
            {
            }
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
            this.Enabled = false;
            showing = false;
            Atimer.Start();
        }

    }

}
